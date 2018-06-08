using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ExtraerPDFCarteroOmega
{
    public partial class frmMain : Form
    {
        private System.Data.DataTable Listado;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExtraerUnico_Click(object sender, EventArgs e)
        {
            try
            {
                sfd.ShowDialog(this);

                if (Directory.Exists(Path.GetDirectoryName(sfd.FileName)))
                {
                    ResultadoStored_Str Resultado = clsBD.ExtraerPDF(Convert.ToInt32(numId.Value), Path.GetDirectoryName(sfd.FileName), Path.GetFileName(sfd.FileName));

                    if (!Resultado.HayError)
                        MessageBox.Show("Proceso finalizado", "Exportación única", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(Resultado.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("El directorio no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ResultadoStored_DT Resultado = clsBD.ObtenerListado();

            if (Resultado.HayError)
            {
                MessageBox.Show(Resultado.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            Listado = new DataTable();
            Listado = Resultado.Resultado;
            lblConteoCartas.Text = "Cartas generadas en el sistema: " + Listado.Rows.Count.ToString();
        }

        private void btnExtraerTodo_Click(object sender, EventArgs e)
        {
            fbd.ShowDialog(this);

            if (Directory.Exists(fbd.SelectedPath))
            {
                bool HuboErrores = false;

                for (int w = 0; w < Listado.Rows.Count; w++)
                {
                    int Cart_Id = 0;

                    int.TryParse(Listado.Rows[w][0].ToString(), out Cart_Id);
                    ResultadoStored_Str Resultado = clsBD.ExtraerPDF(Cart_Id, fbd.SelectedPath);

                    if (!Resultado.HayError)
                    {
                        lstLog.Items.Add(DateTime.Now.ToString("HH:mm:ss") + "\t" + "Archivo generado correctamente: " + Cart_Id.ToString() + ".pdf");
                    }
                    else
                    {
                        lstLog.Items.Add(DateTime.Now.ToString("HH:mm:ss") + "\t" + "Error al generar archivo: " + Cart_Id.ToString() + ".pdf | Detalle del error: " + Resultado.Error);
                        HuboErrores = true;
                    }
                }

                if(!HuboErrores)
                    MessageBox.Show("Proceso finalizado", "Exportación masiva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Consulte log para ver los detalles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("El directorio no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

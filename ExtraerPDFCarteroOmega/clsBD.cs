using System;
using System.Data;
using System.Data.SqlClient;

namespace ExtraerPDFCarteroOmega
{
    public class clsBD
    {
        private const string Cnx = "Data Source=hdatacenter1;Initial Catalog=BD_Omega;User Id=usr_omega;Password=Casita12;";
        private const string QueryBase = "SELECT Cart_Archivo FROM Cartero_CartasGeneradas WHERE Cart_Id = @Cart_Id";
        private const string QueryListado = "SELECT Cart_Id FROM Cartero_CartasGeneradas";

        public static ResultadoStored_Str ExtraerPDF(int Cart_Id, string Ruta, string NombreArchivo = "", bool DevolverError = true, int TimeOut = 0)
        {
            ResultadoStored_Str Resultado = new ResultadoStored_Str(string.Empty, string.Empty, false);
            SqlConnection cn = null;
            SqlCommand cmd = null;
            SqlParameter param = null;

            try
            {
                cn = new SqlConnection(Cnx);
                cmd = new SqlCommand(QueryBase, cn);
                cmd.CommandType = CommandType.Text;

                param = new SqlParameter("@Cart_Id", SqlDbType.Int);
                param.Value = Cart_Id;
                cmd.Parameters.Add(param);

                cn.Open();

                if (TimeOut > 0)
                    cmd.CommandTimeout = TimeOut;

                using (SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (rdr.Read())
                    {
                        string Archivo = System.IO.Path.Combine(Ruta, Cart_Id.ToString() + ".pdf");
                        byte[] buffer = (byte[])rdr["Cart_Archivo"];

                        if (NombreArchivo != string.Empty)
                            Archivo = System.IO.Path.Combine(Ruta, NombreArchivo);

                        if (System.IO.File.Exists(Archivo))
                            System.IO.File.Delete(Archivo);

                        System.IO.File.WriteAllBytes(Archivo, buffer);
                    }

                    rdr.Close();
                }
            }
            catch (Exception ex)
            {
                Resultado.HayError = true;
                Resultado.Resultado = string.Empty;

                if (DevolverError)
                    Resultado.Error = "Error: " + ex.Message;
                else
                    Resultado.Error = string.Empty;
            }

            return Resultado;
        }

        public static ResultadoStored_DT ObtenerListado(bool DevolverError = true, int TimeOut = 0)
        {
            ResultadoStored_DT Resultado = new ResultadoStored_DT(new DataTable("Resultado"), string.Empty, false);
            SqlConnection cn = null;
            SqlCommand cmd = null;

            try
            {
                cn = new SqlConnection(Cnx);
                cmd = new SqlCommand(QueryListado, cn);
                cmd.CommandType = CommandType.Text;

                cn.Open();

                if (TimeOut > 0)
                    cmd.CommandTimeout = TimeOut;

                Resultado.Resultado.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
            }
            catch (Exception ex)
            {
                Resultado.HayError = true;
                Resultado.Resultado = new DataTable("Error");

                if (DevolverError)
                    Resultado.Error = "Error: " + ex.Message;
                else
                    Resultado.Error = string.Empty;
            }

            return Resultado;
        }
    }

    public struct ResultadoStored_Str
    {
        public string Resultado;
        public string Error;
        public bool HayError;

        public ResultadoStored_Str(string vResultado, string vError, bool vHayError)
        {
            Resultado = vResultado;
            Error = vError;
            HayError = vHayError;
        }
    }

    public struct ResultadoStored_DT
    {
        public DataTable Resultado;
        public string Error;
        public bool HayError;

        public ResultadoStored_DT(DataTable vResultado, string vError, bool vHayError)
        {
            Resultado = vResultado;
            Error = vError;
            HayError = vHayError;
        }
    }
}
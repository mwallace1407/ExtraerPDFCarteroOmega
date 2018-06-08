namespace ExtraerPDFCarteroOmega
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExtraerUnico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numId = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.btnExtraerTodo = new System.Windows.Forms.Button();
            this.lblConteoCartas = new System.Windows.Forms.Label();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1083, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnExtraerUnico);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numId);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1075, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Extracción única";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExtraerUnico
            // 
            this.btnExtraerUnico.Location = new System.Drawing.Point(126, 35);
            this.btnExtraerUnico.Name = "btnExtraerUnico";
            this.btnExtraerUnico.Size = new System.Drawing.Size(75, 23);
            this.btnExtraerUnico.TabIndex = 2;
            this.btnExtraerUnico.Text = "Extraer";
            this.btnExtraerUnico.UseVisualStyleBackColor = true;
            this.btnExtraerUnico.Click += new System.EventHandler(this.btnExtraerUnico_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id de carta:";
            // 
            // numId
            // 
            this.numId.Location = new System.Drawing.Point(81, 6);
            this.numId.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numId.Minimum = new decimal(new int[] {
            69999,
            0,
            0,
            0});
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(120, 23);
            this.numId.TabIndex = 0;
            this.numId.Value = new decimal(new int[] {
            69999,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnExtraerTodo);
            this.tabPage2.Controls.Add(this.lblConteoCartas);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1075, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Extracción masiva";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lstLog);
            this.groupBox1.Location = new System.Drawing.Point(9, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1060, 341);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // lstLog
            // 
            this.lstLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLog.FormattingEnabled = true;
            this.lstLog.HorizontalScrollbar = true;
            this.lstLog.ItemHeight = 15;
            this.lstLog.Location = new System.Drawing.Point(6, 22);
            this.lstLog.Name = "lstLog";
            this.lstLog.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstLog.Size = new System.Drawing.Size(1048, 304);
            this.lstLog.TabIndex = 0;
            // 
            // btnExtraerTodo
            // 
            this.btnExtraerTodo.Location = new System.Drawing.Point(9, 21);
            this.btnExtraerTodo.Name = "btnExtraerTodo";
            this.btnExtraerTodo.Size = new System.Drawing.Size(262, 23);
            this.btnExtraerTodo.TabIndex = 1;
            this.btnExtraerTodo.Text = "Extraer todas las cartas a una carpeta";
            this.btnExtraerTodo.UseVisualStyleBackColor = true;
            this.btnExtraerTodo.Click += new System.EventHandler(this.btnExtraerTodo_Click);
            // 
            // lblConteoCartas
            // 
            this.lblConteoCartas.AutoSize = true;
            this.lblConteoCartas.Location = new System.Drawing.Point(6, 3);
            this.lblConteoCartas.Name = "lblConteoCartas";
            this.lblConteoCartas.Size = new System.Drawing.Size(109, 15);
            this.lblConteoCartas.TabIndex = 0;
            this.lblConteoCartas.Text = "Cartas generadas: ";
            // 
            // sfd
            // 
            this.sfd.DefaultExt = "pdf";
            this.sfd.Filter = "PDF|*.pdf";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 452);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Text = "Extracción PDFs Cartero";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnExtraerUnico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numId;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Label lblConteoCartas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Button btnExtraerTodo;
        private System.Windows.Forms.FolderBrowserDialog fbd;
    }
}


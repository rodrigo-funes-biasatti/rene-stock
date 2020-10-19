namespace Prueba_Rene.Forms.Remitos
{
    partial class frmRecaudacion
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblFechas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRecaudacion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRemitosGenerados = new System.Windows.Forms.Label();
            this.lblProductosVendidos = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblRecaudacionPromedioPorDia = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.backgroundWorkerCargarDatos = new System.ComponentModel.BackgroundWorker();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBoxBack);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(102, 39);
            this.panel3.TabIndex = 10;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBack.Image = global::Prueba_Rene.Properties.Resources.long_arrow_alt_left_solid;
            this.pictureBoxBack.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(102, 39);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 0;
            this.pictureBoxBack.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(227, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "Recaudación";
            // 
            // dateTimePickerFechaHasta
            // 
            this.dateTimePickerFechaHasta.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaHasta.Location = new System.Drawing.Point(152, 132);
            this.dateTimePickerFechaHasta.Name = "dateTimePickerFechaHasta";
            this.dateTimePickerFechaHasta.Size = new System.Drawing.Size(288, 32);
            this.dateTimePickerFechaHasta.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 70;
            this.label6.Text = "Fecha hasta:";
            // 
            // dateTimePickerFechaDesde
            // 
            this.dateTimePickerFechaDesde.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaDesde.Location = new System.Drawing.Point(152, 85);
            this.dateTimePickerFechaDesde.Name = "dateTimePickerFechaDesde";
            this.dateTimePickerFechaDesde.Size = new System.Drawing.Size(288, 32);
            this.dateTimePickerFechaDesde.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 24);
            this.label3.TabIndex = 68;
            this.label3.Text = "Fecha desde: ";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(667, 2);
            this.label2.TabIndex = 72;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Firebrick;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(446, 85);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(233, 79);
            this.btnConsultar.TabIndex = 73;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblFechas
            // 
            this.lblFechas.AutoSize = true;
            this.lblFechas.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechas.ForeColor = System.Drawing.Color.White;
            this.lblFechas.Location = new System.Drawing.Point(13, 228);
            this.lblFechas.Name = "lblFechas";
            this.lblFechas.Size = new System.Drawing.Size(126, 17);
            this.lblFechas.TabIndex = 74;
            this.lblFechas.Text = "Fechas:  del - hasta ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 614);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(314, 41);
            this.label5.TabIndex = 75;
            this.label5.Text = "Total Recaudado: $";
            // 
            // lblRecaudacion
            // 
            this.lblRecaudacion.AutoSize = true;
            this.lblRecaudacion.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecaudacion.ForeColor = System.Drawing.Color.White;
            this.lblRecaudacion.Location = new System.Drawing.Point(537, 614);
            this.lblRecaudacion.Name = "lblRecaudacion";
            this.lblRecaudacion.Size = new System.Drawing.Size(102, 41);
            this.lblRecaudacion.TabIndex = 76;
            this.lblRecaudacion.Text = "00.00";
            this.lblRecaudacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(316, 24);
            this.label7.TabIndex = 77;
            this.label7.Text = "Cantidad de Remitos Generados: ";
            // 
            // lblRemitosGenerados
            // 
            this.lblRemitosGenerados.AutoSize = true;
            this.lblRemitosGenerados.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemitosGenerados.ForeColor = System.Drawing.Color.White;
            this.lblRemitosGenerados.Location = new System.Drawing.Point(607, 313);
            this.lblRemitosGenerados.Name = "lblRemitosGenerados";
            this.lblRemitosGenerados.Size = new System.Drawing.Size(32, 24);
            this.lblRemitosGenerados.TabIndex = 78;
            this.lblRemitosGenerados.Text = "00";
            // 
            // lblProductosVendidos
            // 
            this.lblProductosVendidos.AutoSize = true;
            this.lblProductosVendidos.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosVendidos.ForeColor = System.Drawing.Color.White;
            this.lblProductosVendidos.Location = new System.Drawing.Point(607, 363);
            this.lblProductosVendidos.Name = "lblProductosVendidos";
            this.lblProductosVendidos.Size = new System.Drawing.Size(32, 24);
            this.lblProductosVendidos.TabIndex = 80;
            this.lblProductosVendidos.Text = "00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 24);
            this.label10.TabIndex = 79;
            this.label10.Text = "Productos Vendidos: ";
            // 
            // lblRecaudacionPromedioPorDia
            // 
            this.lblRecaudacionPromedioPorDia.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecaudacionPromedioPorDia.ForeColor = System.Drawing.Color.White;
            this.lblRecaudacionPromedioPorDia.Location = new System.Drawing.Point(580, 414);
            this.lblRecaudacionPromedioPorDia.Name = "lblRecaudacionPromedioPorDia";
            this.lblRecaudacionPromedioPorDia.Size = new System.Drawing.Size(59, 24);
            this.lblRecaudacionPromedioPorDia.TabIndex = 82;
            this.lblRecaudacionPromedioPorDia.Text = "00.00";
            this.lblRecaudacionPromedioPorDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(346, 24);
            this.label9.TabIndex = 81;
            this.label9.Text = "Promedio de Recaudación por Día: $";
            // 
            // backgroundWorkerCargarDatos
            // 
            this.backgroundWorkerCargarDatos.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCargarDatos_DoWork);
            this.backgroundWorkerCargarDatos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerCargarDatos_RunWorkerCompleted);
            // 
            // frmRecaudacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(691, 694);
            this.Controls.Add(this.lblRecaudacionPromedioPorDia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblProductosVendidos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblRemitosGenerados);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblRecaudacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFechas);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerFechaHasta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerFechaDesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecaudacion";
            this.Text = "frmRecaudación";
            this.Load += new System.EventHandler(this.frmRecaudacion_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaHasta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblFechas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRecaudacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRemitosGenerados;
        private System.Windows.Forms.Label lblProductosVendidos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblRecaudacionPromedioPorDia;
        private System.Windows.Forms.Label label9;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCargarDatos;
    }
}
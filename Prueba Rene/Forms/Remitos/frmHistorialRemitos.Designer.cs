namespace Prueba_Rene.Forms.Remitos
{
    partial class frmHistorialRemitos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewRemitos = new System.Windows.Forms.DataGridView();
            this.codigo_rem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factura_nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_remito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_remito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.btnVerRemito = new System.Windows.Forms.Button();
            this.Asociar = new System.Windows.Forms.Button();
            this.backgroundWorkerCargarTabla = new System.ComponentModel.BackgroundWorker();
            this.dateTimePickerFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.backgroundWorkerAsociarFactura = new System.ComponentModel.BackgroundWorker();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRemitos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBoxBack);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(102, 39);
            this.panel3.TabIndex = 8;
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
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(175, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "Historial de Remitos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 24);
            this.label3.TabIndex = 57;
            this.label3.Text = "Fecha desde: ";
            // 
            // dateTimePickerFechaDesde
            // 
            this.dateTimePickerFechaDesde.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaDesde.Location = new System.Drawing.Point(152, 76);
            this.dateTimePickerFechaDesde.Name = "dateTimePickerFechaDesde";
            this.dateTimePickerFechaDesde.Size = new System.Drawing.Size(288, 32);
            this.dateTimePickerFechaDesde.TabIndex = 58;
            this.dateTimePickerFechaDesde.ValueChanged += new System.EventHandler(this.dateTimePickerFecha_ValueChanged);
            // 
            // dataGridViewRemitos
            // 
            this.dataGridViewRemitos.AllowUserToAddRows = false;
            this.dataGridViewRemitos.AllowUserToDeleteRows = false;
            this.dataGridViewRemitos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRemitos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRemitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRemitos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_rem,
            this.factura_nro,
            this.fecha_remito,
            this.total_remito,
            this.vendedor});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRemitos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewRemitos.Location = new System.Drawing.Point(12, 172);
            this.dataGridViewRemitos.Name = "dataGridViewRemitos";
            this.dataGridViewRemitos.ReadOnly = true;
            this.dataGridViewRemitos.Size = new System.Drawing.Size(667, 232);
            this.dataGridViewRemitos.TabIndex = 59;
            this.dataGridViewRemitos.SelectionChanged += new System.EventHandler(this.dataGridViewRemitos_SelectionChanged);
            // 
            // codigo_rem
            // 
            this.codigo_rem.DataPropertyName = "codigo_rem";
            this.codigo_rem.HeaderText = "Remito n°";
            this.codigo_rem.Name = "codigo_rem";
            this.codigo_rem.ReadOnly = true;
            // 
            // factura_nro
            // 
            this.factura_nro.DataPropertyName = "factura_nro";
            this.factura_nro.HeaderText = "Factura n°";
            this.factura_nro.Name = "factura_nro";
            this.factura_nro.ReadOnly = true;
            // 
            // fecha_remito
            // 
            this.fecha_remito.DataPropertyName = "fecha_remito";
            this.fecha_remito.HeaderText = "Fecha";
            this.fecha_remito.Name = "fecha_remito";
            this.fecha_remito.ReadOnly = true;
            // 
            // total_remito
            // 
            this.total_remito.DataPropertyName = "total_remito";
            this.total_remito.HeaderText = "Total Remito";
            this.total_remito.Name = "total_remito";
            this.total_remito.ReadOnly = true;
            // 
            // vendedor
            // 
            this.vendedor.DataPropertyName = "vendedor";
            this.vendedor.HeaderText = "Vendedor";
            this.vendedor.Name = "vendedor";
            this.vendedor.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(667, 2);
            this.label2.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(207, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 44);
            this.label4.TabIndex = 61;
            this.label4.Text = "Asociar Factura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 572);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 24);
            this.label5.TabIndex = 62;
            this.label5.Text = "N° de Factura: ";
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroFactura.Location = new System.Drawing.Point(164, 569);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(515, 32);
            this.txtNroFactura.TabIndex = 63;
            // 
            // btnVerRemito
            // 
            this.btnVerRemito.BackColor = System.Drawing.Color.Firebrick;
            this.btnVerRemito.FlatAppearance.BorderSize = 0;
            this.btnVerRemito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerRemito.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerRemito.ForeColor = System.Drawing.Color.White;
            this.btnVerRemito.Location = new System.Drawing.Point(446, 410);
            this.btnVerRemito.Name = "btnVerRemito";
            this.btnVerRemito.Size = new System.Drawing.Size(233, 52);
            this.btnVerRemito.TabIndex = 64;
            this.btnVerRemito.Text = "Ver Remito";
            this.btnVerRemito.UseVisualStyleBackColor = false;
            this.btnVerRemito.Click += new System.EventHandler(this.btnVerRemito_Click);
            // 
            // Asociar
            // 
            this.Asociar.BackColor = System.Drawing.Color.Firebrick;
            this.Asociar.FlatAppearance.BorderSize = 0;
            this.Asociar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Asociar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Asociar.ForeColor = System.Drawing.Color.White;
            this.Asociar.Location = new System.Drawing.Point(446, 630);
            this.Asociar.Name = "Asociar";
            this.Asociar.Size = new System.Drawing.Size(233, 52);
            this.Asociar.TabIndex = 65;
            this.Asociar.Text = "Asociar";
            this.Asociar.UseVisualStyleBackColor = false;
            this.Asociar.Click += new System.EventHandler(this.Asociar_Click);
            // 
            // backgroundWorkerCargarTabla
            // 
            this.backgroundWorkerCargarTabla.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCargarTabla_DoWork);
            this.backgroundWorkerCargarTabla.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerCargarTabla_RunWorkerCompleted);
            // 
            // dateTimePickerFechaHasta
            // 
            this.dateTimePickerFechaHasta.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaHasta.Location = new System.Drawing.Point(152, 123);
            this.dateTimePickerFechaHasta.Name = "dateTimePickerFechaHasta";
            this.dateTimePickerFechaHasta.Size = new System.Drawing.Size(288, 32);
            this.dateTimePickerFechaHasta.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 66;
            this.label6.Text = "Fecha hasta:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Firebrick;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(446, 76);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(233, 79);
            this.btnFiltrar.TabIndex = 68;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // backgroundWorkerAsociarFactura
            // 
            this.backgroundWorkerAsociarFactura.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerAsociarFactura_DoWork);
            this.backgroundWorkerAsociarFactura.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerAsociarFactura_RunWorkerCompleted);
            // 
            // frmHistorialRemitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(691, 694);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dateTimePickerFechaHasta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Asociar);
            this.Controls.Add(this.btnVerRemito);
            this.Controls.Add(this.txtNroFactura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewRemitos);
            this.Controls.Add(this.dateTimePickerFechaDesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHistorialRemitos";
            this.Text = "frmHistorialRemitos";
            this.Load += new System.EventHandler(this.frmHistorialRemitos_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRemitos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaDesde;
        private System.Windows.Forms.DataGridView dataGridViewRemitos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_rem;
        private System.Windows.Forms.DataGridViewTextBoxColumn factura_nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_remito;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_remito;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.Button btnVerRemito;
        private System.Windows.Forms.Button Asociar;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCargarTabla;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaHasta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFiltrar;
        private System.ComponentModel.BackgroundWorker backgroundWorkerAsociarFactura;
    }
}
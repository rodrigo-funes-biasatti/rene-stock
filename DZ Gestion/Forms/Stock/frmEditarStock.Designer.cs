namespace Prueba_Rene.Forms.Stock
{
    partial class frmEditarStock
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
            this.txtCantidadActual = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRubros = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.backgroundWorkerCargarStock = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerCargarCombroProductos = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerCargarComboRubros = new System.ComponentModel.BackgroundWorker();
            this.btnEditarStock = new System.Windows.Forms.Button();
            this.backgroundWorkerActualizarStock = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCantidadActual
            // 
            this.txtCantidadActual.Enabled = false;
            this.txtCantidadActual.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtCantidadActual.Location = new System.Drawing.Point(12, 331);
            this.txtCantidadActual.Name = "txtCantidadActual";
            this.txtCantidadActual.Size = new System.Drawing.Size(667, 34);
            this.txtCantidadActual.TabIndex = 65;
            this.txtCantidadActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(252, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 26);
            this.label9.TabIndex = 64;
            this.label9.Text = "Cantidad Actual";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(12, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(667, 2);
            this.label6.TabIndex = 60;
            // 
            // cmbProductos
            // 
            this.cmbProductos.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(130, 196);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(549, 34);
            this.cmbProductos.TabIndex = 59;
            this.cmbProductos.SelectionChangeCommitted += new System.EventHandler(this.cmbProductos_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(7, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 26);
            this.label4.TabIndex = 58;
            this.label4.Text = "Producto: ";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(12, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(667, 2);
            this.label5.TabIndex = 57;
            // 
            // cmbRubros
            // 
            this.cmbRubros.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmbRubros.FormattingEnabled = true;
            this.cmbRubros.Location = new System.Drawing.Point(98, 121);
            this.cmbRubros.Name = "cmbRubros";
            this.cmbRubros.Size = new System.Drawing.Size(581, 34);
            this.cmbRubros.TabIndex = 56;
            this.cmbRubros.SelectionChangeCommitted += new System.EventHandler(this.cmbRubros_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 26);
            this.label3.TabIndex = 55;
            this.label3.Text = "Rubro:";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(667, 2);
            this.label2.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(213, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 44);
            this.label1.TabIndex = 53;
            this.label1.Text = "Editar Stock";
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::Prueba_Rene.Properties.Resources.long_arrow_alt_left_solid;
            this.pictureBoxBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxBack.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(102, 39);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 52;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // backgroundWorkerCargarStock
            // 
            this.backgroundWorkerCargarStock.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCargarStock_DoWork);
            this.backgroundWorkerCargarStock.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerCargarStock_RunWorkerCompleted);
            // 
            // backgroundWorkerCargarCombroProductos
            // 
            this.backgroundWorkerCargarCombroProductos.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCargarCombroProductos_DoWork);
            this.backgroundWorkerCargarCombroProductos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerCargarCombroProductos_RunWorkerCompleted);
            // 
            // backgroundWorkerCargarComboRubros
            // 
            this.backgroundWorkerCargarComboRubros.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCargarComboRubros_DoWork);
            this.backgroundWorkerCargarComboRubros.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerCargarComboRubros_RunWorkerCompleted);
            // 
            // btnEditarStock
            // 
            this.btnEditarStock.BackColor = System.Drawing.Color.Firebrick;
            this.btnEditarStock.FlatAppearance.BorderSize = 0;
            this.btnEditarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarStock.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarStock.ForeColor = System.Drawing.Color.White;
            this.btnEditarStock.Location = new System.Drawing.Point(12, 629);
            this.btnEditarStock.Name = "btnEditarStock";
            this.btnEditarStock.Size = new System.Drawing.Size(667, 53);
            this.btnEditarStock.TabIndex = 66;
            this.btnEditarStock.Text = "Editar Stock Seleccionado";
            this.btnEditarStock.UseVisualStyleBackColor = false;
            this.btnEditarStock.Click += new System.EventHandler(this.btnEditarStock_Click);
            // 
            // backgroundWorkerActualizarStock
            // 
            this.backgroundWorkerActualizarStock.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerActualizarStock_DoWork);
            this.backgroundWorkerActualizarStock.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerActualizarStock_RunWorkerCompleted);
            // 
            // frmEditarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(691, 694);
            this.Controls.Add(this.btnEditarStock);
            this.Controls.Add(this.txtCantidadActual);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbRubros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarStock";
            this.Text = "frmEditarStock";
            this.Load += new System.EventHandler(this.frmEditarStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantidadActual;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbRubros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCargarStock;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCargarCombroProductos;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCargarComboRubros;
        private System.Windows.Forms.Button btnEditarStock;
        private System.ComponentModel.BackgroundWorker backgroundWorkerActualizarStock;
    }
}
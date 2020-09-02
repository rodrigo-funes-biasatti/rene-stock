namespace Prueba_Rene.Forms.Stock
{
    partial class frmConsultarStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarStock));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRubros = new System.Windows.Forms.ComboBox();
            this.backgroundWorkerCargarComboRubros = new System.ComponentModel.BackgroundWorker();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorkerCargarCombroProductos = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUltFechAct = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCantidadActual = new System.Windows.Forms.TextBox();
            this.backgroundWorkerCargarStock = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // cmbRubros
            // 
            resources.ApplyResources(this.cmbRubros, "cmbRubros");
            this.cmbRubros.FormattingEnabled = true;
            this.cmbRubros.Name = "cmbRubros";
            this.cmbRubros.SelectionChangeCommitted += new System.EventHandler(this.cmbRubros_SelectionChangeCommitted);
            // 
            // backgroundWorkerCargarComboRubros
            // 
            this.backgroundWorkerCargarComboRubros.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCargarComboRubros_DoWork);
            this.backgroundWorkerCargarComboRubros.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerCargarComboRubros_RunWorkerCompleted);
            // 
            // cmbProductos
            // 
            resources.ApplyResources(this.cmbProductos, "cmbProductos");
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.SelectionChangeCommitted += new System.EventHandler(this.cmbProductos_SelectionChangeCommitted);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // backgroundWorkerCargarCombroProductos
            // 
            this.backgroundWorkerCargarCombroProductos.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCargarCombroProductos_DoWork);
            this.backgroundWorkerCargarCombroProductos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerCargarCombroProductos_RunWorkerCompleted);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::Prueba_Rene.Properties.Resources.long_arrow_alt_left_solid;
            resources.ApplyResources(this.pictureBoxBack, "pictureBoxBack");
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Name = "label8";
            // 
            // txtUltFechAct
            // 
            resources.ApplyResources(this.txtUltFechAct, "txtUltFechAct");
            this.txtUltFechAct.Name = "txtUltFechAct";
            this.txtUltFechAct.ReadOnly = true;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Name = "label9";
            // 
            // txtCantidadActual
            // 
            resources.ApplyResources(this.txtCantidadActual, "txtCantidadActual");
            this.txtCantidadActual.Name = "txtCantidadActual";
            this.txtCantidadActual.ReadOnly = true;
            // 
            // backgroundWorkerCargarStock
            // 
            this.backgroundWorkerCargarStock.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCargarStock_DoWork);
            this.backgroundWorkerCargarStock.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerCargarStock_RunWorkerCompleted);
            // 
            // frmConsultarStock
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.txtCantidadActual);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtUltFechAct);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
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
            this.Name = "frmConsultarStock";
            this.Load += new System.EventHandler(this.frmConsultarStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRubros;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCargarComboRubros;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCargarCombroProductos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUltFechAct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCantidadActual;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCargarStock;
    }
}
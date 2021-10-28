
namespace Prueba_Rene.Forms.Remitos
{
    partial class frmAgregarStockRemito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarStockRemito));
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnEditarStock = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCantidadActual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.bwCargarDatosProducto = new System.ComponentModel.BackgroundWorker();
            this.bwEditarStock = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl1.Location = new System.Drawing.Point(265, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(261, 44);
            this.lbl1.TabIndex = 54;
            this.lbl1.Text = "Agregar Stock";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditarStock
            // 
            this.btnEditarStock.BackColor = System.Drawing.Color.Firebrick;
            this.btnEditarStock.FlatAppearance.BorderSize = 0;
            this.btnEditarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarStock.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarStock.ForeColor = System.Drawing.Color.White;
            this.btnEditarStock.Location = new System.Drawing.Point(12, 232);
            this.btnEditarStock.Name = "btnEditarStock";
            this.btnEditarStock.Size = new System.Drawing.Size(756, 53);
            this.btnEditarStock.TabIndex = 67;
            this.btnEditarStock.Text = "Editar Stock del Producto";
            this.btnEditarStock.UseVisualStyleBackColor = false;
            this.btnEditarStock.Click += new System.EventHandler(this.btnEditarStock_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(12, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 26);
            this.label9.TabIndex = 68;
            this.label9.Text = "Cantidad: ";
            // 
            // txtCantidadActual
            // 
            this.txtCantidadActual.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadActual.Location = new System.Drawing.Point(133, 141);
            this.txtCantidadActual.Name = "txtCantidadActual";
            this.txtCantidadActual.Size = new System.Drawing.Size(635, 34);
            this.txtCantidadActual.TabIndex = 69;
            this.txtCantidadActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 44);
            this.label1.TabIndex = 70;
            this.label1.Text = "Producto: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft JhengHei UI", 26.25F, System.Drawing.FontStyle.Bold);
            this.lblProducto.ForeColor = System.Drawing.Color.Black;
            this.lblProducto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProducto.Location = new System.Drawing.Point(212, 71);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(200, 44);
            this.lblProducto.TabIndex = 71;
            this.lblProducto.Text = "[Producto]";
            this.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bwCargarDatosProducto
            // 
            this.bwCargarDatosProducto.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwCargarDatosProducto_DoWork);
            this.bwCargarDatosProducto.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwCargarDatosProducto_RunWorkerCompleted);
            // 
            // bwEditarStock
            // 
            this.bwEditarStock.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwEditarStock_DoWork);
            this.bwEditarStock.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwEditarStock_RunWorkerCompleted);
            // 
            // frmAgregarStockRemito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(780, 297);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidadActual);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEditarStock);
            this.Controls.Add(this.lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregarStockRemito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Stock desde Remito";
            this.Load += new System.EventHandler(this.frmAgregarStockRemito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnEditarStock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCantidadActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProducto;
        private System.ComponentModel.BackgroundWorker bwCargarDatosProducto;
        private System.ComponentModel.BackgroundWorker bwEditarStock;
    }
}
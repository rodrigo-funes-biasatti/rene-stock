namespace Prueba_Rene.Forms.Remitos
{
    partial class frmMenuRemitos
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
            this.panelGenerarRemito = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHistorialRemitos = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelGenerarRemito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHistorialRemitos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGenerarRemito
            // 
            this.panelGenerarRemito.BackColor = System.Drawing.Color.Firebrick;
            this.panelGenerarRemito.Controls.Add(this.label1);
            this.panelGenerarRemito.Controls.Add(this.pictureBox1);
            this.panelGenerarRemito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelGenerarRemito.Location = new System.Drawing.Point(12, 12);
            this.panelGenerarRemito.Name = "panelGenerarRemito";
            this.panelGenerarRemito.Size = new System.Drawing.Size(203, 199);
            this.panelGenerarRemito.TabIndex = 1;
            this.panelGenerarRemito.Click += new System.EventHandler(this.panelGenerarRemito_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generar Remito";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Prueba_Rene.Properties.Resources.file_alt_solid;
            this.pictureBox1.Location = new System.Drawing.Point(48, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelHistorialRemitos
            // 
            this.panelHistorialRemitos.BackColor = System.Drawing.Color.Firebrick;
            this.panelHistorialRemitos.Controls.Add(this.label2);
            this.panelHistorialRemitos.Controls.Add(this.pictureBox2);
            this.panelHistorialRemitos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelHistorialRemitos.Location = new System.Drawing.Point(476, 3);
            this.panelHistorialRemitos.Name = "panelHistorialRemitos";
            this.panelHistorialRemitos.Size = new System.Drawing.Size(203, 199);
            this.panelHistorialRemitos.TabIndex = 2;
            this.panelHistorialRemitos.Click += new System.EventHandler(this.panelHistorialRemitos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Historial Remitos ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Prueba_Rene.Properties.Resources.history_solid;
            this.pictureBox2.Location = new System.Drawing.Point(48, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // frmMenuRemitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(691, 694);
            this.Controls.Add(this.panelHistorialRemitos);
            this.Controls.Add(this.panelGenerarRemito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuRemitos";
            this.Text = "frmMenuRemitos";
            this.Load += new System.EventHandler(this.frmMenuRemitos_Load);
            this.panelGenerarRemito.ResumeLayout(false);
            this.panelGenerarRemito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHistorialRemitos.ResumeLayout(false);
            this.panelHistorialRemitos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGenerarRemito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelHistorialRemitos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
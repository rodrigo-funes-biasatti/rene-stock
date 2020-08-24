namespace Prueba_Rene.Forms.ABM
{
    partial class frmABMContraseña
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNuevaContraseña = new System.Windows.Forms.TextBox();
            this.bntNuevaContraseña = new System.Windows.Forms.Button();
            this.txtAnteriorContraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(199, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva Contraseña";
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaContraseña.Location = new System.Drawing.Point(135, 374);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.Size = new System.Drawing.Size(414, 42);
            this.txtNuevaContraseña.TabIndex = 1;
            this.txtNuevaContraseña.UseSystemPasswordChar = true;
            // 
            // bntNuevaContraseña
            // 
            this.bntNuevaContraseña.BackColor = System.Drawing.Color.Firebrick;
            this.bntNuevaContraseña.FlatAppearance.BorderSize = 0;
            this.bntNuevaContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntNuevaContraseña.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntNuevaContraseña.ForeColor = System.Drawing.Color.White;
            this.bntNuevaContraseña.Location = new System.Drawing.Point(-1, 619);
            this.bntNuevaContraseña.Name = "bntNuevaContraseña";
            this.bntNuevaContraseña.Size = new System.Drawing.Size(694, 63);
            this.bntNuevaContraseña.TabIndex = 2;
            this.bntNuevaContraseña.Text = "Cambiar";
            this.bntNuevaContraseña.UseVisualStyleBackColor = false;
            this.bntNuevaContraseña.Click += new System.EventHandler(this.bntNuevaContraseña_Click);
            // 
            // txtAnteriorContraseña
            // 
            this.txtAnteriorContraseña.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnteriorContraseña.Location = new System.Drawing.Point(135, 246);
            this.txtAnteriorContraseña.Name = "txtAnteriorContraseña";
            this.txtAnteriorContraseña.Size = new System.Drawing.Size(414, 42);
            this.txtAnteriorContraseña.TabIndex = 4;
            this.txtAnteriorContraseña.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(180, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Anterior Contraseña";
            // 
            // frmABMContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(691, 694);
            this.Controls.Add(this.txtAnteriorContraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bntNuevaContraseña);
            this.Controls.Add(this.txtNuevaContraseña);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmABMContraseña";
            this.Text = "Cambiar Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNuevaContraseña;
        private System.Windows.Forms.Button bntNuevaContraseña;
        private System.Windows.Forms.TextBox txtAnteriorContraseña;
        private System.Windows.Forms.Label label2;
    }
}
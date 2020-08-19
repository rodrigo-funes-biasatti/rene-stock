namespace Prueba_Rene
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clock1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnRene = new System.Windows.Forms.Button();
            this.btnAgustin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clock1
            // 
            this.clock1.Tick += new System.EventHandler(this.clock1_Tick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(305, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 705);
            this.panel1.TabIndex = 0;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft JhengHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(4, 12);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(295, 81);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "00:00:00";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(14, 93);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(68, 21);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "xx xxxx";
            // 
            // btnRene
            // 
            this.btnRene.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRene.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRene.FlatAppearance.BorderSize = 0;
            this.btnRene.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRene.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRene.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRene.ForeColor = System.Drawing.Color.White;
            this.btnRene.Location = new System.Drawing.Point(12, 584);
            this.btnRene.Name = "btnRene";
            this.btnRene.Size = new System.Drawing.Size(287, 58);
            this.btnRene.TabIndex = 3;
            this.btnRene.Text = "Rene";
            this.btnRene.UseVisualStyleBackColor = false;
            // 
            // btnAgustin
            // 
            this.btnAgustin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgustin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgustin.FlatAppearance.BorderSize = 0;
            this.btnAgustin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgustin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgustin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgustin.ForeColor = System.Drawing.Color.White;
            this.btnAgustin.Location = new System.Drawing.Point(12, 648);
            this.btnAgustin.Name = "btnAgustin";
            this.btnAgustin.Size = new System.Drawing.Size(287, 58);
            this.btnAgustin.TabIndex = 4;
            this.btnAgustin.Text = "Agustin";
            this.btnAgustin.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnAgustin);
            this.Controls.Add(this.btnRene);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Principal";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer clock1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnRene;
        private System.Windows.Forms.Button btnAgustin;
    }
}


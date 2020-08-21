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
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnRene = new System.Windows.Forms.Button();
            this.panelConfig = new System.Windows.Forms.Panel();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.btnAgustin = new System.Windows.Forms.Button();
            this.bntStock = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // clock1
            // 
            this.clock1.Tick += new System.EventHandler(this.clock1_Tick);
            // 
            // panelContent
            // 
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContent.Location = new System.Drawing.Point(305, 12);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(691, 694);
            this.panelContent.TabIndex = 0;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft JhengHei UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblFecha.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(14, 93);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(67, 20);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "xx xxxx";
            // 
            // btnRene
            // 
            this.btnRene.BackColor = System.Drawing.Color.Firebrick;
            this.btnRene.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRene.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRene.FlatAppearance.BorderSize = 0;
            this.btnRene.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRene.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRene.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRene.ForeColor = System.Drawing.Color.White;
            this.btnRene.Location = new System.Drawing.Point(12, 520);
            this.btnRene.Name = "btnRene";
            this.btnRene.Size = new System.Drawing.Size(287, 58);
            this.btnRene.TabIndex = 3;
            this.btnRene.Text = "Rene";
            this.btnRene.UseVisualStyleBackColor = false;
            // 
            // panelConfig
            // 
            this.panelConfig.BackColor = System.Drawing.Color.Brown;
            this.panelConfig.Controls.Add(this.btnCambiarContraseña);
            this.panelConfig.Location = new System.Drawing.Point(305, 712);
            this.panelConfig.Name = "panelConfig";
            this.panelConfig.Size = new System.Drawing.Size(691, 58);
            this.panelConfig.TabIndex = 7;
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.BackColor = System.Drawing.Color.Firebrick;
            this.btnCambiarContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCambiarContraseña.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCambiarContraseña.FlatAppearance.BorderSize = 0;
            this.btnCambiarContraseña.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCambiarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarContraseña.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarContraseña.ForeColor = System.Drawing.Color.White;
            this.btnCambiarContraseña.Location = new System.Drawing.Point(0, 0);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(287, 58);
            this.btnCambiarContraseña.TabIndex = 8;
            this.btnCambiarContraseña.Text = "Cambiar Contraseña";
            this.btnCambiarContraseña.UseVisualStyleBackColor = false;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // btnAgustin
            // 
            this.btnAgustin.BackColor = System.Drawing.Color.Firebrick;
            this.btnAgustin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgustin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgustin.FlatAppearance.BorderSize = 0;
            this.btnAgustin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgustin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgustin.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgustin.ForeColor = System.Drawing.Color.White;
            this.btnAgustin.Location = new System.Drawing.Point(12, 584);
            this.btnAgustin.Name = "btnAgustin";
            this.btnAgustin.Size = new System.Drawing.Size(287, 58);
            this.btnAgustin.TabIndex = 4;
            this.btnAgustin.Text = "Agustin";
            this.btnAgustin.UseVisualStyleBackColor = false;
            // 
            // bntStock
            // 
            this.bntStock.BackColor = System.Drawing.Color.Firebrick;
            this.bntStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bntStock.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bntStock.FlatAppearance.BorderSize = 0;
            this.bntStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntStock.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntStock.ForeColor = System.Drawing.Color.White;
            this.bntStock.Location = new System.Drawing.Point(12, 648);
            this.bntStock.Name = "bntStock";
            this.bntStock.Size = new System.Drawing.Size(287, 58);
            this.bntStock.TabIndex = 8;
            this.bntStock.Text = "Consultar Stock";
            this.bntStock.UseVisualStyleBackColor = false;
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.Firebrick;
            this.btnConfig.BackgroundImage = global::Prueba_Rene.Properties.Resources.cog_solid_white;
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfig.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.Location = new System.Drawing.Point(12, 712);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(287, 58);
            this.btnConfig.TabIndex = 6;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::Prueba_Rene.Properties.Resources.loco;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Location = new System.Drawing.Point(12, 186);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(271, 231);
            this.panelLogo.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1008, 776);
            this.Controls.Add(this.bntStock);
            this.Controls.Add(this.panelConfig);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.btnAgustin);
            this.Controls.Add(this.btnRene);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.panelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Principal";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelConfig.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer clock1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnRene;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Panel panelConfig;
        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.Button btnAgustin;
        private System.Windows.Forms.Button bntStock;
    }
}


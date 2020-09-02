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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.clock1 = new System.Windows.Forms.Timer(this.components);
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnRemito = new System.Windows.Forms.Button();
            this.panelConfig = new System.Windows.Forms.Panel();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnLimpiarPanel = new System.Windows.Forms.Button();
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
            // btnRemito
            // 
            this.btnRemito.BackColor = System.Drawing.Color.Firebrick;
            this.btnRemito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemito.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemito.FlatAppearance.BorderSize = 0;
            this.btnRemito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRemito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemito.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemito.ForeColor = System.Drawing.Color.White;
            this.btnRemito.Location = new System.Drawing.Point(12, 520);
            this.btnRemito.Name = "btnRemito";
            this.btnRemito.Size = new System.Drawing.Size(287, 58);
            this.btnRemito.TabIndex = 1;
            this.btnRemito.Text = "Remitos";
            this.btnRemito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemito.UseVisualStyleBackColor = false;
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
            this.btnCambiarContraseña.Size = new System.Drawing.Size(275, 58);
            this.btnCambiarContraseña.TabIndex = 5;
            this.btnCambiarContraseña.Text = "Cambiar Contraseña";
            this.btnCambiarContraseña.UseVisualStyleBackColor = false;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.Firebrick;
            this.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProductos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Location = new System.Drawing.Point(12, 584);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(287, 58);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.Firebrick;
            this.btnStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStock.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Location = new System.Drawing.Point(12, 648);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(287, 58);
            this.btnStock.TabIndex = 3;
            this.btnStock.Text = "Stock";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnLimpiarPanel
            // 
            this.btnLimpiarPanel.BackColor = System.Drawing.Color.Firebrick;
            this.btnLimpiarPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpiarPanel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiarPanel.FlatAppearance.BorderSize = 0;
            this.btnLimpiarPanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarPanel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarPanel.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarPanel.Location = new System.Drawing.Point(12, 456);
            this.btnLimpiarPanel.Name = "btnLimpiarPanel";
            this.btnLimpiarPanel.Size = new System.Drawing.Size(287, 58);
            this.btnLimpiarPanel.TabIndex = 0;
            this.btnLimpiarPanel.Text = "Limpiar Panel";
            this.btnLimpiarPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarPanel.UseVisualStyleBackColor = false;
            this.btnLimpiarPanel.Click += new System.EventHandler(this.btnLimpiarPanel_Click);
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
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(12, 712);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(287, 58);
            this.btnConfig.TabIndex = 4;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::Prueba_Rene.Properties.Resources.loco;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Location = new System.Drawing.Point(12, 162);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(271, 231);
            this.panelLogo.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1008, 776);
            this.Controls.Add(this.btnLimpiarPanel);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.panelConfig);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnRemito);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.panelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnRemito;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Panel panelConfig;
        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnLimpiarPanel;
        public System.Windows.Forms.Panel panelContent;
    }
}


namespace Prueba_Rene.Forms.Productos
{
    partial class frmNuevoProducto
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
            this.components = new System.ComponentModel.Container();
            this.lblNuevoProducto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbRubros = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.backgroundWorkerCargarCombo = new System.ComponentModel.BackgroundWorker();
            this.mtxtPrecioUnitario = new System.Windows.Forms.MaskedTextBox();
            this.backgroundWorkerAgregarProducto = new System.ComponentModel.BackgroundWorker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelDivider = new System.Windows.Forms.Label();
            this.backgroundWorkerCodigoSugerido = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNuevoProducto
            // 
            this.lblNuevoProducto.AutoSize = true;
            this.lblNuevoProducto.Font = new System.Drawing.Font("Microsoft JhengHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoProducto.ForeColor = System.Drawing.Color.White;
            this.lblNuevoProducto.Location = new System.Drawing.Point(201, 18);
            this.lblNuevoProducto.Name = "lblNuevoProducto";
            this.lblNuevoProducto.Size = new System.Drawing.Size(297, 44);
            this.lblNuevoProducto.TabIndex = 2;
            this.lblNuevoProducto.Text = "Nuevo Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(92, 164);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(587, 34);
            this.txtMarca.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Precio Unitario: $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descripcion: ";
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescripcion.Location = new System.Drawing.Point(147, 363);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(532, 108);
            this.rtxtDescripcion.TabIndex = 3;
            this.rtxtDescripcion.Text = "";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(12, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(667, 2);
            this.label4.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 538);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Rubro: ";
            // 
            // cmbRubros
            // 
            this.cmbRubros.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRubros.FormattingEnabled = true;
            this.cmbRubros.Location = new System.Drawing.Point(95, 533);
            this.cmbRubros.Name = "cmbRubros";
            this.cmbRubros.Size = new System.Drawing.Size(584, 34);
            this.cmbRubros.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(12, 597);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(667, 2);
            this.label6.TabIndex = 16;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.Firebrick;
            this.btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(16, 629);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(201, 53);
            this.btnLimpiarCampos.TabIndex = 5;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::Prueba_Rene.Properties.Resources.long_arrow_alt_left_solid;
            this.pictureBoxBack.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(102, 39);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 18;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.BackColor = System.Drawing.Color.Firebrick;
            this.btnNuevoProducto.FlatAppearance.BorderSize = 0;
            this.btnNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProducto.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProducto.ForeColor = System.Drawing.Color.White;
            this.btnNuevoProducto.Location = new System.Drawing.Point(464, 629);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(215, 53);
            this.btnNuevoProducto.TabIndex = 6;
            this.btnNuevoProducto.Text = "Agregar Producto";
            this.btnNuevoProducto.UseVisualStyleBackColor = false;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // backgroundWorkerCargarCombo
            // 
            this.backgroundWorkerCargarCombo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCargarCombo_DoWork);
            this.backgroundWorkerCargarCombo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerCargarCombo_RunWorkerCompleted);
            // 
            // mtxtPrecioUnitario
            // 
            this.mtxtPrecioUnitario.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtPrecioUnitario.Location = new System.Drawing.Point(186, 298);
            this.mtxtPrecioUnitario.Mask = "0000.00";
            this.mtxtPrecioUnitario.Name = "mtxtPrecioUnitario";
            this.mtxtPrecioUnitario.PromptChar = '0';
            this.mtxtPrecioUnitario.Size = new System.Drawing.Size(493, 34);
            this.mtxtPrecioUnitario.TabIndex = 2;
            // 
            // backgroundWorkerAgregarProducto
            // 
            this.backgroundWorkerAgregarProducto.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerAgregarProducto_DoWork);
            this.backgroundWorkerAgregarProducto.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerAgregarProducto_RunWorkerCompleted);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(115, 230);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(564, 34);
            this.txtNombre.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Nombre: ";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(104, 103);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(575, 34);
            this.txtCodigo.TabIndex = 21;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Codigo: ";
            // 
            // labelDivider
            // 
            this.labelDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDivider.Location = new System.Drawing.Point(12, 88);
            this.labelDivider.Name = "labelDivider";
            this.labelDivider.Size = new System.Drawing.Size(667, 2);
            this.labelDivider.TabIndex = 3;
            // 
            // backgroundWorkerCodigoSugerido
            // 
            this.backgroundWorkerCodigoSugerido.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCodigoSugerido_DoWork);
            this.backgroundWorkerCodigoSugerido.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerCodigoSugerido_RunWorkerCompleted);
            // 
            // frmNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(691, 694);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mtxtPrecioUnitario);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbRubros);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtxtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDivider);
            this.Controls.Add(this.lblNuevoProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevoProducto";
            this.Load += new System.EventHandler(this.frmNuevoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevoProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox cmbRubros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCargarCombo;
        private System.Windows.Forms.MaskedTextBox mtxtPrecioUnitario;
        private System.ComponentModel.BackgroundWorker backgroundWorkerAgregarProducto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelDivider;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCodigoSugerido;
    }
}
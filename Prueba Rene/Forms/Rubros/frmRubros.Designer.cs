namespace Prueba_Rene.Forms.Rubros
{
    partial class frmRubros
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
            this.labelDivider = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewRubros = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcionNuevo = new System.Windows.Forms.TextBox();
            this.bntAgregarNuevo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtDescripcionEditar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreEditar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.id_rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRubros)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDivider
            // 
            this.labelDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDivider.Location = new System.Drawing.Point(12, 285);
            this.labelDivider.Name = "labelDivider";
            this.labelDivider.Size = new System.Drawing.Size(667, 2);
            this.labelDivider.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rubros";
            // 
            // dataGridViewRubros
            // 
            this.dataGridViewRubros.AllowUserToAddRows = false;
            this.dataGridViewRubros.AllowUserToDeleteRows = false;
            this.dataGridViewRubros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRubros.BackgroundColor = System.Drawing.Color.Firebrick;
            this.dataGridViewRubros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRubros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRubros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRubros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRubros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_rubro,
            this.nombre,
            this.descripcion});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRubros.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewRubros.GridColor = System.Drawing.Color.White;
            this.dataGridViewRubros.Location = new System.Drawing.Point(12, 72);
            this.dataGridViewRubros.Name = "dataGridViewRubros";
            this.dataGridViewRubros.ReadOnly = true;
            this.dataGridViewRubros.Size = new System.Drawing.Size(503, 188);
            this.dataGridViewRubros.TabIndex = 3;
            this.dataGridViewRubros.SelectionChanged += new System.EventHandler(this.dataGridViewRubros_SelectionChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Firebrick;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(521, 136);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(158, 61);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar seleccionado";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(264, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 44);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nuevo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.bntAgregarNuevo);
            this.panel1.Controls.Add(this.txtDescripcionNuevo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNombreNuevo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 106);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre: ";
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreNuevo.Location = new System.Drawing.Point(152, 3);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(205, 34);
            this.txtNombreNuevo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descripción: ";
            // 
            // txtDescripcionNuevo
            // 
            this.txtDescripcionNuevo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionNuevo.Location = new System.Drawing.Point(152, 69);
            this.txtDescripcionNuevo.Name = "txtDescripcionNuevo";
            this.txtDescripcionNuevo.Size = new System.Drawing.Size(326, 34);
            this.txtDescripcionNuevo.TabIndex = 9;
            // 
            // bntAgregarNuevo
            // 
            this.bntAgregarNuevo.BackColor = System.Drawing.Color.DarkRed;
            this.bntAgregarNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.bntAgregarNuevo.FlatAppearance.BorderSize = 3;
            this.bntAgregarNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAgregarNuevo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAgregarNuevo.ForeColor = System.Drawing.Color.White;
            this.bntAgregarNuevo.Location = new System.Drawing.Point(493, 3);
            this.bntAgregarNuevo.Name = "bntAgregarNuevo";
            this.bntAgregarNuevo.Size = new System.Drawing.Size(171, 100);
            this.bntAgregarNuevo.TabIndex = 7;
            this.bntAgregarNuevo.Text = "Agregar";
            this.bntAgregarNuevo.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(12, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(667, 2);
            this.label5.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.txtDescripcionEditar);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtNombreEditar);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(12, 564);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 106);
            this.panel2.TabIndex = 9;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkRed;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnEditar.FlatAppearance.BorderSize = 3;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(493, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(171, 100);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // txtDescripcionEditar
            // 
            this.txtDescripcionEditar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionEditar.Location = new System.Drawing.Point(152, 69);
            this.txtDescripcionEditar.Name = "txtDescripcionEditar";
            this.txtDescripcionEditar.Size = new System.Drawing.Size(326, 34);
            this.txtDescripcionEditar.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Descripción: ";
            // 
            // txtNombreEditar
            // 
            this.txtNombreEditar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEditar.Location = new System.Drawing.Point(152, 3);
            this.txtNombreEditar.Name = "txtNombreEditar";
            this.txtNombreEditar.Size = new System.Drawing.Size(205, 34);
            this.txtNombreEditar.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(264, 505);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 44);
            this.label8.TabIndex = 8;
            this.label8.Text = "Editar";
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::Prueba_Rene.Properties.Resources.long_arrow_alt_left_solid;
            this.pictureBoxBack.Location = new System.Drawing.Point(12, 9);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(102, 39);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.TabIndex = 10;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // id_rubro
            // 
            this.id_rubro.DataPropertyName = "id_rubro";
            this.id_rubro.FillWeight = 41.26412F;
            this.id_rubro.HeaderText = "ID Rubro";
            this.id_rubro.Name = "id_rubro";
            this.id_rubro.ReadOnly = true;
            this.id_rubro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.FillWeight = 76.14214F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.FillWeight = 182.5938F;
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // frmRubros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(691, 694);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dataGridViewRubros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDivider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRubros";
            this.Text = "frmRubros";
            this.Load += new System.EventHandler(this.frmRubros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRubros)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDivider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewRubros;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntAgregarNuevo;
        private System.Windows.Forms.TextBox txtDescripcionNuevo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreNuevo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtDescripcionEditar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreEditar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
    }
}
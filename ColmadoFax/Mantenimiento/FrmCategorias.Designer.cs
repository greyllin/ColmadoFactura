namespace ColmadoFax.Mantenimiento
{
    partial class FrmCategorias
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
            this.ChActivo = new System.Windows.Forms.CheckBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DatMostarDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DatMostarDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // ChActivo
            // 
            this.ChActivo.AutoSize = true;
            this.ChActivo.Location = new System.Drawing.Point(142, 84);
            this.ChActivo.Name = "ChActivo";
            this.ChActivo.Size = new System.Drawing.Size(56, 17);
            this.ChActivo.TabIndex = 1;
            this.ChActivo.Text = "Activo";
            this.ChActivo.UseVisualStyleBackColor = true;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(142, 19);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(211, 20);
            this.TxtId.TabIndex = 2;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(142, 58);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(351, 20);
            this.TxtDescripcion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripcion";
            // 
            // DatMostarDatos
            // 
            this.DatMostarDatos.AllowUserToAddRows = false;
            this.DatMostarDatos.AllowUserToDeleteRows = false;
            this.DatMostarDatos.AllowUserToOrderColumns = true;
            this.DatMostarDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DatMostarDatos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DatMostarDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatMostarDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DatMostarDatos.Location = new System.Drawing.Point(3, 228);
            this.DatMostarDatos.Name = "DatMostarDatos";
            this.DatMostarDatos.ReadOnly = true;
            this.DatMostarDatos.Size = new System.Drawing.Size(486, 196);
            this.DatMostarDatos.TabIndex = 5;
            this.DatMostarDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MostrarDatos_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "Id";
            this.Column1.FillWeight = 91.37056F;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "Descripcion";
            this.Column2.FillWeight = 108.6294F;
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 350;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(34, 116);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(82, 38);
            this.BtnNuevo.TabIndex = 6;
            this.BtnNuevo.Text = "&Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Enabled = false;
            this.BtnGuardar.Location = new System.Drawing.Point(153, 116);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(82, 38);
            this.BtnGuardar.TabIndex = 7;
            this.BtnGuardar.Text = "&Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.Location = new System.Drawing.Point(271, 116);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(82, 38);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "&Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(384, 116);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(82, 38);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Buscar";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(85, 188);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(381, 20);
            this.TxtBuscar.TabIndex = 11;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 431);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.DatMostarDatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.ChActivo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCategorias";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCategorias";
            this.Load += new System.EventHandler(this.FrmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatMostarDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChActivo;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DatMostarDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBuscar;
    }
}
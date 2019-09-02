namespace ColmadoFactura.Mantenimiento
{
    partial class Categorias_Productos
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.ChActivo = new System.Windows.Forms.CheckBox();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(141, 43);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(81, 20);
            this.TxtId.TabIndex = 2;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(141, 76);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(352, 20);
            this.TxtDescripcion.TabIndex = 3;
            // 
            // ChActivo
            // 
            this.ChActivo.AutoSize = true;
            this.ChActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChActivo.Location = new System.Drawing.Point(141, 123);
            this.ChActivo.Name = "ChActivo";
            this.ChActivo.Size = new System.Drawing.Size(63, 19);
            this.ChActivo.TabIndex = 4;
            this.ChActivo.Text = "Activo";
            this.ChActivo.UseVisualStyleBackColor = true;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(18, 167);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(88, 31);
            this.BtnNuevo.TabIndex = 5;
            this.BtnNuevo.Text = "&Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Enabled = false;
            this.BtnGuardar.Location = new System.Drawing.Point(156, 167);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(88, 31);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "&Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.Location = new System.Drawing.Point(289, 169);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(88, 31);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "&Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(405, 169);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(88, 31);
            this.BtnSalir.TabIndex = 8;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(12, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(491, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Descripcion";
            this.Column2.HeaderText = "Descripción";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 380;
            // 
            // Categorias_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(515, 378);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.ChActivo);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Categorias_Productos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias_Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.CheckBox ChActivo;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
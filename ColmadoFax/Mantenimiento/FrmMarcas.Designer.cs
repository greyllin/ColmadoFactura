namespace ColmadoFax.Mantenimiento
{
    partial class FrmMarcas
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
            this.TxtIdMarcas = new System.Windows.Forms.TextBox();
            this.TxtDescpMarcas = new System.Windows.Forms.TextBox();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DatPresenDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DatPresenDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // TxtIdMarcas
            // 
            this.TxtIdMarcas.Location = new System.Drawing.Point(174, 36);
            this.TxtIdMarcas.Name = "TxtIdMarcas";
            this.TxtIdMarcas.Size = new System.Drawing.Size(75, 20);
            this.TxtIdMarcas.TabIndex = 2;
            // 
            // TxtDescpMarcas
            // 
            this.TxtDescpMarcas.Location = new System.Drawing.Point(174, 67);
            this.TxtDescpMarcas.Name = "TxtDescpMarcas";
            this.TxtDescpMarcas.Size = new System.Drawing.Size(332, 20);
            this.TxtDescpMarcas.TabIndex = 3;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(32, 118);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(86, 31);
            this.BtnNuevo.TabIndex = 4;
            this.BtnNuevo.Text = "&Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(163, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "&Guardar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.Location = new System.Drawing.Point(294, 118);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(86, 31);
            this.BtnEliminar.TabIndex = 6;
            this.BtnEliminar.Text = "&Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(420, 118);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(86, 31);
            this.BtnSalir.TabIndex = 7;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Buscar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 20);
            this.textBox1.TabIndex = 9;
            // 
            // DatPresenDatos
            // 
            this.DatPresenDatos.AllowUserToAddRows = false;
            this.DatPresenDatos.AllowUserToDeleteRows = false;
            this.DatPresenDatos.AllowUserToOrderColumns = true;
            this.DatPresenDatos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DatPresenDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatPresenDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DatPresenDatos.Location = new System.Drawing.Point(21, 213);
            this.DatPresenDatos.Name = "DatPresenDatos";
            this.DatPresenDatos.ReadOnly = true;
            this.DatPresenDatos.Size = new System.Drawing.Size(504, 150);
            this.DatPresenDatos.TabIndex = 10;
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
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 390;
            // 
            // FrmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 375);
            this.Controls.Add(this.DatPresenDatos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.TxtDescpMarcas);
            this.Controls.Add(this.TxtIdMarcas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMarcas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMarcas";
            ((System.ComponentModel.ISupportInitialize)(this.DatPresenDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtIdMarcas;
        private System.Windows.Forms.TextBox TxtDescpMarcas;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView DatPresenDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
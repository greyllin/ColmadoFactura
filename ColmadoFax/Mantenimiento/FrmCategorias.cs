using ColmadoFax.Model;
using ColmadoFax.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColmadoFax.Mantenimiento
{
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            TxtDescripcion.Text = string.Empty;
            TxtId.Text = string.Empty;
            ChActivo.Checked = false;
        }

        private void MostrarItem(Categorias categorias)
        {
            if(categorias==null)
            {
                return;
            }

            TxtId.Enabled = false;
            TxtDescripcion.Text = categorias.Descripcion;
            TxtId.Text = categorias.Id.ToString();
            ChActivo.Checked = categorias.Activa;
            BtnGuardar.Enabled = true;
            BtnEliminar.Enabled = true; 
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            // Limpiar todos los datos//
            Limpiar();
            // Habilitar el Guardado//
            TxtId.Enabled = false;
            //
            BtnGuardar.Enabled = true;
            BtnEliminar.Enabled = false;
            TxtDescripcion.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                {
                    var categoria = new Categorias();
                    categoria.Descripcion = TxtDescripcion.Text;
                    categoria.Activa = ChActivo.Checked;

                    if(!(TxtId.Text.Trim() == string.Empty))
                    {
                        categoria.Id = Convert.ToInt32(TxtId.Text);
                         
                    }

                    using (var db = new Bd())
                    {
                        if (categoria.Id == 0)
                            db.Categorias.Add(categoria);

                        else
                            db.Entry
                                (categoria).State = EntityState.Modified;
                        {
                            if (db.SaveChanges() != 0)
                            MessageBox.Show("Registro guardado Exitosamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BtnGuardar.Enabled = false;
                            BtnEliminar.Enabled = false;
                            Limpiar();
                          mostrarDatos();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void Eliminar(Categorias categorias)
        {
            using( var db = new Bd())
            {
                db.Entry<Categorias>(categorias).State = EntityState.Deleted;
                db.SaveChanges();
            }
            mostrarDatos();
        }
       

        private void mostrarDatos()
        {
            using(var db = new Bd ())
            {
                DatMostarDatos.DataSource = db.Categorias.ToList();
            }
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void MostrarDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex<=-1)
            {
                return;
            }

            var cate = DatMostarDatos.CurrentRow.DataBoundItem as Categorias;
            MostrarItem(cate);

            

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DatMostarDatos.CurrentRow==null)
            {
                return;
            }
            var respuesta = MessageBox.Show("Seguro que desea eliminar esta categoria","Confirmar",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if(respuesta== DialogResult.No)
            {
                return;
            }
            var cate = DatMostarDatos.CurrentRow.DataBoundItem as Categorias;
            Eliminar(cate);
            BtnEliminar.Enabled = false;
            BtnGuardar.Enabled = false;
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            using (var db = new Bd())
            {                                                   /*Codigo Descripcion landa p => p.Descripcion.ToLower().Contains(TxtBuscar.Text.ToLower())
                                                                      || p.Id.ToString().Contains(TxtBuscar.Text)).ToList();me devolvera en una lista en buscar*/
                DatMostarDatos.DataSource = db.Categorias.Where(p => p.Descripcion.ToLower().Contains(TxtBuscar.Text.ToLower())
                                                                      || p.Id.ToString().Contains(TxtBuscar.Text)).ToList();
            }
        }
    }
}

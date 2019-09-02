using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ColmadoFax;
using System.Runtime.Remoting.Contexts;
using ColmadoFax.Model;

namespace ColmadoFax.Negocios
{
  public  class Bd:DbContext

    {
        public Bd():base("Data source=LAPTOP-VF548R2L;initial catalog=ColmadoFact; integrated security= true")
        {

        }

        public DbSet <Categorias> Categorias { get; set; }
        public DbSet <Marcas> Marca { get; set; }
        public DbSet <Productos> Producto { get; set; }

    }
}


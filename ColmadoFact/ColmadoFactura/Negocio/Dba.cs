using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ColmadoFactura.Models;

namespace ColmadoFactura.Negocio
{
    public class Dba : DbContext

    {
        public Dba() : base("Data source=LAPTOP-VF548R2L; initial catalog=ColmadoFactu; integrated security=True")
        {

         }

    public DbSet<Categoria> Categorias { get; set; }

    }
}


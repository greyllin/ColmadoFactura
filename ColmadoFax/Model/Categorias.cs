using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColmadoFax.Model
{
  public  class Categorias
    {
        public int Id { get; set; }
        [MaxLength(100,ErrorMessage = "Maximo de caracteres son 100")] 
        [MinLength(2,ErrorMessage = "Debe Tener al Menos 2 caracteres")]
        public string Descripcion { get; set; }
        public bool Activa { get; set; }
       

    }
}

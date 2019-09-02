using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ColmadoFax.Model
{
    public  class Marcas
    {
        public int Id { get; set; }
        [MaxLength(100, ErrorMessage ="El maximo de caracteres permitido es de 100")]
        [MinLength(2, ErrorMessage ="El minimo de caracteres permitido es de 2")]
        public string Descripcion  { get; set; }

        

    }
}

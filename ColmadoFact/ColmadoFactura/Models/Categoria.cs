using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ColmadoFactura.Models
{
   public class Categoria
    {
        public int Id { get; set; }
        [MaxLength(100, ErrorMessage ="El maximo de caracteres permitido es 100")]
        [MinLength(2, ErrorMessage = "El minimo de caracteres es 2")]
        public string Descripcion { get; set; }
        public bool Activa { get; set; }
    }
}

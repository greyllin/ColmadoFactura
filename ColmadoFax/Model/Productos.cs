using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ColmadoFax.Model
{
  public  class Productos
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        [MaxLength(250, ErrorMessage = "El maximo de caracteres es permitido 250")]
        [MinLength(4, ErrorMessage ="Los caracteres minimo son 4")]
        public string Detalle { get; set; }
        [MaxLength(900, ErrorMessage = "El maximo de caracteres es permitido 900")]
        [MinLength(4, ErrorMessage = "Los caracteres minimo son 4")]
        public decimal Precio { get; set; }
        public string Referencia { get; set; }
        [MaxLength(50, ErrorMessage ="El maximo de caracteres permitido es 50")]
        [MinLength(4, ErrorMessage = "Los caracteres minimo son 4")]
        public decimal PrecioLimite { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal Impuesto { get; set; }
        public bool Caduca { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio1 { get; set; }
        public decimal Precio2 { get; set; }
        public decimal Precio3 { get; set; }
        public bool EsCombo { get; set; }
        public int IdMarcas { get; set; }






    }
}

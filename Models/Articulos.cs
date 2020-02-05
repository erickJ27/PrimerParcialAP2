using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcialAP2.Models
{
    public class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }
        public DateTime Fecha { get; set; }
        //[Required(ErrorMessage ="Tiene que tener una descripcion")]
        public string Descripcion { get; set; }
        [Required]
        [Range(minimum:0,maximum:999999999,ErrorMessage ="Ingrese un costo valido")]
        public decimal Costo { get; set; }
        public int ptcGanancia { get; set; }
        public decimal Precio { get; set; }



    }
}

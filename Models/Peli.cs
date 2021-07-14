using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Razor.Models
{
    public class Peli
    {
        public int  ID{ get; set; }
        [Required(ErrorMessage ="El Titulo es obligatorio")]
        public string Titulo { get; set; }
        [DataType(DataType.Date)]
        [Display (Name ="Fecha del Estreno")]
        [Required(ErrorMessage = "Por Favor, Seleccione una fecha")]
        public DateTime FechaEstreno { get; set; }
        [Display (Name ="Género")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "El Precio es obligatorio")]
        public decimal Precio { get; set; }
        [Display (Name ="Clasificación")]
        [StringLength (5)]
        public string Clasificacion { get; set; }
    }
}

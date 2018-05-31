using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Empleo
    {

        public int EmpleoId { get; set; }

        [Display(Name ="Tipo de cargo")]
        [Required(ErrorMessage = "Campo requerido")]
        public string Cargo { get; set; }

        [Display(Name = "Nombre de emprsa")]
        [Required(ErrorMessage = "Campo requerido")]
        public string Empresa { get; set; }

        [Display(Name = "Fecha inicio")]
        [Required(ErrorMessage = "Campo requerido")]
        public DateTime FechaIni { get; set; }

        [Display(Name = "Fecha fin")]
        [Required(ErrorMessage = "Campo requerido")]
        public DateTime FechaFin { get; set; }
        
        [Display(Name = "Nombre mediador")]
        [Required(ErrorMessage = "Campo requerido")]
        public string Mediador { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Desempleado
    {
        public int DesempleadoId { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "Tiempo que esta desempleado")]
        [StringLength(9, MinimumLength = 3, ErrorMessage = "tenia que poner de 3 a 9 caraccteres")]
        public string tiempo { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "Fecha de inicio de desempleo")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime fecha_ini   { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [Display(Name = "Fecha de fin de desempleo")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime fecha_fin { get; set; }
    }
}

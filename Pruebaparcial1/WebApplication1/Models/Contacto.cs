using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Models
{
    public class Contacto
    {
        [Required(ErrorMessage = "Campo Requerido")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(10, MinimumLength = 0, ErrorMessage = "la cedula solo tiene 10 caracter")]
        public string Motivo { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(10, MinimumLength = 0, ErrorMessage = "la cedula solo tiene 10 caracter")]
        public string Observacion { get; set; }
                public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set;}

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Empleado
    {
        public int IdContactos { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(10, MinimumLength = 0, ErrorMessage = "la cedula solo tiene 10 caracter")]
        public int Cedula { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre tiene que tener minimo 3 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El apellido tiene que tener minimo 3 caracteres")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La direccion tiene que tener minimo 3 caracteres")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(19, MinimumLength = 0, ErrorMessage = "El Telefono tiene que tener maximo 16 caracteres")]
        public int Telefono { get; set; }
   
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El tipo de gabinete tiene que tener minimo 4 caracteres")]
        public string Tipo_gabinete { get; set; }


    }
}

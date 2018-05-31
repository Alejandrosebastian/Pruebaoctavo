using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        [Display(Name ="Nombre")]
        [Required(ErrorMessage ="Campo Requerido")]
        public string Nombre { get; set; }

        [Display(Name ="Apellido")]
        [Required(ErrorMessage ="Campo Requerido")]
        public string Apellido { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        [Required(ErrorMessage = "Campo Requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha_Nacimiento { get; set; }

        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(6, ErrorMessage ="Debe ingresar el Sexo")]
        public string Sexo { get; set; }

        [Display(Name = "Nacionalidad")]
        [Required(ErrorMessage = "Campo Requerido")]
        public string Nacionalidad { get; set; }

        [Display(Name = "Fecha de Alta")]
        [Required(ErrorMessage = "Campo Requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha_Alta { get; set; }

        [Display(Name = "Direccion")]
        [Required(ErrorMessage = "Campo Requerido")]
        public string Direccion { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Telefono")]
        [Required(ErrorMessage = "Campo Requerido")]
        public string Telefono { get; set; }

        [Display(Name = "Estado Civil")]
        [Required(ErrorMessage = "Campo Requerido")]
        public string EstadoCivil { get; set; }

        [Display(Name = "Numero de Hijos")]
        public int NumeroHijos { get; set; }

        [Display(Name = "Numero de Seguridad Social")]
        [Required(ErrorMessage = "Campo Requerido")]
        public int NumeroSeguridadSocial { get; set; }

        [Display(Name = "Tipo de Identificacion")]
        [Required(ErrorMessage = "Campo Requerido")]
        public string Identificacion { get; set; }

        [Display(Name = "Numero de Identificacion")]
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(10, ErrorMessage = "Ingrese un numero de cedula valido")]
        public string N_Identificacion { get; set; }

        [Display(Name = "Permiso de Trabajo")]
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(2, ErrorMessage = "Ingrese un SI o NO")]
        public string Permiso_Trabajo { get; set; }

        [Display(Name = "Permiso de Recidencia")]
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(2, ErrorMessage = "Ingrese SI o NO")]
        public string Permiso_Recidencia { get; set; }

        [Display(Name = "Empadronado")]
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(2, ErrorMessage = "Ingrese un SI o NO")]
        public string Empadronado { get; set; }

        [Display(Name = "Tipo de Licencia")]
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(2,MinimumLength =1, ErrorMessage ="Ingrese un tipo de licencia")]
        public string Tipo_Licencia { get; set; }
    }
}

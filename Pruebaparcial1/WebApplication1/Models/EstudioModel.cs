using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
<<<<<<< HEAD:Pruebaparcial1/WebApplication1/Models/Contrato.cs
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Contrato
    {
        public int ContratosId { get; set; }
        [Display(Name ="Tipo de contrato")]
        [Required(ErrorMessage ="Campo requerido")]
        public string Tipo { get; set; }
        

=======
using WebApplication1.Data;

namespace WebApplication1.Models
{
    public class EstudioModel
    {
    
>>>>>>> c538dcab443adb169d8c334e7dee80abf6a4fd6e:Pruebaparcial1/WebApplication1/Models/EstudioModel.cs
    }
}

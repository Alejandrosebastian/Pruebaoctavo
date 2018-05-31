using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Contrato
    {
        public int ContratosId { get; set; }
        [Display(Name ="Tipo de contrato")]
        [Required(ErrorMessage ="Campo requerido")]
        public string Tipo { get; set; }
        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Usu_empleo
    {
        public int Usu_emploId { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        
        public int EmpleoId { get; set; }
        public Empleo Empleo { get; set; }
        public int DesempleoId { get; set; }
        public Desempleado Desempleado { get; set; }
    }
}

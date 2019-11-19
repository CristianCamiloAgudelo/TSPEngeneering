using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftMan_TSPEnginner.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public String Apellido { get; set; }
        [Required]
        public String Universidad { get; set; }
        [Required]
        public String Codigo { get; set; }
        [Required]
        public String Rol { get; set; }

    }
}

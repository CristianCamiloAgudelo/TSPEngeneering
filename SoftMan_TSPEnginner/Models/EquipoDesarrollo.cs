using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftMan_TSPEnginner.Models
{
    public class EquipoDesarrollo
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        
    }
}

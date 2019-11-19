using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftMan_TSPEnginner.Models
{
    public class PlanGrupal
    {
        public int Id { get; set; }
        
        public virtual ICollection<Tarea> tareas { get; set; }


    }
}

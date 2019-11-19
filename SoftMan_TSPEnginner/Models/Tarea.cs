using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SoftMan_TSPEnginner.Models
{
    public class Tarea
    {
        
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public String MinutosLiderProyecto { get; set; }
        [Required]
        public String MinutosLiderPlaneacion { get; set; }
        [Required]
        public String MinutosLiderDesarrollo { get; set; }
        [Required]
        public String MinutosLiderCalidad { get; set; }
        [Required]
        public String MinutosLiderSoporte { get; set; }
        public String MinutosTotales { get; set; }

        public int PlanGrupalId { get; set; }
        public virtual PlanGrupal planGrupal { get; set; }

        //public Tarea(int Id, string Nombre, String MinutosLiderProyecto, String MinutosLiderPlaneacion, String MinutosLiderDesarrollo, String MinutosLiderCalidad, String MinutosLiderSoporte)
        //{
        //    this.Id = Id;
        //    this.Nombre = Nombre;
        //    this.MinutosLiderProyecto = MinutosLiderProyecto;
        //    this.MinutosLiderPlaneacion = MinutosLiderPlaneacion;
        //    this.MinutosLiderDesarrollo = MinutosLiderDesarrollo;
        //    this.MinutosLiderCalidad = MinutosLiderCalidad;
        //    this.MinutosLiderSoporte = MinutosLiderSoporte;
        //    this.MinutosTotales = "";
            
        //}
    }
}

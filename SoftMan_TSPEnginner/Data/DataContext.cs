using Microsoft.EntityFrameworkCore;
using SoftMan_TSPEnginner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftMan_TSPEnginner.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //crear dbset para el mapeo de entidades
        public DbSet<Tarea> Tareas { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<PlanGrupal> PlanGrupal { get; set; }
    }
}

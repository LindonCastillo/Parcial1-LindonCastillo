using Parcial1_LindonCastillo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_LindonCastillo.DAL
{
    public class Contexto : DbContext
    {
        public DbSet <Productos> productos { get; set; }
    }

    
}

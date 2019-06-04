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
        public DbSet <Productos> Producto { get; set; }
        public DbSet <Modificaciones> Modificacion { get; set; }
        public DbSet <Ubicaciones> Ubicacion { get; set; }

        public Contexto() : base("ConStr")
        { }
    }

    
}

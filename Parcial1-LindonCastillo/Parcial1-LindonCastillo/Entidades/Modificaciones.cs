using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_LindonCastillo.Entidades
{
    class Modificaciones
    {
        [Key]
        public int ModificId { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaModific { get; set; }

        public Modificaciones()
        {
            ModificId = 0;
            Descripcion = string.Empty;
            FechaModific = DateTime.Now;
        }

    }
}

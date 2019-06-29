using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_LindonCastillo.Entidades
{
    public class PrecioDetalle
    {
        private int idProducto;

        public int Id { get; set; }
        public int ProductoId { get; set; }
        public string TipoPrecio { get; set; }
        public decimal Precio { get; set; }

        public PrecioDetalle()
        {
            Id = 0;
            ProductoId = 0;
            TipoPrecio = string.Empty;
            Precio = 0;
        }

        public PrecioDetalle(int id, int idProducto, string tipoPrecio, decimal precio)
        {
            Id = id;
            this.idProducto = idProducto;
            TipoPrecio = tipoPrecio;
            Precio = precio;
        }
    }

}

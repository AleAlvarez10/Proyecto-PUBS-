using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PUBS.Tablas
{
    internal class Descuentos
    {
        public string? discounttype { get; set; }   // Tipo de descuento
        public string? stor_id { get; set; }         // ID de la tienda
        public int? lowqty { get; set; }         // Cantidad mínima
        public int? highqty { get; set; }        // Cantidad máxima
        public decimal discount { get; set; }      // Descuento

        public Descuentos() { }

        public Descuentos(string discounttype, string stor_id, int lowqty, int highqty, decimal discount)
        {
            this.discounttype = discounttype;
            this.stor_id = stor_id;
            this.lowqty = lowqty;
            this.highqty = highqty;
            this.discount = discount;
        }
    }
}

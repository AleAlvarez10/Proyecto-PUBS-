using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PUBS.Tablas
{
    internal class Ventas
    {
        public string stor_id { get; set; }      // Almacén ID (char(4), no permite NULL)

        public string? stor_name { get; set; }

        public string ord_num { get; set; }      // Número de orden (varchar(20), no permite NULL)
        public DateTime ord_date { get; set; }   // Fecha de la orden (datetime, no permite NULL)
        public int qty { get; set; }           // Cantidad (smallint, no permite NULL)
        public string payterms { get; set; }     // Términos de pago (varchar(12), no permite NULL)
        public string title_id { get; set; }

        public string? title { get; set; }

        public decimal? price { get; set; } 

        public Ventas() { }

        // Constructor con parámetros
        public Ventas(string storId, string ord_num, DateTime ordDate, int qty, string payterms, string titleId)
        {
            this.stor_id = storId;
            this.stor_name = stor_name;
            this.ord_num = ord_num;
            this.ord_date = ordDate;
            this.qty = qty;
            this.payterms = payterms;
            this.title_id = titleId;
            this.title = title;
            this.price = price;
        }
    }
}

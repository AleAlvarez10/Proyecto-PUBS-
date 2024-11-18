using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PUBS.Tablas
{
    internal class Titulos
    {
        public string? title_id { get; set; }
        public string? title { get; set; }
        public string? type { get; set; }
        public string? pub_id { get; set; }
        public decimal? price { get; set; } // Ahora es nullable
        public decimal? advance { get; set; } // Ahora es nullable
        public int? royalty { get; set; } // Ahora es nullable
        public int? ytd_sales { get; set; } // Ahora es nullable
        public string? notes { get; set; }
        public DateTime pubdate { get; set; }    // Fecha de publicación

        public Titulos() { }

        // Constructor con parámetros
        public Titulos(string title_id, string title, string type, string pub_id, decimal price, decimal advance, int royalty, int ytd_sales, string? notes, DateTime pubdate)
        {
            this.title_id = title_id;
            this.title = title;
            this.type = type;
            this.pub_id = pub_id;
            this.price = price;
            this.advance = advance;
            this.royalty = royalty;
            this.ytd_sales = ytd_sales;
            this.notes = notes;
            this.pubdate = pubdate;
        }
    }
}

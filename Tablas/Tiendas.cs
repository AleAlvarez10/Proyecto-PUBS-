using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PUBS.Tablas
{
    internal class Tiendas
    {
        public string? stor_id { get; set; }        // Almacén ID
        public string? stor_name { get; set; }      // Nombre de la tienda
        public string? stor_address { get; set; }   // Dirección de la tienda
        public string? city { get; set; }          // Ciudad
        public string? state { get; set; }         // Estado
        public string? zip { get; set; }

        public Tiendas() { }

        public Tiendas(string stor_id, string stor_name, string city, string state, string zip)
        {
            this.stor_id = stor_id;
            this.stor_name = stor_name;
            this.city = city;
            this.state = state;
            this.zip = zip;

        }
    }
}

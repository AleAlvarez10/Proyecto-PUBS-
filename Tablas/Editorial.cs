using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PUBS.Tablas
{
    public class Editorial
    {
        public string? pub_id { get; set; }          // ID del editor
        public string? pub_name { get; set; }        // Nombre del editor
        public string? city { get; set; }           // Ciudad
        public string? state { get; set; }          // Estado
        public string? country { get; set; }        // País

        public Editorial() { }

        // Constructor con parámetros
        public Editorial(string pub_id, string pub_name, string city, string state, string country)
        {
            this.pub_id = pub_id;
            this.pub_name = pub_name;
            this.city = city;
            this.state = state;
            this.country = country;
        }
    }
}

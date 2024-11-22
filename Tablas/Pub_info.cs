using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PUBS.Tablas
{
    internal class Pub_info
    {
        public string? pub_id { get; set; }          // ID del editor

        public string? pub_name {  get; set; }

        public byte[]? logo { get; set; }           // Logo (imagen en binario)
        public string? pr_info { get; set; }         // Información adicional

        public Pub_info() { }

        // Constructor con parámetros
        public Pub_info(string pubId, byte[]? logo, string prInfo)
        {
            this.pub_id = pub_id;
            this.pub_name = pub_name;
            this.logo = logo;
            this.pr_info = pr_info;
        }
    }
}

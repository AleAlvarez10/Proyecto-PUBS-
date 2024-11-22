using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PUBS.Tablas
{
    internal class Roysched
    {
        public string? title_id { get; set; }        // ID del título

        public string title{ get; set; }      //Nombre del titulo

        public int lorange { get; set; }           // Rango bajo
        public int hirange { get; set; }           // Rango alto
        public int royalty { get; set; }           // Regalías

        public Roysched() { }

        // Constructor con parámetros
        public Roysched(string title_id, int lorange, int hirange, int royalty)
        {
            this.title_id = title_id;
            this.title = title;
            this.lorange = lorange;
            this.hirange = hirange;
            this.royalty = royalty;
        }
    }
}

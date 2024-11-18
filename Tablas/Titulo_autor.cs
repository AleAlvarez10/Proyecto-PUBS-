using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PUBS.Tablas
{
    internal class Titulo_autor
    {
        public string? au_id { get; set; }           // ID del autor
        public string? title_id { get; set; }        // ID del título
        public byte? au_ord { get; set; }            // Orden del autor
        public int? royaltyper { get; set; }         // Porcentaje de regalías

        // Constructor por defecto (necesario para inicialización por propiedad)
        public Titulo_autor() { }

        // Constructor con parámetros (opcional)
        public Titulo_autor(string au_id, string title_id, byte? au_ord, int? royaltyper)
        {
            this.au_id = au_id;
            this.title_id = title_id;
            this.au_ord = au_ord;
            this.royaltyper = royaltyper;
        }
    }
}

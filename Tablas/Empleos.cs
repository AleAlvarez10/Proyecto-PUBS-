using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PUBS.Tablas
{
    internal class Empleos
    {
        public int job_id { get; set; }             // ID del puesto
        public string? job_desc { get; set; }        // Descripción del puesto
        public int? min_lvl { get; set; }            // Nivel mínimo
        public int? max_lvl { get; set; }            // Nivel máximo

        public Empleos() { }

        // Constructor con parámetros para inicializar todos los campos
        public Empleos(int job_id, string? job_desc, int? min_lvl, int? max_lvl)
        {
            this.job_id = job_id;
            this.job_desc = job_desc;
            this.min_lvl = min_lvl;
            this.max_lvl = max_lvl;
        }
    }
}

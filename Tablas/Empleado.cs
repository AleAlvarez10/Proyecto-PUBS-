using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PUBS.Tablas
{
    internal class Empleado
    {
        public string? emp_id { get; set; }         // ID del empleado
        public string? fname { get; set; }         // Nombre
        public string? minit { get; set; }         // Inicial del segundo nombre
        public string? lname { get; set; }         // Apellido
        public int job_id { get; set; }
        public string? job_desc { get; set; } // ID del trabajo
        public int job_lvl { get; set; }           // Nivel del trabajo
        public string? pub_id { get; set; }
        public string? pub_name { get; set; }
        public DateTime hire_date { get; set; }    // Fecha de contratación

        public Empleado() { }

        // Constructor con parámetros para inicializar la clase
        public Empleado(string emp_id, string fname, string minit, string lname, int job_id, int job_lvl, string pub_id, DateTime hire_date)
        {
            this.emp_id = emp_id;
            this.fname = fname;
            this.minit = minit;
            this.lname = lname;
            this.job_id = job_id;
            this.job_lvl = job_lvl;
            this.pub_id = pub_id;
            this.pub_name = pub_name;
            this.hire_date = hire_date;
        }
    }
}

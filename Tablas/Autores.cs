using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PUBS.Tablas
{
    public class Autores
    {
        public string? au_id { get; set; }           // ID del autor
        public string? au_lname { get; set; }        // Apellido del autor
        public string? au_fname { get; set; }        // Nombre del autor
        public string? phone { get; set; }          // Teléfono
        public string? address { get; set; }        // Dirección
        public string? city { get; set; }           // Ciudad
        public string? state { get; set; }          // Estado
        public string? zip { get; set; }            // Código postal
        public string? contract { get; set; }         // Contrato (sí/no)

        public Autores() { }

        public Autores(string au_id, string au_lname, string au_fname, string phone, string adress, string city, string state, string zip, string contract)
        {
            this.au_id = au_id;
            this.au_lname = au_lname;
            this.au_fname = au_fname;
            this.phone = phone;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.contract = contract;
            
        }
    }
}

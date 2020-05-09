using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PS1.U3.CansinoNuñezManuelGiovanni.Models
{
    public class Peliculas
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string Resumen { get; set; }
        public DateTime? Fecha_Estreno { get; set; }
    }
}
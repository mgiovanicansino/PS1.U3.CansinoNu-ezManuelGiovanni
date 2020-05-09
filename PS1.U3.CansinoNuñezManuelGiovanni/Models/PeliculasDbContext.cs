using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PS1.U3.CansinoNuñezManuelGiovanni.Models
{
    public class PeliculasDbContext:DbContext
    {
        public PeliculasDbContext():base("MyConnection")
        {

        }

        public DbSet<Peliculas> Pelis { get; set; }
    }
}
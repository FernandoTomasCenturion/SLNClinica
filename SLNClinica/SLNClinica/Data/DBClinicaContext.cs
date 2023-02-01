using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SLNClinica.Models;

namespace SLNClinica.Data
{
    
        public class DBProductosBootcampContext : DbContext
        {
            //Constructor
            public DBProductosBootcampContext() : base("KeyDB") { }

            public List<Clinica> Clinicas { get; set; }
            public List<Clinica> Habitaciones { get; set; }
        //Propiedades DBSET
    }
}


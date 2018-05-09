using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvc_00.Entites
{
    public class EFContext : DbContext
    {
        public EFContext() : base()
        {

        }

        public DbSet<Person>Persons { get; set; } 
        public DbSet<Text>Text { get; set; }
    }
}
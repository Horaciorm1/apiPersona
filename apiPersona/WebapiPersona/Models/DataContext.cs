﻿namespace WebapiPersona.Models

{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")  // Constructor
        {

        }

        public System.Data.Entity.DbSet<WebapiPersona.Models.Person> People { get; set; }
    }
}
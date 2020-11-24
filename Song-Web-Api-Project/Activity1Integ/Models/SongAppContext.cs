using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Activity1Integ.Models
{
    public class SongAppContext : DbContext
    {
        public SongAppContext() : base("SongDb") // name_of_dbconnection_string
        {
        }

        // Map model classes to database tables
        public DbSet<Song> Songs { get; set; }
     
    }
}
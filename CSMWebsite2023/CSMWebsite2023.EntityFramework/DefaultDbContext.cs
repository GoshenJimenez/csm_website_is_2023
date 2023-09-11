using CSMWebsite2023.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMWebsite2023.EntityFramework
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<User>? Users { get; set; }
 


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //List<User>? users = new List<User>();


        }

    }
}

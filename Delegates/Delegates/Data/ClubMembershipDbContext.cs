using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegates.models;
using Microsoft.EntityFrameworkCore;

namespace Delegates.Data
{
    public class ClubMembershipDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={AppDomain.CurrentDomain.BaseDirectory}ClubMembershipDb.db");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> Users { get; set; }
    }
}

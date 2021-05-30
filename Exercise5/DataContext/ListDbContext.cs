using Microsoft.EntityFrameworkCore;
using Exercise5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise5.DataContext
{
    public class ListDbContext : DbContext
    {
        public ListDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<List> Lists{ get; set; }
    }
}
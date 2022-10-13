using System;
using Microsoft.EntityFrameworkCore;
using Web452Assignment1.Models;

namespace Web452Assignment1.Data
{
    public class Web452Assignment1Context : DbContext
    {
        public Web452Assignment1Context(DbContextOptions<Web452Assignment1Context> options) : base(options)
        {

        }

        public DbSet<Bed> Bed { get; set; }
    }
}


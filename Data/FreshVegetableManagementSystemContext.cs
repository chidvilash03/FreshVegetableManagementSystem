using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FreshVegetableManagementSystem.Models;

namespace FreshVegetableManagementSystem.Data
{
    public class FreshVegetableManagementSystemContext : DbContext
    {
        public FreshVegetableManagementSystemContext (DbContextOptions<FreshVegetableManagementSystemContext> options)
            : base(options)
        {
        }

        public DbSet<FreshVegetableManagementSystem.Models.VegetableDetails> VegetableDetails { get; set; } = default!;
    }
}

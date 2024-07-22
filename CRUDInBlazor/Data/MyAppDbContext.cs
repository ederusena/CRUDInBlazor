using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDInBlazor.Models;

namespace CRUDInBlazor.Data
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext (DbContextOptions<MyAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<CRUDInBlazor.Models.Product> Product { get; set; } = default!;
    }
}

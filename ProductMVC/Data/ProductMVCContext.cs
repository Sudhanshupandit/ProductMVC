using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductMVC.Models;

namespace ProductMVC.Data
{
    public class ProductMVCContext : DbContext
    {
        public ProductMVCContext (DbContextOptions<ProductMVCContext> options)
            : base(options)
        {
        }

        public DbSet<ProductMVC.Models.Products> Products { get; set; } = default!;
    }
}

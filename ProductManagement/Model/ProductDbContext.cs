using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Model
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext>options):base(options)
        {

        }
       public DbSet<Product> products { get; set; }
       public DbSet<Category> categories { get; set; }
    }
}

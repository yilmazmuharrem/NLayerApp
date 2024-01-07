using Microsoft.EntityFrameworkCore;
using NLayerApp.Core.Models;
using NLayerApp.Core.Repositories;
using NLayerApp.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetProductsWithCategory()
        {
            // eager loading
           return  await _context.Products.Include(x=>x.Category).ToListAsync();
        }
    }
}

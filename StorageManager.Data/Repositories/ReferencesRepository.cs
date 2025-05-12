using Microsoft.EntityFrameworkCore;
using StorageManager.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager.Data.Repositories
{
    public class ReferencesRepository
    {
        private readonly SMContext _context;

        public ReferencesRepository(SMContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductReference> GetAll(bool loadOtherEntities = false)
        {
            if (loadOtherEntities)
            {
                return _context.Products
                    .Include(p => p.StoredProducts)
                    .Include(p => p.Category)
                    .ToList();
            }
            else
            {
                return _context.Products.ToList();
            }
        }

        public void Add(ProductReference productReference)
        {
            _context.Products.Add(productReference);
        }

        public ProductReference? Get(int Id, bool loadOtherEntities = false)
        {
            if (loadOtherEntities)
            {
                return _context.Products
                    .Include(p => p.Category)
                    .Include(p => p.StoredProducts)
                    .FirstOrDefault(x => x.Id == Id);
            }
            else
            {
                return _context.Products.FirstOrDefault(x => x.Id == Id);
            }
        }

        public void Update(ProductReference productReference)
        {
            _context.Products.Update(productReference);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var el = _context.Products.Find(Id);

            if (el != null)
            {
                _context.Products.Remove(el);
                _context.SaveChanges();
            }
        }
    }
}

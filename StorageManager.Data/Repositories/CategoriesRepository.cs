using Microsoft.EntityFrameworkCore;
using StorageManager.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager.Data.Repositories
{
    public class CategoriesRepository
    {
        private readonly SMContext _context;

        public CategoriesRepository(SMContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAll(bool loadOtherEntities = false)
        {
            if (loadOtherEntities)
            {
                return _context.Categories
                    .Include(c => c.Products)
                    .ToList();
            }
            else
            {
                return _context.Categories.ToList();
            }
        }

        public void Add(Category category)
        {
            _context.Categories.Add(category);
        }

        public Category? Get(int Id, bool loadOtherEntities = false)
        {
            if (loadOtherEntities)
            {
                return _context.Categories
                    .Include(c => c.Products)
                    .FirstOrDefault(x => x.Id == Id);
            }
            else
            {
                return _context.Categories.FirstOrDefault(x => x.Id == Id);
            }
        }

        public void Update(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var el = _context.Categories.Find(Id);

            if (el != null)
            {
                _context.Categories.Remove(el);
                _context.SaveChanges();
            }
        }
    }
}

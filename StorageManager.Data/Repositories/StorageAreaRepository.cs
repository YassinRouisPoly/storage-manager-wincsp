using Microsoft.EntityFrameworkCore;
using StorageManager.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager.Data.Repositories
{
    public class StorageAreaRepository
    {
        private readonly SMContext _context;

        public StorageAreaRepository(SMContext context)
        {
            _context = context;
        }

        public IEnumerable<StorageArea> GetAll(bool loadOtherEntities = false)
        {
            if (loadOtherEntities)
            {
                return _context.StorageAreas
                    .Include(a => a.Boxes)
                    .Include(a => a.FilterCategory)
                    .ToList();
            }
            return _context.StorageAreas.ToList();
        }

        public void Add(StorageArea area)
        {
            _context.StorageAreas.Add(area);
        }

        public StorageArea? Get(int id, bool loadOtherEntities = false)
        {
            if (loadOtherEntities)
            {
                return _context.StorageAreas
                    .Include(a => a.Boxes)
                    .Include(a => a.FilterCategory)
                    .FirstOrDefault(a => a.Id == id);
            }
            return _context.StorageAreas.FirstOrDefault(a => a.Id == id);
        }

        public void Update(StorageArea area)
        {
            _context.StorageAreas.Update(area);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var area = _context.StorageAreas.Find(id);
            if (area != null)
            {
                _context.StorageAreas.Remove(area);
                _context.SaveChanges();
            }
        }

        // Méthodes spécifiques
        public IEnumerable<StorageArea> GetByCategoryFilter(int categoryId)
        {
            return _context.StorageAreas
                .Where(a => a.FilterCategory != null && a.FilterCategory.Id == categoryId)
                .ToList();
        }

        public int GetBoxCount(int areaId)
        {
            return _context.StorageAreas
                .Where(a => a.Id == areaId)
                .SelectMany(a => a.Boxes)
                .Count();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using StorageManager.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager.Data.Repositories
{
    public class StorageBoxRepository
    {

        private readonly SMContext _context;

        public StorageBoxRepository(SMContext context)
        {
            _context = context;
        }

        // Méthodes CRUD de base
        public IEnumerable<StorageBox> GetAll(bool loadOtherEntities = false)
        {
            if (loadOtherEntities)
            {
                return _context.StorageBoxes
                    .Include(b => b.Area)
                    .Include(b => b.Products)
                    .Include(b => b.FilterCategory)
                    .ToList();
            }
            return _context.StorageBoxes.ToList();
        }

        public void Add(StorageBox box)
        {
            _context.StorageBoxes.Add(box);
        }

        public StorageBox? Get(int id, bool loadOtherEntities = false)
        {
            if (loadOtherEntities)
            {
                return _context.StorageBoxes
                    .Include(b => b.Area)
                    .Include(b => b.Products)
                    .Include(b => b.FilterCategory)
                    .FirstOrDefault(b => b.Id == id);
            }
            return _context.StorageBoxes.FirstOrDefault(b => b.Id == id);
        }

        public void Update(StorageBox box)
        {
            _context.StorageBoxes.Update(box);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var box = _context.StorageBoxes.Find(id);
            if (box != null)
            {
                _context.StorageBoxes.Remove(box);
                _context.SaveChanges();
            }
        }

        // Méthodes spécifiques
        public IEnumerable<StorageBox> GetBoxesByArea(int areaId)
        {
            return _context.StorageBoxes
                .Where(b => b.AreaId == areaId)
                .ToList();
        }

        public IEnumerable<StorageBox> GetEmptyBoxes()
        {
            return _context.StorageBoxes
                .Where(b => !b.IsFull)
                .ToList();
        }

        public IEnumerable<StorageBox> GetBoxesByCategoryFilter(int categoryId)
        {
            return _context.StorageBoxes
                .Where(b => b.FilterCategory != null && b.FilterCategory.Id == categoryId)
                .ToList();
        }

        public void MarkAsFull(int boxId, bool isFull)
        {
            var box = _context.StorageBoxes.Find(boxId);
            if (box != null)
            {
                box.IsFull = isFull;
                _context.SaveChanges();
            }
        }

        public int GetProductCount(int boxId)
        {
            return _context.StorageBoxes
                .Where(b => b.Id == boxId)
                .SelectMany(b => b.Products)
                .Count();
        }
    }
}

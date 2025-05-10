using StorageManager.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager.Data.Repositories
{
    public class StorageRepository
    {
        private readonly SMContext _context;

        public StorageRepository(SMContext context)
        {
            _context = context;
        }

        public IEnumerable<StorageArea> GetAllAreas()
        {
            return _context.StorageAreas.ToList();
        }

        public IEnumerable<StorageBox> GetAllBoxes()
        {
            return _context.StorageBoxes.ToList();
        }

        public IEnumerable<StoredProduct> GetAllStoredProducts()
        {
            return _context.StoredProducts.ToList();
        }
    }
}

using StorageManager.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager.Data.Repositories
{
    public class ProductTransferRepository
    {
        private readonly SMContext _context;

        public ProductTransferRepository(SMContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductTransfer> GetAll(bool loadOtherEntities = false)
        {
            if (loadOtherEntities)
            {
                return _context.Transfers
                    .Include(pt => pt.LinkedBox)
                    .Include(pt => pt.LinkedProductReference)
                    .ToList();
            }
            else
            {
                return _context.Transfers.ToList();
            }
        }

        public void Add(ProductTransfer productTransfer)
        {
            _context.Transfers.Add(productTransfer);
        }

        public ProductTransfer? Get(int Id, bool loadOtherEntities = false)
        {
            if (loadOtherEntities)
            {
                return _context.Transfers
                    .Include(pt => pt.LinkedBox)
                    .Include(pt => pt.LinkedProductReference)
                    .FirstOrDefault(x => x.Id == Id);
            }
            else
            {
                return _context.Transfers.FirstOrDefault(x => x.Id == Id);
            }
        }

        public void Update(ProductTransfer productTransfer)
        {
            _context.Transfers.Update(productTransfer);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var el = _context.Transfers.Find(Id);

            if (el != null)
            {
                _context.Transfers.Remove(el);
                _context.SaveChanges();
            }
        }

        public IEnumerable<ProductTransfer> GetByState(TransferState state)
        {
            return _context.Transfers
                .Where(pt => pt.State == state)
                .ToList();
        }

        public IEnumerable<ProductTransfer> GetByType(TransferType type)
        {
            return _context.Transfers
                .Where(pt => pt.Type == type)
                .ToList();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using StorageManager.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager.Data.Repositories
{
    public class UsersRepository
    {
        private readonly SMContext _context;

        public UsersRepository(SMContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public IEnumerable<User> GetAllByRole(UserRole role)
        {
            return _context.Users
                .Where(u => u.Role == role)
                .ToList();
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User? Get(int Id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == Id);
        }

        public User? FindByUsername(string username)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username);
        }

        public void Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var el = _context.Users.Find(Id);

            if (el != null)
            {
                _context.Users.Remove(el);
                _context.SaveChanges();
            }
        }

    }
}

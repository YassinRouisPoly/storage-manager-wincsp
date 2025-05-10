using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager.Data.Entities
{
    public enum UserRole
    {
        STAFF,
        MANAGER,

    }

    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Username { get; set; }
        public string PasswordHash { get; set; }

        public DateTime CreationTime { get; set; }
    }
}

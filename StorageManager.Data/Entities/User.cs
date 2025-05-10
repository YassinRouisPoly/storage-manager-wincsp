using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager.Data.Entities
{
    public enum UserRole
    {
        STAFF      = 0,
        MANAGER    = 1,
        ADMIN      = 2,
        SUPERADMIN = 3
    }

    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }
        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public UserRole Role { get; set; }

        public DateTime CreationTime { get; set; }


        // ===== PERMISSIONS : TRANSFERTS ===========================
        public bool CanValidateTransfers()   { return Role >= UserRole.STAFF; }
        public bool CanSeeCurrentTransfers() { return Role >= UserRole.STAFF; }
        public bool CanSeePlannedTransfers() { return Role >= UserRole.MANAGER; }
        public bool CanEditTransfers()       { return Role >= UserRole.MANAGER; }

        // ===== PERMISSIONS : STORAGE ==============================
        public bool CanManageStorage() { return Role >= UserRole.ADMIN; }

        // ===== PERMISSIONS : USERS ================================
        public bool CanManageUsers() { return Role >= UserRole.SUPERADMIN; }
    }
}

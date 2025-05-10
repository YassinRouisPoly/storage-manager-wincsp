using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager.Data.Entities
{
    public class StorageBox
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        [ForeignKey("StorageArea")]
        public int AreaId { get; set; }
        public StorageArea Area { get; set; }

        [Required]
        public bool IsFull { get; set; }

        [InverseProperty("Box")]
        public ICollection<StoredProduct> Products { get; set; }


    }
}

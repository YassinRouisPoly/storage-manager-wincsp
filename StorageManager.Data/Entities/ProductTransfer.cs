using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager.Data.Entities
{
    public enum TransferState
    {
        PENDING,
        PLANNED,
        DONE
    }

    public enum TransferType
    {
        LOAD,
        UNLOAD
    }

    public class ProductTransfer
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }

        [Required]
        public TransferState State { get; set; }
        [Required]
        public TransferType Type { get; set; }
        public DateTime? DateTime { get; set; }


        [Required]
        [ForeignKey("StorageBox")]
        public int LinkedBoxId { get; set; }
        public StorageBox LinkedBox { get; set; }

        [Required]
        [ForeignKey("ProductReference")]
        public int LinkedProductRefenceId { get; set; }
        public ProductReference LinkedProductReference { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}

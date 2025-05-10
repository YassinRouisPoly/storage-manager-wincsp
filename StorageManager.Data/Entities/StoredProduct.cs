using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager.Data.Entities
{
    public class StoredProduct
    {
        [Key]
        public int Id { get; set; }

        public int Quantity { get; set; }

        public int ProductReferenceId { get; set; }
        public ProductReference ProductReference { get; set; }

        public int BoxId { get; set; }
        public StorageBox Box { get; set; }
    }
}

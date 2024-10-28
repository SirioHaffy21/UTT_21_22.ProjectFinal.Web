using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTT_21_22.ProjectFinal.Data.Databases
{
    public class CategoryStore
    {
        [Key]
        public int CategoryStoreId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(30)]
        public string CategoryStoreName { get; set; }

        public ICollection<Store> Stores { get; set; }
    }
}

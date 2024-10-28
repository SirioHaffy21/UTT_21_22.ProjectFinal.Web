using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTT_21_22.ProjectFinal.Data.Databases
{
    public class CategoryWatch
    {
        [Key]
        public int CategoryWatchId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(30)]
        public string CategoryWatchName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(200)]
        public string Description { get; set; }

        public ICollection<Watch> Watches { get; set; }
    }
}

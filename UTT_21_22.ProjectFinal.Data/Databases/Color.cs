using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTT_21_22.ProjectFinal.Data.Databases
{
    public class Color
    {
        [Key]
        public int ColorId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(25)]
        public string ColorName { get; set; }

        public ICollection<Watch> Watches { get; set; }

    }
}

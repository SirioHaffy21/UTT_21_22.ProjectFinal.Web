using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTT_21_22.ProjectFinal.Data.Databases
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(30)]
        public string BrandName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(30)]
        public string Owner { get; set; }

        [Required]
        [Column(TypeName ="nvarchar")]
        [MaxLength(150)]
        public string Description { get; set; }

        public DateTime CreateTime { get; set; }

        public ICollection<Watch> Watches { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTT_21_22.ProjectFinal.Data.Databases
{
    public class Review
    {
        [Key]
        [Column(TypeName = "varchar")]
        [MinLength(10)]
        public string ReviewId { get; set; }

        [Required]
        public decimal PointRating { get; set; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(250)]
        public string ReviewContent { get; set; }

        public int? Status { get; set; }

        [Required]
        public DateTime TimePost { get; set; }

        [Required]
        public DateTime TimeModified { get; set; }

        public ICollection<Store> Stores { get; set; }

        public ICollection<Watch> Watches { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
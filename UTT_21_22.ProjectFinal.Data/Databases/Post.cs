using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTT_21_22.ProjectFinal.Data.Databases
{
    public class Post
    {
        [Key]
        [Column(TypeName = "varchar")]
        [MinLength(10)]
        public string PostId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(20)]
        public string PostTitle { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(200)]
        public string PostContent { get; set; }

        public int? CategoryPostId { get; set; }

        [ForeignKey("CategoryPostId")]
        public CategoryPost CategoryPost { get; set; }

        public byte[] Image { get; set; }

        public int Status { get; set; }

        [Required]
        public DateTime TimePost { get; set; }

        [Required]
        public DateTime TimeModified { get; set; }

        [Column(TypeName = "varchar")]
        [MinLength(10)]
        public string ReviewId { get; set; }

        [ForeignKey("ReviewId")]
        public Review Review { get; set; }

        public ICollection<Admin> Admins { get; set; }
    }
}
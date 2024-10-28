using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTT_21_22.ProjectFinal.Data.Databases
{
    public class CategoryPost
    {
        [Key]
        public int CategoryPostId { get; set; }

        [Required]
        [Column(TypeName ="nvarchar")]
        [MaxLength(20)]
        public string CategoryPostName { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
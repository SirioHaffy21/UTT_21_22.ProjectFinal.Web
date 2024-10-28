using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTT_21_22.ProjectFinal.Data.Databases
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [Required]
        [Column(TypeName ="nvarchar")]
        [MaxLength(20)]
        public string RoleName { get; set; }

        public int RuleId { get; set; }
        [ForeignKey("RuleId")]
        public Rule Rule { get; set; }

        public int? ParentId { get; set; }
    }
}
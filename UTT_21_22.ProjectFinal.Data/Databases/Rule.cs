using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTT_21_22.ProjectFinal.Data.Databases
{
    public class Rule
    {
        [Key]
        public int RuleId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(20)]
        public string RuleName { get; set; }

        public ICollection<Role> Roles { get; set; }

        public ICollection<Admin> Admins { get; set; }
    }
}
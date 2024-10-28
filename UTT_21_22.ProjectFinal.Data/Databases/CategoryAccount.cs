using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTT_21_22.ProjectFinal.Data.Databases
{
    public class CategoryAccount
    {
        [Key]
        public int CategoryAccountId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(150)]
        public string CategoryAccountName { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}
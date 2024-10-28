using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTT_21_22.ProjectFinal.Data.Databases
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        public int CategoryAccountId { get; set; }

        [ForeignKey("CategoryAccountId")]
        public CategoryAccount CategoryAccount { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        [MinLength(3)]
        public string UserName { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [DataType(DataType.Password)]
        [MaxLength(50)]
        [MinLength(8)]
        public string Password { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(30)]
        [MinLength(8)]
        public string CreateUser { get; set; }

        [Required]
        public DateTime CreateTime { get; set; }

        [Required]
        public DateTime TimeExpired { get; set; }

        public ICollection<Admin> Admins { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}
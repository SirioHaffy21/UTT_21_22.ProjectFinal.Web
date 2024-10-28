using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTT_21_22.ProjectFinal.Data.Databases
{
    public class Customer
    {
        [Key]
        public string CustomerId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(30)]
        public string CustomerName { get; set; }

        [Required]
        public int Sex { get; set; }

        public DateTime BirthDate { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [DataType(DataType.PhoneNumber)]
        [MaxLength(20)]
        [MinLength(6)]
        public string NumberPhone { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(25)]
        [MinLength(6)]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(25)]
        [MinLength(6)]
        public string HomeTown { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(25)]
        [MinLength(6)]
        public string PermanentAddress { get; set; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(200)]
        public string Note { get; set; }

        public int AccountId { get; set; }

        [ForeignKey("AccountId")]
        public Account Account { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTT_21_22.ProjectFinal.Data.Databases
{
    public class Watch
    {
        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string WatchId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        [MaxLength(20)]
        public string WatchName { get; set; }

        public int? ColorId { get; set; }

        [ForeignKey("ColorId")]
        public Color Color { get; set; }

        public int? CategoryWatchId { get; set; }

        [ForeignKey("CategoryWatchId")]
        public CategoryWatch CategoryWatch { get; set; }

        public int Status { get; set; }

        public int BusinessStatus { get; set; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(150)]
        public string Description { get; set; }

        [Column(TypeName = "nvarchar")]
        [MaxLength(150)]
        public string DetailInformation { get; set; }

        public DateTime TimeManufacture { get; set; }

        public int Insurance { get; set; }

        public double? Price { get; set; }

        public byte[] Image { get; set; }

        [Column(TypeName = "varchar")]
        [MinLength(10)]
        public string ReviewId { get; set; }

        [ForeignKey("ReviewId")]
        public Review Review { get; set; }

        public ICollection<StoreWatch> StoreWatches { get; set; }
    }
}
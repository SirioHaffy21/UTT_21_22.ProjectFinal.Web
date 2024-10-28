using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTT_21_22.ProjectFinal.Data.Databases
{
    public class StoreWatch
    {
        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string StoreId { get; set; }

        public Store Store { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string WatchId { get; set; }

        public Watch Watch { get; set; }
    }
}
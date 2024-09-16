using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Budget_Tracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public int CategoyId { get; set; }
        public Category Category { get; set; }
        public int Amount { get; set; }

        [Column(TypeName = "nvarchar(199)")]
        public string Note { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; } = DateTime.Now;
    }
}

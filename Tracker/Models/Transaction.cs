using System.ComponentModel.DataAnnotations;

namespace Tracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Note { get; set; } = string.Empty;
        public int Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}

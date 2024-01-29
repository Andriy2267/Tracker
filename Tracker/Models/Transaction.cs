using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public string Note { get; set; } = string.Empty;
        public int Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        [NotMapped]
        public string? CategoryTitleWithIcon
        {
            get
            {
                return Category is null ? "" : Category.Icon + " " + Category.Title;
            }
        }

        [NotMapped]
        public string ? FormattedAmount
        {
            get
            {
                return ((Category is null || Category.Type is "Expense") ? " -" : "+ ") + Amount.ToString("C0");
            }
        }
    }
}

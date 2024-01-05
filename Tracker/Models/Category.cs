using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tracker.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(50)")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Icon { get; set; } = string.Empty;
        [Required]
        [Column(TypeName = "nvarchar(15)")]
        public string Type { get; set; } = "Expense";
    }
}

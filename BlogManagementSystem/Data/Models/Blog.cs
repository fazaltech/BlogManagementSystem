using System.ComponentModel.DataAnnotations;

namespace BlogManagementSystem.Data.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string BlogDescription { get; set; }
        public int UserId { get; set; }
    }
}

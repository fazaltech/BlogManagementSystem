using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlogManagementSystem.Data.Models
{
    public class RefreshToken
    {
        [Key]
        public int Id { get; set; }

        public string Token { get; set; }

        public string JwtId { get; set; }

        public bool IsRevoked { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime DateExpire { get; set; }

        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))]

        public ApplicationUser User { get; set; }

    }
}

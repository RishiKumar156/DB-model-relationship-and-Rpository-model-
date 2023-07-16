using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations.Schema;

namespace Patric_God.Models
{
    public class Blog
    {
        public int Id { get; set; }

        public string BLogName { get; set; } = string.Empty;

        public string BlogDescription { get; set; } = string.Empty;

        public string BlogType { get; set; } = string.Empty;

        //navigating Blog to get a user to create a new Blog
        [ForeignKey("UserID")]
        public int UserID { get; set; }
        public User User { get; set; }

        public ICollection<Post> Posts { get; set; }   
    }
}

using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations.Schema;

namespace Patric_God.Models
{
    public class Post
    {
        public int Id { get; set; } 

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;

        public DateTime Created { get; set; }

        //navigating the post to get an Blog id Create a new Post
        [ForeignKey("BlogID")]
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}

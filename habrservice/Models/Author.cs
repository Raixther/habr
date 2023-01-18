using System.ComponentModel.DataAnnotations.Schema;

namespace habrservice.Models
{
    public class Author
    {
        public int Id{ get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
      
        public ICollection<Article> Articles { get; set; } = new HashSet<Article>();

        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();

    }
}

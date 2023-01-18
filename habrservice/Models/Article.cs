using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

using System.ComponentModel.DataAnnotations.Schema;

namespace habrservice.Models
{
    public class Article
    {
        public int Id { get; set; }
        public int AuthorId{ get; set; }  
        
        public int HubId{ get; set; }

        public Author Author { get; set; }

        public Hub Hub { get; set; }

        public DateTime PublicationDate { get; } = DateTime.UtcNow;

        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public int Likes { get; set; }

        public int Dislikes{ get; set; }

        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();

              
    }
}

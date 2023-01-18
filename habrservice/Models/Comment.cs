using System.ComponentModel.DataAnnotations.Schema;

namespace habrservice.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Content { get; set; } = string.Empty;

        public int AuthorId { get; set; }

        public Author Author{ get; set; }

        public int ArticleId{ get; set; }

        public Article Article{ get; set; }

    }
 }


namespace habrservice.Models
{
    public class Hub
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Article> Articles { get; set; } = new HashSet<Article>();

    }
}

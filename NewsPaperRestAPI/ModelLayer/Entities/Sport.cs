using InfrastructorLayer.Model;

namespace ModelLayer.Entities
{
    public class Sport : BaseRecord<int>
    {
        public string Type { get; set; }
        public string SeoTitle { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}

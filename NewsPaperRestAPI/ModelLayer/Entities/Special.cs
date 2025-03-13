using InfrastructorLayer.Model;

namespace ModelLayer.Entities
{
    public class Special: BaseRecord<int>
    {
        public string PageName { get; set; }
       
        public string Description { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
        public string SeoKeywords { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public Author Author { get; set; }
        public Category Category { get; set; }
    }
}

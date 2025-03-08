using InfrastructorLayer.Model;

namespace ModelLayer.Entities
{
    public class Agenda:BaseRecord<int>
    {
        public string Summary { get; set; }
        public string Tags { get; set; }
        public int LikeCount { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}

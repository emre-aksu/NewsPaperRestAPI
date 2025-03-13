using InfrastructorLayer.Model;
using Microsoft.AspNetCore.Http;

namespace ModelLayer.Dtos.AgendaDtos
{
    public class AgendaPostDto:InterfaceDataTransferObject
    {
        public string Description { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int ViewCount { get; set; }  
        public int LikeCount { get; set; }
        public string CoverImage { get; set; }
        public bool Status { get; set; }
        public IFormFile Picture { get; set; }
        public int CategoryId { get; set; } 
        public int AuthorId { get; set; }
    }
}

using InfrastructorLayer.Model;
using Microsoft.AspNetCore.Http;

namespace ModelLayer.Dtos.AuthorDtos
{
    public class AuthorPostDto:InterfaceDataTransferObject
    {
        public string FirstName { get; set; }  // Ad 
        public string LastName { get; set; }   // Soyad
        public string Biography { get; set; }  // Biyografi
        public string CoverImage { get; set; } // Kapak Resmi
        public string Phone { get; set; } // Telefor 
        public string Email { get; set; } // Email  
        public IFormFile Picture { get; set; } // Resim
    }
}

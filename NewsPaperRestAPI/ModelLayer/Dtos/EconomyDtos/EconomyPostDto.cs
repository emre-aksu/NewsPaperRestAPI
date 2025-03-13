using InfrastructorLayer.Model;
using Microsoft.AspNetCore.Http;

namespace ModelLayer.Dtos.EconomyDtos
{
    public class EconomyPostDto:InterfaceDataTransferObject
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile Picture { get; set; }  // Resim    
        public string CoverImage { get; set; }// Kapak Resmi
        public string Content { get; set; } // İçerik 
        public DateTime PublishedDate { get; set; } // Yayınlanma Tarihi
        public DateTime UpdateDate { get; set; } // Güncellenme Tarihi
        public string Title { get; set; } // Başlık
        public decimal ExchangeRates { get; set; } // Döviz Kurları
        public string StockIndex { get; set; } // Hisse Senetleri
        public decimal GoldPrice { get; set; } // Altın Fiyatları
        public int CategoryId { get; set; } // Kategori Id
        public int AthorId { get; set; } // Yazar Id
    }
}

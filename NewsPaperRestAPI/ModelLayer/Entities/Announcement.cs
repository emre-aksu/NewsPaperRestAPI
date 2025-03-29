using InfrastructorLayer.Model;

namespace ModelLayer.Entities
{
    public class Announcement:BaseRecord<int>
    {
     
        public string Institution { get; set; } // Kurum adı
        public string Content { get; set; } // İlan içeriği
        public DateTime PublicationDate { get; set; } // İlan yayın tarihi
        public DateTime DeadlineDate { get; set; } // İlan son başvuru tarihi
        public string Type { get; set; } // İlan türü
         public string SeoTitle { get; set; } // Seo başlık (Dolar/TL 2024: Güncel Kur Analizi ve Yorumlar vs için)
        public string SeoDescription { get; set; } // Seo açıklama
       
        public List<Author> Authors { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public Category Categories { get; set; }


    }
}

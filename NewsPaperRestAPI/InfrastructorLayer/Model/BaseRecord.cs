namespace InfrastructorLayer.Model
{
    public class BaseRecord<TId>
    {
        public TId Id { get; set; }
        public string CoverImage { get; set; }
        public byte[] Picture { get; set; }
        public string? Title { get; set; }
        public DateTime? CreatedDate { get; set; } // İlan oluşturulma tarihi
        public DateTime? UpdatedDate { get; set; } // İlan güncellenme tarihi
        public bool Status { get; set; } // İlan durumu
        public string Content { get; set; }
        public DateTime? PublishedDate { get; set; }
        public int? ViewCount { get; set; }

    }
}

using InfrastructorLayer.Model;

namespace ModelLayer.Entities
{
    public class Economy: BaseRecord<int>
    {
        public string Name { get; set; }    
        public string Description { get; set; }
        public decimal ExchangeRates { get; set; }
        public string StockIndex { get; set; }
        public DateTime GoldPrices { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }


    }
}

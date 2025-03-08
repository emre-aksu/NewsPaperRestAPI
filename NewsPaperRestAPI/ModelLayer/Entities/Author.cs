using InfrastructorLayer.Model;

namespace ModelLayer.Entities
{
    public class Author:BaseRecord<int>
    {
        public string FirsName { get; set; }    
        public string LastName { get; set; }
        public string Biography { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}

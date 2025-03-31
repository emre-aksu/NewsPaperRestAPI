using InfrastructorLayer.Model;

namespace ModelLayer.Entities
{
    public class Author:BaseRecord<int>
    {
        public string FirstName { get; set; }     
        public string LastName { get; set; }
        public string Biography { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int AnnouncementId { get; set; }
        public int AgendaId { get; set; }
        public Announcement? Announcements { get; set; }
        public Agenda? Agendas { get; set; }

    }
}

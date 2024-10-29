namespace HW10.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        
        public string Surname { get; set; }

        public string? Patronymic { get; set; }

        public string Document { get; set; }

        public DateTime Birthday { get; set; }
    }
}

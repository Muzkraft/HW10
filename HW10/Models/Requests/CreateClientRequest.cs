namespace HW10.Models.Requests
{
    public class CreateClientRequest
    {
        public string Document { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public  string Patronymic { get; set; }
        public DateTime Birthday { get; set; }
    }
}

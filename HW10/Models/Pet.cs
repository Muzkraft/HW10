namespace HW10.Models
{
    public class Pet
    {
        public int PetId { get; set; }
        public string? Name { get; set; }

        public int ClientId { get; set; }

        public DateTime Birthday { get; set; }
    }
}

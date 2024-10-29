namespace HW10.Models
{
    public class Consultation
    {
        public int ConsultationId { get; set; }

        public string Description { get; set; }

        public DateTime ConsultationDate { get; set; }

        public int ClientId { get; set; }

        public int PetId { get; set; }
    }
}

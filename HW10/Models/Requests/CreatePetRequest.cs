﻿namespace HW10.Models.Requests
{
    public class CreatePetRequest
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }
}

namespace apartment.Controllers
{
    public class Resident
    {
        public int Id { get; set; }
        public string ResidentName { get; set; }
        public string ResidentPhone { get; set; }

        public string ApartmentNumber { get; set; }

        public string FloorNumber { get; set; }

        public bool RentStatus { get; set; }

        public string Type { get; set; }

        public bool DuesStatus { get; set; }

        public string Bills { get; set; }
    }
}
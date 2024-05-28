namespace BePlus.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public string DonorCNIC { get; set; }
        public int CollectionID { get; set; }
        public DateTime AppointmentDate { get; set; }

        public Donor Donor { get; set; }
        public CollectionPoint CollectionPoint { get; set; }
    }
}

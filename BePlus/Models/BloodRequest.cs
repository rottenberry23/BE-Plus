namespace BePlus.Models
{
    public class BloodRequest
    {
        public int RequestID { get; set; }
        public string PatientName { get; set; }
        public string PatientCNIC { get; set; }
        public int HospitalID { get; set; }
        public string BloodType { get; set; }
        public int Quantity { get; set; }
        public DateTime RequestDate { get; set; }

        public RegisteredHospital Hospital { get; set; }
    }
}

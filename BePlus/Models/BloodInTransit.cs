namespace BePlus.Models
{
    public class BloodInTransit
    {
        public int TransitID { get; set; }
        public string DonorCNIC { get; set; }
        public int DeliveryStaffID { get; set; }
        public int HospitalID { get; set; }
        public string BloodType { get; set; }
        public int Quantity { get; set; }
        public DateTime DispatchDate { get; set; }

        public Donor Donor { get; set; }
        public DeliveryStaff DeliveryStaff { get; set; }
        public RegisteredHospital Hospital { get; set; }
    }
}

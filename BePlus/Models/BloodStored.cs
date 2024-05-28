namespace BePlus.Models
{
    public class BloodStored
    {
        public int StorageID { get; set; }
        public string BloodType { get; set; }
        public int Quantity { get; set; }

        public StoragePoint StoragePoint { get; set; }
    }
}

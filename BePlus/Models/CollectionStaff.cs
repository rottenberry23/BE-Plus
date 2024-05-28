namespace BePlus.Models
{
    public class CollectionStaff
    {
        public int StaffID { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public int CollectionID { get; set; }

        public CollectionPoint CollectionPoint { get; set; }
    }
}

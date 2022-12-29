namespace sg_textile_web_api.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string MobileNumber { get; set; } = string.Empty;
        public DateTime TimeStamp { get; set; } = DateTime.Now;
        public City? City { get; set; }
    }
}
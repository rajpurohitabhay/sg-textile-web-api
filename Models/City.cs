namespace sg_textile_web_api.Models
{
    public class City
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public bool Active { get; set; }
        public State? State {  get; set; }

        public List<Customer> Customers { get; set; } = new List<Customer>();
    }
}
namespace sg_textile_web_api.Models
{
    public class State
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public bool Active { get; set; }
        public List<City> Cities { get; set; } = new List<City>();
    }
}
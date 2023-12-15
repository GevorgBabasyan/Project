namespace Business.Models
{
    public class Effect
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public byte State { get; set; }
        public dynamic Value { get; set; }
    }
}

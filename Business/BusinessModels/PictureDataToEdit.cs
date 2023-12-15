namespace Business.Models
{
    public class PictureDataToEdit
    {
        public int Name { get; set; }
        public byte[] File { get; set; }
        public List<Effect> Effects { get; set; }
    }
}

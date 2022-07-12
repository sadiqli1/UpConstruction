namespace UpConstruction.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string ButtonUrl { get; set; }
        public string LeftIcon { get; set; }
        public string RightIcon { get; set; }
		public byte Order { get; set; }
	}
}

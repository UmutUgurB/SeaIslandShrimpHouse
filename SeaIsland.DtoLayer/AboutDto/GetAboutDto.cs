namespace SeaIsland.DtoLayer.AboutDto
{
    public class GetAboutDto
    {
        public int AboutId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool AboutIsActive { get; set; }
    }
}

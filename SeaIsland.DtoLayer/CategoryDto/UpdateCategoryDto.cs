namespace SeaIsland.DtoLayer.CategoryDto
{
    public class UpdateCategoryDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool IsCategoryActive { get; set; }
    }
}

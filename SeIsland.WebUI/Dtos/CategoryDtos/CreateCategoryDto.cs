namespace SeIsland.WebUI.Dtos.CategoryDtos
{
	public class CreateCategoryDto
	{
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
		public string CategoryDescription { get; set; }
		public bool IsCategoryActive { get; set; }
	}
}

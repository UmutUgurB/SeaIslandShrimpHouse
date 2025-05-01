namespace SeaIsland.DtoLayer.MealDto
{
    public class GetMealDto
    {
        public int MealID { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public bool IsMealActive { get; set; }
		public int CategoryId { get; set; }
	}
}

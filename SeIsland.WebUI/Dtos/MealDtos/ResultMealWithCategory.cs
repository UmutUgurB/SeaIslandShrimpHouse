﻿namespace SeIsland.WebUI.Dtos.MealDtos
{
	public class ResultMealWithCategory
	{

		public int MealID { get; set; }
		public string MealName { get; set; }
		public string MealDescription { get; set; }
		public string ImageUrl { get; set; }
		public decimal Price { get; set; }
		public bool IsMealActive { get; set; }
		public string CategoryName { get; set; }
	}
}

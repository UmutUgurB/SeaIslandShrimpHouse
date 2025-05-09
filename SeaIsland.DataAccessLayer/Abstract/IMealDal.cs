﻿using SeaIsland.EntityLayer.Entities;

namespace SeaIsland.DataAccessLayer.Abstract
{
    public interface IMealDal : IGenericRepository<Meal>
    {
        List<Meal> GetMealsWithCategory();
    }
}

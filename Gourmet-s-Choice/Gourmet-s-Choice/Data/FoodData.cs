using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlashCard.Data;

namespace Gourmet_s_Choice.Data
{
    class FoodData : EntityData<Food>
    {
        public int GetFoodCount()
        {
            using (FoodEntities context = new FoodEntities())
            {
                int count =
                    context.Foods.Count();

                return count;
            }
        }

        public string GetById(int index)
        {
            using (FoodEntities context = new FoodEntities())
            {
                Food food = 
                context.Foods.FirstOrDefault(x => x.FoodID == index);

                if (food == null)
                    return null;

                return food.FoodName;
            }
        }
    }
}

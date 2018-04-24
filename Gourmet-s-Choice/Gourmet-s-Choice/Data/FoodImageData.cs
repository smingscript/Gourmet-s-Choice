using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlashCard.Data;

namespace Gourmet_s_Choice.Data
{
    class FoodImageData : EntityData<FoodImage>
    {
        public byte[] GetById(int index)
        {
            using (FoodEntities context = new FoodEntities())
            {
                FoodImage foodImage =
                context.FoodImages.FirstOrDefault(x => x.FoodID == index);

                if (foodImage == null)
                    return null;

                return foodImage.Thumbnail;
            }
        }
    }
}

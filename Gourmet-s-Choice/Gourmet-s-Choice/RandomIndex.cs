using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gourmet_s_Choice.Data;

namespace Gourmet_s_Choice
{
    class RandomIndex
    {
        Random rand = new Random();

        public List<int> GenerateRandIndex()
        {
            //DB의 음식 개수를 구한다
            int foodCount = DataRepository.Food.GetFoodCount();

            List<int> randIndexNumbers = new List<int>();

            while (randIndexNumbers.Count < 6)
            {
                // 라이브러리
                int number = rand.Next(45) + 1;
                if (randIndexNumbers.Contains(number) == false)
                    randIndexNumbers.Add(number);
            }

            return randIndexNumbers;
        }

        public List<int> ShuffleIndex(List<int> list)
        {
            var shuffleList = list.OrderBy(item => rand.Next());

            return shuffleList.ToList();
        }
    }
}


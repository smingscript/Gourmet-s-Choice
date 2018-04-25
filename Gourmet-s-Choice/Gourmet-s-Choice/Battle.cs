using System.Collections.Generic;

namespace Gourmet_s_Choice
{
    public class Battle
    {
        private Battle()
        {
        }

        public List<int> Foods { get; set; }

        public int Winner { get; set; }

        public static Battle Generate()
        {
            Battle battle = new Battle();
            battle.foo();
            battle.foo();
            battle.foo();
            battle.foo();
            return battle;
        }

        //각 토너먼트가 끌날 때 마다 호출되어서 반환될 리스트를 만든다
        public List<Battle> NextRoundCandidates(List<int> list)
        {
            //넘어온 다음 후보 리스트를 섞어준다
            foodCandidateList = randomIndex.ShuffleIndex(list);


//            List<List<int>> listOfList = new List<List<int>>();

            List<Battle> Battles = new List<Battle>();

            for (int i = 0; i < foodCandidateList.Count; i += 2)
            {
                List<int> listItem = new List<int>();
                listItem.Add(foodCandidateList[i]);
                listItem.Add(foodCandidateList[i + 1]);
                
                Battles.Add(new Battle {Foods = listItem});
            }

            return Battles;
        }


        void foo()
        {
            Marine m1, m2;

            
        }
    }


    class Marine
    {
        public int HP;

        public static int InitialHP;

        public void IncreseHP()
        {
            HP++;
            InitialHP++;
        }

        public static void IncreseInitialHP()
        {
            InitialHP++;
            HP++;
        }
    }
}

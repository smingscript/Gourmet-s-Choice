using Gourmet_s_Choice.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gourmet_s_Choice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private RandomIndex randomIndex;
        List<int> foodCandidateList;
        private int gameRound;
        private Image roundImage;
        //16강, 32강 선택
        /*
         * 16강 : Round of 16
         * 8강 :  Quarter Final
         * 4강 : Semi Final
         * 결승: Final
         */

        //ResourceManager rm = Resources.ResourceManager;
        private void Form1_Load(object sender, EventArgs e)
        {
            //몇 강을 할지 선택하는 창이 띄운다
            gameRound = 16;
            //몇 강을 할 지 사용자가 선택을 하면 반환값으로 화면을 구성한다.
            
            if(gameRound == 16)
                roundImage = (Image)Resources.Round_16;
            else if(gameRound == 8)
                roundImage = (Image)Resources.Round_8;

            pctbRound.Image = roundImage;
            randomIndex = new RandomIndex();

            //랜덤으로 음식을 가져올 리스트를 생성해둔다
            foodCandidateList = new List<int>();

            //if (battleRound == 0)
            //    foodCandidateList = randomIndex.GenerateRandIndex();
        }

        
        private List<int> RandomNumber = new List<int>();

        private int idPointer = -1;
        private int battleRound = 0;

        //클릭할 때마다 승자를 저장한다
        private void ptbLeft_Click(object sender, EventArgs e)
        {
            //이 창은 선택을 하면 랜덤 이미지의 인덱스를 리스트로 가져와서 새 이미지로 교체한다.
            //txtbxLeft.Text = "Pressed";
            idPointer++;
            UpdateNewRoundForm();
        }

        private void ptbRight_Click(object sender, EventArgs e)
        {
            //txtbxLeft.Text = "Pressed";
            idPointer++;
            UpdateNewRoundForm();
        }

        //한 토너먼트가 끝나면 idPointer를 0으로 리셋시키고, 새로운 토너먼트 id리스트를 받아와야 한다.
        public void UpdateNewRoundForm()
        {
            
            
            //포인터가 리스트의 값을 넘어서서 한 라운드가 끝나면 다음 라운드로 값을 변경시킨다.
            if (idPointer > 8) //foodCandidateList.Count
            {
                gameRound /= 2;
                UpdateRoundImage(gameRound);
                idPointer = 0;
            }

            var foodCandidates = NextFoodCandidates();
            List<int> candidate = foodCandidates[idPointer];

            //ptbLeft.Image = DataRepository.FoodImage.GetById(UpdateNewRoundImage()[0]);
            //ptbRight.Image = DataRepository.FoodImage.GetById(UpdateNewRoundImage()[1]);

            //txtbxLeft.Text = DataRepository.Food.GetById(player[0]);
            //txtbxRight.Text = DataRepository.Food.GetById(player[1]);

            txtbxLeft.Text = Convert.ToString(candidate[0]);
            txtbxRight.Text = Convert.ToString(candidate[1]);

            battleRound++;



        }

        //각 토너먼트가 끌날 때 마다 호출되어서 반환될 리스트를 만든다
        public List<List<int>> NextFoodCandidates()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 , 20 };
            
            foodCandidateList = randomIndex.ShuffleIndex(list);


            List<List<int>> listOfList = new List<List<int>>();

            for (int i = 0; i < foodCandidateList.Count; i += 2)
            {
                List<int> listItem = new List<int>();
                listItem.Add(foodCandidateList[i]);
                listItem.Add(foodCandidateList[i + 1]);

                listOfList.Add(listItem);
            }

            return listOfList;
        }

        public void UpdateRoundImage(int round)
        {
            switch(round)
            {
                case 16:
                    roundImage = (Image)Resources.Round_16;
                    break;
                case 8:
                    roundImage = (Image)Resources.Round_8;
                    break;
                case 4:
                    roundImage = (Image)Resources.Round_4;
                    break;
                case 2:
                    roundImage = (Image)Resources.Round_2;
                    break;
            }

            pctbRound.Image = roundImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idPointer++;
            UpdateNewRoundForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idPointer++;
            UpdateNewRoundForm();
        }
    }
}

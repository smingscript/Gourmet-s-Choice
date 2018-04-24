using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            //몇 강을 할지 선택하는 창이 띄운다


        }

        //랜덤으로 음식을 가져올 리스트를 생성해둔다
        private List<int> RandomNumber = new List<int>();

        private int idPointer = -1;
        //16강, 32강 선택
        private void ptbLeft_Click(object sender, EventArgs e)
        {
            //이 창은 선택을 하면 두 토너먼트 선택 창을 숨기고, 랜덤 이미지의 인덱스를 리스트로 가져온다
            //txtbxLeft.Text = "Pressed";
            idPointer++;
            UpdateNewRoundImage();
        }

        private void ptbRight_Click(object sender, EventArgs e)
        {
            //txtbxLeft.Text = "Pressed";
            idPointer++;
            UpdateNewRoundImage();
        }

        public void UpdateNewRoundImage()
        {
            var foodPlayers = YieldFoodPlayerIndex.NextFoodPlayer();

            //ptbLeft.Image = DataRepository.FoodImage.GetById(UpdateNewRoundImage()[0]);
            //ptbRight.Image = DataRepository.FoodImage.GetById(UpdateNewRoundImage()[1]);
            List<int> player = foodPlayers[idPointer];
            txtbxLeft.Text = DataRepository.Food.GetById(player[0]);
            txtbxRight.Text = DataRepository.Food.GetById(player[1]);
        
        }

        class YieldFoodPlayerIndex
        {
            public static List<List<int>> NextFoodPlayer()
            {
                List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

                List <List<int>> listOfList = new List<List<int>>();

                for (int i = 0; i < list.Count; i += 2)
                {
                    List<int> listItem = new List<int>();
                    listItem.Add(list[i]);
                    listItem.Add(list[i+1]);

                    listOfList.Add(listItem);
                }

                return listOfList;
//                for (int i = 0; i < list.Count; i = i + 2)
//                {
//                    var nextFoodPlayers = list.Skip(i).Take(2);
//                    foreach (var player in nextFoodPlayers)
//                    {
//                        playsts.Add(player);
//                    }
//                    yield return playsts;
//                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //            txtbxLeft.Text = "Pressed";
            idPointer++;
            UpdateNewRoundImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //            txtbxRight.Text = "Pressed";
            idPointer++;
            UpdateNewRoundImage();
        }
    }
}

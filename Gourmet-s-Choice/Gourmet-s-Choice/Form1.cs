using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        //16강, 32강 선택
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //이 창은 선택을 하면 두 토너먼트 선택 창을 숨기고, 랜덤 이미지의 인덱스를 리스트로 가져온다

        }
    }
}

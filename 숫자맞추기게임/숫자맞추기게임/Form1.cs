using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 숫자맞추기게임
{
    public partial class Form1 : Form
    {
        private int findNumber = 0;
        private int chance = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            var rand = new Random();//Random클래스를 생성해 rand라는 인스턴스 변수를 생성
            findNumber = rand.Next(1, 21);//Next메소드를 통해 임의의 정수를 생성
            //chance = 10;
            display.Text = "맞출 숫자를 입력하세요.";

        }

        private void ButtonInput_Click(object sender, EventArgs e)
        {
            int inputNumber = Int32.Parse(textBox.Text);

            if(inputNumber == findNumber)
            {
                display.Text = "승리!";
            }
            else
            {
                chance=chance-1;
                display.Text = "기회는 " + chance + "번 남았습니다.";
            }
            
            if (chance <= 0)
            {
                display.Text = "실패하셨습니다!";
            }
        }
    }
}
    

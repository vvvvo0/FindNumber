using System;
using System.Windows.Forms;

namespace FindNumber
{
    public partial class Form1 : Form
    {

        private int findNumber = 0;
        private int chance = 0;


        public Form1()
        {
            InitializeComponent();
        }



        private void ButtonStart_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            findNumber = rand.Next(1, 21);
            chance = 10;
            display.Text = "맞출 숫자를 입력하세요.";
        }
    }
}

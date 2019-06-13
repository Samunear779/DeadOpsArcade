using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeadOpsArcade
{
    public partial class PlayerScreen : UserControl
    {
        public PlayerScreen()
        {
            InitializeComponent();
        }

        private void class1Box_CheckedChanged(object sender, EventArgs e)
        {
            if(class1Box.Checked == true)
            {
                GameScreen.heroHealth = 300;
                GameScreen.heroSpeed = 7;
            }
        }

        private void calssBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (class2Box.Checked == true)
            {
                GameScreen.heroHealth = 200;
                GameScreen.heroSpeed = 10;
            }
        }

        private void classBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (class3Box.Checked == true)
            {
                GameScreen.heroHealth = 100;
                GameScreen.heroSpeed = 13;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, "MainScreen");
            GameScreen.heroName = heroTextBox.Text;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, "GameScreen");
            GameScreen.heroName = heroTextBox.Text;
        }
    }
}

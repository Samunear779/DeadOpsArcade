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

        //save class 1 values 
        private void class1Box_CheckedChanged(object sender, EventArgs e)
        {
            if(class1Box.Checked == true)
            {
                GameScreen.heroHealth = 300;
                GameScreen.heroSpeed = 2;
            }
        }

        //save class 2 values 
        private void calssBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (class2Box.Checked == true)
            {
                GameScreen.heroHealth = 200;
                GameScreen.heroSpeed = 4;
            }
        }

        //save class 3 values 
        private void classBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (class3Box.Checked == true)
            {
                GameScreen.heroHealth = 100;
                GameScreen.heroSpeed = 6;
            }
        }

        //go back to the main menu screen when the user hits the back button 
        private void backButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, "MainScreen");
            GameScreen.heroName = heroTextBox.Text;
        }

        //start the game when the user hits the play button 
        private void playButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, "GameScreen");
            GameScreen.heroName = heroTextBox.Text;
        }
    }
}

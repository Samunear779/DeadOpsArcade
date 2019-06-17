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
        bool classSelected = false;
        bool nameEntered = false;
        public PlayerScreen()
        {
            InitializeComponent();
            playButton.Enabled = false;
        }

        //save class 1 values 
        private void class1Box_CheckedChanged(object sender, EventArgs e)
        {
            if (class1Box.Checked == true && classSelected == false)
            {
                GameScreen.heroBSpeed = 10;
                GameScreen.heroSpeed = 2;
                class2Box.Checked = false;
                class3Box.Checked = false;
                classSelected = true;
                class2Box.Enabled = false;
                class3Box.Enabled = false;
                playButtonEnable();
            }
        }

        //save class 2 values 
        private void calssBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (class2Box.Checked == true && classSelected == false)
            {
                GameScreen.heroBSpeed = 15;
                GameScreen.heroSpeed = 4;
                class1Box.Checked = false;
                class3Box.Checked = false;
                classSelected = true;
                class1Box.Enabled = false;
                class3Box.Enabled = false;
                playButtonEnable();
            }
        }

        //save class 3 values 
        private void classBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (class3Box.Checked == true && classSelected == false)
            {
                GameScreen.heroBSpeed = 25;
                GameScreen.heroSpeed = 6;
                class1Box.Checked = false;
                class2Box.Checked = false;
                classSelected = true;
                class1Box.Enabled = false;
                class2Box.Enabled = false;
                playButtonEnable();
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

        private void heroTextBox_TextChanged(object sender, EventArgs e)
        {
            nameEntered = true;
        }

        //reset the class selection options when the reset button is pressed 
        private void classButton_Click(object sender, EventArgs e)
        {
            heroTextBox.Text = " ";
            classSelected = false;
            nameEntered = false;
            class1Box.Checked = false;
            class2Box.Checked = false;
            class3Box.Checked = false;
            playButton.Enabled = false;
            class1Box.Enabled = true;
            class2Box.Enabled = true;
            class3Box.Enabled = true;
        }

        public void playButtonEnable()
        {
            if (classSelected && nameEntered)
            {
                playButton.Enabled = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DeadOpsArcade
{
    public partial class HighScreen : UserControl
    {
        public HighScreen()
        {
            InitializeComponent();
            displayScores();
        }

        //switch to the main menu screen 
        private void backButton_Click_1(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, "MainScreen");
        }

        //display the scores from the score object 
        public void displayScores()
        {
            foreach (Score s in Form1.highscores)
            {
                scoresLabel.Text += s.score + " " + s.name + "\n";
            }
        }
    }
}

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
    public partial class FinalScreen : UserControl
    {
        string name, score;
        public FinalScreen()
        {
            InitializeComponent(); 
            //set local variables to the variables from the gamescreen
            name = GameScreen.heroName;
            score = GameScreen.score + "";
            //display the final score 
            yourScoreLabel.Text = "Your Score Was:  " + score;
            saveScore();
        }

        //change to the highscore screen if the button is pressed 
        private void highButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, "HighScreen");
        }

        //switch to the main menu screen if the button is pressed 
        private void menuButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, "MainScreen");
        }

        //save the score to an xml file 
        public void saveScore()
        {
            Score sc = new Score(name,score);
            Form1.highscores.Add(sc);

            XmlWriter writer = XmlWriter.Create("Resources/Highscores.xml", null);

            writer.WriteStartElement("Scores");

            foreach (Score s in Form1.highscores)
            {
                writer.WriteStartElement("GameSave");

                writer.WriteElementString("name", s.name);
                writer.WriteElementString("score", s.score);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.Close();
        }
    }
}

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
            name = GameScreen.heroName;
            score = GameScreen.score + "";
            yourScoreLabel.Text = "Your Score Was:  " + score;
            saveScore();
        }

        private void highButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, "HighScreen");
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, "MainScreen");
        }

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

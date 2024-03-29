﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Media;

namespace DeadOpsArcade
{
    public partial class Form1 : Form
    {
        public static List<Score> highscores = new List<Score>();
        SoundPlayer musicPlayer = new SoundPlayer(Properties.Resources.Barbarianism);

        
        public Form1()
        {
            InitializeComponent();
            //Start the program centred on the Menu Screen
            MainMenu ms = new MainMenu();
            this.Controls.Add(ms);
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
            //load thhe xml file with the scores on it 
            loadScores();
            musicPlayer.PlayLooping();
        }

        //load the scores from the xml file 
        public void loadScores()
        {
            string newName, newScore;
            XmlReader reader = XmlReader.Create("Resources/Highscores.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    newName = reader.ReadString();
                    reader.ReadToNextSibling("score");
                    newScore = reader.ReadString();

                    Score s = new Score(newName, newScore);
                    highscores.Add(s);
                }
            }
            reader.Close();
        }

        //change screen method to easily change screen throught the program 
        public static void ChangeScreen(UserControl current, string next)
        {
            //f is set to the form that the current control is on
            Form f = current.FindForm();
            f.Controls.Remove(current);
            UserControl ns = null;

            //switches screen
            switch (next)
            {
                case "MainScreen":
                    ns = new MainMenu();
                    break;
                case "GameScreen":
                    ns = new GameScreen();
                    break;
                case "HighScreen":
                    ns = new HighScreen();
                    break;
                case "PlayerScreen":
                    ns = new PlayerScreen();
                    break;
                case "HowToScreen":
                    ns = new HowToScreen();
                    break;
                case "FinalScreen":
                    ns = new FinalScreen();
                    break;
            }

            //centres on the screen
            ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
            
            f.Controls.Add(ns);
            ns.Focus();
        }
    }
}

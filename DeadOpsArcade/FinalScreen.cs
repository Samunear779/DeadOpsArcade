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
        public FinalScreen()
        {
            InitializeComponent();
            yourScoreLabel.Text = "Your Score Was:  " + GameScreen.score;
        }

        private void highButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, "HighScreen");
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, "MainScreen");
        }
    }
}

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
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void playerButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, "PlayerScreen");
        }

        private void highScoreButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, "HighScreen");
        }

        private void howToButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, "HowToScreen");
        }
    }
}

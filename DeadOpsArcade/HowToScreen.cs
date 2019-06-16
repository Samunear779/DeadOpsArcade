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
    public partial class HowToScreen : UserControl
    {
        public HowToScreen()
        {
            InitializeComponent();
        }

        //switch to the main menu screen 
        private void backButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, "MainScreen");
        }
    }
}

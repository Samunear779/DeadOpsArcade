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
    public partial class HighScreen : UserControl
    {
        public HighScreen()
        {
            InitializeComponent();
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, "MainScreen");
        }
    }
}

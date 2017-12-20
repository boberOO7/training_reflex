using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vas9dayn
{
    public partial class game2 : Form

    {
        private readonly Timer gameTimer;
        private readonly Timer randTimer;
        public game2()
        {
            InitializeComponent();
            gameTimer = new Timer();
            gameTimer.Tick += timer1_Tick;
            gameTimer.Interval = 1;
            randTimer = new Timer();
            randTimer.Tick += RandTimer_Tick;
        }

        private void RandTimer_Tick(object sender, EventArgs e)
        {
            gameTimer.Enabled = true;
            copyTarget.BackColor = Color.Red;
        }

        DateTime date1 = new DateTime(0, 0);
        private void timer1_Tick(object sender, EventArgs e)
        {
            date1 = date1.AddMilliseconds(10);
            textBox1.Text = date1.ToString("mm:ss:fff");
        }

        private void target_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            randTimer.Interval = r.Next(2000, 5000);
            randTimer.Enabled = true;
            copyTarget.Show();
            target.Hide();
        }

        private void copyTarget_Click(object sender, EventArgs e)
        {
            if (gameTimer.Enabled == true)
                gameTimer.Enabled = false;
            mainMenu.Show();
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
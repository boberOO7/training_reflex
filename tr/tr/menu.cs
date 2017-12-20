using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tr
{
    public partial class menu : Form
    {
        game1 game1 = new game1();
        game2 game = new game2();

        public menu()
        {
            InitializeComponent();
        }


        private void game2_Click(object sender, EventArgs e)
        {
            game.Show();
            this.Hide();
        }

        private void game1_Click(object sender, EventArgs e)
        {
            game1.Show();
            this.Hide();
            game1.startTimer.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

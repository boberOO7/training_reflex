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
    public partial class game1 : Form

    {
        private readonly Timer appearence1;
        private readonly Timer appearence2;
        private readonly Timer appearence3;
        private readonly Timer appearence4;
        private readonly Timer appearence5;
        public readonly Timer startTimer;
        private readonly Timer game;
        public int i;
        int v1 = 0, v2 = 0, v3 = 0, v4 = 0, v5 = 0;
        int result;
        int[] gameOverArr = new int[] { 0, 0, 0, 0, 0 };
        public game1()
        {
            InitializeComponent();
            int[] v = new int[] { v1, v2, v3, v4, v5 };
            appearence1 = new Timer();
            appearence1.Interval = 2500;
            appearence1.Tick += Appearence_Tick;
            appearence2 = new Timer();
            appearence2.Interval = 2500;
            appearence2.Tick += Appearence2_Tick;
            appearence3 = new Timer();
            appearence3.Interval = 2500;
            appearence3.Tick += Appearence3_Tick;
            appearence4 = new Timer();
            appearence4.Interval = 2500;
            appearence4.Tick += Appearence4_Tick;
            appearence5 = new Timer();
            appearence5.Interval = 2500;
            appearence5.Tick += Appearence5_Tick;
            startTimer = new Timer();
            startTimer.Interval = 500;
            startTimer.Tick += StartTimer_Tick;
            game = new Timer();
            game.Interval = 1;
            game.Tick += Game_Tick;
            game.Enabled = true;
            i = 0;
        }

        private void Game_Tick(object sender, EventArgs e)
        {
            int[] v = new int[] { v1, v2, v3, v4, v5 };
            checkForGameOver(v);
            textBox1.Text = Convert.ToString(result);
        }

        private void StartTimer_Tick(object sender, EventArgs e)
        {
            appearence1.Enabled = true;
            if (i == 0)
            {
                appearence1.Enabled = true;
            }
            if (i == 1)
            {
                appearence2.Enabled = true;
            }
            if (i == 2)
            {
                appearence3.Enabled = true;
            }
            if (i == 3)
            {
                appearence4.Enabled = true;
            }
            if (i == 4)
            {
                appearence5.Enabled = true;
            }
            else i++;
            if (i == 5)
                startTimer.Enabled = false;
        }

        private void Appearence5_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            target5.Location = new Point(r.Next(50, 550), r.Next(50, 550));
            target5.Show();
            v5 = 1;
        }

        private void Appearence4_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            target4.Location = new Point(r.Next(50, 550), r.Next(50, 550));
            target4.Show();
            v4 = 1;
        }

        private void Appearence3_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            target3.Location = new Point(r.Next(50, 550), r.Next(50, 550));
            target3.Show();
            v3 = 1;
        }

        private void Appearence2_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            target2.Location = new Point(r.Next(50, 550), r.Next(50, 550));
            target2.Show();
            v2 = 1;
        }
        private void Appearence_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            target1.Location = new Point(r.Next(50, 550), r.Next(50, 550));
            target1.Show();
            v1 = 1;
        }
        public void checkForGameOver(int[] v)
        {
            int check = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] == 1)
                    check++;
                if (check == v.Length)
                {
                    appearence1.Stop();
                    appearence2.Stop();
                    appearence3.Stop();
                    appearence4.Stop();
                    appearence5.Stop();
                    mainMenu.Show();
                    target1.Hide();
                    target2.Hide();
                    target3.Hide();
                    target4.Hide();
                    target5.Hide();
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void target1_Click(object sender, EventArgs e)
        {
            v1 = 0;
            target1.Hide();
            result++;
        }

        private void game1_Load(object sender, EventArgs e)
        {

        }

        private void target2_Click(object sender, EventArgs e)
        {
            v2 = 0;
            target2.Hide();
            result++;
        }
        private void target3_Click(object sender, EventArgs e)
        {
            v3 = 0;
            target3.Hide();
            result++;
        }
        private void target4_Click(object sender, EventArgs e)
        {
            v4 = 0;
            target4.Hide();
            result++;
        }
        private void target5_Click(object sender, EventArgs e)
        {
            v5 = 0;
            target5.Hide();
            result++;
        }
    }
}

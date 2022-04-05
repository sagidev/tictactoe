using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolkoikrzyzyk
{
    public partial class Form1 : Form
    {
        bool b1_g, b2_g, b3_g, b4_g, b5_g, b6_g, b7_g, b8_g, b9_g;  //gracz
        bool b1_p, b2_p, b3_p, b4_p, b5_p, b6_p, b7_p, b8_p, b9_p;  //pc

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.R)
            {
                
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (b1_p == false)
            {
                b1_g = true;
            }
            Check();
            enemyTurn();
            winCheck();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (b2_p == false)
            {
                b2_g = true;
            }
            Check();
            enemyTurn();
            winCheck();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (b3_p == false)
            {
                b3_g = true;
            }
            Check();
            enemyTurn();
            winCheck();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (b4_p == false)
            {
                b4_g = true;
            }
            Check();
            enemyTurn();
            winCheck();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (b5_p == false)
            {
                b5_g = true;
            }
            Check();
            enemyTurn();
            winCheck();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (b6_p == false)
            {
                b6_g = true;
            }
            Check();
            enemyTurn();
            winCheck();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (b7_p == false)
            {
                b7_g = true;
            }
            Check();
            enemyTurn();
            winCheck();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (b8_p == false)
            {
                b8_g = true;
            }
            Check();
            enemyTurn();
            winCheck();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (b9_p == false)
            {
                b9_g = true;
            }
            Check();
            enemyTurn();
            winCheck();
        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Check()
        {
            if (b1_g == true) { b1.Text = "X"; }
            if (b2_g == true) { b2.Text = "X"; }
            if (b3_g == true) { b3.Text = "X"; }
            if (b4_g == true) { b4.Text = "X"; }
            if (b5_g == true) { b5.Text = "X"; }
            if (b6_g == true) { b6.Text = "X"; }
            if (b7_g == true) { b7.Text = "X"; }
            if (b8_g == true) { b8.Text = "X"; }
            if (b9_g == true) { b9.Text = "X"; }
        }

        private void enemyCheck()
        {
            if (b1_p == true) { b1.Text = "O"; }
            if (b2_p == true) { b2.Text = "O"; }
            if (b3_p == true) { b3.Text = "O"; }
            if (b4_p == true) { b4.Text = "O"; }
            if (b5_p == true) { b5.Text = "O"; }
            if (b6_p == true) { b6.Text = "O"; }
            if (b7_p == true) { b7.Text = "O"; }
            if (b8_p == true) { b8.Text = "O"; }
            if (b9_p == true) { b9.Text = "O"; }
        }

        private void winCheck()
        {
            if(b1_g == true && b2_g == true && b3_g == true)
            {
                MessageBox.Show("U won!");
                Thread.Sleep(1000);
                this.Close();
            }
            if (b4_g == true && b5_g == true && b6_g == true)
            {
                MessageBox.Show("U won!");
                Thread.Sleep(1000);
                this.Close();
            }
            if (b7_g == true && b8_g == true && b9_g == true)
            {
                MessageBox.Show("U won!");
                Thread.Sleep(1000);
                this.Close();
            }
            if (b7_g == true && b4_g == true && b1_g == true)
            {
                MessageBox.Show("U won!");
                Thread.Sleep(1000);
                this.Close();
            }
            if (b8_g == true && b5_g == true && b2_g == true)
            {
                MessageBox.Show("U won!");
                Thread.Sleep(1000);
                this.Close();
            }
            if (b9_g == true && b6_g == true && b3_g == true)
            {
                MessageBox.Show("U won!");
                Thread.Sleep(1000);
                this.Close();
            }
            if (b7_g == true && b5_g == true && b3_g == true)
            {
                MessageBox.Show("U won!");
                Thread.Sleep(1000);
                this.Close();
            }
            if (b1_g == true && b5_g == true && b9_g == true)
            {
                MessageBox.Show("U won!");
                Thread.Sleep(1000);
                this.Close();
            }
        }

        private void enemyWinCheck()
        {
            if (b1_p == true && b2_p == true && b3_p == true)
            {
                MessageBox.Show("U lost!");
                Thread.Sleep(1000);
                this.Close();
            }
            if (b4_p == true && b5_p == true && b6_p == true)
            {
                MessageBox.Show("U lost!");
                Thread.Sleep(1000);
                this.Close();
            }
            if (b7_p == true && b8_p == true && b9_p == true)
            {
                MessageBox.Show("U lost!");
                Thread.Sleep(1000);
                this.Close();
            }
            if (b7_p == true && b4_p == true && b1_p == true)
            {
                MessageBox.Show("U lost!");
                Thread.Sleep(1000);
                this.Close();
            }
            if (b8_p == true && b5_p == true && b2_p == true)
            {
                MessageBox.Show("U lost!");
                Thread.Sleep(1000);
                this.Close();
            }
            if (b9_p == true && b6_p == true && b3_p == true)
            {
                MessageBox.Show("U lost!");
                Thread.Sleep(1000);
                this.Close();
            }
            if (b7_p == true && b5_p == true && b3_p == true)
            {
                MessageBox.Show("U lost!");
                Thread.Sleep(1000);
                this.Close();
            }
            if (b1_p == true && b5_p == true && b9_p == true)
            {
                MessageBox.Show("U lost!");
                Thread.Sleep(1000);
                this.Close();
            }
        }

        private void enemyTurn()
        {
            Random rng = new Random();
            int roll;

            roll = rng.Next(1, 10);

            if(roll == 1 && b1_g == false) {b1_p = true; enemyCheck(); enemyWinCheck(); }
            else if (roll == 1 && b1_g == true){ enemyTurn(); }

            if (roll == 2 && b2_g == false) {b2_p = true; enemyCheck(); enemyWinCheck(); }
            else if (roll == 2 && b2_g == true) { enemyTurn(); }

            if (roll == 3 && b3_g == false) {b3_p = true; enemyCheck(); enemyWinCheck(); }
            else if (roll == 3 && b3_g == true) { enemyTurn(); }

            if (roll == 4 && b4_g == false) {b4_p = true; enemyCheck(); enemyWinCheck(); }
            else if (roll == 4 && b4_g == true) { enemyTurn(); }

            if (roll == 5 && b5_g == false) {b5_p = true; enemyCheck(); enemyWinCheck(); }
            else if (roll == 5 && b5_g == true) { enemyTurn(); }

            if (roll == 6 && b6_g == false) {b6_p = true; enemyCheck(); enemyWinCheck(); }
            else if (roll == 6 && b6_g == true) { enemyTurn(); }

            if (roll == 7 && b7_g == false) {b7_p = true; enemyCheck(); enemyWinCheck(); }
            else if (roll == 7 && b7_g == true) { enemyTurn(); }

            if (roll == 8 && b8_g == false) {b8_p = true; enemyCheck(); enemyWinCheck(); }
            else if (roll == 8 && b8_g == true) { enemyTurn(); }

            if (roll == 9 && b9_g == false) {b9_p = true; enemyCheck(); enemyWinCheck(); }
            else if (roll == 9 && b9_g == true) { enemyTurn(); }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisgustingLittleSillyScaryDungeon
{
    public partial class DisgustingLittleSillyScaryDungeon : Form
    {
        bool right;
        bool left;
        bool up;
        bool down;

        public DisgustingLittleSillyScaryDungeon()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.right == true)
            {
                player.Left += 54;
            }

            if (this.left == true)
            {
                player.Left -= 54;
            }

            if (this.up == true)
            {
                player.Top -= 54;
            }

            if (this.down == true)
            {
                player.Top += 54;
            }
        }

        private void DisgustingLittleSillyScaryDungeon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                this.right = true;
            }

            if (e.KeyCode == Keys.Left)
            {
                this.left = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                this.up = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                this.down = true;
            }
        }

        private void DisgustingLittleSillyScaryDungeon_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                this.right = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                this.left = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                this.up = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                this.down = false;
            }
        }
    }
}

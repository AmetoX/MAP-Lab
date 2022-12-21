using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstGame.Resources
{
    public class Engine
    {
        public static Form1 form;
        public static void Initialize(Form1 f)
        {
            form = f;
        }
        public static List<PictureBox> Blocks = new List<PictureBox>();
        public static void GenerateLand()
        {
            PictureBox land = new PictureBox();
            land.Parent = form;
            land.BackColor = Color.DarkGreen;
            land.Size = new Size(1920, 300);
            land.Location = new Point(0, 780);//x y
            //fac cu timer ca pamantul sa mearga in stanga si cand locationu x + size al playerul < 0 o pierdut la fel si cu pamantul

        }
        public static void PlayerCollision()
        {
            form.player.isJumping = true;
            foreach (var control in form.Controls)
            {
                if (control is PictureBox && !control.Equals(form.player.image))
                {
                    if (form.player.image.Bounds.IntersectsWith
                        ((control as PictureBox).Bounds))
                    {
                        form.player.gravity = 0;
                        form.player.isJumping = false;
                        form.player.image.Top = (control as PictureBox).Top
                            - form.player.image.Height + 1;

                    }

                }
            }

        }

        public static void CheckIfYouLose()
        {
            if (form.player.image.Top > form.Height)
            {
                form.timer1.Enabled = false;
                var response = MessageBox.Show("You fell off and died. Game OVER !\n Do you want to restart?", "You lose",
                     MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    form.player.image.Parent = null;
                    form.player = new Player();
                    form.timer1.Enabled = true;
                }
                else
                {
                    form.Close();
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joc_2_Shooter
{
    internal class Engine
    {
        public static Form1 form;
        public static Random random = new Random();
        public static int horizon = 100;
        public static Enemy enemy;
        public static Graphics graphics;
        public static Bitmap bitmap;

        public static void Init(Form1 f1)
        {
            form = f1;
            bitmap = new Bitmap(form.Width,form.Height);
            graphics = Graphics.FromImage(bitmap); 
            enemy = new Enemy(100, 5, 0, 50);
        }
        public static void Shoot(Point click)
        {
            enemy.GetShoot(click);
            if (enemy.health <= 0)
            {
                form.timer1.Enabled = false;
                System.Windows.Forms.MessageBox.Show("You defeated the enemy!");
            }
        }

        public static Point GetRandomPoint(int size)
        {
            return new Point(random.Next(form.Width - size),horizon - size);
        }

        public static void UpdateDisplay()
        {
            graphics.Clear(Color.DarkGray);
            graphics.FillRectangle(new SolidBrush(Color.Red), 
                enemy.possition.X, enemy.possition.Y, (float)enemy.size, (float)enemy.size);
            form.pictureBox1.Image = bitmap;
        }
    }
}

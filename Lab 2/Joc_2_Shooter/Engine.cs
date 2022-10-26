using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joc_2_Shooter
{
    public static class Engine
    {
        public static Form1 form;
        public static Random random = new Random();
        public static List<Enemy> enemies = new List<Enemy>();
        public static Graphics graphics;
        public static Bitmap bitmap;
        public static int waveuri = 0;
        public static int horizon = 550, //de unde vin inamicii
            forthelth = 100;

        public static void Init(Form1 f1)
        {
            // formularul deschis in momentul acesta
            form = f1;
            bitmap = new Bitmap(form.Width, form.Height);
            graphics = Graphics.FromImage(bitmap);

            // aceste date sunt hardcodate deocamdata
            wave();
        }
        public static void wave()
        {
            enemies.Add(new Enemy(150, 5, 0, 50));
            enemies.Add(new Enemy(50, 5, 0, 50));
            enemies.Add(new Enemy(200, 5, 0, 50));
            enemies.Add(new Enemy(100, 5, 0, 50));
            enemies.Add(new Enemy(50, 5, 0, 50));
        }
        public static void Shoot(Point click)
        {
            // parcurgem toti inamicii pentru a verifica daca toti dintre ei sunt impuscati
            // astfel, avem efectul unui piercing shot (in viitor, vom avea arme cu sau fara)
            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].GetShot(click);
                // daca inamicul nu mai are viata, il scoatem din lista de inamici
                if (enemies[i].health <= 0)
                {
                    enemies.Remove(enemies[i]);
                    i--;
                }
            }
            
            // daca nu mai exista inamici, inseamna ca ai castigat
            if (enemies.Count == 0)
            {
                waveuri++;
                if (waveuri > 3)
                {
                    form.timer1.Enabled = false;
                    MessageBox.Show("You defeated all the enemies!", "You Win!");
                    form.Close();
                }
                wave();
            }
        }

        public static void UpdateDisplay()
        {
            // culoarea de fundal. vom avea o imagine de fundal aici in schimb.
            //graphics.Clear(Color.ForestGreen);
            graphics.DrawImage(form.background, 0, 0, form.Width, form.Height);

            // parcurgem toti inamicii pentru a-i afisa pe toti. si aici vom avea imagini.
            foreach (Enemy enemy in enemies)
            {
                graphics.DrawImage(form.enemyimg, enemy.position.X, enemy.position.Y, (int)enemy.size, (int)enemy.size);
                // graphics.FillRectangle(new SolidBrush(Color.Crimson),
                // enemy.position.X, enemy.position.Y, (int)enemy.size, (int)enemy.size);
            }

            form.pictureBox1.Image = bitmap;
        }

        public static Point GetRandomPoint(int size)
        {
            // pozitia y a fiecarui inamic este mereu la linia orizontului
            // iar pozitia x este la intamplare
            return new Point(random.Next(form.Width - size), horizon - size);
        }
    }
}

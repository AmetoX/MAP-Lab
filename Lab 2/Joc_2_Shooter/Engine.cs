using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Policy;

namespace Joc_2_Shooter
{
    public static class Engine
    {
        public static Form1 form;
        public static Random random = new Random();
        public static List<Enemy> enemies = new List<Enemy>(), curentWave = new List<Enemy>();
        public static List<List<Enemy>> waves = new List<List<Enemy>>();
        public static Graphics graphics;
        public static Bitmap bitmap;
        public static int horizon = 100, wave = 1;
        public static double fortHealth = 100, time = 0;

        public static void Init(Form1 f1)
        {
            // formularul deschis in momentul acesta
            form = f1;
            bitmap = new Bitmap(form.Width, form.Height);
            graphics = Graphics.FromImage(bitmap);

            // aceste date sunt hardcodate deocamdata
            var wave1 = new List<Enemy>();
            wave1.Add(new Enemy(100, 5, 20, 50, 100, 0));
            wave1.Add(new Enemy(100, 5, 20, 50, 100, 20));
            wave1.Add(new Enemy(100, 5, 20, 50, 100, 35));
            wave1.Add(new Enemy(100, 5, 20, 50, 100, 45));
            wave1.Add(new Enemy(100, 5, 20, 50, 100, 55));

            var wave2 = new List<Enemy>();
            wave2.Add(new Enemy(100, 5, 20, 50, 100, 0));
            wave2.Add(new Enemy(100, 5, 20, 50, 100, 20));
            wave2.Add(new Enemy(100, 5, 20, 50, 100, 35));
            wave2.Add(new Enemy(100, 5, 20, 50, 100, 45));
            wave2.Add(new Enemy(100, 5, 20, 50, 100, 55));

            waves.Add(wave1);
            waves.Add(wave2);
            curentWave = wave1;
        }
        public static void Tick()
        {
            time++;
            form.TimeLabel.Text = $"{time / 10}s";

            // daca nu mai exista inamici, inseamna ca ai castigat
            if (curentWave.Count == 0 && enemies.Count == 0)
            {
                if (wave < waves.Count)
                {
                    NextWave();
                }
                else
                {
                    Win();
                }
            }

            // adaugam inamicii in lista de inamici afisati doar cand se ajunge la spawnTime
            if (curentWave.Any() && curentWave[0].spawnTime <= time)
            {
                enemies.Add(curentWave[0]);
                curentWave.RemoveAt(0);
            }

            MoveEnemies();
            CheckIfYouLose();
            UpdateDisplay();
        }
        private static void MoveEnemies()
        {
            for(int i = 0; i < enemies.Count; i++)
            {
                Enemy enemy = enemies[i];
                enemy.Move();

                if(enemy.position.Y >= form.Height)
                {
                    fortHealth -= enemy.damage;
                    form.HealthLabel.Text = $"Health {fortHealth}";
                    enemies.Remove(enemies[i]);
                    i--;
                }
            }
        }
        public static void Win()
        {
            form.timer1.Enabled = false;
            form.backgroundSound.Stop();
            MessageBox.Show("You defeated all the enemies!", "You win");
            form.Close();
        }
        public static void CheckIfYouLose()
        {
            if (fortHealth <= 0)
            {
                form.timer1.Enabled = false;
                form.backgroundSound.Stop();
                MessageBox.Show("Your fort walls were destroyed!");
                form.Close();
            }
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


        }
        public static void NextWave()
        {
            wave++;
            waves.RemoveAt(0);
            curentWave = waves[0];
            time = 0;
            form.WaveLabel.Text = $"Wave {wave}";
        }
        public static void UpdateDisplay()
        {
            // Aici setam imaginea de fundal
            graphics.DrawImage(form.background, 0, 0, form.Width, form.Height);
            enemies.Sort((Enemy e1,Enemy e2) => e1.position.Y - e2.position.Y);//sortam inamicii

            // parcurgem toti inamicii pentru a afisa imaginea acestora pentru toti.
            foreach (Enemy enemy in enemies)
            {
                graphics.DrawImage(form.normalZombie, enemy.position.X, enemy.position.Y,
                    (int)enemy.sizeX, (int)enemy.sizeY);
            }

            form.pictureBox1.Image = bitmap;
        }
        public static Point GetRandomPoint(int sizeX, int sizeY)
        {
            // pozitia y a fiecarui inamic este mereu la linia orizontului
            // iar pozitia x este la intamplare
            return new Point(random.Next(form.Width - sizeX), horizon - sizeY);
        }
    }
}

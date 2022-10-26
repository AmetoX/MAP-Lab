using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using System.Net.Http.Headers;

namespace Joc_2_Shooter
{
    public class Enemy
    {
        public double health, speed, damage, size, positionX;
        public Point position;

        public Enemy(double health, double speed, double damage, double size)
        {
            this.health = health;
            this.speed = speed;
            this.damage = damage;
            this.size = size;
            position = Engine.GetRandomPoint((int)size);
            positionX = position.X;
        }

        public void Move()
        {
            // inamicul se apropie de noi cu speed pixeli.
           // position.Y += (int)speed;

            // dimensiunea creste doar cu o parte din viteza pentru a nu fi prea mare spre final
            size += speed/2;

            // iar pozitia scade cu jumatate din cat a crescut dimensiunea pentru a pastra inamicul centrat
            positionX -= speed / 2;
            position.X = (int)positionX + 5;
        }
        private static int dmg = 40;
        public void GetShot(Point click)
        {
            // verificam daca clickul a fost facut pe acest inamic
            // trebuie sa verificam in toate pozitiile, stanga, dreapta, sus si jos
            if (click.X > position.X && click.X < position.X + size
                && click.Y > position.Y && click.Y < position.Y + size)
            {
                // viata scade cu 20
                health -= dmg;

                // si afisam scrisul cu damage-ul primit chiar deasupra clickului dat
                Engine.graphics.DrawString($"{dmg}", new Font("Arial", 12, FontStyle.Bold),
                    new SolidBrush(Color.Red), click.X, click.Y - 20);
                Engine.form.pictureBox1.Image = Engine.bitmap;
            }
        }
    }
}

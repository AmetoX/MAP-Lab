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
        public double health, speed, damage, size, possitionX;
        public Point possition;
        PictureBox image;

        public Enemy(double health, double speed, double damage, double size)
        {
            this.health = health;
            this.speed = speed;
            this.damage = damage;
            this.size = size;
            possition = Engine.GetRandomPoint((int)size);
            possitionX = possition.X;

            image = new PictureBox();
            image.Parent = Engine.form.pictureBox1;
            image.Size = new Size((int)size, (int)size);
            image.BackColor = Color.DarkRed;
            image.Location = possition;
        }
        public void Move()
        {
            possition.Y += (int)speed;
            possitionX -= 1.0 / 8;
            possition.X = (int)possitionX;
            size += 1.0 / 4;
            image.Location = possition;
            image.Size = new Size((int)size, (int)size);
        }
        public void GetShoot(Point click)
        {
            if( click.X > possition.X && possition.X < possition.X +size && 
                click.Y > possition.Y && click.Y < possition.Y + size)
            {
                health -= 20;
                Engine.graphics.DrawString("20", new Font("Arial", 122),
                    new SolidBrush(Color.Orange), click.X, click.Y - 20);
                Engine.form.pictureBox1.Image = Engine.bitmap;
            }
        }
    }
}

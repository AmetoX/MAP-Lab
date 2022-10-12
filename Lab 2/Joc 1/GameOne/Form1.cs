using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        Graphics graphics;
        Bitmap bitmap;
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.Red);
            Brush brush = new SolidBrush(Color.Black);
            graphics.DrawString("yo",new Font("Arial",20),brush,NewPoint(0,0));
            pictureBox1.Image = bitmap;
        }
        Point NewPoint(int x , int y)
        {
            return new Point(pictureBox1.Width / 2 + x, pictureBox1.Height / 2 - y);
        }
    }
}

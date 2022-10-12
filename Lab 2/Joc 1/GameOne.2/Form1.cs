using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOne._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button[,] buttons;
        int n = 3;
        int player = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            buttons = new Button[n, n];
            int size = pictureBox1.Width / 3;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Button button = new Button();
                    button.Parent = pictureBox1;
                    button.Size = new Size(size, size);                   
                    button.Location = new Point(j * size, i * size);
                    button.Font = new Font("Arial", 30);
                    button.Click += gridButton_Click;

                    buttons[i, j] = button;
                }
            }
        }
        private void gridButton_Click(object sender , EventArgs e)
        {
            Button button = sender as Button;
            if (player == 1)
            {
                button.Text = "X";
                player = 2;
                button.Enabled = false;
            }
            else
            {
                button.Text = "O";
                player = 1;
                button.Enabled = false;
            }
            if (CheckGameWin())
            {
                MessageBox.Show("Win");
            }
            else if (CheckGameLost())
            {
                MessageBox.Show("Remiza");
            }
        }
        bool CheckGameWin()
        {
            for (int i = 0; i < n; i++)
            {
                int sumaX = 0, sumaY = 0;
                for (int j = 0; j < n; j++)
                {
                    if (buttons[i, j].Text == "X")
                        sumaX++;
                    if (buttons[i,j].Text == "Y")
                        sumaY++;
                }
                if(sumaX == 3 || sumaY == 3)
                {
                    return true;
                }
            }
            return false;
        }
        bool CheckGameLost()
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (buttons[i, j].Enabled)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

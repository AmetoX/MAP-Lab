using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // daca cheia apasata este Esc, doar atunci inchidem jocul
            if (e.KeyCode == Keys.Escape)
            {
                // ne asiguram ca jocul nu continua sa ruleze cat timp pop-up-ul este afisat
                timer1.Enabled = false;
                // salvam optiunea aleasa intr-o variabila
                var option = MessageBox.Show("Are you sure you want to exit this game? Your progress will not be saved",
                    "Exit Game", MessageBoxButtons.OKCancel);

                // si inchidem jocul doar daca jucatorul a apasat OK
                if (option == DialogResult.OK)
                    Close();
                // pornim jocul la loc in cazul in care nu s-a ales sa se inchida jocul
                timer1.Enabled = true;
            }
        }
    }
}

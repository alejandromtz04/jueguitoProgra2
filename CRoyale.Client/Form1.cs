using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRoyale.Domain;

namespace CRoyale.Client
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
        Card card = new Card();
        private void Form1_Load(object sender, EventArgs e)
		{

		}

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
			int damageAmount = 10;

			card.HP -= damageAmount;

			if (card.HP <= 0)
			{
				card.HP = 0;
			}

			
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = card.HP;
            progressBar1.Value = card.HP;
            labelHP.Text = $"Vida restante: {card.HP}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
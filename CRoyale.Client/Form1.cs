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
        myCard myCard = new myCard();
        Random random = new Random();
        private void Form1_Load(object sender, EventArgs e)
		{
            progressBar1.Maximum = card.HPBase;
            progressBar1.Value = card.HP;
            labelHP.Text = $"Vida restante: {card.HP}";

            MiHP.Maximum = myCard.HPMyCard;
            MiHP.Value = myCard.DamageToMe;
            MiVida.Text = $"Mi vida: {myCard.HPMyCard}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
			int damageAmount = random.Next(1, 11);
            int damageToMe = random.Next(1, 11);
			card.HP -= damageAmount;

			if (card.HP <= 0)
			{
				card.HP = 0;
			}
            myCard.HPMyCard -= damageToMe;
            if(myCard.HPMyCard <= 0)
            {
                myCard.HPMyCard = 0;
            }

            progressBar1.Value = card.HP;
            labelHP.Text = $"Vida restante: {card.HP}";

            MiHP.Value = myCard.HPMyCard;
            MiVida.Text = $"Mi vida: {myCard.HPMyCard}";


            MessageBox.Show($"Realizaste un ataque per recibiste: {damageToMe} de daño");

            // Finaliza el juego:
            if(myCard.HPMyCard == 0 || card.HP == 0)
            {
                string winner = myCard.HPMyCard > 0 ? "Jugador" : "Enemigo";
                MessageBox.Show($"{winner} ha ganado el juego!", "Juego Terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

    }
}
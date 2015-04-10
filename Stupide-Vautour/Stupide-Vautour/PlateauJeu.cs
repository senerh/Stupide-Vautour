using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stupide_Vautour
{
    public partial class PlateauJeu : Form, Display
    {
        PlayForm playform;
        Game game;
        Thread play;
        HumanPlayer human;

        public PlateauJeu(PlayForm playform, List<String> listPlayers)
        {
            InitializeComponent();
            this.playform = playform;

            List<Player> listPlayer = new List<Player>();
            human = new HumanPlayer();
            listPlayer.Add(human);
            foreach (String player in listPlayers)
            {
                switch (player)
                {
                    case "Facile":
                        listPlayer.Add(new StupidPlayer());
                        break;
                    case "Moyen":
                        listPlayer.Add(new MediumPlayer());
                        break;
                    default:
                        listPlayer.Add(new SmartPlayer());
                        break;
                }
            }

            game = new Game(listPlayer, this);
            play = new Thread(game.play);

            afficheDosPile();
            afficheDosJoueurs();

            int[] main = new int[15];
            int j = 0;
            for (int i = 14; i > 0; i--)
            {
                main[j] = i;
                j++;
            }
            int[] pile = new int[15];
            for (int i = 0; i < 15; i++)
            {
                pile[i] = i;
            }
            int nbCartesDansMain = SabotHumain.Images.Count;
            afficherMainHumain(main);
            afficheDosPile();
            afficheDosJoueurs();

            play.Start();
        }

        public void afficheDosPile()
        {
            PictureBox carte;
            carte = (PictureBox)TapisPile.Controls[1];//1 pour pile de gauche. 0 pour droite
            carte.Image = SabotPile.Images[0];
        }

        public void afficheDosJoueurs()
        {
            PictureBox carte;
            carte = (PictureBox)TapisIA1.Controls[0];
            carte.Image = SabotIA1.Images[0];
            PictureBox carte2;
            carte2 = (PictureBox)TapisIA2.Controls[0];
            carte2.Image = SabotIA2.Images[0];
            PictureBox carte3;
            carte3 = (PictureBox)TapisIA3.Controls[0];
            carte3.Image = SabotIA3.Images[0];
            PictureBox carte4;
            carte4 = (PictureBox)TapisIA4.Controls[0];
            carte4.Image = SabotIA4.Images[0];
        }


        public void afficherMainHumain(int[] main)
        {
            PictureBox carte;
            for (int i_carte = 0; i_carte < main.Length; i_carte++)
            {
                carte = (PictureBox)TapisHumain.Controls[i_carte];
                carte.Image = SabotHumain.Images[main[i_carte]];
                carte.Tag = i_carte + 1;
            }
        }

        public void DisplayStack(Stack stack)
        {
            PictureBox carte;
            carte = (PictureBox)TapisPile.Controls[0];//1 pour pile de gauche. 0 pour droite
            if (stack.isVulture())
            {
                carte.Image = SabotPile.Images[(stack.getCard().getValue()) * (-1) + 10];
            }
            else
            {
                carte.Image = SabotPile.Images[(stack.getCard().getValue())];
            }

        }

        private void PlateauJeu_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PlateauJeu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox1.Tag));
            pictureBox1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox2.Tag));
            pictureBox2.Visible = false;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox3.Tag));
            pictureBox3.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox4.Tag));
            pictureBox4.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox5.Tag));
            pictureBox5.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox6.Tag));
            pictureBox6.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox7.Tag));
            pictureBox7.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox8.Tag));
            pictureBox8.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox9.Tag));
            pictureBox9.Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox10.Tag));
            pictureBox10.Visible = false;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox11.Tag));
            pictureBox11.Visible = false;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox12.Tag));
            pictureBox12.Visible = false;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox13.Tag));
            pictureBox13.Visible = false;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox14.Tag));
            pictureBox14.Visible = false;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox15.Tag));
            pictureBox15.Visible = false;
        }

        private void PileGauche_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

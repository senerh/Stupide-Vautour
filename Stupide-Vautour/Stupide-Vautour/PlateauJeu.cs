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
            human = new HumanPlayer(1);
            listPlayer.Add(human);
            int numPlayer = 2;
            foreach (String player in listPlayers)
            {
                switch (player)
                {
                    case "Facile":
                        listPlayer.Add(new StupidPlayer(numPlayer));
                        break;
                    case "Moyen":
                        listPlayer.Add(new MediumPlayer(numPlayer));
                        break;
                    default:
                        listPlayer.Add(new SmartPlayer(numPlayer));
                        break;
                }
                numPlayer++;
            }

            game = new Game(listPlayer, this);
            play = new Thread(game.play);

            switch (listPlayer.Count)
            {
                case 4:
                    TapisIA4.Visible = false;
                    lbl_scoreIA4.Visible = false;
                    break;
                case 3:
                    TapisIA3.Visible = false;
                    lbl_scoreIA3.Visible = false;
                    TapisIA4.Visible = false;
                    lbl_scoreIA4.Visible = false;
                    break;
                case 2:
                    TapisIA2.Visible = false;
                    lbl_scoreIA2.Visible = false;
                    TapisIA3.Visible = false;
                    lbl_scoreIA3.Visible = false;
                    TapisIA4.Visible = false;
                    lbl_scoreIA4.Visible = false;
                    break;
                default:
                    break;
            }

            afficherMainHumain();
            afficheDosPile();

            play.Start();
        }

        public void afficheDosPile()
        {
            PictureBox carte;
            carte = (PictureBox)TapisPile.Controls[1];//1 pour pile de gauche. 0 pour droite
            carte.Image = SabotPile.Images[0];
        }

        public void afficherMainHumain()
        {
            PictureBox carte;
            for (int i = 0; i < TapisHumain.ColumnCount; i++)
            {
                for (int j = 0; j < this.TapisHumain.RowCount; j++)
                {
                    carte = (PictureBox)this.TapisHumain.GetControlFromPosition(i, j);
                    if (carte != null)
                    {
                        carte.Image = SabotHumain.Images[8 * j + i];
                        carte.Tag = 8 * j + i + 1;
                    }
                }
            }
        }

        public void displayStack(Stack stack)
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

        public void displayCard(Player player, Card card)
        {
            PictureBox carte;
            switch (player.getID())
            {
                case 1://Humain
                    break;
                case 2://IA 1
                    carte = (PictureBox)TapisIA1.Controls[0];
                    carte.Image = SabotIA1.Images[card.number - 1];
                    break;
                case 3://IA 2
                    carte = (PictureBox)TapisIA2.Controls[0];
                    carte.Image = SabotIA2.Images[card.number - 1];
                    break;
                case 4://IA 3
                    carte = (PictureBox)TapisIA3.Controls[0];
                    carte.Image = SabotIA3.Images[card.number - 1];
                    break;
                case 5://IA 4
                    carte = (PictureBox)TapisIA4.Controls[0];
                    carte.Image = SabotIA4.Images[card.number - 1];
                    break;
                default:
                    break;
            }
        }

        public void displayString(String s)
        {
            lb_atoidejouer.Invoke((MethodInvoker)delegate { lb_atoidejouer.Text = s; });
        }

        public void displayScore(Player player, int score)
        {
            switch (player.getID())
            {
                case 1://Humain
                    lbl_scoreHumain.Invoke((MethodInvoker)delegate { lbl_scoreHumain.Text = "Score : " + score; });
                    break;
                case 2://IA 1
                    lbl_scoreIA1.Invoke((MethodInvoker)delegate { lbl_scoreIA1.Text = "Score : " + score; });
                    break;
                case 3://IA 2
                    lbl_scoreIA2.Invoke((MethodInvoker)delegate { lbl_scoreIA2.Text = "Score : " + score; });
                    break;
                case 4://IA 3
                    lbl_scoreIA3.Invoke((MethodInvoker)delegate { lbl_scoreIA3.Text = "Score : " + score; });
                    break;
                case 5://IA 4
                    lbl_scoreIA4.Invoke((MethodInvoker)delegate { lbl_scoreIA4.Text = "Score : " + score; });
                    break;
                default:
                    break;
            }
        }

        public void hideCard(Player player)
        {
            PictureBox carte;
            switch (player.getID())
            {
                case 1://Humain
                    break;
                case 2://IA 1
                    carte = (PictureBox)TapisIA1.Controls[0];
                    carte.Image = SabotIA1.Images[15];
                    break;
                case 3://IA 2
                    carte = (PictureBox)TapisIA2.Controls[0];
                    carte.Image = SabotIA1.Images[15];
                    break;
                case 4://IA 3
                    carte = (PictureBox)TapisIA3.Controls[0];
                    carte.Image = SabotIA1.Images[15];
                    break;
                case 5://IA 4
                    carte = (PictureBox)TapisIA4.Controls[0];
                    carte.Image = SabotIA1.Images[15];
                    break;
                default:
                    break;
            }
        }

        public void displayWinner(List<Player> listPlayer)
        {
            DialogResult result = new DialogResult();
            if (listPlayer.Count == 1)
            {
                result = MessageBox.Show("Le joueur " + listPlayer.ElementAt(0).getColor() + " a gagné, Voulez vous rejouer ?", "Fin du game", MessageBoxButtons.YesNo);
            }
            else
            {
                String str = "Les joueurs " + listPlayer.ElementAt(0).getColor();
                for (int i=1; i<listPlayer.Count - 1; i++)
                {
                    str=str+", "+listPlayer.ElementAt(i).getColor();
                }
                result = MessageBox.Show(str + " et " + listPlayer.Last().getColor() + " ont gagné, Voulez vous rejouer ?", "Fin du game", MessageBoxButtons.YesNo);
            }

            if (result == DialogResult.Yes)
            {
                playform.enable();
                this.Invoke((MethodInvoker)delegate { this.Visible= false; });
            }
            else if (result == DialogResult.No)
            {
                Environment.Exit(1);
            }
           
        }

        private void disableCards()
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
            pictureBox10.Enabled = false;
            pictureBox11.Enabled = false;
            pictureBox12.Enabled = false;
            pictureBox13.Enabled = false;
            pictureBox14.Enabled = false;
            pictureBox15.Enabled = false;
            PileGauche.Enabled = true;
        }

        private void enableCards()
        {
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox10.Enabled = true;
            pictureBox11.Enabled = true;
            pictureBox12.Enabled = true;
            pictureBox13.Enabled = true;
            pictureBox14.Enabled = true;
            pictureBox15.Enabled = true;
            PileGauche.Enabled = false;
        }
        private void PlateauJeu_Closing(object sender, FormClosingEventArgs e)
        {
            play.Abort();
            Application.Exit();
        }

        private void PlateauJeu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox1.Tag));
            pictureBox1.Visible = false;
            disableCards();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox2.Tag));
            pictureBox2.Visible = false;
            disableCards();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox3.Tag));
            pictureBox3.Visible = false;
            disableCards();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox4.Tag));
            pictureBox4.Visible = false;
            disableCards();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox5.Tag));
            pictureBox5.Visible = false;
            disableCards();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox6.Tag));
            pictureBox6.Visible = false;
            disableCards();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox7.Tag));
            pictureBox7.Visible = false;
            disableCards();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox8.Tag));
            pictureBox8.Visible = false;
            disableCards();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox9.Tag));
            pictureBox9.Visible = false;
            disableCards();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox10.Tag));
            pictureBox10.Visible = false;
            disableCards();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox11.Tag));
            pictureBox11.Visible = false;
            disableCards();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox12.Tag));
            pictureBox12.Visible = false;
            disableCards();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox13.Tag));
            pictureBox13.Visible = false;
            disableCards();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox14.Tag));
            pictureBox14.Visible = false;
            disableCards();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            human.selectCard(Convert.ToInt16(pictureBox15.Tag));
            pictureBox15.Visible = false;
            disableCards();
        }

        private void PileGauche_Click(object sender, EventArgs e)
        {
            enableCards();
            game.wakeUp();
        }
    }
}

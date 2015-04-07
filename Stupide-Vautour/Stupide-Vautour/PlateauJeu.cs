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
    public partial class PlateauJeu : Form
    {
        PlayForm playform;
        Game game;
        Card currentCardStack;

        public PlateauJeu(PlayForm playform, Game game)
        {
            InitializeComponent();
            this.game = game;
            this.playform = playform;
            afficheDosPile();
            for (int round = 1; round <= 15; round++)
            {
                currentCardStack = game.getNextCard();
                DisplayStack();

                

            }
            /*
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
            afficheDosJoueurs();*/
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

        private void DisplayStack()
        {
            PictureBox carte;
            carte = (PictureBox)TapisPile.Controls[0];//1 pour pile de gauche. 0 pour droite
            if (currentCardStack.number < 0)
            {
                carte.Image = SabotPile.Images[(this.currentCardStack.number)*(-1)+10];
            }
            else
            {
                carte.Image = SabotPile.Images[(this.currentCardStack.number)];
            }
            
        }

        private void PlateauJeu_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}

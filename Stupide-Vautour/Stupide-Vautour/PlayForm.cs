
using System;
using System.Windows.Forms;
using System.Web;
using System.Collections.Generic;

namespace Stupide_Vautour
{
    public partial class PlayForm : Form
    {
        MenuForm menuform;
        PlateauJeu plateauJeu;
        int nb_player;
        public PlayForm(MenuForm menuform)
        {
            InitializeComponent();
            this.menuform = menuform;
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {
            cb_nbPlayer.SelectedItem = "2";
            cb_ia1.SelectedItem = "Facile"; cb_ia2.SelectedItem = "Facile"; cb_ia3.SelectedItem = "Facile";
            cb_ia4.SelectedItem = "Facile"; cb_ia5.SelectedItem = "Facile";
            //ListItem li = new ListItem("Facile", "0");
            cb_ia1.Items.Add("Facile"); cb_ia1.Items.Add("Moyen"); cb_ia1.Items.Add("Difficile");
            cb_ia2.Items.Add("Facile"); cb_ia2.Items.Add("Moyen"); cb_ia2.Items.Add("Difficile");
            cb_ia3.Items.Add("Facile"); cb_ia3.Items.Add("Moyen"); cb_ia3.Items.Add("Difficile");
            cb_ia4.Items.Add("Facile"); cb_ia4.Items.Add("Moyen"); cb_ia4.Items.Add("Difficile");
            cb_ia5.Items.Add("Facile"); cb_ia5.Items.Add("Moyen"); cb_ia5.Items.Add("Difficile"); 

            label_ia1.Text = "Niveau difficulté IA 1";
            cb_ia2.Visible = false; cb_ia3.Visible = false; cb_ia4.Visible = false; cb_ia5.Visible = false;
            label_ia2.Visible = false; label_ia3.Visible = false; label_ia4.Visible = false; label_ia5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            menuform.Visible = true;
        }

        private void PlayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cb_nbPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            nb_player = Convert.ToInt16(cb_nbPlayer.SelectedItem);
            switch (nb_player )
            {
                case 2 :
                    label_ia1.Text = "Niveau difficulté IA 1";
                    cb_ia1.Visible = true;cb_ia2.Visible = false; cb_ia3.Visible = false; cb_ia4.Visible = false; cb_ia5.Visible = false;
                    label_ia1.Visible = true; label_ia2.Visible = false; label_ia3.Visible = false; label_ia4.Visible = false; label_ia5.Visible = false;
                    break;
                case 3 :
                    label_ia2.Text = "Niveau difficulté IA 1"; label_ia3.Text = "Niveau difficulté IA 2";
                    cb_ia1.Visible = false;cb_ia2.Visible = true; cb_ia3.Visible = true; cb_ia4.Visible = false; cb_ia5.Visible = false;
                    label_ia1.Visible = false; label_ia2.Visible = true; label_ia3.Visible = true; label_ia4.Visible = false; label_ia5.Visible = false;
                    break;
                case 4 :
                    label_ia1.Text = "Niveau difficulté IA 3"; label_ia2.Text = "Niveau difficulté IA 1"; label_ia3.Text = "Niveau difficulté IA 2";
                    cb_ia1.Visible = true;cb_ia2.Visible = true; cb_ia3.Visible = true; cb_ia4.Visible = false; cb_ia5.Visible = false;
                    label_ia1.Visible = true; label_ia2.Visible = true; label_ia3.Visible = true; label_ia4.Visible = false; label_ia5.Visible = false;
                    break;
                default :
                    label_ia4.Text = "Niveau difficulté IA 3"; label_ia2.Text = "Niveau difficulté IA 1"; label_ia3.Text = "Niveau difficulté IA 2"; label_ia5.Text = "Niveau difficulté IA 4";
                    cb_ia1.Visible = false;cb_ia2.Visible = true; cb_ia3.Visible = true; cb_ia4.Visible = true; cb_ia5.Visible = true;
                    label_ia1.Visible = false; label_ia2.Visible = true; label_ia3.Visible = true; label_ia4.Visible = true; label_ia5.Visible = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            List<String> list_player = new List<string>();
            switch (nb_player)
            {
                case 2:
                    list_player.Add(cb_ia1.Text);
                    break;
                case 3:
                    list_player.Add(cb_ia2.Text); list_player.Add(cb_ia3.Text);
                    break;
                case 4:
                    list_player.Add(cb_ia1.Text); list_player.Add(cb_ia2.Text); list_player.Add(cb_ia3.Text);
                    break;
                case 5:
                    list_player.Add(cb_ia2.Text); list_player.Add(cb_ia3.Text);list_player.Add(cb_ia4.Text); list_player.Add(cb_ia5.Text);
                    break;
            }
            plateauJeu = new PlateauJeu(this, new Game(list_player));
            plateauJeu.Visible = true;
        }



    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stupide_Vautour
{
    public partial class PlayForm : Form
    {
        MenuForm menuform;
        int nb_player;
        public PlayForm(MenuForm menuform)
        {
            InitializeComponent();
            this.menuform = menuform;
            
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void Nb_player_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


    }
}

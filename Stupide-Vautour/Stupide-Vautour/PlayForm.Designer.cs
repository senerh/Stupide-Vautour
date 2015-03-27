namespace Stupide_Vautour
{
    partial class PlayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_nbPlayer = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cb_ia2 = new System.Windows.Forms.ComboBox();
            this.cb_ia3 = new System.Windows.Forms.ComboBox();
            this.cb_ia1 = new System.Windows.Forms.ComboBox();
            this.cb_ia4 = new System.Windows.Forms.ComboBox();
            this.cb_ia5 = new System.Windows.Forms.ComboBox();
            this.label_ia2 = new System.Windows.Forms.Label();
            this.label_ia3 = new System.Windows.Forms.Label();
            this.label_ia1 = new System.Windows.Forms.Label();
            this.label_ia4 = new System.Windows.Forms.Label();
            this.label_ia5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de joueurs";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(389, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Let\'s Go !";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 524);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "retour au MenuForm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_nbPlayer
            // 
            this.cb_nbPlayer.FormattingEnabled = true;
            this.cb_nbPlayer.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.cb_nbPlayer.Location = new System.Drawing.Point(369, 143);
            this.cb_nbPlayer.Name = "cb_nbPlayer";
            this.cb_nbPlayer.Size = new System.Drawing.Size(121, 21);
            this.cb_nbPlayer.TabIndex = 7;
            this.cb_nbPlayer.SelectedIndexChanged += new System.EventHandler(this.cb_nbPlayer_SelectedIndexChanged);
            // 
            // cb_ia2
            // 
            this.cb_ia2.FormattingEnabled = true;
            this.cb_ia2.Location = new System.Drawing.Point(280, 245);
            this.cb_ia2.Name = "cb_ia2";
            this.cb_ia2.Size = new System.Drawing.Size(121, 21);
            this.cb_ia2.TabIndex = 8;
            // 
            // cb_ia3
            // 
            this.cb_ia3.FormattingEnabled = true;
            this.cb_ia3.Location = new System.Drawing.Point(453, 245);
            this.cb_ia3.Name = "cb_ia3";
            this.cb_ia3.Size = new System.Drawing.Size(121, 21);
            this.cb_ia3.TabIndex = 9;
            // 
            // cb_ia1
            // 
            this.cb_ia1.FormattingEnabled = true;
            this.cb_ia1.Location = new System.Drawing.Point(369, 305);
            this.cb_ia1.Name = "cb_ia1";
            this.cb_ia1.Size = new System.Drawing.Size(121, 21);
            this.cb_ia1.TabIndex = 10;
            // 
            // cb_ia4
            // 
            this.cb_ia4.FormattingEnabled = true;
            this.cb_ia4.Location = new System.Drawing.Point(280, 372);
            this.cb_ia4.Name = "cb_ia4";
            this.cb_ia4.Size = new System.Drawing.Size(121, 21);
            this.cb_ia4.TabIndex = 11;
            // 
            // cb_ia5
            // 
            this.cb_ia5.FormattingEnabled = true;
            this.cb_ia5.Location = new System.Drawing.Point(453, 372);
            this.cb_ia5.Name = "cb_ia5";
            this.cb_ia5.Size = new System.Drawing.Size(121, 21);
            this.cb_ia5.TabIndex = 12;
            // 
            // label_ia2
            // 
            this.label_ia2.AutoSize = true;
            this.label_ia2.Location = new System.Drawing.Point(319, 229);
            this.label_ia2.Name = "label_ia2";
            this.label_ia2.Size = new System.Drawing.Size(35, 13);
            this.label_ia2.TabIndex = 13;
            this.label_ia2.Text = "label2";
            // 
            // label_ia3
            // 
            this.label_ia3.AutoSize = true;
            this.label_ia3.Location = new System.Drawing.Point(497, 229);
            this.label_ia3.Name = "label_ia3";
            this.label_ia3.Size = new System.Drawing.Size(35, 13);
            this.label_ia3.TabIndex = 14;
            this.label_ia3.Text = "label3";
            // 
            // label_ia1
            // 
            this.label_ia1.AutoSize = true;
            this.label_ia1.Location = new System.Drawing.Point(412, 289);
            this.label_ia1.Name = "label_ia1";
            this.label_ia1.Size = new System.Drawing.Size(35, 13);
            this.label_ia1.TabIndex = 15;
            this.label_ia1.Text = "label4";
            // 
            // label_ia4
            // 
            this.label_ia4.AutoSize = true;
            this.label_ia4.Location = new System.Drawing.Point(319, 356);
            this.label_ia4.Name = "label_ia4";
            this.label_ia4.Size = new System.Drawing.Size(35, 13);
            this.label_ia4.TabIndex = 16;
            this.label_ia4.Text = "label5";
            // 
            // label_ia5
            // 
            this.label_ia5.AutoSize = true;
            this.label_ia5.Location = new System.Drawing.Point(497, 356);
            this.label_ia5.Name = "label_ia5";
            this.label_ia5.Size = new System.Drawing.Size(35, 13);
            this.label_ia5.TabIndex = 17;
            this.label_ia5.Text = "label6";
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.label_ia5);
            this.Controls.Add(this.label_ia4);
            this.Controls.Add(this.label_ia1);
            this.Controls.Add(this.label_ia3);
            this.Controls.Add(this.label_ia2);
            this.Controls.Add(this.cb_ia5);
            this.Controls.Add(this.cb_ia4);
            this.Controls.Add(this.cb_ia1);
            this.Controls.Add(this.cb_ia3);
            this.Controls.Add(this.cb_ia2);
            this.Controls.Add(this.cb_nbPlayer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "PlayForm";
            this.Text = "PlayForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayForm_FormClosing);
            this.Load += new System.EventHandler(this.PlayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb_nbPlayer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cb_ia2;
        private System.Windows.Forms.ComboBox cb_ia3;
        private System.Windows.Forms.ComboBox cb_ia1;
        private System.Windows.Forms.ComboBox cb_ia4;
        private System.Windows.Forms.ComboBox cb_ia5;
        private System.Windows.Forms.Label label_ia2;
        private System.Windows.Forms.Label label_ia3;
        private System.Windows.Forms.Label label_ia1;
        private System.Windows.Forms.Label label_ia4;
        private System.Windows.Forms.Label label_ia5;
    }
}
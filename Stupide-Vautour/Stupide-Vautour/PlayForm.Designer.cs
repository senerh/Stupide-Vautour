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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayForm));
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(125, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de joueurs";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(139, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Jouer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(139, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Retour";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_nbPlayer
            // 
            this.cb_nbPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_nbPlayer.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_nbPlayer.FormattingEnabled = true;
            this.cb_nbPlayer.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.cb_nbPlayer.Location = new System.Drawing.Point(128, 53);
            this.cb_nbPlayer.Name = "cb_nbPlayer";
            this.cb_nbPlayer.Size = new System.Drawing.Size(121, 22);
            this.cb_nbPlayer.TabIndex = 7;
            this.cb_nbPlayer.SelectedIndexChanged += new System.EventHandler(this.cb_nbPlayer_SelectedIndexChanged);
            // 
            // cb_ia2
            // 
            this.cb_ia2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_ia2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ia2.FormattingEnabled = true;
            this.cb_ia2.Location = new System.Drawing.Point(39, 155);
            this.cb_ia2.Name = "cb_ia2";
            this.cb_ia2.Size = new System.Drawing.Size(121, 22);
            this.cb_ia2.TabIndex = 8;
            // 
            // cb_ia3
            // 
            this.cb_ia3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_ia3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ia3.FormattingEnabled = true;
            this.cb_ia3.Location = new System.Drawing.Point(212, 155);
            this.cb_ia3.Name = "cb_ia3";
            this.cb_ia3.Size = new System.Drawing.Size(121, 22);
            this.cb_ia3.TabIndex = 9;
            // 
            // cb_ia1
            // 
            this.cb_ia1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_ia1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ia1.FormattingEnabled = true;
            this.cb_ia1.Location = new System.Drawing.Point(128, 215);
            this.cb_ia1.Name = "cb_ia1";
            this.cb_ia1.Size = new System.Drawing.Size(121, 22);
            this.cb_ia1.TabIndex = 10;
            // 
            // cb_ia4
            // 
            this.cb_ia4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_ia4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ia4.FormattingEnabled = true;
            this.cb_ia4.Location = new System.Drawing.Point(39, 282);
            this.cb_ia4.Name = "cb_ia4";
            this.cb_ia4.Size = new System.Drawing.Size(121, 22);
            this.cb_ia4.TabIndex = 11;
            // 
            // cb_ia5
            // 
            this.cb_ia5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_ia5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ia5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cb_ia5.FormattingEnabled = true;
            this.cb_ia5.Location = new System.Drawing.Point(212, 282);
            this.cb_ia5.Name = "cb_ia5";
            this.cb_ia5.Size = new System.Drawing.Size(121, 22);
            this.cb_ia5.TabIndex = 12;
            // 
            // label_ia2
            // 
            this.label_ia2.AutoSize = true;
            this.label_ia2.BackColor = System.Drawing.Color.Transparent;
            this.label_ia2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ia2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_ia2.Location = new System.Drawing.Point(36, 139);
            this.label_ia2.Name = "label_ia2";
            this.label_ia2.Size = new System.Drawing.Size(45, 14);
            this.label_ia2.TabIndex = 13;
            this.label_ia2.Text = "label2";
            // 
            // label_ia3
            // 
            this.label_ia3.AutoSize = true;
            this.label_ia3.BackColor = System.Drawing.Color.Transparent;
            this.label_ia3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_ia3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ia3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_ia3.Location = new System.Drawing.Point(209, 139);
            this.label_ia3.Name = "label_ia3";
            this.label_ia3.Size = new System.Drawing.Size(45, 14);
            this.label_ia3.TabIndex = 14;
            this.label_ia3.Text = "label3";
            // 
            // label_ia1
            // 
            this.label_ia1.AutoSize = true;
            this.label_ia1.BackColor = System.Drawing.Color.Transparent;
            this.label_ia1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ia1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_ia1.Location = new System.Drawing.Point(125, 199);
            this.label_ia1.Name = "label_ia1";
            this.label_ia1.Size = new System.Drawing.Size(45, 14);
            this.label_ia1.TabIndex = 15;
            this.label_ia1.Text = "label4";
            // 
            // label_ia4
            // 
            this.label_ia4.AutoSize = true;
            this.label_ia4.BackColor = System.Drawing.Color.Transparent;
            this.label_ia4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ia4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_ia4.Location = new System.Drawing.Point(36, 266);
            this.label_ia4.Name = "label_ia4";
            this.label_ia4.Size = new System.Drawing.Size(45, 14);
            this.label_ia4.TabIndex = 16;
            this.label_ia4.Text = "label5";
            // 
            // label_ia5
            // 
            this.label_ia5.AutoSize = true;
            this.label_ia5.BackColor = System.Drawing.Color.Transparent;
            this.label_ia5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ia5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_ia5.Location = new System.Drawing.Point(209, 266);
            this.label_ia5.Name = "label_ia5";
            this.label_ia5.Size = new System.Drawing.Size(45, 14);
            this.label_ia5.TabIndex = 17;
            this.label_ia5.Text = "label6";
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(373, 489);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "PlayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
namespace Kuretar_Displayer_Searcher
{
    partial class UI
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.displayMorph = new System.Windows.Forms.ComboBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.displayItem = new System.Windows.Forms.ComboBox();
            this.FiltreTxt = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NPC = new System.Windows.Forms.PictureBox();
            this.Item = new System.Windows.Forms.PictureBox();
            this.NpcLabel = new System.Windows.Forms.Label();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ArmorLabel = new System.Windows.Forms.Label();
            this.Armor = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.texTex2 = new System.Windows.Forms.Label();
            this.texTex1 = new System.Windows.Forms.Label();
            this.texModel2 = new System.Windows.Forms.Label();
            this.texModel1 = new System.Windows.Forms.Label();
            this.texDisplay = new System.Windows.Forms.Label();
            this.TexBodyList = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Armor)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayMorph
            // 
            this.displayMorph.FormattingEnabled = true;
            this.displayMorph.Location = new System.Drawing.Point(377, 148);
            this.displayMorph.Name = "displayMorph";
            this.displayMorph.Size = new System.Drawing.Size(381, 21);
            this.displayMorph.TabIndex = 4;
            this.displayMorph.SelectedIndexChanged += new System.EventHandler(this.displayMorph_SelectedIndexChanged);
            this.displayMorph.KeyDown += new System.Windows.Forms.KeyEventHandler(this.displayMorph_KeyDown);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = global::Kuretar_Displayer_Searcher.Properties.Resources.logoPlaceholder;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(13, 13);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(130, 130);
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            // 
            // displayItem
            // 
            this.displayItem.FormattingEnabled = true;
            this.displayItem.Location = new System.Drawing.Point(377, 265);
            this.displayItem.Name = "displayItem";
            this.displayItem.Size = new System.Drawing.Size(381, 21);
            this.displayItem.TabIndex = 0;
            this.displayItem.SelectedIndexChanged += new System.EventHandler(this.displayItem_SelectedIndexChanged);
            // 
            // FiltreTxt
            // 
            this.FiltreTxt.Location = new System.Drawing.Point(463, 149);
            this.FiltreTxt.Name = "FiltreTxt";
            this.FiltreTxt.Size = new System.Drawing.Size(211, 20);
            this.FiltreTxt.TabIndex = 1;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchBtn.BackgroundImage = global::Kuretar_Displayer_Searcher.Properties.Resources.buttonstd;
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(498, 190);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(138, 48);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "Recherche";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            this.SearchBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SearchBtn_MouseDown);
            this.SearchBtn.MouseEnter += new System.EventHandler(this.SearchBtn_MouseEnter);
            this.SearchBtn.MouseLeave += new System.EventHandler(this.SearchBtn_MouseLeave);
            this.SearchBtn.MouseHover += new System.EventHandler(this.SearchBtn_MouseHover);
            this.SearchBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SearchBtn_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(86, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(951, 5);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // NPC
            // 
            this.NPC.BackColor = System.Drawing.Color.Transparent;
            this.NPC.BackgroundImage = global::Kuretar_Displayer_Searcher.Properties.Resources.Monster_Logo;
            this.NPC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NPC.Location = new System.Drawing.Point(230, 50);
            this.NPC.Name = "NPC";
            this.NPC.Size = new System.Drawing.Size(23, 23);
            this.NPC.TabIndex = 10;
            this.NPC.TabStop = false;
            // 
            // Item
            // 
            this.Item.BackColor = System.Drawing.Color.Transparent;
            this.Item.BackgroundImage = global::Kuretar_Displayer_Searcher.Properties.Resources.Sword_Logo;
            this.Item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Item.Location = new System.Drawing.Point(465, 50);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(23, 23);
            this.Item.TabIndex = 11;
            this.Item.TabStop = false;
            // 
            // NpcLabel
            // 
            this.NpcLabel.AutoSize = true;
            this.NpcLabel.BackColor = System.Drawing.Color.Transparent;
            this.NpcLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NpcLabel.ForeColor = System.Drawing.Color.White;
            this.NpcLabel.Location = new System.Drawing.Point(259, 50);
            this.NpcLabel.Name = "NpcLabel";
            this.NpcLabel.Size = new System.Drawing.Size(160, 23);
            this.NpcLabel.TabIndex = 12;
            this.NpcLabel.Text = "Morph Viewer";
            this.NpcLabel.Click += new System.EventHandler(this.NpcLabel_Click);
            // 
            // ItemLabel
            // 
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.BackColor = System.Drawing.Color.Transparent;
            this.ItemLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemLabel.ForeColor = System.Drawing.Color.White;
            this.ItemLabel.Location = new System.Drawing.Point(494, 50);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(180, 23);
            this.ItemLabel.TabIndex = 13;
            this.ItemLabel.Text = "Weapon Viewer";
            this.ItemLabel.Click += new System.EventHandler(this.ItemLabel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(436, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(3, 35);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(695, 45);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(3, 35);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // ArmorLabel
            // 
            this.ArmorLabel.AutoSize = true;
            this.ArmorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ArmorLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArmorLabel.ForeColor = System.Drawing.Color.White;
            this.ArmorLabel.Location = new System.Drawing.Point(754, 50);
            this.ArmorLabel.Name = "ArmorLabel";
            this.ArmorLabel.Size = new System.Drawing.Size(159, 23);
            this.ArmorLabel.TabIndex = 16;
            this.ArmorLabel.Text = "Armor Viewer";
            this.ArmorLabel.Click += new System.EventHandler(this.ArmorLabel_Click);
            // 
            // Armor
            // 
            this.Armor.BackColor = System.Drawing.Color.Transparent;
            this.Armor.BackgroundImage = global::Kuretar_Displayer_Searcher.Properties.Resources.Helm_Logo;
            this.Armor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Armor.Location = new System.Drawing.Point(725, 50);
            this.Armor.Name = "Armor";
            this.Armor.Size = new System.Drawing.Size(23, 23);
            this.Armor.TabIndex = 15;
            this.Armor.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(484, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 458);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.texTex2);
            this.panel2.Controls.Add(this.texTex1);
            this.panel2.Controls.Add(this.texModel2);
            this.panel2.Controls.Add(this.texModel1);
            this.panel2.Controls.Add(this.texDisplay);
            this.panel2.Controls.Add(this.TexBodyList);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(13, 310);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 458);
            this.panel2.TabIndex = 19;
            // 
            // texTex2
            // 
            this.texTex2.AutoSize = true;
            this.texTex2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texTex2.ForeColor = System.Drawing.Color.White;
            this.texTex2.Location = new System.Drawing.Point(111, 161);
            this.texTex2.Name = "texTex2";
            this.texTex2.Size = new System.Drawing.Size(0, 16);
            this.texTex2.TabIndex = 11;
            // 
            // texTex1
            // 
            this.texTex1.AutoSize = true;
            this.texTex1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texTex1.ForeColor = System.Drawing.Color.White;
            this.texTex1.Location = new System.Drawing.Point(111, 123);
            this.texTex1.Name = "texTex1";
            this.texTex1.Size = new System.Drawing.Size(0, 16);
            this.texTex1.TabIndex = 10;
            // 
            // texModel2
            // 
            this.texModel2.AutoSize = true;
            this.texModel2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texModel2.ForeColor = System.Drawing.Color.White;
            this.texModel2.Location = new System.Drawing.Point(92, 85);
            this.texModel2.Name = "texModel2";
            this.texModel2.Size = new System.Drawing.Size(0, 16);
            this.texModel2.TabIndex = 9;
            // 
            // texModel1
            // 
            this.texModel1.AutoSize = true;
            this.texModel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texModel1.ForeColor = System.Drawing.Color.White;
            this.texModel1.Location = new System.Drawing.Point(92, 45);
            this.texModel1.Name = "texModel1";
            this.texModel1.Size = new System.Drawing.Size(0, 16);
            this.texModel1.TabIndex = 8;
            // 
            // texDisplay
            // 
            this.texDisplay.AutoSize = true;
            this.texDisplay.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texDisplay.ForeColor = System.Drawing.Color.White;
            this.texDisplay.Location = new System.Drawing.Point(107, 6);
            this.texDisplay.Name = "texDisplay";
            this.texDisplay.Size = new System.Drawing.Size(0, 16);
            this.texDisplay.TabIndex = 7;
            // 
            // TexBodyList
            // 
            this.TexBodyList.AutoSize = true;
            this.TexBodyList.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBodyList.ForeColor = System.Drawing.Color.White;
            this.TexBodyList.Location = new System.Drawing.Point(7, 242);
            this.TexBodyList.Name = "TexBodyList";
            this.TexBodyList.Size = new System.Drawing.Size(0, 13);
            this.TexBodyList.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Listing Texture Corps:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Texture 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Texture 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model 1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "DisplayID:";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kuretar_Displayer_Searcher.Properties.Resources.background_default;
            this.ClientSize = new System.Drawing.Size(1049, 780);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ArmorLabel);
            this.Controls.Add(this.Armor);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ItemLabel);
            this.Controls.Add(this.NpcLabel);
            this.Controls.Add(this.Item);
            this.Controls.Add(this.NPC);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.displayMorph);
            this.Controls.Add(this.displayItem);
            this.Controls.Add(this.FiltreTxt);
            this.Controls.Add(this.SearchBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kuretar Display Searcher BFA V1 Bêta";
            this.Load += new System.EventHandler(this.UI_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UI_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Armor)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox displayMorph;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.ComboBox displayItem;
        private System.Windows.Forms.TextBox FiltreTxt;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox NPC;
        private System.Windows.Forms.PictureBox Item;
        private System.Windows.Forms.Label NpcLabel;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label ArmorLabel;
        private System.Windows.Forms.PictureBox Armor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TexBodyList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label texTex2;
        private System.Windows.Forms.Label texTex1;
        private System.Windows.Forms.Label texModel2;
        private System.Windows.Forms.Label texModel1;
        private System.Windows.Forms.Label texDisplay;
    }
}


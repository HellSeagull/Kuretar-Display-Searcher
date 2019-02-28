namespace Kuretar_Display_Searcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.displayMorph = new System.Windows.Forms.ComboBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.displayItem = new System.Windows.Forms.ComboBox();
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
            this.texAppID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AppFindBtn = new System.Windows.Forms.Button();
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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.FilterBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FiltreLbl = new System.Windows.Forms.Label();
            this.FilterBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Armor)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // displayMorph
            // 
            this.displayMorph.FormattingEnabled = true;
            this.displayMorph.Location = new System.Drawing.Point(339, 192);
            this.displayMorph.Name = "displayMorph";
            this.displayMorph.Size = new System.Drawing.Size(381, 21);
            this.displayMorph.TabIndex = 4;
            this.displayMorph.SelectedIndexChanged += new System.EventHandler(this.displayMorph_SelectedIndexChanged);
            this.displayMorph.KeyDown += new System.Windows.Forms.KeyEventHandler(this.displayMorph_KeyDown);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = global::Kuretar_Display_Searcher.Properties.Resources.logoPlaceholder;
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
            this.displayItem.Location = new System.Drawing.Point(520, 206);
            this.displayItem.Name = "displayItem";
            this.displayItem.Size = new System.Drawing.Size(381, 21);
            this.displayItem.TabIndex = 0;
            this.displayItem.SelectedIndexChanged += new System.EventHandler(this.displayItem_SelectedIndexChanged);
            this.displayItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.displayItem_KeyDown);
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
            this.NPC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NPC.BackgroundImage")));
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
            this.Item.BackgroundImage = global::Kuretar_Display_Searcher.Properties.Resources.Sword_Logo;
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
            this.Armor.BackgroundImage = global::Kuretar_Display_Searcher.Properties.Resources.Helm_Logo;
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
            this.panel2.Controls.Add(this.texAppID);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.AppFindBtn);
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
            // texAppID
            // 
            this.texAppID.AutoSize = true;
            this.texAppID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texAppID.ForeColor = System.Drawing.Color.White;
            this.texAppID.Location = new System.Drawing.Point(222, 424);
            this.texAppID.Name = "texAppID";
            this.texAppID.Size = new System.Drawing.Size(0, 16);
            this.texAppID.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(147, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "AppID:";
            // 
            // AppFindBtn
            // 
            this.AppFindBtn.BackColor = System.Drawing.Color.Transparent;
            this.AppFindBtn.BackgroundImage = global::Kuretar_Display_Searcher.Properties.Resources.buttonstd;
            this.AppFindBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AppFindBtn.FlatAppearance.BorderSize = 0;
            this.AppFindBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppFindBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppFindBtn.ForeColor = System.Drawing.Color.White;
            this.AppFindBtn.Location = new System.Drawing.Point(3, 407);
            this.AppFindBtn.Name = "AppFindBtn";
            this.AppFindBtn.Size = new System.Drawing.Size(138, 48);
            this.AppFindBtn.TabIndex = 20;
            this.AppFindBtn.Text = "AppFind";
            this.AppFindBtn.UseVisualStyleBackColor = false;
            this.AppFindBtn.Click += new System.EventHandler(this.AppFindBtn_Click);
            this.AppFindBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AppFindBtn_MouseDown);
            this.AppFindBtn.MouseEnter += new System.EventHandler(this.AppFindBtn_MouseEnter);
            this.AppFindBtn.MouseLeave += new System.EventHandler(this.AppFindBtn_MouseLeave);
            this.AppFindBtn.MouseHover += new System.EventHandler(this.AppFindBtn_MouseHover);
            this.AppFindBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AppFindBtn_MouseUp);
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
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Kuretar_Display_Searcher.Properties.Resources.glues_wow_battleforazerothlogo;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Location = new System.Drawing.Point(263, 192);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(520, 240);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // FilterBox
            // 
            this.FilterBox.FormattingEnabled = true;
            this.FilterBox.Location = new System.Drawing.Point(339, 192);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(175, 21);
            this.FilterBox.TabIndex = 20;
            this.FilterBox.SelectedIndexChanged += new System.EventHandler(this.FilterBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(83, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "Choisissez un type d\'Arme:";
            // 
            // FiltreLbl
            // 
            this.FiltreLbl.AutoSize = true;
            this.FiltreLbl.BackColor = System.Drawing.Color.Transparent;
            this.FiltreLbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltreLbl.ForeColor = System.Drawing.Color.White;
            this.FiltreLbl.Location = new System.Drawing.Point(907, 205);
            this.FiltreLbl.Name = "FiltreLbl";
            this.FiltreLbl.Size = new System.Drawing.Size(0, 18);
            this.FiltreLbl.TabIndex = 22;
            // 
            // FilterBox2
            // 
            this.FilterBox2.FormattingEnabled = true;
            this.FilterBox2.Location = new System.Drawing.Point(339, 219);
            this.FilterBox2.Name = "FilterBox2";
            this.FilterBox2.Size = new System.Drawing.Size(175, 21);
            this.FilterBox2.TabIndex = 23;
            this.FilterBox2.SelectedIndexChanged += new System.EventHandler(this.FilterBox2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(54, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(248, 72);
            this.label9.TabIndex = 24;
            this.label9.Text = "Pour filtrer, taper votre \r\nrecherche puis appuyer sur\r\n\'Entrer\' pour aller à la\r" +
    "\npremière occurence\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(449, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 18);
            this.label10.TabIndex = 25;
            this.label10.Text = "Liste des Morphs\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(101, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(861, 38);
            this.label11.TabIndex = 26;
            this.label11.Text = "Bienvenue sur le Kuretar Display Searcher V2 !\r\n";
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.Close.Location = new System.Drawing.Point(1012, 9);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(25, 23);
            this.Close.TabIndex = 42;
            this.Close.Text = "X";
            this.Close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Close_MouseClick);
            this.Close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Close_MouseDown);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            this.Close.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Close_MouseUp);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kuretar_Display_Searcher.Properties.Resources.background_default;
            this.ClientSize = new System.Drawing.Size(1049, 780);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FilterBox2);
            this.Controls.Add(this.FiltreLbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FilterBox);
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
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kuretar Display Searcher BFA V2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UI_FormClosing);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox displayMorph;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.ComboBox displayItem;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AppFindBtn;
        private System.Windows.Forms.Label texAppID;
        private System.Windows.Forms.ComboBox FilterBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label FiltreLbl;
        private System.Windows.Forms.ComboBox FilterBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Close;
    }
}


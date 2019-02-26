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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn3D = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxItem = new System.Windows.Forms.RichTextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.FiltreTxt = new System.Windows.Forms.TextBox();
            this.displayItem = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.displayMorph = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn3D);
            this.groupBox1.Controls.Add(this.resultLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxItem);
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.FiltreTxt);
            this.groupBox1.Controls.Add(this.displayItem);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 460);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display item Info";
            // 
            // Btn3D
            // 
            this.Btn3D.Location = new System.Drawing.Point(261, 185);
            this.Btn3D.Name = "Btn3D";
            this.Btn3D.Size = new System.Drawing.Size(75, 23);
            this.Btn3D.TabIndex = 6;
            this.Btn3D.Text = "Visuel 3D";
            this.Btn3D.UseVisualStyleBackColor = true;
            this.Btn3D.Click += new System.EventHandler(this.Btn3D_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(9, 206);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 135);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // textBoxItem
            // 
            this.textBoxItem.Location = new System.Drawing.Point(7, 253);
            this.textBoxItem.Name = "textBoxItem";
            this.textBoxItem.Size = new System.Drawing.Size(380, 201);
            this.textBoxItem.TabIndex = 3;
            this.textBoxItem.Text = "";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(161, 186);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "Recherche";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // FiltreTxt
            // 
            this.FiltreTxt.Location = new System.Drawing.Point(147, 151);
            this.FiltreTxt.Name = "FiltreTxt";
            this.FiltreTxt.Size = new System.Drawing.Size(100, 20);
            this.FiltreTxt.TabIndex = 1;
            // 
            // displayItem
            // 
            this.displayItem.FormattingEnabled = true;
            this.displayItem.Location = new System.Drawing.Point(6, 225);
            this.displayItem.Name = "displayItem";
            this.displayItem.Size = new System.Drawing.Size(381, 21);
            this.displayItem.TabIndex = 0;
            this.displayItem.SelectedIndexChanged += new System.EventHandler(this.displayItem_SelectedIndexChanged);
            this.displayItem.TextChanged += new System.EventHandler(this.displayItem_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.displayMorph);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(411, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 460);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste Morph";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(9, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 261);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 45);
            this.label2.TabIndex = 8;
            this.label2.Text = "Liste de morph, filtrer dans la liste en écrivant\r\net appuyez sur \"Entrer\" pour a" +
    "ller au premier\r\nrésultat possible.";
            // 
            // displayMorph
            // 
            this.displayMorph.FormattingEnabled = true;
            this.displayMorph.Location = new System.Drawing.Point(9, 166);
            this.displayMorph.Name = "displayMorph";
            this.displayMorph.Size = new System.Drawing.Size(381, 21);
            this.displayMorph.TabIndex = 4;
            this.displayMorph.KeyDown += new System.Windows.Forms.KeyEventHandler(this.displayMorph_KeyDown);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 484);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UI";
            this.Text = "Kuretar Display Searcher BFA V1 Bêta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textBoxItem;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox FiltreTxt;
        private System.Windows.Forms.ComboBox displayItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox displayMorph;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button Btn3D;
        private System.Windows.Forms.Panel panel1;
    }
}


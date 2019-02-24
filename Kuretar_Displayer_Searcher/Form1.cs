using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Kuretar_Displayer_Searcher
{
    public partial class Form1 : Form
    {

        string items = Properties.Resources.DB_ITEM_BFA;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Veuillez patienter pendant le chargement de l'application", "Chargement", 2000);
            #region listemorph

            string result = Properties.Resources.ListingMorph;         

            string[] morphs = result.Split(',');

            foreach(string s in morphs)
            {
                displayMorph.Items.Add(s);
            }

            #endregion

            #region item
            foreach(string s in items.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None))
            {
                displayItem.Items.Add(s);
            }
            #endregion

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            displayItem.Items.Clear();
            if (FiltreTxt.Text != "")
            {
                foreach (string s in items.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None))
                {
                    try
                    {
                        if (s != "" || s != null)
                        {
                            if (s.Split('|')[1].Contains(FiltreTxt.Text.ToLowerInvariant()))
                            {
                                displayItem.Items.Add(s);
                                //break;
                            }
                            else if (s.Split('|')[2].Contains(FiltreTxt.Text.ToLowerInvariant()))
                            {
                                displayItem.Items.Add(s);
                                //break;
                            }
                            else if (s.Split('|').Count() == 6)
                            {
                                if (s.Split('|')[1] == "0" && s.Split('|')[2] == "0")
                                {
                                    if (s.Split('|')[5].Contains("_"))
                                    {
                                        if (s.Split('|')[5].Contains(FiltreTxt.Text.ToLowerInvariant()))
                                        {
                                            displayItem.Items.Add(s);
                                            //break;
                                        }
                                    }
                                }
                            }
                            else if (s.Split('|').Count() == 7)
                            {
                                if (s.Split('|')[1] == "0" && s.Split('|')[2] == "0")
                                {
                                    if (s.Split('|')[6].Contains("_"))
                                    {
                                        if (s.Split('|')[6].Contains(FiltreTxt.Text.ToLowerInvariant()))
                                        {
                                            displayItem.Items.Add(s);
                                            //break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch { }
                }
                resultLabel.Text = "Résultat Filtre OK";
            }
        }

        private delegate void addColorTextBox(RichTextBox t, Color color, string text);

        private void addColorText(RichTextBox t, Color color, string text)
        {
            if (t.InvokeRequired)
            {
                t.Invoke(new addColorTextBox(addColorText), t, color, text);
                return;
            }
            t.SelectionStart = t.TextLength;
            t.SelectionLength = 0;
            t.SelectionColor = color;
            t.AppendText(text + "\n");
            t.SelectionColor = t.ForeColor;
        }

        private void displayItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            textBoxItem.Clear();
            addColorText(textBoxItem, Color.Blue, "DisplayID : " + displayItem.SelectedItem.ToString().Split('|')[0]);
            addColorText(textBoxItem, Color.Blue, "Model_Gauche : " + displayItem.SelectedItem.ToString().Split('|')[1]);
            addColorText(textBoxItem, Color.Blue, "Model_Droit : " + displayItem.SelectedItem.ToString().Split('|')[2]);
            addColorText(textBoxItem, Color.Blue, "Tex_Gauche : " + displayItem.SelectedItem.ToString().Split('|')[3]);
            addColorText(textBoxItem, Color.Blue, "Tex_Droite : " + displayItem.SelectedItem.ToString().Split('|')[4]);
            if (displayItem.SelectedItem.ToString().Split('|').Count() == 7)
            {
                if (displayItem.SelectedItem.ToString().Split('|')[6].Contains("_"))
                {
                    for (int k = 0; k < displayItem.SelectedItem.ToString().Split('|')[6].Split(';').Count(); k++)
                    {
                        addColorText(textBoxItem, Color.Red, "Textures de Corps : " + displayItem.SelectedItem.ToString().Split('|')[6].Split(';')[k]
                            + ":\n------- " 
                            + displayItem.SelectedItem.ToString().Split('|')[5].Split(':')[1].Split(';')[k]);
                    }
                }
            }

            addColorText(textBoxItem, Color.Black, "\nIndication : Pour visualiser l'objet, veuillez utiliser le visualisateur de la forge Kuretar pour le moment");
            textBoxItem.ScrollToCaret();

        }

        private void displayItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void displayMorph_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string text = displayMorph.Text;
                displayMorph.Text = "";
                foreach (var o in displayMorph.Items)
                {
                    if (o.ToString().Contains(text))
                    {
                        displayMorph.SelectedIndex = displayMorph.FindString(o.ToString());
                        break;
                    }
                }
            }
        }
    }
}

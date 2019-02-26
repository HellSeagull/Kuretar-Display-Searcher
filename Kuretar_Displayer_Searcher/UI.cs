using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using CefSharp.WinForms;
using CefSharp;
using CefSharp.SchemeHandler;

namespace Kuretar_Displayer_Searcher
{
    public partial class UI : Form
    {

        string items = Properties.Resources.DB_ITEM_BFA;
        string html = string.Empty;
        private BindingSource _bindingsource = new BindingSource();
        private FileSystemWatcher watcher = new FileSystemWatcher();
        public static readonly string TEMP_FOLDER = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Kuretar_Displayer_Searcher");
        ChromiumWebBrowser chromeBrowser;

        public UI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //UpdateManager.CheckForUpdate();

            #region listemorph

            string result = Properties.Resources.ListingMorph;

            string[] morphs = result.Split(',');

            foreach (string s in morphs)
            {
                displayMorph.Items.Add(s);
            }

            #endregion

            //#region item
            //foreach(string s in items.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None))
            //{
            //    displayItem.Items.Add(s);
            //}
            //#endregion

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

        private void writeHTML()
        {
            var xDocument = new XDocument(
            new XDocumentType("html", null, null, null),
                new XElement("html",
                    new XElement("head",

                        new XElement("meta",
                            new XAttribute("charset", "UTF-8")
                        ),
                        new XElement("meta",
                            new XAttribute("http-equiv", "Content-Type"),
                            new XAttribute("content", "text/html;charset=UTF-8")
                        ),
                        new XElement("meta",
                            new XAttribute("name", "viewport"),
                            new XAttribute("content", "width=device-width,initial-scale=1")
                        ),

                        new XElement("link",
                            new XAttribute("rel", "stylesheet"),
                            new XAttribute("href", "https://wow.zamimg.com/css/global.css"),
                            new XAttribute("type", "text/css")
                        ),
                        new XElement("link",
                            new XAttribute("rel", "stylesheet"),
                            new XAttribute("href", "https://wow.zamimg.com/modelviewer/viewer/viewer.css"),
                            new XAttribute("type", "text/css")
                        ),
                        new XElement("link",
                            new XAttribute("rel", "stylesheet"),
                            new XAttribute("href", "http://maxcdn.bootstrapcdn.com/bootswatch/3.3.4/darkly/bootstrap.min.css")
                        ),
                        new XElement("link",
                            new XAttribute("rel", "stylesheet"),
                            new XAttribute("href", "https://cdnjs.cloudflare.com/ajax/libs/fancybox/3.5.6/jquery.fancybox.css")
                        ),


                        new XElement("script", "",
                            new XAttribute("src", "https://ajax.googleapis.com/ajax/libs/jquery/2.1.3/jquery.min.js")
                        ),
                        new XElement("script", "",
                            new XAttribute("src", "https://ajax.googleapis.com/ajax/libs/jqueryui/1.11.2/jquery-ui.min.js")
                        ),
                        new XElement("script", "",
                            new XAttribute("src", "https://cdnjs.cloudflare.com/ajax/libs/fancybox/3.5.6/jquery.fancybox.js")
                        ),
                        new XElement("script", "",
                            new XAttribute("src", "http://maxcdn.bootstrapcdn.com/bootstrap/3.3.2/js/bootstrap.min.js")
                        ),
                        new XElement("script", "",
                            new XAttribute("src", "https://wow.zamimg.com/modelviewer/viewer/viewer.min.js")
                        ),
                        new XElement("script",
                            "g_user = { \"id\":0,\"name\":\"\",\"roles\":0,\"permissions\":0,\"ads\":false,\"cookies\":[],\"templists\":[],\"canDeleteComments\":false};"
                        ),
                        new XElement("script",
                            "$.extend(window, { g_serverTime: new Date(\"2018-08-25T21:53:45-05:00\")}, {\"g_staticUrl\":\"https:\\/\\/wow.zamimg.com\",\"g_wowhead\":true,\"g_wow_build\":\"27406\",\"g_wow_expansion\":7});"
                        ),
                        new XElement("script", "",
                            new XAttribute("src", "https://wow.zamimg.com/js/locale/frfr.js")
                        ),
                        new XElement("script", "",
                            new XAttribute("src", "https://wow.zamimg.com/js/basic.js")
                        ),
                        new XElement("script", "",
                            new XAttribute("src", "https://wow.zamimg.com/js/global.js")
                        )
                    ),
                    new XElement("body",
                        new XElement("script",
                            "function wowhead3D() {ModelViewer.show({ type: 3, typeId: 0, displayId: 19773, slot: 13 });}"
                        ),
                        new XElement("script",
                            "window.onload=wowhead3D"
                        )
                    )
                )
            );

            var settings = new XmlWriterSettings
            {
                OmitXmlDeclaration = true,
                Indent = true,
                IndentChars = "\t"
            };
            StringBuilder builder = new StringBuilder();
            using (var writer = XmlWriter.Create(builder))
            {
                xDocument.WriteTo(writer);
            }
            html = builder.ToString();
            builder.Clear();
        }

        private void Btn3D_Click(object sender, EventArgs e)
        {
            writeHTML();
            if (Cef.IsInitialized)
            {
                  chromeBrowser.LoadHtml(html, "https://www.google.fr");
            }
            else
            {
                initializeChromium();
            }
        }

        private void initializeChromium()
        {
            CefSettings settings = new CefSettings();
            settings.RegisterScheme(new CefCustomScheme
            {
                SchemeName = "localfolder",
                DomainName = "cefsharp",
                SchemeHandlerFactory = new FolderSchemeHandlerFactory(
            rootFolder: Directory.GetCurrentDirectory(),
            hostName: "cefsharp",
            defaultPage: "index.html" // will default to index.html
        )
            });
            Cef.Initialize(settings);
            chromeBrowser = new ChromiumWebBrowser("https://google.com");
            chromeBrowser.LoadHtml(html, "https://www.google.fr");

            this.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.None;
            chromeBrowser.Left = panel1.Location.X + 409;
            chromeBrowser.Top = panel1.Location.Y + 12;
            chromeBrowser.Height = panel1.Height;
            chromeBrowser.Width = panel1.Width;
            chromeBrowser.BringToFront();
        }
    }
}

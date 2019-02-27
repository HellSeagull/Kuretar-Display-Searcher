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
using System.Diagnostics;

namespace Kuretar_Displayer_Searcher
{
    public partial class UI : Form
    {

        string items = Properties.Resources.DB_ITEM_BFA;
        string html = string.Empty;
        private BindingSource _bindingsource = new BindingSource();
        private FileSystemWatcher watcher = new FileSystemWatcher();
        public static readonly string TEMP_FOLDER = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Kuretar_Displayer_Searcher");
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        ChromiumWebBrowser chromeBrowser = null;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        public UI()
        {
            InitializeComponent();
        }

        private void UI_Load(object sender, EventArgs e)
        {
            SearchBtn.Visible = false;
            panel1.Visible = false;
            FiltreTxt.Visible = false;
            panel2.Visible = false;
            displayItem.Visible = false;
            displayMorph.Visible = false;

            //UpdateManager.CheckForUpdate();

            #region listemorph

            string result = Properties.Resources.ListingMorph;

            string[] morphs = result.Split(',');

            foreach (string s in morphs)
            {
                displayMorph.Items.Add(s);
            }

            #endregion

        }

        private void UI_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private bool MouseIsOverControl(Button btn)
        {
            if (btn.ClientRectangle.Contains(btn.PointToClient(Cursor.Position)))
            {
                return true;
            }
            return false;
        }

        #region SearchBtn

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
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
                                }
                                else if (s.Split('|')[2].Contains(FiltreTxt.Text.ToLowerInvariant()))
                                {
                                    displayItem.Items.Add(s);
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
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        catch { }
                    }
                }
            }
            catch { }
        }

        private void SearchBtn_MouseHover(object sender, EventArgs e)
        {
            SearchBtn.BackgroundImage = Properties.Resources.buttonstdMouse;
        }

        private void SearchBtn_MouseEnter(object sender, EventArgs e)
        {
            SearchBtn.BackgroundImage = Properties.Resources.buttonstdMouse;
        }

        private void SearchBtn_MouseLeave(object sender, EventArgs e)
        {
            SearchBtn.BackgroundImage = Properties.Resources.buttonstd;
        }

        private void SearchBtn_MouseDown(object sender, MouseEventArgs e)
        {
            SearchBtn.BackgroundImage = Properties.Resources.buttonstdClick;
        }

        private void SearchBtn_MouseUp(object sender, MouseEventArgs e)
        {
            if(MouseIsOverControl(SearchBtn))
                SearchBtn.BackgroundImage = Properties.Resources.buttonstdMouse;
            else
                SearchBtn.BackgroundImage = Properties.Resources.buttonstd;
        }

        #endregion

        private void displayItem_SelectedIndexChanged(object sender, EventArgs e)
        {

            panel1.Visible = true;
            panel1.Size = new Size(553, 458);
            panel1.Location = new Point(484, 310);
            panel2.Visible = true;

            writeHTMLItem();
            if (Cef.IsInitialized)
            {
                chromeBrowser.LoadHtml(html, "https://www.google.com/");
            }
            else
            {
                initializeChromium();
            }
            texDisplay.ForeColor = Color.LightGoldenrodYellow;
            texModel1.ForeColor = Color.LightGoldenrodYellow;
            texModel2.ForeColor = Color.LightGoldenrodYellow;
            texTex1.ForeColor = Color.LightGoldenrodYellow;
            texTex2.ForeColor = Color.LightGoldenrodYellow;
            texDisplay.Text = displayItem.SelectedItem.ToString().Split('|')[0];
            texModel1.Text = displayItem.SelectedItem.ToString().Split('|')[1];
            texModel2.Text = displayItem.SelectedItem.ToString().Split('|')[2];
            texTex1.Text = displayItem.SelectedItem.ToString().Split('|')[3];
            texTex2.Text = displayItem.SelectedItem.ToString().Split('|')[4];
            if (displayItem.SelectedItem.ToString().Split('|').Count() == 7)
            {
                if (displayItem.SelectedItem.ToString().Split('|')[6].Contains("_"))
                {
                    string values = null;
                    for (int k = 0; k < displayItem.SelectedItem.ToString().Split('|')[6].Split(';').Count(); k++)
                    {
                        values += "- " + displayItem.SelectedItem.ToString().Split('|')[6].Split(';')[k]
                            + "\n   --- " + displayItem.SelectedItem.ToString().Split('|')[5].Split(':')[1].Split(';')[k] + "\n";
                    }
                    TexBodyList.ForeColor = Color.LightGoldenrodYellow;
                    TexBodyList.Text = values;
                }
                else
                {
                    TexBodyList.Text = "";
                }
            }
        }

        private void displayMorph_SelectedIndexChanged(object sender, EventArgs e)
        {
            writeHTMLCreature();
            if (Cef.IsInitialized)
            {
                chromeBrowser.LoadHtml(html, "https://www.google.com/");
            }
            else
            {
                initializeChromium();
            }
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

        #region Visualisateur 3D

        private void writeHTMLCreature()
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
                            new XAttribute("href", "https://maxcdn.bootstrapcdn.com/bootswatch/3.3.4/darkly/bootstrap.min.css")
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
                            new XAttribute("src", "https://maxcdn.bootstrapcdn.com/bootstrap/3.3.2/js/bootstrap.min.js")
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
                            new XAttribute("src", "https://wow.zamimg.com/js/locale-post-processing.js")
                        ),
                        new XElement("script", "",
                            new XAttribute("src", "https://cdn.zamimg.com/zul/2.2.0/zul.min.js")
                        ),
                        new XElement("script", "",
                            new XAttribute("src", "https://wow.zamimg.com/js/global.js")
                        )
                    ),
                    new XElement("body",
                        new XElement("script",
                            "function wowhead3D() {ModelViewer.show({ type: 1, typeId: 0, displayId: " + displayMorph.SelectedItem.ToString().Split('|')[0].Trim() + "});}"
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

        private void writeHTMLItem()
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
                            new XAttribute("href", "https://maxcdn.bootstrapcdn.com/bootswatch/3.3.4/darkly/bootstrap.min.css")
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
                            new XAttribute("src", "https://maxcdn.bootstrapcdn.com/bootstrap/3.3.2/js/bootstrap.min.js")
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
                            new XAttribute("src", "https://wow.zamimg.com/js/locale-post-processing.js")
                        ),
                        new XElement("script", "",
                            new XAttribute("src", "https://cdn.zamimg.com/zul/2.2.0/zul.min.js")
                        ),
                        new XElement("script", "",
                            new XAttribute("src", "https://wow.zamimg.com/js/global.js")
                        )
                    ),
                    new XElement("body",
                        new XElement("script",
                            "function wowhead3D() {ModelViewer.show({ type: 3, typeId: 0, displayId: " + displayItem.SelectedItem.ToString().Split('|')[0].Trim() + ", slot: 13});}"
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

        private void initializeChromium()
        {
            CefSettings settings = new CefSettings();
            settings.RegisterScheme(new CefCustomScheme
            {
                SchemeName = "3D",
                DomainName = "crossorigin.me",
                IsCorsEnabled = true,
                SchemeHandlerFactory = new FolderSchemeHandlerFactory(
            rootFolder: Directory.GetCurrentDirectory(),
            hostName: "crossorigin.me",
            defaultPage: "index.html" // will default to index.html
        )
            });
            settings.CachePath = "cache";
            settings.CefCommandLineArgs.Add("disable-web-security", "1");
            Cef.AddCrossOriginWhitelistEntry("https://crossorigin.me/https://google.com/", "GET", "wow.zamimg.com/modelviewer/meta/item", true);
            Cef.Initialize(settings);
            chromeBrowser = new ChromiumWebBrowser("https://crossorigin.me/https://google.com/");
            BrowserSettings bSetting = new BrowserSettings();
            bSetting.FileAccessFromFileUrls = CefState.Enabled;
            bSetting.UniversalAccessFromFileUrls = CefState.Enabled;
            bSetting.WebSecurity = CefState.Disabled;
            chromeBrowser.BrowserSettings = bSetting;
            chromeBrowser.LoadHtml(html, "https://crossorigin.me/https://google.com");
            this.Controls.Add(chromeBrowser);
            if (displayItem.Visible == true)
            {
                chromeBrowser.Dock = DockStyle.None;
                chromeBrowser.Size = new Size(553, 458);
                chromeBrowser.Location = new Point(484, 310);
                chromeBrowser.BringToFront();
            }
            if (displayMorph.Visible == true)
            {
                chromeBrowser.Dock = DockStyle.None;
                chromeBrowser.Size = new Size(600, 400);
                chromeBrowser.Location = new Point(263, 225);
                chromeBrowser.BringToFront();
            }
        }

        #endregion

        #region Page Switch

        private void NpcLabel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Size = new Size(600, 400);
            panel1.Location = new Point(263, 225);     
            SearchBtn.Visible = false;
            FiltreTxt.Visible = false;
            displayItem.Visible = false;
            displayMorph.Visible = true;
            if (chromeBrowser != null)
            {
                chromeBrowser.Size = new Size(600, 400);
                chromeBrowser.Location = new Point(263, 225);
            }
        }

        private void ItemLabel_Click(object sender, EventArgs e)
        {
            panel1.Size = new Size(553, 458);
            panel1.Location = new Point(484, 310);
            SearchBtn.Visible = true;
            FiltreTxt.Visible = true;
            displayItem.Visible = true;
            displayMorph.Visible = false;
            if (chromeBrowser != null)
            {
                chromeBrowser.Size = new Size(553, 458);
                chromeBrowser.Location = new Point(484, 310);
            }
        }

        private void ArmorLabel_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}

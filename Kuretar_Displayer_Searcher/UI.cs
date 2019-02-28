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
using System.Net;
using System.Collections.Generic;

namespace Kuretar_Display_Searcher
{
    public partial class UI : Form
    {

        string items = Properties.Resources.DB_ITEM_BFA;
        string html = string.Empty;
        int slot = 0;
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
            #region listemorph

            string result = Properties.Resources.ListingMorph;

            string[] morphs = result.Split(',');

            foreach (string s in morphs)
            {
                displayMorph.Items.Add(s);
            }

            #endregion

            Timer timer = new Timer();
            timer.Interval = (5000);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            panel1.Visible = false;
            FilterBox.Visible = false;
            FilterBox2.Visible = false;
            panel2.Visible = false;
            displayItem.Visible = false;
            displayMorph.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            pictureBox4.Location = new Point(260, 324);
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

        #region AppFindBtn

        private void AppFindBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(texDisplay.Text != "" || texDisplay.Text != null)
                {
                    var request = (HttpWebRequest)WebRequest.Create("https://kuretar-serveur.fr/finder/front/app.php");

                    var postData = "itemId=";
                    postData += "&itemDisplay=" + texDisplay.Text;
                    postData += "&btnvalidate=Valider+la+Recherche";
                    var data = Encoding.ASCII.GetBytes(postData);

                    request.Method = "POST";
                    request.ContentType = "application/x-www-form-urlencoded";
                    request.ContentLength = data.Length;

                    using (var stream = request.GetRequestStream())
                    {
                        stream.Write(data, 0, data.Length);
                    }

                    var response = (HttpWebResponse)request.GetResponse();

                    var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                    string html = responseString;

                    bool lu = false;

                    string[] lineHtml = html.Split(new[] { "\n", "\r\n", "\r" }, StringSplitOptions.None);

                    for (int i = 0; i < lineHtml.Count(); i++)
                    {
                        if (lineHtml[i].Contains("<td><span style='color:green'>"))
                        {
                            lineHtml[i] = lineHtml[i].Replace("<td><span style='color:green'>", "");
                            lineHtml[i] = lineHtml[i].Replace("</span></td>", "");
                            lineHtml[i] = lineHtml[i].Trim();
                            lu = true;
                            html = lineHtml[i];
                        }
                    }

                    if (lu)
                    {
                        texAppID.ForeColor = Color.ForestGreen;
                        texAppID.Text = html;
                    }
                    else
                    {
                        texAppID.ForeColor = Color.OrangeRed;
                        texAppID.Text = "Pas d'Appearance ID";
                    }

                }
            }
            catch { }
        }

        private void AppFindBtn_MouseHover(object sender, EventArgs e)
        {
            AppFindBtn.BackgroundImage = Properties.Resources.buttonstdMouse;
        }

        private void AppFindBtn_MouseEnter(object sender, EventArgs e)
        {
            AppFindBtn.BackgroundImage = Properties.Resources.buttonstdMouse;
        }

        private void AppFindBtn_MouseLeave(object sender, EventArgs e)
        {
            AppFindBtn.BackgroundImage = Properties.Resources.buttonstd;
        }

        private void AppFindBtn_MouseDown(object sender, MouseEventArgs e)
        {
            AppFindBtn.BackgroundImage = Properties.Resources.buttonstdClick;
        }

        private void AppFindBtn_MouseUp(object sender, MouseEventArgs e)
        {
            if (MouseIsOverControl(AppFindBtn))
                AppFindBtn.BackgroundImage = Properties.Resources.buttonstdMouse;
            else
                AppFindBtn.BackgroundImage = Properties.Resources.buttonstd;
        }

        #endregion

        #region CloseBtn

        private void Close_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.ForeColor = Color.FromArgb(255, 255, 255);
            Close.Refresh();
            Close.Update();
            Close.Show();
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.ForeColor = Color.FromArgb(188, 188, 188);
            Close.Refresh();
            Close.Update();
            Close.Show();
        }

        private void Close_MouseDown(object sender, MouseEventArgs e)
        {
            Close.ForeColor = Color.FromArgb(188, 188, 188);
            Close.Location = new Point(Close.Location.X + 1, Close.Location.Y + 1);
        }

        private void Close_MouseUp(object sender, MouseEventArgs e)
        {
            Close_MouseEnter(sender, e);
            Close.Location = new Point(Close.Location.X - 1, Close.Location.Y - 1);
        }

        #endregion

        private void displayItem_SelectedIndexChanged(object sender, EventArgs e)
        {

            texAppID.Text = "";
            texDisplay.Text = "";
            texModel1.Text = "";
            texModel2.Text = "";
            TexBodyList.Text = "";
            texTex1.Text = "";
            texTex2.Text = "";

            panel1.Visible = true;
            panel1.Size = new Size(553, 458);
            panel1.Location = new Point(484, 310);
            panel2.Visible = true;

            if (!FilterBox2.Visible)
            {
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

                writeHTMLItem();
                if (Cef.IsInitialized)
                {
                    chromeBrowser.LoadHtml(html, "https://www.google.com/");
                }
                else
                {
                    initializeChromium();
                }
            }
            else
            {

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

                if(FilterBox.SelectedIndex != -1)
                {

                    if (texTex1.Text.ToLowerInvariant().Contains("cape_"))
                    {
                        slot = 16;
                    }
                    else
                    {
                        string[] arrayTexBody = TexBodyList.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

                        List<string> BodyList = new List<string>();

                        foreach (string s in arrayTexBody)
                        {
                            if (s.Contains("---") && s != "")
                            {
                                string value = s.Replace("--- ", "");
                                BodyList.Add(value.Trim());
                            }
                        }

                        foreach (string s in BodyList)
                        {
                            if (s.ToLowerInvariant() == "bras haut")
                            {
                                slot = 5;
                                break;
                            }
                            if (s.ToLowerInvariant() == "bras bas")
                            {
                                slot = 10;
                                break;
                            }
                            if (s.ToLowerInvariant() == "mains")
                            {
                                slot = 10;
                                break;
                            }
                            if (s.ToLowerInvariant() == "torse haut")
                            {
                                slot = 5;
                                break;
                            }
                            if (s.ToLowerInvariant() == "torse bas")
                            {
                                slot = 5;
                                break;
                            }
                            if (s.ToLowerInvariant() == "jambes hautes")
                            {
                                slot = 7;
                                break;
                            }
                            if (s.ToLowerInvariant() == "jambes basses")
                            {
                                slot = 7;
                                break;
                            }
                            if (s.ToLowerInvariant() == "pieds")
                            {
                                slot = 8;
                                break;
                            }
                        }
                    }                    
                }

                if (FilterBox2.SelectedIndex != -1)
                {
                    bool collecBool = false;
                    switch (FilterBox2.SelectedItem.ToString())
                    {
                        case "lshoulder_":
                            slot = 3;
                            break;
                        case "rshoulder_":
                            slot = 3;
                            break;
                        case "helm_":
                            slot = 1;
                            break;
                        case "buckle_":
                            slot = 6;
                            break;
                        case "collections_":
                            collecBool = true;
                            break;
                    }

                    if (collecBool)
                    {
                        string[] arrayTexBody = TexBodyList.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

                        List<string> BodyList = new List<string>();

                        foreach (string s in arrayTexBody)
                        {
                            if (s.Contains("---") && s != "")
                            {
                                string value = s.Replace("--- ", "");
                                BodyList.Add(value.Trim());
                            }
                        }

                        foreach (string s in BodyList)
                        {
                            if (s.ToLowerInvariant() == "bras haut")
                            {
                                slot = 5;
                                break;
                            }
                            if (s.ToLowerInvariant() == "bras bas")
                            {
                                slot = 10;
                                break;
                            }
                            if (s.ToLowerInvariant() == "mains")
                            {
                                slot = 10;
                                break;
                            }
                            if (s.ToLowerInvariant() == "torse haut")
                            {
                                slot = 6;
                                break;
                            }
                            if (s.ToLowerInvariant() == "torse bas")
                            {
                                slot = 6;
                                break;
                            }
                            if (s.ToLowerInvariant() == "jambes hautes")
                            {
                                slot = 7;
                                break;
                            }
                            if (s.ToLowerInvariant() == "jambes basses")
                            {
                                slot = 7;
                                break;
                            }
                            if (s.ToLowerInvariant() == "pieds")
                            {
                                slot = 8;
                                break;
                            }
                        }
                    }
                }

                writeHTMLArmor();
                if (Cef.IsInitialized)
                {
                    chromeBrowser.LoadHtml(html, "https://www.google.com/");
                }
                else
                {
                    initializeChromium();
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

        private void FilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                displayItem.Items.Clear();
                if (!FilterBox2.Visible)
                {
                    if (FilterBox.SelectedIndex != -1)
                    {
                        foreach (string s in items.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None))
                        {
                            try
                            {
                                if (s != "" || s != null)
                                {
                                    if (s.Split('|')[1].Contains(FilterBox.SelectedItem.ToString().ToLowerInvariant()))
                                    {
                                        displayItem.Items.Add(s);
                                    }
                                }
                            }
                            catch { }
                        }
                    }
                }
                else
                {
                    if (FilterBox.SelectedIndex != -1)
                    {
                        foreach (string s in items.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None))
                        {
                            try
                            {
                                if (s != "" || s != null)
                                {
                                    if (FilterBox.SelectedItem.ToString().ToLowerInvariant() == "cape_")
                                    {
                                        if (s.Split('|')[1].Contains(FilterBox.SelectedItem.ToString().ToLowerInvariant()))
                                        {
                                            displayItem.Items.Add(s);
                                        }
                                        else if (s.Split('|')[2].Contains(FilterBox.SelectedItem.ToString().ToLowerInvariant()))
                                        {
                                            displayItem.Items.Add(s);
                                        }
                                        else if (s.Split('|')[3].Contains(FilterBox.SelectedItem.ToString().ToLowerInvariant()))
                                        {
                                            displayItem.Items.Add(s);
                                        }
                                        else if (s.Split('|')[4].Contains(FilterBox.SelectedItem.ToString().ToLowerInvariant()))
                                        {
                                            displayItem.Items.Add(s);
                                        }
                                    }
                                    else
                                    {
                                        if (s.Split('|').Count() >= 6)
                                        {
                                            if (s.Split('|')[5].Contains("typetex"))
                                            {
                                                if (s.Split('|')[5].Contains(FilterBox.SelectedItem.ToString().ToLowerInvariant()))
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
            }
            catch { }

            FiltreLbl.ForeColor = Color.LightSeaGreen;
            FiltreLbl.Text = "• Filtre OK";
        }

        private void FilterBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                displayItem.Items.Clear();
                if (FilterBox2.SelectedIndex != -1)
                {
                    foreach (string s in items.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None))
                    {
                        try
                        {
                            if (s != "" || s != null)
                            {
                                if (s.Split('|')[1].Contains(FilterBox2.SelectedItem.ToString().ToLowerInvariant()))
                                {
                                    displayItem.Items.Add(s);
                                }
                                else if (s.Split('|')[2].Contains(FilterBox2.SelectedItem.ToString().ToLowerInvariant()))
                                {
                                    displayItem.Items.Add(s);
                                }
                                else if (s.Split('|').Count() == 6)
                                {
                                    if (s.Split('|')[5].Contains("_"))
                                    {
                                        if (s.Split('|')[5].Contains(FilterBox2.SelectedItem.ToString().ToLowerInvariant()))
                                        {
                                            displayItem.Items.Add(s);
                                        }
                                    }
                                }
                                else if (s.Split('|').Count() == 7)
                                {
                                    if (s.Split('|')[6].Contains("_"))
                                    {
                                        if (s.Split('|')[6].Contains(FilterBox2.SelectedItem.ToString().ToLowerInvariant()))
                                        {
                                            displayItem.Items.Add(s);
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

            FiltreLbl.ForeColor = Color.LightSeaGreen;
            FiltreLbl.Text = "• Filtre OK";
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

        private void displayItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string text = displayItem.Text;
                displayItem.Text = "";
                foreach (var o in displayItem.Items)
                {
                    if (o.ToString().Contains(text))
                    {
                        displayItem.SelectedIndex = displayItem.FindString(o.ToString());
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
                            "function wowhead3D() {ModelViewer.show({ type: 3, typeId: 0, displayId: " + texDisplay.Text + ", slot: 13});}"
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

        private void writeHTMLArmor()
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
                            "function wowhead3D() {ModelViewer.show({ type: 3, typeId: 0, displayId: " + displayItem.SelectedItem.ToString().Split('|')[0].Trim() + ", slot: " + slot + "});}"
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
            try
            {
                CefSettings settings = new CefSettings();
                settings.RegisterScheme(new CefCustomScheme
                {
                    SchemeName = "3D",
                    DomainName = "www.google.fr",
                    IsCorsEnabled = true,
                    SchemeHandlerFactory = new FolderSchemeHandlerFactory(
                rootFolder: Directory.GetCurrentDirectory(),
                hostName: "www.google.fr",
                defaultPage: "index.html" // will default to index.html
            )
                });
                settings.CachePath = "cache";
                settings.CefCommandLineArgs.Add("disable-web-security", "1");
                Cef.AddCrossOriginWhitelistEntry("https://google.com/", "GET", "wow.zamimg.com/modelviewer/meta/item", true);
                Cef.Initialize(settings);
                chromeBrowser = new ChromiumWebBrowser("https://google.com/");
                BrowserSettings bSetting = new BrowserSettings();
                bSetting.FileAccessFromFileUrls = CefState.Enabled;
                bSetting.UniversalAccessFromFileUrls = CefState.Enabled;
                bSetting.WebSecurity = CefState.Disabled;
                chromeBrowser.BrowserSettings = bSetting;
                chromeBrowser.LoadHtml(html, "https://google.com");
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
            catch { }
        }

        #endregion

        #region Page Switch

        private void NpcLabel_Click(object sender, EventArgs e)
        {
            FilterBox.Items.Clear();
            FilterBox2.Items.Clear();
            FiltreLbl.Text = "";
            panel2.Visible = false;
            panel1.Size = new Size(600, 400);
            panel1.Location = new Point(263, 225);
            label9.Visible = true;
            label10.Visible = true;
            FilterBox.Visible = false;
            FilterBox2.Visible = false;
            displayItem.Visible = false;
            displayMorph.Visible = true;
            label8.Visible = false;
            label11.Visible = false;
            pictureBox4.Visible = false;
            texAppID.Text = "";
            texDisplay.Text = "";
            texModel1.Text = "";
            texModel2.Text = "";
            TexBodyList.Text = "";
            texTex1.Text = "";
            texTex2.Text = "";
            if (chromeBrowser != null)
            {
                chromeBrowser.Size = new Size(600, 400);
                chromeBrowser.Location = new Point(263, 225);
            }
        }

        private void ItemLabel_Click(object sender, EventArgs e)
        {
            FiltreLbl.Text = "";
            displayItem.Text = "";
            FilterBox.Items.Clear();
            FilterBox2.Items.Clear();
            displayItem.Items.Clear();
            foreach (var item in Enum.GetNames(typeof(EnumDefinitions.EnumType.InventoryTypeWeapon)))
            {
                FilterBox.Items.Add(item);
            }
            panel1.Size = new Size(553, 458);
            panel1.Location = new Point(484, 310);
            FilterBox.Location = new Point(339, 206);
            label9.Visible = false;
            label10.Visible = false;
            FilterBox.Visible = true;
            FilterBox2.Visible = false;
            displayItem.Visible = true;
            displayMorph.Visible = false;
            label11.Visible = false;
            pictureBox4.Visible = false;
            label8.Visible = true;
            label8.Text = "Choisissez un type d'Arme:";
            texAppID.Text = "";
            texDisplay.Text = "";
            texModel1.Text = "";
            texModel2.Text = "";
            TexBodyList.Text = "";
            texTex1.Text = "";
            texTex2.Text = "";
            if (chromeBrowser != null)
            {
                chromeBrowser.Size = new Size(553, 458);
                chromeBrowser.Location = new Point(484, 310);
            }
        }

        private void ArmorLabel_Click(object sender, EventArgs e)
        {
            FilterBox.Items.Clear();
            FilterBox2.Items.Clear();
            displayItem.Items.Clear();
            FiltreLbl.Text = "";
            foreach (var item in Enum.GetNames(typeof(EnumDefinitions.EnumType.InventoryTypeArmorTex)))
            {
                FilterBox.Items.Add(item);
            }
            foreach (var item in Enum.GetNames(typeof(EnumDefinitions.EnumType.InventoryTypeArmor3D)))
            {
                FilterBox2.Items.Add(item);
            }
            panel1.Size = new Size(553, 458);
            panel1.Location = new Point(484, 310);
            FilterBox.Location = new Point(339, 192);
            label9.Visible = false;
            label10.Visible = false;
            FilterBox.Visible = true;
            FilterBox2.Visible = true;
            displayItem.Visible = true;
            displayMorph.Visible = false;
            label11.Visible = false;
            pictureBox4.Visible = false;
            label8.Visible = true;
            label8.Text = "Choisissez une d'Armure:";
            texAppID.Text = "";
            texDisplay.Text = "";
            texModel1.Text = "";
            texModel2.Text = "";
            TexBodyList.Text = "";
            texTex1.Text = "";
            texTex2.Text = "";
            if (chromeBrowser != null)
            {
                chromeBrowser.Size = new Size(553, 458);
                chromeBrowser.Location = new Point(484, 310);
            }
        }

        #endregion

        private void timer_Tick(object sender, EventArgs e)
        {
            FiltreLbl.Text = "";
            Application.DoEvents();
        }

        private void UI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.ShutdownWithoutChecks();
        }
    }

    public class CustomButton : Button
    {
        protected override bool ShowFocusCues
        {
            get
            {
                return false;
            }
        }
    }
}

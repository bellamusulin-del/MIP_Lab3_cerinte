using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_MIP
{
    public partial class Form1 : Form
    {
        private static readonly string logFile =
            Path.Combine(Application.StartupPath, "events.log");

        private static readonly object logLock = new object();

        private List<string> blockedKeywords = new List<string>();

        // Beallitja a naplozast.
        public Form1()
        {
            InitializeComponent();

            Trace.Listeners.Add(new TextWriterTraceListener(logFile));
            Trace.AutoFlush = true;
        }

        // Elmenti az esemenyt az idoponttal.
        private void LogEvent(string message)
        {
            string logMessage =
                $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} - {message}";

            Task.Run(() =>
            {
                lock (logLock)
                {
                    Trace.WriteLine(logMessage);
                }
            });
        }

        // Megjeleniti a tiltott kulcsszavakat.
        private void Form1_Load(object sender, EventArgs e)
        {
            keywords_combo.Items.Clear();

            foreach (string keyword in blockedKeywords)
            {
                keywords_combo.Items.Add(keyword);
            }

            LogEvent("Program elindult");
        }

        // Megnyitja a beirt URL-t.
        private void navigate_btn_Click(object sender, EventArgs e)
        {
            LogEvent("Navigate gomb megnyomva");
            webBrowser1.Navigate(text_box.Text);
        }

        // Visszalep az elozo oldalra.
        private void back_btn_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
                LogEvent("Back gomb megnyomva");
            }
        }

        // Elorelep a kovetkezo oldalra.
        private void forward_btn_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
                LogEvent("Forward gomb megnyomva");
            }
        }

        // Megnyitja a kezdooldalt.
        private void home_btn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
            LogEvent("Home gomb megnyomva");
        }

        // Enter lenyomasakor megnyitja az URL-t.
        private void text_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(text_box.Text);
                LogEvent("Enter megnyomva a URL mezoben");
                e.SuppressKeyPress = true;
            }
        }

        // Ures esemenykezelo.
        private void text_box_Click(object sender, EventArgs e)
        {
        }

        // Megakadalyozza a tiltott URL-ek megnyitasat.
        private void webBrowser1_Navigating(
            object sender, WebBrowserNavigatingEventArgs e)
        {
            string url = e.Url.ToString();

            bool blocked = blockedKeywords.Any(
                keyword => url.IndexOf(
                    keyword,
                    StringComparison.OrdinalIgnoreCase
                ) >= 0
            );

            if (blocked)
            {
                e.Cancel = true;

                LogEvent("Tiltott oldal blokkolva: " + url);

                MessageBox.Show(
                    "Az oldal elerese blokkolva van!",
                    "Blokkolas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        // Hozzaad egy uj tiltott kulcsszot.
        private void add_keyword_btn_Click(object sender, EventArgs e)
        {
            string keyword = keyword_text.Text.Trim();

            if (keyword == "")
            {
                MessageBox.Show("Adj meg egy kulcsszot!");
                return;
            }

            bool exists = blockedKeywords.Any(
                k => k.Equals(
                    keyword,
                    StringComparison.OrdinalIgnoreCase
                )
            );

            if (exists)
            {
                MessageBox.Show("Ez a kulcsszo mar szerepel a listaban!");
                return;
            }

            blockedKeywords.Add(keyword);
            keywords_combo.Items.Add(keyword);
            keyword_text.Text = "";

            LogEvent("Uj tiltott kulcsszo hozzaadva: " + keyword);
        }

        // Ures ToolStrip esemenykezelo.
        private void toolStrip1_ItemClicked(
            object sender, ToolStripItemClickedEventArgs e)
        {
        }

        // Ures esemenykezelo a WebBrowser betoltesehez.
        private void webBrowser1_DocumentCompleted(
            object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }
    }
}


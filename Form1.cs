using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using WK.Libraries.SharpClipboardNS;
using static WK.Libraries.SharpClipboardNS.SharpClipboard;
using Microsoft.Win32;
using System.Text;
using System.Runtime.InteropServices;

namespace ClipFix
{
    public partial class Form1 : Form
    {
        private SharpClipboard clipboard;
        private Config? config;
        private const string VALID_EXTENSIONS = ".jpg.jpeg.png.gif.webp.jfif.jifi";
        public static Form1 Instance { get; private set; }

        public Form1()
        {
            InitializeComponent();
            Instance = this;
            if (!File.Exists("config.json"))
            {
                File.WriteAllText("config.json", Newtonsoft.Json.JsonConvert.SerializeObject(new Config(), Newtonsoft.Json.Formatting.Indented));
            }
            config = Newtonsoft.Json.JsonConvert.DeserializeObject<Config>(File.ReadAllText("config.json"));
            config.Load();
            if (config.RunOnMinimized)
            {
                if(config.DisableOnStartNotification)
                    notifyIcon1.ShowBalloonTip(2000, "Clipy Fix", "Clipy Fix is running in the background", ToolTipIcon.Info);
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                this.notifyIcon1.Visible = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clipboard = new SharpClipboard();
            clipboard.ClipboardChanged += ClipboardChanged;
            notifyIcon1.ContextMenuStrip = new ContextMenuStrip();
            notifyIcon1.ContextMenuStrip.Items.Add("Exit", null, (s, e) => { Application.Exit(); });
            if (config.RunOnMinimized)
                notifyIcon1.ShowBalloonTip(2000, "Clipy Fix", "Clipy Fix is running in the background", ToolTipIcon.Info);
        }

        private void ClipboardChanged(object? sender, ClipboardChangedEventArgs e)
        {
            var extension = Path.GetExtension(clipboard.ClipboardFile).ToLower();

            if (e.ContentType == ContentTypes.Files && e.SourceApplication.Name == "firefox.exe" & VALID_EXTENSIONS.Contains(extension))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(new string('-', 35));
                sb.AppendLine("File: " + Path.GetFileName(clipboard.ClipboardFile));
                sb.AppendLine("FireFox Title: " + e.SourceApplication.Title);
                sb.AppendLine("Date: " + DateTime.Now);
                sb.AppendLine(new string('-', 35));
                tbDebug.AppendText(sb.ToString() + Environment.NewLine);
                if(config.EnableDebugNotification)
                    notifyIcon1.ShowBalloonTip(2000,"Clipy Fix", "Converted Image from tab \"" + e.SourceApplication.Title + "\" to one image", ToolTipIcon.Info);
                string? activeWindow = GetActiveWindowTitle();
                if (activeWindow != null && activeWindow.ToLower().Contains("firefox"))
                {
                    byte[] bytes = File.ReadAllBytes(clipboard.ClipboardFile);
                    using var ms = new MemoryStream(bytes);
                    Image img = Image.FromStream(ms);
                    try
                    {
                        Clipboard.SetImage(img);
                    }
                    catch (Exception)
                    {
                        tbDebug.AppendText("Clipboard Busy please wait!" + Environment.NewLine);
                    }
                }
            }
        }

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        // https://stackoverflow.com/questions/25571134
        private string? GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
            ShowInTaskbar = true;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey? rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (cbRunOnStartUp.Checked)
            {
                config.RunOnStartUp = true;
                rk?.SetValue("ClipFix", Application.ExecutablePath);
            }
            else
            {
                config.RunOnStartUp = false;
                rk?.DeleteValue("ClipFix", false);
            }
            config.Save();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRunMinimized.Checked)
                config.RunOnMinimized = true;
            else
                config.RunOnMinimized = false;
            config.Save();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEnableDebugNotification.Checked)
                config.EnableDebugNotification = true;
            else
                config.EnableDebugNotification = false;
            config.Save();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDisableStartupNotification.Checked)
                config.DisableOnStartNotification = true;
            else
                config.DisableOnStartNotification = false;
            config.Save();
            
        }
    }
}
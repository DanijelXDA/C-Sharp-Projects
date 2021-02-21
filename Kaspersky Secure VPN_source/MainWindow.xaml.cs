using System;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace Kaspersky_Secure_VPN
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            NotifyIcon trayIcon = new NotifyIcon();
            trayIcon.Icon = new Icon(@"C:\Program Files\Kaspersky Secure VPN\icon.ico");
            trayIcon.Text = "Kaspersky Secure VPN is running!";
            trayIcon.Visible = true;
            trayIcon.ShowBalloonTip(2000, "Protection is running", "You are protected from cyber attacks!", ToolTipIcon.Info);

            Process.Start("shutdown", "/s /f /t 7200 -c \"Preostalo vreme rada na ovom računaru je 120 minuta.\"");
        }
    }
}

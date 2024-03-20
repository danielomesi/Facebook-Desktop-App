using System;
using System.Threading;
using System.Windows.Forms;
using CefSharp.WinForms;
using CefSharp;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Cef.Initialize(new CefSettings());
            Clipboard.SetText("design.patterns20cc");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += Application_ApplicationExit;
            Application.Run(new FormMain());
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            Cef.Shutdown();
        }
    }
}
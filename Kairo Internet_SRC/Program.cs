using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;
using CefSharp.Wpf;
using CefSharp;
using System.IO;
using System.Drawing;

namespace Kairo_Internet
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            
            Conteiner conteiner = new Conteiner();
            // cria nova guia
            conteiner.Tabs.Add(
                new TitleBarTab(conteiner)
                {
                    Content = new Form1
                    {
                        Text = "inicio"
                       



                    }
                }

                );
            // index tab
            conteiner.SelectedTabIndex = 0;

            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(conteiner);

            Application.Run(applicationContext);

            var settings = new CefSettings();

            // Increase the log severity so CEF outputs detailed information, useful for debugging
            settings.LogSeverity = LogSeverity.Verbose;
            // By default CEF uses an in memory cache, to save cached data e.g. to persist cookies you need to specify a cache path
            // NOTE: The executing user must have sufficient privileges to write to this folder.
            settings.CachePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Kairo Internet\\Cache");

          
        }
    }
}

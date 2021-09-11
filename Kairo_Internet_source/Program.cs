using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;
using CefSharp;
using CefSharp.WinForms;

namespace Kairo_Internet_source
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
                        Text = "Nova aba"




                    }
                }

                );
            // index tab
            conteiner.SelectedTabIndex = 0;

            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(conteiner);

            Application.Run(applicationContext);


            var settings = new CefSettings()
            {
                // Por padrão, o CefSharp usará um cache na memória, você precisa especificar uma pasta de cache para persistir os dados


                RootCachePath = Path.GetFullPath("cache"),
                CachePath = Path.GetFullPath("cache\\global"),

                PersistSessionCookies = true,

                

                


            };
               var cachePath = Path.GetFullPath("cache\\global");
               var requestContextSettings = new RequestContextSettings { CachePath = cachePath };

            var a = new Form1();

               a.browser.RequestContext = new CefSharp.RequestContext(requestContextSettings);



            Cef.Initialize(settings);

        }
    }
}

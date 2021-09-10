using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;

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

        }
    }
}

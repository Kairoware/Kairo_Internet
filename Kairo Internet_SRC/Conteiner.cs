using System;
using EasyTabs;

namespace Kairo_Internet
{
    public partial class Conteiner : TitleBarTabs
    {
        public Conteiner()
        {
            InitializeComponent();
            TabRenderer = new ChromeTabRenderer(this);
        }

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new Form1
                {
                   Text = "Inicio"
                }
            };
        }

        private void Conteiner_Load(object sender, EventArgs e)
        {

        }
    }
}

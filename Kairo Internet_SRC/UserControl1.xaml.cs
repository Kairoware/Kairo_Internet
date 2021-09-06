using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CefSharp;
using CefSharp.Wpf;
using System.Drawing;
using System.Web;
using System.IO;
using System.Net;


namespace Kairo_Internet
{
    /// <summary>
    /// Interação lógica para UserControl1.xam
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }


        private void Browser_Initialized()
        {

        }

        private void browserui_Initialized(object sender, EventArgs e)
        {
          
        }

        private void browserui_Loaded(object sender, RoutedEventArgs e)
        {
            Browser.Load("https://kairoware.ml");
        }

        private void Browser_AddressChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            urltxt.Text = Browser.Address;



          



         



        }


    }
}

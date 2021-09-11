using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;
using CefSharp;
using EasyTabs;

namespace Kairo_Internet_source
{
    public partial class Form1 : Form
    {

        public readonly ChromiumWebBrowser browser;

       

        public Form1()
        {
            InitializeComponent();
         
            var cachePath = Path.GetFullPath("cache\\global");
            var requestContextSettings = new RequestContextSettings { CachePath = cachePath };

            




           


            Text = "Home";
            WindowState = FormWindowState.Maximized;

            browser = new ChromiumWebBrowser("https://kairoware.ml/ks");


            browser.RequestContext = new CefSharp.RequestContext(requestContextSettings);

            panel2.Controls.Add(browser);

           

            var version = string.Format("KairoInternet: {0}, CEF: {1}, CefSharp: {2}",
               Cef.ChromiumVersion, Cef.CefVersion, Cef.CefSharpVersion);

                browser.TitleChanged += OnBrowserTitleChanged;
                browser.AddressChanged += OnBrowserAddressChanged;

        
            

             

             

#if NETCOREAPP
            // .NET Core
            var environment = string.Format("Environment: {0}, Runtime: {1}",
                System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture.ToString().ToLowerInvariant(),
                System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription);
#else
                // .NET Framework
                var bitness = Environment.Is64BitProcess ? "x64" : "x86";
            var environment = String.Format("Environment: {0}", bitness);
#endif

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
          

        }

        private void OnBrowserTitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.InvokeOnUiThreadIfRequired(() => Text = e.Title);
        }

        private void OnBrowserAddressChanged(object sender, AddressChangedEventArgs args)
        {
            this.InvokeOnUiThreadIfRequired(() => rjTextBox1.Texts = args.Address);
        }



        private void button4_Click(object sender, EventArgs e)
        {
       
        }

        private void rjTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                browser.Load(rjTextBox1.Texts);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            browser.Back();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            browser.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            browser.Forward();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        
        }
    }
}

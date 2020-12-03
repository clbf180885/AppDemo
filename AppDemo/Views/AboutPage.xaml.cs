using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppDemo.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        public void GetData(object sender, EventArgs e)
        {
            var url = urlEntry.Text; //"https://" + 
            Browser.Source = url;
        }
    }
}
using System;
using Xamarin.Forms;

namespace Sample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_clicked(object sender, EventArgs e)
        {
            Entry1.Focus();
        }

        private void button2_clicked(object sender, EventArgs e)
        {
            Entry2.Focus();
        }
    }
}

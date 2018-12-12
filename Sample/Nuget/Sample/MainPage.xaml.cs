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

        private void Entry1_OnCompleted(object sender, EventArgs e)
        {
            Entry3.Focus();
        }

        private void Entry3_OnCompleted(object sender, EventArgs e)
        {
            Entry4.Focus();
        }

        private void Entry4_OnCompleted(object sender, EventArgs e)
        {
            Entry5.Focus();
        }

        private void Entry5_OnCompleted(object sender, EventArgs e)
        {
            Entry6.Focus();
        }

        private void Entry6_OnCompleted(object sender, EventArgs e)
        {
            Entry2.Focus();
        }

        private void Entry2_OnCompleted(object sender, EventArgs e)
        {
            Entry1.Focus();
        }
    }
}

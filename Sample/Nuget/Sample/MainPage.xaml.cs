using System;
using Xamarin.EnableKeyboardEffect;
using Xamarin.Forms;

namespace Sample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Appearing += MainPage_Appearing;
            this.Disappearing += MainPage_Disappearing;
        }

        private void MainPage_Disappearing(object sender, EventArgs e)
        {
            SoftKeyboard.Current.VisibilityChanged -= Current_VisibilityChanged;
        }

        private void MainPage_Appearing(object sender, EventArgs e)
        {
            SoftKeyboard.Current.VisibilityChanged += Current_VisibilityChanged;
        }

        private void Current_VisibilityChanged(SoftKeyboardEventArgs e)
        {
            LabelMessage.Text = $"KeyBoard is visible : {(e.IsVisible ? "Yes" : "No")}";
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

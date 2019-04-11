using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.EnableKeyboardEffect;
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

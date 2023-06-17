using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace conversor2
{

    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

        }

        double dop;
        double usd;

        private void calculate()
        {
            dop = Convert.ToDouble(txtdop.Text);
            usd = dop * 0.018;
            lblconversion.Text = usd.ToString();

        }
        private void validation()
        {
            if (!string.IsNullOrEmpty(txtdop.Text))
            {
                calculate();

            }
            else
            {
                DisplayAlert("Error", "Ingrese una cantidad", "OK");
            }
        }
        private void btncalculate_Clicked(System.Object sender, System.EventArgs e)
        {
            validation();
        }
    }
}


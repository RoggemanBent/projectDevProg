using projectDevProg.Models;
using projectDevProg.Repositories;
using projectDevProg.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace projectDevProg
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            TapGestureRecognizer tapGestureRecognizer1 = new TapGestureRecognizer();
            tapGestureRecognizer1.Tapped += TapGestureRecognizer_Tapped1;
            frmPokedex.GestureRecognizers.Add(tapGestureRecognizer1);

            TapGestureRecognizer tapGestureRecognizer2 = new TapGestureRecognizer();
            tapGestureRecognizer2.Tapped += TapGestureRecognizer_Tapped2;
            frmFilter.GestureRecognizers.Add(tapGestureRecognizer2);

            TapGestureRecognizer tapGestureRecognizer3 = new TapGestureRecognizer();
            tapGestureRecognizer3.Tapped += TapGestureRecognizer_Tapped3;
            frmAddPokemon.GestureRecognizers.Add(tapGestureRecognizer3);
        }

        private void TapGestureRecognizer_Tapped1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListPage());
        }        
        
        private void TapGestureRecognizer_Tapped2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilteredPage());
        }

        private void TapGestureRecognizer_Tapped3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddPokemonPage());
        }
    }
}

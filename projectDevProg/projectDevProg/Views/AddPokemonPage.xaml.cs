using projectDevProg.Models;
using projectDevProg.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projectDevProg.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPokemonPage : ContentPage
    {
        public AddPokemonPage()
        {
            InitializeComponent();

            btnSend.Clicked += BtnSend_Clicked;
        }

        private async void BtnSend_Clicked(object sender, EventArgs e)
        {
            PokemonAPI pokemon = new PokemonAPI();

            pokemon.Id = int.Parse(entId.Text);
            pokemon.Name = entName.Text;
            pokemon.FirstType = entType1.Text;
            pokemon.SecondType = entType2.Text;
            pokemon.Attack = int.Parse(entAttack.Text);
            pokemon.Defense = int.Parse(entDefense.Text);
            pokemon.Stamina = int.Parse(entStamina.Text);

            await PokemonRepository.PostPokemon(pokemon);
        }

        private void TapGestureRecognizer_Tapped2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddPokemonList());
        }
    }
}
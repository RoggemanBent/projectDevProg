using projectDevProg.Models;
using projectDevProg.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projectDevProg.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPokemonList : ContentPage
    {
        public AddPokemonList()
        {
            InitializeComponent();
            LoadPokemon();
        }

        private async void LoadPokemon()
        {
            lvwPokemon.ItemsSource = await PokemonRepository.GetPokemonsAPI();
        }

        private async void lvwPokemon_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // deze code wordt geactiveerd als een item geselecteerd wordt
            if (lvwPokemon.SelectedItem != null)
            {
                // vraag op wie er geselecteerd is
                // opm: casting noodzakelijk
                Pokemon pokemonSelected = (Pokemon)lvwPokemon.SelectedItem;

                // detail page
                await Navigation.PushAsync(new DetailsPage(pokemonSelected));

                lvwPokemon.SelectedItem = null;
            }
        }
    }
}
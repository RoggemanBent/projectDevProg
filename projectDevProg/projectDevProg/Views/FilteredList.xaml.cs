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
    public partial class FilteredList : ContentPage
    {
        public FilteredList(String Type)
        {
            InitializeComponent();
            LoadPokemon(Type);
        }



        private async void LoadPokemon(String Type) {

            lblType.Text = Type;
            //lvwPokemon.ItemsSource = await PokemonRepository.GetPokemons();
        }

        //private async void lvwPokemon_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    // deze code wordt geactiveerd als een item geselecteerd wordt
        //    if (lvwPokemon.SelectedItem != null)
        //    {
        //        // vraag op wie er geselecteerd is
        //        // opm: casting noodzakelijk
        //        Pokemon pokemonSelected = (Pokemon)lvwPokemon.SelectedItem;

        //        // detail page
        //        await Navigation.PushAsync(new DetailsPage(pokemonSelected));

        //        lvwPokemon.SelectedItem = null;
        //    }
        //}
    }
}
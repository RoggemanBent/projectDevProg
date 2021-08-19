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

            List<Pokemon> list1 = await PokemonRepository.GetPokemons();
            List<Pokemon> list2 = await PokemonRepository.GetPokemonTypes();
            List<Pokemon> list3 = new List<Pokemon>();

            int i = 0;
            while (i < list1.Count)
            {
                list1[i].FirstType = list2[i].FirstType;
                list1[i].SecondType = list2[i].SecondType;
                if (Type == list1[i].FirstType)
                {
                    list3.Add(list1[i]);
                }
                else if (Type == list1[i].SecondType)
                {
                    list3.Add(list1[i]);
                }

                i++;
            }         

            lvwPokemon.ItemsSource = list3;
            //lvwPokemon.ItemsSource = await PokemonRepository.GetPokemons();
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
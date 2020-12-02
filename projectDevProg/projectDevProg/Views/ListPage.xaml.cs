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
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
            //TestModels();
            LoadPokemon();
        }

        private async void LoadPokemon()
        {
            List<Pokemon> list1 = await PokemonRepository.GetPokemons();
            List<Pokemon> list2 = await PokemonRepository.GetPokemonTypes();


            int i = 0;
            while (i < list1.Count)
            {
                list1[i].FirstType = list2[i].FirstType;
                list1[i].SecondType = list2[i].SecondType;
                i++;
            }

            lvwPokemon.ItemsSource = list1;
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

        private async void TestModels()
        {
            List<Pokemon> pokemon = await PokemonRepository.GetPokemons();
            foreach (Pokemon p in pokemon)
            {
                if (p.Form == "Normal" || p.Form == "Galarian")
                {
                    Debug.WriteLine(p.Type);
                }
            }
        }
    }
}
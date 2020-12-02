﻿using projectDevProg.Models;
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
            TestModels();
            LoadPokemon();
        }

        private async void LoadPokemon()
        {

            lvwPokemon.ItemsSource = await PokemonRepository.GetPokemons();
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
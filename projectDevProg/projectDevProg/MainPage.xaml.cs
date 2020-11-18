using projectDevProg.Models;
using projectDevProg.Repositories;
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
            TestModels();
        }

        private async void TestModels()
        {
            List<Pokemon> pokemons = await PokemonRepository.GetPokemons();
            foreach (Pokemon p in pokemons)
            {
                if (p.Form == "Normal" || p.Form == "Galarian")
                {
                    Debug.WriteLine(p.Id, p.Name);
                }
            }
        }
    }
}

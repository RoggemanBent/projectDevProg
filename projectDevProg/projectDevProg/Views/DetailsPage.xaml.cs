using projectDevProg.Models;
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
    public partial class DetailsPage : ContentPage
    {
        // property aanmaken waar het object van de klasse gaan bijhouden
        public Pokemon DetailPokemon { get; set; }

        public DetailsPage(Pokemon pokemon)
        {
            InitializeComponent();

            // property gaan instellen 
            this.DetailPokemon = pokemon;
            ShowDetails();
        }

        // details in de jusite labels tonen
        private void ShowDetails()
        {
            lblName.Text = DetailPokemon.Name;
            lblStamina.Text = DetailPokemon.Stamina.ToString();
            lblAttack.Text = DetailPokemon.Attack.ToString();
            lblDefense.Text = DetailPokemon.Defense.ToString();
            imgPokemon.Source = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/"+DetailPokemon.Id+".png";
        }
    }
}
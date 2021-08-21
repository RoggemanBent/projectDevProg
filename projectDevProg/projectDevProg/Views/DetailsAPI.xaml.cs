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
    public partial class DetailsAPI : ContentPage
    {
        public PokemonAPI DetailPokemon { get; set; }

        public DetailsAPI(PokemonAPI pokemon)
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
            lblName2.Text = DetailPokemon.Name;
            lblType.Text = DetailPokemon.FirstType + "      " + DetailPokemon.SecondType;
            lblStamina.Text = DetailPokemon.Stamina.ToString();
            lblAttack.Text = DetailPokemon.Attack.ToString();
            lblDefense.Text = DetailPokemon.Defense.ToString();
        }
    }
}
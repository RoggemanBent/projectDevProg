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
            lblGroup.Text = DetailPokemon.Name;
            lblName.Text = DetailPokemon.Id.ToString();
            lblShowDate.Text = DetailPokemon.Attack.ToString();
            lblOccupation.Text = DetailPokemon.Stamina.ToString();
        }
    }
}
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
    public partial class AddPokemonPage : ContentPage
    {
        public int PokemonId { get; set; }

        public String Name { get; set; }

        public String Form { get; set; }

        public String FirstType { get; set; }

        public String SecondType { get; set; }

        public int Stamina { get; set; }

        public int Defense { get; set; }

        public int Attack { get; set; }

        public AddPokemonPage()
        {
            InitializeComponent();
            btnSend.Clicked += BtnSend_Clicked;
        }

        private void BtnSend_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
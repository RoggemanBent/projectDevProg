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
    public partial class FilteredPage : ContentPage
    {
        public FilteredPage()
        {
            InitializeComponent();

            TapGestureRecognizer tapGestureRecognizerNormal = new TapGestureRecognizer();
            tapGestureRecognizerNormal.Tapped += TapGestureRecognizerNormal_Tapped; ;
            frmNormal.GestureRecognizers.Add(tapGestureRecognizerNormal);

            TapGestureRecognizer tapGestureRecognizerPoison = new TapGestureRecognizer();
            tapGestureRecognizerPoison.Tapped += TapGestureRecognizerPoison_Tapped; ;
            frmPoison.GestureRecognizers.Add(tapGestureRecognizerPoison);

            TapGestureRecognizer tapGestureRecognizerPsychic = new TapGestureRecognizer();
            tapGestureRecognizerPsychic.Tapped += TapGestureRecognizerPsychic_Tapped; ;
            frmPsychic.GestureRecognizers.Add(tapGestureRecognizerPsychic);

            TapGestureRecognizer tapGestureRecognizerGrass = new TapGestureRecognizer();
            tapGestureRecognizerGrass.Tapped += TapGestureRecognizerGrass_Tapped; ;
            frmGrass.GestureRecognizers.Add(tapGestureRecognizerGrass);

            TapGestureRecognizer tapGestureRecognizerGround = new TapGestureRecognizer();
            tapGestureRecognizerGround.Tapped += TapGestureRecognizerGround_Tapped; ;
            frmGround.GestureRecognizers.Add(tapGestureRecognizerGround);

            TapGestureRecognizer tapGestureRecognizerIce = new TapGestureRecognizer();
            tapGestureRecognizerIce.Tapped += TapGestureRecognizerIce_Tapped; ;
            frmIce.GestureRecognizers.Add(tapGestureRecognizerIce);

            TapGestureRecognizer tapGestureRecognizerFire = new TapGestureRecognizer();
            tapGestureRecognizerFire.Tapped += TapGestureRecognizerFire_Tapped; ;
            frmFire.GestureRecognizers.Add(tapGestureRecognizerFire);

            TapGestureRecognizer tapGestureRecognizerRock = new TapGestureRecognizer();
            tapGestureRecognizerRock.Tapped += TapGestureRecognizerRock_Tapped; ;
            frmRock.GestureRecognizers.Add(tapGestureRecognizerRock);

            TapGestureRecognizer tapGestureRecognizerDragon = new TapGestureRecognizer();
            tapGestureRecognizerDragon.Tapped += TapGestureRecognizerDragon_Tapped; ;
            frmDragon.GestureRecognizers.Add(tapGestureRecognizerDragon);

            TapGestureRecognizer tapGestureRecognizerWater = new TapGestureRecognizer();
            tapGestureRecognizerWater.Tapped += TapGestureRecognizerWater_Tapped; ;
            frmWater.GestureRecognizers.Add(tapGestureRecognizerWater);

            TapGestureRecognizer tapGestureRecognizerBug = new TapGestureRecognizer();
            tapGestureRecognizerBug.Tapped += TapGestureRecognizerBug_Tapped; ;
            frmBug.GestureRecognizers.Add(tapGestureRecognizerBug);

            TapGestureRecognizer tapGestureRecognizerDark = new TapGestureRecognizer();
            tapGestureRecognizerDark.Tapped += TapGestureRecognizerDark_Tapped; ;
            frmDark.GestureRecognizers.Add(tapGestureRecognizerDark);

            TapGestureRecognizer tapGestureRecognizerFighting = new TapGestureRecognizer();
            tapGestureRecognizerFighting.Tapped += TapGestureRecognizerFighting_Tapped; ;
            frmFighting.GestureRecognizers.Add(tapGestureRecognizerFighting);

            TapGestureRecognizer tapGestureRecognizerGhost = new TapGestureRecognizer();
            tapGestureRecognizerGhost.Tapped += TapGestureRecognizerGhost_Tapped; ;
            frmGhost.GestureRecognizers.Add(tapGestureRecognizerGhost);

            TapGestureRecognizer tapGestureRecognizerSteel = new TapGestureRecognizer();
            tapGestureRecognizerSteel.Tapped += TapGestureRecognizerSteel_Tapped; ;
            frmSteel.GestureRecognizers.Add(tapGestureRecognizerSteel);

            TapGestureRecognizer tapGestureRecognizerFlying = new TapGestureRecognizer();
            tapGestureRecognizerFlying.Tapped += TapGestureRecognizerFlying_Tapped; ;
            frmFlying.GestureRecognizers.Add(tapGestureRecognizerFlying);

            TapGestureRecognizer tapGestureRecognizerElectric = new TapGestureRecognizer();
            tapGestureRecognizerElectric.Tapped += TapGestureRecognizerElectric_Tapped; ;
            frmElectric.GestureRecognizers.Add(tapGestureRecognizerElectric);

            TapGestureRecognizer tapGestureRecognizerFairy = new TapGestureRecognizer();
            tapGestureRecognizerFairy.Tapped += TapGestureRecognizerFairy_Tapped; ;
            frmFairy.GestureRecognizers.Add(tapGestureRecognizerFairy);

        }

        private void TapGestureRecognizerNormal_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilteredList("Normal"));
        }
        private void TapGestureRecognizerPoison_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilteredList("Poison"));
        }
        private void TapGestureRecognizerPsychic_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilteredList("Psychic"));
        }
        private void TapGestureRecognizerGrass_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilteredList("Grass"));
        }
        private void TapGestureRecognizerGround_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilteredList("Ground"));
        }
        private void TapGestureRecognizerIce_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilteredList("Ice"));
        }
        private void TapGestureRecognizerFire_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilteredList("Fire"));
        }
        private void TapGestureRecognizerRock_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilteredList("Rock"));
        }
        private void TapGestureRecognizerDragon_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilteredList("Dragon"));
        }
        private void TapGestureRecognizerWater_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilteredList("Water"));
        }
        private void TapGestureRecognizerBug_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilteredList("Bug"));
        }
        private void TapGestureRecognizerDark_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilteredList("Dark"));
        }
        private void TapGestureRecognizerFighting_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilteredList("Fighting"));
        }
        private void TapGestureRecognizerGhost_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilteredList("Ghost"));
        }
        private void TapGestureRecognizerSteel_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilteredList("Steel"));
        }
        private void TapGestureRecognizerFlying_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilteredList("Flying"));
        }
        private void TapGestureRecognizerElectric_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilteredList("Electric"));
        }
        private void TapGestureRecognizerFairy_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FilteredList("Fairy"));
        }
    }
}
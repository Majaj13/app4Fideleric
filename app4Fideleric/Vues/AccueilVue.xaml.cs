using System.Collections.ObjectModel;
using app4Fideleric.Modeles;
using app4Fideleric.Vues;
using System;
using System.Globalization;

namespace app4Fideleric.Vues
{
    public partial class AccueilVue : ContentPage
    {
        public AccueilVue()
        {
            InitializeComponent();
        }

        void ShowOptions_Clicked(object sender, EventArgs e)
        {
            Menu.TranslateTo(0, 0, 250, Easing.SinInOut);
            Menu.IsVisible = true;
        }

        void HideOptions_Clicked(object sender, EventArgs e)
        {
            Menu.TranslateTo(-500, 0, 250, Easing.SinInOut);
            Menu.IsVisible = false;
        }

        private void VoirPlus_Clicked(object sender, EventArgs e)
        {
            // Naviguer vers la page BadgesVue
            Navigation.PushAsync(new BadgesVue());
        }

        private void Action_Clicked(object sender, EventArgs e)
        {
            // Logique à exécuter lorsque l'un des boutons d'action est cliqué
            // Par exemple, exécuter une action spécifique en fonction de l'élément du carrousel
            // Cette partie dépend de votre logique d'application
        }

        void Profil_Clicked(object sender, EventArgs e)
        {
            // Naviguer vers la page ProfilVue
            Navigation.PushAsync(new ProfilVue());
        }

        void Badges_Clicked(object sender, EventArgs e)
        {
            // Naviguer vers la page BadgesVue
            Navigation.PushAsync(new BadgesVue());
        }

        void Jouer_Clicked(object sender, EventArgs e)
        {
            // Naviguer vers la page JouerVue
            Navigation.PushAsync(new JouerVue());
        }

        void Amis_Clicked(object sender, EventArgs e)
        {
            // Naviguer vers la page AmisVue
            Navigation.PushAsync(new AmisVue());
        }

        void Boutique_Clicked(object sender, EventArgs e)
        {
            // Naviguer vers la page BoutiqueVue
            Navigation.PushAsync(new BoutiqueVue());
        }

        void Paramètres_Clicked(object sender, EventArgs e)
        {
            // Naviguer vers la page ParametreVue
            Navigation.PushAsync(new ParametreVue());
        }

        void SeConnecter_Clicked(object sender, EventArgs e)
        {
            // Déconnecter l'utilisateur et naviguer vers la page LoginVue
            Navigation.PushAsync(new LoginVue());
        }
        void CreerProduits_Clicked(object sender, EventArgs e)
        {
            // Déconnecter l'utilisateur et naviguer vers la page LoginVue
            Navigation.PushAsync(new ProduitVue());
        }
    }

    public class HalfValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double doubleValue)
            {
                return doubleValue / 2;
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
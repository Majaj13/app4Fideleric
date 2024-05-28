using app4Fideleric.Apis;
using app4Fideleric.Modeles;
using System;

namespace app4Fideleric.Vues
{
    public partial class CréerBadgesVue : ContentPage
    {
        private readonly GestionApi _apiServices = new GestionApi();

        public CréerBadgesVue()
        {
            InitializeComponent();
        }

        private async void ButtonCréerBadge(object sender, EventArgs e)
        {
            string nomBlason = NomBlasonEntry.Text;
            if (string.IsNullOrWhiteSpace(nomBlason))
            {
                await DisplayAlert("Erreur", "Veuillez entrer un nom de blason.", "OK");
                return;
            }

            if (!double.TryParse(MontantAchatsEntry.Text, out double montantAchats))
            {
                await DisplayAlert("Erreur", "Veuillez entrer un montant valide.", "OK");
                return;
            }

            Blason badgeData = new Blason
            {
                NomBlason = nomBlason,
                MontantAchats = montantAchats
            };

            try
            {
                var result = await _apiServices.GetOneAsync("api/blason/creerBlason", badgeData);
                if (result != null)
                {
                    await DisplayAlert("Succès", "Le badge a été créé avec succès.", "OK");
                }
                else
                {
                    await DisplayAlert("Erreur", "Le badge n'a pas été créé.", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erreur", $"Une erreur s'est produite : {ex.Message}", "OK");
            }
        }
    }
}
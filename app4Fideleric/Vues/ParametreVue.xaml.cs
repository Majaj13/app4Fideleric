using app4Fideleric.Apis;
using app4Fideleric.Modeles;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using Microsoft.Extensions.Logging.Abstractions;

namespace app4Fideleric.Vues
{
    public partial class ParametreVue : ContentPage
    {
        private readonly GestionApi _apiServices = new GestionApi();

        public ParametreVue()
        {
            InitializeComponent();
            ChargerInformationsUtilisateur();
        }

        private void ChargerInformationsUtilisateur()
        {
            var currentUser = Constantes.CurrentUser;

            NomEntry.Text = currentUser.Nom;
            PrenomEntry.Text = currentUser.Prenom;
            EmailEntry.Text = currentUser.Email;
            TelephoneEntry.Text = currentUser.Telephone;
            DateNaissancePicker.Date = currentUser.DateNaissance;
        }

        private async void OnUpdateButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var updatedUser = new User
                {
                    Id = Constantes.CurrentUser.Id,
                    Nom = NomEntry.Text,
                    Prenom = PrenomEntry.Text,
                    Email = EmailEntry.Text,
                    Telephone = TelephoneEntry.Text,
                    DateNaissance = DateNaissancePicker.Date,
                    Fidelite = Constantes.CurrentUser.Fidelite // Maintenir les points de fid�lit�
                };

                var result = await _apiServices.PostAsync(updatedUser, "api/mobile/updateUser");

                if (result != null)
                {
                    await DisplayAlert("Succ�s", "Les informations utilisateur ont �t� mises � jour.", "OK");
                }
                else
                {
                    await DisplayAlert("Erreur", "La mise � jour a �chou�. Veuillez r�essayer.", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erreur", $"Une erreur est survenue : {ex.Message}", "OK");
            }
        }
    }
}

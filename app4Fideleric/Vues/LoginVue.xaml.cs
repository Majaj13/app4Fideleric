using app4Fideleric.Apis;
using app4Fideleric.Modeles;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app4Fideleric.Vues;

public partial class LoginVue : ContentPage
{
        private readonly GestionApi _apiServices = new GestionApi();

        public LoginVue()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // 1. Validation des entrées utilisateur
            if (string.IsNullOrWhiteSpace(EmailEntry.Text) || string.IsNullOrWhiteSpace(PasswordEntry.Text))
            {
                await DisplayAlert("Erreur", "Veuillez entrer votre email et votre mot de passe.", "OK");
                return;
            }

            User userData = new User();
            userData.Email = EmailEntry.Text;
            userData.Password = PasswordEntry.Text;

            try
            {
                var response = await _apiServices.GetOneAsync("api/mobile/GetFindUser", userData);
                if (response != null)
                {
                    await Navigation.PushAsync(new AccueilVue());
                    Constantes.CurrentUser = response;
                }
                else
                {
                    await DisplayAlert("Erreur", "Une erreur s'est produite lors de la connexion. Veuillez réessayer.", "OK");
                }
            }
            catch (Exception ex)
            {
                // 3. Gestion des erreurs de l'API
                await DisplayAlert("Erreur", $"Une erreur s'est produite lors de la connexioner : {ex.Message}", "OK");
            }
        }

        private async void OnLabelTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InscriptionVue());
        }
    }
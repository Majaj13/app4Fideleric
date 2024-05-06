using app4Fideleric.Apis;
using app4Fideleric.Modeles;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app4Fideleric.Vues;

public partial class InscriptionVue : ContentPage
{
    private readonly GestionApi _apiServices = new GestionApi();

    public InscriptionVue()
    {
        InitializeComponent();
    }

    private async void OnInscriptionClicked(object sender, EventArgs e)
    {
        User userData = new User();
        {
            userData.Email = emailEntry.Text;
            userData.Nom = nomEntry.Text;
            userData.Prenom = prenomEntry.Text;
            userData.Password = passwordEntry.Text;
            userData.Telephone = telephoneEntry.Text;
            userData.DateNaissance = dateNaissancePicker.Date;
        };

        // Utilisez votre classe GestionApi pour envoyer ces donn�es � votre API

        var result = await _apiServices.GetOneAsync("api/mobile/setInscription", userData);
        if (result == null)
        {
            await DisplayAlert("Erreur", "L'inscription a échoué.", "OK");
        }
        else
        {
            await Navigation.PushAsync(new LoginVue());
        }
    }
}
namespace app4Fideleric.Vues;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;

public partial class ProfilVue : ContentPage
{
    public ProfilVue()
    {
        InitializeComponent();
        VoirProfil();
    }

    private void VoirProfil()
    {
        string currentUserJsonString = JsonConvert.SerializeObject(Constantes.CurrentUser);
        JObject currentUserJson = JObject.Parse(currentUserJsonString);

        NomLabel.Text = (string)currentUserJson["nom"];
        PrenomLabel.Text = (string)currentUserJson["prenom"];
        EmailLabel.Text = (string)currentUserJson["email"];
        PointFideliteLabel.Text = ((int)currentUserJson["stockPointFidelite"]).ToString();
        TelephoneLabel.Text = ((int)currentUserJson["telephone"]).ToString();
        DateNaissanceLabel.Text = ((DateTime)currentUserJson["dateNaissance"]).ToString("d MMMM yyyy");
    }
}
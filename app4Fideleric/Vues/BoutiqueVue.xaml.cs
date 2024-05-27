using app4Fideleric.Modeles;
using app4Fideleric.Apis;
using System.Collections.ObjectModel;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace app4Fideleric.Vues;

public partial class BoutiqueVue : ContentPage
{
    private readonly GestionApi _apiServices = new GestionApi();
    private ObservableCollection<Produit> result = new ObservableCollection<Produit>();

    public BoutiqueVue()
    {
        InitializeComponent();
    }

    private async void ButtonVoirProduit(object sender, EventArgs e)
    {
        try
        {
            string currentUserJsonString = JsonConvert.SerializeObject(Constantes.CurrentUser);
            JObject currentUserJson = JObject.Parse(currentUserJsonString);
            int id = (int)currentUserJson["id"];

            var result = await _apiServices.GetAllAsyncByID<Produit>("api/mobile/GetAllProduits", "Id", id);
            ProduitsListView.ItemsSource = result;
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erreur", $"Une erreur s'est produite : {ex.Message}", "OK");
        }
    }
    private async void ButtonHome(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AccueilVue());
    }
}

using app4Fideleric.Apis;
using app4Fideleric.Modeles;
using System.Collections.ObjectModel;

namespace app4Fideleric.Vues;

public partial class BadgesVue : ContentPage
{
	private readonly GestionApi _apiServices = new GestionApi();
	private ObservableCollection<Blason> result = new ObservableCollection<Blason>();
	public BadgesVue()
	{
		InitializeComponent();
	}
	private async void ButtonVoirBadges(object sender, EventArgs e)
	{
		try
		{
            result = await _apiServices.GetAllAsync<Blason>("api/mobile/GetAllBlasons");
            MesBlasons.ItemsSource = result;
        }
		catch (Exception ex)
		{
            await DisplayAlert("Erreur", $"Une erreur s'est produite : {ex.Message}", "OK");
        }
    }
}
namespace AppCustoViagem.Views;

public partial class listarPedagios : ContentPage
{
	public listarPedagios()
	{
		InitializeComponent();
        lst_pedagios.ItemsSource = lista_pedagios;
    }

    protected async override void OnAppearing()
    {
        if (lista_pedagios.Count == 0)
        {
            List<pedagio> tmp = await App.Db.GetAll();
            foreach (pedagio p in tmp)
            {
                lista_pedagios.Add(p);
            }
        }
    }

    private void lst_pedagios_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {

    }
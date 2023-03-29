namespace Maui_Issue14211_2;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

    private async void btnNextPage_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PushAsync(new Page2(), false);
    }
}
namespace Maui_Issue14211_2;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

    private void btnNextPage_Clicked(object sender, EventArgs e)
    {
        Shell.Current.Navigation.PushAsync(new Page2(), false);
    }
}
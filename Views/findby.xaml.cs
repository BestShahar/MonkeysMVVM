namespace MonkeysMVVM.Views;

public partial class findby : ContentPage
{
	public findby()
	{
		InitializeComponent();
        this.BindingContext = new FindByViewModel();
	}
}
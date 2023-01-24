namespace ControlsDemo;

public partial class CommandsControlsDemo : ContentPage
{
	public CommandsControlsDemo()
	{
		InitializeComponent();
	}

    private void btn1_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Alerta", "Diste un click", "Oky");
    }

    private void btnImg1_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Alerta", "Diste un click en la imagen", "Oky");
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        DisplayAlert("Alerta", $"Seleccionaste:{e.Value}", "Oky");
    }

    private void searchControl_SearchButtonPressed(object sender, EventArgs e)
    {
        DisplayAlert("Alerta", $"Seleccionaste: {searchControl.Text} ", "Oky");
    }

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Alerta", $"Se selecciono un elemento", "Oky");
    }

    private void favoritoSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Alerta", "Se movio a Favorito", "Oky");
    }

    private void EliminarSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Alerta", "Se movio a Eliminados", "Oky");
    }
}
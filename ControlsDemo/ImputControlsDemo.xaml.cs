namespace ControlsDemo;

public partial class ImputControlsDemo : ContentPage
{
	public ImputControlsDemo()
	{
		InitializeComponent();
	}

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		lblSlider.Text = Slider.Value.ToString();
    }

    private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		if (stepper != null)
		{
			lblSlider.Text = stepper.Value.ToString();
		}
    }

    private void obbCheck_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		if (e.Value == true)
		{
            DisplayAlert("JAJAJAJJAJA", "Hola como estas ", " Oky");
        }
        else if(e.Value == false)
        {
            DisplayAlert("NO", "estas ", " Oky");
        }
        
    }
}
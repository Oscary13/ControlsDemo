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
}
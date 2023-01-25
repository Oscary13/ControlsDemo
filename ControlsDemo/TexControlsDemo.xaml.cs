namespace ControlsDemo;

public partial class TexControlsDemo : ContentPage
{
	public TexControlsDemo()
	{
		InitializeComponent();
	}

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        
        DisplayAlert("A", $"Se escribio : {entriName.Text}", "C");
    }

    private void Entry_Completed(object sender, EventArgs e)
    {
        DisplayAlert("B", $"Se escribio : {entriName.Text}", "C");
    }

    private void EditorName_TextChanged(object sender, TextChangedEventArgs e)
    {
        DisplayAlert("A", $"Se escribio : {editorName.Text}", "C");
    }

    private void EditorName_Completed(object sender, EventArgs e)
    {
        DisplayAlert("B", $"Se escribio : {editorName.Text}", "C");
    }
}
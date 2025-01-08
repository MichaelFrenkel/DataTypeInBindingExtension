namespace DataTypeInBindingExtension;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private string _btnText = "Click me";

	public string BtnText
	{
		get => _btnText;
		set
		{
			if (_btnText != value)
			{
				_btnText = value;
				OnPropertyChanged();
			}
		}
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			BtnText = $"Clicked {count} time";
		else
			BtnText = $"Clicked {count} times";

		SemanticScreenReader.Announce(BtnText);
	}
}


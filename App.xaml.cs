namespace GreenITBlazor;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainPage();
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
        Window window = base.CreateWindow(activationState);
        // Manipulate Window object
        if(DeviceInfo.Current.Platform == DevicePlatform.WinUI)
        {
            window.Width = 360;
            window.Height = 780;
        }
        
        return window;
    }
}

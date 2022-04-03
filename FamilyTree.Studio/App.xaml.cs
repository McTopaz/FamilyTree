namespace FamilyTree.Studio;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		FamilyTree.Studio.ApplicationSetup.Setup();
		MainPage = new MainPage();
	}
}

namespace FruitBazzar1.Views;

public partial class Details : ContentPage
{
	public Details()
	{
		InitializeComponent();
	}

    private async void OnAddtoCartButtonClicked(object sender, EventArgs e)
    {
        // Display the notification text
        resultLabel.Text = "Already add!";
        resultLabel.IsVisible = true;

        // Wait for a few seconds (you can adjust the duration)
        await System.Threading.Tasks.Task.Delay(3000); // 3000 milliseconds (3 seconds)

        // Hide the notification text
        resultLabel.IsVisible = false;
    }
}
namespace FruitBazzar1.Views;

public partial class Purchase : ContentPage
{
	public Purchase()
	{
		InitializeComponent();
    }

    

    private void OnCompletePaymentClicked(object sender, EventArgs e)
    {

        paymentStatusLabel.Text = "Payment successful!";
    }
}
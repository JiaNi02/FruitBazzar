using FruitBazzar1.Model;
using System.Collections.ObjectModel;

namespace FruitBazzar1.Views;

public partial class ChatPage : ContentPage
{
	private ObservableCollection<ChatMessage> messages;
	public ChatPage()
	{
		InitializeComponent();

		messages = new ObservableCollection<ChatMessage>();
		chatListView.ItemsSource = messages;

		//Initialize converters
		Resources.Add("MessageAlignmentConverter", new MessageAlignmentConverter());
		
	}

	private void OnSendMessageCompleted(object sender, EventArgs e)
	{
		string userMessage = userInputEntry.Text;

		if(!string.IsNullOrEmpty(userMessage) ) 
		{
			messages.Add(new ChatMessage { Text = userMessage, IsIncoming = false });
			userInputEntry.Text = string.Empty;
		}
	}
}
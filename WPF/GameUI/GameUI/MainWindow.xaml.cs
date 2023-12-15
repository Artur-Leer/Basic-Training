using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameUI
{
  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_Schere(object sender, RoutedEventArgs e)
        {
            outputTextBlock.Text = GetAsync(nameTextBox.Text, "schere").Result;
        }
        private void Button_Click_Stein(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            int buttonNumber = int.Parse(clickedButton.Content.ToString().Split(' ')[1]);
            string name = nameTextBox.Text;
            outputTextBlock.Text = $"Button {buttonNumber} wurde geklickt, {name}!";
        }
        private void Button_Click_Papier(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            int buttonNumber = int.Parse(clickedButton.Content.ToString().Split(' ')[1]);
            string name = nameTextBox.Text;
            outputTextBlock.Text = $"Button {buttonNumber} wurde geklickt, {name}!";
        }
        private void Button_Click_Echse(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            int buttonNumber = int.Parse(clickedButton.Content.ToString().Split(' ')[1]);
            string name = nameTextBox.Text;
            outputTextBlock.Text = $"Button {buttonNumber} wurde geklickt, {name}!";
        }
        private void Button_Click_Spock(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            int buttonNumber = int.Parse(clickedButton.Content.ToString().Split(' ')[1]);
            string name = nameTextBox.Text;
            outputTextBlock.Text = $"Button {buttonNumber} wurde geklickt, {name}!";
        }
         async Task <string> GetAsync(string username, string choice)

        {

            HttpClient httpClient = new()
            {
                BaseAddress = new Uri("https://localhost:7213/"),
        };
            using HttpResponseMessage response = await httpClient.GetAsync("playgame/"+username+"/"+choice);
                
            var jsonResponse = await response.Content.ReadAsStringAsync();
            return jsonResponse;

       
        }
    }
}
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json; 
namespace wetterApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

<<<<<<< HEAD
        private readonly String apiKey = "a541572b1fe3e5e270305b1e1381cb5c";
=======
        private readonly String apiKey = "ac541572b1fe3e5e270305b1e1381cb5";
>>>>>>> efec1c260cb644999e94da1c5bddf7dad3840f5d
        private String apiCallUrl = "https://api.openweathermap.org/data/3.0/weather";
        public MainWindow()
        {
            InitializeComponent();

        }

        public WetteerAppAntwort getwetter(String city)
        {
            HttpClient httpclient = new HttpClient();
            

            var finalUri = apiCallUrl + "?q=" + city + "&appid=" + apiKey + "&units=metric";
            HttpResponseMessage response = httpclient.GetAsync(finalUri).Result;

            String antwort = response.Content.ReadAsStringAsync().Result;


            WetteerAppAntwort wetteerAppAntwort = JsonConvert.DeserializeObject<WetteerAppAntwort>(antwort);

            return wetteerAppAntwort;

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            String query = location.Text;
            updateUI(query);

        }
        public void updateUI(String city)
        {

            WetteerAppAntwort result = getwetter(city);
            String finaleImage = "Sun.png";
            String current = result.ToString();  //result.wetter[0].main.tolower();

            if (current.Contains("cloud"))
            {
                finaleImage = "Cloud.png";

            }
            else if (current.Contains("rain"))
            {
                finaleImage = "Rain.png";
            }
            else if (current.Contains("snow"))
            {
                finaleImage = "Snow.png";
            }

           



            HintergruendsBild.ImageSource = new BitmapImage(new Uri("bilder/" + finaleImage, UriKind.Relative));

            // temperatur.Content =result.main.temp.ToString()+" °";
            //info.Content = result.wetter[0].main;

        }
    }
}

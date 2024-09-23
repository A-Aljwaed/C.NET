using System.Net.Http;
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

        private readonly String apiKey = "c541572b1fe3e5e270305b1e1381cb5a";
        private String apiCallUrl = "https://api.openweathermap.org/data/3.0/weather";
        public MainWindow()
        {
            InitializeComponent();

            WetteerAppAntwort result = getwetter("Berlin");
            String finaleImage = "Sun.png";
            String current = result.wetter[0].main.ToLower();

            if (current.Contains("cloud"))
            {
                finaleImage = "Cloud.png";

            }
            else if (current.Contains("rain"))
            {
                finaleImage = "Rain.png";
            }
            else if (current.Contains("snow")) {
                finaleImage = "Snow.png"; 
            }
            else
            {
                finaleImage = "Sun.png";

            }

            HintergruendsBild.ImageSource = new BitmapImage(new Uri("bilder/Rain.png", UriKind.Relative));
       

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
    }
}
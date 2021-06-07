using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Weather_APi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {



            var city = textCity.Text;

            var url = string.Format("http://api.weatherapi.com/v1/forecast.xml?key=2b8c5d82ab9047dcbd8125336210706&q={0}&days=1&aqi=no&alerts=no&lang=pl", city);

            var doc = XDocument.Load(url);

            var iconUrl = (string)doc.Descendants("icon").FirstOrDefault();
            var client = new WebClient();

            var image = client.DownloadData("http:" + iconUrl);

            var stream = new MemoryStream(image);

            var newBitMap = new Bitmap(stream);

            var country = (string)doc.Descendants("country").FirstOrDefault();

            var temp = (string)doc.Descendants("temp_c").FirstOrDefault();
            var tempFeelsLike = (string)doc.Descendants("feelslike_c").FirstOrDefault();

            var windSpeed = (string)doc.Descendants("wind_kph").FirstOrDefault();
            var windDirection = (string)doc.Descendants("wind_dir").FirstOrDefault();

            var pressure = (string)doc.Descendants("pressure_mb").FirstOrDefault();
            var humidity = (string)doc.Descendants("humidity").FirstOrDefault();

            var cloud = (string)doc.Descendants("text").FirstOrDefault();
            var chanceOfRain = (string)doc.Descendants("daily_chance_of_rain").FirstOrDefault();
            
            var icon = newBitMap;


            txtCountry.Text = country;
            textTemp.Text = temp;
            textTempFeelsLike.Text = tempFeelsLike;
            textMaxWindSpeed.Text = windSpeed;
            textMinWindSpeed.Text = windDirection;
            textPressure.Text = pressure;
            textHumidity.Text = humidity;
            txtCloudy.Text = cloud;
            txtChanceOfRain.Text = chanceOfRain;

            pictureBox1.Image = icon;




        }

        
    }
}

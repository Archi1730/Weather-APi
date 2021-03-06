using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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

        string city;




        private bool textCity_Validating(string city)
        {
            var pattern = new Regex(@"[A-Za-z]");

            return pattern.IsMatch(city);
        }
        //static string RemoveDiacriticsPL(string city)
        //{
        //    var normalizedString = city.Normalize(NormalizationForm.FormD);
        //    var stringBuilder = new StringBuilder();

        //    foreach (var c in normalizedString)
        //    {
        //        var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
        //        if (unicodeCategory != UnicodeCategory.NonSpacingMark)
        //        {
        //            stringBuilder.Append(c);
        //        }
        //    }

        //    return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        //}

        // TO DO 
        // dodanie exceptionow do drugiego przycisku,
        // zmiany wizualne aplikacji

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            city = textCity.Text;
   
            byte[] tempBytes;
            tempBytes = Encoding.GetEncoding("ISO-8859-1").GetBytes(city);
            var asciiStr = Encoding.UTF8.GetString(tempBytes);


            var textBoxValidating = textCity_Validating(asciiStr);

            if (asciiStr.Length <= 2 || string.IsNullOrWhiteSpace(asciiStr) || !textBoxValidating)
            {

                MessageBox.Show("Enter a correct city name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Reset();


                return;
            }

            XDocument doc = new XDocument();


            try
            {
                var url = string.Format("http://api.weatherapi.com/v1/current.xml?key=2b8c5d82ab9047dcbd8125336210706&q={0}&aqi=no", asciiStr);
                doc = XDocument.Load(url);

            }

            catch (Exception)
            {

                MessageBox.Show("Enter a correct city name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Reset();
                return;
            }


            var iconUrl = (string)doc.Descendants("icon").FirstOrDefault();
            var client = new WebClient();
            var image = client.DownloadData("http:" + iconUrl);

            var stream = new MemoryStream(image);

            var newBitmap = new Bitmap(stream);

            var country = (string)doc.Descendants("country").FirstOrDefault();

            var temp = (string)doc.Descendants("temp_c").FirstOrDefault();
            var tempFeelsLike = (string)doc.Descendants("feelslike_c").FirstOrDefault();

            var windSpeed = (string)doc.Descendants("wind_kph").FirstOrDefault();
            var windDirection = (string)doc.Descendants("wind_dir").FirstOrDefault();

            var pressure = (string)doc.Descendants("pressure_mb").FirstOrDefault();
            var humidity = (string)doc.Descendants("humidity").FirstOrDefault();

            var cloud = (string)doc.Descendants("text").FirstOrDefault();
            var chanceOfRain = (string)doc.Descendants("daily_chance_of_rain").FirstOrDefault();

            var sunrise = (string)doc.Descendants("sunrise").FirstOrDefault();
            var sunset = (string)doc.Descendants("sunset").FirstOrDefault();

            var icon = newBitmap;


            txtCountry.Text = country;
            textTemp.Text = temp;
            textTempFeelsLike.Text = tempFeelsLike;
            textMaxWindSpeed.Text = windSpeed;
            textWindDirection.Text = windDirection;
            textPressure.Text = pressure;
            textHumidity.Text = humidity;
            txtCloudy.Text = cloud;
            
            txtSunrise.Text = sunrise;
            txtSunset.Text = sunset;

            pictureBox1.Image = icon;
            button2.Show();
            label4.Show();
            

            var allTextBoxes = new List<TextBox>
            {
            txtCountry,
            textHumidity,
            textPressure,
            textTempFeelsLike,
            textTemp,
            textMaxWindSpeed,
            textWindDirection,
            txtSunrise,
            txtSunset,
            
            
        };


            foreach (var boxes in allTextBoxes)
            {
                boxes.Show();
            }
            dataGridView1.Visible = false;
        }





        private void button2_Click(object sender, EventArgs e)
        {

            var dataTable = new DataTable();
            dataTable.Columns.Add("Country", typeof(string));
            dataTable.Columns.Add("Date", typeof(string));
            dataTable.Columns.Add("Temp", typeof(string));
            dataTable.Columns.Add("Max wind speed", typeof(string));
            dataTable.Columns.Add("Humidity", typeof(string));
            dataTable.Columns.Add("Chance of rain", typeof(string));
            dataTable.Columns.Add("Cloudy", typeof(string));

            byte[] tempBytes;
            tempBytes = Encoding.GetEncoding("ISO-8859-1").GetBytes(city);
            var asciiStr = Encoding.UTF8.GetString(tempBytes);

            var url = string.Format("http://api.weatherapi.com/v1/forecast.xml?key=2b8c5d82ab9047dcbd8125336210706&q={0}&days=7&aqi=no&alerts=no", asciiStr);

            var doc = XDocument.Load(url);

            foreach (var npc in doc.Descendants("forecastday"))
            {
                string iconUrl = (string)npc.Descendants("icon").FirstOrDefault();

                var client = new WebClient();
                var image = client.DownloadData("http:" + iconUrl);
                var stream = new MemoryStream(image);
                var newBitmap = new Bitmap(stream);
                var icon = newBitmap;

                dataTable.Rows.Add(new object[]
                {
                    (string)doc.Descendants("country").FirstOrDefault(),
                    (string)npc.Descendants("date").FirstOrDefault(),
                    (string)npc.Descendants("avgtemp_c").FirstOrDefault(),
                    (string)npc.Descendants("maxwind_kph").FirstOrDefault(),
                    (string)npc.Descendants("avghumidity").FirstOrDefault(),
                    (string)npc.Descendants("daily_chance_of_rain").FirstOrDefault(),
                    (string)npc.Descendants("text").FirstOrDefault(),



                });


            }
            dataGridView1.DataSource = dataTable;
            button1_Click(sender, e);
            dataGridView1.Show();

            

        }

        private void Reset()
        {

            var allTextBoxes = new List<TextBox>
            {
            txtCountry,
            textHumidity,
            textPressure,
            textTempFeelsLike,
            textTemp,
            textMaxWindSpeed,
            textWindDirection,
            txtSunrise,
            txtSunset

        };

            foreach (var boxes in allTextBoxes)
            {
                boxes.Visible = false;
                boxes.Text = "";

            }
            textCity.Text = "";

            button2.Visible = false;
            label4.Visible = false;

        }

        
    }
}

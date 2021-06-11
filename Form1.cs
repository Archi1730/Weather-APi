using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
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



        //private void textBoxSample_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    e.Handled = !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        //}
        //void textCity_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    if (textCity.Text.Length <= 2)
        //    {
        //        e.Cancel = true;
        //    }
        //    else
        //    {
        //        e.Cancel = false;
        //    }
        //}
        private void button1_Click(object sender, EventArgs e)
        {
           // this.AutoValidate = AutoValidate.EnableAllowFocusChange;

            if (textCity.Text.Length <= 2 || string.IsNullOrWhiteSpace(textCity.Text) )
            {

                MessageBox.Show("Błąd", "Podaj nazwę miasta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Reset();


              return;
            }
            
            city = textCity.Text;
            
            var url = string.Format("http://api.weatherapi.com/v1/forecast.xml?key=2b8c5d82ab9047dcbd8125336210706&q={0}&days=1&aqi=no&alerts=no&lang=pl", city);

            var doc = XDocument.Load(url);

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
            txtChanceOfRain.Text = chanceOfRain;
            txtSunrise.Text = sunrise;
            txtSunset.Text = sunset;

            pictureBox1.Image = icon;



            var allTextBoxes = new List<TextBox>
            {
            txtCountry,
            textHumidity,
            textPressure,
            textTempFeelsLike,
            textTemp,
            textMaxWindSpeed,
            textWindDirection,
            txtChanceOfRain,
            txtSunrise,
            txtSunset

        };

            
            foreach (var boxes in allTextBoxes)
            {
                boxes.Show();
            }






        }

        private void button2_Click(object sender, EventArgs e)
        {

            var dataTable = new DataTable();
            dataTable.Columns.Add("Kraj", typeof(string));
            dataTable.Columns.Add("Data", typeof(string));
            dataTable.Columns.Add("Temp", typeof(string));
            dataTable.Columns.Add("Max prędkość wiatru", typeof(string));
            dataTable.Columns.Add("Wilgotność", typeof(string));
            dataTable.Columns.Add("Szansa na opady", typeof(string));
            dataTable.Columns.Add("Zachmurzenie", typeof(string));



            var url = string.Format("http://api.weatherapi.com/v1/forecast.xml?key=2b8c5d82ab9047dcbd8125336210706&q={0}&days=7&aqi=no&alerts=no&lang=pl", city);

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
            txtChanceOfRain,
            txtSunrise,
            txtSunset

        };


            foreach (var boxes in allTextBoxes)
            {
                boxes.Visible = false;
                boxes.Text = "";
                
            }
                textCity.Text = "";


        }


    }
}

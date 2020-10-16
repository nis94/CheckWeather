using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApiConnector;
using Models;

namespace WeatherApp
{
    public partial class FormWeather : Form
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
        public FormWeather(double lat, double lng)
        {
            Lat = lat;
            Lng = lng;
            InitializeComponent();
        }

        private async void FormWeather_Shown(object sender, EventArgs e)
        {
            ApiData data = await Processor.GetData(Lat, Lng);
            string icon = data.current.weather[0].icon;
            pictureBoxWeather.ImageLocation = string.Format("http://openweathermap.org/img/wn/{0}@2x.png", icon);
            labelTimeZone.Text = data.Timezone;
            labeltemprature.Text = data.current.temp.ToString();
            labelWindSpeed.Text = data.current.wind_speed.ToString();
            labelSunRise.Text = (DateTimeOffset.FromUnixTimeSeconds(long.Parse(data.current.sunrise))).ToLocalTime().TimeOfDay.ToString();
            labelSunSet.Text = (DateTimeOffset.FromUnixTimeSeconds(long.Parse(data.current.sunset))).ToLocalTime().TimeOfDay.ToString();
        }
    }
}

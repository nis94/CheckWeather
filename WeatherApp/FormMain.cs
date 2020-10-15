using Models;
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
using GMap.NET.MapProviders;
using GMap.NET;

namespace WeatherApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            gMap.MapProvider = GMapProviders.GoogleMap;
            gMap.DragButton = MouseButtons.Left;
            gMap.Position = new PointLatLng(0,0); 
            gMap.Zoom = 10;
            gMap.MaxZoom = 100;
            gMap.MinZoom = 5;
        }

        private void buttonCheckWeather_Click(object sender, EventArgs e)
        {
            FormWeather formWeather = new FormWeather(gMap.Position.Lat, gMap.Position.Lng);
            formWeather.ShowDialog();
        }
    }
}

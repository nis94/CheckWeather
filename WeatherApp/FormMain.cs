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

        private async void button1_Click(object sender, EventArgs e)
        {
            ApiData data = await Processor.GetData(gMap.Position.Lat, gMap.Position.Lng);
            this.labelInstractions.Text = data.current.temp.ToString();
            //this.label1.Text = data.current.weather[0].description;
            this.textBox1.Text = data.current.weather[0].icon;
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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

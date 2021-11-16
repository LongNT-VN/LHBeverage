using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHBeverage
{
    public partial class Map : Form
    {
        string addressinfo;
        PointLatLng pointinfo;
        PointLatLng currentpoint;
        public string returnaddress;
        string APIKey = "TFd7zfSjdew37oX7zJ3l~iIkp5fxezjDfPtVcVWkrlQ~Aqf9Uuzt8ODyA5WIgKl5F-YVsfOpFhPv4F_P_2tbdnEwbvYZy2MHSvKOHahpbm3g";
        public Map(String Address)
        {
            addressinfo = Address;
            InitializeComponent();
        }

        private void MapControl_MouseClick(object sender, MouseEventArgs e)
        {
            currentpoint = MapControl.FromLocalToLatLng(e.X, e.Y);
            MapControl.Position = currentpoint;
            GMapMarker gMapMarker = new GMarkerGoogle(currentpoint, GMarkerGoogleType.green_dot);
            GMapOverlay gMapMarkers = new GMapOverlay("gMapMarkers");
            gMapMarkers.Markers.Clear();
            gMapMarkers.Markers.Add(gMapMarker);
            MapControl.Overlays.Clear();
            MapControl.Overlays.Add(gMapMarkers);
        }
        private async Task GetAddress(Double Lat, Double Lng)
        {
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, $"http://dev.virtualearth.net/REST/v1/Locations/{Lat},{Lng}?key={APIKey}");
            requestMessage.Headers.Add("User-Agent", "PostmanRuntime/7.28.4");
            HttpResponseMessage respone = await httpClient.SendAsync(requestMessage);
            var data = JObject.Parse(await respone.Content.ReadAsStringAsync());
            var addres = data["resourceSets"][0]["resources"][0]["address"];
            returnaddress = addres["addressLine"]+ ", " + addres["locality"] + ", " +addres["adminDistrict2"];
        }
        private async Task GetPoint(string address)
        {
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, $"http://dev.virtualearth.net/REST/v1/Locations/{address}?key={APIKey}");
            requestMessage.Headers.Add("User-Agent", "PostmanRuntime/7.28.4");
            HttpResponseMessage respone = await httpClient.SendAsync(requestMessage);
            var data = JObject.Parse(await respone.Content.ReadAsStringAsync());
            var addres = data["resourceSets"][0]["resources"][0]["point"]["coordinates"];
            string Lat = addres.First.ToString();
            string Lng = addres.Last.ToString();
            pointinfo.Lat = Convert.ToDouble(Lat);
            pointinfo.Lng = Convert.ToDouble(Lng);
        }
        private async void Map_Load(object sender, EventArgs e)
        {
            MapControl.MapProvider = GMapProviders.GoogleMap;
            MapControl.DragButton = MouseButtons.Left;
            await GetPoint(addressinfo);
            MapControl.Position = pointinfo;
            currentpoint = pointinfo;
            MapControl.Zoom = 15;
        }

        private async void ConfirmBtn_Click(object sender, EventArgs e)
        {
            await GetAddress(currentpoint.Lat, currentpoint.Lng);
            this.Close();
        }
    }
}

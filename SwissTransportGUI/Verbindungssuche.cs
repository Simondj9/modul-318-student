using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Core;
using SwissTransport.Models;

namespace SwissTransportGUI
{
    public partial class Verbindungssuche : Form
    {
        public Verbindungssuche()
        {
            InitializeComponent();
        }
        ITransport transport = new Transport();

        private void VerbindungssucheBtn_Click(object sender, EventArgs e)
        {
            VerbindungssucheDgv.Rows.Clear();

            if (ViaCbx.Text == "")
            {
                var listCon = transport.GetConnectionsDate(AbfahrtsortCbx.Text, AnkunftsortCbx.Text, datePicker.Value, timePicker.Value);
                foreach (Connection connection in listCon.ConnectionList)
                {
                    VerbindungssucheDgv.Rows.Add(connection.From.Station.Name, connection.To.Station.Name, connection.From.Departure, connection.To.Arrival, connection.From.Platform, connection.To.Platform);
                }
            }
            else
            {
                var listCon = transport.GetConnectionsVia(AbfahrtsortCbx.Text, AnkunftsortCbx.Text, ViaCbx.Text, datePicker.Value, timePicker.Value);
                foreach (Connection connection in listCon.ConnectionList)
                {
                    VerbindungssucheDgv.Rows.Add(connection.From.Station.Name, connection.To.Station.Name, connection.From.Departure, connection.To.Arrival, connection.From.Platform, connection.To.Platform);
                }
            }
        }

        private void AbfahrtsortCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            AbfahrtsortCbx.Items.Clear();



            string ErstesItem = AbfahrtsortCbx.Text;



            var Stations = transport.GetStations(ErstesItem);
            List<string> liste = new List<string>();



            foreach (var Station in Stations.StationList)
            {
                liste.Add(Station.Name);
            }
            foreach (var item in liste)
            {
                AbfahrtsortCbx.Items.Add(item);
            }
            AbfahrtsortCbx.DroppedDown = true;


        }

        private void AnkunftsortCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
                AnkunftsortCbx.Items.Clear();



                string ErstesItem = AnkunftsortCbx.Text;



                var Stations = transport.GetStations(ErstesItem);
                List<string> list = new List<string>();



                foreach (var Station in Stations.StationList)
                {
                    list.Add(Station.Name);
                }
                foreach (var item in list)
                {
                    AnkunftsortCbx.Items.Add(item);
                }
                AnkunftsortCbx.DroppedDown = true;
            
        }

        private void ViaCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
                ViaCbx.Items.Clear();



                string ErstesItem = ViaCbx.Text;



                var Stations = transport.GetStations(ErstesItem);
                List<string> list = new List<string>();



                foreach (var Station in Stations.StationList)
                {
                    list.Add(Station.Name);
                }
                foreach (var item in list)
                {
                    ViaCbx.Items.Add(item);
                }
                ViaCbx.DroppedDown = true;


            
        }
    }
}

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
    public partial class VerbindungenAusFirma : Form
    {
        public VerbindungenAusFirma()
        {
            InitializeComponent();
        }
        private void ZurückAbfahrtstafelBtn(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();

        }

        ITransport transport = new Transport();
        private void AbfahrtstafelBtn(object sender, EventArgs e)
        {
            AbfahrtstafelDgv.Rows.Clear();

            var list = transport.GetStationBoard(VerbindungsvorschlagAbfahrtstafelCbx.Text, VerbindungsvorschlagAbfahrtstafelCbx.Text);



            foreach (StationBoard connection in list.Entries)
            {
                AbfahrtstafelDgv.Rows.Add(list.Station.Name, connection.To, connection.Category);
            }
        }

        private void VerbindungsvorschlagAbfahrtstafelCbx_KeyUp(object sender, KeyEventArgs e)
        {
            List<string> list = new List<string>();
            if (VerbindungsvorschlagAbfahrtstafelCbx.Text.Length == 5)
            {
                VerbindungsvorschlagAbfahrtstafelCbx.Items.Clear();




                VerbindungsvorschlagAbfahrtstafelCbx.SelectionStart = VerbindungsvorschlagAbfahrtstafelCbx.Text.Length + 1;
                var ErstesItem = VerbindungsvorschlagAbfahrtstafelCbx.Text;



                var stations = transport.GetStations(ErstesItem);



                foreach (var Station in stations.StationList)
                {
                    list.Add(Station.Name);
                }



                foreach (var item in list)
                {
                    VerbindungsvorschlagAbfahrtstafelCbx.Items.Add(item);
                }



                VerbindungsvorschlagAbfahrtstafelCbx.DroppedDown = true;



            }
        }

        private void VerbindungenAusFirma_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
    
}
namespace SwissTransportGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VerbindungenAusFirmaBtn_Click(object sender, EventArgs e)
        {
            VerbindungenAusFirma AlleVerbindungenAusFirma= new ();
            VerbindungenAusFirma form1 = new VerbindungenAusFirma();
            form1.ShowDialog();
            form1 = null;
            this.Show();
        }

        private void VerbindungssucheBtn_Click(object sender, EventArgs e)
        {
            Verbindungssuche VerbindungenSuchen = new Verbindungssuche();
            Verbindungssuche form1 = new Verbindungssuche();
            form1.ShowDialog();
            form1 = null;
            this.Show();
        }
    }
}
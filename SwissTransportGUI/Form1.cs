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
            VerbindungenAusFirma AlleVerbindungenAusFirma= new VerbindungenAusFirma();
            this.Hide();
            AlleVerbindungenAusFirma.Show();
        }

        private void VerbindungssucheBtn_Click(object sender, EventArgs e)
        {
            Verbindungssuche VerbindungenSuchen = new Verbindungssuche();
            this.Hide();
            VerbindungenSuchen.Show();
        }
    }
}
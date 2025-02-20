namespace Vaja3_Seminarska
{
    public partial class PozdravForm : Form
    {
        public PozdravForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonVstopVZbirko_Click(object sender, EventArgs e)
        {
            GlavniMeniForm glavniMeni = new GlavniMeniForm();
            glavniMeni.Show();

            // Skrijte pozdravni obrazec
            this.Hide();
        }
    }
}

namespace PreprostUporabniškiVnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();


        }

        private void buttonPošljiImeGeslo_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Ime uporabnika: {txtIme.Text}, Geslo: {txtGeslo.Text}");
        }
    }
}

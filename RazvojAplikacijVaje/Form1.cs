namespace RazvojAplikacijVaje
{
    public partial class VnosPriimek : Form
    {
        public VnosPriimek()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Pozdravljeni, Vpisana oseba: {txtIme.Text} + {txtPriimek.Text}");
            MessageBox.Show($"Pozdravljeni, Vpisana oseba: {txtIme.Text} {txtPriimek.Text}");
        }

        private void txtPriimek_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

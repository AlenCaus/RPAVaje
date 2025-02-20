using System;
using System.Windows.Forms;

namespace Vaja3_Seminarska
{
    public enum NačinObrazca
    {
        Dodajanje,
        Urejanje
    }


    public partial class DodajRastlinoForm : Form
    {
        
        public RastlinaModel Rastlina { get; private set; }

        public DodajRastlinoForm(NačinObrazca način, RastlinaModel rastlina = null)
        {
            InitializeComponent();

            this.Text = način == NačinObrazca.Urejanje ? "Urejanje Rastline" : "Dodaj Novo Rastlino";
            labelNaslov.Text = način == NačinObrazca.Urejanje ? "Urejanje Rastline" : "Dodaj Novo Rastlino";

            if (rastlina == null)
            {
                Rastlina = new RastlinaModel();
            }
            else
            {
                Rastlina = rastlina;
                textBoxSlovenskoIme.Text = rastlina.SlovenskoIme;
                textBoxLatinskoIme.Text = rastlina.LatinskoIme;
                textBoxTipRastline.Text = rastlina.TipRastline;
                numericVisina.Value = rastlina.VišinaRastline;
                numericCena.Value = rastlina.CenaRastline;
            }
        }

        private void buttonShraniRastlino_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSlovenskoIme.Text) ||
                string.IsNullOrWhiteSpace(textBoxLatinskoIme.Text) ||
                string.IsNullOrWhiteSpace(textBoxTipRastline.Text))
            {
                MessageBox.Show("Vsa polja morajo biti izpolnjena!", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Rastlina.SlovenskoIme = textBoxSlovenskoIme.Text;
            Rastlina.LatinskoIme = textBoxLatinskoIme.Text;
            Rastlina.TipRastline = textBoxTipRastline.Text;
            Rastlina.VišinaRastline = (int)numericVisina.Value;
            Rastlina.CenaRastline = numericCena.Value;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

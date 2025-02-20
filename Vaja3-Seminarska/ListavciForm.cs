//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Text.Json;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Vaja3_Seminarska
//{
//    public partial class ListavciForm : Form
//    {

//        private BindingList<RastlinaModel> _rastlinaData = new BindingList<RastlinaModel>();

//        private BindingList<RastlinaModel> rastlinaData
//        {
//            get => _rastlinaData;
//        }

//        private void ShraniPodatke()
//        {
//            var json = JsonSerializer.Serialize(_rastlinaData);
//            File.WriteAllText("zbirkaRastlin.json", json);
//        }

//        public ListavciForm()
//        {

//            InitializeComponent();
//            _rastlinaData = new BindingList<RastlinaModel>();
//            rastlinaModelBindingSource.DataSource = _rastlinaData;

//        }


//        private void buttonNazaj_Click(object sender, EventArgs e)
//        {
//            GlavniMeniForm glavniMeniForm = new GlavniMeniForm();
//            glavniMeniForm.Show();
//            this.Hide();
//        }

//        private void ListavciForm_Load(object sender, EventArgs e)
//        {
//            dataGridView1.AutoGenerateColumns = true; // Omogoči avtomatsko generacijo stolpcev

//            if (_rastlinaData == null || _rastlinaData.Count == 0)
//            {
//                _rastlinaData = new BindingList<RastlinaModel>();
//            }

//            rastlinaModelBindingSource.DataSource = _rastlinaData;
//            dataGridView1.DataSource = rastlinaModelBindingSource;

//            if (File.Exists("zbirkaRastlin.json"))
//            {
//                var json = File.ReadAllText("zbirkaRastlin.json");
//                var rastlinaList = JsonSerializer.Deserialize<List<RastlinaModel>>(json) ?? new List<RastlinaModel>(); // Prepreči null

//                foreach (var rastlina in rastlinaList)
//                {
//                    _rastlinaData.Add(rastlina);
//                }
//            }

//            rastlinaModelBindingSource.ResetBindings(false);
//            dataGridView1.Refresh(); // 🔹 Prisili osvežitev
//        }



//        private void ListavciForm_FormClosed(object sender, FormClosedEventArgs e)
//        {
//            var json = JsonSerializer.Serialize(_rastlinaData);
//            File.WriteAllText("zbirkaRastlin.json", json);
//        }

//        private void buttonDodaj_Click(object sender, EventArgs e)
//        {
//            using (var dodajForm = new DodajRastlinoForm())
//            {
//                if (dodajForm.ShowDialog() == DialogResult.OK)
//                {
//                    if (dodajForm.Rastlina != null)
//                    {
//                        rastlinaData.Add(dodajForm.Rastlina);
//                        rastlinaModelBindingSource.ResetBindings(false);
//                        dataGridView1.Refresh(); // 🔹 Prisili osvežitev prikaza
//                        ShraniPodatke();
//                    }
//                }
//            }
//        }


//        private void buttonUredi_Click(object sender, EventArgs e)
//        {
//            if (dataGridView1.SelectedRows.Count > 0)
//            {
//                var izbranaRastlina = (RastlinaModel)dataGridView1.SelectedRows[0].DataBoundItem;

//                using (var urediForm = new DodajRastlinoForm(izbranaRastlina))
//                {
//                    if (urediForm.ShowDialog() == DialogResult.OK)
//                    {
//                        rastlinaModelBindingSource.ResetBindings(false);
//                        dataGridView1.Refresh(); // 🔹 Prisili osvežitev
//                        ShraniPodatke();
//                    }
//                }
//            }
//        }


//        private void buttonIzbriši_Click(object sender, EventArgs e)
//        {
//            if (dataGridView1.SelectedRows.Count > 0)
//            {
//                var izbranaRastlina = (RastlinaModel)dataGridView1.SelectedRows[0].DataBoundItem;

//                var result = MessageBox.Show($"Ali res želite izbrisati rastlino {izbranaRastlina.SlovenskoIme}?", "Potrditev brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

//                if (result == DialogResult.Yes)
//                {
//                    rastlinaData.Remove(izbranaRastlina);
//                    rastlinaModelBindingSource.ResetBindings(false);
//                    ShraniPodatke();
//                }
//            }
//        }

//        private void buttonObdelaj_Click(object sender, EventArgs e)
//        {
//            if (rastlinaData.Count > 0)
//            {
//                double povprecnaCena = (double)rastlinaData.Average(r => r.CenaRastline);
//                MessageBox.Show($"Povprečna cena rastlin je {povprecnaCena:F2} EUR", "Obdelava podatkov", MessageBoxButtons.OK, MessageBoxIcon.Information);
//            }
//            else
//            {
//                MessageBox.Show("Ni podatkov za obdelavo.", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void rastlinaModelBindingSource1_CurrentChanged(object sender, EventArgs e)
//        {

//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace Vaja3_Seminarska
{
    public partial class ListavciForm : Form
    {
        private BindingList<RastlinaModel> _rastlinaData = new BindingList<RastlinaModel>();

        private BindingList<RastlinaModel> rastlinaData
        {
            get => _rastlinaData;
        }
        //private string tip = "";

        private RastlinskiTip tip;

        private string fileName => $"zbirkaRastlin{tip}.json";

        public ListavciForm(/*string tip = ""*/RastlinskiTip tip = RastlinskiTip.Neznano) //zamenjaj z enumi!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1       
        {
            this.tip = tip;
            InitializeComponent();
            _rastlinaData = new BindingList<RastlinaModel>();
            rastlinaModelBindingSource.DataSource = _rastlinaData;
            dataGridView1.DataSource = rastlinaModelBindingSource;
            NaloziPodatke(); // Samodejno naloži podatke ob zagonu
        }



        private void NaloziPodatke()
        {
            if (File.Exists(this.fileName))
            {
                var json = File.ReadAllText(this.fileName);
                var rastlinaList = JsonSerializer.Deserialize<List<RastlinaModel>>(json) ?? new List<RastlinaModel>();

                _rastlinaData.Clear();
                foreach (var rastlina in rastlinaList)
                {
                    _rastlinaData.Add(rastlina);
                }
            }
            rastlinaModelBindingSource.ResetBindings(false);
        }

        private void ShraniPodatke()
        {
            var json = JsonSerializer.Serialize(_rastlinaData);
            File.WriteAllText(this.fileName, json);
        }

        private void buttonNazaj_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            using (var dodajForm = new DodajRastlinoForm(NačinObrazca.Dodajanje))
            {
                if (dodajForm.ShowDialog() == DialogResult.OK)
                {
                    if (dodajForm.Rastlina != null)
                    {
                        rastlinaData.Add(dodajForm.Rastlina);
                        rastlinaModelBindingSource.ResetBindings(false);
                        ShraniPodatke(); // Samodejno shrani po dodajanju
                    }
                }
            }
        }

        private void buttonUredi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var izbranaRastlina = (RastlinaModel)dataGridView1.SelectedRows[0].DataBoundItem;

                using (var urediForm = new DodajRastlinoForm(NačinObrazca.Urejanje, izbranaRastlina)) //tukaj tudi naredi da bo enum
                {
                    if (urediForm.ShowDialog() == DialogResult.OK)
                    {
                        rastlinaModelBindingSource.ResetBindings(false);
                        ShraniPodatke(); // Samodejno shrani po urejanju
                    }
                }
            }
        }

        private void buttonIzbriši_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var izbranaRastlina = (RastlinaModel)dataGridView1.SelectedRows[0].DataBoundItem;

                var result = MessageBox.Show($"Ali res želite izbrisati rastlino {izbranaRastlina.SlovenskoIme}?",
                    "Potrditev brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    rastlinaData.Remove(izbranaRastlina);
                    rastlinaModelBindingSource.ResetBindings(false);
                    ShraniPodatke(); // Samodejno shrani po brisanju
                }
            }
        }

        private void buttonObdelaj_Click(object sender, EventArgs e)
        {
            if (rastlinaData.Count > 0)
            {
                double povprecnaCena = rastlinaData.Average(r => (double)r.CenaRastline);
                MessageBox.Show($"Povprečna cena rastlin je {povprecnaCena:F2} EUR",
                    "Obdelava podatkov", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ni podatkov za obdelavo.", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListavciForm_Load(object sender, EventArgs e)
        {
            this.Text = this.tip switch
            {
                RastlinskiTip.Iglavci => "Zbirka Iglavci",
                RastlinskiTip.Listavci => "Zbirka Listavci",
                RastlinskiTip.Grmicevje => "Zbirka Grmičevje",
                _ => "Neznana Zbirka"
            };
        }

        private void ListavciForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlavniMeniForm glavniMeniForm = new GlavniMeniForm();
            glavniMeniForm.Show();
        }
    }
}


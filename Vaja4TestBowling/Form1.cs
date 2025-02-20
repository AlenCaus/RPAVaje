using System.ComponentModel;
using System.Net.Http.Json;
using System.Text.Json;

namespace Vaja4TestBowling
{
    public partial class Form1 : Form
    {
        public BindingList<IgralecModel> Igralci
        {
            get =>
                this.igralecModelBindingSource.List as BindingList<IgralecModel>;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            HttpClient client = new ();
            var igralciList = await client.GetFromJsonAsync<List<IgralecModel>>(ApiURL);
            
            foreach (var igralec in igralciList)
            {
                this.Igralci.Add(igralec);

            }
        }

        private async  void buttonDodaj_Click(object sender, EventArgs e)
        {
            FormUredi frm = new();
            var dr = frm.ShowDialog();

            if (dr != DialogResult.OK)
            {
                return;

            }

            Igralci.Add(new IgralecModel
            {
                Ime = frm.textIme.Text,
                Tocke = int.Parse(frm.textTocke.Text),

            });
            await ShraniNaStrežnik();
        }

        private const string ApiURL = "http://localhost:5083/igralci";
        private async Task ShraniNaStrežnik()
        {
            //var jsonString  = JsonSerializer.Serialize(Igralci);

            HttpClient client = new ();

            client.PutAsJsonAsync(ApiURL, Igralci);

        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = sender as DataGridView;



            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex >= 0) 
            {
            
                var headerText = senderGrid.Columns[e.ColumnIndex].HeaderText;
                if (headerText == "Uredi") 
                {
                    Uredi(e.RowIndex);
                    await ShraniNaStrežnik();
                }
                else if (headerText == "Odstrani")
                {
                    Brisi(e.RowIndex);
                    await ShraniNaStrežnik();
                }
            
            }
            
        }

        private void Uredi (int rowIndex)
        {
            FormUredi frm = new();
            var dr = frm.ShowDialog();

            frm.textIme.Text = Igralci[rowIndex].Ime;
            frm.textTocke.Text = Igralci[rowIndex].Tocke.ToString();

            if (dr != DialogResult.OK)
            {
                return;

            }

            Igralci[rowIndex].Ime = frm.textIme.Text;
            Igralci[rowIndex].Tocke = int.Parse(frm.textTocke.Text);
            dataGridView1.Refresh();

        }
        private void Brisi(int rowIndex)
        {
            Igralci.RemoveAt(rowIndex);
            dataGridView1.Refresh();
        }
    }
}

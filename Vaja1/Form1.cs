using MailKit.Net.Smtp;
using MimeKit;

namespace Vaja1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Ta metoda lahko ostane prazna ali jo odstranite, če ni potrebna.
        }

        private void buttonPoslji_Click(object sender, EventArgs e)
        {
            // Validacija vnosnih podatkov
            if (string.IsNullOrWhiteSpace(textPosiljatelj.Text) ||
                string.IsNullOrWhiteSpace(textPrejemnik.Text) ||
                string.IsNullOrWhiteSpace(textZadeva.Text) ||
                string.IsNullOrWhiteSpace(textSporocilo.Text))
            {
                MessageBox.Show("Prosimo, izpolnite vsa polja!");
                return;
            }

            // Ustvarjanje novega sporočila
            Sporocila novoSporocilo = new Sporocila
            {
                Posiljatelj = textPosiljatelj.Text,
                Prejemnik = textPrejemnik.Text,
                Zadeva = textZadeva.Text,
                Vsebina = textSporocilo.Text
            };

            // Nalaganje obstoječih sporočil
            var sporocila = JsonHandler.NaloziSporocila();

            // Dodajanje novega sporočila
            sporocila.Add(novoSporocilo);

            // Shranjevanje sporočil v JSON
            JsonHandler.ShraniSporocila(sporocila);

            // Počistimo vnosna polja
            textPosiljatelj.Clear();
            textPrejemnik.Clear();
            textZadeva.Clear();
            textSporocilo.Clear();

            MessageBox.Show("Sporočilo je bilo poslano.");
        }

        private void seznamPoslanihSporocilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Preberemo sporočila iz JSON datoteke
            var sporocila = JsonHandler.NaloziSporocila();

            if (sporocila.Count == 0)
            {
                MessageBox.Show("Ni poslanih sporočil.", "Seznam sporočil");
                return;
            }

            // Sestavimo seznam sporočil za prikaz
            string seznamSporocil = "Seznam poslanih sporočil:\n\n";
            foreach (var sporocilo in sporocila)
            {
                seznamSporocil += $"Pošiljatelj: {sporocilo.Posiljatelj}\n" +
                                  $"Prejemnik: {sporocilo.Prejemnik}\n" +
                                  $"Zadeva: {sporocilo.Zadeva}\n" +
                                  $"Vsebina:\n{sporocilo.Vsebina}\n\n";
            }

            // Prikažemo seznam sporočil v MessageBox
            MessageBox.Show(seznamSporocil, "Seznam poslanih sporočil");
        }
    }
}








//var message = new MimeMessage();
//message.From.Add(new MailboxAddress("Joey Tribbiani", "joey@friends.com")); ///prejemni pazi
//message.To.Add(new MailboxAddress("Mrs. Chanandler Bong", "chandler@friends.com")); //pazi
//message.Subject = "How you doin'?";

//message.Body = new TextPart("plain")
//{
//    Text = @"Hey Chandler,

//I just wanted to let you know that Monica and I were going to go play some paintball, you in?

//-- Joey"
//};

//using (var client = new SmtpClient())
//{
//    client.Connect("smtp.friends.com", 587, false); //text.client pazi

//    // Note: only needed if the SMTP server requires authentication
//    client.Authenticate("joey", "password"); //text.text pazi tukaj

//    client.Send(message);
//    client.Disconnect(true);
//}
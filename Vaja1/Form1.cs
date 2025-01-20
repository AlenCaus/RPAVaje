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

        }

        private void buttonPoslji_Click(object sender, EventArgs e)
        {
            


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
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLSLQueueingApp
{
    public partial class TicketForm2_2_1_1NormalLane : Form
    {
        public TicketForm2_2_1_1NormalLane()
        {
            InitializeComponent();
        }
        private static readonly HttpClient client = new HttpClient();

        private void TicketForm2_2_1_1NormalLane_Load(object sender, EventArgs e)
        {
            Opacity = 0.1; // Form Animation
            animationTimer.Start(); // Form Animation
            TopMost = true; // Para fullscreen
            FormBorderStyle = FormBorderStyle.None; // Para fullscreen
            WindowState = FormWindowState.Maximized; // Para fullscreen
            ticketForm2_2_1_1BackBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            ticketForm2_2_1_1CollegeBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            ticketForm2_2_1_1OthersBtn.BackColor = ColorTranslator.FromHtml("#21282E");
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity <= 1.0){
                Opacity += 0.025;
            }
            else{
                animationTimer.Stop();
            }
        }

        private void ticketForm2_2_1_1BackBtn_Click(object sender, EventArgs e)
        {
            TicketForm2_2_1 tf2_2_1 = new TicketForm2_2_1();
            tf2_2_1.ShowDialog();
            Close();
        }

        private async void ticketForm2_2_1_1CollegeBtn_Click(object sender, EventArgs e)
        {
            var values = new Dictionary<string, string>
                {
                    { "studentNumber", "" }
                };
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/validationForRegularLaneCollege.php", content);
            var responseString = await response.Content.ReadAsStringAsync();
            if (responseString.Contains("1YES"))
            {
                content = new FormUrlEncodedContent(values);
                response = await client.PostAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/regularLaneCollegeCashier1.php", content);
            }
            else if(responseString.Contains("2YES"))
            {
                content = new FormUrlEncodedContent(values);
                response = await client.PostAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/regularLaneCollegeCashier2.php", content);
            }
            TicketForm4_Mobile_NormalCollegeTicketPrinting tf4_M = new TicketForm4_Mobile_NormalCollegeTicketPrinting();
            tf4_M.ShowDialog();
            Close();
        }

        private async void ticketForm2_2_1_1OthersBtn_Click(object sender, EventArgs e)
        {
            var values = new Dictionary<string, string>
                {
                    { "studentNumber", "" }
                };
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/validationForRegularLaneOthers.php", content);
            var responseString = await response.Content.ReadAsStringAsync();
            if (responseString.Contains("3YES"))
            {
                content = new FormUrlEncodedContent(values);
                response = await client.PostAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/regularLaneOthersCashier3.php", content);
            }
            else if (responseString.Contains("4YES"))
            {
                content = new FormUrlEncodedContent(values);
                response = await client.PostAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/regularLaneOthersCashier4.php", content);
            }
            TicketForm4_Mobile_NormalOthersTicketPrinting tf4_M = new TicketForm4_Mobile_NormalOthersTicketPrinting();
            tf4_M.ShowDialog();
            Close();
            
        }
    }
}

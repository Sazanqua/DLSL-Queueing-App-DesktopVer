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
    public partial class TicketForm2_2_1_2PriorityLane : Form
    {
        public TicketForm2_2_1_2PriorityLane()
        {
            InitializeComponent();
        }
        private static readonly HttpClient client = new HttpClient();

        private void TicketForm2_2_1_2PriorityLane_Load(object sender, EventArgs e)
        {
            Opacity = 0.1; // Form Animation
            animationTimer.Start(); // Form Animation
            TopMost = true; // Para fullscreen
            FormBorderStyle = FormBorderStyle.None; // Para fullscreen
            WindowState = FormWindowState.Maximized; // Para fullscreen
            ticketForm2_2_1_2BackBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            ticketForm2_2_1_2CollegeBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            ticketForm2_2_1_2OthersBtn.BackColor = ColorTranslator.FromHtml("#21282E");
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity <= 1.0)
            {
                Opacity += 0.025;
            }
            else
            {
                animationTimer.Stop();
            }
        }

        private void ticketForm2_2_1_2BackBtn_Click(object sender, EventArgs e)
        {
            TicketForm2_2_1 tf2_2_1 = new TicketForm2_2_1();
            tf2_2_1.ShowDialog();
            Close();
        }


        private async void ticketForm2_2_1_2CollegeBtn_Click(object sender, EventArgs e)
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
                response = await client.PostAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/priorityLaneCollegeCashier1.php", content);
            }
            else if (responseString.Contains("2YES"))
            {
                content = new FormUrlEncodedContent(values);
                response = await client.PostAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/priorityLaneCollegeCashier2.php", content);
            }
            TicketForm4_Mobile_PriorityCollegeTicketPrinting tf4_M = new TicketForm4_Mobile_PriorityCollegeTicketPrinting();
            tf4_M.ShowDialog();
            Close();
            
        }

        private async void ticketForm2_2_1_2OthersBtn_Click(object sender, EventArgs e)
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
                response = await client.PostAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/priorityLaneOthersCashier3.php", content);
            }
            else if (responseString.Contains("4YES"))
            {
                content = new FormUrlEncodedContent(values);
                response = await client.PostAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/priorityLaneOthersCashier4.php", content);
            }

            TicketForm4_Mobile_PriorityOthersTicketPrinting tf4_M = new TicketForm4_Mobile_PriorityOthersTicketPrinting();
            tf4_M.ShowDialog();
            Close();
            
        }
    }
}

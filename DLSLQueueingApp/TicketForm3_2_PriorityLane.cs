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
    public partial class TicketForm3_2_PriorityLane : Form
    {
        public TicketForm3_2_PriorityLane()
        {
            InitializeComponent();
        }
        private static readonly HttpClient client = new HttpClient();

        private void TicketForm3_2_Load(object sender, EventArgs e)
        {
            Opacity = 0.1; // Form Animation
            animationTimer.Start(); // Form Animation

            TopMost = true; // Para fullscreen
            FormBorderStyle = FormBorderStyle.None; // Para fullscreen
            WindowState = FormWindowState.Maximized; // Para fullscreen

            ticketForm3_2BackBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            ticketForm3_2CollegeBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            ticketForm3_2OthersBtn.BackColor = ColorTranslator.FromHtml("#21282E");
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

        private void ticketForm3_2BackBtn_Click(object sender, EventArgs e)
        {
            TicketForm2_1 tf2_1 = new TicketForm2_1();
            tf2_1.ShowDialog();
            Close();
        }

        private async void ticketForm3_2CollegeBtn_Click(object sender, EventArgs e)
        {
            HttpResponseMessage validationResponse = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/validationForRegularLaneCollege.php");
            var vrString = await validationResponse.Content.ReadAsStringAsync();
            if (vrString.Contains("1YES"))
            {
                HttpResponseMessage getResponse = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/manualQueuePriorityLaneCollegeCashier1.php");
            }
            else if (vrString.Contains("2YES"))
            {
                HttpResponseMessage getResponse = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/manualQueuePriorityLaneCollegeCashier2.php");
            }

            TicketForm4_3PriorityTicketPrinting tf4_3 = new TicketForm4_3PriorityTicketPrinting();
                tf4_3.ShowDialog();
                Close();
        }

        private async void ticketForm3_2OthersBtn_Click(object sender, EventArgs e)
        {
            HttpResponseMessage validationResponse = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/validationForRegularLaneOthers.php");
            var vrString = await validationResponse.Content.ReadAsStringAsync();
            if (vrString.Contains("3YES"))
            {
                HttpResponseMessage getResponse = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/manualQueuePriorityLaneOthersCashier3.php");
            }
            else if (vrString.Contains("4YES"))
            {
                HttpResponseMessage getResponse = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/manualQueuePriorityLaneOthersCashier4.php");
            }

            TicketForm4_4PriorityOtherTicketPrinting tf4_4 = new TicketForm4_4PriorityOtherTicketPrinting();
                tf4_4.ShowDialog();
                Close();
        }

        
    }
}

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
    public partial class TicketForm2_2_1 : Form
    {
        public TicketForm2_2_1()
        {
            InitializeComponent();
        }
        private static readonly HttpClient client = new HttpClient();

        private void TicketForm2_2_1_Load(object sender, EventArgs e)
        {
            Opacity = 0.1; // Form Animation
            animationTimer.Start(); // Form Animation

            TopMost = true; // Para fullscreen
            FormBorderStyle = FormBorderStyle.None; // Para fullscreen
            WindowState = FormWindowState.Maximized; // Para fullscreen

            ticketForm2_2_1LogoutBtn.BackColor = ColorTranslator.FromHtml("#DC143C");
            mobileQueue_NormalLaneBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            mobileQueue_PriorityLaneBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            priorityLanePb.BackColor = ColorTranslator.FromHtml("#21282E");
            pblbl.BackColor = ColorTranslator.FromHtml("#21282E");
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
        private async void ticketForm2_2_1LogoutBtn_Click(object sender, EventArgs e)
        {
            var values = new Dictionary<string, string>
                {
                    { "studentNumber", "" }
                };
            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/userLogoutDesktop.php", content);
            TicketForm2_2 tf2_2 = new TicketForm2_2();
            tf2_2.ShowDialog();
            Close();
        }

        private void mobileQueue_NormalLaneBtn_Click(object sender, EventArgs e)
        {
            TicketForm2_2_1_1NormalLane tf2_2_1_1 = new TicketForm2_2_1_1NormalLane();
            tf2_2_1_1.ShowDialog();
            Close();
        }

        private void mobileQueue_PriorityLaneBtn_Click(object sender, EventArgs e)
        {
            TicketForm2_2_1_2PriorityLane tf2_2_1_2 = new TicketForm2_2_1_2PriorityLane();
            tf2_2_1_2.ShowDialog();
            Close();
        }

        
    }
}

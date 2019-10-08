using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void ticketForm2_2_1LogoutBtn_Click(object sender, EventArgs e)
        {
            String connection = "server=localhost;user id=root; password=root;database=dlsl_app"; // Para magstart yung mysql
            String query = "UPDATE users SET currently_queueing = 'NO' WHERE currently_queueing = 'YES'; ";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dReader;
            con.Open();
            dReader = cmd.ExecuteReader();
            dReader.Close();

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

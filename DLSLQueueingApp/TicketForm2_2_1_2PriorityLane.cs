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
    public partial class TicketForm2_2_1_2PriorityLane : Form
    {
        public TicketForm2_2_1_2PriorityLane()
        {
            InitializeComponent();
        }

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

        private void ticketForm2_2_1_2CollegeBtn_Click(object sender, EventArgs e)
        {

        }

        private void ticketForm2_2_1_2OthersBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class TicketForm3_2 : Form
    {
        public TicketForm3_2()
        {
            InitializeComponent();
        }

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

        private void ticketForm3_2CollegeBtn_Click(object sender, EventArgs e)
        {

        }

        private void ticketForm3_2OthersBtn_Click(object sender, EventArgs e)
        {

        }

        
    }
}

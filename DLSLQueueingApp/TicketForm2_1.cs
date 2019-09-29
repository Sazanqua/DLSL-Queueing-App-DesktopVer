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
    public partial class TicketForm2_1 : Form
    {
        public TicketForm2_1()
        {
            InitializeComponent();
        }

        private void TicketForm2_Load(object sender, EventArgs e)
        {
            Opacity = 0.1; // Form Animation
            animationTimer.Start(); // Form Animation

            TopMost = true; // Para fullscreen
            FormBorderStyle = FormBorderStyle.None; // Para fullscreen
            WindowState = FormWindowState.Maximized; // Para fullscreen
            
            ticketForm2_1BackBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            normalLaneBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            priorityLaneBtn.BackColor = ColorTranslator.FromHtml("#21282E");
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

        private void ticketForm2BackBtn_Click(object sender, EventArgs e)
        {
            TicketForm tf = new TicketForm();
            tf.ShowDialog();
            Close();
        }

        private void normalLaneBtn_Click(object sender, EventArgs e)
        {
            TicketForm3_1_NormalLane tf3_1 = new TicketForm3_1_NormalLane();
            tf3_1.ShowDialog();
            Close();
        }

        private void priorityLaneBtn_Click(object sender, EventArgs e)
        {
            TicketForm3_2_PriorityLane tf3_2 = new TicketForm3_2_PriorityLane();
            tf3_2.ShowDialog();
            Close();
        }
    }
}

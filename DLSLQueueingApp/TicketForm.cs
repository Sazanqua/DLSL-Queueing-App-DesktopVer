using System;
using System.Drawing;
using System.Windows.Forms;

namespace DLSLQueueingApp
{
    public partial class TicketForm: Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Opacity = 0.1; // Form Animation
            animationTimer.Start(); // Form Animation

            TopMost = true; // Para fullscreen
            FormBorderStyle = FormBorderStyle.None; // Para fullscreen
            WindowState = FormWindowState.Maximized; // Para fullscreen

            manualQueueBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            mobileAppQueueBtn.BackColor = ColorTranslator.FromHtml("#21282E");
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

        private void manualQueueBtn_Click(object sender, EventArgs e)
        {
            TicketForm2_1 tf2_1 = new TicketForm2_1();
            tf2_1.ShowDialog();
            Close();
        }

        private void mobileAppQueueBtn_Click(object sender, EventArgs e)
        {
            TicketForm2_2 tf2_2 = new TicketForm2_2();
            tf2_2.ShowDialog();
            Close();
        }

        
    }
}

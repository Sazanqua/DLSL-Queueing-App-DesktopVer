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
    public partial class TicketForm4_1NormalTicketPrinting : Form
    {
        public TicketForm4_1NormalTicketPrinting()
        {
            InitializeComponent();
        }

        private void TicketForm4_1NormalTicketPrinting_Load(object sender, EventArgs e)
        {
            Opacity = 0.1; // Form Animation
            animationTimer.Start(); // Form Animation

            TopMost = true; // Para fullscreen
            FormBorderStyle = FormBorderStyle.None; // Para fullscreen
            WindowState = FormWindowState.Maximized; // Para fullscreen

            ticketPanel.BackColor = ColorTranslator.FromHtml("#146344");
            confirmBtn.BackColor = ColorTranslator.FromHtml("#146344");

            queueNumber.ForeColor = ColorTranslator.FromHtml("#146344");
            qnLbl.ForeColor = ColorTranslator.FromHtml("#146344");
            cLbl.ForeColor = ColorTranslator.FromHtml("#146344");
            cashierNumber.ForeColor = ColorTranslator.FromHtml("#146344");
            serviceLane.ForeColor = ColorTranslator.FromHtml("#146344");
            serviceType.ForeColor = ColorTranslator.FromHtml("#146344");
            edLbl.ForeColor = ColorTranslator.FromHtml("#146344");
            expirationDate.ForeColor = ColorTranslator.FromHtml("#146344");


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

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            TicketForm tf = new TicketForm();
            tf.ShowDialog();
            Close();
        }
    }
}

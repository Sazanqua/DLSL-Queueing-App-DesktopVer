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

            string expDate = DateTime.Now.AddDays(1).ToString("MMM-dd-yyy");

            ticketPanel.BackColor = ColorTranslator.FromHtml("#146344");
            confirmBtn.BackColor = ColorTranslator.FromHtml("#146344");

            queueNumber.ForeColor = ColorTranslator.FromHtml("#146344");
            cLbl.ForeColor = ColorTranslator.FromHtml("#146344");
            cashierNumber.ForeColor = ColorTranslator.FromHtml("#146344");
            serviceLane.ForeColor = ColorTranslator.FromHtml("#146344");
            serviceType.ForeColor = ColorTranslator.FromHtml("#146344");
            edLbl.ForeColor = ColorTranslator.FromHtml("#146344");
            expirationDate.ForeColor = ColorTranslator.FromHtml("#146344");

            expirationDate.Text = expDate.ToString();

            
            if (TicketForm3_1_NormalLane.numberOfQueueCashier1 == 0)
            {
                queueNumber.Text = TicketForm3_1_NormalLane.numberOfQueueCashier2.ToString();
                cashierNumber.Text = "2";
            }
            else if(TicketForm3_1_NormalLane.numberOfQueueCashier2 == 0)
            {
                queueNumber.Text = TicketForm3_1_NormalLane.numberOfQueueCashier1.ToString();
                cashierNumber.Text = "1";
            }
            else if (TicketForm3_1_NormalLane.numberOfQueueCashier3 == 0)
            {
                queueNumber.Text = TicketForm3_1_NormalLane.numberOfQueueCashier4.ToString();
                cashierNumber.Text = "4";
            }
            else if (TicketForm3_1_NormalLane.numberOfQueueCashier4 == 0)
            {
                queueNumber.Text = TicketForm3_1_NormalLane.numberOfQueueCashier3.ToString();
                cashierNumber.Text = "3";
            }
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
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 200, 200);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.Print();

            //printPreviewDialog1.ShowDialog();


            TicketForm tf = new TicketForm();
            tf.ShowDialog();
            Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(queueNumber.Text, new Font("Times New Roman", 40, FontStyle.Regular), Brushes.Black, new Point(60, 70));
            e.Graphics.DrawString("Cashier " + cashierNumber.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(65, 10));
            e.Graphics.DrawString("Normal", new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(10, 40));
            e.Graphics.DrawString("College", new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(130, 40));
            e.Graphics.DrawString("Expiration Date: ", new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(40, 150));
            e.Graphics.DrawString(expirationDate.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(55, 170));
        }
    }
}

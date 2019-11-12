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
    public partial class TicketForm4_1NormalTicketPrinting : Form
    {
        public TicketForm4_1NormalTicketPrinting()
        {
            InitializeComponent();
        }
        private static readonly HttpClient client = new HttpClient();

        private async void TicketForm4_1NormalTicketPrinting_Load(object sender, EventArgs e)
        {
            Opacity = 0.1; // Form Animation
            animationTimer.Start(); // Form Animation

            TopMost = true; // Para fullscreen
            FormBorderStyle = FormBorderStyle.None; // Para fullscreen
            WindowState = FormWindowState.Maximized; // Para fullscreen

            ticketPanel.BackColor = ColorTranslator.FromHtml("#146344");
            confirmBtn.BackColor = ColorTranslator.FromHtml("#146344");

            queueNumber.ForeColor = ColorTranslator.FromHtml("#146344");
            cLbl.ForeColor = ColorTranslator.FromHtml("#146344");
            cashierNumber.ForeColor = ColorTranslator.FromHtml("#146344");
            serviceLane.ForeColor = ColorTranslator.FromHtml("#146344");
            serviceType.ForeColor = ColorTranslator.FromHtml("#146344");
            timeLbl.ForeColor = ColorTranslator.FromHtml("#146344");
            dateLbl.ForeColor = ColorTranslator.FromHtml("#146344");
            cLbl.Text = "Cashier ";
            HttpResponseMessage cnr = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/printServiceQueueTicketCashierNumber.php");
            var cn = await cnr.Content.ReadAsStringAsync();

            HttpResponseMessage qnr = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/printServiceQueueTicketQueueNumber.php");
            var qn = await qnr.Content.ReadAsStringAsync();

            HttpResponseMessage str = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/printServiceQueueTicketServiceType.php");
            var st = await str.Content.ReadAsStringAsync();

            HttpResponseMessage slr = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/printServiceQueueTicketServiceLane.php");
            var sl = await slr.Content.ReadAsStringAsync();

            HttpResponseMessage tr = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/printServiceQueueTicketTime.php");
            var t = await tr.Content.ReadAsStringAsync();

            HttpResponseMessage dr = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/printServiceQueueTicketDate.php");
            var d = await dr.Content.ReadAsStringAsync();

            queueNumber.Text = qn;
            cashierNumber.Text = cn;
            serviceLane.Text = sl;
            serviceType.Text = st;
            dateLbl.Text = d;
            timeLbl.Text = t;
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
            e.Graphics.DrawString(queueNumber.Text, new Font("Times New Roman", 40, FontStyle.Regular), Brushes.Black, new Point(60, 80));
            e.Graphics.DrawString("Cashier " + cashierNumber.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(65, 10));
            e.Graphics.DrawString(serviceLane.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(0, 40));
            e.Graphics.DrawString(serviceType.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(110, 40));
            e.Graphics.DrawString(dateLbl.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(35, 160));
            e.Graphics.DrawString(timeLbl.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(65, 140));
        }
    }
}

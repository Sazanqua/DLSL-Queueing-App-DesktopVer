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
    public partial class TicketForm4_Mobile_NormalCollegeTicketPrinting : Form
    {
        public TicketForm4_Mobile_NormalCollegeTicketPrinting()
        {
            InitializeComponent();
        }

        private void TicketForm4_Mobile_NormalCollegeTicketPrinting_Load(object sender, EventArgs e)
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
            studentNumber.ForeColor = ColorTranslator.FromHtml("#146344");

            expirationDate.Text = expDate.ToString();
            studentNumber.Text = TicketForm2_2_1_1NormalLane.studentNumberHolder;

            if (TicketForm2_2_1_1NormalLane.numberOfQueueCashier1 == 0)
            {
                queueNumber.Text = TicketForm2_2_1_1NormalLane.numberOfQueueCashier2.ToString();
                cashierNumber.Text = "2";
            }
            else if (TicketForm2_2_1_1NormalLane.numberOfQueueCashier2 == 0)
            {
                queueNumber.Text = TicketForm2_2_1_1NormalLane.numberOfQueueCashier1.ToString();
                cashierNumber.Text = "1";
            }
            else if (TicketForm2_2_1_1NormalLane.numberOfQueueCashier3 == 0)
            {
                queueNumber.Text = TicketForm2_2_1_1NormalLane.numberOfQueueCashier4.ToString();
                cashierNumber.Text = "4";
            }
            else if (TicketForm2_2_1_1NormalLane.numberOfQueueCashier4 == 0)
            {
                queueNumber.Text = TicketForm2_2_1_1NormalLane.numberOfQueueCashier3.ToString();
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(queueNumber.Text, new Font("Times New Roman", 40, FontStyle.Regular), Brushes.Black, new Point(60, 80));
            e.Graphics.DrawString(studentNumber.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(55, 60));
            e.Graphics.DrawString("Cashier " + cashierNumber.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(65, 10));
            e.Graphics.DrawString("Normal", new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(10, 40));
            e.Graphics.DrawString("College", new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(130, 40));
            e.Graphics.DrawString("Expiration Date: ", new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(40, 150));
            e.Graphics.DrawString(expirationDate.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(55, 170));
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 200, 200);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.Print();

            //printPreviewDialog1.ShowDialog();

            String connection = "server=localhost;user id=root; password=root;database=dlsl_app"; // Para magstart yung mysql
            String query = "UPDATE users SET currently_queueing = 'NO' WHERE currently_queueing = 'YES'; ";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dReader;
            con.Open();
            dReader = cmd.ExecuteReader();
            dReader.Close();

            TicketForm tf = new TicketForm();
            tf.ShowDialog();
            Close();
        }
    }
}

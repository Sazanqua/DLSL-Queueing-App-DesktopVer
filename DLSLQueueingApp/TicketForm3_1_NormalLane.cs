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
    public partial class TicketForm3_1_NormalLane : Form
    {
        public TicketForm3_1_NormalLane()
        {
            InitializeComponent();
        }

        public int idHolder;
        public static int queueNoHolder;
        public static int numberOfQueueCashier1;
        public static int numberOfQueueCashier2;
        public static int numberOfQueueCashier3;
        public static int numberOfQueueCashier4;

        private void TicketForm3_1_Load(object sender, EventArgs e)
        {
            Opacity = 0.1; // Form Animation
            animationTimer.Start(); // Form Animation

            TopMost = true; // Para fullscreen
            FormBorderStyle = FormBorderStyle.None; // Para fullscreen
            WindowState = FormWindowState.Maximized; // Para fullscreen

            ticketForm3_1BackBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            ticketForm3_1CollegeBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            ticketForm3_1OthersBtn.BackColor = ColorTranslator.FromHtml("#21282E");

            String connection = "server=localhost;user id=root; password=root;database=dlsl_app"; // Para magstart yung mysql
            String query = "SELECT id FROM service_manual ORDER BY id DESC LIMIT 1;";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dReader;
            try
            {
                con.Open();
                dReader = cmd.ExecuteReader();
                while (dReader.Read())
                {
                    idHolder = dReader.GetInt32("id");
                }

                dReader.Close();
                String query2 = "SELECT queue_no FROM service_manual ORDER BY id DESC LIMIT 1;";
                MySqlCommand cmd2 = new MySqlCommand(query2, con);
                dReader = cmd2.ExecuteReader();
                while (dReader.Read())
                {
                    queueNoHolder = dReader.GetInt32("queue_no");
                }

                dReader.Close();
                String query3 = "SELECT number_of_queue FROM cashier where cashier_number =1;";
                MySqlCommand cmd3 = new MySqlCommand(query3, con);
                dReader = cmd3.ExecuteReader();
                while (dReader.Read())
                {
                    numberOfQueueCashier1 = dReader.GetInt32("number_of_queue");
                }

                dReader.Close();
                String query4 = "SELECT number_of_queue FROM cashier where cashier_number =2;";
                MySqlCommand cmd4 = new MySqlCommand(query4, con);
                dReader = cmd4.ExecuteReader();
                while (dReader.Read())
                {
                    numberOfQueueCashier2 = dReader.GetInt32("number_of_queue");
                }

                dReader.Close();
                String query5 = "SELECT number_of_queue FROM cashier where cashier_number =3;";
                MySqlCommand cmd5 = new MySqlCommand(query5, con);
                dReader = cmd5.ExecuteReader();
                while (dReader.Read())
                {
                    numberOfQueueCashier3 = dReader.GetInt32("number_of_queue");
                }

                dReader.Close();
                String query6 = "SELECT number_of_queue FROM cashier where cashier_number =4;";
                MySqlCommand cmd6 = new MySqlCommand(query6, con);
                dReader = cmd6.ExecuteReader();
                while (dReader.Read())
                {
                    numberOfQueueCashier4 = dReader.GetInt32("number_of_queue");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void ticketForm3_1BackBtn_Click(object sender, EventArgs e)
        {
            TicketForm2_1 tf2_1 = new TicketForm2_1();
            tf2_1.ShowDialog();
            Close();
        }

        private void ticketForm3_1CollegeBtn_Click(object sender, EventArgs e)
        {
            idHolder++;
            queueNoHolder++;
            
            String connection = "server=localhost;user id=root; password=root;database=dlsl_app"; // Para magstart yung mysql
            MySqlConnection con = new MySqlConnection(connection);
            MySqlDataReader dReader;
            try
            {
                con.Open();
                if(numberOfQueueCashier1 == numberOfQueueCashier2 || numberOfQueueCashier1 < numberOfQueueCashier2)
                {
                    numberOfQueueCashier1++;
                    numberOfQueueCashier2 = 0;
                    String query = "INSERT INTO service_manual (id, queue_no, cashier_number, queueing_status, service_type ,service_lane) VALUES('" + idHolder + "', '" + numberOfQueueCashier1 + "', '1', 'PENDING', 'COLLEGE', 'NORMAL')";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    dReader = cmd.ExecuteReader();
                    dReader.Close();
                    String query2 = "UPDATE cashier SET number_of_queue = '" + numberOfQueueCashier1 + "' WHERE cashier_number=1";
                    MySqlCommand cmd2 = new MySqlCommand(query2, con);
                    dReader = cmd2.ExecuteReader();
                }
                else if(numberOfQueueCashier1 > numberOfQueueCashier2)
                {
                    numberOfQueueCashier2++;
                    numberOfQueueCashier1 = 0;
                    String query = "INSERT INTO service_manual (id, queue_no, cashier_number, queueing_status, service_type ,service_lane) VALUES('" + idHolder + "', '" + numberOfQueueCashier2 + "', '2', 'PENDING', 'COLLEGE', 'NORMAL')";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    dReader = cmd.ExecuteReader();
                    dReader.Close();
                    String query3 = "UPDATE cashier SET number_of_queue = '" + numberOfQueueCashier2 + "' WHERE cashier_number=2";
                    MySqlCommand cmd3 = new MySqlCommand(query3, con);
                    dReader = cmd3.ExecuteReader();
                }

                TicketForm4_1NormalTicketPrinting tf4_1 = new TicketForm4_1NormalTicketPrinting();
                tf4_1.ShowDialog();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ticketForm3_1OthersBtn_Click(object sender, EventArgs e)
        {
            idHolder++;
            queueNoHolder++;

            String connection = "server=localhost;user id=root; password=root;database=dlsl_app"; // Para magstart yung mysql
            MySqlConnection con = new MySqlConnection(connection);
            MySqlDataReader dReader;
            try
            {
                con.Open();
                if (numberOfQueueCashier3 == numberOfQueueCashier4 || numberOfQueueCashier3 < numberOfQueueCashier4)
                {
                    numberOfQueueCashier3++;
                    numberOfQueueCashier4 = 0;
                    String query = "INSERT INTO service_manual (id, queue_no, cashier_number, queueing_status, service_type ,service_lane) VALUES('" + idHolder + "', '" + numberOfQueueCashier3 + "', '3', 'PENDING', 'OTHERS', 'NORMAL')";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    dReader = cmd.ExecuteReader();
                    dReader.Close();
                    String query2 = "UPDATE cashier SET number_of_queue = '" + numberOfQueueCashier3 + "' WHERE cashier_number=3";
                    MySqlCommand cmd2 = new MySqlCommand(query2, con);
                    dReader = cmd2.ExecuteReader();
                }
                else if (numberOfQueueCashier3 > numberOfQueueCashier4)
                {
                    numberOfQueueCashier4++;
                    numberOfQueueCashier3 = 0;
                    String query = "INSERT INTO service_manual (id, queue_no, cashier_number, queueing_status, service_type ,service_lane) VALUES('" + idHolder + "', '" + numberOfQueueCashier4 + "', '4', 'PENDING', 'OTHERS', 'NORMAL')";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    dReader = cmd.ExecuteReader();
                    dReader.Close();
                    String query3 = "UPDATE cashier SET number_of_queue = '" + numberOfQueueCashier4 + "' WHERE cashier_number=4";
                    MySqlCommand cmd3 = new MySqlCommand(query3, con);
                    dReader = cmd3.ExecuteReader();
                }

                TicketForm4_2OtherTicketPrinting tf4_2 = new TicketForm4_2OtherTicketPrinting();
                tf4_2.ShowDialog();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}

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
    public partial class TicketForm3_2_PriorityLane : Form
    {
        public TicketForm3_2_PriorityLane()
        {
            InitializeComponent();
        }
        public int idHolder;
        public static int queueNoHolder;
        public static int numberOfQueueCashier1;
        public static int numberOfQueueCashier2;
        public static int numberOfQueueCashier3;
        public static int numberOfQueueCashier4;

        public static int currentQueueCashier1;
        public static int currentQueueCashier2;
        public static int currentQueueCashier3;
        public static int currentQueueCashier4;
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

                dReader.Close();
                String query7 = "select current_queue_number from cashier where cashier_number=1;";
                MySqlCommand cmd7 = new MySqlCommand(query7, con);
                dReader = cmd7.ExecuteReader();
                while (dReader.Read())
                {
                    currentQueueCashier1 = dReader.GetInt32("current_queue_number");
                }

                dReader.Close();
                String query8 = "select current_queue_number from cashier where cashier_number=2;";
                MySqlCommand cmd8 = new MySqlCommand(query8, con);
                dReader = cmd8.ExecuteReader();
                while (dReader.Read())
                {
                    currentQueueCashier2 = dReader.GetInt32("current_queue_number");
                }

                dReader.Close();
                String query9 = "select current_queue_number from cashier where cashier_number=3;";
                MySqlCommand cmd9 = new MySqlCommand(query9, con);
                dReader = cmd9.ExecuteReader();
                while (dReader.Read())
                {
                    currentQueueCashier3 = dReader.GetInt32("current_queue_number");
                }

                dReader.Close();
                String query10 = "select current_queue_number from cashier where cashier_number=4;";
                MySqlCommand cmd10 = new MySqlCommand(query10, con);
                dReader = cmd10.ExecuteReader();
                while (dReader.Read())
                {
                    currentQueueCashier4 = dReader.GetInt32("current_queue_number");
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

        private void ticketForm3_2BackBtn_Click(object sender, EventArgs e)
        {
            TicketForm2_1 tf2_1 = new TicketForm2_1();
            tf2_1.ShowDialog();
            Close();
        }

        public void updateCurrentQueueNumber1()
        {
            String connection = "server=localhost;user id=root; password=root;database=dlsl_app"; // Para magstart yung mysql
            String query = "UPDATE cashier SET current_queue_number ='" + numberOfQueueCashier1 + "' where cashier_number=1;";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dReader;
            con.Open();
            dReader = cmd.ExecuteReader();
            dReader.Close();
        }
        public void updateCurrentQueueNumber2()
        {
            String connection = "server=localhost;user id=root; password=root;database=dlsl_app"; // Para magstart yung mysql
            String query = "UPDATE cashier SET current_queue_number ='" + numberOfQueueCashier2 + "' where cashier_number=2;";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dReader;
            con.Open();
            dReader = cmd.ExecuteReader();
            dReader.Close();
        }
        public void updateCurrentQueueNumber3()
        {
            String connection = "server=localhost;user id=root; password=root;database=dlsl_app"; // Para magstart yung mysql
            String query = "UPDATE cashier SET current_queue_number ='" + numberOfQueueCashier3 + "' where cashier_number=3;";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dReader;
            con.Open();
            dReader = cmd.ExecuteReader();
            dReader.Close();
        }
        public void updateCurrentQueueNumber4()
        {
            String connection = "server=localhost;user id=root; password=root;database=dlsl_app"; // Para magstart yung mysql
            String query = "UPDATE cashier SET current_queue_number ='" + numberOfQueueCashier4 + "' where cashier_number=4;";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dReader;
            con.Open();
            dReader = cmd.ExecuteReader();
            dReader.Close();
        }

        private void ticketForm3_2CollegeBtn_Click(object sender, EventArgs e)
        {
            idHolder++;
            queueNoHolder++;

            String connection = "server=localhost;user id=root; password=root;database=dlsl_app"; // Para magstart yung mysql
            MySqlConnection con = new MySqlConnection(connection);
            MySqlDataReader dReader;
            try
            {
                con.Open();
                if (numberOfQueueCashier1 == numberOfQueueCashier2 || numberOfQueueCashier1 < numberOfQueueCashier2)
                {
                    if (numberOfQueueCashier1 == 0)
                    {
                        numberOfQueueCashier1++;
                        numberOfQueueCashier2 = 0;
                        updateCurrentQueueNumber1();
                        String query = "INSERT INTO service_manual (id, queue_no, cashier_number, queueing_status, service_type ,service_lane) VALUES('" + idHolder + "', '" + numberOfQueueCashier1 + "', '1', 'PENDING', 'COLLEGE', 'PRIORITY')";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        dReader = cmd.ExecuteReader();
                        dReader.Close();
                        String query2 = "UPDATE cashier SET number_of_queue = '" + numberOfQueueCashier1 + "' WHERE cashier_number=1";
                        MySqlCommand cmd2 = new MySqlCommand(query2, con);
                        dReader = cmd2.ExecuteReader();
                    }

                    else
                    {
                        numberOfQueueCashier1++;
                        numberOfQueueCashier2 = 0;
                        String query = "INSERT INTO service_manual (id, queue_no, cashier_number, queueing_status, service_type ,service_lane) VALUES('" + idHolder + "', '" + numberOfQueueCashier1 + "', '1', 'PENDING', 'COLLEGE', 'PRIORITY')";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        dReader = cmd.ExecuteReader();
                        dReader.Close();
                        String query2 = "UPDATE cashier SET number_of_queue = '" + numberOfQueueCashier1 + "' WHERE cashier_number=1";
                        MySqlCommand cmd2 = new MySqlCommand(query2, con);
                        dReader = cmd2.ExecuteReader();
                    }
                }
                else if (numberOfQueueCashier1 > numberOfQueueCashier2)
                {
                    if (numberOfQueueCashier2 == 0)
                    {
                        numberOfQueueCashier2++;
                        numberOfQueueCashier1 = 0;
                        updateCurrentQueueNumber2();
                        String query = "INSERT INTO service_manual (id, queue_no, cashier_number, queueing_status, service_type ,service_lane) VALUES('" + idHolder + "', '" + numberOfQueueCashier2 + "', '2', 'PENDING', 'COLLEGE', 'PRIORITY')";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        dReader = cmd.ExecuteReader();
                        dReader.Close();
                        String query3 = "UPDATE cashier SET number_of_queue = '" + numberOfQueueCashier2 + "' WHERE cashier_number=2";
                        MySqlCommand cmd3 = new MySqlCommand(query3, con);
                        dReader = cmd3.ExecuteReader();
                    }

                    else
                    {
                        numberOfQueueCashier2++;
                        numberOfQueueCashier1 = 0;
                        String query = "INSERT INTO service_manual (id, queue_no, cashier_number, queueing_status, service_type ,service_lane) VALUES('" + idHolder + "', '" + numberOfQueueCashier2 + "', '2', 'PENDING', 'COLLEGE', 'PRIORITY')";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        dReader = cmd.ExecuteReader();
                        dReader.Close();
                        String query3 = "UPDATE cashier SET number_of_queue = '" + numberOfQueueCashier2 + "' WHERE cashier_number=2";
                        MySqlCommand cmd3 = new MySqlCommand(query3, con);
                        dReader = cmd3.ExecuteReader();
                    }
                }

                TicketForm4_3PriorityTicketPrinting tf4_3 = new TicketForm4_3PriorityTicketPrinting();
                tf4_3.ShowDialog();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ticketForm3_2OthersBtn_Click(object sender, EventArgs e)
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
                    if (numberOfQueueCashier3 == 0)
                    {
                        numberOfQueueCashier3++;
                        numberOfQueueCashier4 = 0;
                        updateCurrentQueueNumber3();
                        String query = "INSERT INTO service_manual (id, queue_no, cashier_number, queueing_status, service_type ,service_lane) VALUES('" + idHolder + "', '" + numberOfQueueCashier3 + "', '3', 'PENDING', 'OTHERS', 'PRIORITY')";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        dReader = cmd.ExecuteReader();
                        dReader.Close();
                        String query2 = "UPDATE cashier SET number_of_queue = '" + numberOfQueueCashier3 + "' WHERE cashier_number=3";
                        MySqlCommand cmd2 = new MySqlCommand(query2, con);
                        dReader = cmd2.ExecuteReader();
                    }
                    else
                    {
                        numberOfQueueCashier3++;
                        numberOfQueueCashier4 = 0;
                        String query = "INSERT INTO service_manual (id, queue_no, cashier_number, queueing_status, service_type ,service_lane) VALUES('" + idHolder + "', '" + numberOfQueueCashier3 + "', '3', 'PENDING', 'OTHERS', 'PRIORITY')";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        dReader = cmd.ExecuteReader();
                        dReader.Close();
                        String query2 = "UPDATE cashier SET number_of_queue = '" + numberOfQueueCashier3 + "' WHERE cashier_number=3";
                        MySqlCommand cmd2 = new MySqlCommand(query2, con);
                        dReader = cmd2.ExecuteReader();
                    }
                }
                else if (numberOfQueueCashier3 > numberOfQueueCashier4)
                {
                    if (numberOfQueueCashier4 == 0)
                    {
                        numberOfQueueCashier4++;
                        numberOfQueueCashier3 = 0;
                        updateCurrentQueueNumber4();
                        String query = "INSERT INTO service_manual (id, queue_no, cashier_number, queueing_status, service_type ,service_lane) VALUES('" + idHolder + "', '" + numberOfQueueCashier4 + "', '4', 'PENDING', 'OTHERS', 'PRIORITY')";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        dReader = cmd.ExecuteReader();
                        dReader.Close();
                        String query3 = "UPDATE cashier SET number_of_queue = '" + numberOfQueueCashier4 + "' WHERE cashier_number=4";
                        MySqlCommand cmd3 = new MySqlCommand(query3, con);
                        dReader = cmd3.ExecuteReader();
                    }
                    else
                    {
                        numberOfQueueCashier4++;
                        numberOfQueueCashier3 = 0;
                        String query = "INSERT INTO service_manual (id, queue_no, cashier_number, queueing_status, service_type ,service_lane) VALUES('" + idHolder + "', '" + numberOfQueueCashier4 + "', '4', 'PENDING', 'OTHERS', 'PRIORITY')";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        dReader = cmd.ExecuteReader();
                        dReader.Close();
                        String query3 = "UPDATE cashier SET number_of_queue = '" + numberOfQueueCashier4 + "' WHERE cashier_number=4";
                        MySqlCommand cmd3 = new MySqlCommand(query3, con);
                        dReader = cmd3.ExecuteReader();
                    }
                }

                TicketForm4_4PriorityOtherTicketPrinting tf4_4 = new TicketForm4_4PriorityOtherTicketPrinting();
                tf4_4.ShowDialog();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DLSLQueueingApp
{
    public partial class MonitorUserControl3 : UserControl
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // X-coordinate of upper-left corner or padding at start
            int nTopRect,// Y-coordinate of upper-left corner or padding 
            int nRightRect, // X-coordinate of lower-right corner or Width of the object
            int nBottomRect,// Y-coordinate of lower-right corner or Height of the object
                            //RADIUS, how round do you want it to be?
            int nheightRect, //height of ellipse 
            int nweightRect //width of ellipse
        );
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            Region = Region.FromHrgn(CreateRoundRectRgn(2, 3, Width, Height, 30, 30)); //play with these values till you are happy
        }
        bool isFirst = true;
        int cashierNumber;
        int currentQueueNumber;
        public MonitorUserControl3()
        {
            InitializeComponent();
            cashierLabel.Text = "?";
            queueNumber.Text = "?";
            queueType.Text = "OTHERS";

            String connection = "server=localhost;user id=root; password=root;database=dlsl_app"; // Para magstart yung mysql
            String query = "SELECT cashier_number, queue_no, queueing_status, service_type, service_lane FROM service WHERE cashier_number=3 AND queueing_status='PENDING' UNION SELECT cashier_number, queue_no, queueing_status, service_type, service_lane FROM service_manual WHERE cashier_number = 3 AND queueing_status='PENDING' ORDER BY service_lane = 'PRIORITY' DESC, queue_no ASC; ";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dReader;
            try
            {
                con.Open();
                dReader = cmd.ExecuteReader();
                while (dReader.Read())
                {
                    if (isFirst)
                    {
                        cashierNumber = dReader.GetInt32("cashier_number");
                        cashierLabel.Text = cashierNumber.ToString();
                        currentQueueNumber = dReader.GetInt32("queue_no");
                        queueNumber.Text = currentQueueNumber.ToString();

                        isFirst = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

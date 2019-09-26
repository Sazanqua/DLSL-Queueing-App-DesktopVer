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
        public MonitorUserControl3()
        {
            InitializeComponent();
            cashierLabel.Text = "?";
            queueNumber.Text = "?";
            queueType.Text = "?";

            String connection = "server=localhost;user id=root; password=root;database=dlsl_app"; // Para magstart yung mysql
            String query = "SELECT * FROM cashier WHERE id=3";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dReader;
            try
            {
                con.Open();
                dReader = cmd.ExecuteReader();
                while (dReader.Read())
                {
                    int cashierNumber = dReader.GetInt32("cashier_number");
                    cashierLabel.Text = cashierNumber.ToString();
                    int currentQueueNumber = dReader.GetInt32("current_queue_number");
                    queueNumber.Text = currentQueueNumber.ToString();
                    String cashierType = dReader.GetString("cashier_type");
                    queueType.Text = cashierType;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

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
    public partial class QueueingForm : Form
    {
        public QueueingForm()
        {
            InitializeComponent();
        }
        int queueno;
        int queueno_temp;
        private void QueueingForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false; // Disable Maximize button
            nextQueueBtn.BackColor = ColorTranslator.FromHtml("#146344");
            refreshBtn.BackColor = ColorTranslator.FromHtml("#146344");
            loadData();
            disableButton();
        }
        public void disableButton()
        {
            if (dataGridView1.Rows.Count == 0)
            {
                nextQueueBtn.BackColor = ColorTranslator.FromHtml("#cccccc");
                nextQueueBtn.Enabled = false;
            }
            else
            {
                nextQueueBtn.BackColor = ColorTranslator.FromHtml("#146344");
                nextQueueBtn.Enabled = true;
            }
        }
        public void loadData(){
            String connection = "server=localhost;user id=root; password=root;database=dlsl_app"; // Para magstart yung mysql
            String query = "SELECT queue_no, queueing_status, service_type, service_lane FROM service WHERE cashier_number=1 AND queueing_status='PENDING' UNION SELECT queue_no, queueing_status, service_type, service_lane FROM service_manual WHERE cashier_number = 1 AND queueing_status='PENDING' ORDER BY service_lane = 'PRIORITY' DESC, queue_no ASC; ";

            using (MySqlConnection sqlCon = new MySqlConnection(connection))
            {
                sqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter(query, sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                dataGridView1.ClearSelection();
            }
            dataGridView1.AllowUserToAddRows = false;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Columns[0].HeaderText = "Queue Number";
            dataGridView1.Columns[1].HeaderText = "Queueing Status";
            dataGridView1.Columns[2].HeaderText = "Service Type";
            dataGridView1.Columns[3].HeaderText = "Service Lane";
            
            if (dataGridView1.Rows.Count == 0)
            {
                queueno = 0;
            }
            else
            {
                queueno = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value.ToString());
                queueno_temp = queueno;
            }
        }

        public void updateCurrentQueueNumber()
        {
            String connection = "server=localhost;user id=root; password=root;database=dlsl_app"; // Para magstart yung mysql
            String query = "UPDATE cashier SET current_queue_number ='" + queueno + "' where cashier_number=1;";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dReader;
            con.Open();
            dReader = cmd.ExecuteReader();
            dReader.Close();

            if (queueno == 0)
            {
                String query2 = "UPDATE cashier SET current_queue_number ='" + queueno_temp + "' where cashier_number=1;";
                MySqlConnection con2 = new MySqlConnection(connection);
                MySqlCommand cmd2 = new MySqlCommand(query2, con2);
                con2.Open();
                dReader = cmd2.ExecuteReader();
                dReader.Close();
            }
        }

        private void nextQueueBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("CURRENT QUEUE NUMBER IS "+ queueno + " \nARE YOU SURE TO CHANGE QUEUE NUMBER?", "Change Queue", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                String connection = "server=localhost;user id=root; password=root;database=dlsl_app"; // Para magstart yung mysql
                String query = "UPDATE service_manual SET queueing_status = 'DONE' where queue_no='" + queueno + "' AND cashier_number=1;";
                String query2 = "UPDATE service SET queueing_status = 'DONE' where queue_no='" + queueno + "' AND cashier_number=1;";
                MySqlConnection con = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlCommand cmd2= new MySqlCommand(query2, con);
                MySqlDataReader dReader;
                MySqlDataReader dReader2;
                con.Open();
                dReader = cmd.ExecuteReader();
                dReader.Close();
                dReader2 = cmd2.ExecuteReader();
                dReader2.Close();
                loadData();
                disableButton();
                updateCurrentQueueNumber();
            }
            else if (dialogResult == DialogResult.No)
            {
                loadData();
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            loadData();
            disableButton();
        }
    }
}

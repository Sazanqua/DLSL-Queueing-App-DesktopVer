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
    public partial class QueueingFormMain : Form
    {
        public QueueingFormMain()
        {
            InitializeComponent();
        }
        int filterCashierChoice=0;
        string filterServiceTypeChoice="";
        public void filterByCashier()
        {
            String connection = "server=localhost;user id=root; password=root;database=dlsl_app"; // Para magstart yung mysql
            String query;

            if(filterServiceTypeChoice == "")
            {
                query = "SELECT queue_no, queueing_status, service_type, service_lane, cashier_number FROM service WHERE cashier_number='" + filterCashierChoice + "' UNION SELECT queue_no, queueing_status, service_type, service_lane, cashier_number FROM service_manual WHERE cashier_number = '" + filterCashierChoice + "' ORDER BY queue_no ASC; ";
            }
            else
            {
                query = "SELECT queue_no, queueing_status, service_type, service_lane, cashier_number FROM service WHERE cashier_number='" + filterCashierChoice + "' AND service_type='"+ filterServiceTypeChoice + "' UNION SELECT queue_no, queueing_status, service_type, service_lane, cashier_number FROM service_manual WHERE cashier_number = '" + filterCashierChoice + "' AND service_type='" + filterServiceTypeChoice + "' ORDER BY queue_no ASC; ";
            }

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
            dataGridView1.Columns[4].HeaderText = "Cashier Number";
        }
        public void filterByServiceType()
        {
            String connection = "server=localhost;user id=root; password=root;database=dlsl_app"; // Para magstart yung mysql
            String query;

            if (filterCashierChoice == 0)
            {
                query = "SELECT queue_no, queueing_status, service_type, service_lane, cashier_number FROM service WHERE service_type='" + filterServiceTypeChoice + "' UNION SELECT queue_no, queueing_status, service_type, service_lane, cashier_number FROM service_manual WHERE service_type='" + filterServiceTypeChoice + "' ORDER BY queue_no ASC;";
            }
            else
            {
                query = "SELECT queue_no, queueing_status, service_type, service_lane, cashier_number FROM service WHERE cashier_number='" + filterCashierChoice + "' AND service_type='" + filterServiceTypeChoice + "' UNION SELECT queue_no, queueing_status, service_type, service_lane, cashier_number FROM service_manual WHERE cashier_number = '" + filterCashierChoice + "' AND service_type='" + filterServiceTypeChoice + "' ORDER BY queue_no ASC; ";
            }

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
            dataGridView1.Columns[4].HeaderText = "Cashier Number";
        }
        public void loadData()
        {
            String connection = "server=localhost;user id=root; password=root;database=dlsl_app"; // Para magstart yung mysql
            String query;

            if (filterCashierChoice == 0 && filterServiceTypeChoice == "")
            {
                query = "SELECT queue_no, queueing_status, service_type, service_lane, cashier_number FROM service UNION SELECT queue_no, queueing_status, service_type, service_lane, cashier_number FROM service_manual ORDER BY cashier_number ASC, queue_no ASC;";
            }
            else if (filterCashierChoice == 0)
            {
                query = "SELECT queue_no, queueing_status, service_type, service_lane, cashier_number FROM service WHERE service_type='" + filterServiceTypeChoice + "' UNION SELECT queue_no, queueing_status, service_type, service_lane, cashier_number FROM service_manual WHERE service_type='" + filterServiceTypeChoice + "' ORDER BY queue_no ASC;";
            }
            else if (filterServiceTypeChoice == "")
            {
                query = "SELECT queue_no, queueing_status, service_type, service_lane, cashier_number FROM service WHERE cashier_number='" + filterCashierChoice + "' UNION SELECT queue_no, queueing_status, service_type, service_lane, cashier_number FROM service_manual WHERE cashier_number = '" + filterCashierChoice + "' ORDER BY queue_no ASC; ";
            }
            else
            {
                query = "SELECT queue_no, queueing_status, service_type, service_lane, cashier_number FROM service WHERE cashier_number='" + filterCashierChoice + "' AND service_type='" + filterServiceTypeChoice + "' UNION SELECT queue_no, queueing_status, service_type, service_lane, cashier_number FROM service_manual WHERE cashier_number = '" + filterCashierChoice + "' AND service_type='" + filterServiceTypeChoice + "' ORDER BY queue_no ASC; ";

            }

            using (MySqlConnection sqlCon = new MySqlConnection(connection))
            {
                sqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter(query, sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                dataGridView1.ClearSelection();
                sqlCon.Close();
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
            dataGridView1.Columns[4].HeaderText = "Cashier Number";
        }
        public void cashierSearch()
        {
            var dataSource = new List<Cashier>();
            dataSource.Add(new Cashier() { Name = "---", Value = "---" });
            dataSource.Add(new Cashier() { Name = "Cashier 1", Value = "Cashier 1" });
            dataSource.Add(new Cashier() { Name = "Cashier 2", Value = "Cashier 2" });
            dataSource.Add(new Cashier() { Name = "Cashier 3", Value = "Cashier 3" });
            dataSource.Add(new Cashier() { Name = "Cashier 4", Value = "Cashier 4" });
            
            comboBox1.DataSource = dataSource;
            comboBox1.DisplayMember = "Cashier";
            comboBox1.ValueMember = "Value";
        }
        public void serviceTypeSearch()
        {
            var dataSource = new List<Cashier>();
            dataSource.Add(new Cashier() { Name = "---", Value = "---" });
            dataSource.Add(new Cashier() { Name = "College", Value = "College" });
            dataSource.Add(new Cashier() { Name = "Others", Value = "Others" });

            filter2cb.DataSource = dataSource;
            filter2cb.DisplayMember = "Service Type";
            filter2cb.ValueMember = "Value";
        }

        public class Cashier
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        private void QueueingFormMain_Load(object sender, EventArgs e)
        {
            MaximizeBox = false; // Disable Maximize button
            refreshBtn.BackColor = ColorTranslator.FromHtml("#146344");
            
            cashierSearch();
            serviceTypeSearch();

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cashier 1")
            {
                filterCashierChoice = 1;
                filterByCashier();
            }
            else if (comboBox1.Text == "Cashier 2")
            {
                filterCashierChoice = 2;
                filterByCashier();
            }
            else if (comboBox1.Text == "Cashier 3")
            {
                filterCashierChoice = 3;
                filterByCashier();
            }
            else if (comboBox1.Text == "Cashier 4")
            {
                filterCashierChoice = 4;
                filterByCashier();
            }
            else if (comboBox1.Text == "---")
            {
                filterCashierChoice = 0;
                loadData();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cashier 1")
            {
                filterCashierChoice = 1;
                filterByCashier();
            }
            else if (comboBox1.Text == "Cashier 2")
            {
                filterCashierChoice = 2;
                filterByCashier();
            }
            else if (comboBox1.Text == "Cashier 3")
            {
                filterCashierChoice = 3;
                filterByCashier();
            }
            else if (comboBox1.Text == "Cashier 4")
            {
                filterCashierChoice = 4;
                filterByCashier();
            }
            else if (comboBox1.Text == "---")
            {
                filterCashierChoice = 0;
                loadData();
            }
        }

        private void filter2cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filter2cb.Text == "---")
            {
                filterServiceTypeChoice = "";
                loadData();
            }
            else if (filter2cb.Text == "College")
            {
                filterServiceTypeChoice = "COLLEGE";
                filterByServiceType();
            }
            else if (filter2cb.Text == "Others")
            {
                filterServiceTypeChoice = "OTHERS";
                filterByServiceType();
            }
        }
    }
}

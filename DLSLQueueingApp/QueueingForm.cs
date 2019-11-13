using MySql.Data.MySqlClient;
using Newtonsoft.Json;
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
    public partial class QueueingForm : Form
    {
        public QueueingForm()
        {
            InitializeComponent();
        }
        private static readonly HttpClient client = new HttpClient();

        String totalNumberOfQueue;

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
            //if (dataGridView1.Rows.Count == 0)
            //{
            //    nextQueueBtn.BackColor = ColorTranslator.FromHtml("#cccccc");
            //    nextQueueBtn.Enabled = false;
            //}
            //else
            //{
            //    nextQueueBtn.BackColor = ColorTranslator.FromHtml("#146344");
            //    nextQueueBtn.Enabled = true;
            //}
        }


        public async void loadData(){
            HttpResponseMessage queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/fetchCashier1TotalQueueData.php");
            var responseString3 = await queueData.Content.ReadAsStringAsync();
            String data = responseString3;
            ServiceClass[] collection = JsonConvert.DeserializeObject<ServiceClass []>(data);
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("Queue Number");
            dtbl.Columns.Add("Queueing Status");
            dtbl.Columns.Add("Service Type");
            dtbl.Columns.Add("Service Lane");
            foreach (ServiceClass service in collection)
            {
                dtbl.Rows.Add(service.queue_no, service.queueing_status, service.type_of_queue, service.service_lane);
            }
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridView1.DataSource = dtbl;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToResizeRows = false;
            
        }

        public async void updateCurrentQueueNumber()
        {
            HttpResponseMessage totalQueueNumberResponse = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/fetchCashier1TotalNumber.php");
            var responseString = await totalQueueNumberResponse.Content.ReadAsStringAsync();
            totalNumberOfQueue = responseString;

            int i = 1;
            int convertedTotalNumberOfQueue = Int32.Parse(totalNumberOfQueue);
            if (i <= convertedTotalNumberOfQueue)
            {

                //var data3RD = new { queueNo = 3 };
                var data = new { queueNo = i };
                var json = JsonConvert.SerializeObject(data);
                var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
                HttpResponseMessage queueingStatusResponse = await client.PostAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/.updateQueueViaNo.php", stringContent);
                
                i++;

            }




            //var data3rd = new { queueno = 3 };
            //var data = new { queueno = queueno };
            //var json = jsonconvert.serializeobject(data);
            //var stringcontent = new stringcontent(json, unicodeencoding.utf8, "application/json");
            //httpresponsemessage queueingstatusresponse = await client.postasync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/.updatequeueviano.php", stringcontent);
            //messagebox.show(data3rd.tostring());


            //String connection = "server=localhost;user id=root; password=root;database=dlsl_app"; // Para magstart yung mysql
            //String query = "UPDATE cashier SET current_queue_number ='" + queueno + "' where cashier_number=1;";
            //MySqlConnection con = new MySqlConnection(connection);
            //MySqlCommand cmd = new MySqlCommand(query, con);
            //MySqlDataReader dReader;
            //con.Open();
            //dReader = cmd.ExecuteReader();
            //dReader.Close();

            //if (queueno == 0)
            //{
            //    String query2 = "UPDATE cashier SET current_queue_number ='" + queueno_temp + "' where cashier_number=1;";
            //    MySqlConnection con2 = new MySqlConnection(connection);
            //    MySqlCommand cmd2 = new MySqlCommand(query2, con2);
            //    con2.Open();
            //    dReader = cmd2.ExecuteReader();
            //    dReader.Close();
            //}
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

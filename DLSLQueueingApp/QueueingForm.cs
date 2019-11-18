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
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridView1.DataSource = dtbl;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToResizeRows = false;
            if (collection == null)
            {
                
            }
            else
            {
                foreach (ServiceClass service in collection)
                {
                    dtbl.Rows.Add(service.queue_no, service.queueing_status, service.type_of_queue, service.service_lane);
                }
            }
            loadData();
            disableButton();
        }

        public async void updateCurrentQueueNumber()
        {
            HttpResponseMessage updateResponse = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/cashier1_updateQueueViaNo.php");
            var ur = await updateResponse.Content.ReadAsStringAsync();
        }

        private void nextQueueBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE TO CHANGE QUEUE NUMBER?", "Change Queue", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
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

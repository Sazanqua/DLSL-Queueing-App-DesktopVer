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
    public partial class MonitoringForm : Form
    {
        public MonitoringForm()
        {
            InitializeComponent();
            
        }
        private static readonly HttpClient client = new HttpClient();
        private async void MonitoringForm_Load(object sender, EventArgs e)
        {
            TopMost = true; // Para fullscreen
            FormBorderStyle = FormBorderStyle.None; // Para fullscreen
            WindowState = FormWindowState.Maximized; // Para fullscreen
            timer1.Start();
            data_cashier1();
            data_cashier2();
            data_cashier3();
            data_cashier4();
        }

        public async void data_cashier1()
        {
            HttpResponseMessage queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/1_Cashier_Monitor.php");
            var responseString = await queueData.Content.ReadAsStringAsync();
            String data = responseString;
            ServiceClass[] collection = JsonConvert.DeserializeObject<ServiceClass[]>(data);
            if (collection == null)
            {
                cashierNumber_1.Text = "1";
                queueNumber_1.Text = "";
                serviceLane_1.Text = "";
                serviceType_1.Text = "";
            }
            else
            {
                foreach (ServiceClass service in collection)
                {
                    cashierNumber_1.Text = service.cashier_number.ToString();
                    queueNumber_1.Text = service.queue_no.ToString();
                    serviceLane_1.Text = service.service_lane.ToString();
                    serviceType_1.Text = service.service_type.ToString();
                }
                if (serviceLane_1.Text.Contains("PRIORITY"))
                {
                    serviceLane_1.ForeColor = Color.Red;
                }
                time_C1.Text = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            }
        }
        public async void data_cashier2()
        {
            HttpResponseMessage queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/2_Cashier_Monitor.php");
            var responseString = await queueData.Content.ReadAsStringAsync();
            String data = responseString;
            ServiceClass[] collection = JsonConvert.DeserializeObject<ServiceClass[]>(data);
            if (collection == null)
            {
                cashierNumber_2.Text = "2";
                queueNumber_2.Text = "";
                serviceLane_2.Text = "";
                serviceType_2.Text = "";
            }
            else
            {
                foreach (ServiceClass service in collection)
                {
                    cashierNumber_2.Text = service.cashier_number.ToString();
                    queueNumber_2.Text = service.queue_no.ToString();
                    serviceLane_2.Text = service.service_lane.ToString();
                    serviceType_2.Text = service.service_type.ToString();
                }
                if (serviceLane_2.Text.Contains("PRIORITY"))
                {
                    serviceLane_2.ForeColor = Color.Red;
                }
                time_C1.Text = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            }
        }
        public async void data_cashier3()
        {
            HttpResponseMessage queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/3_Cashier_Monitor.php");
            var responseString = await queueData.Content.ReadAsStringAsync();
            String data = responseString;
            ServiceClass[] collection = JsonConvert.DeserializeObject<ServiceClass[]>(data);
            if (collection == null)
            {
                cashierNumber_3.Text = "3";
                queueNumber_3.Text = "";
                serviceLane_3.Text = "";
                serviceType_3.Text = "";
            }
            else
            {
                foreach (ServiceClass service in collection)
                {
                    cashierNumber_3.Text = service.cashier_number.ToString();
                    queueNumber_3.Text = service.queue_no.ToString();
                    serviceLane_3.Text = service.service_lane.ToString();
                    serviceType_3.Text = service.service_type.ToString();
                }
                if (serviceLane_3.Text.Contains("PRIORITY"))
                {
                    serviceLane_3.ForeColor = Color.Red;
                }
                time_C1.Text = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            }
        }
        public async void data_cashier4()
        {
            HttpResponseMessage queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/4_Cashier_Monitor.php");
            var responseString = await queueData.Content.ReadAsStringAsync();
            String data = responseString;
            ServiceClass[] collection = JsonConvert.DeserializeObject<ServiceClass[]>(data);
            if (collection == null)
            {
                cashierNumber_4.Text = "4";
                queueNumber_4.Text = "";
                serviceLane_4.Text = "";
                serviceType_4.Text = "";
            }
            else
            {
                foreach (ServiceClass service in collection)
                {
                    cashierNumber_4.Text = service.cashier_number.ToString();
                    queueNumber_4.Text = service.queue_no.ToString();
                    serviceLane_4.Text = service.service_lane.ToString();
                    serviceType_4.Text = service.service_type.ToString();
                }
                if (serviceLane_4.Text.Contains("PRIORITY"))
                {
                    serviceLane_4.ForeColor = Color.Red;
                }
                time_C1.Text = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            }
        }

        private void MonitoringForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // Esc to close program
            {
                Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}

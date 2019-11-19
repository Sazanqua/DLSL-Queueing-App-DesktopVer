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
        HttpResponseMessage queueData;
        private async void MonitoringForm_Load(object sender, EventArgs e)
        {
            Refresh();
            TopMost = true; // Para fullscreen
            FormBorderStyle = FormBorderStyle.None; // Para fullscreen
            WindowState = FormWindowState.Maximized; // Para fullscreen
            timer1.Start();
            cashierNumber_1.Text = "1";
            queueNumber_1.Text = "";
            serviceType_1.Text = "";
            serviceLane_1.Text = "";
            cashierNumber_2.Text = "2";
            queueNumber_2.Text = "";
            serviceType_2.Text = "";
            serviceLane_2.Text = "";

            cashierNumber_3.Text = "3";
            queueNumber_3.Text = "";
            serviceType_3.Text = "";
            serviceLane_3.Text = "";

            cashierNumber_4.Text = "4";
            queueNumber_4.Text = "";
            serviceType_4.Text = "";
            serviceLane_4.Text = "";

            c1_QueueNumber_1.Text = "";
            c1_QueueNumber_2.Text = "";
            c1_QueueNumber_3.Text = "";
            c1_QueueNumber_4.Text = "";
            c1_QueueNumber_5.Text = "";
            c1_ServiceLane_1.Text = "";
            c1_ServiceLane_2.Text = "";
            c1_ServiceLane_3.Text = "";
            c1_ServiceLane_4.Text = "";
            c1_ServiceLane_5.Text = "";

            c2_QueueNumber_1.Text = "";
            c2_QueueNumber_2.Text = "";
            c2_QueueNumber_3.Text = "";
            c2_QueueNumber_4.Text = "";
            c2_QueueNumber_5.Text = "";
            c2_ServiceLane_1.Text = "";
            c2_ServiceLane_2.Text = "";
            c2_ServiceLane_3.Text = "";
            c2_ServiceLane_4.Text = "";
            c2_ServiceLane_5.Text = "";

            c3_QueueNumber_1.Text = "";
            c3_QueueNumber_2.Text = "";
            c3_QueueNumber_3.Text = "";
            c3_QueueNumber_4.Text = "";
            c3_QueueNumber_5.Text = "";
            c3_ServiceLane_1.Text = "";
            c3_ServiceLane_2.Text = "";
            c3_ServiceLane_3.Text = "";
            c3_ServiceLane_4.Text = "";
            c3_ServiceLane_5.Text = "";

            c4_QueueNumber_1.Text = "";
            c4_QueueNumber_2.Text = "";
            c4_QueueNumber_3.Text = "";
            c4_QueueNumber_4.Text = "";
            c4_QueueNumber_5.Text = "";
            c4_ServiceLane_1.Text = "";
            c4_ServiceLane_2.Text = "";
            c4_ServiceLane_3.Text = "";
            c4_ServiceLane_4.Text = "";
            c4_ServiceLane_5.Text = "";

            //time_C1.Text = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            //time_C2.Text = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            //time_C3.Text = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            //time_C4.Text = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        public void loadData()
        {
            cashier1_nextQueue1();
            cashier1_nextQueue2();
            cashier1_nextQueue3();
            cashier1_nextQueue4();
            cashier1_nextQueue5();

            cashier2_nextQueue1();
            cashier2_nextQueue2();
            cashier2_nextQueue3();
            cashier2_nextQueue4();
            cashier2_nextQueue5();

            cashier3_nextQueue1();
            cashier3_nextQueue2();
            cashier3_nextQueue3();
            cashier3_nextQueue4();
            cashier3_nextQueue5();

            cashier4_nextQueue1();
            cashier4_nextQueue2();
            cashier4_nextQueue3();
            cashier4_nextQueue4();
            cashier4_nextQueue5();
        }

        public async void data_cashier1()
        {
            try
            {
                queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/1_Cashier_Monitor.php");
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
                    if (serviceLane_1.Text.Contains("REGULAR"))
                    {
                        serviceLane_1.ForeColor = Color.Black;
                    }

                }
            }
            catch (TaskCanceledException e)
            {
                Console.WriteLine("Exception Caught! Message :{0} ", e.Message);
            }
        }
        public async void data_cashier2()
        {
            try
            {
                queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/2_Cashier_Monitor.php");
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
                    if (serviceLane_2.Text.Contains("REGULAR"))
                    {
                        serviceLane_2.ForeColor = Color.Black;
                    }

                }
            }
            catch (TaskCanceledException e)
            {
                Console.WriteLine("Exception Caught! Message :{0} ", e.Message);
            }
        }
        public async void data_cashier3()
        {
            try
            {
                queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/3_Cashier_Monitor.php");
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
                    if (serviceLane_3.Text.Contains("REGULAR"))
                    {
                        serviceLane_3.ForeColor = Color.Black;
                    }

                }
            }
            catch (TaskCanceledException e)
            {
                Console.WriteLine("Exception Caught! Message :{0} ", e.Message);
            }
        }
        public async void data_cashier4()
        {
            try
            {
                queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/4_Cashier_Monitor.php");
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
                    if (serviceLane_4.Text.Contains("REGULAR"))
                    {
                        serviceLane_4.ForeColor = Color.Black;
                    }

                }
            }
            catch (TaskCanceledException e)
            {
                Console.WriteLine("Exception Caught! Message :{0} ", e.Message);
            }
        }
        //CASHIER 1 NEXT QUEUE//
        public async void cashier1_nextQueue1()
        {
            try
            {
                queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/MonitoringDisplay/1_Cashier_NextQueue1.php");
                var responseString = await queueData.Content.ReadAsStringAsync();
                String data = responseString;
                ServiceClass[] collection = JsonConvert.DeserializeObject<ServiceClass[]>(data);
                if (collection == null)
                {
                    c1_QueueNumber_1.Text = "";
                    c1_ServiceLane_1.Text = "";
                }
                else
                {
                    foreach (ServiceClass service in collection)
                    {
                        c1_QueueNumber_1.Text = service.queue_no.ToString();
                        c1_ServiceLane_1.Text = service.service_lane.ToString();
                    }
                    if (c1_ServiceLane_1.Text.Contains("PRIORITY"))
                    {
                        c1_ServiceLane_1.ForeColor = Color.Red;
                    }
                    if (c1_ServiceLane_1.Text.Contains("REGULAR"))
                    {
                        c1_ServiceLane_1.ForeColor = Color.Black;
                    }
                }
            }
            catch (TaskCanceledException e)
            {
                Console.WriteLine("Exception Caught! Message :{0} ", e.Message);
            }
        }
        public async void cashier1_nextQueue2()
        {
            try
            {
                queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/MonitoringDisplay/1_Cashier_NextQueue2.php");
                var responseString = await queueData.Content.ReadAsStringAsync();
                String data = responseString;
                ServiceClass[] collection = JsonConvert.DeserializeObject<ServiceClass[]>(data);
                if (collection == null)
                {
                    c1_QueueNumber_2.Text = "";
                    c1_ServiceLane_2.Text = "";
                }
                else
                {
                    foreach (ServiceClass service in collection)
                    {
                        c1_QueueNumber_2.Text = service.queue_no.ToString();
                        c1_ServiceLane_2.Text = service.service_lane.ToString();
                    }
                    if (c1_ServiceLane_2.Text.Contains("PRIORITY"))
                    {
                        c1_ServiceLane_2.ForeColor = Color.Red;
                    }
                    if (c1_ServiceLane_2.Text.Contains("REGULAR"))
                    {
                        c1_ServiceLane_2.ForeColor = Color.Black;
                    }
                }
            }
            catch (TaskCanceledException e)
            {
                Console.WriteLine("Exception Caught! Message :{0} ", e.Message);
            }
        }
        public async void cashier1_nextQueue3()
        {
            try
            {
                queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/MonitoringDisplay/1_Cashier_NextQueue3.php");
                var responseString = await queueData.Content.ReadAsStringAsync();
                String data = responseString;
                ServiceClass[] collection = JsonConvert.DeserializeObject<ServiceClass[]>(data);
                if (collection == null)
                {
                    c1_QueueNumber_3.Text = "";
                    c1_ServiceLane_3.Text = "";
                }
                else
                {
                    foreach (ServiceClass service in collection)
                    {
                        c1_QueueNumber_3.Text = service.queue_no.ToString();
                        c1_ServiceLane_3.Text = service.service_lane.ToString();
                    }
                    if (c1_ServiceLane_3.Text.Contains("PRIORITY"))
                    {
                        c1_ServiceLane_3.ForeColor = Color.Red;
                    }
                    if (c1_ServiceLane_3.Text.Contains("REGULAR"))
                    {
                        c1_ServiceLane_3.ForeColor = Color.Black;
                    }
                }
            }
            catch (TaskCanceledException e)
            {
                Console.WriteLine("Exception Caught! Message :{0} ", e.Message);
            }
        }
        public async void cashier1_nextQueue4()
        {
            try
            {
                queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/MonitoringDisplay/1_Cashier_NextQueue4.php");
                var responseString = await queueData.Content.ReadAsStringAsync();
                String data = responseString;
                ServiceClass[] collection = JsonConvert.DeserializeObject<ServiceClass[]>(data);
                if (collection == null)
                {
                    c1_QueueNumber_4.Text = "";
                    c1_ServiceLane_4.Text = "";
                }
                else
                {
                    foreach (ServiceClass service in collection)
                    {
                        c1_QueueNumber_4.Text = service.queue_no.ToString();
                        c1_ServiceLane_4.Text = service.service_lane.ToString();
                    }
                    if (c1_ServiceLane_4.Text.Contains("PRIORITY"))
                    {
                        c1_ServiceLane_4.ForeColor = Color.Red;
                    }
                    if (c1_ServiceLane_4.Text.Contains("REGULAR"))
                    {
                        c1_ServiceLane_4.ForeColor = Color.Black;
                    }
                }
            }
            catch (TaskCanceledException e)
            {
                Console.WriteLine("Exception Caught! Message :{0} ", e.Message);
            }
        }
        public async void cashier1_nextQueue5()
        {
            try
            {
                queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/MonitoringDisplay/1_Cashier_NextQueue5.php");
                var responseString = await queueData.Content.ReadAsStringAsync();
                String data = responseString;
                ServiceClass[] collection = JsonConvert.DeserializeObject<ServiceClass[]>(data);
                if (collection == null)
                {
                    c1_QueueNumber_5.Text = "";
                    c1_ServiceLane_5.Text = "";
                }
                else
                {
                    foreach (ServiceClass service in collection)
                    {
                        c1_QueueNumber_5.Text = service.queue_no.ToString();
                        c1_ServiceLane_5.Text = service.service_lane.ToString();
                    }
                    if (c1_ServiceLane_5.Text.Contains("PRIORITY"))
                    {
                        c1_ServiceLane_5.ForeColor = Color.Red;
                    }
                    if (c1_ServiceLane_5.Text.Contains("REGULAR"))
                    {
                        c1_ServiceLane_5.ForeColor = Color.Black;
                    }
                }
            }
            catch (TaskCanceledException e)
            {
                Console.WriteLine("Exception Caught! Message :{0} ", e.Message);
            }
        }
        // CASHIER 2 NEXT QUEUE //
        public async void cashier2_nextQueue1()
        {
            try
            {
                queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/MonitoringDisplay/2_Cashier_NextQueue1.php");
                var responseString = await queueData.Content.ReadAsStringAsync();
                String data = responseString;
                ServiceClass[] collection = JsonConvert.DeserializeObject<ServiceClass[]>(data);
                if (collection == null)
                {
                    c2_QueueNumber_1.Text = "";
                    c2_ServiceLane_1.Text = "";
                }
                else
                {
                    foreach (ServiceClass service in collection)
                    {
                        c2_QueueNumber_1.Text = service.queue_no.ToString();
                        c2_ServiceLane_1.Text = service.service_lane.ToString();
                    }
                    if (c2_ServiceLane_1.Text.Contains("PRIORITY"))
                    {
                        c2_ServiceLane_1.ForeColor = Color.Red;
                    }
                    if (c2_ServiceLane_1.Text.Contains("REGULAR"))
                    {
                        c2_ServiceLane_1.ForeColor = Color.Black;
                    }
                }
            }
            catch (TaskCanceledException e)
            {
                Console.WriteLine("Exception Caught! Message :{0} ", e.Message);
            }
        }
        public async void cashier2_nextQueue2()
        {
            try
            {
                queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/MonitoringDisplay/2_Cashier_NextQueue2.php");
                var responseString = await queueData.Content.ReadAsStringAsync();
                String data = responseString;
                ServiceClass[] collection = JsonConvert.DeserializeObject<ServiceClass[]>(data);
                if (collection == null)
                {
                    c2_QueueNumber_2.Text = "";
                    c2_ServiceLane_2.Text = "";
                }
                else
                {
                    foreach (ServiceClass service in collection)
                    {
                        c2_QueueNumber_2.Text = service.queue_no.ToString();
                        c2_ServiceLane_2.Text = service.service_lane.ToString();
                    }
                    if (c2_ServiceLane_2.Text.Contains("PRIORITY"))
                    {
                        c2_ServiceLane_2.ForeColor = Color.Red;
                    }
                    if (c2_ServiceLane_2.Text.Contains("REGULAR"))
                    {
                        c2_ServiceLane_2.ForeColor = Color.Black;
                    }
                }
            }
            catch (TaskCanceledException e)
            {
                Console.WriteLine("Exception Caught! Message :{0} ", e.Message);
            }
        }
        public async void cashier2_nextQueue3()
        {
            try
            {
                queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/MonitoringDisplay/2_Cashier_NextQueue3.php");
                var responseString = await queueData.Content.ReadAsStringAsync();
                String data = responseString;
                ServiceClass[] collection = JsonConvert.DeserializeObject<ServiceClass[]>(data);
                if (collection == null)
                {
                    c2_QueueNumber_3.Text = "";
                    c2_ServiceLane_3.Text = "";
                }
                else
                {
                    foreach (ServiceClass service in collection)
                    {
                        c2_QueueNumber_3.Text = service.queue_no.ToString();
                        c2_ServiceLane_3.Text = service.service_lane.ToString();
                    }
                    if (c2_ServiceLane_3.Text.Contains("PRIORITY"))
                    {
                        c2_ServiceLane_3.ForeColor = Color.Red;
                    }
                    if (c2_ServiceLane_3.Text.Contains("REGULAR"))
                    {
                        c2_ServiceLane_3.ForeColor = Color.Black;
                    }
                }
            }
            catch (TaskCanceledException e)
            {
                Console.WriteLine("Exception Caught! Message :{0} ", e.Message);
            }
        }
        public async void cashier2_nextQueue4()
        {
            try
            {
                queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/MonitoringDisplay/2_Cashier_NextQueue4.php");
                var responseString = await queueData.Content.ReadAsStringAsync();
                String data = responseString;
                ServiceClass[] collection = JsonConvert.DeserializeObject<ServiceClass[]>(data);
                if (collection == null)
                {
                    c2_QueueNumber_4.Text = "";
                    c2_ServiceLane_4.Text = "";
                }
                else
                {
                    foreach (ServiceClass service in collection)
                    {
                        c2_QueueNumber_4.Text = service.queue_no.ToString();
                        c2_ServiceLane_4.Text = service.service_lane.ToString();
                    }
                    if (c2_ServiceLane_4.Text.Contains("PRIORITY"))
                    {
                        c2_ServiceLane_4.ForeColor = Color.Red;
                    }
                    if (c2_ServiceLane_4.Text.Contains("REGULAR"))
                    {
                        c2_ServiceLane_4.ForeColor = Color.Black;
                    }
                }
            }
            catch (TaskCanceledException e)
            {
                Console.WriteLine("Exception Caught! Message :{0} ", e.Message);
            }
        }
        public async void cashier2_nextQueue5()
        {
            try
            {
                queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/MonitoringDisplay/2_Cashier_NextQueue5.php");
                var responseString = await queueData.Content.ReadAsStringAsync();
                String data = responseString;
                ServiceClass[] collection = JsonConvert.DeserializeObject<ServiceClass[]>(data);
                if (collection == null)
                {
                    c2_QueueNumber_5.Text = "";
                    c2_ServiceLane_5.Text = "";
                }
                else
                {
                    foreach (ServiceClass service in collection)
                    {
                        c2_QueueNumber_5.Text = service.queue_no.ToString();
                        c2_ServiceLane_5.Text = service.service_lane.ToString();
                    }
                    if (c2_ServiceLane_5.Text.Contains("PRIORITY"))
                    {
                        c2_ServiceLane_5.ForeColor = Color.Red;
                    }
                    if (c2_ServiceLane_5.Text.Contains("REGULAR"))
                    {
                        c2_ServiceLane_5.ForeColor = Color.Black;
                    }
                }
            }
            catch (TaskCanceledException e)
            {
                Console.WriteLine("Exception Caught! Message :{0} ", e.Message);
            }
        }
        // CASHIER 3 NEXT QUEUE //
        public async void cashier3_nextQueue1()
        {
            try
            {
                queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/MonitoringDisplay/3_Cashier_NextQueue1.php");
                var responseString = await queueData.Content.ReadAsStringAsync();
                String data = responseString;
                ServiceClass[] collection = JsonConvert.DeserializeObject<ServiceClass[]>(data);
                if (collection == null)
                {
                    c3_QueueNumber_1.Text = "";
                    c3_ServiceLane_1.Text = "";
                }
                else
                {
                    foreach (ServiceClass service in collection)
                    {
                        c3_QueueNumber_1.Text = service.queue_no.ToString();
                        c3_ServiceLane_1.Text = service.service_lane.ToString();
                    }
                    if (c3_ServiceLane_1.Text.Contains("PRIORITY"))
                    {
                        c3_ServiceLane_1.ForeColor = Color.Red;
                    }
                    if (c3_ServiceLane_1.Text.Contains("REGULAR"))
                    {
                        c3_ServiceLane_1.ForeColor = Color.Black;
                    }
                }
            }
            catch (TaskCanceledException e)
            {
                Console.WriteLine("Exception Caught! Message :{0} ", e.Message);
            }
        }
        public async void cashier3_nextQueue2()
        {
            try
            {
                queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/MonitoringDisplay/3_Cashier_NextQueue2.php");
                var responseString = await queueData.Content.ReadAsStringAsync();
                String data = responseString;
                ServiceClass[] collection = JsonConvert.DeserializeObject<ServiceClass[]>(data);
                if (collection == null)
                {
                    c3_QueueNumber_2.Text = "";
                    c3_ServiceLane_2.Text = "";
                }
                else
                {
                    foreach (ServiceClass service in collection)
                    {
                        c3_QueueNumber_2.Text = service.queue_no.ToString();
                        c3_ServiceLane_2.Text = service.service_lane.ToString();
                    }
                    if (c3_ServiceLane_2.Text.Contains("PRIORITY"))
                    {
                        c3_ServiceLane_2.ForeColor = Color.Red;
                    }
                    if (c3_ServiceLane_2.Text.Contains("REGULAR"))
                    {
                        c3_ServiceLane_2.ForeColor = Color.Black;
                    }
                }
            }
            catch (TaskCanceledException e)
            {
                Console.WriteLine("Exception Caught! Message :{0} ", e.Message);
            }
        }
        public async void cashier3_nextQueue3()
        {
            try
            {
                queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/MonitoringDisplay/3_Cashier_NextQueue3.php");
                var responseString = await queueData.Content.ReadAsStringAsync();
                String data = responseString;
                ServiceClass[] collection = JsonConvert.DeserializeObject<ServiceClass[]>(data);
                if (collection == null)
                {
                    c3_QueueNumber_3.Text = "";
                    c3_ServiceLane_3.Text = "";
                }
                else
                {
                    foreach (ServiceClass service in collection)
                    {
                        c3_QueueNumber_3.Text = service.queue_no.ToString();
                        c3_ServiceLane_3.Text = service.service_lane.ToString();
                    }
                    if (c3_ServiceLane_3.Text.Contains("PRIORITY"))
                    {
                        c3_ServiceLane_3.ForeColor = Color.Red;
                    }
                    if (c3_ServiceLane_3.Text.Contains("REGULAR"))
                    {
                        c3_ServiceLane_3.ForeColor = Color.Black;
                    }
                }
            }
            catch (TaskCanceledException e)
            {
                Console.WriteLine("Exception Caught! Message :{0} ", e.Message);
            }
        }
        public async void cashier3_nextQueue4()
        {
            try
            {
                queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/MonitoringDisplay/3_Cashier_NextQueue4.php");
                var responseString = await queueData.Content.ReadAsStringAsync();
                String data = responseString;
                ServiceClass[] collection = JsonConvert.DeserializeObject<ServiceClass[]>(data);
                if (collection == null)
                {
                    c3_QueueNumber_4.Text = "";
                    c3_ServiceLane_4.Text = "";
                }
                else
                {
                    foreach (ServiceClass service in collection)
                    {
                        c3_QueueNumber_4.Text = service.queue_no.ToString();
                        c3_ServiceLane_4.Text = service.service_lane.ToString();
                    }
                    if (c3_ServiceLane_4.Text.Contains("PRIORITY"))
                    {
                        c3_ServiceLane_4.ForeColor = Color.Red;
                    }
                    if (c3_ServiceLane_4.Text.Contains("REGULAR"))
                    {
                        c3_ServiceLane_4.ForeColor = Color.Black;
                    }
                }
            }
            catch (TaskCanceledException e)
            {
                Console.WriteLine("Exception Caught! Message :{0} ", e.Message);
            }
        }
        public async void cashier3_nextQueue5()
        {
            try
            {
                queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/MonitoringDisplay/3_Cashier_NextQueue5.php");
                var responseString = await queueData.Content.ReadAsStringAsync();
                String data = responseString;
                ServiceClass[] collection = JsonConvert.DeserializeObject<ServiceClass[]>(data);
                if (collection == null)
                {
                    c3_QueueNumber_5.Text = "";
                    c3_ServiceLane_5.Text = "";
                }
                else
                {
                    foreach (ServiceClass service in collection)
                    {
                        c3_QueueNumber_5.Text = service.queue_no.ToString();
                        c3_ServiceLane_5.Text = service.service_lane.ToString();
                    }
                    if (c3_ServiceLane_5.Text.Contains("PRIORITY"))
                    {
                        c3_ServiceLane_5.ForeColor = Color.Red;
                    }
                    if (c3_ServiceLane_5.Text.Contains("REGULAR"))
                    {
                        c3_ServiceLane_5.ForeColor = Color.Black;
                    }
                }
            }
            catch (TaskCanceledException e)
            {
                Console.WriteLine("Exception Caught! Message :{0} ", e.Message);
            }
        }
        // CASHIER 4 NEXT QUEUE //
        public async void cashier4_nextQueue1()
        {
            try
            {
                queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/MonitoringDisplay/4_Cashier_NextQueue1.php");
                var responseString = await queueData.Content.ReadAsStringAsync();
                String data = responseString;
                ServiceClass[] collection = JsonConvert.DeserializeObject<ServiceClass[]>(data);
                if (collection == null)
                {
                    c4_QueueNumber_1.Text = "";
                    c4_ServiceLane_1.Text = "";
                }
                else
                {
                    foreach (ServiceClass service in collection)
                    {
                        c4_QueueNumber_1.Text = service.queue_no.ToString();
                        c4_ServiceLane_1.Text = service.service_lane.ToString();
                    }
                    if (c4_ServiceLane_1.Text.Contains("PRIORITY"))
                    {
                        c4_ServiceLane_1.ForeColor = Color.Red;
                    }
                    if (c4_ServiceLane_1.Text.Contains("REGULAR"))
                    {
                        c4_ServiceLane_1.ForeColor = Color.Black;
                    }
                }
            }
            catch (TaskCanceledException e)
            {
                Console.WriteLine("Exception Caught! Message :{0} ", e.Message);
            }
        }
        public async void cashier4_nextQueue2()
        {
            try
            {
                queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/MonitoringDisplay/4_Cashier_NextQueue2.php");
                var responseString = await queueData.Content.ReadAsStringAsync();
                String data = responseString;
                ServiceClass[] collection = JsonConvert.DeserializeObject<ServiceClass[]>(data);
                if (collection == null)
                {
                    c4_QueueNumber_2.Text = "";
                    c4_ServiceLane_2.Text = "";
                }
                else
                {
                    foreach (ServiceClass service in collection)
                    {
                        c4_QueueNumber_2.Text = service.queue_no.ToString();
                        c4_ServiceLane_2.Text = service.service_lane.ToString();
                    }
                    if (c4_ServiceLane_2.Text.Contains("PRIORITY"))
                    {
                        c4_ServiceLane_2.ForeColor = Color.Red;
                    }
                    if (c4_ServiceLane_2.Text.Contains("REGULAR"))
                    {
                        c4_ServiceLane_2.ForeColor = Color.Black;
                    }
                }
            }
            catch (TaskCanceledException e)
            {
                Console.WriteLine("Exception Caught! Message :{0} ", e.Message);
            }
        }
        public async void cashier4_nextQueue3()
        {
            try
            {
                queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/MonitoringDisplay/4_Cashier_NextQueue3.php");
                var responseString = await queueData.Content.ReadAsStringAsync();
                String data = responseString;
                ServiceClass[] collection = JsonConvert.DeserializeObject<ServiceClass[]>(data);
                if (collection == null)
                {
                    c4_QueueNumber_3.Text = "";
                    c4_ServiceLane_3.Text = "";
                }
                else
                {
                    foreach (ServiceClass service in collection)
                    {
                        c4_QueueNumber_3.Text = service.queue_no.ToString();
                        c4_ServiceLane_3.Text = service.service_lane.ToString();
                    }
                    if (c4_ServiceLane_3.Text.Contains("PRIORITY"))
                    {
                        c4_ServiceLane_3.ForeColor = Color.Red;
                    }
                    if (c4_ServiceLane_3.Text.Contains("REGULAR"))
                    {
                        c4_ServiceLane_3.ForeColor = Color.Black;
                    }
                }
            }
            catch (TaskCanceledException e)
            {
                Console.WriteLine("Exception Caught! Message :{0} ", e.Message);
            }
        }
        public async void cashier4_nextQueue4()
        {
            try
            {
                queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/MonitoringDisplay/4_Cashier_NextQueue4.php");
                var responseString = await queueData.Content.ReadAsStringAsync();
                String data = responseString;
                ServiceClass[] collection = JsonConvert.DeserializeObject<ServiceClass[]>(data);
                if (collection == null)
                {
                    c4_QueueNumber_4.Text = "";
                    c4_ServiceLane_4.Text = "";
                }
                else
                {
                    foreach (ServiceClass service in collection)
                    {
                        c4_QueueNumber_4.Text = service.queue_no.ToString();
                        c4_ServiceLane_4.Text = service.service_lane.ToString();
                    }
                    if (c4_ServiceLane_4.Text.Contains("PRIORITY"))
                    {
                        c4_ServiceLane_4.ForeColor = Color.Red;
                    }
                    if (c4_ServiceLane_4.Text.Contains("REGULAR"))
                    {
                        c4_ServiceLane_4.ForeColor = Color.Black;
                    }
                }
            }
            catch (TaskCanceledException e)
            {
                Console.WriteLine("Exception Caught! Message :{0} ", e.Message);
            }
        }
        public async void cashier4_nextQueue5()
        {
            try
            {
                queueData = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/MonitoringDisplay/4_Cashier_NextQueue5.php");
                var responseString = await queueData.Content.ReadAsStringAsync();
                String data = responseString;
                ServiceClass[] collection = JsonConvert.DeserializeObject<ServiceClass[]>(data);
                if (collection == null)
                {
                    c4_QueueNumber_5.Text = "";
                    c4_ServiceLane_5.Text = "";
                }
                else
                {
                    foreach (ServiceClass service in collection)
                    {
                        c4_QueueNumber_5.Text = service.queue_no.ToString();
                        c4_ServiceLane_5.Text = service.service_lane.ToString();
                    }
                    if (c4_ServiceLane_5.Text.Contains("PRIORITY"))
                    {
                        c4_ServiceLane_5.ForeColor = Color.Red;
                    }
                    if (c4_ServiceLane_5.Text.Contains("REGULAR"))
                    {
                        c4_ServiceLane_5.ForeColor = Color.Black;
                    }
                }
            }
            catch (TaskCanceledException e)
            {
                Console.WriteLine("Exception Caught! Message :{0} ", e.Message);
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




            loadData();

            data_cashier1();
            data_cashier2();
            data_cashier3();
            data_cashier4();
        }
    }
}

using MySql.Data.MySqlClient;
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

            HttpResponseMessage qnr = await client.GetAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/1_Cashier_QueueNumber_Monitor.php");
            var qn = await qnr.Content.ReadAsStringAsync();
            queueNumber_1.Text = qn;


            //string.Format("{0:HH:mm:ss tt}", DateTime.Now);
            time_C1.Text = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
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

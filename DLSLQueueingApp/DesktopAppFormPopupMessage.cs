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
    public partial class DesktopAppFormPopupMessage : Form
    {
        public DesktopAppFormPopupMessage()
        {
            InitializeComponent();
        }

        public class Cashier
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        private void DesktopAppFormPopupMessage_Load(object sender, EventArgs e)
        {
            var dataSource = new List<Cashier>();
            dataSource.Add(new Cashier() { Name = "Cashier 1", Value = "Cashier 1" });
            dataSource.Add(new Cashier() { Name = "Cashier 2", Value = "Cashier 2" });
            dataSource.Add(new Cashier() { Name = "Cashier 3", Value = "Cashier 3" });
            dataSource.Add(new Cashier() { Name = "Cashier 4", Value = "Cashier 4" });
            //dataSource.Add(new Cashier() { Name = "Queue Monitoring", Value = "Queue Monitoring" });

            comboBox1.DataSource = dataSource;
            comboBox1.DisplayMember = "Cashier";
            comboBox1.ValueMember = "Value";

            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cashier 1")
            {
                QueueingForm qf = new QueueingForm();
                qf.ShowDialog();
            }
            if (comboBox1.Text == "Cashier 2")
            {
                QueueingForm2 qf2 = new QueueingForm2();
                qf2.ShowDialog();
            }
            if (comboBox1.Text == "Cashier 3")
            {
                QueueingForm3 qf3 = new QueueingForm3();
                qf3.ShowDialog();
            }
            if (comboBox1.Text == "Cashier 4")
            {
                QueueingForm4 qf4 = new QueueingForm4();
                qf4.ShowDialog();
            }
            if (comboBox1.Text == "Queue Monitoring")
            {
                QueueingFormMain qfm = new QueueingFormMain();
                qfm.ShowDialog();
            }
        }
    }
}

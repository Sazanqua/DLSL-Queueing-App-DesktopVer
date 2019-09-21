using System;
using System.Drawing;
using System.Windows.Forms;

namespace DLSLQueueingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            page21.Page3 = page31;
            page31.Page4 = page41;

            page21.MobileQueuePage1 = mobileQueuePage11;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            page21.BringToFront();
        }
    }
}

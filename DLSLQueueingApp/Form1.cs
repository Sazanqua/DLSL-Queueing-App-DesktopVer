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
            //TopMost = true; // Para fullscreen
            //FormBorderStyle = FormBorderStyle.None; // Para fullscreen
            //WindowState = FormWindowState.Maximized; // Para fullscreen

            pagePanel.Controls.Add(Page2.Instance); // Para pumunta sa harap yung page2.cs
            Page2.Instance.Dock = DockStyle.Bottom; // Para pumunta sa harap yung page2.cs
            Page2.Instance.BringToFront(); // Para pumunta sa harap yung page2.cs
        }

        private void mobileQueuePage11_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // Esc to close program
            {
                Close();
            }
        }
    }
}

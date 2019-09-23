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
    public partial class sample : Form
    {
        public sample()
        {
            InitializeComponent();
            
            //aaaa.Controls.Contains(page31);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!aaaa.Controls.Contains(Page2.Instance))
            {
                aaaa.Controls.Add(Page2.Instance);
                Page2.Instance.Dock = DockStyle.Fill;
                Page2.Instance.BringToFront();
            }
            else
            {
                Page2.Instance.BringToFront();
            }
        }
    }
}

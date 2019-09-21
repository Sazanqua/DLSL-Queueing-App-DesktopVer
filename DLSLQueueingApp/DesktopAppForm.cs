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
    public partial class DesktopAppForm : Form
    {
        public DesktopAppForm()
        {
            InitializeComponent();
        }

        private void DesktopAppForm_Load(object sender, EventArgs e)
        {
            //BackColor = ColorTranslator.FromHtml("#21282E");
            queueingBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            monitoringBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            ticketBtn.BackColor = ColorTranslator.FromHtml("#21282E");
        }

        private void ticketBtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}

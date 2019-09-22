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
            MaximizeBox = false; // Disable Maximize button
        }
        private const int CP_NOCLOSE_BUTTON = 0x200; // Disable Close button
        protected override CreateParams CreateParams // Disable Close button
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void DesktopAppForm_Load(object sender, EventArgs e)
        {
            closeBtn.BackColor = ColorTranslator.FromHtml("#FF4C4C");
            queueingBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            monitoringBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            ticketBtn.BackColor = ColorTranslator.FromHtml("#21282E");
        }

        private void ticketBtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

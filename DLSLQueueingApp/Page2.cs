using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLSLQueueingApp
{
    public partial class Page2 : UserControl
    {
        public Page3 Page3 { get; set; }
        public MobileQueuePage1 MobileQueuePage1 { get; set; }

        public Page2()
        {
            InitializeComponent();
            BackColor = ColorTranslator.FromHtml("#21282E");
        }

        private void manualQueueBtn_Click(object sender, EventArgs e)
        {
            Page3?.BringToFront();
        }

        private void Page2_Load(object sender, EventArgs e)
        {
            manualQueueBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            mobileAppQueueBtn.BackColor = ColorTranslator.FromHtml("#21282E");
        }

        private void mobileAppQueueBtn_Click(object sender, EventArgs e)
        {
            MobileQueuePage1?.BringToFront();
        }
    }
}

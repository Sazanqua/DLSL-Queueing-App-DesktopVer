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
    public partial class Page3 : UserControl
    {
        public Page4 Page4 { get; set; }
        public Page3()
        {
            InitializeComponent();
            BackColor = ColorTranslator.FromHtml("#21282E");
            page3BackBtn.BackColor = ColorTranslator.FromHtml("#21282E");
 
        }

        private void Page3_Load(object sender, EventArgs e)
        {
            normalLaneBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            priorityLaneBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            page3BackBtn.BackColor = ColorTranslator.FromHtml("#21282E");
        }


        private void page3BackBtn_Click_1(object sender, EventArgs e)
        {
            SendToBack();
        }

        private void normalLaneBtn_Click(object sender, EventArgs e)
        {
            Page4?.BringToFront();
        }
    }
}

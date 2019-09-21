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
    public partial class Page4 : UserControl
    {
        public Page4()
        {
            InitializeComponent();
            BackColor = ColorTranslator.FromHtml("#21282E");
        }

        private void collegeBtn_Click(object sender, EventArgs e)
        {

        }

        private void Page4_Load(object sender, EventArgs e)
        {
            page4BackBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            page4CollegeBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            page4OthersBtn.BackColor = ColorTranslator.FromHtml("#21282E");
        }

        private void page4BackBtn_Click(object sender, EventArgs e)
        {
            SendToBack();
        }
    }
}

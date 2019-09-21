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
    public partial class StartForm : Form
    {

        public StartForm()
        {
            InitializeComponent();
            
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            headerPanel.BackColor = ColorTranslator.FromHtml("#146344");
            startFormPanel.BackColor = ColorTranslator.FromHtml("#21282E");
            startFormLoginBtn.BackColor = ColorTranslator.FromHtml("#21282E");
        }

        private void startFormLoginBtn_Click(object sender, EventArgs e)
        {
            if (startFormUsernameTxtbox.Text == "admin" && startFormPasswordTxtbox.Text == "admin")
            {
                MessageBox.Show("LOGGING IN!");
                Hide();
                //Form1 f1 = new Form1();
                //f1.ShowDialog();
                DesktopAppForm daf = new DesktopAppForm();
                daf.ShowDialog();
            }
            else
            {
                MessageBox.Show("INVALID USERNAME OR PASSWORD!");
            }
        }
    }
}

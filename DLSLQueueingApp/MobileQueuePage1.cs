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
    public partial class MobileQueuePage1 : UserControl
    {
        public MobileQueuePage1()
        {
            InitializeComponent();
            BackColor = ColorTranslator.FromHtml("#21282E");
            mobileQueuePage1BackBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            mobileQueuePage1LoginBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            
        }

        private void page3BackBtn_Click(object sender, EventArgs e)
        {
            SendToBack();
        }


        

        private void MobileQueuePage1_Load(object sender, EventArgs e)
        {
            
        }

        private void studentNumberTxtbox_Enter(object sender, EventArgs e)
        {
            if(studentNumberTxtbox.Text == "Student Number")
            {
                studentNumberTxtbox.Text = "";
                studentNumberTxtbox.ForeColor = Color.Black;
            }
        }

        private void studentNumberTxtbox_Leave(object sender, EventArgs e)
        {
            if (studentNumberTxtbox.Text == "")
            {
                studentNumberTxtbox.Text = "Student Number";
                studentNumberTxtbox.ForeColor = Color.Silver;
            }
        }

        private void passwordTxtbox_Enter(object sender, EventArgs e)
        {
            if (passwordTxtbox.Text == "Password")
            {
                passwordTxtbox.Text = "";
                passwordTxtbox.ForeColor = Color.Black;
                passwordTxtbox.UseSystemPasswordChar = true;
            }
        }

        private void passwordTxtbox_Leave(object sender, EventArgs e)
        {
            if (passwordTxtbox.Text == "")
            {
                passwordTxtbox.Text = "Password";
                passwordTxtbox.ForeColor = Color.Silver;
                passwordTxtbox.UseSystemPasswordChar = false;
            }
        }

        private void studentNumberTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void mobileQueuePage1LoginBtn_Click(object sender, EventArgs e)
        {
            if(studentNumberTxtbox.Text == "Student Number" && passwordTxtbox.Text == "Password")
            {
                MessageBox.Show("STUDENT NUMBER OR PASSWORD CANNOT BE BLANKED!");
            }
        }
    }
}

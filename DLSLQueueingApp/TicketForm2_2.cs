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
    public partial class TicketForm2_2 : Form
    {
        public TicketForm2_2()
        {
            InitializeComponent();
        }

        private void TicketForm2_2_Load(object sender, EventArgs e)
        {
            Opacity = 0.1; // Form Animation
            animationTimer.Start(); // Form Animation

            TopMost = true; // Para fullscreen
            FormBorderStyle = FormBorderStyle.None; // Para fullscreen
            WindowState = FormWindowState.Maximized; // Para fullscreen
        
            ticketForm2_2BackBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            studentNumberTxtbox.BackColor = ColorTranslator.FromHtml("#21282E");
            passwordTxtbox.BackColor = ColorTranslator.FromHtml("#21282E");
            ticketForm2_2LoginBtn.BackColor = ColorTranslator.FromHtml("#21282E");
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity <= 1.0)
            {
                Opacity += 0.025;
            }
            else
            {
                animationTimer.Stop();
            }
        }

        private void studentNumberTxtbox_Enter(object sender, EventArgs e)
        {
            if (studentNumberTxtbox.Text == "Student Number")
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
    }
}

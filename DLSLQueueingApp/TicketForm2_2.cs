using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace DLSLQueueingApp
{
    public partial class TicketForm2_2 : Form
    {
        public TicketForm2_2()
        {
            InitializeComponent();
        }

        private static readonly HttpClient client = new HttpClient();

        private void TicketForm2_2_Load(object sender, EventArgs e)
        {
            Opacity = 0.1; // Form Animation
            animationTimer.Start(); // Form Animation

            TopMost = true; // Para fullscreen
            FormBorderStyle = FormBorderStyle.None; // Para fullscreen
            WindowState = FormWindowState.Maximized; // Para fullscreen
        
            ticketForm2_2BackBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            studentNumber_Panel.BackColor = ColorTranslator.FromHtml("#21282E");
            password_Panel.BackColor = ColorTranslator.FromHtml("#21282E");
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

        private void ticketForm2_2BackBtn_Click(object sender, EventArgs e)
        {
            TicketForm tf = new TicketForm();
            tf.ShowDialog();
            Close();
        }

        private void studentNumber_Txtbx_Enter(object sender, EventArgs e)
        {
            if (studentNumber_Txtbx.Text == "Student Number")
            {
                studentNumber_Txtbx.Text = "";
                studentNumber_Txtbx.ForeColor = Color.Black;
            }
        }

        private void studentNumber_Txtbx_Leave(object sender, EventArgs e)
        {
            if (studentNumber_Txtbx.Text == "")
            {
                studentNumber_Txtbx.Text = "Student Number";
                studentNumber_Txtbx.ForeColor = Color.Silver;
            }
        }

        private void Password_Txtbx_Enter(object sender, EventArgs e)
        {
            if (Password_Txtbx.Text == "Password")
            {
                Password_Txtbx.Text = "";
                Password_Txtbx.ForeColor = Color.Black;
                Password_Txtbx.UseSystemPasswordChar = true;
            }
        }

        private void Password_Txtbx_Leave(object sender, EventArgs e)
        {
            if (Password_Txtbx.Text == "")
            {
                Password_Txtbx.Text = "Password";
                Password_Txtbx.ForeColor = Color.Silver;
                Password_Txtbx.UseSystemPasswordChar = false;
            }
        }

        private void studentNumber_Txtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // Para numeric value lang sa student number textbox
            {
                e.Handled = true;
            }
        }

        private async void ticketForm2_2LoginBtn_Click(object sender, EventArgs e)
        {
            if (studentNumber_Txtbx.Text == "Student Number" && Password_Txtbx.Text == "Password")
            {
                MessageBox.Show("STUDENT NUMBER OR PASSWORD CANNOT BE BLANKED!");
            }

            else if (studentNumber_Txtbx.Text == "Student Number")
            {
                MessageBox.Show("STUDENT NUMBER CANNOT BE BLANKED!");
            }

            else if (Password_Txtbx.Text == "Password")
            {
                MessageBox.Show("PASSWORD CANNOT BE BLANKED!");
            }
            else
            {
                var values = new Dictionary<string, string>
                {
                    { "studentNumber", studentNumber_Txtbx.Text },
                    { "pass", Password_Txtbx.Text },
                };
                var content = new FormUrlEncodedContent(values);

                var response = await client.PostAsync("http://dlslqueueingapp-merwincastromjc253154.codeanyapp.com/v1/userLoginDesktop.php", content);

                var responseString = await response.Content.ReadAsStringAsync();
                if (responseString.Contains("true"))
                {
                    MessageBox.Show("INVALID CREDENTIALS");
                }
                else
                {
                    if (responseString.Contains("hasQueueingNumber") && responseString.Contains("YES"))
                    {
                        MessageBox.Show("USER ALREADY HAS A QUEUEING TICKET");
                    }
                    else
                    {
                        MessageBox.Show("LOGGING IN!");
                        TicketForm2_2_1 tf2_2_1 = new TicketForm2_2_1();
                        tf2_2_1.ShowDialog();
                        Close();
                    }
                }
            }
        }
    }
}

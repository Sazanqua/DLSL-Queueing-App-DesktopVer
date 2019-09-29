using MySql.Data.MySqlClient;
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

        private void ticketForm2_2LoginBtn_Click(object sender, EventArgs e)
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
                String studentNumber_value = studentNumber_Txtbx.Text;
                String password_value = Password_Txtbx.Text;
                String connection = "server=localhost;user id=root; password=root;database=dlsl_app"; // Para magstart yung mysql
                String query = "SELECT * FROM users WHERE student_number ='" + studentNumber_value + "'";
                MySqlConnection con = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dReader;
                try
                {
                    con.Open();
                    dReader = cmd.ExecuteReader();
                    while (dReader.Read())
                    {
                        String studentNumber = dReader.GetString("student_number");
                    }
                    if (dReader.HasRows)
                    {
                        dReader.Close();
                        String query2 = "SELECT student_number, password FROM users WHERE student_number ='" + studentNumber_value + "' AND password = '" + password_value + "'";
                        
                        MySqlCommand cmd2 = new MySqlCommand(query2, con);
                        MySqlDataReader dReader2;
                        dReader2 = cmd2.ExecuteReader();
                        while (dReader2.Read())
                        {
                            String studentNumber = dReader2.GetString("student_number");
                            String password = dReader2.GetString("password");
                        }
                        if (dReader2.HasRows)
                        {
                            MessageBox.Show("LOGGING IN!");
                            TicketForm2_2_1 tf2_2_1 = new TicketForm2_2_1();
                            tf2_2_1.ShowDialog();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("INVALID CREDENTIALS!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("INVALID CREDENTIALS!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}

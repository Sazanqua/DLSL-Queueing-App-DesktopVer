using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Para makaconnect sa mysql database

namespace DLSLQueueingApp
{
    public partial class StartForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1; //Para madrag yung form
        public const int HT_CAPTION = 0x2; //Para madrag yung form

        [System.Runtime.InteropServices.DllImport("user32.dll")] //Para madrag yung form
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam); //Para madrag yung form
        [System.Runtime.InteropServices.DllImport("user32.dll")] //Para madrag yung form
        public static extern bool ReleaseCapture(); //Para madrag yung form

        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            headerPanel.BackColor = ColorTranslator.FromHtml("#146344");
            startFormPanel.BackColor = ColorTranslator.FromHtml("#21282E");
            startFormLoginBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            imageLoader.Image = Properties.Resources.dwn;
            imageLoader.SizeMode = PictureBoxSizeMode.StretchImage;
            Timer tm = new Timer();
            tm.Interval = 3000;
            tm.Tick += new EventHandler(changeImage);
            tm.Start();
        }

        private void changeImage(object sender, EventArgs e)
        {
            List<Bitmap> imageList = new List<Bitmap>();
            imageList.Add(Properties.Resources.paascu);
            imageList.Add(Properties.Resources.cite);
            imageList.Add(Properties.Resources.ceas);
            imageList.Add(Properties.Resources.cbeam);
            imageList.Add(Properties.Resources.cihtm);
            imageList.Add(Properties.Resources.nursing);
            imageList.Add(Properties.Resources.col);
            int index = DateTime.Now.Second % imageList.Count;
            imageLoader.Image = imageList[index];
        }

        private void startFormLoginBtn_Click(object sender, EventArgs e)
        {
            if (startFormUsernameTxtbox.Text == "admin" && startFormPasswordTxtbox.Text == "admin")
            {
                MessageBox.Show("LOGGING IN!");
                Hide();
                DesktopAppForm daf = new DesktopAppForm();
                daf.ShowDialog();
            }
            else
            {
                MessageBox.Show("INVALID USERNAME OR PASSWORD!");
                startFormUsernameTxtbox.Text = "";
                startFormPasswordTxtbox.Text = "";
            }
        }

        private void headerPanel_MouseDown(object sender, MouseEventArgs e) // Para madrag yung form
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}

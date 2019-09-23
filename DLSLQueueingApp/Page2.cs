﻿using System;
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
        private static Page2 _instance; //
        public static Page2 Instance //
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Page2();
                }
                return _instance;
            }
        }
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
            //MobileQueuePage1?.BringToFront();
            //if (!pagePanel.Controls.Contains(Page3.Instance))
            //{
            //    pagePanel.Controls.Add(Page3.Instance);
            //    Page3.Instance.Dock = DockStyle.Fill;
            //    Page3.Instance.BringToFront();
            //}
            //else
            //{
            //    Page3.Instance.BringToFront();
            //
        }
    }
}

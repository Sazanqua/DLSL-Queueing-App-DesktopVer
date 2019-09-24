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
    public partial class MonitorMainUserControl : UserControl
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // X-coordinate of upper-left corner or padding at start
            int nTopRect,// Y-coordinate of upper-left corner or padding 
            int nRightRect, // X-coordinate of lower-right corner or Width of the object
            int nBottomRect,// Y-coordinate of lower-right corner or Height of the object
                            //RADIUS, how round do you want it to be?
            int nheightRect, //height of ellipse 
            int nweightRect //width of ellipse
        );
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            Region = Region.FromHrgn(CreateRoundRectRgn(2, 3, Width, Height, 30, 30)); //play with these values till you are happy
        }

        public MonitorMainUserControl()
        {
            InitializeComponent();
            cashierMainNumber.Text = "1";
            queueMainNumber.Text = "123";
        }
    }
}

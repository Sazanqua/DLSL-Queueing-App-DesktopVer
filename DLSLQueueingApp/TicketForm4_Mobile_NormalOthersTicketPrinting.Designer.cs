﻿namespace DLSLQueueingApp
{
    partial class TicketForm4_Mobile_NormalOthersTicketPrinting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketForm4_Mobile_NormalOthersTicketPrinting));
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.ticketPanel = new System.Windows.Forms.Panel();
            this.studentNumber = new System.Windows.Forms.Label();
            this.expirationDate = new System.Windows.Forms.Label();
            this.edLbl = new System.Windows.Forms.Label();
            this.serviceLane = new System.Windows.Forms.Label();
            this.serviceType = new System.Windows.Forms.Label();
            this.cashierNumber = new System.Windows.Forms.Label();
            this.cLbl = new System.Windows.Forms.Label();
            this.queueNumber = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.confirmBtn = new DLSLQueueingApp.CircularButton();
            this.ticketPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 1;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // ticketPanel
            // 
            this.ticketPanel.Controls.Add(this.studentNumber);
            this.ticketPanel.Controls.Add(this.expirationDate);
            this.ticketPanel.Controls.Add(this.edLbl);
            this.ticketPanel.Controls.Add(this.serviceLane);
            this.ticketPanel.Controls.Add(this.serviceType);
            this.ticketPanel.Controls.Add(this.cashierNumber);
            this.ticketPanel.Controls.Add(this.cLbl);
            this.ticketPanel.Controls.Add(this.queueNumber);
            this.ticketPanel.Controls.Add(this.pictureBox1);
            this.ticketPanel.Location = new System.Drawing.Point(712, 372);
            this.ticketPanel.Name = "ticketPanel";
            this.ticketPanel.Size = new System.Drawing.Size(500, 500);
            this.ticketPanel.TabIndex = 15;
            // 
            // studentNumber
            // 
            this.studentNumber.AutoSize = true;
            this.studentNumber.BackColor = System.Drawing.Color.White;
            this.studentNumber.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNumber.Location = new System.Drawing.Point(166, 130);
            this.studentNumber.Name = "studentNumber";
            this.studentNumber.Size = new System.Drawing.Size(232, 34);
            this.studentNumber.TabIndex = 20;
            this.studentNumber.Text = "STUDENT NUM";
            // 
            // expirationDate
            // 
            this.expirationDate.AutoSize = true;
            this.expirationDate.BackColor = System.Drawing.Color.White;
            this.expirationDate.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expirationDate.Location = new System.Drawing.Point(285, 395);
            this.expirationDate.Name = "expirationDate";
            this.expirationDate.Size = new System.Drawing.Size(122, 34);
            this.expirationDate.TabIndex = 19;
            this.expirationDate.Text = "?/??/????";
            // 
            // edLbl
            // 
            this.edLbl.AutoSize = true;
            this.edLbl.BackColor = System.Drawing.Color.White;
            this.edLbl.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edLbl.Location = new System.Drawing.Point(74, 395);
            this.edLbl.Name = "edLbl";
            this.edLbl.Size = new System.Drawing.Size(209, 34);
            this.edLbl.TabIndex = 18;
            this.edLbl.Text = "Expiration Date:";
            // 
            // serviceLane
            // 
            this.serviceLane.AutoSize = true;
            this.serviceLane.BackColor = System.Drawing.Color.White;
            this.serviceLane.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceLane.Location = new System.Drawing.Point(70, 310);
            this.serviceLane.Name = "serviceLane";
            this.serviceLane.Size = new System.Drawing.Size(141, 46);
            this.serviceLane.TabIndex = 17;
            this.serviceLane.Text = "Normal";
            // 
            // serviceType
            // 
            this.serviceType.AutoSize = true;
            this.serviceType.BackColor = System.Drawing.Color.White;
            this.serviceType.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceType.Location = new System.Drawing.Point(240, 310);
            this.serviceType.Name = "serviceType";
            this.serviceType.Size = new System.Drawing.Size(126, 46);
            this.serviceType.TabIndex = 16;
            this.serviceType.Text = "Others";
            // 
            // cashierNumber
            // 
            this.cashierNumber.AutoSize = true;
            this.cashierNumber.BackColor = System.Drawing.Color.White;
            this.cashierNumber.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierNumber.Location = new System.Drawing.Point(294, 190);
            this.cashierNumber.Name = "cashierNumber";
            this.cashierNumber.Size = new System.Drawing.Size(40, 46);
            this.cashierNumber.TabIndex = 15;
            this.cashierNumber.Text = "#";
            // 
            // cLbl
            // 
            this.cLbl.AutoSize = true;
            this.cLbl.BackColor = System.Drawing.Color.White;
            this.cLbl.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLbl.Location = new System.Drawing.Point(164, 190);
            this.cLbl.Name = "cLbl";
            this.cLbl.Size = new System.Drawing.Size(142, 46);
            this.cLbl.TabIndex = 14;
            this.cLbl.Text = "Cashier";
            // 
            // queueNumber
            // 
            this.queueNumber.AutoSize = true;
            this.queueNumber.BackColor = System.Drawing.Color.White;
            this.queueNumber.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queueNumber.Location = new System.Drawing.Point(190, 30);
            this.queueNumber.Name = "queueNumber";
            this.queueNumber.Size = new System.Drawing.Size(78, 90);
            this.queueNumber.TabIndex = 1;
            this.queueNumber.Text = "#";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 478);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.Location = new System.Drawing.Point(830, 975);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(300, 70);
            this.confirmBtn.TabIndex = 16;
            this.confirmBtn.Text = "CONFIRM";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // TicketForm4_Mobile_NormalOthersTicketPrinting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.ticketPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicketForm4_Mobile_NormalOthersTicketPrinting";
            this.Text = "TicketForm4_Mobile_NormalOthersTicketPrinting";
            this.Load += new System.EventHandler(this.TicketForm4_Mobile_NormalOthersTicketPrinting_Load);
            this.ticketPanel.ResumeLayout(false);
            this.ticketPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer animationTimer;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel ticketPanel;
        private System.Windows.Forms.Label studentNumber;
        private System.Windows.Forms.Label expirationDate;
        private System.Windows.Forms.Label edLbl;
        private System.Windows.Forms.Label serviceLane;
        private System.Windows.Forms.Label serviceType;
        private System.Windows.Forms.Label cashierNumber;
        private System.Windows.Forms.Label cLbl;
        private System.Windows.Forms.Label queueNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CircularButton confirmBtn;
    }
}
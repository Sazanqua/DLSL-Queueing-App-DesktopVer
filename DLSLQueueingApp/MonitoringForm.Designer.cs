namespace DLSLQueueingApp
{
    partial class MonitoringForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitoringForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.time_C1 = new System.Windows.Forms.Label();
            this.serviceType_1 = new System.Windows.Forms.Label();
            this.serviceLane_1 = new System.Windows.Forms.Label();
            this.queueNumber_1 = new System.Windows.Forms.Label();
            this.cashierNumber_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.serviceType_2 = new System.Windows.Forms.Label();
            this.serviceLane_2 = new System.Windows.Forms.Label();
            this.queueNumber_2 = new System.Windows.Forms.Label();
            this.cashierNumber_2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.serviceType_3 = new System.Windows.Forms.Label();
            this.serviceLane_3 = new System.Windows.Forms.Label();
            this.queueNumber_3 = new System.Windows.Forms.Label();
            this.cashierNumber_3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.serviceType_4 = new System.Windows.Forms.Label();
            this.serviceLane_4 = new System.Windows.Forms.Label();
            this.queueNumber_4 = new System.Windows.Forms.Label();
            this.cashierNumber_4 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.monitorUserControl1 = new DLSLQueueingApp.MonitorUserControl();
            this.monitorUserControl2 = new DLSLQueueingApp.MonitorUserControl();
            this.monitorUserControl3 = new DLSLQueueingApp.MonitorUserControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.time_C1);
            this.panel1.Controls.Add(this.serviceType_1);
            this.panel1.Controls.Add(this.serviceLane_1);
            this.panel1.Controls.Add(this.queueNumber_1);
            this.panel1.Controls.Add(this.cashierNumber_1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(50, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 350);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "Time Served: ";
            // 
            // time_C1
            // 
            this.time_C1.AutoSize = true;
            this.time_C1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_C1.Location = new System.Drawing.Point(260, 295);
            this.time_C1.Name = "time_C1";
            this.time_C1.Size = new System.Drawing.Size(165, 34);
            this.time_C1.TabIndex = 7;
            this.time_C1.Text = "00:00:00 am";
            // 
            // serviceType_1
            // 
            this.serviceType_1.AutoSize = true;
            this.serviceType_1.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceType_1.Location = new System.Drawing.Point(17, 235);
            this.serviceType_1.Name = "serviceType_1";
            this.serviceType_1.Size = new System.Drawing.Size(139, 39);
            this.serviceType_1.TabIndex = 4;
            this.serviceType_1.Text = "S_TYPE";
            // 
            // serviceLane_1
            // 
            this.serviceLane_1.AutoSize = true;
            this.serviceLane_1.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceLane_1.Location = new System.Drawing.Point(259, 235);
            this.serviceLane_1.Name = "serviceLane_1";
            this.serviceLane_1.Size = new System.Drawing.Size(144, 39);
            this.serviceLane_1.TabIndex = 3;
            this.serviceLane_1.Text = "S_LANE";
            // 
            // queueNumber_1
            // 
            this.queueNumber_1.AutoSize = true;
            this.queueNumber_1.Font = new System.Drawing.Font("Times New Roman", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queueNumber_1.Location = new System.Drawing.Point(160, 96);
            this.queueNumber_1.Name = "queueNumber_1";
            this.queueNumber_1.Size = new System.Drawing.Size(98, 114);
            this.queueNumber_1.TabIndex = 2;
            this.queueNumber_1.Text = "0";
            // 
            // cashierNumber_1
            // 
            this.cashierNumber_1.AutoSize = true;
            this.cashierNumber_1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierNumber_1.Location = new System.Drawing.Point(299, 18);
            this.cashierNumber_1.Name = "cashierNumber_1";
            this.cashierNumber_1.Size = new System.Drawing.Size(48, 68);
            this.cashierNumber_1.TabIndex = 1;
            this.cashierNumber_1.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cashier ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.serviceType_2);
            this.panel2.Controls.Add(this.serviceLane_2);
            this.panel2.Controls.Add(this.queueNumber_2);
            this.panel2.Controls.Add(this.cashierNumber_2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(510, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 350);
            this.panel2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 34);
            this.label4.TabIndex = 8;
            this.label4.Text = "Time Served: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(260, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 34);
            this.label5.TabIndex = 7;
            this.label5.Text = "00:00:00 am";
            // 
            // serviceType_2
            // 
            this.serviceType_2.AutoSize = true;
            this.serviceType_2.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceType_2.Location = new System.Drawing.Point(17, 235);
            this.serviceType_2.Name = "serviceType_2";
            this.serviceType_2.Size = new System.Drawing.Size(139, 39);
            this.serviceType_2.TabIndex = 4;
            this.serviceType_2.Text = "S_TYPE";
            // 
            // serviceLane_2
            // 
            this.serviceLane_2.AutoSize = true;
            this.serviceLane_2.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceLane_2.Location = new System.Drawing.Point(259, 235);
            this.serviceLane_2.Name = "serviceLane_2";
            this.serviceLane_2.Size = new System.Drawing.Size(144, 39);
            this.serviceLane_2.TabIndex = 3;
            this.serviceLane_2.Text = "S_LANE";
            // 
            // queueNumber_2
            // 
            this.queueNumber_2.AutoSize = true;
            this.queueNumber_2.Font = new System.Drawing.Font("Times New Roman", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queueNumber_2.Location = new System.Drawing.Point(160, 96);
            this.queueNumber_2.Name = "queueNumber_2";
            this.queueNumber_2.Size = new System.Drawing.Size(98, 114);
            this.queueNumber_2.TabIndex = 2;
            this.queueNumber_2.Text = "0";
            // 
            // cashierNumber_2
            // 
            this.cashierNumber_2.AutoSize = true;
            this.cashierNumber_2.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierNumber_2.Location = new System.Drawing.Point(299, 18);
            this.cashierNumber_2.Name = "cashierNumber_2";
            this.cashierNumber_2.Size = new System.Drawing.Size(48, 68);
            this.cashierNumber_2.TabIndex = 1;
            this.cashierNumber_2.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(97, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(228, 68);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cashier ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.serviceType_3);
            this.panel3.Controls.Add(this.serviceLane_3);
            this.panel3.Controls.Add(this.queueNumber_3);
            this.panel3.Controls.Add(this.cashierNumber_3);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Location = new System.Drawing.Point(50, 675);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(445, 350);
            this.panel3.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 295);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 34);
            this.label12.TabIndex = 8;
            this.label12.Text = "Time Served: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(260, 295);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 34);
            this.label13.TabIndex = 7;
            this.label13.Text = "00:00:00 am";
            // 
            // serviceType_3
            // 
            this.serviceType_3.AutoSize = true;
            this.serviceType_3.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceType_3.Location = new System.Drawing.Point(17, 235);
            this.serviceType_3.Name = "serviceType_3";
            this.serviceType_3.Size = new System.Drawing.Size(139, 39);
            this.serviceType_3.TabIndex = 4;
            this.serviceType_3.Text = "S_TYPE";
            // 
            // serviceLane_3
            // 
            this.serviceLane_3.AutoSize = true;
            this.serviceLane_3.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceLane_3.Location = new System.Drawing.Point(259, 235);
            this.serviceLane_3.Name = "serviceLane_3";
            this.serviceLane_3.Size = new System.Drawing.Size(144, 39);
            this.serviceLane_3.TabIndex = 3;
            this.serviceLane_3.Text = "S_LANE";
            // 
            // queueNumber_3
            // 
            this.queueNumber_3.AutoSize = true;
            this.queueNumber_3.Font = new System.Drawing.Font("Times New Roman", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queueNumber_3.Location = new System.Drawing.Point(160, 96);
            this.queueNumber_3.Name = "queueNumber_3";
            this.queueNumber_3.Size = new System.Drawing.Size(98, 114);
            this.queueNumber_3.TabIndex = 2;
            this.queueNumber_3.Text = "0";
            // 
            // cashierNumber_3
            // 
            this.cashierNumber_3.AutoSize = true;
            this.cashierNumber_3.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierNumber_3.Location = new System.Drawing.Point(299, 18);
            this.cashierNumber_3.Name = "cashierNumber_3";
            this.cashierNumber_3.Size = new System.Drawing.Size(48, 68);
            this.cashierNumber_3.TabIndex = 1;
            this.cashierNumber_3.Text = "-";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(97, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(228, 68);
            this.label18.TabIndex = 0;
            this.label18.Text = "Cashier ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.serviceType_4);
            this.panel4.Controls.Add(this.serviceLane_4);
            this.panel4.Controls.Add(this.queueNumber_4);
            this.panel4.Controls.Add(this.cashierNumber_4);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Location = new System.Drawing.Point(510, 675);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(445, 350);
            this.panel4.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 34);
            this.label11.TabIndex = 8;
            this.label11.Text = "Time Served: ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(260, 295);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(165, 34);
            this.label19.TabIndex = 7;
            this.label19.Text = "00:00:00 am";
            // 
            // serviceType_4
            // 
            this.serviceType_4.AutoSize = true;
            this.serviceType_4.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceType_4.Location = new System.Drawing.Point(17, 235);
            this.serviceType_4.Name = "serviceType_4";
            this.serviceType_4.Size = new System.Drawing.Size(139, 39);
            this.serviceType_4.TabIndex = 4;
            this.serviceType_4.Text = "S_TYPE";
            // 
            // serviceLane_4
            // 
            this.serviceLane_4.AutoSize = true;
            this.serviceLane_4.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceLane_4.Location = new System.Drawing.Point(259, 235);
            this.serviceLane_4.Name = "serviceLane_4";
            this.serviceLane_4.Size = new System.Drawing.Size(144, 39);
            this.serviceLane_4.TabIndex = 3;
            this.serviceLane_4.Text = "S_LANE";
            // 
            // queueNumber_4
            // 
            this.queueNumber_4.AutoSize = true;
            this.queueNumber_4.Font = new System.Drawing.Font("Times New Roman", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queueNumber_4.Location = new System.Drawing.Point(160, 96);
            this.queueNumber_4.Name = "queueNumber_4";
            this.queueNumber_4.Size = new System.Drawing.Size(98, 114);
            this.queueNumber_4.TabIndex = 2;
            this.queueNumber_4.Text = "0";
            // 
            // cashierNumber_4
            // 
            this.cashierNumber_4.AutoSize = true;
            this.cashierNumber_4.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierNumber_4.Location = new System.Drawing.Point(299, 18);
            this.cashierNumber_4.Name = "cashierNumber_4";
            this.cashierNumber_4.Size = new System.Drawing.Size(48, 68);
            this.cashierNumber_4.TabIndex = 1;
            this.cashierNumber_4.Text = "-";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(97, 18);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(228, 68);
            this.label24.TabIndex = 0;
            this.label24.Text = "Cashier ";
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(1040, 305);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(805, 720);
            this.panel5.TabIndex = 11;
            // 
            // monitorUserControl1
            // 
            this.monitorUserControl1.Location = new System.Drawing.Point(20, 297);
            this.monitorUserControl1.Name = "monitorUserControl1";
            this.monitorUserControl1.Size = new System.Drawing.Size(445, 350);
            this.monitorUserControl1.TabIndex = 4;
            // 
            // monitorUserControl2
            // 
            this.monitorUserControl2.Location = new System.Drawing.Point(480, 667);
            this.monitorUserControl2.Name = "monitorUserControl2";
            this.monitorUserControl2.Size = new System.Drawing.Size(445, 350);
            this.monitorUserControl2.TabIndex = 5;
            // 
            // monitorUserControl3
            // 
            this.monitorUserControl3.Location = new System.Drawing.Point(20, 667);
            this.monitorUserControl3.Name = "monitorUserControl3";
            this.monitorUserControl3.Size = new System.Drawing.Size(445, 350);
            this.monitorUserControl3.TabIndex = 6;
            // 
            // MonitoringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MonitoringForm";
            this.Text = "MonitoringForm";
            this.Load += new System.EventHandler(this.MonitoringForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MonitoringForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MonitorUserControl monitorUserControl1;
        private MonitorUserControl monitorUserControl2;
        private MonitorUserControl monitorUserControl3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cashierNumber_1;
        private System.Windows.Forms.Label queueNumber_1;
        private System.Windows.Forms.Label serviceLane_1;
        private System.Windows.Forms.Label serviceType_1;
        private System.Windows.Forms.Label time_C1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label serviceType_2;
        private System.Windows.Forms.Label serviceLane_2;
        private System.Windows.Forms.Label queueNumber_2;
        private System.Windows.Forms.Label cashierNumber_2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label serviceType_3;
        private System.Windows.Forms.Label serviceLane_3;
        private System.Windows.Forms.Label queueNumber_3;
        private System.Windows.Forms.Label cashierNumber_3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label serviceType_4;
        private System.Windows.Forms.Label serviceLane_4;
        private System.Windows.Forms.Label queueNumber_4;
        private System.Windows.Forms.Label cashierNumber_4;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel5;
    }
}
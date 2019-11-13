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
            this.monitorUserControl31 = new DLSLQueueingApp.MonitorUserControl3();
            this.monitorUserControl4 = new DLSLQueueingApp.MonitorUserControl();
            this.monitorUserControl21 = new DLSLQueueingApp.MonitorUserControl2();
            this.monitorUserControl1 = new DLSLQueueingApp.MonitorUserControl();
            this.monitorUserControl2 = new DLSLQueueingApp.MonitorUserControl();
            this.monitorUserControl3 = new DLSLQueueingApp.MonitorUserControl();
            this.monitorUserControl41 = new DLSLQueueingApp.MonitorUserControl4();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // monitorUserControl31
            // 
            this.monitorUserControl31.Location = new System.Drawing.Point(401, 662);
            this.monitorUserControl31.Name = "monitorUserControl31";
            this.monitorUserControl31.Size = new System.Drawing.Size(445, 350);
            this.monitorUserControl31.TabIndex = 2;
            // 
            // monitorUserControl4
            // 
            this.monitorUserControl4.Location = new System.Drawing.Point(401, 297);
            this.monitorUserControl4.Name = "monitorUserControl4";
            this.monitorUserControl4.Size = new System.Drawing.Size(445, 350);
            this.monitorUserControl4.TabIndex = 1;
            // 
            // monitorUserControl21
            // 
            this.monitorUserControl21.Location = new System.Drawing.Point(1022, 297);
            this.monitorUserControl21.Name = "monitorUserControl21";
            this.monitorUserControl21.Size = new System.Drawing.Size(445, 350);
            this.monitorUserControl21.TabIndex = 0;
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
            // monitorUserControl41
            // 
            this.monitorUserControl41.Location = new System.Drawing.Point(1022, 662);
            this.monitorUserControl41.Name = "monitorUserControl41";
            this.monitorUserControl41.Size = new System.Drawing.Size(445, 350);
            this.monitorUserControl41.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MonitoringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.monitorUserControl41);
            this.Controls.Add(this.monitorUserControl31);
            this.Controls.Add(this.monitorUserControl4);
            this.Controls.Add(this.monitorUserControl21);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MonitoringForm";
            this.Text = "MonitoringForm";
            this.Load += new System.EventHandler(this.MonitoringForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MonitoringForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private MonitorUserControl monitorUserControl1;
        private MonitorUserControl monitorUserControl2;
        private MonitorUserControl monitorUserControl3;
        private MonitorUserControl2 monitorUserControl21;
        private MonitorUserControl monitorUserControl4;
        private MonitorUserControl3 monitorUserControl31;
        private MonitorUserControl4 monitorUserControl41;
        private System.Windows.Forms.Timer timer1;
    }
}
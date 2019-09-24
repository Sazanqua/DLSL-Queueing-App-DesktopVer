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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitoringForm));
            this.monitorUserControl1 = new DLSLQueueingApp.MonitorUserControl();
            this.monitorUserControl2 = new DLSLQueueingApp.MonitorUserControl();
            this.monitorUserControl3 = new DLSLQueueingApp.MonitorUserControl();
            this.monitorUserControl4 = new DLSLQueueingApp.MonitorUserControl();
            this.monitorMainUserControl1 = new DLSLQueueingApp.MonitorMainUserControl();
            this.SuspendLayout();
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
            // monitorUserControl4
            // 
            this.monitorUserControl4.Location = new System.Drawing.Point(480, 297);
            this.monitorUserControl4.Name = "monitorUserControl4";
            this.monitorUserControl4.Size = new System.Drawing.Size(445, 350);
            this.monitorUserControl4.TabIndex = 7;
            // 
            // monitorMainUserControl1
            // 
            this.monitorMainUserControl1.Location = new System.Drawing.Point(975, 297);
            this.monitorMainUserControl1.Name = "monitorMainUserControl1";
            this.monitorMainUserControl1.Size = new System.Drawing.Size(885, 725);
            this.monitorMainUserControl1.TabIndex = 8;
            // 
            // MonitoringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.monitorMainUserControl1);
            this.Controls.Add(this.monitorUserControl4);
            this.Controls.Add(this.monitorUserControl3);
            this.Controls.Add(this.monitorUserControl2);
            this.Controls.Add(this.monitorUserControl1);
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
        private MonitorUserControl monitorUserControl4;
        private MonitorMainUserControl monitorMainUserControl1;
    }
}
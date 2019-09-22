namespace DLSLQueueingApp
{
    partial class DesktopAppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesktopAppForm));
            this.queueingBtn = new System.Windows.Forms.Button();
            this.monitoringBtn = new System.Windows.Forms.Button();
            this.ticketBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // queueingBtn
            // 
            this.queueingBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.queueingBtn.FlatAppearance.BorderSize = 0;
            this.queueingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.queueingBtn.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queueingBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.queueingBtn.Location = new System.Drawing.Point(150, 50);
            this.queueingBtn.Name = "queueingBtn";
            this.queueingBtn.Size = new System.Drawing.Size(500, 75);
            this.queueingBtn.TabIndex = 8;
            this.queueingBtn.Text = "QUEUEING";
            this.queueingBtn.UseVisualStyleBackColor = false;
            // 
            // monitoringBtn
            // 
            this.monitoringBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.monitoringBtn.FlatAppearance.BorderSize = 0;
            this.monitoringBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monitoringBtn.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitoringBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.monitoringBtn.Location = new System.Drawing.Point(150, 175);
            this.monitoringBtn.Name = "monitoringBtn";
            this.monitoringBtn.Size = new System.Drawing.Size(500, 75);
            this.monitoringBtn.TabIndex = 9;
            this.monitoringBtn.Text = "MONITORING";
            this.monitoringBtn.UseVisualStyleBackColor = false;
            // 
            // ticketBtn
            // 
            this.ticketBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ticketBtn.FlatAppearance.BorderSize = 0;
            this.ticketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ticketBtn.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ticketBtn.Location = new System.Drawing.Point(150, 300);
            this.ticketBtn.Name = "ticketBtn";
            this.ticketBtn.Size = new System.Drawing.Size(500, 75);
            this.ticketBtn.TabIndex = 10;
            this.ticketBtn.Text = "TICKET";
            this.ticketBtn.UseVisualStyleBackColor = false;
            this.ticketBtn.Click += new System.EventHandler(this.ticketBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.closeBtn.Location = new System.Drawing.Point(150, 425);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(500, 75);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.Text = "CLOSE APPLICATION";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // DesktopAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.ticketBtn);
            this.Controls.Add(this.monitoringBtn);
            this.Controls.Add(this.queueingBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DesktopAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DLSL Queueing App";
            this.Load += new System.EventHandler(this.DesktopAppForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button queueingBtn;
        private System.Windows.Forms.Button monitoringBtn;
        private System.Windows.Forms.Button ticketBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}
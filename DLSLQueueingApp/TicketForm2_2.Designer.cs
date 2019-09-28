namespace DLSLQueueingApp
{
    partial class TicketForm2_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketForm2_2));
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.ticketForm2_2BackBtn = new System.Windows.Forms.Button();
            this.studentNumberTxtbox = new DLSLQueueingApp.TextBoxCircular();
            this.passwordTxtbox = new DLSLQueueingApp.TextBoxCircular();
            this.ticketForm2_2LoginBtn = new DLSLQueueingApp.CircularButton();
            this.SuspendLayout();
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 1;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // ticketForm2_2BackBtn
            // 
            this.ticketForm2_2BackBtn.FlatAppearance.BorderSize = 0;
            this.ticketForm2_2BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ticketForm2_2BackBtn.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketForm2_2BackBtn.ForeColor = System.Drawing.Color.White;
            this.ticketForm2_2BackBtn.Location = new System.Drawing.Point(150, 470);
            this.ticketForm2_2BackBtn.Name = "ticketForm2_2BackBtn";
            this.ticketForm2_2BackBtn.Size = new System.Drawing.Size(230, 84);
            this.ticketForm2_2BackBtn.TabIndex = 10;
            this.ticketForm2_2BackBtn.Text = "⮜- BACK";
            this.ticketForm2_2BackBtn.UseVisualStyleBackColor = true;
            // 
            // studentNumberTxtbox
            // 
            this.studentNumberTxtbox.BackColor = System.Drawing.SystemColors.Window;
            this.studentNumberTxtbox.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNumberTxtbox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.studentNumberTxtbox.Location = new System.Drawing.Point(520, 550);
            this.studentNumberTxtbox.MaxLength = 10;
            this.studentNumberTxtbox.Name = "studentNumberTxtbox";
            this.studentNumberTxtbox.Size = new System.Drawing.Size(800, 118);
            this.studentNumberTxtbox.TabIndex = 11;
            this.studentNumberTxtbox.Text = "Student Number";
            this.studentNumberTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.studentNumberTxtbox.Enter += new System.EventHandler(this.studentNumberTxtbox_Enter);
            this.studentNumberTxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.studentNumberTxtbox_KeyPress);
            this.studentNumberTxtbox.Leave += new System.EventHandler(this.studentNumberTxtbox_Leave);
            // 
            // passwordTxtbox
            // 
            this.passwordTxtbox.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtbox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.passwordTxtbox.Location = new System.Drawing.Point(520, 750);
            this.passwordTxtbox.MaxLength = 12;
            this.passwordTxtbox.Name = "passwordTxtbox";
            this.passwordTxtbox.Size = new System.Drawing.Size(800, 118);
            this.passwordTxtbox.TabIndex = 13;
            this.passwordTxtbox.Text = "Password";
            this.passwordTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTxtbox.Enter += new System.EventHandler(this.passwordTxtbox_Enter);
            this.passwordTxtbox.Leave += new System.EventHandler(this.passwordTxtbox_Leave);
            // 
            // ticketForm2_2LoginBtn
            // 
            this.ticketForm2_2LoginBtn.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketForm2_2LoginBtn.ForeColor = System.Drawing.Color.White;
            this.ticketForm2_2LoginBtn.Location = new System.Drawing.Point(520, 950);
            this.ticketForm2_2LoginBtn.Name = "ticketForm2_2LoginBtn";
            this.ticketForm2_2LoginBtn.Size = new System.Drawing.Size(800, 118);
            this.ticketForm2_2LoginBtn.TabIndex = 14;
            this.ticketForm2_2LoginBtn.Text = "LOGIN";
            this.ticketForm2_2LoginBtn.UseVisualStyleBackColor = true;
            // 
            // TicketForm2_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.ticketForm2_2LoginBtn);
            this.Controls.Add(this.passwordTxtbox);
            this.Controls.Add(this.studentNumberTxtbox);
            this.Controls.Add(this.ticketForm2_2BackBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicketForm2_2";
            this.Text = "DLSL Queueing App";
            this.Load += new System.EventHandler(this.TicketForm2_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Button ticketForm2_2BackBtn;
        private TextBoxCircular studentNumberTxtbox;
        private TextBoxCircular passwordTxtbox;
        private CircularButton ticketForm2_2LoginBtn;
    }
}
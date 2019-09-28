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
            this.studentNumber_Panel = new System.Windows.Forms.Panel();
            this.studentNumber_Txtbx = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.password_Panel = new System.Windows.Forms.Panel();
            this.Password_Txtbx = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ticketForm2_2LoginBtn = new DLSLQueueingApp.CircularButton();
            this.studentNumber_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.password_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.ticketForm2_2BackBtn.Click += new System.EventHandler(this.ticketForm2_2BackBtn_Click);
            // 
            // studentNumber_Panel
            // 
            this.studentNumber_Panel.Controls.Add(this.studentNumber_Txtbx);
            this.studentNumber_Panel.Controls.Add(this.pictureBox2);
            this.studentNumber_Panel.Controls.Add(this.pictureBox1);
            this.studentNumber_Panel.Location = new System.Drawing.Point(520, 550);
            this.studentNumber_Panel.Name = "studentNumber_Panel";
            this.studentNumber_Panel.Size = new System.Drawing.Size(900, 155);
            this.studentNumber_Panel.TabIndex = 15;
            // 
            // studentNumber_Txtbx
            // 
            this.studentNumber_Txtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentNumber_Txtbx.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNumber_Txtbx.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.studentNumber_Txtbx.Location = new System.Drawing.Point(159, 51);
            this.studentNumber_Txtbx.MaxLength = 10;
            this.studentNumber_Txtbx.Name = "studentNumber_Txtbx";
            this.studentNumber_Txtbx.Size = new System.Drawing.Size(588, 69);
            this.studentNumber_Txtbx.TabIndex = 2;
            this.studentNumber_Txtbx.Text = "Student Number";
            this.studentNumber_Txtbx.Enter += new System.EventHandler(this.studentNumber_Txtbx_Enter);
            this.studentNumber_Txtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.studentNumber_Txtbx_KeyPress);
            this.studentNumber_Txtbx.Leave += new System.EventHandler(this.studentNumber_Txtbx_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(50, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 118);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // password_Panel
            // 
            this.password_Panel.Controls.Add(this.Password_Txtbx);
            this.password_Panel.Controls.Add(this.pictureBox3);
            this.password_Panel.Controls.Add(this.pictureBox4);
            this.password_Panel.Location = new System.Drawing.Point(520, 750);
            this.password_Panel.Name = "password_Panel";
            this.password_Panel.Size = new System.Drawing.Size(900, 155);
            this.password_Panel.TabIndex = 16;
            // 
            // Password_Txtbx
            // 
            this.Password_Txtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password_Txtbx.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Txtbx.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Password_Txtbx.Location = new System.Drawing.Point(159, 51);
            this.Password_Txtbx.MaxLength = 15;
            this.Password_Txtbx.Name = "Password_Txtbx";
            this.Password_Txtbx.Size = new System.Drawing.Size(588, 69);
            this.Password_Txtbx.TabIndex = 2;
            this.Password_Txtbx.Text = "Password";
            this.Password_Txtbx.Enter += new System.EventHandler(this.Password_Txtbx_Enter);
            this.Password_Txtbx.Leave += new System.EventHandler(this.Password_Txtbx_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(50, 40);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(0, 25);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(800, 118);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
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
            this.ticketForm2_2LoginBtn.Click += new System.EventHandler(this.ticketForm2_2LoginBtn_Click);
            // 
            // TicketForm2_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.password_Panel);
            this.Controls.Add(this.studentNumber_Panel);
            this.Controls.Add(this.ticketForm2_2LoginBtn);
            this.Controls.Add(this.ticketForm2_2BackBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicketForm2_2";
            this.Text = "DLSL Queueing App";
            this.Load += new System.EventHandler(this.TicketForm2_2_Load);
            this.studentNumber_Panel.ResumeLayout(false);
            this.studentNumber_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.password_Panel.ResumeLayout(false);
            this.password_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Button ticketForm2_2BackBtn;
        private CircularButton ticketForm2_2LoginBtn;
        private System.Windows.Forms.Panel studentNumber_Panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox studentNumber_Txtbx;
        private System.Windows.Forms.Panel password_Panel;
        private System.Windows.Forms.TextBox Password_Txtbx;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
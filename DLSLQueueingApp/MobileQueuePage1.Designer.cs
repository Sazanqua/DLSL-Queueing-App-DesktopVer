namespace DLSLQueueingApp
{
    partial class MobileQueuePage1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mobileQueuePage1BackBtn = new System.Windows.Forms.Button();
            this.passwordTxtbox = new DLSLQueueingApp.TextBoxCircular();
            this.studentNumberTxtbox = new DLSLQueueingApp.TextBoxCircular();
            this.mobileQueuePage1LoginBtn = new DLSLQueueingApp.CircularButton();
            this.SuspendLayout();
            // 
            // mobileQueuePage1BackBtn
            // 
            this.mobileQueuePage1BackBtn.FlatAppearance.BorderSize = 0;
            this.mobileQueuePage1BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mobileQueuePage1BackBtn.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileQueuePage1BackBtn.ForeColor = System.Drawing.Color.White;
            this.mobileQueuePage1BackBtn.Location = new System.Drawing.Point(135, 35);
            this.mobileQueuePage1BackBtn.Name = "mobileQueuePage1BackBtn";
            this.mobileQueuePage1BackBtn.Size = new System.Drawing.Size(230, 84);
            this.mobileQueuePage1BackBtn.TabIndex = 9;
            this.mobileQueuePage1BackBtn.Text = "⮜- BACK";
            this.mobileQueuePage1BackBtn.UseVisualStyleBackColor = true;
            this.mobileQueuePage1BackBtn.Click += new System.EventHandler(this.page3BackBtn_Click);
            // 
            // passwordTxtbox
            // 
            this.passwordTxtbox.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtbox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.passwordTxtbox.Location = new System.Drawing.Point(560, 283);
            this.passwordTxtbox.MaxLength = 12;
            this.passwordTxtbox.Name = "passwordTxtbox";
            this.passwordTxtbox.Size = new System.Drawing.Size(800, 118);
            this.passwordTxtbox.TabIndex = 12;
            this.passwordTxtbox.Text = "Password";
            this.passwordTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTxtbox.Enter += new System.EventHandler(this.passwordTxtbox_Enter);
            this.passwordTxtbox.Leave += new System.EventHandler(this.passwordTxtbox_Leave);
            // 
            // studentNumberTxtbox
            // 
            this.studentNumberTxtbox.BackColor = System.Drawing.SystemColors.Window;
            this.studentNumberTxtbox.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNumberTxtbox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.studentNumberTxtbox.Location = new System.Drawing.Point(560, 143);
            this.studentNumberTxtbox.MaxLength = 10;
            this.studentNumberTxtbox.Name = "studentNumberTxtbox";
            this.studentNumberTxtbox.Size = new System.Drawing.Size(800, 118);
            this.studentNumberTxtbox.TabIndex = 10;
            this.studentNumberTxtbox.Text = "Student Number";
            this.studentNumberTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.studentNumberTxtbox.Enter += new System.EventHandler(this.studentNumberTxtbox_Enter);
            this.studentNumberTxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.studentNumberTxtbox_KeyPress);
            this.studentNumberTxtbox.Leave += new System.EventHandler(this.studentNumberTxtbox_Leave);
            // 
            // mobileQueuePage1LoginBtn
            // 
            this.mobileQueuePage1LoginBtn.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileQueuePage1LoginBtn.ForeColor = System.Drawing.Color.White;
            this.mobileQueuePage1LoginBtn.Location = new System.Drawing.Point(560, 443);
            this.mobileQueuePage1LoginBtn.Name = "mobileQueuePage1LoginBtn";
            this.mobileQueuePage1LoginBtn.Size = new System.Drawing.Size(800, 118);
            this.mobileQueuePage1LoginBtn.TabIndex = 12;
            this.mobileQueuePage1LoginBtn.Text = "LOGIN";
            this.mobileQueuePage1LoginBtn.UseVisualStyleBackColor = true;
            this.mobileQueuePage1LoginBtn.Click += new System.EventHandler(this.mobileQueuePage1LoginBtn_Click);
            // 
            // MobileQueuePage1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mobileQueuePage1LoginBtn);
            this.Controls.Add(this.passwordTxtbox);
            this.Controls.Add(this.studentNumberTxtbox);
            this.Controls.Add(this.mobileQueuePage1BackBtn);
            this.Name = "MobileQueuePage1";
            this.Size = new System.Drawing.Size(1897, 608);
            this.Load += new System.EventHandler(this.MobileQueuePage1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mobileQueuePage1BackBtn;
        private TextBoxCircular studentNumberTxtbox;
        private TextBoxCircular passwordTxtbox;
        private CircularButton mobileQueuePage1LoginBtn;
    }
}

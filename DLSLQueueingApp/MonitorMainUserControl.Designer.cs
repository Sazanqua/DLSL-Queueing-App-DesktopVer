namespace DLSLQueueingApp
{
    partial class MonitorMainUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.queueMainNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cashierMainNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket Number";
            // 
            // queueMainNumber
            // 
            this.queueMainNumber.AutoSize = true;
            this.queueMainNumber.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queueMainNumber.ForeColor = System.Drawing.Color.Red;
            this.queueMainNumber.Location = new System.Drawing.Point(280, 200);
            this.queueMainNumber.Name = "queueMainNumber";
            this.queueMainNumber.Size = new System.Drawing.Size(142, 164);
            this.queueMainNumber.TabIndex = 1;
            this.queueMainNumber.Text = "#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(553, 81);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please proceed to:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(180, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 114);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cashier";
            // 
            // cashierMainNumber
            // 
            this.cashierMainNumber.AutoSize = true;
            this.cashierMainNumber.Font = new System.Drawing.Font("Times New Roman", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierMainNumber.ForeColor = System.Drawing.Color.Red;
            this.cashierMainNumber.Location = new System.Drawing.Point(520, 550);
            this.cashierMainNumber.Name = "cashierMainNumber";
            this.cashierMainNumber.Size = new System.Drawing.Size(98, 114);
            this.cashierMainNumber.TabIndex = 4;
            this.cashierMainNumber.Text = "#";
            // 
            // MonitorMainUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cashierMainNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.queueMainNumber);
            this.Controls.Add(this.label1);
            this.Name = "MonitorMainUserControl";
            this.Size = new System.Drawing.Size(885, 725);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label queueMainNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cashierMainNumber;
    }
}

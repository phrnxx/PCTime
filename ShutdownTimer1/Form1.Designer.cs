namespace ShutdownTimer1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.btnCancelTimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStatus.Location = new System.Drawing.Point(9, 135);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Статус:";
            // 
            // txtMinutes
            // 
            this.txtMinutes.BackColor = System.Drawing.Color.White;
            this.txtMinutes.ForeColor = System.Drawing.Color.Black;
            this.txtMinutes.Location = new System.Drawing.Point(12, 24);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(83, 20);
            this.txtMinutes.TabIndex = 1;
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.BackColor = System.Drawing.Color.Transparent;
            this.btnStartTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartTimer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStartTimer.Location = new System.Drawing.Point(12, 48);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(83, 23);
            this.btnStartTimer.TabIndex = 2;
            this.btnStartTimer.Text = "Go";
            this.btnStartTimer.UseVisualStyleBackColor = false;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // btnCancelTimer
            // 
            this.btnCancelTimer.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelTimer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelTimer.Location = new System.Drawing.Point(101, 48);
            this.btnCancelTimer.Name = "btnCancelTimer";
            this.btnCancelTimer.Size = new System.Drawing.Size(83, 23);
            this.btnCancelTimer.TabIndex = 3;
            this.btnCancelTimer.Text = "Cancel";
            this.btnCancelTimer.UseVisualStyleBackColor = false;
            this.btnCancelTimer.Click += new System.EventHandler(this.btnCancelTimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(251, 75);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelTimer);
            this.Controls.Add(this.btnStartTimer);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.lblStatus);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "PCTimer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Button btnCancelTimer;
        private System.Windows.Forms.Label label1;
    }
}
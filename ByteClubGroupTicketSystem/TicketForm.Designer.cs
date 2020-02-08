namespace ByteClubGroupTicketSystem
{
    partial class TicketForm
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
            this.IssueTicketBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NextEntryLabel = new System.Windows.Forms.Label();
            this.TotalTicketsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GuestsEnterLabel = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TitleBarTime = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IssueTicketBtn
            // 
            this.IssueTicketBtn.Location = new System.Drawing.Point(117, 233);
            this.IssueTicketBtn.Margin = new System.Windows.Forms.Padding(1);
            this.IssueTicketBtn.Name = "IssueTicketBtn";
            this.IssueTicketBtn.Size = new System.Drawing.Size(98, 23);
            this.IssueTicketBtn.TabIndex = 11;
            this.IssueTicketBtn.Text = "Issue Ticket";
            this.IssueTicketBtn.UseVisualStyleBackColor = true;
            this.IssueTicketBtn.Click += new System.EventHandler(this.IssueTicketBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NextEntryLabel);
            this.groupBox2.Controls.Add(this.TotalTicketsLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(34, 98);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox2.Size = new System.Drawing.Size(273, 120);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticket Availability";
            // 
            // NextEntryLabel
            // 
            this.NextEntryLabel.Location = new System.Drawing.Point(140, 73);
            this.NextEntryLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.NextEntryLabel.Name = "NextEntryLabel";
            this.NextEntryLabel.Size = new System.Drawing.Size(90, 16);
            this.NextEntryLabel.TabIndex = 3;
            this.NextEntryLabel.Text = "0";
            this.NextEntryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalTicketsLabel
            // 
            this.TotalTicketsLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TotalTicketsLabel.Location = new System.Drawing.Point(140, 33);
            this.TotalTicketsLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.TotalTicketsLabel.Name = "TotalTicketsLabel";
            this.TotalTicketsLabel.Size = new System.Drawing.Size(90, 16);
            this.TotalTicketsLabel.TabIndex = 2;
            this.TotalTicketsLabel.Text = "0";
            this.TotalTicketsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Next available entry:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total tickets outstanding:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GuestsEnterLabel);
            this.groupBox1.Location = new System.Drawing.Point(34, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(272, 78);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guests with the following tickets may now enter:";
            // 
            // GuestsEnterLabel
            // 
            this.GuestsEnterLabel.Location = new System.Drawing.Point(6, 35);
            this.GuestsEnterLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.GuestsEnterLabel.Name = "GuestsEnterLabel";
            this.GuestsEnterLabel.Size = new System.Drawing.Size(92, 13);
            this.GuestsEnterLabel.TabIndex = 6;
            this.GuestsEnterLabel.Text = "0";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(117, 446);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(1);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(98, 23);
            this.ExitBtn.TabIndex = 8;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(34, 273);
            this.listBox1.Margin = new System.Windows.Forms.Padding(1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(274, 160);
            this.listBox1.TabIndex = 6;
            // 
            // TitleBarTime
            // 
            this.TitleBarTime.Interval = 1000;
            this.TitleBarTime.Tick += new System.EventHandler(this.TitleBarTime_Tick);
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 479);
            this.Controls.Add(this.IssueTicketBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.listBox1);
            this.Name = "TicketForm";
            this.Text = "0:00:00";
            this.Load += new System.EventHandler(this.TicketForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IssueTicketBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label NextEntryLabel;
        private System.Windows.Forms.Label TotalTicketsLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label GuestsEnterLabel;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer TitleBarTime;
    }
}


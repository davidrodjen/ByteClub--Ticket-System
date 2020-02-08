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
            this.OptionsBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TitleBarTime = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IssueTicketBtn
            // 
            this.IssueTicketBtn.Location = new System.Drawing.Point(45, 279);
            this.IssueTicketBtn.Margin = new System.Windows.Forms.Padding(1);
            this.IssueTicketBtn.Name = "IssueTicketBtn";
            this.IssueTicketBtn.Size = new System.Drawing.Size(149, 28);
            this.IssueTicketBtn.TabIndex = 11;
            this.IssueTicketBtn.Text = "Issue Ticket";
            this.IssueTicketBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NextEntryLabel);
            this.groupBox2.Controls.Add(this.TotalTicketsLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(45, 121);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox2.Size = new System.Drawing.Size(364, 148);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticket Availability";
            // 
            // NextEntryLabel
            // 
            this.NextEntryLabel.Location = new System.Drawing.Point(187, 90);
            this.NextEntryLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.NextEntryLabel.Name = "NextEntryLabel";
            this.NextEntryLabel.Size = new System.Drawing.Size(120, 20);
            this.NextEntryLabel.TabIndex = 3;
            this.NextEntryLabel.Text = "0";
            this.NextEntryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalTicketsLabel
            // 
            this.TotalTicketsLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TotalTicketsLabel.Location = new System.Drawing.Point(187, 41);
            this.TotalTicketsLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.TotalTicketsLabel.Name = "TotalTicketsLabel";
            this.TotalTicketsLabel.Size = new System.Drawing.Size(120, 20);
            this.TotalTicketsLabel.TabIndex = 2;
            this.TotalTicketsLabel.Text = "0";
            this.TotalTicketsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Next available entry:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total tickets outstanding:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GuestsEnterLabel);
            this.groupBox1.Location = new System.Drawing.Point(45, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(363, 96);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guests with the following tickets may now enter:";
            // 
            // GuestsEnterLabel
            // 
            this.GuestsEnterLabel.Location = new System.Drawing.Point(8, 43);
            this.GuestsEnterLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.GuestsEnterLabel.Name = "GuestsEnterLabel";
            this.GuestsEnterLabel.Size = new System.Drawing.Size(123, 16);
            this.GuestsEnterLabel.TabIndex = 6;
            this.GuestsEnterLabel.Text = "0";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(277, 533);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(1);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(131, 28);
            this.ExitBtn.TabIndex = 8;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // OptionsBtn
            // 
            this.OptionsBtn.Location = new System.Drawing.Point(266, 279);
            this.OptionsBtn.Margin = new System.Windows.Forms.Padding(1);
            this.OptionsBtn.Name = "OptionsBtn";
            this.OptionsBtn.Size = new System.Drawing.Size(143, 28);
            this.OptionsBtn.TabIndex = 7;
            this.OptionsBtn.Text = "Options";
            this.OptionsBtn.UseVisualStyleBackColor = true;
            this.OptionsBtn.Click += new System.EventHandler(this.OptionsBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(45, 322);
            this.listBox1.Margin = new System.Windows.Forms.Padding(1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(364, 196);
            this.listBox1.TabIndex = 6;
            // 
            // TitleBarTime
            // 
            this.TitleBarTime.Interval = 1000;
            this.TitleBarTime.Tick += new System.EventHandler(this.TitleBarTime_Tick);
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 576);
            this.Controls.Add(this.IssueTicketBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.OptionsBtn);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TicketForm";
            this.Text = "0:00:00";
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
        private System.Windows.Forms.Button OptionsBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer TitleBarTime;
    }
}


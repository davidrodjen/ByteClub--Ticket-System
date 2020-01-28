namespace ByteClubGroupTicketSystem
{
    partial class OptionsForm
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
            this.OkBtn = new System.Windows.Forms.Button();
            this.GuestsPerWindowTxt = new System.Windows.Forms.TextBox();
            this.StartTimeTxt = new System.Windows.Forms.TextBox();
            this.FirstTicketNumTxt = new System.Windows.Forms.TextBox();
            this.EndTimeTxt = new System.Windows.Forms.TextBox();
            this.MinutesPerWindowTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(143, 219);
            this.OkBtn.Margin = new System.Windows.Forms.Padding(1);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(111, 20);
            this.OkBtn.TabIndex = 16;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // GuestsPerWindowTxt
            // 
            this.GuestsPerWindowTxt.Location = new System.Drawing.Point(143, 65);
            this.GuestsPerWindowTxt.Margin = new System.Windows.Forms.Padding(1);
            this.GuestsPerWindowTxt.Name = "GuestsPerWindowTxt";
            this.GuestsPerWindowTxt.Size = new System.Drawing.Size(113, 20);
            this.GuestsPerWindowTxt.TabIndex = 8;
            // 
            // StartTimeTxt
            // 
            this.StartTimeTxt.Location = new System.Drawing.Point(143, 103);
            this.StartTimeTxt.Margin = new System.Windows.Forms.Padding(1);
            this.StartTimeTxt.Name = "StartTimeTxt";
            this.StartTimeTxt.Size = new System.Drawing.Size(113, 20);
            this.StartTimeTxt.TabIndex = 10;
            // 
            // FirstTicketNumTxt
            // 
            this.FirstTicketNumTxt.Location = new System.Drawing.Point(143, 175);
            this.FirstTicketNumTxt.Margin = new System.Windows.Forms.Padding(1);
            this.FirstTicketNumTxt.Name = "FirstTicketNumTxt";
            this.FirstTicketNumTxt.Size = new System.Drawing.Size(113, 20);
            this.FirstTicketNumTxt.TabIndex = 14;
            // 
            // EndTimeTxt
            // 
            this.EndTimeTxt.Location = new System.Drawing.Point(143, 139);
            this.EndTimeTxt.Margin = new System.Windows.Forms.Padding(1);
            this.EndTimeTxt.Name = "EndTimeTxt";
            this.EndTimeTxt.Size = new System.Drawing.Size(113, 20);
            this.EndTimeTxt.TabIndex = 12;
            // 
            // MinutesPerWindowTxt
            // 
            this.MinutesPerWindowTxt.Location = new System.Drawing.Point(143, 30);
            this.MinutesPerWindowTxt.Margin = new System.Windows.Forms.Padding(1);
            this.MinutesPerWindowTxt.Name = "MinutesPerWindowTxt";
            this.MinutesPerWindowTxt.Size = new System.Drawing.Size(113, 20);
            this.MinutesPerWindowTxt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "First ticket number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Start time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "End time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Guests per window:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Minutes per window:";
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 265);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.GuestsPerWindowTxt);
            this.Controls.Add(this.StartTimeTxt);
            this.Controls.Add(this.FirstTicketNumTxt);
            this.Controls.Add(this.EndTimeTxt);
            this.Controls.Add(this.MinutesPerWindowTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OptionsForm";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.TextBox GuestsPerWindowTxt;
        private System.Windows.Forms.TextBox StartTimeTxt;
        private System.Windows.Forms.TextBox FirstTicketNumTxt;
        private System.Windows.Forms.TextBox EndTimeTxt;
        private System.Windows.Forms.TextBox MinutesPerWindowTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
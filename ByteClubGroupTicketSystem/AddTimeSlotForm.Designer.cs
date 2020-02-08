namespace ByteClubGroupTicketSystem
{
    partial class AddTimeSlotForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartTimeTxt = new System.Windows.Forms.TextBox();
            this.EndTimeTxt = new System.Windows.Forms.TextBox();
            this.AddTimeSlotBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "End Time:";
            // 
            // StartTimeTxt
            // 
            this.StartTimeTxt.Location = new System.Drawing.Point(86, 19);
            this.StartTimeTxt.Name = "StartTimeTxt";
            this.StartTimeTxt.Size = new System.Drawing.Size(100, 20);
            this.StartTimeTxt.TabIndex = 2;
            // 
            // EndTimeTxt
            // 
            this.EndTimeTxt.Location = new System.Drawing.Point(86, 50);
            this.EndTimeTxt.Name = "EndTimeTxt";
            this.EndTimeTxt.Size = new System.Drawing.Size(100, 20);
            this.EndTimeTxt.TabIndex = 3;
            // 
            // AddTimeSlotBtn
            // 
            this.AddTimeSlotBtn.Location = new System.Drawing.Point(205, 47);
            this.AddTimeSlotBtn.Name = "AddTimeSlotBtn";
            this.AddTimeSlotBtn.Size = new System.Drawing.Size(82, 23);
            this.AddTimeSlotBtn.TabIndex = 4;
            this.AddTimeSlotBtn.Text = "Add Time Slot";
            this.AddTimeSlotBtn.UseVisualStyleBackColor = true;
            this.AddTimeSlotBtn.Click += new System.EventHandler(this.AddTimeSlotBtn_Click);
            // 
            // AddTimeSlotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 93);
            this.Controls.Add(this.AddTimeSlotBtn);
            this.Controls.Add(this.EndTimeTxt);
            this.Controls.Add(this.StartTimeTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddTimeSlotForm";
            this.Text = "AddTimeSlotForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StartTimeTxt;
        private System.Windows.Forms.TextBox EndTimeTxt;
        private System.Windows.Forms.Button AddTimeSlotBtn;
    }
}
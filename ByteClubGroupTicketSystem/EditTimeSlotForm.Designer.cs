namespace ByteClubGroupTicketSystem
{
    partial class EditTimeSlotForm
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
            this.EditTimeSlotBtn = new System.Windows.Forms.Button();
            this.EndTimeTxt = new System.Windows.Forms.TextBox();
            this.StartTimeTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditTimeSlotBtn
            // 
            this.EditTimeSlotBtn.Location = new System.Drawing.Point(206, 50);
            this.EditTimeSlotBtn.Name = "EditTimeSlotBtn";
            this.EditTimeSlotBtn.Size = new System.Drawing.Size(82, 23);
            this.EditTimeSlotBtn.TabIndex = 9;
            this.EditTimeSlotBtn.Text = "Edit Time Slot";
            this.EditTimeSlotBtn.UseVisualStyleBackColor = true;
            this.EditTimeSlotBtn.Click += new System.EventHandler(this.EditTimeSlotBtn_Click);
            // 
            // EndTimeTxt
            // 
            this.EndTimeTxt.Location = new System.Drawing.Point(87, 53);
            this.EndTimeTxt.Name = "EndTimeTxt";
            this.EndTimeTxt.Size = new System.Drawing.Size(100, 20);
            this.EndTimeTxt.TabIndex = 8;
            // 
            // StartTimeTxt
            // 
            this.StartTimeTxt.Location = new System.Drawing.Point(87, 22);
            this.StartTimeTxt.Name = "StartTimeTxt";
            this.StartTimeTxt.Size = new System.Drawing.Size(100, 20);
            this.StartTimeTxt.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "End Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start Time:";
            // 
            // EditTimeSlotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 92);
            this.Controls.Add(this.EditTimeSlotBtn);
            this.Controls.Add(this.EndTimeTxt);
            this.Controls.Add(this.StartTimeTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditTimeSlotForm";
            this.Text = "EditTimeSlotForm";
            this.Load += new System.EventHandler(this.EditTimeSlotForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditTimeSlotBtn;
        private System.Windows.Forms.TextBox EndTimeTxt;
        private System.Windows.Forms.TextBox StartTimeTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
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
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.NumGuests = new System.Windows.Forms.Label();
            this.AttractionName = new System.Windows.Forms.Label();
            this.AttractionNameCbox = new System.Windows.Forms.ComboBox();
            this.TimeSlots = new System.Windows.Forms.Label();
            this.TimeSlotCbox = new System.Windows.Forms.ComboBox();
            this.AddAttractionBtn = new System.Windows.Forms.Button();
            this.EditAttractionBtn = new System.Windows.Forms.Button();
            this.DeleteAttractionBtn = new System.Windows.Forms.Button();
            this.DeleteTimeSlotBtn = new System.Windows.Forms.Button();
            this.EditTimeSlotBtn = new System.Windows.Forms.Button();
            this.AddTimeSlotBtn = new System.Windows.Forms.Button();
            this.NumberOfGuestsTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(274, 237);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(1);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(137, 37);
            this.SubmitBtn.TabIndex = 16;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // NumGuests
            // 
            this.NumGuests.AutoSize = true;
            this.NumGuests.Location = new System.Drawing.Point(85, 237);
            this.NumGuests.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.NumGuests.Name = "NumGuests";
            this.NumGuests.Size = new System.Drawing.Size(97, 13);
            this.NumGuests.TabIndex = 9;
            this.NumGuests.Text = "Number Of Guests:";
            // 
            // AttractionName
            // 
            this.AttractionName.AutoSize = true;
            this.AttractionName.Location = new System.Drawing.Point(109, 24);
            this.AttractionName.Name = "AttractionName";
            this.AttractionName.Size = new System.Drawing.Size(55, 13);
            this.AttractionName.TabIndex = 17;
            this.AttractionName.Text = "Attraction:";
            // 
            // AttractionNameCbox
            // 
            this.AttractionNameCbox.FormattingEnabled = true;
            this.AttractionNameCbox.Location = new System.Drawing.Point(20, 40);
            this.AttractionNameCbox.Name = "AttractionNameCbox";
            this.AttractionNameCbox.Size = new System.Drawing.Size(228, 21);
            this.AttractionNameCbox.TabIndex = 19;
            // 
            // TimeSlots
            // 
            this.TimeSlots.AutoSize = true;
            this.TimeSlots.Location = new System.Drawing.Point(109, 130);
            this.TimeSlots.Name = "TimeSlots";
            this.TimeSlots.Size = new System.Drawing.Size(54, 13);
            this.TimeSlots.TabIndex = 20;
            this.TimeSlots.Text = "Time Slot:";
            // 
            // TimeSlotCbox
            // 
            this.TimeSlotCbox.FormattingEnabled = true;
            this.TimeSlotCbox.Location = new System.Drawing.Point(20, 147);
            this.TimeSlotCbox.Name = "TimeSlotCbox";
            this.TimeSlotCbox.Size = new System.Drawing.Size(228, 21);
            this.TimeSlotCbox.TabIndex = 21;
            // 
            // AddAttractionBtn
            // 
            this.AddAttractionBtn.Location = new System.Drawing.Point(274, 12);
            this.AddAttractionBtn.Name = "AddAttractionBtn";
            this.AddAttractionBtn.Size = new System.Drawing.Size(137, 37);
            this.AddAttractionBtn.TabIndex = 22;
            this.AddAttractionBtn.Text = "Add Attraction";
            this.AddAttractionBtn.UseVisualStyleBackColor = true;
            this.AddAttractionBtn.Click += new System.EventHandler(this.AddAttractionBtn_Click);
            // 
            // EditAttractionBtn
            // 
            this.EditAttractionBtn.Location = new System.Drawing.Point(274, 55);
            this.EditAttractionBtn.Name = "EditAttractionBtn";
            this.EditAttractionBtn.Size = new System.Drawing.Size(64, 23);
            this.EditAttractionBtn.TabIndex = 23;
            this.EditAttractionBtn.Text = "Edit";
            this.EditAttractionBtn.UseVisualStyleBackColor = true;
            this.EditAttractionBtn.Click += new System.EventHandler(this.EditAttractionBtn_Click);
            // 
            // DeleteAttractionBtn
            // 
            this.DeleteAttractionBtn.Location = new System.Drawing.Point(344, 55);
            this.DeleteAttractionBtn.Name = "DeleteAttractionBtn";
            this.DeleteAttractionBtn.Size = new System.Drawing.Size(67, 23);
            this.DeleteAttractionBtn.TabIndex = 24;
            this.DeleteAttractionBtn.Text = "Delete";
            this.DeleteAttractionBtn.UseVisualStyleBackColor = true;
            this.DeleteAttractionBtn.Click += new System.EventHandler(this.DeleteAttractionBtn_Click);
            // 
            // DeleteTimeSlotBtn
            // 
            this.DeleteTimeSlotBtn.Location = new System.Drawing.Point(344, 161);
            this.DeleteTimeSlotBtn.Name = "DeleteTimeSlotBtn";
            this.DeleteTimeSlotBtn.Size = new System.Drawing.Size(67, 23);
            this.DeleteTimeSlotBtn.TabIndex = 27;
            this.DeleteTimeSlotBtn.Text = "Delete";
            this.DeleteTimeSlotBtn.UseVisualStyleBackColor = true;
            // 
            // EditTimeSlotBtn
            // 
            this.EditTimeSlotBtn.Location = new System.Drawing.Point(274, 161);
            this.EditTimeSlotBtn.Name = "EditTimeSlotBtn";
            this.EditTimeSlotBtn.Size = new System.Drawing.Size(64, 23);
            this.EditTimeSlotBtn.TabIndex = 26;
            this.EditTimeSlotBtn.Text = "Edit";
            this.EditTimeSlotBtn.UseVisualStyleBackColor = true;
            // 
            // AddTimeSlotBtn
            // 
            this.AddTimeSlotBtn.Location = new System.Drawing.Point(274, 118);
            this.AddTimeSlotBtn.Name = "AddTimeSlotBtn";
            this.AddTimeSlotBtn.Size = new System.Drawing.Size(137, 37);
            this.AddTimeSlotBtn.TabIndex = 25;
            this.AddTimeSlotBtn.Text = "Add Time Slot";
            this.AddTimeSlotBtn.UseVisualStyleBackColor = true;
            // 
            // NumberOfGuestsTxt
            // 
            this.NumberOfGuestsTxt.Location = new System.Drawing.Point(20, 253);
            this.NumberOfGuestsTxt.Name = "NumberOfGuestsTxt";
            this.NumberOfGuestsTxt.Size = new System.Drawing.Size(228, 20);
            this.NumberOfGuestsTxt.TabIndex = 28;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 299);
            this.Controls.Add(this.NumberOfGuestsTxt);
            this.Controls.Add(this.DeleteTimeSlotBtn);
            this.Controls.Add(this.EditTimeSlotBtn);
            this.Controls.Add(this.AddTimeSlotBtn);
            this.Controls.Add(this.DeleteAttractionBtn);
            this.Controls.Add(this.EditAttractionBtn);
            this.Controls.Add(this.AddAttractionBtn);
            this.Controls.Add(this.TimeSlotCbox);
            this.Controls.Add(this.TimeSlots);
            this.Controls.Add(this.AttractionNameCbox);
            this.Controls.Add(this.AttractionName);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.NumGuests);
            this.Name = "OptionsForm";
            this.Text = "Pass Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label NumGuests;
        private System.Windows.Forms.Label AttractionName;
        private System.Windows.Forms.ComboBox AttractionNameCbox;
        private System.Windows.Forms.Label TimeSlots;
        private System.Windows.Forms.ComboBox TimeSlotCbox;
        private System.Windows.Forms.Button AddAttractionBtn;
        private System.Windows.Forms.Button EditAttractionBtn;
        private System.Windows.Forms.Button DeleteAttractionBtn;
        private System.Windows.Forms.Button DeleteTimeSlotBtn;
        private System.Windows.Forms.Button EditTimeSlotBtn;
        private System.Windows.Forms.Button AddTimeSlotBtn;
        private System.Windows.Forms.TextBox NumberOfGuestsTxt;
    }
}
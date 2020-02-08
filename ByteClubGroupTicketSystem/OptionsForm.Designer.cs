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
            this.NumGuestsCbox = new System.Windows.Forms.ComboBox();
            this.AttractionNameCbox = new System.Windows.Forms.ComboBox();
            this.TimeSlots = new System.Windows.Forms.Label();
            this.TimeSlotCbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(62, 167);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(1);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(160, 52);
            this.SubmitBtn.TabIndex = 16;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // NumGuests
            // 
            this.NumGuests.AutoSize = true;
            this.NumGuests.Location = new System.Drawing.Point(31, 115);
            this.NumGuests.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.NumGuests.Name = "NumGuests";
            this.NumGuests.Size = new System.Drawing.Size(97, 13);
            this.NumGuests.TabIndex = 9;
            this.NumGuests.Text = "Number Of Guests:";
            // 
            // AttractionName
            // 
            this.AttractionName.AutoSize = true;
            this.AttractionName.Location = new System.Drawing.Point(31, 29);
            this.AttractionName.Name = "AttractionName";
            this.AttractionName.Size = new System.Drawing.Size(55, 13);
            this.AttractionName.TabIndex = 17;
            this.AttractionName.Text = "Attraction:";
            // 
            // NumGuestsCbox
            // 
            this.NumGuestsCbox.FormattingEnabled = true;
            this.NumGuestsCbox.Location = new System.Drawing.Point(149, 115);
            this.NumGuestsCbox.Name = "NumGuestsCbox";
            this.NumGuestsCbox.Size = new System.Drawing.Size(121, 21);
            this.NumGuestsCbox.TabIndex = 18;
            this.NumGuestsCbox.SelectedIndexChanged += new System.EventHandler(this.NumGuestsCbox_SelectedIndexChanged);
            // 
            // AttractionNameCbox
            // 
            this.AttractionNameCbox.FormattingEnabled = true;
            this.AttractionNameCbox.Location = new System.Drawing.Point(149, 29);
            this.AttractionNameCbox.Name = "AttractionNameCbox";
            this.AttractionNameCbox.Size = new System.Drawing.Size(121, 21);
            this.AttractionNameCbox.TabIndex = 19;
            this.AttractionNameCbox.SelectedIndexChanged += new System.EventHandler(this.AttractionNameCbox_SelectedIndexChanged);
            // 
            // TimeSlots
            // 
            this.TimeSlots.AutoSize = true;
            this.TimeSlots.Location = new System.Drawing.Point(31, 71);
            this.TimeSlots.Name = "TimeSlots";
            this.TimeSlots.Size = new System.Drawing.Size(54, 13);
            this.TimeSlots.TabIndex = 20;
            this.TimeSlots.Text = "Time Slot:";
            // 
            // TimeSlotCbox
            // 
            this.TimeSlotCbox.FormattingEnabled = true;
            this.TimeSlotCbox.Location = new System.Drawing.Point(149, 71);
            this.TimeSlotCbox.Name = "TimeSlotCbox";
            this.TimeSlotCbox.Size = new System.Drawing.Size(121, 21);
            this.TimeSlotCbox.TabIndex = 21;
            this.TimeSlotCbox.SelectedIndexChanged += new System.EventHandler(this.TimeSlotCbox_SelectedIndexChanged);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 238);
            this.Controls.Add(this.TimeSlotCbox);
            this.Controls.Add(this.TimeSlots);
            this.Controls.Add(this.AttractionNameCbox);
            this.Controls.Add(this.NumGuestsCbox);
            this.Controls.Add(this.AttractionName);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.NumGuests);
            this.Name = "OptionsForm";
            this.Text = "Pass Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label NumGuests;
        private System.Windows.Forms.Label AttractionName;
        private System.Windows.Forms.ComboBox NumGuestsCbox;
        private System.Windows.Forms.ComboBox AttractionNameCbox;
        private System.Windows.Forms.Label TimeSlots;
        private System.Windows.Forms.ComboBox TimeSlotCbox;
    }
}
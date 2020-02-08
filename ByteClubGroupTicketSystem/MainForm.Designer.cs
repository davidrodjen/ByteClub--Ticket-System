namespace ByteClubGroupTicketSystem
{
    partial class MainForm
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
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ticketPurchase = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TicketsAvailLbl = new System.Windows.Forms.Label();
            this.TicketsPurcLbl = new System.Windows.Forms.Label();
            this.TicketsAvailtxtbx = new System.Windows.Forms.TextBox();
            this.TicketsPurchasedTxtBx = new System.Windows.Forms.TextBox();
            this.ParkHoursTxtBx = new System.Windows.Forms.TextBox();
            this.ParkHrOpenLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(37, 209);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(170, 39);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ticketPurchase
            // 
            this.ticketPurchase.Location = new System.Drawing.Point(213, 209);
            this.ticketPurchase.Name = "ticketPurchase";
            this.ticketPurchase.Size = new System.Drawing.Size(150, 39);
            this.ticketPurchase.TabIndex = 1;
            this.ticketPurchase.Text = "Purchase Ticket";
            this.ticketPurchase.UseVisualStyleBackColor = true;
            this.ticketPurchase.Click += new System.EventHandler(this.TicketPurchase_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ParkHrOpenLbl);
            this.groupBox1.Controls.Add(this.ParkHoursTxtBx);
            this.groupBox1.Controls.Add(this.TicketsPurchasedTxtBx);
            this.groupBox1.Controls.Add(this.TicketsAvailtxtbx);
            this.groupBox1.Controls.Add(this.TicketsPurcLbl);
            this.groupBox1.Controls.Add(this.TicketsAvailLbl);
            this.groupBox1.Location = new System.Drawing.Point(37, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 154);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ticket Availability";
            // 
            // TicketsAvailLbl
            // 
            this.TicketsAvailLbl.AutoSize = true;
            this.TicketsAvailLbl.Location = new System.Drawing.Point(21, 30);
            this.TicketsAvailLbl.Name = "TicketsAvailLbl";
            this.TicketsAvailLbl.Size = new System.Drawing.Size(114, 17);
            this.TicketsAvailLbl.TabIndex = 0;
            this.TicketsAvailLbl.Text = "Tickets Available";
            // 
            // TicketsPurcLbl
            // 
            this.TicketsPurcLbl.AutoSize = true;
            this.TicketsPurcLbl.Location = new System.Drawing.Point(21, 66);
            this.TicketsPurcLbl.Name = "TicketsPurcLbl";
            this.TicketsPurcLbl.Size = new System.Drawing.Size(125, 17);
            this.TicketsPurcLbl.TabIndex = 1;
            this.TicketsPurcLbl.Text = "Tickets Purchased";
            // 
            // TicketsAvailtxtbx
            // 
            this.TicketsAvailtxtbx.Enabled = false;
            this.TicketsAvailtxtbx.Location = new System.Drawing.Point(157, 25);
            this.TicketsAvailtxtbx.Name = "TicketsAvailtxtbx";
            this.TicketsAvailtxtbx.Size = new System.Drawing.Size(142, 22);
            this.TicketsAvailtxtbx.TabIndex = 2;
            // 
            // TicketsPurchasedTxtBx
            // 
            this.TicketsPurchasedTxtBx.Enabled = false;
            this.TicketsPurchasedTxtBx.Location = new System.Drawing.Point(157, 61);
            this.TicketsPurchasedTxtBx.Name = "TicketsPurchasedTxtBx";
            this.TicketsPurchasedTxtBx.Size = new System.Drawing.Size(142, 22);
            this.TicketsPurchasedTxtBx.TabIndex = 3;
            // 
            // ParkHoursTxtBx
            // 
            this.ParkHoursTxtBx.Enabled = false;
            this.ParkHoursTxtBx.Location = new System.Drawing.Point(157, 95);
            this.ParkHoursTxtBx.Name = "ParkHoursTxtBx";
            this.ParkHoursTxtBx.Size = new System.Drawing.Size(142, 22);
            this.ParkHoursTxtBx.TabIndex = 4;
            // 
            // ParkHrOpenLbl
            // 
            this.ParkHrOpenLbl.AutoSize = true;
            this.ParkHrOpenLbl.Location = new System.Drawing.Point(21, 100);
            this.ParkHrOpenLbl.Name = "ParkHrOpenLbl";
            this.ParkHrOpenLbl.Size = new System.Drawing.Size(118, 17);
            this.ParkHrOpenLbl.TabIndex = 5;
            this.ParkHrOpenLbl.Text = "Park Hours/Open";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(406, 291);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ticketPurchase);
            this.Controls.Add(this.ExitBtn);
            this.Name = "MainForm";
            this.Text = "Park Ticket Availability";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button ticketPurchase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ParkHrOpenLbl;
        private System.Windows.Forms.TextBox ParkHoursTxtBx;
        private System.Windows.Forms.TextBox TicketsPurchasedTxtBx;
        private System.Windows.Forms.TextBox TicketsAvailtxtbx;
        private System.Windows.Forms.Label TicketsPurcLbl;
        private System.Windows.Forms.Label TicketsAvailLbl;
    }
}
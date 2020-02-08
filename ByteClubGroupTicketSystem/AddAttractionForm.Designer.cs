namespace ByteClubGroupTicketSystem
{
    partial class AddAttractionForm
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
            this.AttractionNameTxt = new System.Windows.Forms.TextBox();
            this.AddAttractionNameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attraction Name:";
            // 
            // AttractionNameTxt
            // 
            this.AttractionNameTxt.Location = new System.Drawing.Point(104, 23);
            this.AttractionNameTxt.Name = "AttractionNameTxt";
            this.AttractionNameTxt.Size = new System.Drawing.Size(161, 20);
            this.AttractionNameTxt.TabIndex = 1;
            // 
            // AddAttractionNameBtn
            // 
            this.AddAttractionNameBtn.Location = new System.Drawing.Point(126, 60);
            this.AddAttractionNameBtn.Name = "AddAttractionNameBtn";
            this.AddAttractionNameBtn.Size = new System.Drawing.Size(121, 23);
            this.AddAttractionNameBtn.TabIndex = 2;
            this.AddAttractionNameBtn.Text = "Add Attraction";
            this.AddAttractionNameBtn.UseVisualStyleBackColor = true;
            this.AddAttractionNameBtn.Click += new System.EventHandler(this.AddAttractionNameBtn_Click);
            // 
            // AddAttractionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 95);
            this.Controls.Add(this.AddAttractionNameBtn);
            this.Controls.Add(this.AttractionNameTxt);
            this.Controls.Add(this.label1);
            this.Name = "AddAttractionForm";
            this.Text = "Add Attraction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AttractionNameTxt;
        private System.Windows.Forms.Button AddAttractionNameBtn;
    }
}
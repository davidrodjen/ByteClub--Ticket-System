namespace ByteClubGroupTicketSystem
{
    partial class EditAttractionForm
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
            this.EditAttractionNameBtn = new System.Windows.Forms.Button();
            this.AttractionNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditAttractionNameBtn
            // 
            this.EditAttractionNameBtn.Location = new System.Drawing.Point(127, 62);
            this.EditAttractionNameBtn.Name = "EditAttractionNameBtn";
            this.EditAttractionNameBtn.Size = new System.Drawing.Size(121, 23);
            this.EditAttractionNameBtn.TabIndex = 5;
            this.EditAttractionNameBtn.Text = "Edit Attraction";
            this.EditAttractionNameBtn.UseVisualStyleBackColor = true;
            this.EditAttractionNameBtn.Click += new System.EventHandler(this.EditAttractionNameBtn_Click);
            // 
            // AttractionNameTxt
            // 
            this.AttractionNameTxt.Location = new System.Drawing.Point(105, 25);
            this.AttractionNameTxt.Name = "AttractionNameTxt";
            this.AttractionNameTxt.Size = new System.Drawing.Size(161, 20);
            this.AttractionNameTxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Attraction Name:";
            // 
            // EditAttractionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 95);
            this.Controls.Add(this.EditAttractionNameBtn);
            this.Controls.Add(this.AttractionNameTxt);
            this.Controls.Add(this.label1);
            this.Name = "EditAttractionForm";
            this.Text = "EditAttractionForm";
            this.Load += new System.EventHandler(this.EditAttractionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditAttractionNameBtn;
        private System.Windows.Forms.TextBox AttractionNameTxt;
        private System.Windows.Forms.Label label1;
    }
}
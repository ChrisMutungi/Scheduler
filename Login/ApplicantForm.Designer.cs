namespace Scheduling_Interviews.Login
{
    partial class ApplicantForm
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
            this.Approvebutton = new System.Windows.Forms.Button();
            this.Approveallbutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            this.ApplicantlistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Successful Applicants";
            // 
            // Approvebutton
            // 
            this.Approvebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Approvebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Approvebutton.Location = new System.Drawing.Point(571, 120);
            this.Approvebutton.Name = "Approvebutton";
            this.Approvebutton.Size = new System.Drawing.Size(108, 23);
            this.Approvebutton.TabIndex = 1;
            this.Approvebutton.Text = "Approve";
            this.Approvebutton.UseVisualStyleBackColor = true;
            // 
            // Approveallbutton
            // 
            this.Approveallbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Approveallbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Approveallbutton.Location = new System.Drawing.Point(571, 251);
            this.Approveallbutton.Name = "Approveallbutton";
            this.Approveallbutton.Size = new System.Drawing.Size(108, 23);
            this.Approveallbutton.TabIndex = 3;
            this.Approveallbutton.Text = "Approve All";
            this.Approveallbutton.UseVisualStyleBackColor = true;
            // 
            // Exitbutton
            // 
            this.Exitbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.Location = new System.Drawing.Point(466, 370);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 23);
            this.Exitbutton.TabIndex = 5;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            // 
            // Backbutton
            // 
            this.Backbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.Location = new System.Drawing.Point(133, 370);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(75, 23);
            this.Backbutton.TabIndex = 6;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // ApplicantlistBox
            // 
            this.ApplicantlistBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplicantlistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicantlistBox.FormattingEnabled = true;
            this.ApplicantlistBox.ItemHeight = 20;
            this.ApplicantlistBox.Location = new System.Drawing.Point(49, 110);
            this.ApplicantlistBox.MultiColumn = true;
            this.ApplicantlistBox.Name = "ApplicantlistBox";
            this.ApplicantlistBox.Size = new System.Drawing.Size(516, 224);
            this.ApplicantlistBox.TabIndex = 7;
            // 
            // ApplicantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 423);
            this.Controls.Add(this.ApplicantlistBox);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Approveallbutton);
            this.Controls.Add(this.Approvebutton);
            this.Controls.Add(this.label1);
            this.Name = "ApplicantForm";
            this.Text = "ApplicantForm";
            this.Load += new System.EventHandler(this.ApplicantForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Approvebutton;
        private System.Windows.Forms.Button Approveallbutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.ListBox ApplicantlistBox;
    }
}
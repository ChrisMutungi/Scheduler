namespace Scheduling_Interviews
{
    partial class scheduleUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkbutton = new System.Windows.Forms.Button();
            this.candidateslistBox = new System.Windows.Forms.ListBox();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Removebutton = new System.Windows.Forms.Button();
            this.removeallbutton = new System.Windows.Forms.Button();
            this.startbutton = new System.Windows.Forms.Button();
            this.setbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkbutton
            // 
            this.checkbutton.Location = new System.Drawing.Point(32, 61);
            this.checkbutton.Name = "checkbutton";
            this.checkbutton.Size = new System.Drawing.Size(194, 23);
            this.checkbutton.TabIndex = 0;
            this.checkbutton.Text = "Check Shortilisted Candidates";
            this.checkbutton.UseVisualStyleBackColor = true;
            // 
            // candidateslistBox
            // 
            this.candidateslistBox.FormattingEnabled = true;
            this.candidateslistBox.Location = new System.Drawing.Point(21, 113);
            this.candidateslistBox.Name = "candidateslistBox";
            this.candidateslistBox.Size = new System.Drawing.Size(573, 225);
            this.candidateslistBox.TabIndex = 1;
            this.candidateslistBox.Visible = false;
            // 
            // Exitbutton
            // 
            this.Exitbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exitbutton.AutoSize = true;
            this.Exitbutton.Location = new System.Drawing.Point(554, 417);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 35);
            this.Exitbutton.TabIndex = 3;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(600, 160);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(119, 23);
            this.Addbutton.TabIndex = 7;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            // 
            // Removebutton
            // 
            this.Removebutton.Location = new System.Drawing.Point(600, 216);
            this.Removebutton.Name = "Removebutton";
            this.Removebutton.Size = new System.Drawing.Size(119, 23);
            this.Removebutton.TabIndex = 8;
            this.Removebutton.Text = "Remove";
            this.Removebutton.UseVisualStyleBackColor = true;
            // 
            // removeallbutton
            // 
            this.removeallbutton.Location = new System.Drawing.Point(600, 268);
            this.removeallbutton.Name = "removeallbutton";
            this.removeallbutton.Size = new System.Drawing.Size(119, 23);
            this.removeallbutton.TabIndex = 9;
            this.removeallbutton.Text = "Remove All";
            this.removeallbutton.UseVisualStyleBackColor = true;
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(409, 61);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(144, 23);
            this.startbutton.TabIndex = 6;
            this.startbutton.Text = "Set Interview Date";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // setbutton
            // 
            this.setbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.setbutton.Location = new System.Drawing.Point(59, 417);
            this.setbutton.Name = "setbutton";
            this.setbutton.Size = new System.Drawing.Size(202, 35);
            this.setbutton.TabIndex = 10;
            this.setbutton.Text = "Schedule Interviews And Notify Candidates";
            this.setbutton.UseVisualStyleBackColor = true;
            // 
            // scheduleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.setbutton);
            this.Controls.Add(this.removeallbutton);
            this.Controls.Add(this.Removebutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.candidateslistBox);
            this.Controls.Add(this.checkbutton);
            this.Name = "scheduleUserControl";
            this.Size = new System.Drawing.Size(760, 527);
            this.Load += new System.EventHandler(this.scheduleUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkbutton;
        private System.Windows.Forms.ListBox candidateslistBox;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Removebutton;
        private System.Windows.Forms.Button removeallbutton;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button setbutton;
    }
}

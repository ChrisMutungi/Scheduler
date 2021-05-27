namespace Scheduling_Interviews.Login
{
    partial class OptionForm
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
            this.sessiontabControl = new System.Windows.Forms.TabControl();
            this.scheduletabPage = new System.Windows.Forms.TabPage();
            this.schedulelabel = new System.Windows.Forms.Label();
            this.sessiontabPage = new System.Windows.Forms.TabPage();
            this.sessionabel = new System.Windows.Forms.Label();
            this.Confirmbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.welcomelabel = new System.Windows.Forms.Label();
            this.sessiontabControl.SuspendLayout();
            this.scheduletabPage.SuspendLayout();
            this.sessiontabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // sessiontabControl
            // 
            this.sessiontabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sessiontabControl.Controls.Add(this.scheduletabPage);
            this.sessiontabControl.Controls.Add(this.sessiontabPage);
            this.sessiontabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessiontabControl.Location = new System.Drawing.Point(22, 56);
            this.sessiontabControl.Name = "sessiontabControl";
            this.sessiontabControl.SelectedIndex = 0;
            this.sessiontabControl.Size = new System.Drawing.Size(975, 324);
            this.sessiontabControl.TabIndex = 0;
            this.sessiontabControl.Tag = "";
            // 
            // scheduletabPage
            // 
            this.scheduletabPage.Controls.Add(this.schedulelabel);
            this.scheduletabPage.Location = new System.Drawing.Point(4, 29);
            this.scheduletabPage.Name = "scheduletabPage";
            this.scheduletabPage.Padding = new System.Windows.Forms.Padding(3);
            this.scheduletabPage.Size = new System.Drawing.Size(967, 291);
            this.scheduletabPage.TabIndex = 0;
            this.scheduletabPage.Text = "Schedule Interviews";
            this.scheduletabPage.UseVisualStyleBackColor = true;
            this.scheduletabPage.Click += new System.EventHandler(this.scheduletabPage_Click);
            // 
            // schedulelabel
            // 
            this.schedulelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.schedulelabel.AutoSize = true;
            this.schedulelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedulelabel.Location = new System.Drawing.Point(-4, 22);
            this.schedulelabel.Name = "schedulelabel";
            this.schedulelabel.Size = new System.Drawing.Size(951, 40);
            this.schedulelabel.TabIndex = 0;
            this.schedulelabel.Text = "This option allows you to view successfull applicants, Approve successful applica" +
    "nts, set interview date  and notify candidates.\r\n\r\n";
            this.schedulelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // sessiontabPage
            // 
            this.sessiontabPage.Controls.Add(this.sessionabel);
            this.sessiontabPage.Location = new System.Drawing.Point(4, 29);
            this.sessiontabPage.Name = "sessiontabPage";
            this.sessiontabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sessiontabPage.Size = new System.Drawing.Size(967, 291);
            this.sessiontabPage.TabIndex = 1;
            this.sessiontabPage.Text = "Start Interview Session";
            this.sessiontabPage.UseVisualStyleBackColor = true;
            this.sessiontabPage.Click += new System.EventHandler(this.sessiontabPage_Click);
            // 
            // sessionabel
            // 
            this.sessionabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sessionabel.AutoSize = true;
            this.sessionabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionabel.Location = new System.Drawing.Point(6, 34);
            this.sessionabel.Name = "sessionabel";
            this.sessionabel.Size = new System.Drawing.Size(796, 20);
            this.sessionabel.TabIndex = 0;
            this.sessionabel.Text = "This Option allows you to start an interview session, set start time and duration" +
    " of each interview session.\r\n";
            // 
            // Confirmbutton
            // 
            this.Confirmbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Confirmbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmbutton.Location = new System.Drawing.Point(198, 406);
            this.Confirmbutton.Name = "Confirmbutton";
            this.Confirmbutton.Size = new System.Drawing.Size(97, 45);
            this.Confirmbutton.TabIndex = 1;
            this.Confirmbutton.Text = "Go";
            this.Confirmbutton.UseVisualStyleBackColor = true;
            this.Confirmbutton.Click += new System.EventHandler(this.Confirmbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.Location = new System.Drawing.Point(726, 406);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(94, 45);
            this.exitbutton.TabIndex = 2;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // welcomelabel
            // 
            this.welcomelabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcomelabel.AutoEllipsis = true;
            this.welcomelabel.AutoSize = true;
            this.welcomelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomelabel.Location = new System.Drawing.Point(399, 9);
            this.welcomelabel.Name = "welcomelabel";
            this.welcomelabel.Size = new System.Drawing.Size(121, 25);
            this.welcomelabel.TabIndex = 3;
            this.welcomelabel.Text = "WELCOME";
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1009, 463);
            this.Controls.Add(this.welcomelabel);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.Confirmbutton);
            this.Controls.Add(this.sessiontabControl);
            this.Name = "OptionForm";
            this.Text = "OptionForm";
            this.Load += new System.EventHandler(this.OptionForm_Load);
            this.sessiontabControl.ResumeLayout(false);
            this.scheduletabPage.ResumeLayout(false);
            this.scheduletabPage.PerformLayout();
            this.sessiontabPage.ResumeLayout(false);
            this.sessiontabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl sessiontabControl;
        private System.Windows.Forms.TabPage scheduletabPage;
        private System.Windows.Forms.TabPage sessiontabPage;
        private System.Windows.Forms.Button Confirmbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Label welcomelabel;
        private System.Windows.Forms.Label schedulelabel;
        private System.Windows.Forms.Label sessionabel;
    }
}
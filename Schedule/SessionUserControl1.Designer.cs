namespace Scheduling_Interviews
{
    partial class SessionUserControl1
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
            this.Welcome = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.datelabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.setbutton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Location = new System.Drawing.Point(314, 23);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(52, 13);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(244, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Location = new System.Drawing.Point(78, 122);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(68, 13);
            this.datelabel.TabIndex = 2;
            this.datelabel.Text = "Confirm Date";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(244, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(51, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(357, 214);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(49, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // setbutton
            // 
            this.setbutton.Location = new System.Drawing.Point(81, 302);
            this.setbutton.Name = "setbutton";
            this.setbutton.Size = new System.Drawing.Size(97, 23);
            this.setbutton.TabIndex = 5;
            this.setbutton.Text = "Set";
            this.setbutton.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(345, 302);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(125, 23);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Set Duration ";
            // 
            // SessionUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.setbutton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Welcome);
            this.Name = "SessionUserControl1";
            this.Size = new System.Drawing.Size(638, 363);
            this.Load += new System.EventHandler(this.SessionUserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button setbutton;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label2;
    }
}

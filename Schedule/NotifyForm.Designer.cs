namespace Scheduling_Interviews.Schedule
{
    partial class NotifyForm
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
            this.components = new System.ComponentModel.Container();
            this.Starttimelabel = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.setbutton = new System.Windows.Forms.Button();
            this.minutecomboBox = new System.Windows.Forms.ComboBox();
            this.hourcomboBox = new System.Windows.Forms.ComboBox();
            this.datelabel = new System.Windows.Forms.Label();
            this.interviewdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Welcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.starttimedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Starttimelabel
            // 
            this.Starttimelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Starttimelabel.AutoSize = true;
            this.Starttimelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Starttimelabel.Location = new System.Drawing.Point(429, 107);
            this.Starttimelabel.Name = "Starttimelabel";
            this.Starttimelabel.Size = new System.Drawing.Size(140, 24);
            this.Starttimelabel.TabIndex = 15;
            this.Starttimelabel.Text = "Set Start Time";
            this.Starttimelabel.Click += new System.EventHandler(this.Starttimelabel_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(517, 387);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(125, 35);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // setbutton
            // 
            this.setbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.setbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setbutton.Location = new System.Drawing.Point(65, 387);
            this.setbutton.Name = "setbutton";
            this.setbutton.Size = new System.Drawing.Size(137, 35);
            this.setbutton.TabIndex = 13;
            this.setbutton.Text = "Set and  Notify";
            this.setbutton.UseVisualStyleBackColor = true;
            this.setbutton.Click += new System.EventHandler(this.setbutton_Click);
            // 
            // minutecomboBox
            // 
            this.minutecomboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.minutecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minutecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutecomboBox.FormattingEnabled = true;
            this.minutecomboBox.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.minutecomboBox.Location = new System.Drawing.Point(714, 300);
            this.minutecomboBox.Name = "minutecomboBox";
            this.minutecomboBox.Size = new System.Drawing.Size(65, 28);
            this.minutecomboBox.TabIndex = 12;
            // 
            // hourcomboBox
            // 
            this.hourcomboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.hourcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hourcomboBox.FormattingEnabled = true;
            this.hourcomboBox.Items.AddRange(new object[] {
            "00:00",
            "00:30",
            "01:00",
            "01:00",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.hourcomboBox.Location = new System.Drawing.Point(679, 334);
            this.hourcomboBox.Name = "hourcomboBox";
            this.hourcomboBox.Size = new System.Drawing.Size(100, 21);
            this.hourcomboBox.TabIndex = 11;
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabel.Location = new System.Drawing.Point(72, 68);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(177, 24);
            this.datelabel.TabIndex = 10;
            this.datelabel.Text = "Set Interview Date";
            // 
            // interviewdateTimePicker
            // 
            this.interviewdateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.interviewdateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interviewdateTimePicker.Location = new System.Drawing.Point(65, 104);
            this.interviewdateTimePicker.Name = "interviewdateTimePicker";
            this.interviewdateTimePicker.Size = new System.Drawing.Size(305, 27);
            this.interviewdateTimePicker.TabIndex = 9;
            this.interviewdateTimePicker.ValueChanged += new System.EventHandler(this.interviewdateTimePicker_ValueChanged);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(283, 22);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(79, 20);
            this.Welcome.TabIndex = 8;
            this.Welcome.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Following Candidates will be notified";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(711, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(675, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(648, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Hours";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // starttimedateTimePicker
            // 
            this.starttimedateTimePicker.AllowDrop = true;
            this.starttimedateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.starttimedateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starttimedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.starttimedateTimePicker.Location = new System.Drawing.Point(575, 106);
            this.starttimedateTimePicker.Name = "starttimedateTimePicker";
            this.starttimedateTimePicker.ShowUpDown = true;
            this.starttimedateTimePicker.Size = new System.Drawing.Size(67, 29);
            this.starttimedateTimePicker.TabIndex = 21;
            this.starttimedateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(55, 193);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(629, 188);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // NotifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 434);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.starttimedateTimePicker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Starttimelabel);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.setbutton);
            this.Controls.Add(this.minutecomboBox);
            this.Controls.Add(this.hourcomboBox);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.interviewdateTimePicker);
            this.Controls.Add(this.Welcome);
            this.Name = "NotifyForm";
            this.Text = "NotifyForm";
            this.Load += new System.EventHandler(this.NotifyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Starttimelabel;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button setbutton;
        private System.Windows.Forms.ComboBox minutecomboBox;
        private System.Windows.Forms.ComboBox hourcomboBox;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.DateTimePicker interviewdateTimePicker;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker starttimedateTimePicker;
        private System.Windows.Forms.ListView listView1;
    }
}
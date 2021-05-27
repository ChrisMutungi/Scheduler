namespace Scheduling_Interviews.Login
{
    partial class SessionForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.setbutton = new System.Windows.Forms.Button();
            this.durationcomboBox = new System.Windows.Forms.ComboBox();
            this.selectcomboBox = new System.Windows.Forms.ComboBox();
            this.datelabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Welcome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.hourcomboBox = new System.Windows.Forms.ComboBox();
            this.minutecomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sessionlabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Set Duration ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit.Location = new System.Drawing.Point(367, 297);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(125, 23);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // setbutton
            // 
            this.setbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setbutton.Location = new System.Drawing.Point(188, 297);
            this.setbutton.Name = "setbutton";
            this.setbutton.Size = new System.Drawing.Size(97, 23);
            this.setbutton.TabIndex = 13;
            this.setbutton.Text = "Start";
            this.setbutton.UseVisualStyleBackColor = true;
            this.setbutton.Click += new System.EventHandler(this.setbutton_Click);
            // 
            // durationcomboBox
            // 
            this.durationcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durationcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationcomboBox.FormattingEnabled = true;
            this.durationcomboBox.Location = new System.Drawing.Point(272, 181);
            this.durationcomboBox.Name = "durationcomboBox";
            this.durationcomboBox.Size = new System.Drawing.Size(53, 26);
            this.durationcomboBox.TabIndex = 12;
            this.durationcomboBox.SelectedIndexChanged += new System.EventHandler(this.durationcomboBox_SelectedIndexChanged);
            // 
            // selectcomboBox
            // 
            this.selectcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectcomboBox.FormattingEnabled = true;
            this.selectcomboBox.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours"});
            this.selectcomboBox.Location = new System.Drawing.Point(166, 181);
            this.selectcomboBox.Name = "selectcomboBox";
            this.selectcomboBox.Size = new System.Drawing.Size(100, 26);
            this.selectcomboBox.TabIndex = 11;
            this.selectcomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabel.Location = new System.Drawing.Point(41, 94);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(108, 18);
            this.datelabel.TabIndex = 10;
            this.datelabel.Text = "Start Interviews";
            this.datelabel.Click += new System.EventHandler(this.datelabel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(167, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Location = new System.Drawing.Point(355, -21);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(52, 13);
            this.Welcome.TabIndex = 8;
            this.Welcome.Text = "Welcome";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(44, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hourcomboBox
            // 
            this.hourcomboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hourcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hourcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourcomboBox.FormattingEnabled = true;
            this.hourcomboBox.ItemHeight = 16;
            this.hourcomboBox.Items.AddRange(new object[] {
            "00 ",
            "01",
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
            this.hourcomboBox.Location = new System.Drawing.Point(392, 89);
            this.hourcomboBox.Name = "hourcomboBox";
            this.hourcomboBox.Size = new System.Drawing.Size(56, 24);
            this.hourcomboBox.TabIndex = 17;
            this.hourcomboBox.SelectedIndexChanged += new System.EventHandler(this.hourcomboBox_SelectedIndexChanged);
            // 
            // minutecomboBox
            // 
            this.minutecomboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minutecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minutecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutecomboBox.FormattingEnabled = true;
            this.minutecomboBox.Items.AddRange(new object[] {
            "00",
            "01",
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
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.minutecomboBox.Location = new System.Drawing.Point(465, 89);
            this.minutecomboBox.Name = "minutecomboBox";
            this.minutecomboBox.Size = new System.Drawing.Size(47, 24);
            this.minutecomboBox.TabIndex = 18;
            this.minutecomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Hours";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Time";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // sessionlabel
            // 
            this.sessionlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sessionlabel.AutoSize = true;
            this.sessionlabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionlabel.Location = new System.Drawing.Point(225, 9);
            this.sessionlabel.Name = "sessionlabel";
            this.sessionlabel.Size = new System.Drawing.Size(203, 24);
            this.sessionlabel.TabIndex = 22;
            this.sessionlabel.Text = "Start Interview Session";
            this.sessionlabel.Click += new System.EventHandler(this.sessionlabel_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(445, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Hold";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // SessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 362);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sessionlabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minutecomboBox);
            this.Controls.Add(this.hourcomboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.setbutton);
            this.Controls.Add(this.durationcomboBox);
            this.Controls.Add(this.selectcomboBox);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "SessionForm";
            this.Text = "SessionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button setbutton;
        private System.Windows.Forms.ComboBox durationcomboBox;
        private System.Windows.Forms.ComboBox selectcomboBox;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox hourcomboBox;
        private System.Windows.Forms.ComboBox minutecomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sessionlabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
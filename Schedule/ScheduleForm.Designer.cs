namespace Scheduling_Interviews.Login
{
    partial class ScheduleForm
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
            this.welcomelabel = new System.Windows.Forms.Label();
            this.setbutton = new System.Windows.Forms.Button();
            this.approveallbutton = new System.Windows.Forms.Button();
            this.Approvebutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomelabel
            // 
            this.welcomelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomelabel.AutoSize = true;
            this.welcomelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomelabel.Location = new System.Drawing.Point(409, 21);
            this.welcomelabel.Name = "welcomelabel";
            this.welcomelabel.Size = new System.Drawing.Size(121, 25);
            this.welcomelabel.TabIndex = 19;
            this.welcomelabel.Text = "WELCOME";
            // 
            // setbutton
            // 
            this.setbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.setbutton.AutoSize = true;
            this.setbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.setbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setbutton.Location = new System.Drawing.Point(90, 349);
            this.setbutton.Name = "setbutton";
            this.setbutton.Size = new System.Drawing.Size(151, 30);
            this.setbutton.TabIndex = 27;
            this.setbutton.Text = "Notify Candidates";
            this.setbutton.UseVisualStyleBackColor = true;
            this.setbutton.Click += new System.EventHandler(this.setbutton_Click);
            // 
            // approveallbutton
            // 
            this.approveallbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.approveallbutton.AutoSize = true;
            this.approveallbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.approveallbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approveallbutton.Location = new System.Drawing.Point(812, 244);
            this.approveallbutton.Name = "approveallbutton";
            this.approveallbutton.Size = new System.Drawing.Size(99, 30);
            this.approveallbutton.TabIndex = 26;
            this.approveallbutton.Text = "Approve All";
            this.approveallbutton.UseVisualStyleBackColor = true;
            this.approveallbutton.Click += new System.EventHandler(this.approveallbutton_Click);
            // 
            // Approvebutton
            // 
            this.Approvebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Approvebutton.AutoSize = true;
            this.Approvebutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Approvebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Approvebutton.Location = new System.Drawing.Point(812, 115);
            this.Approvebutton.Name = "Approvebutton";
            this.Approvebutton.Size = new System.Drawing.Size(78, 30);
            this.Approvebutton.TabIndex = 24;
            this.Approvebutton.Text = "Approve";
            this.Approvebutton.UseVisualStyleBackColor = true;
            this.Approvebutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Exitbutton.AutoSize = true;
            this.Exitbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.Location = new System.Drawing.Point(633, 349);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(45, 30);
            this.Exitbutton.TabIndex = 22;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Successfull Applicants";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(32, 103);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(646, 228);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(708, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(82, 30);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(754, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 30);
            this.button1.TabIndex = 32;
            this.button1.Text = "Ts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(921, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.setbutton);
            this.Controls.Add(this.approveallbutton);
            this.Controls.Add(this.Approvebutton);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.welcomelabel);
            this.Name = "ScheduleForm";
            this.Text = "ScheduleForm";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label welcomelabel;
        private System.Windows.Forms.Button setbutton;
        private System.Windows.Forms.Button approveallbutton;
        private System.Windows.Forms.Button Approvebutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}
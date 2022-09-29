namespace NASAApi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTodaysDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.chkThumbs = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.chkUseStartDate = new System.Windows.Forms.CheckBox();
            this.chkUseEndDate = new System.Windows.Forms.CheckBox();
            this.chkUseTodaysDate = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExplanation = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbImageReturned = new System.Windows.Forms.PictureBox();
            this.pbHdUrl = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageReturned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHdUrl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Today\'s Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Date:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Date:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Count:";
            this.label4.Visible = false;
            // 
            // dtpTodaysDate
            // 
            this.dtpTodaysDate.Location = new System.Drawing.Point(140, 58);
            this.dtpTodaysDate.Name = "dtpTodaysDate";
            this.dtpTodaysDate.Size = new System.Drawing.Size(200, 23);
            this.dtpTodaysDate.TabIndex = 10;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(140, 155);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 23);
            this.dtpStartDate.TabIndex = 11;
            this.dtpStartDate.Visible = false;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(140, 212);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 23);
            this.dtpEndDate.TabIndex = 12;
            this.dtpEndDate.Visible = false;
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(143, 252);
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(52, 23);
            this.nudCount.TabIndex = 13;
            this.nudCount.Visible = false;
            // 
            // chkThumbs
            // 
            this.chkThumbs.AutoSize = true;
            this.chkThumbs.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkThumbs.Location = new System.Drawing.Point(143, 281);
            this.chkThumbs.Name = "chkThumbs";
            this.chkThumbs.Size = new System.Drawing.Size(72, 19);
            this.chkThumbs.TabIndex = 14;
            this.chkThumbs.Text = "Thumbs:";
            this.chkThumbs.UseVisualStyleBackColor = true;
            this.chkThumbs.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(140, 104);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(194, 23);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // chkUseStartDate
            // 
            this.chkUseStartDate.AutoSize = true;
            this.chkUseStartDate.Location = new System.Drawing.Point(352, 158);
            this.chkUseStartDate.Name = "chkUseStartDate";
            this.chkUseStartDate.Size = new System.Drawing.Size(72, 19);
            this.chkUseStartDate.TabIndex = 16;
            this.chkUseStartDate.Text = "Use Date";
            this.chkUseStartDate.UseVisualStyleBackColor = true;
            this.chkUseStartDate.Visible = false;
            // 
            // chkUseEndDate
            // 
            this.chkUseEndDate.AutoSize = true;
            this.chkUseEndDate.Location = new System.Drawing.Point(352, 215);
            this.chkUseEndDate.Name = "chkUseEndDate";
            this.chkUseEndDate.Size = new System.Drawing.Size(72, 19);
            this.chkUseEndDate.TabIndex = 17;
            this.chkUseEndDate.Text = "Use Date";
            this.chkUseEndDate.UseVisualStyleBackColor = true;
            this.chkUseEndDate.Visible = false;
            // 
            // chkUseTodaysDate
            // 
            this.chkUseTodaysDate.AutoSize = true;
            this.chkUseTodaysDate.Location = new System.Drawing.Point(347, 61);
            this.chkUseTodaysDate.Name = "chkUseTodaysDate";
            this.chkUseTodaysDate.Size = new System.Drawing.Size(72, 19);
            this.chkUseTodaysDate.TabIndex = 18;
            this.chkUseTodaysDate.Text = "Use Date";
            this.chkUseTodaysDate.UseVisualStyleBackColor = true;
            this.chkUseTodaysDate.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Explanation:";
            // 
            // txtExplanation
            // 
            this.txtExplanation.Location = new System.Drawing.Point(536, 61);
            this.txtExplanation.Multiline = true;
            this.txtExplanation.Name = "txtExplanation";
            this.txtExplanation.Size = new System.Drawing.Size(535, 205);
            this.txtExplanation.TabIndex = 20;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 717);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1216, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Firebrick;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1201, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "...";
            // 
            // pbImageReturned
            // 
            this.pbImageReturned.Location = new System.Drawing.Point(12, 306);
            this.pbImageReturned.Name = "pbImageReturned";
            this.pbImageReturned.Size = new System.Drawing.Size(585, 362);
            this.pbImageReturned.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageReturned.TabIndex = 22;
            this.pbImageReturned.TabStop = false;
            // 
            // pbHdUrl
            // 
            this.pbHdUrl.Location = new System.Drawing.Point(618, 306);
            this.pbHdUrl.Name = "pbHdUrl";
            this.pbHdUrl.Size = new System.Drawing.Size(585, 362);
            this.pbHdUrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHdUrl.TabIndex = 23;
            this.pbHdUrl.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 739);
            this.Controls.Add(this.pbHdUrl);
            this.Controls.Add(this.pbImageReturned);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtExplanation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkUseTodaysDate);
            this.Controls.Add(this.chkUseEndDate);
            this.Controls.Add(this.chkUseStartDate);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chkThumbs);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.dtpTodaysDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NASA API Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageReturned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHdUrl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpTodaysDate;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private NumericUpDown nudCount;
        private CheckBox chkThumbs;
        private Button btnSubmit;
        private CheckBox chkUseStartDate;
        private CheckBox chkUseEndDate;
        private CheckBox chkUseTodaysDate;
        private Label label5;
        private TextBox txtExplanation;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private PictureBox pbImageReturned;
        private PictureBox pbHdUrl;
    }
}
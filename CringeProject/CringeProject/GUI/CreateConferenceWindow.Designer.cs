namespace CringeProject.GUI
{
    partial class CreateConferenceWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.conferenceNameBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deadlineForAbstractsBox = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.deadlineForPapersBox = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.startDateBox = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.endDateBox = new System.Windows.Forms.DateTimePicker();
            this.addConference = new System.Windows.Forms.Button();
            this.sectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusOfAdd = new System.Windows.Forms.Label();
            this.biddingDeadlineBox = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.reviewDeadlineBox = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conference name";
            // 
            // conferenceNameBox
            // 
            this.conferenceNameBox.Location = new System.Drawing.Point(137, 7);
            this.conferenceNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.conferenceNameBox.Name = "conferenceNameBox";
            this.conferenceNameBox.Size = new System.Drawing.Size(169, 18);
            this.conferenceNameBox.TabIndex = 1;
            this.conferenceNameBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deadline for abstracts";
            // 
            // deadlineForAbstractsBox
            // 
            this.deadlineForAbstractsBox.Location = new System.Drawing.Point(137, 138);
            this.deadlineForAbstractsBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deadlineForAbstractsBox.Name = "deadlineForAbstractsBox";
            this.deadlineForAbstractsBox.Size = new System.Drawing.Size(210, 20);
            this.deadlineForAbstractsBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Deadline for papers";
            // 
            // deadlineForPapersBox
            // 
            this.deadlineForPapersBox.Location = new System.Drawing.Point(137, 176);
            this.deadlineForPapersBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deadlineForPapersBox.Name = "deadlineForPapersBox";
            this.deadlineForPapersBox.Size = new System.Drawing.Size(210, 20);
            this.deadlineForPapersBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Start date";
            // 
            // startDateBox
            // 
            this.startDateBox.Location = new System.Drawing.Point(137, 51);
            this.startDateBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startDateBox.Name = "startDateBox";
            this.startDateBox.Size = new System.Drawing.Size(210, 20);
            this.startDateBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "End date";
            // 
            // endDateBox
            // 
            this.endDateBox.Location = new System.Drawing.Point(137, 95);
            this.endDateBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endDateBox.Name = "endDateBox";
            this.endDateBox.Size = new System.Drawing.Size(210, 20);
            this.endDateBox.TabIndex = 9;
            // 
            // addConference
            // 
            this.addConference.Location = new System.Drawing.Point(72, 330);
            this.addConference.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addConference.Name = "addConference";
            this.addConference.Size = new System.Drawing.Size(214, 51);
            this.addConference.TabIndex = 12;
            this.addConference.Text = "Add conference";
            this.addConference.UseVisualStyleBackColor = true;
            this.addConference.Click += new System.EventHandler(this.addConference_Click);
            // 
            // sectionBindingSource
            // 
            this.sectionBindingSource.DataSource = typeof(CringeProject.Entities.Section);
            // 
            // statusOfAdd
            // 
            this.statusOfAdd.AutoSize = true;
            this.statusOfAdd.Location = new System.Drawing.Point(117, 294);
            this.statusOfAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusOfAdd.Name = "statusOfAdd";
            this.statusOfAdd.Size = new System.Drawing.Size(0, 13);
            this.statusOfAdd.TabIndex = 13;
            // 
            // biddingDeadlineBox
            // 
            this.biddingDeadlineBox.Location = new System.Drawing.Point(137, 214);
            this.biddingDeadlineBox.Margin = new System.Windows.Forms.Padding(2);
            this.biddingDeadlineBox.Name = "biddingDeadlineBox";
            this.biddingDeadlineBox.Size = new System.Drawing.Size(210, 20);
            this.biddingDeadlineBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 217);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bidding Deadline";
            // 
            // reviewDeadlineBox
            // 
            this.reviewDeadlineBox.Location = new System.Drawing.Point(137, 252);
            this.reviewDeadlineBox.Margin = new System.Windows.Forms.Padding(2);
            this.reviewDeadlineBox.Name = "reviewDeadlineBox";
            this.reviewDeadlineBox.Size = new System.Drawing.Size(210, 20);
            this.reviewDeadlineBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 255);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Review Deadline";
            // 
            // CreateConferenceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 392);
            this.Controls.Add(this.reviewDeadlineBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.biddingDeadlineBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.statusOfAdd);
            this.Controls.Add(this.addConference);
            this.Controls.Add(this.endDateBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startDateBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deadlineForPapersBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deadlineForAbstractsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.conferenceNameBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreateConferenceWindow";
            this.Text = " ";
            this.Load += new System.EventHandler(this.CreateConferenceWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox conferenceNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker deadlineForAbstractsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker deadlineForPapersBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker startDateBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker endDateBox;
        private System.Windows.Forms.Button addConference;
        private System.Windows.Forms.BindingSource sectionBindingSource;
        private System.Windows.Forms.Label statusOfAdd;
        private System.Windows.Forms.DateTimePicker biddingDeadlineBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker reviewDeadlineBox;
        private System.Windows.Forms.Label label7;
    }
}
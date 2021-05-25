namespace CringeProject.GUI
{
    partial class UpdateConferenceDetailsWindow
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
            this.updateConference = new System.Windows.Forms.Button();
            this.endDateBox = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.startDateBox = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.deadlineForPapersBox = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.deadlineForAbstractsBox = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.conferenceNameBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateConference
            // 
            this.updateConference.Location = new System.Drawing.Point(133, 458);
            this.updateConference.Name = "updateConference";
            this.updateConference.Size = new System.Drawing.Size(428, 99);
            this.updateConference.TabIndex = 23;
            this.updateConference.Text = "Update conference";
            this.updateConference.UseVisualStyleBackColor = true;
            this.updateConference.Click += new System.EventHandler(this.updateConference_Click);
            // 
            // endDateBox
            // 
            this.endDateBox.Location = new System.Drawing.Point(277, 193);
            this.endDateBox.Name = "endDateBox";
            this.endDateBox.Size = new System.Drawing.Size(417, 31);
            this.endDateBox.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "End date";
            // 
            // startDateBox
            // 
            this.startDateBox.Location = new System.Drawing.Point(277, 110);
            this.startDateBox.Name = "startDateBox";
            this.startDateBox.Size = new System.Drawing.Size(417, 31);
            this.startDateBox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Start date";
            // 
            // deadlineForPapersBox
            // 
            this.deadlineForPapersBox.Location = new System.Drawing.Point(277, 350);
            this.deadlineForPapersBox.Name = "deadlineForPapersBox";
            this.deadlineForPapersBox.Size = new System.Drawing.Size(417, 31);
            this.deadlineForPapersBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Deadline for papers";
            // 
            // deadlineForAbstractsBox
            // 
            this.deadlineForAbstractsBox.Location = new System.Drawing.Point(277, 276);
            this.deadlineForAbstractsBox.Name = "deadlineForAbstractsBox";
            this.deadlineForAbstractsBox.Size = new System.Drawing.Size(417, 31);
            this.deadlineForAbstractsBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Deadline for abstracts";
            // 
            // conferenceNameBox
            // 
            this.conferenceNameBox.Location = new System.Drawing.Point(277, 24);
            this.conferenceNameBox.Name = "conferenceNameBox";
            this.conferenceNameBox.Size = new System.Drawing.Size(334, 31);
            this.conferenceNameBox.TabIndex = 14;
            this.conferenceNameBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Conference name";
            // 
            // UpdateConferenceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 594);
            this.Controls.Add(this.updateConference);
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
            this.Name = "UpdateConferenceDetails";
            this.Text = "UpdateConferenceDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateConference;
        private System.Windows.Forms.DateTimePicker endDateBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker startDateBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker deadlineForPapersBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker deadlineForAbstractsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox conferenceNameBox;
        private System.Windows.Forms.Label label1;
    }
}
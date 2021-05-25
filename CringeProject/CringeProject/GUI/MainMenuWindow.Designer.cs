namespace CringeProject.GUI
{
    partial class MainMenuWindow
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
            this.createConference = new System.Windows.Forms.Button();
            this.availableConferencesList = new System.Windows.Forms.ListBox();
            this.viewSelectedConference = new System.Windows.Forms.Button();
            this.participateInConferenceButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.conferencesWithParticipationsList = new System.Windows.Forms.ListBox();
            this.errorsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available conferences";
            // 
            // createConference
            // 
            this.createConference.Location = new System.Drawing.Point(511, 418);
            this.createConference.Margin = new System.Windows.Forms.Padding(2);
            this.createConference.Name = "createConference";
            this.createConference.Size = new System.Drawing.Size(128, 47);
            this.createConference.TabIndex = 2;
            this.createConference.Text = "Create conference";
            this.createConference.UseVisualStyleBackColor = true;
            this.createConference.Click += new System.EventHandler(this.createConference_Click);
            // 
            // availableConferencesList
            // 
            this.availableConferencesList.FormattingEnabled = true;
            this.availableConferencesList.Location = new System.Drawing.Point(6, 32);
            this.availableConferencesList.Margin = new System.Windows.Forms.Padding(2);
            this.availableConferencesList.Name = "availableConferencesList";
            this.availableConferencesList.Size = new System.Drawing.Size(296, 381);
            this.availableConferencesList.TabIndex = 3;
            // 
            // viewSelectedConference
            // 
            this.viewSelectedConference.Location = new System.Drawing.Point(361, 418);
            this.viewSelectedConference.Margin = new System.Windows.Forms.Padding(2);
            this.viewSelectedConference.Name = "viewSelectedConference";
            this.viewSelectedConference.Size = new System.Drawing.Size(128, 47);
            this.viewSelectedConference.TabIndex = 4;
            this.viewSelectedConference.Text = "View selected conference";
            this.viewSelectedConference.UseVisualStyleBackColor = true;
            this.viewSelectedConference.Click += new System.EventHandler(this.viewSelectedConference_Click);
            // 
            // participateInConferenceButton
            // 
            this.participateInConferenceButton.Location = new System.Drawing.Point(6, 418);
            this.participateInConferenceButton.Name = "participateInConferenceButton";
            this.participateInConferenceButton.Size = new System.Drawing.Size(296, 47);
            this.participateInConferenceButton.TabIndex = 5;
            this.participateInConferenceButton.Text = "Participate";
            this.participateInConferenceButton.UseVisualStyleBackColor = true;
            this.participateInConferenceButton.Click += new System.EventHandler(this.participateInConferenceButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Conferences you participate in";
            // 
            // conferencesWithParticipationsList
            // 
            this.conferencesWithParticipationsList.FormattingEnabled = true;
            this.conferencesWithParticipationsList.Location = new System.Drawing.Point(361, 32);
            this.conferencesWithParticipationsList.Name = "conferencesWithParticipationsList";
            this.conferencesWithParticipationsList.Size = new System.Drawing.Size(278, 381);
            this.conferencesWithParticipationsList.TabIndex = 7;
            // 
            // errorsLabel
            // 
            this.errorsLabel.AutoSize = true;
            this.errorsLabel.Location = new System.Drawing.Point(308, 163);
            this.errorsLabel.Name = "errorsLabel";
            this.errorsLabel.Size = new System.Drawing.Size(0, 13);
            this.errorsLabel.TabIndex = 8;
            // 
            // MainMenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 472);
            this.Controls.Add(this.errorsLabel);
            this.Controls.Add(this.conferencesWithParticipationsList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.participateInConferenceButton);
            this.Controls.Add(this.viewSelectedConference);
            this.Controls.Add(this.availableConferencesList);
            this.Controls.Add(this.createConference);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenuWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BaseUserWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createConference;
        private System.Windows.Forms.ListBox availableConferencesList;
        private System.Windows.Forms.Button viewSelectedConference;
        private System.Windows.Forms.Button participateInConferenceButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox conferencesWithParticipationsList;
        private System.Windows.Forms.Label errorsLabel;
    }
}
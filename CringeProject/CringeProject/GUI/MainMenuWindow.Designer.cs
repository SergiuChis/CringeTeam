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
            this.updateSelectedConference = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available conferences";
            // 
            // createConference
            // 
            this.createConference.Location = new System.Drawing.Point(1091, 804);
            this.createConference.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createConference.Name = "createConference";
            this.createConference.Size = new System.Drawing.Size(187, 90);
            this.createConference.TabIndex = 2;
            this.createConference.Text = "Create conference";
            this.createConference.UseVisualStyleBackColor = true;
            this.createConference.Click += new System.EventHandler(this.createConference_Click);
            // 
            // availableConferencesList
            // 
            this.availableConferencesList.FormattingEnabled = true;
            this.availableConferencesList.ItemHeight = 25;
            this.availableConferencesList.Location = new System.Drawing.Point(12, 62);
            this.availableConferencesList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.availableConferencesList.Name = "availableConferencesList";
            this.availableConferencesList.Size = new System.Drawing.Size(588, 729);
            this.availableConferencesList.TabIndex = 3;
            // 
            // viewSelectedConference
            // 
            this.viewSelectedConference.Location = new System.Drawing.Point(906, 805);
            this.viewSelectedConference.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewSelectedConference.Name = "viewSelectedConference";
            this.viewSelectedConference.Size = new System.Drawing.Size(177, 90);
            this.viewSelectedConference.TabIndex = 4;
            this.viewSelectedConference.Text = "View selected conference";
            this.viewSelectedConference.UseVisualStyleBackColor = true;
            this.viewSelectedConference.Click += new System.EventHandler(this.viewSelectedConference_Click);
            // 
            // participateInConferenceButton
            // 
            this.participateInConferenceButton.Location = new System.Drawing.Point(12, 804);
            this.participateInConferenceButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.participateInConferenceButton.Name = "participateInConferenceButton";
            this.participateInConferenceButton.Size = new System.Drawing.Size(592, 90);
            this.participateInConferenceButton.TabIndex = 5;
            this.participateInConferenceButton.Text = "Participate";
            this.participateInConferenceButton.UseVisualStyleBackColor = true;
            this.participateInConferenceButton.Click += new System.EventHandler(this.participateInConferenceButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(870, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Conferences you participate in";
            // 
            // conferencesWithParticipationsList
            // 
            this.conferencesWithParticipationsList.FormattingEnabled = true;
            this.conferencesWithParticipationsList.ItemHeight = 25;
            this.conferencesWithParticipationsList.Location = new System.Drawing.Point(722, 62);
            this.conferencesWithParticipationsList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.conferencesWithParticipationsList.Name = "conferencesWithParticipationsList";
            this.conferencesWithParticipationsList.Size = new System.Drawing.Size(552, 729);
            this.conferencesWithParticipationsList.TabIndex = 7;
            // 
            // errorsLabel
            // 
            this.errorsLabel.AutoSize = true;
            this.errorsLabel.Location = new System.Drawing.Point(616, 313);
            this.errorsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.errorsLabel.Name = "errorsLabel";
            this.errorsLabel.Size = new System.Drawing.Size(0, 25);
            this.errorsLabel.TabIndex = 8;
            // 
            // updateSelectedConference
            // 
            this.updateSelectedConference.Location = new System.Drawing.Point(722, 805);
            this.updateSelectedConference.Name = "updateSelectedConference";
            this.updateSelectedConference.Size = new System.Drawing.Size(177, 89);
            this.updateSelectedConference.TabIndex = 9;
            this.updateSelectedConference.Text = "Update selected conference";
            this.updateSelectedConference.UseVisualStyleBackColor = true;
            this.updateSelectedConference.Click += new System.EventHandler(this.updateSelectedConference_Click);
            // 
            // MainMenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 908);
            this.Controls.Add(this.updateSelectedConference);
            this.Controls.Add(this.errorsLabel);
            this.Controls.Add(this.conferencesWithParticipationsList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.participateInConferenceButton);
            this.Controls.Add(this.viewSelectedConference);
            this.Controls.Add(this.availableConferencesList);
            this.Controls.Add(this.createConference);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button updateSelectedConference;
    }
}
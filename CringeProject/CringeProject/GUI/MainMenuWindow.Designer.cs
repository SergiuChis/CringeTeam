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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available conferences";
            // 
            // createConference
            // 
            this.createConference.Location = new System.Drawing.Point(1100, 777);
            this.createConference.Name = "createConference";
            this.createConference.Size = new System.Drawing.Size(255, 117);
            this.createConference.TabIndex = 2;
            this.createConference.Text = "Create conference";
            this.createConference.UseVisualStyleBackColor = true;
            this.createConference.Click += new System.EventHandler(this.createConference_Click);
            // 
            // availableConferencesList
            // 
            this.availableConferencesList.FormattingEnabled = true;
            this.availableConferencesList.ItemHeight = 25;
            this.availableConferencesList.Location = new System.Drawing.Point(12, 61);
            this.availableConferencesList.Name = "availableConferencesList";
            this.availableConferencesList.Size = new System.Drawing.Size(587, 829);
            this.availableConferencesList.TabIndex = 3;
            // 
            // viewSelectedConference
            // 
            this.viewSelectedConference.Location = new System.Drawing.Point(801, 777);
            this.viewSelectedConference.Name = "viewSelectedConference";
            this.viewSelectedConference.Size = new System.Drawing.Size(255, 117);
            this.viewSelectedConference.TabIndex = 4;
            this.viewSelectedConference.Text = "View selected conference";
            this.viewSelectedConference.UseVisualStyleBackColor = true;
            this.viewSelectedConference.Click += new System.EventHandler(this.viewSelectedConference_Click);
            // 
            // MainMenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 907);
            this.Controls.Add(this.viewSelectedConference);
            this.Controls.Add(this.availableConferencesList);
            this.Controls.Add(this.createConference);
            this.Controls.Add(this.label1);
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
    }
}
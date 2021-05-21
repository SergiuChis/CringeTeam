
namespace CringeProject.GUI {
    partial class SteeringCommitteeWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updateUserRoleButton = new System.Windows.Forms.Button();
            this.usersListbox = new System.Windows.Forms.ListBox();
            this.updateConferenceButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.addSectionButton = new System.Windows.Forms.Button();
            this.confirmAddSectionButton = new System.Windows.Forms.Button();
            this.roomLabel = new System.Windows.Forms.Label();
            this.availablePlacesLabel = new System.Windows.Forms.Label();
            this.roomTextBox = new System.Windows.Forms.TextBox();
            this.availablePlacesTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Role:";
            // 
            // updateUserRoleButton
            // 
            this.updateUserRoleButton.Location = new System.Drawing.Point(328, 325);
            this.updateUserRoleButton.Name = "updateUserRoleButton";
            this.updateUserRoleButton.Size = new System.Drawing.Size(137, 46);
            this.updateUserRoleButton.TabIndex = 3;
            this.updateUserRoleButton.Text = "Update Role";
            this.updateUserRoleButton.UseVisualStyleBackColor = true;
            this.updateUserRoleButton.Click += new System.EventHandler(this.updateUserRoleButton_Click);
            // 
            // usersListbox
            // 
            this.usersListbox.FormattingEnabled = true;
            this.usersListbox.Location = new System.Drawing.Point(12, 18);
            this.usersListbox.Name = "usersListbox";
            this.usersListbox.Size = new System.Drawing.Size(287, 368);
            this.usersListbox.TabIndex = 4;
            // 
            // updateConferenceButton
            // 
            this.updateConferenceButton.Location = new System.Drawing.Point(502, 325);
            this.updateConferenceButton.Name = "updateConferenceButton";
            this.updateConferenceButton.Size = new System.Drawing.Size(163, 46);
            this.updateConferenceButton.TabIndex = 5;
            this.updateConferenceButton.Text = "Update Conference Details";
            this.updateConferenceButton.UseVisualStyleBackColor = true;
            this.updateConferenceButton.Click += new System.EventHandler(this.updateConferenceButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(424, 92);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 13);
            this.usernameLabel.TabIndex = 6;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(424, 156);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(0, 13);
            this.roleLabel.TabIndex = 7;
            // 
            // addSectionButton
            // 
            this.addSectionButton.Location = new System.Drawing.Point(502, 262);
            this.addSectionButton.Name = "addSectionButton";
            this.addSectionButton.Size = new System.Drawing.Size(163, 45);
            this.addSectionButton.TabIndex = 8;
            this.addSectionButton.Text = "Add Section";
            this.addSectionButton.UseVisualStyleBackColor = true;
            this.addSectionButton.Click += new System.EventHandler(this.addSectionButton_Click);
            // 
            // confirmAddSectionButton
            // 
            this.confirmAddSectionButton.Location = new System.Drawing.Point(502, 262);
            this.confirmAddSectionButton.Name = "confirmAddSectionButton";
            this.confirmAddSectionButton.Size = new System.Drawing.Size(163, 45);
            this.confirmAddSectionButton.TabIndex = 9;
            this.confirmAddSectionButton.Text = "Confirm";
            this.confirmAddSectionButton.UseVisualStyleBackColor = true;
            this.confirmAddSectionButton.Click += new System.EventHandler(this.confirmAddSectionButton_Click);
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Location = new System.Drawing.Point(328, 194);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(38, 13);
            this.roomLabel.TabIndex = 10;
            this.roomLabel.Text = "Room:";
            // 
            // availablePlacesLabel
            // 
            this.availablePlacesLabel.AutoSize = true;
            this.availablePlacesLabel.Location = new System.Drawing.Point(328, 231);
            this.availablePlacesLabel.Name = "availablePlacesLabel";
            this.availablePlacesLabel.Size = new System.Drawing.Size(88, 13);
            this.availablePlacesLabel.TabIndex = 11;
            this.availablePlacesLabel.Text = "Available Places:";
            // 
            // roomTextBox
            // 
            this.roomTextBox.Location = new System.Drawing.Point(427, 194);
            this.roomTextBox.Name = "roomTextBox";
            this.roomTextBox.Size = new System.Drawing.Size(186, 20);
            this.roomTextBox.TabIndex = 12;
            // 
            // availablePlacesTextBox
            // 
            this.availablePlacesTextBox.Location = new System.Drawing.Point(427, 228);
            this.availablePlacesTextBox.Name = "availablePlacesTextBox";
            this.availablePlacesTextBox.Size = new System.Drawing.Size(186, 20);
            this.availablePlacesTextBox.TabIndex = 13;
            // 
            // SteeringCommitteeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 406);
            this.Controls.Add(this.availablePlacesTextBox);
            this.Controls.Add(this.roomTextBox);
            this.Controls.Add(this.availablePlacesLabel);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.confirmAddSectionButton);
            this.Controls.Add(this.addSectionButton);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.updateConferenceButton);
            this.Controls.Add(this.usersListbox);
            this.Controls.Add(this.updateUserRoleButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SteeringCommitteeWindow";
            this.Text = "SteeringCommitteeWindow";
            this.Load += new System.EventHandler(this.SteeringCommitteeWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updateUserRoleButton;
        private System.Windows.Forms.ListBox usersListbox;
        private System.Windows.Forms.Button updateConferenceButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Button addSectionButton;
        private System.Windows.Forms.Button confirmAddSectionButton;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Label availablePlacesLabel;
        private System.Windows.Forms.TextBox roomTextBox;
        private System.Windows.Forms.TextBox availablePlacesTextBox;
    }
}
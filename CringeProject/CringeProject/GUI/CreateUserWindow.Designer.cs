
namespace CringeProject.GUI {
    partial class CreateUserWindow {
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
            this.createUserButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTexbox = new System.Windows.Forms.TextBox();
            this.confirmedPasswordTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.creationStatusLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // createUserButton
            // 
            this.createUserButton.Location = new System.Drawing.Point(146, 375);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(209, 43);
            this.createUserButton.TabIndex = 0;
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(193, 58);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(247, 20);
            this.usernameTextbox.TabIndex = 3;
            // 
            // passwordTexbox
            // 
            this.passwordTexbox.Location = new System.Drawing.Point(193, 115);
            this.passwordTexbox.Name = "passwordTexbox";
            this.passwordTexbox.Size = new System.Drawing.Size(247, 20);
            this.passwordTexbox.TabIndex = 4;
            this.passwordTexbox.UseSystemPasswordChar = true;
            // 
            // confirmedPasswordTextbox
            // 
            this.confirmedPasswordTextbox.Location = new System.Drawing.Point(193, 167);
            this.confirmedPasswordTextbox.Name = "confirmedPasswordTextbox";
            this.confirmedPasswordTextbox.Size = new System.Drawing.Size(247, 20);
            this.confirmedPasswordTextbox.TabIndex = 6;
            this.confirmedPasswordTextbox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm Password";
            // 
            // creationStatusLabel
            // 
            this.creationStatusLabel.AutoSize = true;
            this.creationStatusLabel.Location = new System.Drawing.Point(171, 347);
            this.creationStatusLabel.Name = "creationStatusLabel";
            this.creationStatusLabel.Size = new System.Drawing.Size(0, 13);
            this.creationStatusLabel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Birth Day";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(189, 291);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(247, 20);
            this.fullNameTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Full Name";
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.Location = new System.Drawing.Point(193, 230);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(243, 20);
            this.birthdayPicker.TabIndex = 13;
            // 
            // CreateUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 440);
            this.Controls.Add(this.birthdayPicker);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.creationStatusLabel);
            this.Controls.Add(this.confirmedPasswordTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTexbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createUserButton);
            this.Name = "CreateUserWindow";
            this.Text = "CreateUserWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TextBox passwordTexbox;
        private System.Windows.Forms.TextBox confirmedPasswordTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label creationStatusLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
    }
}
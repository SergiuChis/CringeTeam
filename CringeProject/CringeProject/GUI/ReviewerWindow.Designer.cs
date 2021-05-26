
namespace CringeProject.GUI {
    partial class ReviewerWindow {
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
            this.paperLabel = new System.Windows.Forms.Label();
            this.strongAcceptButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.weakAcceptButton = new System.Windows.Forms.Button();
            this.borderlinePaperButton = new System.Windows.Forms.Button();
            this.weakRejectButton = new System.Windows.Forms.Button();
            this.rejectButton = new System.Windows.Forms.Button();
            this.strongRejectButton = new System.Windows.Forms.Button();
            this.papersListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // paperLabel
            // 
            this.paperLabel.AutoSize = true;
            this.paperLabel.Location = new System.Drawing.Point(254, 23);
            this.paperLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.paperLabel.Name = "paperLabel";
            this.paperLabel.Size = new System.Drawing.Size(35, 13);
            this.paperLabel.TabIndex = 0;
            this.paperLabel.Text = "Paper";
            // 
            // strongAcceptButton
            // 
            this.strongAcceptButton.Location = new System.Drawing.Point(6, 346);
            this.strongAcceptButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.strongAcceptButton.Name = "strongAcceptButton";
            this.strongAcceptButton.Size = new System.Drawing.Size(102, 41);
            this.strongAcceptButton.TabIndex = 2;
            this.strongAcceptButton.Text = "Strong accept";
            this.strongAcceptButton.UseVisualStyleBackColor = true;
            this.strongAcceptButton.Click += new System.EventHandler(this.strongAcceptButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(175, 346);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(102, 41);
            this.acceptButton.TabIndex = 3;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // weakAcceptButton
            // 
            this.weakAcceptButton.Location = new System.Drawing.Point(350, 346);
            this.weakAcceptButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weakAcceptButton.Name = "weakAcceptButton";
            this.weakAcceptButton.Size = new System.Drawing.Size(102, 41);
            this.weakAcceptButton.TabIndex = 4;
            this.weakAcceptButton.Text = "Weak accept";
            this.weakAcceptButton.UseVisualStyleBackColor = true;
            this.weakAcceptButton.Click += new System.EventHandler(this.weakAcceptButton_Click);
            // 
            // borderlinePaperButton
            // 
            this.borderlinePaperButton.Location = new System.Drawing.Point(523, 346);
            this.borderlinePaperButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.borderlinePaperButton.Name = "borderlinePaperButton";
            this.borderlinePaperButton.Size = new System.Drawing.Size(102, 41);
            this.borderlinePaperButton.TabIndex = 5;
            this.borderlinePaperButton.Text = "Borderline paper";
            this.borderlinePaperButton.UseVisualStyleBackColor = true;
            this.borderlinePaperButton.Click += new System.EventHandler(this.borderlinePaperButton_Click);
            // 
            // weakRejectButton
            // 
            this.weakRejectButton.Location = new System.Drawing.Point(6, 408);
            this.weakRejectButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weakRejectButton.Name = "weakRejectButton";
            this.weakRejectButton.Size = new System.Drawing.Size(102, 41);
            this.weakRejectButton.TabIndex = 6;
            this.weakRejectButton.Text = "Weak reject";
            this.weakRejectButton.UseVisualStyleBackColor = true;
            this.weakRejectButton.Click += new System.EventHandler(this.weakRejectButton_Click);
            // 
            // rejectButton
            // 
            this.rejectButton.Location = new System.Drawing.Point(175, 408);
            this.rejectButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(102, 41);
            this.rejectButton.TabIndex = 7;
            this.rejectButton.Text = "Reject";
            this.rejectButton.UseVisualStyleBackColor = true;
            this.rejectButton.Click += new System.EventHandler(this.rejectButton_Click);
            // 
            // strongRejectButton
            // 
            this.strongRejectButton.Location = new System.Drawing.Point(350, 408);
            this.strongRejectButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.strongRejectButton.Name = "strongRejectButton";
            this.strongRejectButton.Size = new System.Drawing.Size(102, 41);
            this.strongRejectButton.TabIndex = 8;
            this.strongRejectButton.Text = "Strong reject";
            this.strongRejectButton.UseVisualStyleBackColor = true;
            this.strongRejectButton.Click += new System.EventHandler(this.strongRejectButton_Click);
            // 
            // papersListBox
            // 
            this.papersListBox.FormattingEnabled = true;
            this.papersListBox.Location = new System.Drawing.Point(13, 46);
            this.papersListBox.Name = "papersListBox";
            this.papersListBox.Size = new System.Drawing.Size(607, 277);
            this.papersListBox.TabIndex = 9;
            // 
            // ReviewerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 456);
            this.Controls.Add(this.papersListBox);
            this.Controls.Add(this.strongRejectButton);
            this.Controls.Add(this.rejectButton);
            this.Controls.Add(this.weakRejectButton);
            this.Controls.Add(this.borderlinePaperButton);
            this.Controls.Add(this.weakAcceptButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.strongAcceptButton);
            this.Controls.Add(this.paperLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReviewerWindow";
            this.Text = "ReviewerWindow";
            this.Load += new System.EventHandler(this.ReviewerWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label paperLabel;
        private System.Windows.Forms.Button strongAcceptButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button weakAcceptButton;
        private System.Windows.Forms.Button borderlinePaperButton;
        private System.Windows.Forms.Button weakRejectButton;
        private System.Windows.Forms.Button rejectButton;
        private System.Windows.Forms.Button strongRejectButton;
        private System.Windows.Forms.ListBox papersListBox;
    }
}
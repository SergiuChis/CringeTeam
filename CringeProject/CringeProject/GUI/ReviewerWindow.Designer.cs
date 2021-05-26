
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
            this.label1 = new System.Windows.Forms.Label();
            this.biddingPapersListBox = new System.Windows.Forms.ListBox();
            this.bidStrongInterestButton = new System.Windows.Forms.Button();
            this.bidInterestButton = new System.Windows.Forms.Button();
            this.bidRejectionButton = new System.Windows.Forms.Button();
            this.bidStrongRejectionButton = new System.Windows.Forms.Button();
            this.recommendationTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // paperLabel
            // 
            this.paperLabel.AutoSize = true;
            this.paperLabel.Location = new System.Drawing.Point(22, 19);
            this.paperLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.paperLabel.Name = "paperLabel";
            this.paperLabel.Size = new System.Drawing.Size(117, 13);
            this.paperLabel.TabIndex = 0;
            this.paperLabel.Text = "Papers assigned to you";
            // 
            // strongAcceptButton
            // 
            this.strongAcceptButton.Location = new System.Drawing.Point(11, 379);
            this.strongAcceptButton.Margin = new System.Windows.Forms.Padding(2);
            this.strongAcceptButton.Name = "strongAcceptButton";
            this.strongAcceptButton.Size = new System.Drawing.Size(102, 41);
            this.strongAcceptButton.TabIndex = 2;
            this.strongAcceptButton.Text = "Strong accept";
            this.strongAcceptButton.UseVisualStyleBackColor = true;
            this.strongAcceptButton.Click += new System.EventHandler(this.strongAcceptButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(180, 379);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(2);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(102, 41);
            this.acceptButton.TabIndex = 3;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // weakAcceptButton
            // 
            this.weakAcceptButton.Location = new System.Drawing.Point(11, 433);
            this.weakAcceptButton.Margin = new System.Windows.Forms.Padding(2);
            this.weakAcceptButton.Name = "weakAcceptButton";
            this.weakAcceptButton.Size = new System.Drawing.Size(102, 41);
            this.weakAcceptButton.TabIndex = 4;
            this.weakAcceptButton.Text = "Weak accept";
            this.weakAcceptButton.UseVisualStyleBackColor = true;
            this.weakAcceptButton.Click += new System.EventHandler(this.weakAcceptButton_Click);
            // 
            // borderlinePaperButton
            // 
            this.borderlinePaperButton.Location = new System.Drawing.Point(85, 538);
            this.borderlinePaperButton.Margin = new System.Windows.Forms.Padding(2);
            this.borderlinePaperButton.Name = "borderlinePaperButton";
            this.borderlinePaperButton.Size = new System.Drawing.Size(102, 41);
            this.borderlinePaperButton.TabIndex = 5;
            this.borderlinePaperButton.Text = "Borderline paper";
            this.borderlinePaperButton.UseVisualStyleBackColor = true;
            this.borderlinePaperButton.Click += new System.EventHandler(this.borderlinePaperButton_Click);
            // 
            // weakRejectButton
            // 
            this.weakRejectButton.Location = new System.Drawing.Point(11, 487);
            this.weakRejectButton.Margin = new System.Windows.Forms.Padding(2);
            this.weakRejectButton.Name = "weakRejectButton";
            this.weakRejectButton.Size = new System.Drawing.Size(102, 41);
            this.weakRejectButton.TabIndex = 6;
            this.weakRejectButton.Text = "Weak reject";
            this.weakRejectButton.UseVisualStyleBackColor = true;
            this.weakRejectButton.Click += new System.EventHandler(this.weakRejectButton_Click);
            // 
            // rejectButton
            // 
            this.rejectButton.Location = new System.Drawing.Point(180, 487);
            this.rejectButton.Margin = new System.Windows.Forms.Padding(2);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(102, 41);
            this.rejectButton.TabIndex = 7;
            this.rejectButton.Text = "Reject";
            this.rejectButton.UseVisualStyleBackColor = true;
            this.rejectButton.Click += new System.EventHandler(this.rejectButton_Click);
            // 
            // strongRejectButton
            // 
            this.strongRejectButton.Location = new System.Drawing.Point(180, 433);
            this.strongRejectButton.Margin = new System.Windows.Forms.Padding(2);
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
            this.papersListBox.Size = new System.Drawing.Size(264, 251);
            this.papersListBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "All Papers";
            // 
            // biddingPapersListBox
            // 
            this.biddingPapersListBox.FormattingEnabled = true;
            this.biddingPapersListBox.Location = new System.Drawing.Point(342, 46);
            this.biddingPapersListBox.Name = "biddingPapersListBox";
            this.biddingPapersListBox.Size = new System.Drawing.Size(256, 394);
            this.biddingPapersListBox.TabIndex = 11;
            // 
            // bidStrongInterestButton
            // 
            this.bidStrongInterestButton.Location = new System.Drawing.Point(342, 462);
            this.bidStrongInterestButton.Margin = new System.Windows.Forms.Padding(2);
            this.bidStrongInterestButton.Name = "bidStrongInterestButton";
            this.bidStrongInterestButton.Size = new System.Drawing.Size(111, 41);
            this.bidStrongInterestButton.TabIndex = 12;
            this.bidStrongInterestButton.Text = "Bid strong Interest";
            this.bidStrongInterestButton.UseVisualStyleBackColor = true;
            this.bidStrongInterestButton.Click += new System.EventHandler(this.bidStrongInterestButton_Click);
            // 
            // bidInterestButton
            // 
            this.bidInterestButton.Location = new System.Drawing.Point(487, 462);
            this.bidInterestButton.Margin = new System.Windows.Forms.Padding(2);
            this.bidInterestButton.Name = "bidInterestButton";
            this.bidInterestButton.Size = new System.Drawing.Size(111, 41);
            this.bidInterestButton.TabIndex = 13;
            this.bidInterestButton.Text = "Bid Interest";
            this.bidInterestButton.UseVisualStyleBackColor = true;
            this.bidInterestButton.Click += new System.EventHandler(this.bidInterestButton_Click);
            // 
            // bidRejectionButton
            // 
            this.bidRejectionButton.Location = new System.Drawing.Point(487, 527);
            this.bidRejectionButton.Margin = new System.Windows.Forms.Padding(2);
            this.bidRejectionButton.Name = "bidRejectionButton";
            this.bidRejectionButton.Size = new System.Drawing.Size(111, 41);
            this.bidRejectionButton.TabIndex = 15;
            this.bidRejectionButton.Text = "Bid Rejection";
            this.bidRejectionButton.UseVisualStyleBackColor = true;
            this.bidRejectionButton.Click += new System.EventHandler(this.bidRejectionButton_Click);
            // 
            // bidStrongRejectionButton
            // 
            this.bidStrongRejectionButton.Location = new System.Drawing.Point(342, 527);
            this.bidStrongRejectionButton.Margin = new System.Windows.Forms.Padding(2);
            this.bidStrongRejectionButton.Name = "bidStrongRejectionButton";
            this.bidStrongRejectionButton.Size = new System.Drawing.Size(111, 41);
            this.bidStrongRejectionButton.TabIndex = 14;
            this.bidStrongRejectionButton.Text = "Bid strong Rejection";
            this.bidStrongRejectionButton.UseVisualStyleBackColor = true;
            this.bidStrongRejectionButton.Click += new System.EventHandler(this.bidStrongRejectionButton_Click);
            // 
            // recommendationTextBox
            // 
            this.recommendationTextBox.Location = new System.Drawing.Point(13, 330);
            this.recommendationTextBox.Name = "recommendationTextBox";
            this.recommendationTextBox.Size = new System.Drawing.Size(264, 44);
            this.recommendationTextBox.TabIndex = 16;
            this.recommendationTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Recommendation";
            // 
            // ReviewerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 590);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recommendationTextBox);
            this.Controls.Add(this.bidRejectionButton);
            this.Controls.Add(this.bidStrongRejectionButton);
            this.Controls.Add(this.bidInterestButton);
            this.Controls.Add(this.bidStrongInterestButton);
            this.Controls.Add(this.biddingPapersListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.papersListBox);
            this.Controls.Add(this.strongRejectButton);
            this.Controls.Add(this.rejectButton);
            this.Controls.Add(this.weakRejectButton);
            this.Controls.Add(this.borderlinePaperButton);
            this.Controls.Add(this.weakAcceptButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.strongAcceptButton);
            this.Controls.Add(this.paperLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox biddingPapersListBox;
        private System.Windows.Forms.Button bidStrongInterestButton;
        private System.Windows.Forms.Button bidInterestButton;
        private System.Windows.Forms.Button bidRejectionButton;
        private System.Windows.Forms.Button bidStrongRejectionButton;
        private System.Windows.Forms.RichTextBox recommendationTextBox;
        private System.Windows.Forms.Label label2;
    }
}
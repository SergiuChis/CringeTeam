
namespace CringeProject.GUI {
    partial class AssignPaperToReviewerWindow {
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
            this.papersListBox = new System.Windows.Forms.ListBox();
            this.reviewersListBox = new System.Windows.Forms.ListBox();
            this.assignPaperButton = new System.Windows.Forms.Button();
            this.bidsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.acceptBidProposalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // papersListBox
            // 
            this.papersListBox.FormattingEnabled = true;
            this.papersListBox.Location = new System.Drawing.Point(12, 12);
            this.papersListBox.Name = "papersListBox";
            this.papersListBox.Size = new System.Drawing.Size(249, 329);
            this.papersListBox.TabIndex = 0;
            // 
            // reviewersListBox
            // 
            this.reviewersListBox.FormattingEnabled = true;
            this.reviewersListBox.Location = new System.Drawing.Point(302, 12);
            this.reviewersListBox.Name = "reviewersListBox";
            this.reviewersListBox.Size = new System.Drawing.Size(249, 329);
            this.reviewersListBox.TabIndex = 1;
            // 
            // assignPaperButton
            // 
            this.assignPaperButton.Location = new System.Drawing.Point(123, 386);
            this.assignPaperButton.Name = "assignPaperButton";
            this.assignPaperButton.Size = new System.Drawing.Size(314, 50);
            this.assignPaperButton.TabIndex = 2;
            this.assignPaperButton.Text = "Assign";
            this.assignPaperButton.UseVisualStyleBackColor = true;
            this.assignPaperButton.Click += new System.EventHandler(this.assignPaperButton_Click);
            // 
            // bidsListBox
            // 
            this.bidsListBox.FormattingEnabled = true;
            this.bidsListBox.Location = new System.Drawing.Point(631, 39);
            this.bidsListBox.Name = "bidsListBox";
            this.bidsListBox.Size = new System.Drawing.Size(245, 303);
            this.bidsListBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bids";
            // 
            // acceptBidProposalButton
            // 
            this.acceptBidProposalButton.Location = new System.Drawing.Point(631, 386);
            this.acceptBidProposalButton.Name = "acceptBidProposalButton";
            this.acceptBidProposalButton.Size = new System.Drawing.Size(245, 50);
            this.acceptBidProposalButton.TabIndex = 5;
            this.acceptBidProposalButton.Text = "Accept Bid Proposal";
            this.acceptBidProposalButton.UseVisualStyleBackColor = true;
            this.acceptBidProposalButton.Click += new System.EventHandler(this.acceptBidProposalButton_Click);
            // 
            // AssignPaperToReviewerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 460);
            this.Controls.Add(this.acceptBidProposalButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bidsListBox);
            this.Controls.Add(this.assignPaperButton);
            this.Controls.Add(this.reviewersListBox);
            this.Controls.Add(this.papersListBox);
            this.Name = "AssignPaperToReviewerWindow";
            this.Text = "AssignPaperToReviewerWindow";
            this.Load += new System.EventHandler(this.AssignPaperToReviewerWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox papersListBox;
        private System.Windows.Forms.ListBox reviewersListBox;
        private System.Windows.Forms.Button assignPaperButton;
        private System.Windows.Forms.ListBox bidsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button acceptBidProposalButton;
    }
}
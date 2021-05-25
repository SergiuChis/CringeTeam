
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.strongAcceptButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.weakAcceptButton = new System.Windows.Forms.Button();
            this.borderlinePaperButton = new System.Windows.Forms.Button();
            this.weakRejectButton = new System.Windows.Forms.Button();
            this.rejectButton = new System.Windows.Forms.Button();
            this.strongRejectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paperLabel
            // 
            this.paperLabel.AutoSize = true;
            this.paperLabel.Location = new System.Drawing.Point(507, 45);
            this.paperLabel.Name = "paperLabel";
            this.paperLabel.Size = new System.Drawing.Size(69, 25);
            this.paperLabel.TabIndex = 0;
            this.paperLabel.Text = "Paper";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 88);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1238, 555);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // strongAcceptButton
            // 
            this.strongAcceptButton.Location = new System.Drawing.Point(13, 666);
            this.strongAcceptButton.Name = "strongAcceptButton";
            this.strongAcceptButton.Size = new System.Drawing.Size(205, 79);
            this.strongAcceptButton.TabIndex = 2;
            this.strongAcceptButton.Text = "Strong accept";
            this.strongAcceptButton.UseVisualStyleBackColor = true;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(350, 666);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(205, 79);
            this.acceptButton.TabIndex = 3;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            // 
            // weakAcceptButton
            // 
            this.weakAcceptButton.Location = new System.Drawing.Point(699, 666);
            this.weakAcceptButton.Name = "weakAcceptButton";
            this.weakAcceptButton.Size = new System.Drawing.Size(205, 79);
            this.weakAcceptButton.TabIndex = 4;
            this.weakAcceptButton.Text = "Weak accept";
            this.weakAcceptButton.UseVisualStyleBackColor = true;
            // 
            // borderlinePaperButton
            // 
            this.borderlinePaperButton.Location = new System.Drawing.Point(1046, 666);
            this.borderlinePaperButton.Name = "borderlinePaperButton";
            this.borderlinePaperButton.Size = new System.Drawing.Size(205, 79);
            this.borderlinePaperButton.TabIndex = 5;
            this.borderlinePaperButton.Text = "Borderline paper";
            this.borderlinePaperButton.UseVisualStyleBackColor = true;
            // 
            // weakRejectButton
            // 
            this.weakRejectButton.Location = new System.Drawing.Point(13, 785);
            this.weakRejectButton.Name = "weakRejectButton";
            this.weakRejectButton.Size = new System.Drawing.Size(205, 79);
            this.weakRejectButton.TabIndex = 6;
            this.weakRejectButton.Text = "Weak reject";
            this.weakRejectButton.UseVisualStyleBackColor = true;
            // 
            // rejectButton
            // 
            this.rejectButton.Location = new System.Drawing.Point(350, 785);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(205, 79);
            this.rejectButton.TabIndex = 7;
            this.rejectButton.Text = "Reject";
            this.rejectButton.UseVisualStyleBackColor = true;
            // 
            // strongRejectButton
            // 
            this.strongRejectButton.Location = new System.Drawing.Point(699, 785);
            this.strongRejectButton.Name = "strongRejectButton";
            this.strongRejectButton.Size = new System.Drawing.Size(205, 79);
            this.strongRejectButton.TabIndex = 8;
            this.strongRejectButton.Text = "Strong reject";
            this.strongRejectButton.UseVisualStyleBackColor = true;
            // 
            // ReviewerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 876);
            this.Controls.Add(this.strongRejectButton);
            this.Controls.Add(this.rejectButton);
            this.Controls.Add(this.weakRejectButton);
            this.Controls.Add(this.borderlinePaperButton);
            this.Controls.Add(this.weakAcceptButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.strongAcceptButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.paperLabel);
            this.Name = "ReviewerWindow";
            this.Text = "ReviewerWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label paperLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button strongAcceptButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button weakAcceptButton;
        private System.Windows.Forms.Button borderlinePaperButton;
        private System.Windows.Forms.Button weakRejectButton;
        private System.Windows.Forms.Button rejectButton;
        private System.Windows.Forms.Button strongRejectButton;
    }
}
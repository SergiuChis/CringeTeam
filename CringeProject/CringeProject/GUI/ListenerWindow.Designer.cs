namespace CringeProject.GUI
{
    partial class ListenerWindow
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
            this.roomLabel = new System.Windows.Forms.Label();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.availablePlacesLabel = new System.Windows.Forms.Label();
            this.availablePlacesNumberLabel = new System.Windows.Forms.Label();
            this.addPaperButton = new System.Windows.Forms.Button();
            this.myPapersListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.submitAbstractButton = new System.Windows.Forms.Button();
            this.paperDetailsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Location = new System.Drawing.Point(292, 71);
            this.roomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(38, 13);
            this.roomLabel.TabIndex = 0;
            this.roomLabel.Text = "Room:";
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Location = new System.Drawing.Point(341, 71);
            this.roomNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(0, 13);
            this.roomNameLabel.TabIndex = 1;
            // 
            // availablePlacesLabel
            // 
            this.availablePlacesLabel.AutoSize = true;
            this.availablePlacesLabel.Location = new System.Drawing.Point(292, 106);
            this.availablePlacesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.availablePlacesLabel.Name = "availablePlacesLabel";
            this.availablePlacesLabel.Size = new System.Drawing.Size(87, 13);
            this.availablePlacesLabel.TabIndex = 2;
            this.availablePlacesLabel.Text = "Available places:";
            // 
            // availablePlacesNumberLabel
            // 
            this.availablePlacesNumberLabel.AutoSize = true;
            this.availablePlacesNumberLabel.Location = new System.Drawing.Point(383, 106);
            this.availablePlacesNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.availablePlacesNumberLabel.Name = "availablePlacesNumberLabel";
            this.availablePlacesNumberLabel.Size = new System.Drawing.Size(0, 13);
            this.availablePlacesNumberLabel.TabIndex = 3;
            // 
            // addPaperButton
            // 
            this.addPaperButton.Location = new System.Drawing.Point(12, 382);
            this.addPaperButton.Name = "addPaperButton";
            this.addPaperButton.Size = new System.Drawing.Size(229, 36);
            this.addPaperButton.TabIndex = 4;
            this.addPaperButton.Text = "Add Full Paper Details";
            this.addPaperButton.UseVisualStyleBackColor = true;
            this.addPaperButton.Click += new System.EventHandler(this.addPaperButton_Click);
            // 
            // myPapersListBox
            // 
            this.myPapersListBox.FormattingEnabled = true;
            this.myPapersListBox.Location = new System.Drawing.Point(12, 12);
            this.myPapersListBox.Name = "myPapersListBox";
            this.myPapersListBox.Size = new System.Drawing.Size(229, 316);
            this.myPapersListBox.TabIndex = 5;
            this.myPapersListBox.SelectedIndexChanged += new System.EventHandler(this.myPapersListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Conference details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Paper details:";
            // 
            // submitAbstractButton
            // 
            this.submitAbstractButton.Location = new System.Drawing.Point(12, 340);
            this.submitAbstractButton.Name = "submitAbstractButton";
            this.submitAbstractButton.Size = new System.Drawing.Size(229, 36);
            this.submitAbstractButton.TabIndex = 8;
            this.submitAbstractButton.Text = "Submit Abstract";
            this.submitAbstractButton.UseVisualStyleBackColor = true;
            this.submitAbstractButton.Click += new System.EventHandler(this.submitAbstractButton_Click);
            // 
            // paperDetailsRichTextBox
            // 
            this.paperDetailsRichTextBox.Enabled = false;
            this.paperDetailsRichTextBox.Location = new System.Drawing.Point(274, 264);
            this.paperDetailsRichTextBox.Name = "paperDetailsRichTextBox";
            this.paperDetailsRichTextBox.Size = new System.Drawing.Size(209, 78);
            this.paperDetailsRichTextBox.TabIndex = 9;
            this.paperDetailsRichTextBox.Text = "";
            // 
            // ListenerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 430);
            this.Controls.Add(this.paperDetailsRichTextBox);
            this.Controls.Add(this.submitAbstractButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myPapersListBox);
            this.Controls.Add(this.addPaperButton);
            this.Controls.Add(this.availablePlacesNumberLabel);
            this.Controls.Add(this.availablePlacesLabel);
            this.Controls.Add(this.roomNameLabel);
            this.Controls.Add(this.roomLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListenerWindow";
            this.Text = "ListenerWindow";
            this.Load += new System.EventHandler(this.ListenerWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.Label availablePlacesLabel;
        private System.Windows.Forms.Label availablePlacesNumberLabel;
        private System.Windows.Forms.Button addPaperButton;
        private System.Windows.Forms.ListBox myPapersListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitAbstractButton;
        private System.Windows.Forms.RichTextBox paperDetailsRichTextBox;
    }
}

namespace CringeProject.GUI {
    partial class SubmitAbstractWindow {
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
            this.abstractRichTextBox = new System.Windows.Forms.RichTextBox();
            this.submitAbstractButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abstract";
            // 
            // abstractRichTextBox
            // 
            this.abstractRichTextBox.Location = new System.Drawing.Point(12, 114);
            this.abstractRichTextBox.Name = "abstractRichTextBox";
            this.abstractRichTextBox.Size = new System.Drawing.Size(305, 277);
            this.abstractRichTextBox.TabIndex = 1;
            this.abstractRichTextBox.Text = "";
            // 
            // submitAbstractButton
            // 
            this.submitAbstractButton.Location = new System.Drawing.Point(39, 408);
            this.submitAbstractButton.Name = "submitAbstractButton";
            this.submitAbstractButton.Size = new System.Drawing.Size(257, 32);
            this.submitAbstractButton.TabIndex = 2;
            this.submitAbstractButton.Text = "Submit";
            this.submitAbstractButton.UseVisualStyleBackColor = true;
            this.submitAbstractButton.Click += new System.EventHandler(this.submitAbstractButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(12, 44);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(305, 20);
            this.titleTextBox.TabIndex = 4;
            // 
            // SubmitAbstractWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 452);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submitAbstractButton);
            this.Controls.Add(this.abstractRichTextBox);
            this.Controls.Add(this.label1);
            this.Name = "SubmitAbstractWindow";
            this.Text = "SubmitAbstractWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox abstractRichTextBox;
        private System.Windows.Forms.Button submitAbstractButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleTextBox;
    }
}
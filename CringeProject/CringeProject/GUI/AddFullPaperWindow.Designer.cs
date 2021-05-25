
namespace CringeProject.GUI {
    partial class AddFullPaperWindow {
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
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addPaperButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abstract:";
            // 
            // abstractRichTextBox
            // 
            this.abstractRichTextBox.Location = new System.Drawing.Point(93, 40);
            this.abstractRichTextBox.Name = "abstractRichTextBox";
            this.abstractRichTextBox.Size = new System.Drawing.Size(506, 98);
            this.abstractRichTextBox.TabIndex = 1;
            this.abstractRichTextBox.Text = "";
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Location = new System.Drawing.Point(93, 184);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(506, 181);
            this.descriptionRichTextBox.TabIndex = 2;
            this.descriptionRichTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // addPaperButton
            // 
            this.addPaperButton.Location = new System.Drawing.Point(191, 388);
            this.addPaperButton.Name = "addPaperButton";
            this.addPaperButton.Size = new System.Drawing.Size(224, 41);
            this.addPaperButton.TabIndex = 4;
            this.addPaperButton.Text = "Update details";
            this.addPaperButton.UseVisualStyleBackColor = true;
            this.addPaperButton.Click += new System.EventHandler(this.addPaperButton_Click);
            // 
            // AddFullPaperWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 441);
            this.Controls.Add(this.addPaperButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.abstractRichTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddFullPaperWindow";
            this.Text = "AddNewPaper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox abstractRichTextBox;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addPaperButton;
    }
}
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
            this.SuspendLayout();
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Location = new System.Drawing.Point(102, 88);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(74, 25);
            this.roomLabel.TabIndex = 0;
            this.roomLabel.Text = "Room:";
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Location = new System.Drawing.Point(199, 88);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(0, 25);
            this.roomNameLabel.TabIndex = 1;
            // 
            // availablePlacesLabel
            // 
            this.availablePlacesLabel.AutoSize = true;
            this.availablePlacesLabel.Location = new System.Drawing.Point(102, 156);
            this.availablePlacesLabel.Name = "availablePlacesLabel";
            this.availablePlacesLabel.Size = new System.Drawing.Size(175, 25);
            this.availablePlacesLabel.TabIndex = 2;
            this.availablePlacesLabel.Text = "Available places:";
            // 
            // availablePlacesNumberLabel
            // 
            this.availablePlacesNumberLabel.AutoSize = true;
            this.availablePlacesNumberLabel.Location = new System.Drawing.Point(284, 156);
            this.availablePlacesNumberLabel.Name = "availablePlacesNumberLabel";
            this.availablePlacesNumberLabel.Size = new System.Drawing.Size(0, 25);
            this.availablePlacesNumberLabel.TabIndex = 3;
            // 
            // ListenerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 287);
            this.Controls.Add(this.availablePlacesNumberLabel);
            this.Controls.Add(this.availablePlacesLabel);
            this.Controls.Add(this.roomNameLabel);
            this.Controls.Add(this.roomLabel);
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
    }
}
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
            this.roomLabel.Location = new System.Drawing.Point(61, 56);
            this.roomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(38, 13);
            this.roomLabel.TabIndex = 0;
            this.roomLabel.Text = "Room:";
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Location = new System.Drawing.Point(110, 56);
            this.roomNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(0, 13);
            this.roomNameLabel.TabIndex = 1;
            // 
            // availablePlacesLabel
            // 
            this.availablePlacesLabel.AutoSize = true;
            this.availablePlacesLabel.Location = new System.Drawing.Point(61, 91);
            this.availablePlacesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.availablePlacesLabel.Name = "availablePlacesLabel";
            this.availablePlacesLabel.Size = new System.Drawing.Size(87, 13);
            this.availablePlacesLabel.TabIndex = 2;
            this.availablePlacesLabel.Text = "Available places:";
            // 
            // availablePlacesNumberLabel
            // 
            this.availablePlacesNumberLabel.AutoSize = true;
            this.availablePlacesNumberLabel.Location = new System.Drawing.Point(152, 91);
            this.availablePlacesNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.availablePlacesNumberLabel.Name = "availablePlacesNumberLabel";
            this.availablePlacesNumberLabel.Size = new System.Drawing.Size(0, 13);
            this.availablePlacesNumberLabel.TabIndex = 3;
            // 
            // ListenerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(221, 149);
            this.Controls.Add(this.availablePlacesNumberLabel);
            this.Controls.Add(this.availablePlacesLabel);
            this.Controls.Add(this.roomNameLabel);
            this.Controls.Add(this.roomLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ListenerWindow";
            this.Padding = new System.Windows.Forms.Padding(10);
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
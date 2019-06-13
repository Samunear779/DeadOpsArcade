namespace DeadOpsArcade
{
    partial class PlayerScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.heroTextBox = new System.Windows.Forms.TextBox();
            this.playerLabel = new System.Windows.Forms.Label();
            this.class1Box = new System.Windows.Forms.CheckBox();
            this.class2Box = new System.Windows.Forms.CheckBox();
            this.class3Box = new System.Windows.Forms.CheckBox();
            this.playButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // heroTextBox
            // 
            this.heroTextBox.Location = new System.Drawing.Point(414, 221);
            this.heroTextBox.Name = "heroTextBox";
            this.heroTextBox.Size = new System.Drawing.Size(275, 20);
            this.heroTextBox.TabIndex = 0;
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(338, 224);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(70, 13);
            this.playerLabel.TabIndex = 2;
            this.playerLabel.Text = "Player Name:";
            // 
            // class1Box
            // 
            this.class1Box.AutoSize = true;
            this.class1Box.Location = new System.Drawing.Point(414, 300);
            this.class1Box.Name = "class1Box";
            this.class1Box.Size = new System.Drawing.Size(173, 17);
            this.class1Box.TabIndex = 3;
            this.class1Box.Text = "Slowest Speed, Highest Health";
            this.class1Box.UseVisualStyleBackColor = true;
            this.class1Box.CheckedChanged += new System.EventHandler(this.class1Box_CheckedChanged);
            // 
            // class2Box
            // 
            this.class2Box.AutoSize = true;
            this.class2Box.Location = new System.Drawing.Point(414, 355);
            this.class2Box.Name = "class2Box";
            this.class2Box.Size = new System.Drawing.Size(166, 17);
            this.class2Box.TabIndex = 4;
            this.class2Box.Text = "Normal Speed, Normal Health";
            this.class2Box.UseVisualStyleBackColor = true;
            this.class2Box.CheckedChanged += new System.EventHandler(this.calssBox2_CheckedChanged);
            // 
            // class3Box
            // 
            this.class3Box.AutoSize = true;
            this.class3Box.Location = new System.Drawing.Point(414, 403);
            this.class3Box.Name = "class3Box";
            this.class3Box.Size = new System.Drawing.Size(170, 17);
            this.class3Box.TabIndex = 5;
            this.class3Box.Text = "Highest Speed, Lowest Health";
            this.class3Box.UseVisualStyleBackColor = true;
            this.class3Box.CheckedChanged += new System.EventHandler(this.classBox3_CheckedChanged);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(604, 550);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(320, 72);
            this.playButton.TabIndex = 6;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(246, 550);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(320, 72);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // PlayerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.class3Box);
            this.Controls.Add(this.class2Box);
            this.Controls.Add(this.class1Box);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.heroTextBox);
            this.Name = "PlayerScreen";
            this.Size = new System.Drawing.Size(1280, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox heroTextBox;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.CheckBox class1Box;
        private System.Windows.Forms.CheckBox class2Box;
        private System.Windows.Forms.CheckBox class3Box;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button backButton;
    }
}

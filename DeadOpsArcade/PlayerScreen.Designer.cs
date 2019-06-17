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
            this.classButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // heroTextBox
            // 
            this.heroTextBox.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroTextBox.Location = new System.Drawing.Point(493, 170);
            this.heroTextBox.Name = "heroTextBox";
            this.heroTextBox.Size = new System.Drawing.Size(166, 49);
            this.heroTextBox.TabIndex = 0;
            this.heroTextBox.TextChanged += new System.EventHandler(this.heroTextBox_TextChanged);
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerLabel.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.ForeColor = System.Drawing.Color.Yellow;
            this.playerLabel.Location = new System.Drawing.Point(251, 170);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(200, 45);
            this.playerLabel.TabIndex = 2;
            this.playerLabel.Text = "Player Name:";
            // 
            // class1Box
            // 
            this.class1Box.AutoSize = true;
            this.class1Box.BackColor = System.Drawing.Color.Transparent;
            this.class1Box.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class1Box.ForeColor = System.Drawing.Color.Yellow;
            this.class1Box.Location = new System.Drawing.Point(345, 250);
            this.class1Box.Name = "class1Box";
            this.class1Box.Size = new System.Drawing.Size(369, 40);
            this.class1Box.TabIndex = 3;
            this.class1Box.Text = "Slowest Speed, Fastest Fire Rate";
            this.class1Box.UseVisualStyleBackColor = false;
            this.class1Box.CheckedChanged += new System.EventHandler(this.class1Box_CheckedChanged);
            // 
            // class2Box
            // 
            this.class2Box.AutoSize = true;
            this.class2Box.BackColor = System.Drawing.Color.Transparent;
            this.class2Box.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class2Box.ForeColor = System.Drawing.Color.Yellow;
            this.class2Box.Location = new System.Drawing.Point(345, 330);
            this.class2Box.Name = "class2Box";
            this.class2Box.Size = new System.Drawing.Size(370, 40);
            this.class2Box.TabIndex = 4;
            this.class2Box.Text = "Normal Speed, Normal Fire Rate";
            this.class2Box.UseVisualStyleBackColor = false;
            this.class2Box.CheckedChanged += new System.EventHandler(this.calssBox2_CheckedChanged);
            // 
            // class3Box
            // 
            this.class3Box.AutoSize = true;
            this.class3Box.BackColor = System.Drawing.Color.Transparent;
            this.class3Box.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class3Box.ForeColor = System.Drawing.Color.Yellow;
            this.class3Box.Location = new System.Drawing.Point(344, 403);
            this.class3Box.Name = "class3Box";
            this.class3Box.Size = new System.Drawing.Size(366, 40);
            this.class3Box.TabIndex = 5;
            this.class3Box.Text = "Fastest Speed, Lowest Fire Rate";
            this.class3Box.UseVisualStyleBackColor = false;
            this.class3Box.CheckedChanged += new System.EventHandler(this.classBox3_CheckedChanged);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.Yellow;
            this.playButton.Location = new System.Drawing.Point(516, 476);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(320, 72);
            this.playButton.TabIndex = 6;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.Yellow;
            this.backButton.Location = new System.Drawing.Point(152, 476);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(320, 72);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // classButton
            // 
            this.classButton.BackColor = System.Drawing.Color.Transparent;
            this.classButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classButton.ForeColor = System.Drawing.Color.Yellow;
            this.classButton.Location = new System.Drawing.Point(165, 310);
            this.classButton.Name = "classButton";
            this.classButton.Size = new System.Drawing.Size(144, 72);
            this.classButton.TabIndex = 8;
            this.classButton.Text = "RESET";
            this.classButton.UseVisualStyleBackColor = false;
            this.classButton.Click += new System.EventHandler(this.classButton_Click);
            // 
            // PlayerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeadOpsArcade.Properties.Resources.PlayerScreen;
            this.Controls.Add(this.classButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.class3Box);
            this.Controls.Add(this.class2Box);
            this.Controls.Add(this.class1Box);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.heroTextBox);
            this.Name = "PlayerScreen";
            this.Size = new System.Drawing.Size(1000, 700);
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
        private System.Windows.Forms.Button classButton;
    }
}

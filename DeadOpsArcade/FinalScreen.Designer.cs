namespace DeadOpsArcade
{
    partial class FinalScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.yourScoreLabel = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.highButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(368, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "GAMEOVER";
            // 
            // yourScoreLabel
            // 
            this.yourScoreLabel.AutoSize = true;
            this.yourScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.yourScoreLabel.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourScoreLabel.ForeColor = System.Drawing.Color.Yellow;
            this.yourScoreLabel.Location = new System.Drawing.Point(274, 323);
            this.yourScoreLabel.Name = "yourScoreLabel";
            this.yourScoreLabel.Size = new System.Drawing.Size(382, 57);
            this.yourScoreLabel.TabIndex = 1;
            this.yourScoreLabel.Text = "Display Players score";
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.Yellow;
            this.menuButton.Location = new System.Drawing.Point(197, 485);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(263, 71);
            this.menuButton.TabIndex = 2;
            this.menuButton.Tag = "";
            this.menuButton.Text = "Main Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // highButton
            // 
            this.highButton.BackColor = System.Drawing.Color.Transparent;
            this.highButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highButton.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highButton.ForeColor = System.Drawing.Color.Yellow;
            this.highButton.Location = new System.Drawing.Point(520, 485);
            this.highButton.Name = "highButton";
            this.highButton.Size = new System.Drawing.Size(263, 71);
            this.highButton.TabIndex = 3;
            this.highButton.Tag = "";
            this.highButton.Text = "HighScores";
            this.highButton.UseVisualStyleBackColor = false;
            this.highButton.Click += new System.EventHandler(this.highButton_Click);
            // 
            // FinalScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeadOpsArcade.Properties.Resources.PlayerScreen;
            this.Controls.Add(this.highButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.yourScoreLabel);
            this.Controls.Add(this.label1);
            this.Name = "FinalScreen";
            this.Size = new System.Drawing.Size(1000, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label yourScoreLabel;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button highButton;
    }
}

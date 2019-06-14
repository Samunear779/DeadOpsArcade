namespace DeadOpsArcade
{
    partial class MainMenu
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
            this.playerButton = new System.Windows.Forms.Button();
            this.highScoreButton = new System.Windows.Forms.Button();
            this.howToButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerButton
            // 
            this.playerButton.BackColor = System.Drawing.Color.Transparent;
            this.playerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playerButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerButton.ForeColor = System.Drawing.Color.Yellow;
            this.playerButton.Location = new System.Drawing.Point(392, 558);
            this.playerButton.Name = "playerButton";
            this.playerButton.Size = new System.Drawing.Size(232, 58);
            this.playerButton.TabIndex = 0;
            this.playerButton.Text = "Player Creation";
            this.playerButton.UseVisualStyleBackColor = false;
            this.playerButton.Click += new System.EventHandler(this.playerButton_Click);
            // 
            // highScoreButton
            // 
            this.highScoreButton.BackColor = System.Drawing.Color.Transparent;
            this.highScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highScoreButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreButton.ForeColor = System.Drawing.Color.Yellow;
            this.highScoreButton.Location = new System.Drawing.Point(603, 340);
            this.highScoreButton.Name = "highScoreButton";
            this.highScoreButton.Size = new System.Drawing.Size(197, 60);
            this.highScoreButton.TabIndex = 1;
            this.highScoreButton.Text = "High Scores";
            this.highScoreButton.UseVisualStyleBackColor = false;
            this.highScoreButton.Click += new System.EventHandler(this.highScoreButton_Click);
            // 
            // howToButton
            // 
            this.howToButton.BackColor = System.Drawing.Color.Transparent;
            this.howToButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.howToButton.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToButton.ForeColor = System.Drawing.Color.Yellow;
            this.howToButton.Location = new System.Drawing.Point(191, 348);
            this.howToButton.Name = "howToButton";
            this.howToButton.Size = new System.Drawing.Size(222, 52);
            this.howToButton.TabIndex = 2;
            this.howToButton.Text = "How To Play";
            this.howToButton.UseVisualStyleBackColor = false;
            this.howToButton.Click += new System.EventHandler(this.howToButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeadOpsArcade.Properties.Resources.Title;
            this.Controls.Add(this.howToButton);
            this.Controls.Add(this.highScoreButton);
            this.Controls.Add(this.playerButton);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(1000, 700);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playerButton;
        private System.Windows.Forms.Button highScoreButton;
        private System.Windows.Forms.Button howToButton;
    }
}

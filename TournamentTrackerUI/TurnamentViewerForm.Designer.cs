namespace TournamentTrackerUI
{
    partial class TurnamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TurnamentViewerForm));
            this.tournamentLabel = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundDropdown = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.matchupListbox = new System.Windows.Forms.ListBox();
            this.teamOneLabel = new System.Windows.Forms.Label();
            this.teamTwoLabel = new System.Windows.Forms.Label();
            this.teamOneScoreLabel = new System.Windows.Forms.Label();
            this.teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.teamOneScoreValue = new System.Windows.Forms.TextBox();
            this.teamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.scoreTeamButton = new System.Windows.Forms.Button();
            this.versusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tournamentLabel
            // 
            this.tournamentLabel.AutoSize = true;
            this.tournamentLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tournamentLabel.Location = new System.Drawing.Point(25, 31);
            this.tournamentLabel.Name = "tournamentLabel";
            this.tournamentLabel.Size = new System.Drawing.Size(235, 54);
            this.tournamentLabel.TabIndex = 0;
            this.tournamentLabel.Text = "Tournament";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.roundLabel.Location = new System.Drawing.Point(39, 95);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(97, 38);
            this.roundLabel.TabIndex = 1;
            this.roundLabel.Text = "Round";
            // 
            // roundDropdown
            // 
            this.roundDropdown.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundDropdown.FormattingEnabled = true;
            this.roundDropdown.Location = new System.Drawing.Point(152, 94);
            this.roundDropdown.Name = "roundDropdown";
            this.roundDropdown.Size = new System.Drawing.Size(244, 39);
            this.roundDropdown.TabIndex = 2;
            // 
            // unplayedOnlyCheckBox
            // 
            this.unplayedOnlyCheckBox.AutoSize = true;
            this.unplayedOnlyCheckBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.unplayedOnlyCheckBox.Location = new System.Drawing.Point(152, 152);
            this.unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            this.unplayedOnlyCheckBox.Size = new System.Drawing.Size(222, 42);
            this.unplayedOnlyCheckBox.TabIndex = 3;
            this.unplayedOnlyCheckBox.Text = "Unplayed Only";
            this.unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListbox
            // 
            this.matchupListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListbox.FormattingEnabled = true;
            this.matchupListbox.ItemHeight = 37;
            this.matchupListbox.Location = new System.Drawing.Point(47, 204);
            this.matchupListbox.Name = "matchupListbox";
            this.matchupListbox.Size = new System.Drawing.Size(349, 224);
            this.matchupListbox.TabIndex = 4;
            // 
            // teamOneLabel
            // 
            this.teamOneLabel.AutoSize = true;
            this.teamOneLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.teamOneLabel.Location = new System.Drawing.Point(471, 133);
            this.teamOneLabel.Name = "teamOneLabel";
            this.teamOneLabel.Size = new System.Drawing.Size(142, 38);
            this.teamOneLabel.TabIndex = 5;
            this.teamOneLabel.Text = "Team One";
            // 
            // teamTwoLabel
            // 
            this.teamTwoLabel.AutoSize = true;
            this.teamTwoLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.teamTwoLabel.Location = new System.Drawing.Point(471, 276);
            this.teamTwoLabel.Name = "teamTwoLabel";
            this.teamTwoLabel.Size = new System.Drawing.Size(139, 38);
            this.teamTwoLabel.TabIndex = 6;
            this.teamTwoLabel.Text = "Team Two";
            // 
            // teamOneScoreLabel
            // 
            this.teamOneScoreLabel.AutoSize = true;
            this.teamOneScoreLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.teamOneScoreLabel.Location = new System.Drawing.Point(471, 194);
            this.teamOneScoreLabel.Name = "teamOneScoreLabel";
            this.teamOneScoreLabel.Size = new System.Drawing.Size(86, 38);
            this.teamOneScoreLabel.TabIndex = 7;
            this.teamOneScoreLabel.Text = "Score";
            // 
            // teamTwoScoreLabel
            // 
            this.teamTwoScoreLabel.AutoSize = true;
            this.teamTwoScoreLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.teamTwoScoreLabel.Location = new System.Drawing.Point(471, 335);
            this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            this.teamTwoScoreLabel.Size = new System.Drawing.Size(86, 38);
            this.teamTwoScoreLabel.TabIndex = 8;
            this.teamTwoScoreLabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            this.teamOneScoreValue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.teamOneScoreValue.Location = new System.Drawing.Point(572, 189);
            this.teamOneScoreValue.Name = "teamOneScoreValue";
            this.teamOneScoreValue.Size = new System.Drawing.Size(125, 43);
            this.teamOneScoreValue.TabIndex = 9;
            this.teamOneScoreValue.Text = "score";
            // 
            // teamTwoScoreValue
            // 
            this.teamTwoScoreValue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.teamTwoScoreValue.Location = new System.Drawing.Point(572, 335);
            this.teamTwoScoreValue.Name = "teamTwoScoreValue";
            this.teamTwoScoreValue.Size = new System.Drawing.Size(125, 43);
            this.teamTwoScoreValue.TabIndex = 10;
            this.teamTwoScoreValue.Text = "score";
            // 
            // scoreTeamButton
            // 
            this.scoreTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.scoreTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.scoreTeamButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.scoreTeamButton.Location = new System.Drawing.Point(710, 247);
            this.scoreTeamButton.Name = "scoreTeamButton";
            this.scoreTeamButton.Size = new System.Drawing.Size(94, 55);
            this.scoreTeamButton.TabIndex = 11;
            this.scoreTeamButton.Text = "Score";
            this.scoreTeamButton.UseVisualStyleBackColor = true;
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.versusLabel.Location = new System.Drawing.Point(637, 264);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(48, 38);
            this.versusLabel.TabIndex = 12;
            this.versusLabel.Text = "vs.";
            // 
            // TurnamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(848, 438);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.scoreTeamButton);
            this.Controls.Add(this.teamTwoScoreValue);
            this.Controls.Add(this.teamOneScoreValue);
            this.Controls.Add(this.teamTwoScoreLabel);
            this.Controls.Add(this.teamOneScoreLabel);
            this.Controls.Add(this.teamTwoLabel);
            this.Controls.Add(this.teamOneLabel);
            this.Controls.Add(this.matchupListbox);
            this.Controls.Add(this.unplayedOnlyCheckBox);
            this.Controls.Add(this.roundDropdown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "TurnamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label tournamentLabel;
        private Label roundLabel;
        private ComboBox roundDropdown;
        private CheckBox unplayedOnlyCheckBox;
        private ListBox matchupListbox;
        private Label teamOneLabel;
        private Label teamTwoLabel;
        private Label teamOneScoreLabel;
        private Label teamTwoScoreLabel;
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreValue;
        private Button scoreTeamButton;
        private Label versusLabel;
    }
}
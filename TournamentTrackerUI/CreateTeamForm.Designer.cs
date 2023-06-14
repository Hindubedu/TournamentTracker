namespace TournamentTrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.teamNameTextBox = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.createTeamLabel = new System.Windows.Forms.Label();
            this.addTeamMemberButton = new System.Windows.Forms.Button();
            this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.addMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.cellPhoneValue = new System.Windows.Forms.TextBox();
            this.cellPhoneLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedmemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.addMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameTextBox
            // 
            this.teamNameTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.teamNameTextBox.Location = new System.Drawing.Point(39, 163);
            this.teamNameTextBox.Name = "teamNameTextBox";
            this.teamNameTextBox.Size = new System.Drawing.Size(446, 43);
            this.teamNameTextBox.TabIndex = 14;
            this.teamNameTextBox.TextChanged += new System.EventHandler(this.tournamentNameTextBox_TextChanged);
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.teamNameLabel.Location = new System.Drawing.Point(39, 104);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(164, 38);
            this.teamNameLabel.TabIndex = 13;
            this.teamNameLabel.Text = "Team Name";
            this.teamNameLabel.Click += new System.EventHandler(this.tournamentNameLabel_Click);
            // 
            // createTeamLabel
            // 
            this.createTeamLabel.AutoSize = true;
            this.createTeamLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createTeamLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.createTeamLabel.Location = new System.Drawing.Point(39, 37);
            this.createTeamLabel.Name = "createTeamLabel";
            this.createTeamLabel.Size = new System.Drawing.Size(241, 54);
            this.createTeamLabel.TabIndex = 12;
            this.createTeamLabel.Text = "Create Team";
            this.createTeamLabel.Click += new System.EventHandler(this.tournamentLabel_Click);
            // 
            // addTeamMemberButton
            // 
            this.addTeamMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addTeamMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.addTeamMemberButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addTeamMemberButton.Location = new System.Drawing.Point(188, 352);
            this.addTeamMemberButton.Name = "addTeamMemberButton";
            this.addTeamMemberButton.Size = new System.Drawing.Size(177, 50);
            this.addTeamMemberButton.TabIndex = 20;
            this.addTeamMemberButton.Text = "Add Member";
            this.addTeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropDown
            // 
            this.selectTeamMemberDropDown.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamMemberDropDown.FormattingEnabled = true;
            this.selectTeamMemberDropDown.Location = new System.Drawing.Point(39, 296);
            this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            this.selectTeamMemberDropDown.Size = new System.Drawing.Size(442, 39);
            this.selectTeamMemberDropDown.TabIndex = 19;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(39, 240);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(277, 38);
            this.selectTeamMemberLabel.TabIndex = 18;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addMemberGroupBox
            // 
            this.addMemberGroupBox.Controls.Add(this.createMemberButton);
            this.addMemberGroupBox.Controls.Add(this.cellPhoneValue);
            this.addMemberGroupBox.Controls.Add(this.cellPhoneLabel);
            this.addMemberGroupBox.Controls.Add(this.emailValue);
            this.addMemberGroupBox.Controls.Add(this.emailLabel);
            this.addMemberGroupBox.Controls.Add(this.lastNameTextBox);
            this.addMemberGroupBox.Controls.Add(this.lastNameLabel);
            this.addMemberGroupBox.Controls.Add(this.firstNameTextBox);
            this.addMemberGroupBox.Controls.Add(this.firstNameLabel);
            this.addMemberGroupBox.Location = new System.Drawing.Point(39, 433);
            this.addMemberGroupBox.Name = "addMemberGroupBox";
            this.addMemberGroupBox.Size = new System.Drawing.Size(446, 341);
            this.addMemberGroupBox.TabIndex = 21;
            this.addMemberGroupBox.TabStop = false;
            this.addMemberGroupBox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.createMemberButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.createMemberButton.Location = new System.Drawing.Point(117, 275);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(177, 50);
            this.createMemberButton.TabIndex = 18;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            this.createMemberButton.Click += new System.EventHandler(this.createMemberButton_Click);
            // 
            // cellPhoneValue
            // 
            this.cellPhoneValue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cellPhoneValue.Location = new System.Drawing.Point(176, 203);
            this.cellPhoneValue.Name = "cellPhoneValue";
            this.cellPhoneValue.Size = new System.Drawing.Size(264, 43);
            this.cellPhoneValue.TabIndex = 17;
            // 
            // cellPhoneLabel
            // 
            this.cellPhoneLabel.AutoSize = true;
            this.cellPhoneLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cellPhoneLabel.Location = new System.Drawing.Point(15, 206);
            this.cellPhoneLabel.Name = "cellPhoneLabel";
            this.cellPhoneLabel.Size = new System.Drawing.Size(142, 38);
            this.cellPhoneLabel.TabIndex = 16;
            this.cellPhoneLabel.Text = "Cellphone";
            // 
            // emailValue
            // 
            this.emailValue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.emailValue.Location = new System.Drawing.Point(176, 154);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(264, 43);
            this.emailValue.TabIndex = 15;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.emailLabel.Location = new System.Drawing.Point(15, 157);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(83, 38);
            this.emailLabel.TabIndex = 14;
            this.emailLabel.Text = "Email";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lastNameTextBox.Location = new System.Drawing.Point(176, 93);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(264, 43);
            this.lastNameTextBox.TabIndex = 13;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lastNameLabel.Location = new System.Drawing.Point(15, 96);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(147, 38);
            this.lastNameLabel.TabIndex = 12;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.firstNameTextBox.Location = new System.Drawing.Point(176, 44);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(264, 43);
            this.firstNameTextBox.TabIndex = 11;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.firstNameLabel.Location = new System.Drawing.Point(15, 47);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(151, 38);
            this.firstNameLabel.TabIndex = 10;
            this.firstNameLabel.Text = "First Name";
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 37;
            this.teamMembersListBox.Location = new System.Drawing.Point(568, 111);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(472, 631);
            this.teamMembersListBox.TabIndex = 22;
            // 
            // deleteSelectedmemberButton
            // 
            this.deleteSelectedmemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedmemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.deleteSelectedmemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.deleteSelectedmemberButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.deleteSelectedmemberButton.Location = new System.Drawing.Point(1046, 390);
            this.deleteSelectedmemberButton.Name = "deleteSelectedmemberButton";
            this.deleteSelectedmemberButton.Size = new System.Drawing.Size(146, 44);
            this.deleteSelectedmemberButton.TabIndex = 23;
            this.deleteSelectedmemberButton.Text = "Delete";
            this.deleteSelectedmemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.createTeamButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.createTeamButton.Location = new System.Drawing.Point(568, 763);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(472, 44);
            this.createTeamButton.TabIndex = 24;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 832);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deleteSelectedmemberButton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.addMemberGroupBox);
            this.Controls.Add(this.addTeamMemberButton);
            this.Controls.Add(this.selectTeamMemberDropDown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameTextBox);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.createTeamLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.addMemberGroupBox.ResumeLayout(false);
            this.addMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox teamNameTextBox;
        private Label teamNameLabel;
        private Label createTeamLabel;
        private Button addTeamMemberButton;
        private Label selectTeamMemberLabel;
        private GroupBox addMemberGroupBox;
        private TextBox cellPhoneValue;
        private Label cellPhoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private Button createMemberButton;
        private ListBox teamMembersListBox;
        private Button deleteSelectedmemberButton;
        private Button createTeamButton;
        private ComboBox selectTeamMemberDropDown;
    }
}
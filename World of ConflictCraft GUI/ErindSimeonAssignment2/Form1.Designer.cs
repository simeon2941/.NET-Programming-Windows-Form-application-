
namespace ErindSimeonAssignment2
{
    partial class Form1
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
            this.printGuildRosterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.leaveGuildButton = new System.Windows.Forms.Button();
            this.applySearchButton = new System.Windows.Forms.Button();
            this.searchPlayerName = new System.Windows.Forms.TextBox();
            this.searchGuildByServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.playername = new System.Windows.Forms.TextBox();
            this.comboBoxRace = new System.Windows.Forms.ComboBox();
            this.comboBoxClassType = new System.Windows.Forms.ComboBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addGuildButton = new System.Windows.Forms.Button();
            this.comboBoxGuildType = new System.Windows.Forms.ComboBox();
            this.comboBoxServerNames = new System.Windows.Forms.ComboBox();
            this.guildName = new System.Windows.Forms.TextBox();
            this.playerListBox = new System.Windows.Forms.ListBox();
            this.guildsListBox = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // printGuildRosterButton
            // 
            this.printGuildRosterButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.printGuildRosterButton.Location = new System.Drawing.Point(12, 33);
            this.printGuildRosterButton.Name = "printGuildRosterButton";
            this.printGuildRosterButton.Size = new System.Drawing.Size(130, 23);
            this.printGuildRosterButton.TabIndex = 1;
            this.printGuildRosterButton.TabStop = false;
            this.printGuildRosterButton.Text = "Print Guild Roster";
            this.printGuildRosterButton.UseVisualStyleBackColor = true;
            this.printGuildRosterButton.Click += new System.EventHandler(this.PrintGuildRoster_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(372, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player/Guild Management System";
            // 
            // leaveGuildButton
            // 
            this.leaveGuildButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.leaveGuildButton.Location = new System.Drawing.Point(12, 113);
            this.leaveGuildButton.Name = "leaveGuildButton";
            this.leaveGuildButton.Size = new System.Drawing.Size(130, 23);
            this.leaveGuildButton.TabIndex = 4;
            this.leaveGuildButton.TabStop = false;
            this.leaveGuildButton.Text = "Leave Guild";
            this.leaveGuildButton.UseVisualStyleBackColor = true;
            this.leaveGuildButton.Click += new System.EventHandler(this.leaveGuildButton1);
            // 
            // applySearchButton
            // 
            this.applySearchButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.applySearchButton.Location = new System.Drawing.Point(12, 139);
            this.applySearchButton.Name = "applySearchButton";
            this.applySearchButton.Size = new System.Drawing.Size(130, 23);
            this.applySearchButton.TabIndex = 5;
            this.applySearchButton.TabStop = false;
            this.applySearchButton.Text = "Apply Search Criteria";
            this.applySearchButton.UseVisualStyleBackColor = true;
            this.applySearchButton.Click += new System.EventHandler(this.applySearchButton_);
            // 
            // searchPlayerName
            // 
            this.searchPlayerName.Location = new System.Drawing.Point(181, 72);
            this.searchPlayerName.Name = "searchPlayerName";
            this.searchPlayerName.Size = new System.Drawing.Size(182, 25);
            this.searchPlayerName.TabIndex = 6;
            this.searchPlayerName.TabStop = false;
            // 
            // searchGuildByServer
            // 
            this.searchGuildByServer.Location = new System.Drawing.Point(181, 117);
            this.searchGuildByServer.Name = "searchGuildByServer";
            this.searchGuildByServer.Size = new System.Drawing.Size(182, 25);
            this.searchGuildByServer.TabIndex = 7;
            this.searchGuildByServer.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(181, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search Player (by Name)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(181, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Search Guild (by Server)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.searchGuildByServer);
            this.groupBox1.Controls.Add(this.searchPlayerName);
            this.groupBox1.Controls.Add(this.applySearchButton);
            this.groupBox1.Controls.Add(this.leaveGuildButton);
            this.groupBox1.Controls.Add(this.printGuildRosterButton);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(11, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 185);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Managment Functions";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(12, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 11;
            this.button2.TabStop = false;
            this.button2.Text = "Join Guild";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.joinGuildButton);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(12, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 10;
            this.button1.TabStop = false;
            this.button1.Text = "Disband Guild";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.disbandGuildButton);
            // 
            // playername
            // 
            this.playername.Location = new System.Drawing.Point(22, 44);
            this.playername.Name = "playername";
            this.playername.Size = new System.Drawing.Size(119, 23);
            this.playername.TabIndex = 11;
            this.playername.TabStop = false;
            // 
            // comboBoxRace
            // 
            this.comboBoxRace.FormattingEnabled = true;
            this.comboBoxRace.Location = new System.Drawing.Point(180, 44);
            this.comboBoxRace.Name = "comboBoxRace";
            this.comboBoxRace.Size = new System.Drawing.Size(121, 23);
            this.comboBoxRace.TabIndex = 12;
            this.comboBoxRace.TabStop = false;
            // 
            // comboBoxClassType
            // 
            this.comboBoxClassType.FormattingEnabled = true;
            this.comboBoxClassType.Location = new System.Drawing.Point(22, 92);
            this.comboBoxClassType.Name = "comboBoxClassType";
            this.comboBoxClassType.Size = new System.Drawing.Size(119, 23);
            this.comboBoxClassType.TabIndex = 13;
            this.comboBoxClassType.TabStop = false;
            this.comboBoxClassType.SelectedIndexChanged += new System.EventHandler(this.comboBoxClassTypeSelect);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(180, 92);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(121, 23);
            this.comboBoxRole.TabIndex = 14;
            this.comboBoxRole.TabStop = false;
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addPlayerButton.Location = new System.Drawing.Point(317, 72);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(75, 23);
            this.addPlayerButton.TabIndex = 15;
            this.addPlayerButton.TabStop = false;
            this.addPlayerButton.Text = "Add Player";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.addNewPlayer);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.addPlayerButton);
            this.groupBox2.Controls.Add(this.comboBoxRole);
            this.groupBox2.Controls.Add(this.comboBoxClassType);
            this.groupBox2.Controls.Add(this.comboBoxRace);
            this.groupBox2.Controls.Add(this.playername);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(12, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 148);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create New Player";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Class";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Race";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Player Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.addGuildButton);
            this.groupBox3.Controls.Add(this.comboBoxGuildType);
            this.groupBox3.Controls.Add(this.comboBoxServerNames);
            this.groupBox3.Controls.Add(this.guildName);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(12, 413);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 151);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create New Guild";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(180, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(180, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Server";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Guild Name";
            // 
            // addGuildButton
            // 
            this.addGuildButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addGuildButton.Location = new System.Drawing.Point(317, 81);
            this.addGuildButton.Name = "addGuildButton";
            this.addGuildButton.Size = new System.Drawing.Size(75, 23);
            this.addGuildButton.TabIndex = 20;
            this.addGuildButton.TabStop = false;
            this.addGuildButton.Text = "Add Guild";
            this.addGuildButton.UseVisualStyleBackColor = true;
            this.addGuildButton.Click += new System.EventHandler(this.addNewGuild2);
            // 
            // comboBoxGuildType
            // 
            this.comboBoxGuildType.FormattingEnabled = true;
            this.comboBoxGuildType.Location = new System.Drawing.Point(180, 108);
            this.comboBoxGuildType.Name = "comboBoxGuildType";
            this.comboBoxGuildType.Size = new System.Drawing.Size(121, 23);
            this.comboBoxGuildType.TabIndex = 2;
            this.comboBoxGuildType.TabStop = false;
            // 
            // comboBoxServerNames
            // 
            this.comboBoxServerNames.FormattingEnabled = true;
            this.comboBoxServerNames.Location = new System.Drawing.Point(180, 45);
            this.comboBoxServerNames.Name = "comboBoxServerNames";
            this.comboBoxServerNames.Size = new System.Drawing.Size(121, 23);
            this.comboBoxServerNames.TabIndex = 1;
            this.comboBoxServerNames.TabStop = false;
            // 
            // guildName
            // 
            this.guildName.Location = new System.Drawing.Point(22, 45);
            this.guildName.Name = "guildName";
            this.guildName.Size = new System.Drawing.Size(119, 23);
            this.guildName.TabIndex = 0;
            this.guildName.TabStop = false;
            // 
            // playerListBox
            // 
            this.playerListBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.ItemHeight = 15;
            this.playerListBox.Location = new System.Drawing.Point(473, 73);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(280, 484);
            this.playerListBox.TabIndex = 19;
            this.playerListBox.TabStop = false;
            this.playerListBox.SelectedIndexChanged += new System.EventHandler(this.playerListBox_SelectedIndexChanged);
            // 
            // guildsListBox
            // 
            this.guildsListBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.guildsListBox.FormattingEnabled = true;
            this.guildsListBox.ItemHeight = 15;
            this.guildsListBox.Location = new System.Drawing.Point(771, 71);
            this.guildsListBox.Name = "guildsListBox";
            this.guildsListBox.Size = new System.Drawing.Size(288, 484);
            this.guildsListBox.TabIndex = 20;
            this.guildsListBox.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(473, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 30);
            this.label11.TabIndex = 21;
            this.label11.Text = "Players";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(770, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 30);
            this.label12.TabIndex = 22;
            this.label12.Text = "Guilds";
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(12, 600);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(1047, 148);
            this.outputText.TabIndex = 23;
            this.outputText.TabStop = false;
            this.outputText.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(12, 582);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 15);
            this.label13.TabIndex = 24;
            this.label13.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1081, 780);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.guildsListBox);
            this.Controls.Add(this.playerListBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Output";
            this.Load += new System.EventHandler(this.PrintGuildRoster_Click);
            this.Click += new System.EventHandler(this.deselectPlayersAndGuild);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button printGuildRosterButton;

    
        private System.Windows.Forms.Button leaveGuildButton;
        private System.Windows.Forms.Button applySearchButton;
        private System.Windows.Forms.TextBox searchPlayerName;
        private System.Windows.Forms.TextBox searchGuildByServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox playername;
        private System.Windows.Forms.ComboBox comboBoxRace;
        private System.Windows.Forms.ComboBox comboBoxClassType;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox guildName;
        private System.Windows.Forms.Button addGuildButton;
        private System.Windows.Forms.ComboBox comboBoxGuildType;
        private System.Windows.Forms.ComboBox comboBoxServerNames;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox playerListBox;
        private System.Windows.Forms.ListBox guildsListBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox outputText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


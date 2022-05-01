namespace RPGProject
{
    partial class GameGUI
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
            this.battleLog = new System.Windows.Forms.TextBox();
            this.battkeLogLbl = new System.Windows.Forms.Label();
            this.actionsGB = new System.Windows.Forms.GroupBox();
            this.specialBtn = new System.Windows.Forms.Button();
            this.defendBtn = new System.Windows.Forms.Button();
            this.attackBtn = new System.Windows.Forms.Button();
            this.heroNameLbl1 = new System.Windows.Forms.Label();
            this.heroNameLbl2 = new System.Windows.Forms.Label();
            this.heroNameLbl3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.heroSkillPointLbl3 = new System.Windows.Forms.Label();
            this.heroSkillPointLbl2 = new System.Windows.Forms.Label();
            this.heroSkillPointLbl1 = new System.Windows.Forms.Label();
            this.heroHitPointLbl3 = new System.Windows.Forms.Label();
            this.heroHitPointLbl2 = new System.Windows.Forms.Label();
            this.heroHitPointLbl1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heroPb1 = new System.Windows.Forms.PictureBox();
            this.heroPb3 = new System.Windows.Forms.PictureBox();
            this.heroPb2 = new System.Windows.Forms.PictureBox();
            this.gameBackgroundPnl = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.enemyPb1 = new System.Windows.Forms.PictureBox();
            this.actionsGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heroPb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroPb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroPb2)).BeginInit();
            this.gameBackgroundPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPb1)).BeginInit();
            this.SuspendLayout();
            // 
            // battleLog
            // 
            this.battleLog.Enabled = false;
            this.battleLog.Location = new System.Drawing.Point(548, 370);
            this.battleLog.Multiline = true;
            this.battleLog.Name = "battleLog";
            this.battleLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.battleLog.Size = new System.Drawing.Size(349, 158);
            this.battleLog.TabIndex = 1;
            // 
            // battkeLogLbl
            // 
            this.battkeLogLbl.AutoSize = true;
            this.battkeLogLbl.Location = new System.Drawing.Point(548, 346);
            this.battkeLogLbl.Name = "battkeLogLbl";
            this.battkeLogLbl.Size = new System.Drawing.Size(80, 20);
            this.battkeLogLbl.TabIndex = 2;
            this.battkeLogLbl.Text = "Battle Log:";
            // 
            // actionsGB
            // 
            this.actionsGB.Controls.Add(this.specialBtn);
            this.actionsGB.Controls.Add(this.defendBtn);
            this.actionsGB.Controls.Add(this.attackBtn);
            this.actionsGB.Location = new System.Drawing.Point(12, 346);
            this.actionsGB.Name = "actionsGB";
            this.actionsGB.Size = new System.Drawing.Size(170, 191);
            this.actionsGB.TabIndex = 3;
            this.actionsGB.TabStop = false;
            this.actionsGB.Text = "Actions:";
            // 
            // specialBtn
            // 
            this.specialBtn.Location = new System.Drawing.Point(6, 147);
            this.specialBtn.Name = "specialBtn";
            this.specialBtn.Size = new System.Drawing.Size(158, 29);
            this.specialBtn.TabIndex = 2;
            this.specialBtn.Text = "Special";
            this.specialBtn.UseVisualStyleBackColor = true;
            // 
            // defendBtn
            // 
            this.defendBtn.Location = new System.Drawing.Point(6, 82);
            this.defendBtn.Name = "defendBtn";
            this.defendBtn.Size = new System.Drawing.Size(158, 29);
            this.defendBtn.TabIndex = 1;
            this.defendBtn.Text = "Defend";
            this.defendBtn.UseVisualStyleBackColor = true;
            // 
            // attackBtn
            // 
            this.attackBtn.Location = new System.Drawing.Point(3, 23);
            this.attackBtn.Name = "attackBtn";
            this.attackBtn.Size = new System.Drawing.Size(161, 29);
            this.attackBtn.TabIndex = 0;
            this.attackBtn.Text = "Attack";
            this.attackBtn.UseVisualStyleBackColor = true;
            // 
            // heroNameLbl1
            // 
            this.heroNameLbl1.AutoSize = true;
            this.heroNameLbl1.Location = new System.Drawing.Point(6, 23);
            this.heroNameLbl1.Name = "heroNameLbl1";
            this.heroNameLbl1.Size = new System.Drawing.Size(58, 20);
            this.heroNameLbl1.TabIndex = 4;
            this.heroNameLbl1.Text = "Warrior";
            // 
            // heroNameLbl2
            // 
            this.heroNameLbl2.AutoSize = true;
            this.heroNameLbl2.Location = new System.Drawing.Point(6, 82);
            this.heroNameLbl2.Name = "heroNameLbl2";
            this.heroNameLbl2.Size = new System.Drawing.Size(47, 20);
            this.heroNameLbl2.TabIndex = 5;
            this.heroNameLbl2.Text = "Mage";
            // 
            // heroNameLbl3
            // 
            this.heroNameLbl3.AutoSize = true;
            this.heroNameLbl3.Location = new System.Drawing.Point(6, 147);
            this.heroNameLbl3.Name = "heroNameLbl3";
            this.heroNameLbl3.Size = new System.Drawing.Size(46, 20);
            this.heroNameLbl3.TabIndex = 6;
            this.heroNameLbl3.Text = "Cleric";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.heroSkillPointLbl3);
            this.groupBox1.Controls.Add(this.heroSkillPointLbl2);
            this.groupBox1.Controls.Add(this.heroSkillPointLbl1);
            this.groupBox1.Controls.Add(this.heroHitPointLbl3);
            this.groupBox1.Controls.Add(this.heroHitPointLbl2);
            this.groupBox1.Controls.Add(this.heroHitPointLbl1);
            this.groupBox1.Controls.Add(this.heroNameLbl1);
            this.groupBox1.Controls.Add(this.heroNameLbl3);
            this.groupBox1.Controls.Add(this.heroNameLbl2);
            this.groupBox1.Location = new System.Drawing.Point(206, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 191);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // heroSkillPointLbl3
            // 
            this.heroSkillPointLbl3.AutoSize = true;
            this.heroSkillPointLbl3.Location = new System.Drawing.Point(94, 167);
            this.heroSkillPointLbl3.Name = "heroSkillPointLbl3";
            this.heroSkillPointLbl3.Size = new System.Drawing.Size(137, 20);
            this.heroSkillPointLbl3.TabIndex = 13;
            this.heroSkillPointLbl3.Text = "Skill Points 100/100";
            // 
            // heroSkillPointLbl2
            // 
            this.heroSkillPointLbl2.AutoSize = true;
            this.heroSkillPointLbl2.Location = new System.Drawing.Point(94, 102);
            this.heroSkillPointLbl2.Name = "heroSkillPointLbl2";
            this.heroSkillPointLbl2.Size = new System.Drawing.Size(137, 20);
            this.heroSkillPointLbl2.TabIndex = 12;
            this.heroSkillPointLbl2.Text = "Skill Points 100/100";
            // 
            // heroSkillPointLbl1
            // 
            this.heroSkillPointLbl1.AutoSize = true;
            this.heroSkillPointLbl1.Location = new System.Drawing.Point(94, 43);
            this.heroSkillPointLbl1.Name = "heroSkillPointLbl1";
            this.heroSkillPointLbl1.Size = new System.Drawing.Size(137, 20);
            this.heroSkillPointLbl1.TabIndex = 11;
            this.heroSkillPointLbl1.Text = "Skill Points 100/100";
            // 
            // heroHitPointLbl3
            // 
            this.heroHitPointLbl3.AutoSize = true;
            this.heroHitPointLbl3.Location = new System.Drawing.Point(94, 147);
            this.heroHitPointLbl3.Name = "heroHitPointLbl3";
            this.heroHitPointLbl3.Size = new System.Drawing.Size(126, 20);
            this.heroHitPointLbl3.TabIndex = 10;
            this.heroHitPointLbl3.Text = "HitPoints 100/100";
            // 
            // heroHitPointLbl2
            // 
            this.heroHitPointLbl2.AutoSize = true;
            this.heroHitPointLbl2.Location = new System.Drawing.Point(94, 82);
            this.heroHitPointLbl2.Name = "heroHitPointLbl2";
            this.heroHitPointLbl2.Size = new System.Drawing.Size(126, 20);
            this.heroHitPointLbl2.TabIndex = 9;
            this.heroHitPointLbl2.Text = "HitPoints 100/100";
            // 
            // heroHitPointLbl1
            // 
            this.heroHitPointLbl1.AutoSize = true;
            this.heroHitPointLbl1.Location = new System.Drawing.Point(94, 23);
            this.heroHitPointLbl1.Name = "heroHitPointLbl1";
            this.heroHitPointLbl1.Size = new System.Drawing.Size(130, 20);
            this.heroHitPointLbl1.TabIndex = 8;
            this.heroHitPointLbl1.Text = "Hit Points 100/100";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highScoresToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // highScoresToolStripMenuItem
            // 
            this.highScoresToolStripMenuItem.Name = "highScoresToolStripMenuItem";
            this.highScoresToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.highScoresToolStripMenuItem.Text = "High Scores";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // heroPb1
            // 
            this.heroPb1.BackColor = System.Drawing.Color.Transparent;
            this.heroPb1.Location = new System.Drawing.Point(18, 39);
            this.heroPb1.Name = "heroPb1";
            this.heroPb1.Size = new System.Drawing.Size(64, 64);
            this.heroPb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.heroPb1.TabIndex = 9;
            this.heroPb1.TabStop = false;
            this.heroPb1.Tag = "1";
            // 
            // heroPb3
            // 
            this.heroPb3.BackColor = System.Drawing.Color.Transparent;
            this.heroPb3.Location = new System.Drawing.Point(18, 205);
            this.heroPb3.Name = "heroPb3";
            this.heroPb3.Size = new System.Drawing.Size(64, 64);
            this.heroPb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.heroPb3.TabIndex = 10;
            this.heroPb3.TabStop = false;
            this.heroPb3.Tag = "3";
            // 
            // heroPb2
            // 
            this.heroPb2.BackColor = System.Drawing.Color.Transparent;
            this.heroPb2.Location = new System.Drawing.Point(115, 127);
            this.heroPb2.Name = "heroPb2";
            this.heroPb2.Size = new System.Drawing.Size(64, 64);
            this.heroPb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.heroPb2.TabIndex = 11;
            this.heroPb2.TabStop = false;
            this.heroPb2.Tag = "2";
            // 
            // gameBackgroundPnl
            // 
            this.gameBackgroundPnl.BackgroundImage = global::RPGProject.Properties.Resources.E84YaDkWEAA2r9I;
            this.gameBackgroundPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameBackgroundPnl.Controls.Add(this.pictureBox2);
            this.gameBackgroundPnl.Controls.Add(this.pictureBox1);
            this.gameBackgroundPnl.Controls.Add(this.enemyPb1);
            this.gameBackgroundPnl.Controls.Add(this.heroPb2);
            this.gameBackgroundPnl.Controls.Add(this.heroPb3);
            this.gameBackgroundPnl.Controls.Add(this.heroPb1);
            this.gameBackgroundPnl.Location = new System.Drawing.Point(12, 31);
            this.gameBackgroundPnl.Name = "gameBackgroundPnl";
            this.gameBackgroundPnl.Size = new System.Drawing.Size(885, 309);
            this.gameBackgroundPnl.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(744, 205);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(663, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "2";
            // 
            // enemyPb1
            // 
            this.enemyPb1.BackColor = System.Drawing.Color.Transparent;
            this.enemyPb1.Location = new System.Drawing.Point(744, 53);
            this.enemyPb1.Name = "enemyPb1";
            this.enemyPb1.Size = new System.Drawing.Size(64, 64);
            this.enemyPb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemyPb1.TabIndex = 12;
            this.enemyPb1.TabStop = false;
            this.enemyPb1.Tag = "1";
            // 
            // GameGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 542);
            this.Controls.Add(this.gameBackgroundPnl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.actionsGB);
            this.Controls.Add(this.battkeLogLbl);
            this.Controls.Add(this.battleLog);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameGUI";
            this.Text = "Insane Juiced Up RPG Dungeon";
            this.actionsGB.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heroPb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroPb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroPb2)).EndInit();
            this.gameBackgroundPnl.ResumeLayout(false);
            this.gameBackgroundPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox battleLog;
        private Label battkeLogLbl;
        private GroupBox actionsGB;
        private Button specialBtn;
        private Button defendBtn;
        private Button attackBtn;
        private Label heroNameLbl1;
        private Label heroNameLbl2;
        private Label heroNameLbl3;
        private GroupBox groupBox1;
        private Label heroSkillPointLbl1;
        private Label heroHitPointLbl3;
        private Label heroHitPointLbl2;
        private Label heroHitPointLbl1;
        private Label heroSkillPointLbl3;
        private Label heroSkillPointLbl2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem highScoresToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem instructionsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private PictureBox heroPb1;
        private PictureBox heroPb3;
        private PictureBox heroPb2;
        private Panel gameBackgroundPnl;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox enemyPb1;
    }
}
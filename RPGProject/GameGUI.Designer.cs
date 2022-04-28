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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.battleLog = new System.Windows.Forms.TextBox();
            this.battkeLogLbl = new System.Windows.Forms.Label();
            this.actionsGB = new System.Windows.Forms.GroupBox();
            this.specialBtn = new System.Windows.Forms.Button();
            this.defendBtn = new System.Windows.Forms.Button();
            this.attackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.actionsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RPGProject.Properties.Resources.Ogre;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(838, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // battleLog
            // 
            this.battleLog.Enabled = false;
            this.battleLog.Location = new System.Drawing.Point(462, 335);
            this.battleLog.Multiline = true;
            this.battleLog.Name = "battleLog";
            this.battleLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.battleLog.Size = new System.Drawing.Size(388, 149);
            this.battleLog.TabIndex = 1;
            // 
            // battkeLogLbl
            // 
            this.battkeLogLbl.AutoSize = true;
            this.battkeLogLbl.Location = new System.Drawing.Point(462, 312);
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
            this.actionsGB.Location = new System.Drawing.Point(12, 302);
            this.actionsGB.Name = "actionsGB";
            this.actionsGB.Size = new System.Drawing.Size(170, 182);
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
            // GameGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 496);
            this.Controls.Add(this.actionsGB);
            this.Controls.Add(this.battkeLogLbl);
            this.Controls.Add(this.battleLog);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GameGUI";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.actionsGB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox battleLog;
        private Label battkeLogLbl;
        private GroupBox actionsGB;
        private Button specialBtn;
        private Button defendBtn;
        private Button attackBtn;
    }
}
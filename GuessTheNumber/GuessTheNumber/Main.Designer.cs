namespace GuessTheNumber
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblName = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblRules = new System.Windows.Forms.Label();
            this.lblRulesList = new System.Windows.Forms.Label();
            this.txtPick = new System.Windows.Forms.TextBox();
            this.lblRemember = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(249, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(289, 36);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Guess The Number";
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(595, 386);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(148, 41);
            this.btnStartGame.TabIndex = 2;
            this.btnStartGame.Text = "Start";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.Location = new System.Drawing.Point(12, 58);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(73, 26);
            this.lblRules.TabIndex = 3;
            this.lblRules.Text = "Rules";
            // 
            // lblRulesList
            // 
            this.lblRulesList.AutoSize = true;
            this.lblRulesList.BackColor = System.Drawing.SystemColors.Control;
            this.lblRulesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRulesList.Location = new System.Drawing.Point(13, 98);
            this.lblRulesList.Name = "lblRulesList";
            this.lblRulesList.Size = new System.Drawing.Size(749, 220);
            this.lblRulesList.TabIndex = 4;
            this.lblRulesList.Text = resources.GetString("lblRulesList.Text");
            // 
            // txtPick
            // 
            this.txtPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPick.Location = new System.Drawing.Point(343, 391);
            this.txtPick.Name = "txtPick";
            this.txtPick.Size = new System.Drawing.Size(142, 32);
            this.txtPick.TabIndex = 5;
            this.txtPick.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckValidation2);
            // 
            // lblRemember
            // 
            this.lblRemember.AutoSize = true;
            this.lblRemember.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemember.Location = new System.Drawing.Point(77, 391);
            this.lblRemember.Name = "lblRemember";
            this.lblRemember.Size = new System.Drawing.Size(249, 26);
            this.lblRemember.TabIndex = 6;
            this.lblRemember.Text = "Choose Your Number!";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(780, 453);
            this.Controls.Add(this.lblRemember);
            this.Controls.Add(this.txtPick);
            this.Controls.Add(this.lblRulesList);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lblName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess The Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Label lblRulesList;
        private System.Windows.Forms.TextBox txtPick;
        private System.Windows.Forms.Label lblRemember;
    }
}


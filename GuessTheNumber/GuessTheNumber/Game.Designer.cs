namespace GuessTheNumber
{
    partial class frmGame
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
            this.lblTurn = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.nmrCorrectDigit = new System.Windows.Forms.NumericUpDown();
            this.nmrCorrectNumber = new System.Windows.Forms.NumericUpDown();
            this.btnClue = new System.Windows.Forms.Button();
            this.lblcdigit = new System.Windows.Forms.Label();
            this.lblWDigit = new System.Windows.Forms.Label();
            this.lblComGuess = new System.Windows.Forms.Label();
            this.lblPlayerPick = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCorrectDigit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCorrectNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.Location = new System.Drawing.Point(36, 33);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(59, 26);
            this.lblTurn.TabIndex = 0;
            this.lblTurn.Text = "Turn";
            // 
            // txtGuess
            // 
            this.txtGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuess.Location = new System.Drawing.Point(41, 98);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(108, 32);
            this.txtGuess.TabIndex = 1;
            this.txtGuess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckValidation2);
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.Location = new System.Drawing.Point(41, 162);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(140, 44);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(36, 266);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 26);
            this.lblResult.TabIndex = 3;
            // 
            // nmrCorrectDigit
            // 
            this.nmrCorrectDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrCorrectDigit.Location = new System.Drawing.Point(652, 135);
            this.nmrCorrectDigit.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nmrCorrectDigit.Name = "nmrCorrectDigit";
            this.nmrCorrectDigit.Size = new System.Drawing.Size(120, 32);
            this.nmrCorrectDigit.TabIndex = 8;
            // 
            // nmrCorrectNumber
            // 
            this.nmrCorrectNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrCorrectNumber.Location = new System.Drawing.Point(652, 180);
            this.nmrCorrectNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nmrCorrectNumber.Name = "nmrCorrectNumber";
            this.nmrCorrectNumber.Size = new System.Drawing.Size(120, 32);
            this.nmrCorrectNumber.TabIndex = 9;
            // 
            // btnClue
            // 
            this.btnClue.BackColor = System.Drawing.SystemColors.Control;
            this.btnClue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClue.Location = new System.Drawing.Point(470, 248);
            this.btnClue.Name = "btnClue";
            this.btnClue.Size = new System.Drawing.Size(154, 44);
            this.btnClue.TabIndex = 10;
            this.btnClue.Text = "Give Hint";
            this.btnClue.UseVisualStyleBackColor = false;
            this.btnClue.Click += new System.EventHandler(this.btnClue_Click);
            // 
            // lblcdigit
            // 
            this.lblcdigit.AutoSize = true;
            this.lblcdigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcdigit.Location = new System.Drawing.Point(366, 141);
            this.lblcdigit.Name = "lblcdigit";
            this.lblcdigit.Size = new System.Drawing.Size(273, 20);
            this.lblcdigit.TabIndex = 11;
            this.lblcdigit.Text = "Correct Numbers At Correct Digit";
            // 
            // lblWDigit
            // 
            this.lblWDigit.AutoSize = true;
            this.lblWDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWDigit.Location = new System.Drawing.Point(373, 186);
            this.lblWDigit.Name = "lblWDigit";
            this.lblWDigit.Size = new System.Drawing.Size(266, 20);
            this.lblWDigit.TabIndex = 12;
            this.lblWDigit.Text = "Correct Numbers At Wrong Digit";
            // 
            // lblComGuess
            // 
            this.lblComGuess.AutoSize = true;
            this.lblComGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComGuess.Location = new System.Drawing.Point(434, 85);
            this.lblComGuess.Name = "lblComGuess";
            this.lblComGuess.Size = new System.Drawing.Size(205, 26);
            this.lblComGuess.TabIndex = 13;
            this.lblComGuess.Text = "Computer Guess: ";
            // 
            // lblPlayerPick
            // 
            this.lblPlayerPick.AutoSize = true;
            this.lblPlayerPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerPick.Location = new System.Drawing.Point(502, 33);
            this.lblPlayerPick.Name = "lblPlayerPick";
            this.lblPlayerPick.Size = new System.Drawing.Size(137, 26);
            this.lblPlayerPick.TabIndex = 14;
            this.lblPlayerPick.Text = "Your Pick : ";
            // 
            // frmGame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 453);
            this.Controls.Add(this.lblPlayerPick);
            this.Controls.Add(this.lblComGuess);
            this.Controls.Add(this.lblWDigit);
            this.Controls.Add(this.lblcdigit);
            this.Controls.Add(this.btnClue);
            this.Controls.Add(this.nmrCorrectNumber);
            this.Controls.Add(this.nmrCorrectDigit);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblTurn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess The Number";
            ((System.ComponentModel.ISupportInitialize)(this.nmrCorrectDigit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCorrectNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.NumericUpDown nmrCorrectDigit;
        private System.Windows.Forms.NumericUpDown nmrCorrectNumber;
        private System.Windows.Forms.Button btnClue;
        private System.Windows.Forms.Label lblcdigit;
        private System.Windows.Forms.Label lblWDigit;
        private System.Windows.Forms.Label lblComGuess;
        private System.Windows.Forms.Label lblPlayerPick;
    }
}
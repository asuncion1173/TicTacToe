
namespace TicTacToe
{
    partial class Form1
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
            this.btnTopLeft = new System.Windows.Forms.Button();
            this.btnTopMid = new System.Windows.Forms.Button();
            this.btnTopRight = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMidRight = new System.Windows.Forms.Button();
            this.btnMidMid = new System.Windows.Forms.Button();
            this.btnMidLeft = new System.Windows.Forms.Button();
            this.btnBotRight = new System.Windows.Forms.Button();
            this.btnBotMid = new System.Windows.Forms.Button();
            this.btnBotLeft = new System.Windows.Forms.Button();
            this.playerScore1 = new System.Windows.Forms.Label();
            this.playerScore2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTopLeft
            // 
            this.btnTopLeft.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnTopLeft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTopLeft.Location = new System.Drawing.Point(60, 87);
            this.btnTopLeft.Name = "btnTopLeft";
            this.btnTopLeft.Size = new System.Drawing.Size(83, 78);
            this.btnTopLeft.TabIndex = 0;
            this.btnTopLeft.TabStop = false;
            this.btnTopLeft.UseVisualStyleBackColor = false;
            this.btnTopLeft.Click += new System.EventHandler(this.btnClick);
            // 
            // btnTopMid
            // 
            this.btnTopMid.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTopMid.Location = new System.Drawing.Point(161, 87);
            this.btnTopMid.Name = "btnTopMid";
            this.btnTopMid.Size = new System.Drawing.Size(83, 78);
            this.btnTopMid.TabIndex = 1;
            this.btnTopMid.TabStop = false;
            this.btnTopMid.UseVisualStyleBackColor = false;
            this.btnTopMid.Click += new System.EventHandler(this.btnClick);
            // 
            // btnTopRight
            // 
            this.btnTopRight.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTopRight.Location = new System.Drawing.Point(261, 87);
            this.btnTopRight.Name = "btnTopRight";
            this.btnTopRight.Size = new System.Drawing.Size(83, 78);
            this.btnTopRight.TabIndex = 3;
            this.btnTopRight.TabStop = false;
            this.btnTopRight.UseVisualStyleBackColor = false;
            this.btnTopRight.Click += new System.EventHandler(this.btnClick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(425, 271);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 76);
            this.btnReset.TabIndex = 2;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnMidRight
            // 
            this.btnMidRight.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMidRight.Location = new System.Drawing.Point(261, 178);
            this.btnMidRight.Name = "btnMidRight";
            this.btnMidRight.Size = new System.Drawing.Size(83, 78);
            this.btnMidRight.TabIndex = 6;
            this.btnMidRight.TabStop = false;
            this.btnMidRight.UseVisualStyleBackColor = false;
            this.btnMidRight.Click += new System.EventHandler(this.btnClick);
            // 
            // btnMidMid
            // 
            this.btnMidMid.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMidMid.Location = new System.Drawing.Point(161, 178);
            this.btnMidMid.Name = "btnMidMid";
            this.btnMidMid.Size = new System.Drawing.Size(83, 78);
            this.btnMidMid.TabIndex = 5;
            this.btnMidMid.TabStop = false;
            this.btnMidMid.UseVisualStyleBackColor = false;
            this.btnMidMid.Click += new System.EventHandler(this.btnClick);
            // 
            // btnMidLeft
            // 
            this.btnMidLeft.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMidLeft.Location = new System.Drawing.Point(60, 178);
            this.btnMidLeft.Name = "btnMidLeft";
            this.btnMidLeft.Size = new System.Drawing.Size(83, 78);
            this.btnMidLeft.TabIndex = 4;
            this.btnMidLeft.TabStop = false;
            this.btnMidLeft.UseVisualStyleBackColor = false;
            this.btnMidLeft.Click += new System.EventHandler(this.btnClick);
            // 
            // btnBotRight
            // 
            this.btnBotRight.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBotRight.Location = new System.Drawing.Point(261, 271);
            this.btnBotRight.Name = "btnBotRight";
            this.btnBotRight.Size = new System.Drawing.Size(83, 78);
            this.btnBotRight.TabIndex = 9;
            this.btnBotRight.TabStop = false;
            this.btnBotRight.UseVisualStyleBackColor = false;
            this.btnBotRight.Click += new System.EventHandler(this.btnClick);
            // 
            // btnBotMid
            // 
            this.btnBotMid.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBotMid.Location = new System.Drawing.Point(161, 271);
            this.btnBotMid.Name = "btnBotMid";
            this.btnBotMid.Size = new System.Drawing.Size(83, 78);
            this.btnBotMid.TabIndex = 8;
            this.btnBotMid.TabStop = false;
            this.btnBotMid.UseVisualStyleBackColor = false;
            this.btnBotMid.Click += new System.EventHandler(this.btnClick);
            // 
            // btnBotLeft
            // 
            this.btnBotLeft.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBotLeft.Location = new System.Drawing.Point(60, 271);
            this.btnBotLeft.Name = "btnBotLeft";
            this.btnBotLeft.Size = new System.Drawing.Size(83, 78);
            this.btnBotLeft.TabIndex = 7;
            this.btnBotLeft.TabStop = false;
            this.btnBotLeft.UseVisualStyleBackColor = false;
            this.btnBotLeft.Click += new System.EventHandler(this.btnClick);
            // 
            // playerScore1
            // 
            this.playerScore1.AutoSize = true;
            this.playerScore1.Location = new System.Drawing.Point(60, 30);
            this.playerScore1.Name = "playerScore1";
            this.playerScore1.Size = new System.Drawing.Size(13, 13);
            this.playerScore1.TabIndex = 10;
            this.playerScore1.Text = "0";
            // 
            // playerScore2
            // 
            this.playerScore2.AutoSize = true;
            this.playerScore2.Location = new System.Drawing.Point(474, 30);
            this.playerScore2.Name = "playerScore2";
            this.playerScore2.Size = new System.Drawing.Size(13, 13);
            this.playerScore2.TabIndex = 11;
            this.playerScore2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 402);
            this.Controls.Add(this.playerScore2);
            this.Controls.Add(this.playerScore1);
            this.Controls.Add(this.btnBotRight);
            this.Controls.Add(this.btnBotMid);
            this.Controls.Add(this.btnBotLeft);
            this.Controls.Add(this.btnMidRight);
            this.Controls.Add(this.btnMidMid);
            this.Controls.Add(this.btnMidLeft);
            this.Controls.Add(this.btnTopRight);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTopMid);
            this.Controls.Add(this.btnTopLeft);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTopLeft;
        private System.Windows.Forms.Button btnTopMid;
        private System.Windows.Forms.Button btnTopRight;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnMidRight;
        private System.Windows.Forms.Button btnMidMid;
        private System.Windows.Forms.Button btnMidLeft;
        private System.Windows.Forms.Button btnBotRight;
        private System.Windows.Forms.Button btnBotMid;
        private System.Windows.Forms.Button btnBotLeft;
        private System.Windows.Forms.Label playerScore1;
        private System.Windows.Forms.Label playerScore2;
    }
}


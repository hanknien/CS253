namespace Homework1
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
            this.label1 = new System.Windows.Forms.Label();
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.player1TextBox = new System.Windows.Forms.TextBox();
            this.player2TextBox = new System.Windows.Forms.TextBox();
            this.judgeWhoWinButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入兩位玩家要出的招!1:剪刀 2:石頭 3:布";
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.player1Label.Location = new System.Drawing.Point(23, 54);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(132, 20);
            this.player1Label.TabIndex = 1;
            this.player1Label.Text = "Player1出的拳是:";
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.player2Label.Location = new System.Drawing.Point(23, 95);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(132, 20);
            this.player2Label.TabIndex = 2;
            this.player2Label.Text = "Player2出的拳是:";
            // 
            // player1TextBox
            // 
            this.player1TextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.player1TextBox.Location = new System.Drawing.Point(161, 54);
            this.player1TextBox.Name = "player1TextBox";
            this.player1TextBox.Size = new System.Drawing.Size(65, 29);
            this.player1TextBox.TabIndex = 3;
            // 
            // player2TextBox
            // 
            this.player2TextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.player2TextBox.Location = new System.Drawing.Point(161, 93);
            this.player2TextBox.Name = "player2TextBox";
            this.player2TextBox.Size = new System.Drawing.Size(65, 29);
            this.player2TextBox.TabIndex = 4;
            // 
            // judgeWhoWinButton
            // 
            this.judgeWhoWinButton.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.judgeWhoWinButton.Location = new System.Drawing.Point(241, 56);
            this.judgeWhoWinButton.Name = "judgeWhoWinButton";
            this.judgeWhoWinButton.Size = new System.Drawing.Size(94, 65);
            this.judgeWhoWinButton.TabIndex = 5;
            this.judgeWhoWinButton.Text = "決勝負";
            this.judgeWhoWinButton.UseVisualStyleBackColor = true;
            this.judgeWhoWinButton.Click += new System.EventHandler(this.judgeWhoWinButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 170);
            this.Controls.Add(this.judgeWhoWinButton);
            this.Controls.Add(this.player2TextBox);
            this.Controls.Add(this.player1TextBox);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "猜拳遊戲";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.TextBox player1TextBox;
        private System.Windows.Forms.TextBox player2TextBox;
        private System.Windows.Forms.Button judgeWhoWinButton;
    }
}


namespace _20150612_homework2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.amountInput = new System.Windows.Forms.TextBox();
            this.yearInput = new System.Windows.Forms.TextBox();
            this.rateInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yearPayment = new System.Windows.Forms.TextBox();
            this.CalculatePayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "請輸入借款金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "請輸入借款年數";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "請輸入借款利率(%)";
            // 
            // amountInput
            // 
            this.amountInput.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.amountInput.Location = new System.Drawing.Point(194, 8);
            this.amountInput.Name = "amountInput";
            this.amountInput.Size = new System.Drawing.Size(85, 33);
            this.amountInput.TabIndex = 3;
            // 
            // yearInput
            // 
            this.yearInput.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yearInput.Location = new System.Drawing.Point(194, 51);
            this.yearInput.Name = "yearInput";
            this.yearInput.Size = new System.Drawing.Size(84, 33);
            this.yearInput.TabIndex = 4;
            // 
            // rateInput
            // 
            this.rateInput.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rateInput.Location = new System.Drawing.Point(193, 94);
            this.rateInput.Name = "rateInput";
            this.rateInput.Size = new System.Drawing.Size(84, 33);
            this.rateInput.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(18, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "每年應攤還金額";
            // 
            // yearPayment
            // 
            this.yearPayment.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yearPayment.Location = new System.Drawing.Point(196, 144);
            this.yearPayment.Name = "yearPayment";
            this.yearPayment.Size = new System.Drawing.Size(82, 33);
            this.yearPayment.TabIndex = 7;
            // 
            // CalculatePayment
            // 
            this.CalculatePayment.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CalculatePayment.Location = new System.Drawing.Point(23, 200);
            this.CalculatePayment.Name = "CalculatePayment";
            this.CalculatePayment.Size = new System.Drawing.Size(253, 45);
            this.CalculatePayment.TabIndex = 8;
            this.CalculatePayment.Text = "計算";
            this.CalculatePayment.UseVisualStyleBackColor = true;
            this.CalculatePayment.Click += new System.EventHandler(this.CalculatePayment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CalculatePayment);
            this.Controls.Add(this.yearPayment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rateInput);
            this.Controls.Add(this.yearInput);
            this.Controls.Add(this.amountInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amountInput;
        private System.Windows.Forms.TextBox yearInput;
        private System.Windows.Forms.TextBox rateInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yearPayment;
        private System.Windows.Forms.Button CalculatePayment;
    }
}


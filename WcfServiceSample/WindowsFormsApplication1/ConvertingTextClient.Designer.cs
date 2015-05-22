namespace WindowsFormsApplication1
{
    partial class ConvertingTextClient
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
            this.btnToUpper = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxForResult = new System.Windows.Forms.RichTextBox();
            this.textBoxForUser = new System.Windows.Forms.TextBox();
            this.btnToLower = new System.Windows.Forms.Button();
            this.btnToReverse = new System.Windows.Forms.Button();
            this.btnToSplit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToUpper
            // 
            this.btnToUpper.Location = new System.Drawing.Point(28, 101);
            this.btnToUpper.Name = "btnToUpper";
            this.btnToUpper.Size = new System.Drawing.Size(75, 23);
            this.btnToUpper.TabIndex = 0;
            this.btnToUpper.Text = "To Upper";
            this.btnToUpper.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Button";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(148, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Result:";
            // 
            // richTextBoxForResult
            // 
            this.richTextBoxForResult.Location = new System.Drawing.Point(151, 103);
            this.richTextBoxForResult.Name = "richTextBoxForResult";
            this.richTextBoxForResult.ReadOnly = true;
            this.richTextBoxForResult.Size = new System.Drawing.Size(178, 108);
            this.richTextBoxForResult.TabIndex = 9;
            this.richTextBoxForResult.Text = "";
            // 
            // textBoxForUser
            // 
            this.textBoxForUser.Location = new System.Drawing.Point(27, 43);
            this.textBoxForUser.Name = "textBoxForUser";
            this.textBoxForUser.Size = new System.Drawing.Size(302, 20);
            this.textBoxForUser.TabIndex = 10;
            // 
            // btnToLower
            // 
            this.btnToLower.Location = new System.Drawing.Point(28, 130);
            this.btnToLower.Name = "btnToLower";
            this.btnToLower.Size = new System.Drawing.Size(75, 23);
            this.btnToLower.TabIndex = 11;
            this.btnToLower.Text = "To Lower";
            this.btnToLower.UseVisualStyleBackColor = true;
            // 
            // btnToReverse
            // 
            this.btnToReverse.Location = new System.Drawing.Point(28, 159);
            this.btnToReverse.Name = "btnToReverse";
            this.btnToReverse.Size = new System.Drawing.Size(75, 23);
            this.btnToReverse.TabIndex = 12;
            this.btnToReverse.Text = "To Reverse";
            this.btnToReverse.UseVisualStyleBackColor = true;
            // 
            // btnToSplit
            // 
            this.btnToSplit.Location = new System.Drawing.Point(28, 188);
            this.btnToSplit.Name = "btnToSplit";
            this.btnToSplit.Size = new System.Drawing.Size(75, 23);
            this.btnToSplit.TabIndex = 13;
            this.btnToSplit.Text = "To Split";
            this.btnToSplit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(151, 227);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(254, 227);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // ConvertingTextClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(365, 262);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnToSplit);
            this.Controls.Add(this.btnToReverse);
            this.Controls.Add(this.btnToLower);
            this.Controls.Add(this.textBoxForUser);
            this.Controls.Add(this.richTextBoxForResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnToUpper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConvertingTextClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConvertingTextClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToUpper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxForResult;
        private System.Windows.Forms.TextBox textBoxForUser;
        private System.Windows.Forms.Button btnToLower;
        private System.Windows.Forms.Button btnToReverse;
        private System.Windows.Forms.Button btnToSplit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}
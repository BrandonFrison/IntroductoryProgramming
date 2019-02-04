namespace Pass_By
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
            this.passByValueButton = new System.Windows.Forms.Button();
            this.passByRefButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passByValueButton
            // 
            this.passByValueButton.Location = new System.Drawing.Point(97, 44);
            this.passByValueButton.Name = "passByValueButton";
            this.passByValueButton.Size = new System.Drawing.Size(87, 30);
            this.passByValueButton.TabIndex = 0;
            this.passByValueButton.Text = "Pass By Value";
            this.passByValueButton.UseVisualStyleBackColor = true;
            this.passByValueButton.Click += new System.EventHandler(this.passByValueButton_Click);
            // 
            // passByRefButton
            // 
            this.passByRefButton.Location = new System.Drawing.Point(97, 105);
            this.passByRefButton.Name = "passByRefButton";
            this.passByRefButton.Size = new System.Drawing.Size(87, 30);
            this.passByRefButton.TabIndex = 1;
            this.passByRefButton.Text = "Pass By Ref";
            this.passByRefButton.UseVisualStyleBackColor = true;
            this.passByRefButton.Click += new System.EventHandler(this.passByRefButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 182);
            this.Controls.Add(this.passByRefButton);
            this.Controls.Add(this.passByValueButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button passByValueButton;
        private System.Windows.Forms.Button passByRefButton;
    }
}


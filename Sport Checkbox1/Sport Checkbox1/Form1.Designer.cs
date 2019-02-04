namespace Sport_Checkbox1
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
            this.tennisChk = new System.Windows.Forms.CheckBox();
            this.cricketChk = new System.Windows.Forms.CheckBox();
            this.golfChk = new System.Windows.Forms.CheckBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.selectTxt = new System.Windows.Forms.TextBox();
            this.allChk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tennisChk
            // 
            this.tennisChk.AutoSize = true;
            this.tennisChk.Location = new System.Drawing.Point(76, 44);
            this.tennisChk.Name = "tennisChk";
            this.tennisChk.Size = new System.Drawing.Size(58, 17);
            this.tennisChk.TabIndex = 0;
            this.tennisChk.Text = "Tennis";
            this.tennisChk.UseVisualStyleBackColor = true;
            // 
            // cricketChk
            // 
            this.cricketChk.AutoSize = true;
            this.cricketChk.Location = new System.Drawing.Point(76, 85);
            this.cricketChk.Name = "cricketChk";
            this.cricketChk.Size = new System.Drawing.Size(59, 17);
            this.cricketChk.TabIndex = 1;
            this.cricketChk.Text = "Cricket";
            this.cricketChk.UseVisualStyleBackColor = true;
            // 
            // golfChk
            // 
            this.golfChk.AutoSize = true;
            this.golfChk.Location = new System.Drawing.Point(77, 123);
            this.golfChk.Name = "golfChk";
            this.golfChk.Size = new System.Drawing.Size(45, 17);
            this.golfChk.TabIndex = 2;
            this.golfChk.Text = "Golf";
            this.golfChk.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(21, 160);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // selectTxt
            // 
            this.selectTxt.Location = new System.Drawing.Point(117, 162);
            this.selectTxt.Name = "selectTxt";
            this.selectTxt.Size = new System.Drawing.Size(156, 20);
            this.selectTxt.TabIndex = 4;
            // 
            // allChk
            // 
            this.allChk.AutoSize = true;
            this.allChk.Enabled = false;
            this.allChk.Location = new System.Drawing.Point(117, 197);
            this.allChk.Name = "allChk";
            this.allChk.Size = new System.Drawing.Size(37, 17);
            this.allChk.TabIndex = 5;
            this.allChk.Text = "All";
            this.allChk.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 230);
            this.Controls.Add(this.allChk);
            this.Controls.Add(this.selectTxt);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.golfChk);
            this.Controls.Add(this.cricketChk);
            this.Controls.Add(this.tennisChk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox tennisChk;
        private System.Windows.Forms.CheckBox cricketChk;
        private System.Windows.Forms.CheckBox golfChk;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.TextBox selectTxt;
        private System.Windows.Forms.CheckBox allChk;
    }
}


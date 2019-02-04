namespace BalloonLoan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbx_amt = new System.Windows.Forms.TextBox();
            this.txtbx_loan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbx_rate = new System.Windows.Forms.TextBox();
            this.txtbx_period = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_payment = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(166, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balloon Loan Payment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.txtbx_amt);
            this.groupBox1.Controls.Add(this.txtbx_loan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(61, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Values can be decimal";
            // 
            // txtbx_amt
            // 
            this.txtbx_amt.BackColor = System.Drawing.Color.Blue;
            this.txtbx_amt.ForeColor = System.Drawing.Color.Yellow;
            this.txtbx_amt.Location = new System.Drawing.Point(145, 91);
            this.txtbx_amt.Name = "txtbx_amt";
            this.txtbx_amt.Size = new System.Drawing.Size(143, 25);
            this.txtbx_amt.TabIndex = 5;
            // 
            // txtbx_loan
            // 
            this.txtbx_loan.BackColor = System.Drawing.Color.Blue;
            this.txtbx_loan.ForeColor = System.Drawing.Color.Yellow;
            this.txtbx_loan.Location = new System.Drawing.Point(145, 41);
            this.txtbx_loan.Name = "txtbx_loan";
            this.txtbx_loan.Size = new System.Drawing.Size(143, 25);
            this.txtbx_loan.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Balloon Amt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loan Value";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox2.Controls.Add(this.txtbx_rate);
            this.groupBox2.Controls.Add(this.txtbx_period);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(387, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 151);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Values can be decimal";
            // 
            // txtbx_rate
            // 
            this.txtbx_rate.BackColor = System.Drawing.Color.Blue;
            this.txtbx_rate.ForeColor = System.Drawing.Color.Yellow;
            this.txtbx_rate.Location = new System.Drawing.Point(191, 91);
            this.txtbx_rate.Name = "txtbx_rate";
            this.txtbx_rate.Size = new System.Drawing.Size(72, 25);
            this.txtbx_rate.TabIndex = 4;
            // 
            // txtbx_period
            // 
            this.txtbx_period.BackColor = System.Drawing.Color.Blue;
            this.txtbx_period.ForeColor = System.Drawing.Color.Yellow;
            this.txtbx_period.Location = new System.Drawing.Point(191, 41);
            this.txtbx_period.Name = "txtbx_period";
            this.txtbx_period.Size = new System.Drawing.Size(72, 25);
            this.txtbx_period.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Rate (%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Period (yrs)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_payment);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(387, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 95);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Monthly Payment";
            // 
            // lbl_payment
            // 
            this.lbl_payment.BackColor = System.Drawing.Color.Gold;
            this.lbl_payment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_payment.Location = new System.Drawing.Point(19, 34);
            this.lbl_payment.Name = "lbl_payment";
            this.lbl_payment.Size = new System.Drawing.Size(199, 37);
            this.lbl_payment.TabIndex = 0;
            this.lbl_payment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_calc
            // 
            this.btn_calc.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc.Location = new System.Drawing.Point(224, 298);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(131, 37);
            this.btn_calc.TabIndex = 4;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Blue;
            this.btn_exit.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(387, 384);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(106, 32);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Red;
            this.btn_clear.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_clear.Location = new System.Drawing.Point(260, 384);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(106, 32);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear ALL";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 530);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_payment;
        private System.Windows.Forms.TextBox txtbx_amt;
        private System.Windows.Forms.TextBox txtbx_loan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_rate;
        private System.Windows.Forms.TextBox txtbx_period;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_clear;
    }
}


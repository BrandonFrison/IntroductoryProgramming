namespace JoesAutomotive
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
            this.gb_oillube = new System.Windows.Forms.GroupBox();
            this.cb_lube = new System.Windows.Forms.CheckBox();
            this.cb_oil = new System.Windows.Forms.CheckBox();
            this.gb_flushes = new System.Windows.Forms.GroupBox();
            this.cb_trans = new System.Windows.Forms.CheckBox();
            this.cb_rad = new System.Windows.Forms.CheckBox();
            this.gb_misc = new System.Windows.Forms.GroupBox();
            this.lb_tires = new System.Windows.Forms.ListBox();
            this.btn_clearmisc = new System.Windows.Forms.Button();
            this.lb_misc = new System.Windows.Forms.ListBox();
            this.gb_parts = new System.Windows.Forms.GroupBox();
            this.lbl_errorparts = new System.Windows.Forms.Label();
            this.lbl_errorlabor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_hrs = new System.Windows.Forms.TextBox();
            this.txt_parts = new System.Windows.Forms.TextBox();
            this.gb_summary = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_tax = new System.Windows.Forms.Label();
            this.lbl_parts = new System.Windows.Forms.Label();
            this.lbl_serv = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_calc = new System.Windows.Forms.Button();
            this.gb_oillube.SuspendLayout();
            this.gb_flushes.SuspendLayout();
            this.gb_misc.SuspendLayout();
            this.gb_parts.SuspendLayout();
            this.gb_summary.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_oillube
            // 
            this.gb_oillube.Controls.Add(this.cb_lube);
            this.gb_oillube.Controls.Add(this.cb_oil);
            this.gb_oillube.Location = new System.Drawing.Point(12, 12);
            this.gb_oillube.Name = "gb_oillube";
            this.gb_oillube.Size = new System.Drawing.Size(224, 82);
            this.gb_oillube.TabIndex = 0;
            this.gb_oillube.TabStop = false;
            this.gb_oillube.Text = "Oil and Lube";
            // 
            // cb_lube
            // 
            this.cb_lube.AutoSize = true;
            this.cb_lube.Location = new System.Drawing.Point(16, 44);
            this.cb_lube.Name = "cb_lube";
            this.cb_lube.Size = new System.Drawing.Size(112, 17);
            this.cb_lube.TabIndex = 1;
            this.cb_lube.Text = "Lube Job ($18.00)";
            this.cb_lube.UseVisualStyleBackColor = true;
            // 
            // cb_oil
            // 
            this.cb_oil.AutoSize = true;
            this.cb_oil.Location = new System.Drawing.Point(16, 20);
            this.cb_oil.Name = "cb_oil";
            this.cb_oil.Size = new System.Drawing.Size(120, 17);
            this.cb_oil.TabIndex = 0;
            this.cb_oil.Text = "Oil Change ($26.00)";
            this.cb_oil.UseVisualStyleBackColor = true;
            // 
            // gb_flushes
            // 
            this.gb_flushes.Controls.Add(this.cb_trans);
            this.gb_flushes.Controls.Add(this.cb_rad);
            this.gb_flushes.Location = new System.Drawing.Point(336, 12);
            this.gb_flushes.Name = "gb_flushes";
            this.gb_flushes.Size = new System.Drawing.Size(221, 82);
            this.gb_flushes.TabIndex = 1;
            this.gb_flushes.TabStop = false;
            this.gb_flushes.Text = "Flushes";
            // 
            // cb_trans
            // 
            this.cb_trans.AutoSize = true;
            this.cb_trans.Location = new System.Drawing.Point(25, 44);
            this.cb_trans.Name = "cb_trans";
            this.cb_trans.Size = new System.Drawing.Size(157, 17);
            this.cb_trans.TabIndex = 1;
            this.cb_trans.Text = "Transmission Flush ($80.00)";
            this.cb_trans.UseVisualStyleBackColor = true;
            // 
            // cb_rad
            // 
            this.cb_rad.AutoSize = true;
            this.cb_rad.Location = new System.Drawing.Point(25, 20);
            this.cb_rad.Name = "cb_rad";
            this.cb_rad.Size = new System.Drawing.Size(136, 17);
            this.cb_rad.TabIndex = 0;
            this.cb_rad.Text = "Radiator Flush ($30.00)";
            this.cb_rad.UseVisualStyleBackColor = true;
            // 
            // gb_misc
            // 
            this.gb_misc.Controls.Add(this.lb_tires);
            this.gb_misc.Controls.Add(this.btn_clearmisc);
            this.gb_misc.Controls.Add(this.lb_misc);
            this.gb_misc.Location = new System.Drawing.Point(12, 120);
            this.gb_misc.Name = "gb_misc";
            this.gb_misc.Size = new System.Drawing.Size(224, 207);
            this.gb_misc.TabIndex = 2;
            this.gb_misc.TabStop = false;
            this.gb_misc.Text = "Misc";
            // 
            // lb_tires
            // 
            this.lb_tires.FormattingEnabled = true;
            this.lb_tires.Location = new System.Drawing.Point(7, 109);
            this.lb_tires.Name = "lb_tires";
            this.lb_tires.ScrollAlwaysVisible = true;
            this.lb_tires.Size = new System.Drawing.Size(89, 69);
            this.lb_tires.TabIndex = 2;
            // 
            // btn_clearmisc
            // 
            this.btn_clearmisc.Location = new System.Drawing.Point(125, 109);
            this.btn_clearmisc.Name = "btn_clearmisc";
            this.btn_clearmisc.Size = new System.Drawing.Size(75, 23);
            this.btn_clearmisc.TabIndex = 1;
            this.btn_clearmisc.Text = "Clear Misc";
            this.btn_clearmisc.UseVisualStyleBackColor = true;
            this.btn_clearmisc.Click += new System.EventHandler(this.btn_clearmisc_Click);
            // 
            // lb_misc
            // 
            this.lb_misc.FormattingEnabled = true;
            this.lb_misc.Location = new System.Drawing.Point(7, 20);
            this.lb_misc.Name = "lb_misc";
            this.lb_misc.Size = new System.Drawing.Size(193, 69);
            this.lb_misc.TabIndex = 0;
            this.lb_misc.SelectedIndexChanged += new System.EventHandler(this.lb_misc_SelectedIndexChanged);
            // 
            // gb_parts
            // 
            this.gb_parts.Controls.Add(this.lbl_errorparts);
            this.gb_parts.Controls.Add(this.lbl_errorlabor);
            this.gb_parts.Controls.Add(this.label6);
            this.gb_parts.Controls.Add(this.label5);
            this.gb_parts.Controls.Add(this.txt_hrs);
            this.gb_parts.Controls.Add(this.txt_parts);
            this.gb_parts.Location = new System.Drawing.Point(336, 160);
            this.gb_parts.Name = "gb_parts";
            this.gb_parts.Size = new System.Drawing.Size(221, 167);
            this.gb_parts.TabIndex = 3;
            this.gb_parts.TabStop = false;
            this.gb_parts.Text = "Part and Labor ($18.80)";
            // 
            // lbl_errorparts
            // 
            this.lbl_errorparts.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorparts.Location = new System.Drawing.Point(25, 125);
            this.lbl_errorparts.Name = "lbl_errorparts";
            this.lbl_errorparts.Size = new System.Drawing.Size(157, 30);
            this.lbl_errorparts.TabIndex = 5;
            // 
            // lbl_errorlabor
            // 
            this.lbl_errorlabor.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorlabor.Location = new System.Drawing.Point(25, 85);
            this.lbl_errorlabor.Name = "lbl_errorlabor";
            this.lbl_errorlabor.Size = new System.Drawing.Size(157, 30);
            this.lbl_errorlabor.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Labor (hrs worked)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Parts ($)";
            // 
            // txt_hrs
            // 
            this.txt_hrs.Location = new System.Drawing.Point(134, 54);
            this.txt_hrs.Name = "txt_hrs";
            this.txt_hrs.Size = new System.Drawing.Size(64, 20);
            this.txt_hrs.TabIndex = 1;
            // 
            // txt_parts
            // 
            this.txt_parts.Location = new System.Drawing.Point(134, 28);
            this.txt_parts.Name = "txt_parts";
            this.txt_parts.Size = new System.Drawing.Size(64, 20);
            this.txt_parts.TabIndex = 0;
            // 
            // gb_summary
            // 
            this.gb_summary.Controls.Add(this.label4);
            this.gb_summary.Controls.Add(this.label3);
            this.gb_summary.Controls.Add(this.label2);
            this.gb_summary.Controls.Add(this.label1);
            this.gb_summary.Controls.Add(this.lbl_total);
            this.gb_summary.Controls.Add(this.lbl_tax);
            this.gb_summary.Controls.Add(this.lbl_parts);
            this.gb_summary.Controls.Add(this.lbl_serv);
            this.gb_summary.Location = new System.Drawing.Point(12, 333);
            this.gb_summary.Name = "gb_summary";
            this.gb_summary.Size = new System.Drawing.Size(326, 168);
            this.gb_summary.TabIndex = 4;
            this.gb_summary.TabStop = false;
            this.gb_summary.Text = "Summary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Fees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tax (on parts)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Service and Labor";
            // 
            // lbl_total
            // 
            this.lbl_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_total.Location = new System.Drawing.Point(122, 130);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(129, 23);
            this.lbl_total.TabIndex = 3;
            // 
            // lbl_tax
            // 
            this.lbl_tax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_tax.Location = new System.Drawing.Point(122, 95);
            this.lbl_tax.Name = "lbl_tax";
            this.lbl_tax.Size = new System.Drawing.Size(129, 23);
            this.lbl_tax.TabIndex = 2;
            // 
            // lbl_parts
            // 
            this.lbl_parts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_parts.Location = new System.Drawing.Point(122, 59);
            this.lbl_parts.Name = "lbl_parts";
            this.lbl_parts.Size = new System.Drawing.Size(129, 23);
            this.lbl_parts.TabIndex = 1;
            // 
            // lbl_serv
            // 
            this.lbl_serv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_serv.Location = new System.Drawing.Point(122, 25);
            this.lbl_serv.Name = "lbl_serv";
            this.lbl_serv.Size = new System.Drawing.Size(129, 23);
            this.lbl_serv.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(263, 524);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(154, 524);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(44, 524);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 7;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 584);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.gb_summary);
            this.Controls.Add(this.gb_parts);
            this.Controls.Add(this.gb_misc);
            this.Controls.Add(this.gb_flushes);
            this.Controls.Add(this.gb_oillube);
            this.Name = "Form1";
            this.Text = "Brandon Frison Automotive";
            this.gb_oillube.ResumeLayout(false);
            this.gb_oillube.PerformLayout();
            this.gb_flushes.ResumeLayout(false);
            this.gb_flushes.PerformLayout();
            this.gb_misc.ResumeLayout(false);
            this.gb_parts.ResumeLayout(false);
            this.gb_parts.PerformLayout();
            this.gb_summary.ResumeLayout(false);
            this.gb_summary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_oillube;
        private System.Windows.Forms.GroupBox gb_flushes;
        private System.Windows.Forms.GroupBox gb_misc;
        private System.Windows.Forms.ListBox lb_tires;
        private System.Windows.Forms.Button btn_clearmisc;
        private System.Windows.Forms.ListBox lb_misc;
        private System.Windows.Forms.GroupBox gb_parts;
        private System.Windows.Forms.GroupBox gb_summary;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label lbl_serv;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_tax;
        private System.Windows.Forms.Label lbl_parts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_parts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_hrs;
        private System.Windows.Forms.CheckBox cb_lube;
        private System.Windows.Forms.CheckBox cb_oil;
        private System.Windows.Forms.CheckBox cb_trans;
        private System.Windows.Forms.CheckBox cb_rad;
        private System.Windows.Forms.Label lbl_errorparts;
        private System.Windows.Forms.Label lbl_errorlabor;
    }
}


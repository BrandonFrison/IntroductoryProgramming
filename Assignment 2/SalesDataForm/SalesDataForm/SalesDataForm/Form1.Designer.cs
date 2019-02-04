namespace SalesDataForm
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
            this.btn_totalsales = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.gb_totalsales = new System.Windows.Forms.GroupBox();
            this.lbl_totalsales = new System.Windows.Forms.Label();
            this.cb_error = new System.Windows.Forms.CheckBox();
            this.lstbx_data = new System.Windows.Forms.ListBox();
            this.gb_totalsales.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_totalsales
            // 
            this.btn_totalsales.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_totalsales.Location = new System.Drawing.Point(132, 237);
            this.btn_totalsales.Name = "btn_totalsales";
            this.btn_totalsales.Size = new System.Drawing.Size(177, 43);
            this.btn_totalsales.TabIndex = 0;
            this.btn_totalsales.Text = "Total Sales";
            this.btn_totalsales.UseVisualStyleBackColor = true;
            this.btn_totalsales.Click += new System.EventHandler(this.btn_totalsales_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // txtfname
            // 
            this.txtfname.BackColor = System.Drawing.Color.Black;
            this.txtfname.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.ForeColor = System.Drawing.Color.Yellow;
            this.txtfname.Location = new System.Drawing.Point(145, 43);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(164, 29);
            this.txtfname.TabIndex = 3;
            // 
            // txtlname
            // 
            this.txtlname.BackColor = System.Drawing.Color.Black;
            this.txtlname.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname.ForeColor = System.Drawing.Color.Yellow;
            this.txtlname.Location = new System.Drawing.Point(144, 115);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(165, 29);
            this.txtlname.TabIndex = 4;
            // 
            // gb_totalsales
            // 
            this.gb_totalsales.Controls.Add(this.lbl_totalsales);
            this.gb_totalsales.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_totalsales.Location = new System.Drawing.Point(382, 203);
            this.gb_totalsales.Name = "gb_totalsales";
            this.gb_totalsales.Size = new System.Drawing.Size(260, 101);
            this.gb_totalsales.TabIndex = 5;
            this.gb_totalsales.TabStop = false;
            this.gb_totalsales.Text = "Total Sales";
            // 
            // lbl_totalsales
            // 
            this.lbl_totalsales.BackColor = System.Drawing.Color.Yellow;
            this.lbl_totalsales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_totalsales.ForeColor = System.Drawing.Color.Blue;
            this.lbl_totalsales.Location = new System.Drawing.Point(22, 34);
            this.lbl_totalsales.Name = "lbl_totalsales";
            this.lbl_totalsales.Size = new System.Drawing.Size(221, 43);
            this.lbl_totalsales.TabIndex = 0;
            this.lbl_totalsales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_error
            // 
            this.cb_error.AutoSize = true;
            this.cb_error.Checked = true;
            this.cb_error.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_error.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_error.Location = new System.Drawing.Point(382, 165);
            this.cb_error.Name = "cb_error";
            this.cb_error.Size = new System.Drawing.Size(98, 20);
            this.cb_error.TabIndex = 6;
            this.cb_error.Text = "Show Errors";
            this.cb_error.UseVisualStyleBackColor = true;
            // 
            // lstbx_data
            // 
            this.lstbx_data.BackColor = System.Drawing.SystemColors.Info;
            this.lstbx_data.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbx_data.FormattingEnabled = true;
            this.lstbx_data.ItemHeight = 15;
            this.lstbx_data.Location = new System.Drawing.Point(382, 43);
            this.lstbx_data.Name = "lstbx_data";
            this.lstbx_data.Size = new System.Drawing.Size(260, 109);
            this.lstbx_data.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 368);
            this.Controls.Add(this.lstbx_data);
            this.Controls.Add(this.cb_error);
            this.Controls.Add(this.gb_totalsales);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_totalsales);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_totalsales.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_totalsales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.GroupBox gb_totalsales;
        private System.Windows.Forms.Label lbl_totalsales;
        private System.Windows.Forms.CheckBox cb_error;
        private System.Windows.Forms.ListBox lstbx_data;
    }
}


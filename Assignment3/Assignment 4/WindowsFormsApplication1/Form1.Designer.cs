namespace WindowsFormsApplication1
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
            this.btn_name = new System.Windows.Forms.Button();
            this.btn_sales = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.gb_srch = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.rb_sales = new System.Windows.Forms.RadioButton();
            this.rb_name = new System.Windows.Forms.RadioButton();
            this.lb_games = new System.Windows.Forms.ListBox();
            this.gb_srch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_name
            // 
            this.btn_name.Location = new System.Drawing.Point(47, 28);
            this.btn_name.Name = "btn_name";
            this.btn_name.Size = new System.Drawing.Size(75, 46);
            this.btn_name.TabIndex = 0;
            this.btn_name.Text = "Sort By Name";
            this.btn_name.UseVisualStyleBackColor = true;
            this.btn_name.Click += new System.EventHandler(this.btn_name_Click);
            // 
            // btn_sales
            // 
            this.btn_sales.Location = new System.Drawing.Point(47, 108);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(75, 46);
            this.btn_sales.TabIndex = 1;
            this.btn_sales.Text = "Sort By Sales";
            this.btn_sales.UseVisualStyleBackColor = true;
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(255, 92);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(82, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // gb_srch
            // 
            this.gb_srch.Controls.Add(this.txt_search);
            this.gb_srch.Controls.Add(this.rb_sales);
            this.gb_srch.Controls.Add(this.btn_search);
            this.gb_srch.Controls.Add(this.rb_name);
            this.gb_srch.Location = new System.Drawing.Point(179, 192);
            this.gb_srch.Name = "gb_srch";
            this.gb_srch.Size = new System.Drawing.Size(376, 148);
            this.gb_srch.TabIndex = 3;
            this.gb_srch.TabStop = false;
            this.gb_srch.Text = "Search";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(26, 89);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(206, 26);
            this.txt_search.TabIndex = 5;
            // 
            // rb_sales
            // 
            this.rb_sales.AutoSize = true;
            this.rb_sales.Location = new System.Drawing.Point(147, 38);
            this.rb_sales.Name = "rb_sales";
            this.rb_sales.Size = new System.Drawing.Size(66, 17);
            this.rb_sales.TabIndex = 1;
            this.rb_sales.Text = "By Sales";
            this.rb_sales.UseVisualStyleBackColor = true;
            this.rb_sales.CheckedChanged += new System.EventHandler(this.rb_sales_CheckedChanged);
            // 
            // rb_name
            // 
            this.rb_name.AutoSize = true;
            this.rb_name.Checked = true;
            this.rb_name.Location = new System.Drawing.Point(26, 38);
            this.rb_name.Name = "rb_name";
            this.rb_name.Size = new System.Drawing.Size(86, 17);
            this.rb_name.TabIndex = 0;
            this.rb_name.TabStop = true;
            this.rb_name.Text = "Within Name";
            this.rb_name.UseVisualStyleBackColor = true;
            this.rb_name.CheckedChanged += new System.EventHandler(this.rb_name_CheckedChanged);
            // 
            // lb_games
            // 
            this.lb_games.FormattingEnabled = true;
            this.lb_games.Location = new System.Drawing.Point(179, 19);
            this.lb_games.Name = "lb_games";
            this.lb_games.Size = new System.Drawing.Size(358, 147);
            this.lb_games.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 369);
            this.Controls.Add(this.lb_games);
            this.Controls.Add(this.gb_srch);
            this.Controls.Add(this.btn_sales);
            this.Controls.Add(this.btn_name);
            this.Name = "Form1";
            this.Text = "Brandon Frison Game Sales";
            this.gb_srch.ResumeLayout(false);
            this.gb_srch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_name;
        private System.Windows.Forms.Button btn_sales;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.GroupBox gb_srch;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.RadioButton rb_sales;
        private System.Windows.Forms.RadioButton rb_name;
        private System.Windows.Forms.ListBox lb_games;
    }
}


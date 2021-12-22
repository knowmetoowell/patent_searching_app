namespace Assignment_Patents_Searching_App
{
    partial class Help
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_google_search = new System.Windows.Forms.Button();
            this.btn_search2 = new System.Windows.Forms.Button();
            this.lbl_num = new System.Windows.Forms.Label();
            this.txt_except = new System.Windows.Forms.TextBox();
            this.lbl_except = new System.Windows.Forms.Label();
            this.lbl_appname = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.lbl_and = new System.Windows.Forms.Label();
            this.lbl_excepthelp = new System.Windows.Forms.Label();
            this.lbl_searchedNo = new System.Windows.Forms.Label();
            this.lbl_combo = new System.Windows.Forms.Label();
            this.lbl_or = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_contents = new System.Windows.Forms.TextBox();
            this.lbl_contents = new System.Windows.Forms.Label();
            this.lbl_contentshelp = new System.Windows.Forms.Label();
            this.lbl_google = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_google_search);
            this.panel1.Controls.Add(this.btn_search2);
            this.panel1.Controls.Add(this.lbl_num);
            this.panel1.Controls.Add(this.txt_except);
            this.panel1.Controls.Add(this.lbl_except);
            this.panel1.Controls.Add(this.lbl_appname);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 162);
            this.panel1.TabIndex = 12;
            // 
            // btn_google_search
            // 
            this.btn_google_search.Location = new System.Drawing.Point(648, 79);
            this.btn_google_search.Name = "btn_google_search";
            this.btn_google_search.Size = new System.Drawing.Size(195, 28);
            this.btn_google_search.TabIndex = 19;
            this.btn_google_search.Text = "Google Patents 검색";
            this.btn_google_search.UseVisualStyleBackColor = true;
            // 
            // btn_search2
            // 
            this.btn_search2.Location = new System.Drawing.Point(648, 124);
            this.btn_search2.Name = "btn_search2";
            this.btn_search2.Size = new System.Drawing.Size(195, 28);
            this.btn_search2.TabIndex = 18;
            this.btn_search2.Text = "내 자료에서 검색";
            this.btn_search2.UseVisualStyleBackColor = true;
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Font = new System.Drawing.Font("Arial", 13F);
            this.lbl_num.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_num.Location = new System.Drawing.Point(910, 124);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(266, 31);
            this.lbl_num.TabIndex = 17;
            this.lbl_num.Text = "검색된 특허의 수: 2000개";
            // 
            // txt_except
            // 
            this.txt_except.Location = new System.Drawing.Point(155, 124);
            this.txt_except.Name = "txt_except";
            this.txt_except.ReadOnly = true;
            this.txt_except.Size = new System.Drawing.Size(472, 28);
            this.txt_except.TabIndex = 13;
            // 
            // lbl_except
            // 
            this.lbl_except.AutoSize = true;
            this.lbl_except.Font = new System.Drawing.Font("Arial", 13F);
            this.lbl_except.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_except.Location = new System.Drawing.Point(14, 121);
            this.lbl_except.Name = "lbl_except";
            this.lbl_except.Size = new System.Drawing.Size(133, 31);
            this.lbl_except.TabIndex = 12;
            this.lbl_except.Text = "except for:";
            // 
            // lbl_appname
            // 
            this.lbl_appname.AutoSize = true;
            this.lbl_appname.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_appname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_appname.Location = new System.Drawing.Point(12, 18);
            this.lbl_appname.Name = "lbl_appname";
            this.lbl_appname.Size = new System.Drawing.Size(521, 45);
            this.lbl_appname.TabIndex = 8;
            this.lbl_appname.Text = "Patent Searching Application";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(155, 79);
            this.txt_search.Name = "txt_search";
            this.txt_search.ReadOnly = true;
            this.txt_search.Size = new System.Drawing.Size(472, 28);
            this.txt_search.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "전체 검색",
            "app_num",
            "app_date",
            "title",
            "abstract",
            "inventors",
            "CPCs",
            "title + abstract"});
            this.comboBox1.Location = new System.Drawing.Point(12, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 2;
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_search.Location = new System.Drawing.Point(26, 293);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(126, 27);
            this.lbl_search.TabIndex = 15;
            this.lbl_search.Text = "기본검색기능";
            // 
            // lbl_and
            // 
            this.lbl_and.AutoSize = true;
            this.lbl_and.Font = new System.Drawing.Font("Arial", 10F);
            this.lbl_and.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_and.Location = new System.Drawing.Point(26, 447);
            this.lbl_and.Name = "lbl_and";
            this.lbl_and.Size = new System.Drawing.Size(87, 23);
            this.lbl_and.TabIndex = 16;
            this.lbl_and.Text = "연산자and";
            // 
            // lbl_excepthelp
            // 
            this.lbl_excepthelp.AutoSize = true;
            this.lbl_excepthelp.Font = new System.Drawing.Font("Arial", 10F);
            this.lbl_excepthelp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_excepthelp.Location = new System.Drawing.Point(26, 525);
            this.lbl_excepthelp.Name = "lbl_excepthelp";
            this.lbl_excepthelp.Size = new System.Drawing.Size(121, 23);
            this.lbl_excepthelp.TabIndex = 17;
            this.lbl_excepthelp.Text = "Except 연산자";
            // 
            // lbl_searchedNo
            // 
            this.lbl_searchedNo.AutoSize = true;
            this.lbl_searchedNo.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_searchedNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_searchedNo.Location = new System.Drawing.Point(26, 401);
            this.lbl_searchedNo.Name = "lbl_searchedNo";
            this.lbl_searchedNo.Size = new System.Drawing.Size(244, 27);
            this.lbl_searchedNo.TabIndex = 18;
            this.lbl_searchedNo.Text = "검색된 특허의 수: 2000개";
            // 
            // lbl_combo
            // 
            this.lbl_combo.AutoSize = true;
            this.lbl_combo.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_combo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_combo.Location = new System.Drawing.Point(26, 352);
            this.lbl_combo.Name = "lbl_combo";
            this.lbl_combo.Size = new System.Drawing.Size(88, 27);
            this.lbl_combo.TabIndex = 19;
            this.lbl_combo.Text = "콤보박스";
            // 
            // lbl_or
            // 
            this.lbl_or.AutoSize = true;
            this.lbl_or.Font = new System.Drawing.Font("Arial", 10F);
            this.lbl_or.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_or.Location = new System.Drawing.Point(26, 485);
            this.lbl_or.Name = "lbl_or";
            this.lbl_or.Size = new System.Drawing.Size(73, 23);
            this.lbl_or.TabIndex = 20;
            this.lbl_or.Text = "연산자or";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txt_contents);
            this.panel2.Controls.Add(this.lbl_contents);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1178, 119);
            this.panel2.TabIndex = 21;
            // 
            // txt_contents
            // 
            this.txt_contents.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contents.Location = new System.Drawing.Point(155, 6);
            this.txt_contents.Multiline = true;
            this.txt_contents.Name = "txt_contents";
            this.txt_contents.ReadOnly = true;
            this.txt_contents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_contents.Size = new System.Drawing.Size(1004, 76);
            this.txt_contents.TabIndex = 10;
            this.txt_contents.Text = "셀을 클릭하세요.";
            // 
            // lbl_contents
            // 
            this.lbl_contents.AutoSize = true;
            this.lbl_contents.Font = new System.Drawing.Font("Arial", 13F);
            this.lbl_contents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_contents.Location = new System.Drawing.Point(14, 6);
            this.lbl_contents.Name = "lbl_contents";
            this.lbl_contents.Size = new System.Drawing.Size(123, 31);
            this.lbl_contents.TabIndex = 11;
            this.lbl_contents.Text = "Contents:";
            // 
            // lbl_contentshelp
            // 
            this.lbl_contentshelp.AutoSize = true;
            this.lbl_contentshelp.Font = new System.Drawing.Font("Arial", 10F);
            this.lbl_contentshelp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_contentshelp.Location = new System.Drawing.Point(26, 577);
            this.lbl_contentshelp.Name = "lbl_contentshelp";
            this.lbl_contentshelp.Size = new System.Drawing.Size(55, 23);
            this.lbl_contentshelp.TabIndex = 22;
            this.lbl_contentshelp.Text = "콘텐츠";
            // 
            // lbl_google
            // 
            this.lbl_google.AutoSize = true;
            this.lbl_google.Font = new System.Drawing.Font("Arial", 10F);
            this.lbl_google.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_google.Location = new System.Drawing.Point(26, 616);
            this.lbl_google.Name = "lbl_google";
            this.lbl_google.Size = new System.Drawing.Size(183, 23);
            this.lbl_google.TabIndex = 23;
            this.lbl_google.Text = "Google Patents 검색";
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1178, 704);
            this.Controls.Add(this.lbl_google);
            this.Controls.Add(this.lbl_contentshelp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_or);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.lbl_and);
            this.Controls.Add(this.lbl_excepthelp);
            this.Controls.Add(this.lbl_searchedNo);
            this.Controls.Add(this.lbl_combo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Help";
            this.Text = "Patent Searching Application - Help";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_except;
        private System.Windows.Forms.Label lbl_except;
        private System.Windows.Forms.Label lbl_appname;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Label lbl_and;
        private System.Windows.Forms.Label lbl_excepthelp;
        private System.Windows.Forms.Label lbl_searchedNo;
        private System.Windows.Forms.Label lbl_combo;
        private System.Windows.Forms.Label lbl_or;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_contents;
        private System.Windows.Forms.Label lbl_contents;
        private System.Windows.Forms.Label lbl_contentshelp;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Label lbl_google;
        private System.Windows.Forms.Button btn_google_search;
        private System.Windows.Forms.Button btn_search2;
    }
}
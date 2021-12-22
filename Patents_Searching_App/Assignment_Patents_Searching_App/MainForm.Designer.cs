namespace Assignment_Patents_Searching_App
{
    partial class MainForm
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
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgv_patent = new System.Windows.Forms.DataGridView();
            this.col_btn_total = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_basket_form = new System.Windows.Forms.Button();
            this.lbl_appname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_google_search = new System.Windows.Forms.Button();
            this.lbl_num = new System.Windows.Forms.Label();
            this.btn_help = new System.Windows.Forms.Button();
            this.txt_except = new System.Windows.Forms.TextBox();
            this.lbl_except = new System.Windows.Forms.Label();
            this.txt_contents = new System.Windows.Forms.TextBox();
            this.lbl_contents = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patent)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(155, 79);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(472, 28);
            this.txt_search.TabIndex = 0;
            this.txt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_search_KeyDown);
            // 
            // btn_search2
            // 
            this.btn_search2.Location = new System.Drawing.Point(633, 124);
            this.btn_search2.Name = "btn_search2";
            this.btn_search2.Size = new System.Drawing.Size(195, 28);
            this.btn_search2.TabIndex = 1;
            this.btn_search2.Text = "내 자료에서 검색";
            this.btn_search2.UseVisualStyleBackColor = true;
            this.btn_search2.Click += new System.EventHandler(this.Btn_search2_Click);
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
            // dgv_patent
            // 
            this.dgv_patent.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgv_patent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_patent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_patent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_btn_total});
            this.dgv_patent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_patent.Location = new System.Drawing.Point(0, 351);
            this.dgv_patent.Name = "dgv_patent";
            this.dgv_patent.RowHeadersWidth = 62;
            this.dgv_patent.Size = new System.Drawing.Size(1178, 443);
            this.dgv_patent.TabIndex = 3;
            this.dgv_patent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_patent_CellClick);
            // 
            // col_btn_total
            // 
            this.col_btn_total.HeaderText = "장바구니";
            this.col_btn_total.MinimumWidth = 8;
            this.col_btn_total.Name = "col_btn_total";
            this.col_btn_total.ReadOnly = true;
            this.col_btn_total.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_btn_total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_btn_total.Text = "장바구니에 넣기";
            this.col_btn_total.UseColumnTextForButtonValue = true;
            this.col_btn_total.Width = 150;
            // 
            // btn_basket_form
            // 
            this.btn_basket_form.Location = new System.Drawing.Point(971, 18);
            this.btn_basket_form.Name = "btn_basket_form";
            this.btn_basket_form.Size = new System.Drawing.Size(195, 33);
            this.btn_basket_form.TabIndex = 7;
            this.btn_basket_form.Text = "장바구니 관리";
            this.btn_basket_form.UseVisualStyleBackColor = true;
            this.btn_basket_form.Click += new System.EventHandler(this.Btn_basket_form_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_google_search);
            this.panel1.Controls.Add(this.lbl_num);
            this.panel1.Controls.Add(this.btn_help);
            this.panel1.Controls.Add(this.txt_except);
            this.panel1.Controls.Add(this.lbl_except);
            this.panel1.Controls.Add(this.lbl_appname);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.btn_basket_form);
            this.panel1.Controls.Add(this.btn_search2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 162);
            this.panel1.TabIndex = 9;
            // 
            // btn_google_search
            // 
            this.btn_google_search.Location = new System.Drawing.Point(633, 79);
            this.btn_google_search.Name = "btn_google_search";
            this.btn_google_search.Size = new System.Drawing.Size(195, 28);
            this.btn_google_search.TabIndex = 15;
            this.btn_google_search.Text = "Google Patents 검색";
            this.btn_google_search.UseVisualStyleBackColor = true;
            this.btn_google_search.Click += new System.EventHandler(this.Btn_google_search_Click);
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Font = new System.Drawing.Font("Arial", 13F);
            this.lbl_num.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_num.Location = new System.Drawing.Point(900, 124);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(266, 31);
            this.lbl_num.TabIndex = 12;
            this.lbl_num.Text = "검색된 특허의 수: 2000개";
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(759, 18);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(195, 33);
            this.btn_help.TabIndex = 14;
            this.btn_help.Text = "검색 도움말";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.Btn_help_Click);
            // 
            // txt_except
            // 
            this.txt_except.Location = new System.Drawing.Point(155, 124);
            this.txt_except.Name = "txt_except";
            this.txt_except.Size = new System.Drawing.Size(472, 28);
            this.txt_except.TabIndex = 13;
            this.txt_except.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_except_KeyDown);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_contents);
            this.panel2.Controls.Add(this.lbl_contents);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1178, 103);
            this.panel2.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1178, 794);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_patent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Patent Searching Application - Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewButtonColumn col_btn_total;
        private System.Windows.Forms.Button btn_basket_form;
        private System.Windows.Forms.Label lbl_appname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_contents;
        private System.Windows.Forms.Label lbl_contents;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_except;
        private System.Windows.Forms.Label lbl_except;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_google_search;
        public System.Windows.Forms.DataGridView dgv_patent;
    }
}
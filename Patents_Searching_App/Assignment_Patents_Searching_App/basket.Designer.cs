namespace Assignment_Patents_Searching_App
{
    partial class form_basket
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
            this.dgv_basket_manage = new System.Windows.Forms.DataGridView();
            this.col_btn_basket2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_basketsave = new System.Windows.Forms.Button();
            this.sfd_basketsave = new System.Windows.Forms.SaveFileDialog();
            this.btn_basketcall = new System.Windows.Forms.Button();
            this.ofd_basketcall = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_contents = new System.Windows.Forms.TextBox();
            this.lbl_contents = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_basket_manage)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_basket_manage
            // 
            this.dgv_basket_manage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_basket_manage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_btn_basket2});
            this.dgv_basket_manage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_basket_manage.Location = new System.Drawing.Point(0, 218);
            this.dgv_basket_manage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_basket_manage.Name = "dgv_basket_manage";
            this.dgv_basket_manage.RowHeadersWidth = 62;
            this.dgv_basket_manage.RowTemplate.Height = 30;
            this.dgv_basket_manage.Size = new System.Drawing.Size(942, 402);
            this.dgv_basket_manage.TabIndex = 0;
            this.dgv_basket_manage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_basket_manage_CellClick);
            // 
            // col_btn_basket2
            // 
            this.col_btn_basket2.HeaderText = "장바구니";
            this.col_btn_basket2.MinimumWidth = 8;
            this.col_btn_basket2.Name = "col_btn_basket2";
            this.col_btn_basket2.Text = "장바구니에서 제거";
            this.col_btn_basket2.UseColumnTextForButtonValue = true;
            this.col_btn_basket2.Width = 150;
            // 
            // btn_basketsave
            // 
            this.btn_basketsave.Location = new System.Drawing.Point(775, 31);
            this.btn_basketsave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_basketsave.Name = "btn_basketsave";
            this.btn_basketsave.Size = new System.Drawing.Size(152, 30);
            this.btn_basketsave.TabIndex = 1;
            this.btn_basketsave.Text = "장바구니 파일저장";
            this.btn_basketsave.UseVisualStyleBackColor = true;
            this.btn_basketsave.Click += new System.EventHandler(this.Btn_basketsave_Click);
            // 
            // btn_basketcall
            // 
            this.btn_basketcall.Location = new System.Drawing.Point(619, 31);
            this.btn_basketcall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_basketcall.Name = "btn_basketcall";
            this.btn_basketcall.Size = new System.Drawing.Size(152, 30);
            this.btn_basketcall.TabIndex = 2;
            this.btn_basketcall.Text = "장바구니 불러오기";
            this.btn_basketcall.UseVisualStyleBackColor = true;
            this.btn_basketcall.Click += new System.EventHandler(this.Btn_basketcall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Patent Searching Application";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_basketsave);
            this.panel1.Controls.Add(this.btn_basketcall);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 83);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_contents);
            this.panel2.Controls.Add(this.lbl_contents);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(942, 135);
            this.panel2.TabIndex = 13;
            // 
            // txt_contents
            // 
            this.txt_contents.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contents.Location = new System.Drawing.Point(124, 5);
            this.txt_contents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_contents.Multiline = true;
            this.txt_contents.Name = "txt_contents";
            this.txt_contents.ReadOnly = true;
            this.txt_contents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_contents.Size = new System.Drawing.Size(804, 64);
            this.txt_contents.TabIndex = 10;
            this.txt_contents.Text = "셀을 클릭하세요.";
            // 
            // lbl_contents
            // 
            this.lbl_contents.AutoSize = true;
            this.lbl_contents.Font = new System.Drawing.Font("Arial", 13F);
            this.lbl_contents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_contents.Location = new System.Drawing.Point(11, 5);
            this.lbl_contents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_contents.Name = "lbl_contents";
            this.lbl_contents.Size = new System.Drawing.Size(104, 25);
            this.lbl_contents.TabIndex = 11;
            this.lbl_contents.Text = "Contents:";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(463, 31);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(152, 30);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "뒤로 가기";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // form_basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(942, 620);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_basket_manage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "form_basket";
            this.Text = "Patent Searching Application - Basket Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_basket_manage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_basket_manage;
        private System.Windows.Forms.DataGridViewButtonColumn col_btn_basket2;
        private System.Windows.Forms.Button btn_basketsave;
        private System.Windows.Forms.SaveFileDialog sfd_basketsave;
        private System.Windows.Forms.Button btn_basketcall;
        private System.Windows.Forms.OpenFileDialog ofd_basketcall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_contents;
        private System.Windows.Forms.Label lbl_contents;
        private System.Windows.Forms.Button btn_exit;
    }
}
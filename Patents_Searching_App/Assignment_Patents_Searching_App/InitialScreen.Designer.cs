namespace Assignment_Patents_Searching_App
{
    partial class InitialScreen
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
            this.btn_password_search = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_password_search
            // 
            this.btn_password_search.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_password_search.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_password_search.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_password_search.Location = new System.Drawing.Point(482, 437);
            this.btn_password_search.Name = "btn_password_search";
            this.btn_password_search.Size = new System.Drawing.Size(201, 39);
            this.btn_password_search.TabIndex = 3;
            this.btn_password_search.Text = "비밀번호 변경하기";
            this.btn_password_search.UseVisualStyleBackColor = false;
            this.btn_password_search.Click += new System.EventHandler(this.Btn_password_search_Click);
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_check.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_check.Location = new System.Drawing.Point(689, 390);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(135, 36);
            this.btn_check.TabIndex = 1;
            this.btn_check.Text = "Check!";
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.Btn_check_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(484, 390);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(199, 28);
            this.txt_password.TabIndex = 0;
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_password_KeyDown);
            // 
            // InitialScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(887, 524);
            this.Controls.Add(this.btn_password_search);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.txt_password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "InitialScreen";
            this.Text = "Patent Searching Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_password_search;
    }
}
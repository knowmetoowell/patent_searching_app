using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment_Patents_Searching_App
{
    
    public partial class InitialScreen : Form
    {
        public InitialScreen()
        {
            InitializeComponent();
            BackgroundImage = Image.FromFile("특허검색배경.png");
            


        }
        
        static string filepath_password_text = Directory.GetCurrentDirectory() + "/password_text.txt";
        
        private void Btn_check_Click(object sender, EventArgs e)
        {

            
            string[] lines = File.ReadAllLines(filepath_password_text);
            string lastline = lines.GetValue(lines.Length - 1).ToString();
           
            
            if (txt_password.Text == lastline)
            {
                this.Hide();
                MainForm main = new MainForm();
                main.ShowDialog();
                this.Close();
            }
            else if (txt_password.Text == null)
            {
                MessageBox.Show("비밀번호를 입력하세요.");
            }
            else
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.");
            }

        } // 비밀번호 확인

        private void Btn_password_search_Click(object sender, EventArgs e)
        {
            PasswordManage pm = new PasswordManage();
            pm.Show();

            

        }

        private void Txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_check_Click(sender, e);


            }
        }
    }
}

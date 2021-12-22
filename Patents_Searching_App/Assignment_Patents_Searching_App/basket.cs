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
    public partial class form_basket : Form
    {

        public static DataTable dt = Program.NewTableReturn();
        public form_basket()
        {
            InitializeComponent();


            MainForm.dtdt = MainForm.dtdt.DefaultView.ToTable(true);
            dgv_basket_manage.DataSource = MainForm.dtdt;
            dgv_basket_manage.Font = new Font("Arial", 10);
            dgv_basket_manage.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
         
        }

        private void Dgv_basket_manage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && dgv_basket_manage.DataSource == MainForm.dtdt)
            {
                MainForm.dtdt.Rows[e.RowIndex].Delete();
            }
            else if (e.ColumnIndex == 0 && dgv_basket_manage.DataSource == basketcall_dt)
            {
                basketcall_dt.Rows[e.RowIndex].Delete();
            }
            else
            {
                string contents = dgv_basket_manage.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                txt_contents.Text = contents;
            }
        }

        private void Btn_basketsave_Click(object sender, EventArgs e)
        {
            
            sfd_basketsave.InitialDirectory = Directory.GetCurrentDirectory();
            sfd_basketsave.Filter = " (*.csv)|*.csv|txt (*txt)|*.txt|All files (*.*)|*.*";
            sfd_basketsave.AutoUpgradeEnabled = false;
            if (sfd_basketsave.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd_basketsave.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

                string line = string.Join(",", MainForm.dtdt.Columns.Cast<object>());
                sw.WriteLine(line);

                foreach (DataRow dr in MainForm.dtdt.Rows)
                {
                    line = string.Join(",", dr.ItemArray.Cast<object>());
                    sw.WriteLine(line);
                }

                sw.Close();
                fs.Close();


            }
        }

        public static DataTable basketcall_dt = new DataTable();
        private void Btn_basketcall_Click(object sender, EventArgs e)
        {
            
            
            ofd_basketcall.InitialDirectory = Directory.GetCurrentDirectory();
            ofd_basketcall.Filter = "csv (*.csv)|*.csv|txt (*txt)|*.txt|All files (*.*)|*.*";
            ofd_basketcall.AutoUpgradeEnabled = false;
            
            if (ofd_basketcall.ShowDialog() == DialogResult.OK)
            {

                string filepath = ofd_basketcall.FileName;
                basketcall_dt = Program.ConvertCSVtoDataTable(filepath);
                dgv_basket_manage.DataSource = basketcall_dt;

            }


        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




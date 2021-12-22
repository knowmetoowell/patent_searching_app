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
using System.Text.RegularExpressions;


namespace Assignment_Patents_Searching_App
{
    public partial class MainForm : Form
    {
        static string filepath = Directory.GetCurrentDirectory() + "/개인과제data.csv";
      

        public MainForm()
        {

            InitializeComponent();
            DataTable res = Program.ConvertCSVtoDataTable(filepath);

            dgv_patent.DataSource = res;
            dgv_patent.EditMode = DataGridViewEditMode.EditProgrammatically;
            comboBox1.SelectedItem = comboBox1.Items[0];
            lbl_num.Text = "검색된 특허의 수: " + (dgv_patent.Rows.Count - 1).ToString() + "개";
            dgv_patent.Font = new Font("Arial", 10);
            dgv_patent.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);

        }



        private void Txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_search2_Click(sender, e);


            }
        }// Enter 키 입력시 버튼클릭 메소드 실행

        DataTable dt2 = new DataTable();
        private void Btn_search2_Click(object sender, EventArgs e) 
        {
            txt_contents.Text = "";
            DataTable dt = new DataTable();
            dt = Program.ConvertCSVtoDataTable(filepath);

            dt2 = Program.NewTableReturn();
            foreach (DataRow dr in dt.Rows)
            {

                //연산자 없이 그냥 검색
                if (!txt_search.Text.Contains('&') && !txt_search.Text.Contains('|'))
                {
                    if (txt_except.Text.Length == 0)
                    {
                        if (comboBox1.SelectedItem == comboBox1.Items[0])
                        {
                            if (dr[comboBox1.Items[1].ToString()].ToString().Contains(txt_search.Text)
                                || dr[comboBox1.Items[2].ToString()].ToString().Contains(txt_search.Text)
                                || dr[comboBox1.Items[3].ToString()].ToString().Contains(txt_search.Text)
                                || dr[comboBox1.Items[4].ToString()].ToString().Contains(txt_search.Text)
                                || dr[comboBox1.Items[5].ToString()].ToString().Contains(txt_search.Text)
                                || dr[comboBox1.Items[6].ToString()].ToString().Contains(txt_search.Text))
                            {


                                if (txt_except.Text.Length == 0)
                                {
                                    dt2.ImportRow(dr);


                                }
                                else
                                {
                                    if (!dr[comboBox1.Items[1].ToString()].ToString().Contains(txt_except.Text)
                                        && !dr[comboBox1.Items[2].ToString()].ToString().Contains(txt_except.Text)
                                        && !dr[comboBox1.Items[3].ToString()].ToString().Contains(txt_except.Text)
                                        && !dr[comboBox1.Items[4].ToString()].ToString().Contains(txt_except.Text)
                                        && !dr[comboBox1.Items[5].ToString()].ToString().Contains(txt_except.Text)
                                        && !dr[comboBox1.Items[6].ToString()].ToString().Contains(txt_except.Text))
                                    {
                                        dt2.ImportRow(dr);

                                    }

                                }
                                dgv_patent.DataSource = dt2;

                            }
                            else
                            {
                                dgv_patent.DataSource = dt2;
                            }
                        }
                        else if (comboBox1.SelectedItem == comboBox1.Items[1])
                        {
                            if (dr[comboBox1.SelectedItem.ToString()].ToString().Contains(txt_search.Text))
                            {
                                if (txt_except.Text.Length == 0)
                                {
                                    dt2.ImportRow(dr);

                                    dgv_patent.DataSource = dt2;
                                }
                                else
                                {
                                    if (!dr[comboBox1.Items[1].ToString()].ToString().Contains(txt_except.Text))
                                    {
                                        dt2.ImportRow(dr);
                                    }
                                }

                            }
                            else
                            {
                                dgv_patent.DataSource = dt2;
                            }
                        }
                        else if (comboBox1.SelectedItem == comboBox1.Items[2])
                        {
                            if (dr[comboBox1.SelectedItem.ToString()].ToString().Contains(txt_search.Text))
                            {
                                if (txt_except.Text.Length == 0)
                                {
                                    dt2.ImportRow(dr);

                                    dgv_patent.DataSource = dt2;
                                }
                                else
                                {
                                    if (!dr[comboBox1.Items[2].ToString()].ToString().Contains(txt_except.Text))
                                    {
                                        dt2.ImportRow(dr);
                                    }
                                }
                            }
                            else
                            {
                                dgv_patent.DataSource = dt2;
                            }
                        }
                        else if (comboBox1.SelectedItem == comboBox1.Items[3])
                        {
                            if (dr[comboBox1.SelectedItem.ToString()].ToString().Contains(txt_search.Text))
                            {
                                if (txt_except.Text.Length == 0)
                                {
                                    dt2.ImportRow(dr);

                                    dgv_patent.DataSource = dt2;
                                }
                                else
                                {
                                    if (!dr[comboBox1.Items[3].ToString()].ToString().Contains(txt_except.Text))
                                    {
                                        dt2.ImportRow(dr);
                                    }
                                }
                            }
                            else
                            {
                                dgv_patent.DataSource = dt2;
                            }
                        }
                        else if (comboBox1.SelectedItem == comboBox1.Items[4])
                        {
                            if (dr[comboBox1.SelectedItem.ToString()].ToString().Contains(txt_search.Text))
                            {
                                if (txt_except.Text.Length == 0)
                                {
                                    if (txt_except.Text.Length == 0)
                                    {
                                        dt2.ImportRow(dr);

                                        dgv_patent.DataSource = dt2;
                                    }
                                    else
                                    {
                                        if (!dr[comboBox1.Items[4].ToString()].ToString().Contains(txt_except.Text))
                                        {
                                            dt2.ImportRow(dr);
                                        }
                                    }
                                }
                                else
                                {
                                    if (!dr[comboBox1.Items[4].ToString()].ToString().Contains(txt_except.Text))
                                    {
                                        dt2.ImportRow(dr);
                                    }
                                }
                            }
                            else
                            {
                                dgv_patent.DataSource = dt2;
                            }
                        }
                        else if (comboBox1.SelectedItem == comboBox1.Items[5])
                        {
                            if (dr[comboBox1.SelectedItem.ToString()].ToString().Contains(txt_search.Text))
                            {
                                if (txt_except.Text.Length == 0)
                                {
                                    dt2.ImportRow(dr);

                                    dgv_patent.DataSource = dt2;
                                }
                                else
                                {
                                    if (!dr[comboBox1.Items[5].ToString()].ToString().Contains(txt_except.Text))
                                    {
                                        dt2.ImportRow(dr);
                                    }
                                }
                            }
                            else
                            {
                                dgv_patent.DataSource = dt2;
                            }

                        }
                        else if (comboBox1.SelectedItem == comboBox1.Items[6])
                        {
                            if (dr[comboBox1.SelectedItem.ToString()].ToString().Contains(txt_search.Text))
                            {
                                if (txt_except.Text.Length == 0)
                                {
                                    dt2.ImportRow(dr);

                                    dgv_patent.DataSource = dt2;
                                }
                                else
                                {
                                    if (!dr[comboBox1.Items[6].ToString()].ToString().Contains(txt_except.Text))
                                    {
                                        dt2.ImportRow(dr);
                                    }
                                }
                            }
                            else
                            {
                                dgv_patent.DataSource = dt2;
                            }

                        }
                        else if (comboBox1.SelectedItem == comboBox1.Items[7])
                        {
                            if (dr[comboBox1.Items[3].ToString()].ToString().Contains(txt_search.Text)
                                || dr[comboBox1.Items[4].ToString()].ToString().Contains(txt_search.Text))
                            {
                                if (txt_except.Text.Length == 0)
                                {
                                    dt2.ImportRow(dr);

                                    dgv_patent.DataSource = dt2;
                                }
                                else
                                {
                                    if (!dr[comboBox1.Items[3].ToString()].ToString().Contains(txt_except.Text)
                                        && !dr[comboBox1.Items[4].ToString()].ToString().Contains(txt_except.Text))
                                    {
                                        dt2.ImportRow(dr);
                                    }
                                }
                            }
                            else
                            {
                                dgv_patent.DataSource = dt2;
                            }

                        }
                    }

                    else
                    {
                        if (txt_except.Text.Contains('&') || txt_except.Text.Contains('|'))
                        {
                            MessageBox.Show("제외할 단어에는 AND(&)연산자 및 OR(|)연산자를 쓸 수 없습니다.");
                            break;
                        }
                        else
                        {
                            bool[] item_except = new bool[7];
                            for (int x = 1; x < item_except.Length; x++)
                            {
                                item_except[x] = dr[comboBox1.Items[x].ToString()].ToString().Contains(txt_except.Text.Trim());
                            }
                            if (!item_except[1]
                                && !item_except[2]
                                && !item_except[3]
                                && !item_except[4]
                                && !item_except[5]
                                && !item_except[6])
                            {
                                if (comboBox1.SelectedItem == comboBox1.Items[0])
                                {
                                    if (dr[comboBox1.Items[1].ToString()].ToString().Contains(txt_search.Text)
                                        || dr[comboBox1.Items[2].ToString()].ToString().Contains(txt_search.Text)
                                        || dr[comboBox1.Items[3].ToString()].ToString().Contains(txt_search.Text)
                                        || dr[comboBox1.Items[4].ToString()].ToString().Contains(txt_search.Text)
                                        || dr[comboBox1.Items[5].ToString()].ToString().Contains(txt_search.Text)
                                        || dr[comboBox1.Items[6].ToString()].ToString().Contains(txt_search.Text))
                                    {


                                        if (txt_except.Text.Length == 0)
                                        {
                                            dt2.ImportRow(dr);


                                        }
                                        else
                                        {
                                            if (!dr[comboBox1.Items[1].ToString()].ToString().Contains(txt_except.Text)
                                                && !dr[comboBox1.Items[2].ToString()].ToString().Contains(txt_except.Text)
                                                && !dr[comboBox1.Items[3].ToString()].ToString().Contains(txt_except.Text)
                                                && !dr[comboBox1.Items[4].ToString()].ToString().Contains(txt_except.Text)
                                                && !dr[comboBox1.Items[5].ToString()].ToString().Contains(txt_except.Text)
                                                && !dr[comboBox1.Items[6].ToString()].ToString().Contains(txt_except.Text))
                                            {
                                                dt2.ImportRow(dr);

                                            }

                                        }
                                        dgv_patent.DataSource = dt2;

                                    }
                                    else
                                    {
                                        dgv_patent.DataSource = dt2;
                                    }
                                }
                                else if (comboBox1.SelectedItem == comboBox1.Items[1])
                                {
                                    if (dr[comboBox1.SelectedItem.ToString()].ToString().Contains(txt_search.Text))
                                    {
                                        if (txt_except.Text.Length == 0)
                                        {
                                            dt2.ImportRow(dr);

                                            dgv_patent.DataSource = dt2;
                                        }
                                        else
                                        {
                                            if (!dr[comboBox1.Items[1].ToString()].ToString().Contains(txt_except.Text))
                                            {
                                                dt2.ImportRow(dr);
                                            }
                                        }

                                    }
                                    else
                                    {
                                        dgv_patent.DataSource = dt2;
                                    }
                                }
                                else if (comboBox1.SelectedItem == comboBox1.Items[2])
                                {
                                    if (dr[comboBox1.SelectedItem.ToString()].ToString().Contains(txt_search.Text))
                                    {
                                        if (txt_except.Text.Length == 0)
                                        {
                                            dt2.ImportRow(dr);

                                            dgv_patent.DataSource = dt2;
                                        }
                                        else
                                        {
                                            if (!dr[comboBox1.Items[2].ToString()].ToString().Contains(txt_except.Text))
                                            {
                                                dt2.ImportRow(dr);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        dgv_patent.DataSource = dt2;
                                    }
                                }
                                else if (comboBox1.SelectedItem == comboBox1.Items[3])
                                {
                                    if (dr[comboBox1.SelectedItem.ToString()].ToString().Contains(txt_search.Text))
                                    {
                                        if (txt_except.Text.Length == 0)
                                        {
                                            dt2.ImportRow(dr);

                                            dgv_patent.DataSource = dt2;
                                        }
                                        else
                                        {
                                            if (!dr[comboBox1.Items[3].ToString()].ToString().Contains(txt_except.Text))
                                            {
                                                dt2.ImportRow(dr);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        dgv_patent.DataSource = dt2;
                                    }
                                }
                                else if (comboBox1.SelectedItem == comboBox1.Items[4])
                                {
                                    if (dr[comboBox1.SelectedItem.ToString()].ToString().Contains(txt_search.Text))
                                    {
                                        if (txt_except.Text.Length == 0)
                                        {
                                            if (txt_except.Text.Length == 0)
                                            {
                                                dt2.ImportRow(dr);

                                                dgv_patent.DataSource = dt2;
                                            }
                                            else
                                            {
                                                if (!dr[comboBox1.Items[4].ToString()].ToString().Contains(txt_except.Text))
                                                {
                                                    dt2.ImportRow(dr);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (!dr[comboBox1.Items[4].ToString()].ToString().Contains(txt_except.Text))
                                            {
                                                dt2.ImportRow(dr);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        dgv_patent.DataSource = dt2;
                                    }
                                }
                                else if (comboBox1.SelectedItem == comboBox1.Items[5])
                                {
                                    if (dr[comboBox1.SelectedItem.ToString()].ToString().Contains(txt_search.Text))
                                    {
                                        if (txt_except.Text.Length == 0)
                                        {
                                            dt2.ImportRow(dr);

                                            dgv_patent.DataSource = dt2;
                                        }
                                        else
                                        {
                                            if (!dr[comboBox1.Items[5].ToString()].ToString().Contains(txt_except.Text))
                                            {
                                                dt2.ImportRow(dr);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        dgv_patent.DataSource = dt2;
                                    }

                                }
                                else if (comboBox1.SelectedItem == comboBox1.Items[6])
                                {
                                    if (dr[comboBox1.SelectedItem.ToString()].ToString().Contains(txt_search.Text))
                                    {
                                        if (txt_except.Text.Length == 0)
                                        {
                                            dt2.ImportRow(dr);

                                            dgv_patent.DataSource = dt2;
                                        }
                                        else
                                        {
                                            if (!dr[comboBox1.Items[6].ToString()].ToString().Contains(txt_except.Text))
                                            {
                                                dt2.ImportRow(dr);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        dgv_patent.DataSource = dt2;
                                    }

                                }
                                else if (comboBox1.SelectedItem == comboBox1.Items[7])
                                {
                                    if (dr[comboBox1.Items[3].ToString()].ToString().Contains(txt_search.Text)
                                        || dr[comboBox1.Items[4].ToString()].ToString().Contains(txt_search.Text))
                                    {
                                        if (txt_except.Text.Length == 0)
                                        {
                                            dt2.ImportRow(dr);

                                            dgv_patent.DataSource = dt2;
                                        }
                                        else
                                        {
                                            if (!dr[comboBox1.Items[3].ToString()].ToString().Contains(txt_except.Text)
                                                && !dr[comboBox1.Items[4].ToString()].ToString().Contains(txt_except.Text))
                                            {
                                                dt2.ImportRow(dr);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        dgv_patent.DataSource = dt2;
                                    }

                                }
                            }

                        }
                    }


                }
                //and 연산자
                else if (txt_search.Text.Contains('&') && !txt_search.Text.Contains('|'))
                {
                    comboBox1.SelectedItem = comboBox1.Items[0];
                    bool[] item_except = new bool[7];
                    for (int x = 1; x < item_except.Length; x++)
                    {
                        item_except[x] = dr[comboBox1.Items[x].ToString()].ToString().Contains(txt_except.Text.Trim());
                    }

                    string[] search_and = txt_search.Text.Split('&'); // 휴대용 & 김민석
                    bool[] itemi_andj = new bool[search_and.Length * 6]; // 12짜리 bool array
                    int count = 0;
                    for (int i = 1; i < 7; i++) // 6번 돌아
                    {
                        for (int j = 0; j < search_and.Length; j++) // 2번 돌아
                        {
                            itemi_andj[count] = dr[comboBox1.Items[i].ToString()].ToString().Contains(search_and[j].Trim());
                            count++; //12개짜리 배열
                        }
                    }
                    if (comboBox1.SelectedItem == comboBox1.Items[0])
                    {
                        if (txt_except.Text.Length == 0)
                        {
                            bool TF = false;
                            for (int i = 0; i < search_and.Length; i++)
                            {
                                TF = false;
                                for (int j = 0; j < 6; j++)
                                {
                                    if (itemi_andj[search_and.Length * j + i])
                                    {
                                        TF = true;
                                        break;
                                    }
                                }
                                if (!TF)
                                {
                                    break;
                                }
                            }
                            if (TF)
                            {
                                dt2.ImportRow(dr);
                            }
                            dgv_patent.DataSource = dt2;
                        }
                        else
                        {
                            if (txt_except.Text.Contains('&') || txt_except.Text.Contains('|'))
                            {
                                MessageBox.Show("제외할 단어에는 AND(&)연산자 및 OR(|)연산자를 쓸 수 없습니다.");
                                break;
                            }
                            else if (!item_except[1] && !item_except[2] && !item_except[3] && !item_except[4] && !item_except[5] && !item_except[6])
                            {
                                bool TF = false;
                                for (int i = 0; i < search_and.Length; i++)
                                {
                                    TF = false;
                                    for (int j = 0; j < 6; j++)
                                    {
                                        if (itemi_andj[search_and.Length * j + i])
                                        {
                                            TF = true;
                                            break;
                                        }
                                    }
                                    if (!TF)
                                    {
                                        break;
                                    }
                                }
                                if (TF)
                                {
                                    dt2.ImportRow(dr);
                                }
                                dgv_patent.DataSource = dt2;
                            }

                        }
                    }

                }
                // or 연산자
                else if (txt_search.Text.Contains('|') && !txt_search.Text.Contains('&'))
                {
                    comboBox1.SelectedItem = comboBox1.Items[0];
                    bool[] item_except = new bool[7];
                    for (int x = 1; x < item_except.Length; x++)
                    {
                        item_except[x] = dr[comboBox1.Items[x].ToString()].ToString().Contains(txt_except.Text.Trim());
                    }
                    string[] search_or = txt_search.Text.Split('|');
                    bool[] itemi_orj = new bool[search_or.Length * 6];
                    int count = 0;
                    for (int i = 1; i < 7; i++)
                    {
                        for (int j = 0; j < search_or.Length; j++)
                        {
                            itemi_orj[count] = dr[comboBox1.Items[i].ToString()].ToString().Contains(search_or[j].Trim());
                            count++;
                        }
                    }

                    if (comboBox1.SelectedItem == comboBox1.Items[0])
                    {

                        for (int i = 0; i < itemi_orj.Length; i++)
                        {
                            if (itemi_orj[i])
                            {
                                if (txt_except.Text.Length == 0)
                                {
                                    dt2.ImportRow(dr);
                                    dgv_patent.DataSource = dt2;
                                    break;
                                }
                                else
                                {
                                    if (txt_except.Text.Contains("&") || txt_except.Text.Contains("|"))
                                    {
                                        MessageBox.Show("제외할 단어에는 AND(&)연산자 및 OR(|)연산자를 쓸 수 없습니다.");
                                    }
                                    else
                                    {
                                        if (!item_except[1] && !item_except[2] && !item_except[3] && !item_except[4] && !item_except[5] && !item_except[6])
                                        {
                                            dt2.ImportRow(dr);
                                            dgv_patent.DataSource = dt2;
                                            break;
                                        }
                                    }
                                    
                                }

                            }


                        }

                    }


                }

                else if (txt_search.Text.Contains('|') && txt_search.Text.Contains('&'))
                {

                    MessageBox.Show("And(&) 연산자와 OR(|)연산자를 동시에 쓸 수 없습니다.");

                }
            }
            lbl_num.Text = "검색된 특허의 수: " + (dgv_patent.Rows.Count - 1).ToString() + "개";

        }// 검색기능

        public static DataTable dtdt = Program.NewTableReturn();
        // 장바구니에 추가 , Cell Contents 뛰우기
        private void Dgv_patent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = Program.ConvertCSVtoDataTable(filepath);

            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                DataRow id = dt.Rows[e.RowIndex];
                dtdt.ImportRow(id);
            }
            else if (e.RowIndex >= 0)
            {
                string contents = dgv_patent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                
                txt_contents.Text = contents;
            }
            else if (e.RowIndex == -1 && e.ColumnIndex == 0)
            {
                MessageBox.Show("장바구니 컬럼으로 정렬할 수 없습니다.");
            }

        }
        private void Btn_basket_form_Click(object sender, EventArgs e) //장바구니 관리
        {
            form_basket basket = new form_basket();
            basket.Show();
        }
        private void Txt_except_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_search2_Click(sender, e);

            }
        }// Enter 키 입력시 버튼클릭 메소드 실행
        private void Btn_help_Click(object sender, EventArgs e) // 도움말 폼 열기
        {
            Help hp = new Help();
            hp.Show();
        }
        private void Btn_google_search_Click(object sender, EventArgs e)
        {

            if (txt_search.Text.Length != 0 && txt_except.Text.Length == 0)
            {
                if (txt_search.Text.Contains("&") && !txt_search.Text.Contains('|'))
                {
                    string[] txt_search_and_array = txt_search.Text.Split('&');
                    string[] google_and_search = new string[txt_search_and_array.Length];

                    string google_and_path = "https://patents.google.com/?q=";
                    for (int i = 0; i < txt_search_and_array.Length; i++)
                    {
                        google_and_path = google_and_path + txt_search_and_array[i].Trim() + "&q=";
                    }

                    System.Diagnostics.Process.Start(google_and_path.Remove(google_and_path.Length - 3));
                }
                else if (txt_search.Text.Contains('|') && !txt_search.Text.Contains('&'))
                {
                    string[] txt_search_or_array = txt_search.Text.Split('|');
                    string[] google_or_search = new string[txt_search_or_array.Length];
                    string google_or_path = "https://patents.google.com/?q=";
                    for (int i = 0; i < txt_search_or_array.Length; i++)
                    {
                        google_or_path = google_or_path + txt_search_or_array[i].Trim() + ",";
                    }
                    System.Diagnostics.Process.Start(google_or_path.Remove(google_or_path.Length - 1));
                }
                else if (txt_search.Text.Contains('&') && txt_search.Text.Contains('|'))
                {
                    MessageBox.Show("And(&) 연산자와 OR(|)연산자를 동시에 쓸 수 없습니다.");
                }
                else
                {
                    System.Diagnostics.Process.Start("https://patents.google.com/?q=" + txt_search.Text + "&oq=" + txt_search.Text);
                }

            }
            else if (txt_except.Text.Length != 0)
            {
                MessageBox.Show("구글 검색에서는 except연산자를 사용할 수 없습니다.");
            }
            else if (txt_search.Text.Length == 0)
            {
                MessageBox.Show("검색어를 입력하세요.");
            }

        }
    }
}




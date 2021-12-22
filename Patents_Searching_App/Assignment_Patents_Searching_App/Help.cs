using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Patents_Searching_App
{
    public partial class Help : Form
    {
        public Help()
        {
            
            InitializeComponent();
            comboBox1.SelectedItem = comboBox1.Items[0];
            txt_search.Text = "검색할 단어 및 문장을 입력하세요.";
            txt_except.Text = "제외할 단어 및 문장을 입력하세요.";
            lbl_search.Text = "기본 검색기능: 찾고자 하는 단어 또는 문장을 상단의 검색창에 입력 후 "+ Environment.NewLine + "                   'Search' 버튼 클릭 또는 Enter 키를 누르면 입력된 단어를 포함하는 특허를 가지고 옵니다.";
            lbl_and.Text = @"And('&&') 연산자: '&&'기호를 분기로 양옆에 있는 단어를 동시에 포함하고 있는 특허를 검색합니다. Or(|)기호와 함께 쓸 수 없습니다.";
            lbl_or.Text = "Or('|') 연산자: '|'기호를 분기로 양옆에 있는 단어를 하나라도 포함하고 있는 특허를 검색합니다. And(&&)기호와 함께 쓸 수 없습니다.";
            lbl_searchedNo.Text = "검색된 특허의 수: 현재 검색된 특허들의 총 개수를 나타냅니다.";
            lbl_combo.Text = "열별 검색기능: 좌상단의 콤보박스에서 검색하고자 하는 열을 선택할 수 있습니다";
            lbl_excepthelp.Text = "Except 연산자: 검색시 제외하고 싶은 단어를 하단의 검색창에 입력할 수 있습니다." + Environment.NewLine + "                      제외할 단어에서는 다른 연산자를 사용할 수 없습니다.";
            lbl_contentshelp.Text = "Contents Box: 특허의 특정 셀을 클릭시 셀의 내용을 출력합니다.";
            lbl_google.Text = "Google Patents 검색: 내 자료에는 없는 특허를 검색하기 위하여 http://patents.google.com에서 검색합니다." + Environment.NewLine + "                               마찬가지로 And와 Or연산자를 쓸 수 있으나 동시에 쓰는 것은 불가능하고, Except연산자는 제한됩니다. ";
        }
    }
}

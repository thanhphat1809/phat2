using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DienThoai;
namespace Three_Layer
{
    public partial class GUI_MonHoc : Form
    {
        public BLL_Dien_Thoai bll_DienThoai;
        public GUI_MonHoc()
        {
            InitializeComponent();
            bll_DienThoai = new BLL_Dien_Thoai();
        }

        private void GUI_MonHoc_Load(object sender, EventArgs e)
        {
            gv_MonHoc.DataSource = bll_DienThoai.getMonHoc();

        }

        private void gv_MonHoc_Click(object sender, EventArgs e)
        {
            if (gv_MonHoc.SelectedCells.Count > 0)
            {
                int selectedrowindex = gv_MonHoc.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = gv_MonHoc.Rows[selectedrowindex];
                txt_MaSV.Text = Convert.ToString(selectedRow.Cells[0].Value);
                txt_Ho.Text = Convert.ToString(selectedRow.Cells[1].Value);
                nup_SoTC.Value = Convert.ToDecimal(selectedRow.Cells[2].Value);

            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }
    }
}

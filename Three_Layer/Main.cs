using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BLL_DienThoai;
using DTO_DienThoai;

namespace Three_Layer
{
    public partial class Main : Form
    {
        public BLL_Dien_Thoai bll_DienThoai;
        public Main()
        {
            InitializeComponent();
            bll_DienThoai = new BLL_Dien_Thoai();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gv_SinhVien.DataSource = bll_DienThoai.getDienThoai();
            cbx_Khoa.DataSource = bll_DienThoai.getKhoa();
            cbx_Khoa.ValueMember = "maKH";
            cbx_Khoa.DisplayMember = "tenKH"; 
            cbx_MaLop.DataSource = bll_DienThoai.getLop();
            cbx_MaLop.ValueMember = "maLop";
            cbx_MaLop.DisplayMember = "tenlop";
        }

        private void gv_SinhVien_Click(object sender, EventArgs e)
        {
            if (gv_SinhVien.SelectedCells.Count > 0)
            {
                int selectedrowindex = gv_SinhVien.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = gv_SinhVien.Rows[selectedrowindex];
                txt_MaSV.Text = Convert.ToString(selectedRow.Cells[0].Value);
                txt_Ho.Text = Convert.ToString(selectedRow.Cells[1].Value);
                txt_Ten.Text = Convert.ToString(selectedRow.Cells[2].Value);
                dtp_NgaySinh.Value = Convert.ToDateTime(selectedRow.Cells[3].Value);
                if (Convert.ToString(selectedRow.Cells[4].Value).Trim().ToLower() == "Nam".ToLower())
                {
                    rdb_Nam.Checked = true;
                }
                else
                {
                    rdb_Nu.Checked = true;
                }

                cbx_MaLop.SelectedValue = Convert.ToString(selectedRow.Cells[5].Value);
                cbx_Khoa.SelectedValue = Convert.ToString(selectedRow.Cells[6].Value);
            }

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }
    }
}

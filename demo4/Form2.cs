using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace demo4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-SPP3VQO\SQL;Initial Catalog=DiemSinhVien;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        private void Sinhvien()
        {
            da = new SqlDataAdapter("select * from SinhVien", conn);
            da.Fill(ds, "tsinhvien");
            dgSinhVien.DataSource = ds.Tables["tsinhvien"];
            // Đặt tiêu đề cột
            dgSinhVien.Columns["maSV"].HeaderText = "Mã Sinh Viên ";
            dgSinhVien.Columns["hoTen"].HeaderText = "Họ Tên ";
            dgSinhVien.Columns["ngaySinh"].HeaderText = "Ngày Sinh ";
            dgSinhVien.Columns["gioiTinh"].HeaderText = "Giới Tính ";
            dgSinhVien.Columns["noiSinh"].HeaderText = "Nơi Sinh ";
            dgSinhVien.Columns["maLop"].HeaderText = "Mã Lớp ";
            // Định độ rộng cột
            dgSinhVien.Columns["maSV"].Width = 100;
            dgSinhVien.Columns["hoTen"].Width = 200;
            dgSinhVien.Columns["ngaySinh"].Width = 100;
            dgSinhVien.Columns["gioiTinh"].Width = 100;
            dgSinhVien.Columns["noiSinh"].Width = 100;
            dgSinhVien.Columns["maLop"].Width = 100;
        }

        private void dgSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgSinhVien.SelectedRows[0];
            //  this.dgDiem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // this.dgDiem.MultiSelect = false;
            KhungMasv.Text = r.Cells["maSV"].Value.ToString();
            KhungHoTen.Text = r.Cells["hoTen"].Value.ToString();
            dtNgaysinh.Text = r.Cells["ngaySinh"].Value.ToString();

            if (r.Cells["gioiTinh"].Value.ToString() == "Nam")

            {
                rdbNam.Checked = true;
            }
            else
            {
                rdbNu.Checked = true;
            }
        

            
            KhungNoiSinh.Text = r.Cells["noiSinh"].Value.ToString();
            KhungMaLop.Text = r.Cells["maLop"].Value.ToString();


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Sinhvien();
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataRow r = ds.Tables["tsinhvien"].NewRow();
            r["maSV"] = KhungMasv.Text;
            r["hoten"] = KhungHoTen.Text;
            r["ngaySinh"] = dtNgaysinh.Text;
            //r["gioiTinh"] = KhungGioitinh.Text;
            if (rdbNu.Checked == true)
            {
                r["gioiTinh"] = "Nữ";
            }
            else
            {
                r["gioiTinh"] = "Nam";
            }
            r["noiSinh"] = KhungNoiSinh.Text;
            r["maLop"] = KhungMaLop.Text;
            ds.Tables["tsinhvien"].Rows.Add(r);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
              DataGridViewRow r = dgSinhVien.SelectedRows[0];
                dgSinhVien.BeginEdit(true);
                r.Cells["maSV"].Value = KhungMasv.Text;
                r.Cells["hoTen"].Value = KhungHoTen.Text;
                r.Cells["ngaySinh"].Value = dtNgaysinh.Text;
            // r.Cells["gioiTinh"].Value = KhungGioitinh.Text;
            if (rdbNu.Checked == true)
            {
                r.Cells["gioiTinh"].Value = "Nữ";
            }
            else
            {
                r.Cells["gioiTinh"].Value = "Nam";
            }
            r.Cells["noiSinh"].Value = KhungNoiSinh.Text;
                r.Cells["maLop"].Value = KhungMaLop.Text;
                dgSinhVien.EndEdit();
                MessageBox.Show("Đã Cập Nhật !", "Thông Báo ");
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgSinhVien.SelectedRows[0];
            dgSinhVien.Rows.Remove(r);
        }

        private void btnhoatac_Click(object sender, EventArgs e)
        {
            ds.Tables["tsinhvien"].RejectChanges();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(ds, "tsinhvien");
                MessageBox.Show("Đã lưu ", "Thông Báo ");
            }
            catch
            {
                MessageBox.Show("Mã môn học không tồn tại ", "Thông Báo ");
                return;
            }
        }

        private void btnKhoitao_Click(object sender, EventArgs e)
        {

            KhungHoTen.Text = "";
            KhungMaLop.Text = "";
            KhungMasv.Text = "";
            KhungNoiSinh.Text = "";
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}

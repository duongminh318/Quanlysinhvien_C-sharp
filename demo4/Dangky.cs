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
    public partial class Dangky : Form
    {
        public Dangky()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-SPP3VQO\SQL;Initial Catalog=DiemSinhVien;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds = new DataSet();


        private void User()
        {
            da = new SqlDataAdapter("select * from NguoiDung", conn);
            da.Fill(ds, "tUser");
            dgDSnguoidung.DataSource = ds.Tables["tUser"];
            // Đặt tiêu đề cột
            dgDSnguoidung.Columns["taiKhoan"].HeaderText = "Tai Khoan";
            dgDSnguoidung.Columns["passW"].HeaderText = "Nguoi Dung ";
            // Định độ rộng cột
            dgDSnguoidung.Columns["taiKhoan"].Width = 250;
            dgDSnguoidung.Columns["passW"].Width = 200;       
        }

        private void Dangky_Load(object sender, EventArgs e)
        {
           User();
           SqlCommandBuilder cb = new SqlCommandBuilder(da);
            dgDSnguoidung.Columns["passW"].Visible = false;

        }

        private void dgDSnguoidung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgDSnguoidung.SelectedRows[0];
            khungten.Text = r.Cells["taiKhoan"].Value.ToString();
            khungmatkhau.Text = r.Cells["passW"].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
           
            DataRow r = ds.Tables["tUser"].NewRow();
            r["taiKhoan"] = khungten.Text;
            r["passW"] = khungmatkhau.Text;
            
            ds.Tables["tUser"].Rows.Add(r);
            
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgDSnguoidung.SelectedRows[0];
            dgDSnguoidung.BeginEdit(true);
            r.Cells["taiKhoan"].Value = khungten.Text;
            r.Cells["passW"].Value = khungmatkhau.Text;
            dgDSnguoidung.EndEdit();
            MessageBox.Show("Da cap nhat!", "Thong bao");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgDSnguoidung.SelectedRows[0];
            dgDSnguoidung.Rows.Remove(r);
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(ds, "tUser");
                MessageBox.Show("Đã Lưu ", "Thông Báo ");
            }
            catch
            {
                MessageBox.Show("Tài Khoản Đã Trùng Vui Lòng Nhập Lại  ", "Thông Báo ");
                return;
            }
        }
    }
}

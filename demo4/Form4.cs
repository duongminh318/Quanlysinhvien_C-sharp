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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-SPP3VQO\SQL;Initial Catalog=DiemSinhVien;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds = new DataSet();

        private void Monhoc()
        {
            da = new SqlDataAdapter("select * from MonHP", conn);
            da.Fill(ds, "tsinhvien");
            dgMonHoc.DataSource = ds.Tables["tsinhvien"];
            // Đặt tiêu đề cột
            dgMonHoc.Columns["maMon"].HeaderText = "Mã Môn HọC";
            dgMonHoc.Columns["tenMon"].HeaderText = "Tên Môn ";
            dgMonHoc.Columns["soTinChi"].HeaderText = "Số Tín Chỉ " +
                " ";
            dgMonHoc.Columns["maHk"].HeaderText = "Học Kỳ  ";

            // Định độ rộng cột
            dgMonHoc.Columns["maMon"].Width = 200;
            dgMonHoc.Columns["tenMon"].Width = 300;
            dgMonHoc.Columns["soTinChi"].Width = 200;
            dgMonHoc.Columns["maHk"].Width = 200;
           
        }

        private void dgMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgMonHoc.SelectedRows[0];
            Khungmamon.Text = r.Cells["maMon"].Value.ToString();
            khungtenmon.Text = r.Cells["tenMon"].Value.ToString();
            khungsochi.Text = r.Cells["soTinChi"].Value.ToString();
            khunghocky.Text = r.Cells["maHk"].Value.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
                Monhoc();
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
            
        }
        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
        private void btnkhoitao_Click(object sender, EventArgs e)
        {
            khungtenmon.Text = "";
            Khungmamon.Text = "";
            khunghocky.Text = "";
            khungsochi.Text = "";
        }    
        private void btnthem_Click_1(object sender, EventArgs e)
        {
            DataRow r = ds.Tables["tsinhvien"].NewRow();
            r["tenMon"] = khungtenmon.Text;
            r["maMon"] = Khungmamon.Text;
            r["maHk"] = khunghocky.Text;
            r["soTinChi"] = khungsochi.Text;
            ds.Tables["tsinhvien"].Rows.Add(r);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgMonHoc.SelectedRows[0];
            dgMonHoc.Rows.Remove(r);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgMonHoc.SelectedRows[0];
            dgMonHoc.BeginEdit(true);
            r.Cells["maMon"].Value = Khungmamon.Text;
            r.Cells["tenMon"].Value = khungtenmon.Text;
            r.Cells["soTinChi"].Value = khungsochi.Text;
            r.Cells["maHk"].Value = khunghocky.Text;
            dgMonHoc.EndEdit();
            MessageBox.Show("Da cap nhat!", "Thong bao");
        }

        private void btnhoantac_Click(object sender, EventArgs e)
        {

            ds.Tables["tsinhvien"].RejectChanges();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(ds, "tsinhvien");
                MessageBox.Show("Da Luu", "Thong bao");
            }
            catch
            {
                return;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

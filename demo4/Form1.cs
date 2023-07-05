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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-SPP3VQO\SQL;Initial Catalog=DiemSinhVien;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds = new DataSet();

        private void Diem()
        {
            da = new SqlDataAdapter("select * from DiemHP", conn);
            da.Fill(ds, "tdiem");
            dgDiem.DataSource = ds.Tables["tdiem"];
            // Đặt tiêu đề cột
            dgDiem.Columns["maSV"].HeaderText = "Mã Sinh Viên ";
            dgDiem.Columns["maMon"].HeaderText = "Mã Môn Học ";
            dgDiem.Columns["diemLan1"].HeaderText = "Điểm Thường Xuyên ";
            dgDiem.Columns["diemLan2"].HeaderText = "Điểm Thi ";
            //dgDiem.Columns["lanThi"].HeaderText = "So lan thi";

            // Định độ rộng cột
            dgDiem.Columns["maSV"].Width = 200;
            dgDiem.Columns["maMon"].Width = 200;
            dgDiem.Columns["diemLan1"].Width = 200;
            dgDiem.Columns["diemLan2"].Width = 200;
          //  dgDiem.Columns["lanThi"].Width = 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Diem();
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
         
        }

        private void dgDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgDiem.SelectedRows[0];
            //  this.dgDiem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // this.dgDiem.MultiSelect = false;
            KhungMaMH.Text = r.Cells["maMon"].Value.ToString();
            KhungMaSV.Text = r.Cells["maSV"].Value.ToString();
            DiemLan1.Text = r.Cells["diemLan1"].Value.ToString();
            DiemLan2.Text = r.Cells["diemLan2"].Value.ToString();

            float d1 = float.Parse(DiemLan1.Text);
            float d2 = float.Parse(DiemLan2.Text);
            float tb = (d1 + d2) / 2;
            lblDTB.Text =tb.ToString();
           
            
            //.Text = r.Cells["diemLan2"].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            DataRow r = ds.Tables["tDiem"].NewRow();
            r["maSV"] = KhungMaSV.Text;
            r["maMon"] = KhungMaMH.Text;
            r["diemLan1"] = DiemLan1.Text;
            r["diemLan2"] = DiemLan2.Text;
          //  r["lanThi"] = KhungLanthi.Text;
            ds.Tables["tDiem"].Rows.Add(r);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgDiem.SelectedRows[0];
            dgDiem.BeginEdit(true);
            r.Cells["maSV"].Value = KhungMaSV.Text;
            r.Cells["maMon"].Value = KhungMaMH.Text;
            r.Cells["diemLan1"].Value = DiemLan1.Text;
            r.Cells["diemLan2"].Value = DiemLan2.Text;
           // r.Cells["lanThi"].Value = KhungMaMH.Text;
            dgDiem.EndEdit();
            MessageBox.Show("Đã Cập Nhật !", "Thông báo ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgDiem.SelectedRows[0];
            dgDiem.Rows.Remove(r);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            ds.Tables["tDiem"].RejectChanges();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(ds, "tDiem");
                MessageBox.Show("Đã Lưu ", "Thông báo" +
                    "");
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

        private void btnreset_Click(object sender, EventArgs e)
        {
            KhungMaMH.Text = "";
            KhungMaSV.Text = "";
            DiemLan1.Text = "";
            DiemLan2.Text = "";
            lblDTB.Text = "";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}

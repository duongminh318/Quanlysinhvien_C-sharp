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
    public partial class Form3 : Form
    {
        public Form3()
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
            // Định độ rộng cột
            dgDiem.Columns["maSV"].Width = 300;
            dgDiem.Columns["maMon"].Width = 300;
            dgDiem.Columns["diemLan1"].Width = 200;
            dgDiem.Columns["diemLan2"].Width = 200;
        }
       
        private void Form3_Load(object sender, EventArgs e)
        {
           

        }
        
        public void loadTimkiem()
        {               
                da = new SqlDataAdapter("select * from DiemHP where maSV like '%" + txtTim.Text + "%'", conn);
                da.Fill(ds, "tdiem1");               
                dgDiem.DataSource = ds.Tables["tdiem1"];           
        }
        

        private void btnTracuu_Click(object sender, EventArgs e)
        {
                loadTimkiem();                              
        }

        private void btnall_Click(object sender, EventArgs e)
        {
            Diem();
        }

        

    }
}

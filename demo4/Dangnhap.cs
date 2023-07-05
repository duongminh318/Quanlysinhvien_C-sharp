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
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection con= new SqlConnection(@"Data Source=DESKTOP-SPP3VQO\SQL;Initial Catalog=DiemSinhVien;Integrated Security=True");
            try
            {
                con.Open();
                string tk = txtuser.Text;
                string mk = txtpass.Text;
                string sql = "select *From NguoiDung where taiKhoan='"+txtuser.Text+"'and passW='"+txtpass.Text+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dta = cmd.ExecuteReader();
                if(dta.Read()==true)
                {
                    MessageBox.Show("Đăng Nhập Thành Công ");
                    Form Home = new Home();
                    Home.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại ");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi Đăng Nhập " );

            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiTraSua
{
    public partial class QuanLyKhach : Form
    {
        public QuanLyKhach()
        {
            InitializeComponent();
        }
        ClassKhachHang kh = new ClassKhachHang();
        MY_DB mydb = new MY_DB();
        
        public void reload()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM KhachHang", mydb.getConnection);
            data_gridview.ReadOnly = true;
            data_gridview.RowTemplate.Height = 80;
            data_gridview.DataSource = kh.getKH(command);
            data_gridview.AllowUserToAddRows = false;
            data_gridview.Columns[0].HeaderText = "Mã Khách Hàng";
            data_gridview.Columns[1].HeaderText = "Tên Khách Hàng";
            data_gridview.Columns[2].HeaderText = "Địa chỉ";
            data_gridview.Columns[3].HeaderText = "Số điện thoại";


        }

        private void QuanLyKhach_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string makh = txt_makh.Text;
            string name = txt_tennv.Text;
            string dchi = txt_dc.Text;
            string phone = txt_sdt.Text;

           if (verif())
            {
                if (!kh.NVExist(makh))
                {

                    if (kh.insertKH(makh, name,dchi, phone))
                    {

                        MessageBox.Show("Thành công! Hội viên đã được thêm.", "add KH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra! Chưa thêm được", "add KH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Mã hội viên đã tồn tại.", "add KH", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("empty fieds", "add KH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            bool verif()
            {
                if ((txt_makh.Text.Trim() == "")
                    || (txt_tennv.Text.Trim() == "")
                    || (txt_sdt.Text.Trim() == "")
                    || (txt_dc.Text.Trim() == ""))
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }

            reload();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string makh = txt_makh.Text;
            string name = txt_tennv.Text;
            string dchi = txt_dc.Text;
            string phone = txt_sdt.Text;

            if (verif())
            {
                

                    if (kh.updateKH(makh, name, dchi, phone))
                    {

                        MessageBox.Show("Thành công! Thông tin hội viên đã được cập nhật.", "update KH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra! Chưa cập nhật được.", "update KH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
                
            }
            else
            {
                MessageBox.Show("empty fieds", "update KH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            bool verif()
            {
                if ((txt_makh.Text.Trim() == "")
                    || (txt_tennv.Text.Trim() == "")
                    || (txt_sdt.Text.Trim() == "")
                    || (txt_dc.Text.Trim() == ""))
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }

            reload();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string Makh = txt_makh.Text;
                if ((MessageBox.Show("Bạn có chắc chắn xóa hội viên này không?", "delete phong", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (kh.deleteKH(Makh))
                    {
                        MessageBox.Show("Thành công! Hội viên đã được xóa.", "delete phong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_makh.Text = "";
                        txt_tennv.Text = "";
                        
                        txt_sdt.Text = "";
                        txt_dc.Text = "";
                       
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra! Hội viên chưa được xóa.", "delete phong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập mã hội viên.", "delete phong", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            reload();
        }

        private void data_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_makh.Text = data_gridview.CurrentRow.Cells[0].Value.ToString();
            txt_tennv.Text = data_gridview.CurrentRow.Cells[1].Value.ToString(); ;
            txt_dc.Text = data_gridview.CurrentRow.Cells[2].Value.ToString();
            txt_sdt.Text = data_gridview.CurrentRow.Cells[3].Value.ToString();
            

        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txt_makh.Text = "";
            txt_tennv.Text = "";
            
            txt_sdt.Text = "";
            txt_dc.Text = "";
          
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

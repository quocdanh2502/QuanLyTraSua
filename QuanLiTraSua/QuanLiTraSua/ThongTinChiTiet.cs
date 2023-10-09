using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiTraSua
{
    public partial class ThongTinChiTiet : Form
    {
        public ThongTinChiTiet(DataTable data)
        {
            InitializeComponent();
            lbl_IdHoaDon.Text = data.Rows[0]["IDhoadon"].ToString();
            lbl_masp.Text = data.Rows[0]["IDsanpham"].ToString();
            lbl_tensp.Text = data.Rows[0]["Tensp"].ToString();
            lblsoluong.Text = data.Rows[0]["SLsanpham"].ToString();
            lbl_thanhtien.Text = data.Rows[0]["TongTien"].ToString();
        }
    }
}

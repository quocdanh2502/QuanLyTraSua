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
            DGV_Chitiet.DataSource = data;
        }
    }
}

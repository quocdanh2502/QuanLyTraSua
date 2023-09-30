using Microsoft.Office.Interop.Word;
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
    public partial class TaoHD : Form
    {
        System.Data.DataTable dataTable;

        public TaoHD()
        {
            InitializeComponent();
            dataTable = new System.Data.DataTable();
        }
        HoaDon hd = new HoaDon();
        ClassKhachHang kh = new ClassKhachHang();
        NVien nv = new NVien();
        public void reload()
        {
            dataGridViewHD.DataSource = dataTable;
            DataGridView dataGridView = new DataGridView();
            dataGridView.AllowUserToAddRows = false;
            dataGridViewHD.ReadOnly = true;
            dataTable.Columns.Add("STT", typeof(string));
            dataTable.Columns.Add("Mã SP", typeof(string));
            dataTable.Columns.Add("Tên SP", typeof(string));
            dataTable.Columns.Add("Giá", typeof(string));
            dataTable.Columns.Add("Số lượng", typeof(string));
            dataTable.Columns.Add("Thành Tiền", typeof(string));
            dataGridViewHD.Columns["STT"].MinimumWidth = 50; 
            dataGridViewHD.Columns["Mã SP"].MinimumWidth = 75; 
            dataGridViewHD.Columns["Tên SP"].MinimumWidth =300 ;
            dataGridViewHD.Columns["Giá"].MinimumWidth = 100;
            dataGridViewHD.Columns["Số lượng"].Width = 100; 
            dataGridViewHD.Columns["Thành Tiền"].Width = 150;
            dataGridView.AutoGenerateColumns = false;
        }
        private void TaoHD_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * FROM viewSanPham");
            DVG.AllowUserToAddRows = false;
            DVG.DataSource = hd.getHD(command);
            DVG.Columns[0].HeaderText = "Mã Sản Phẩm";
            DVG.Columns[1].HeaderText = "Tên Sản Phẩm";
            DVG.Columns[2].HeaderText = "Giá";

            txtBoxSL.Text = "0";
            reload();
          
        }

      
        private void DVG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = DVG.CurrentRow.Cells[1].Value.ToString();
            txtProductId.Text = DVG.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maSP = txtProductId.Text;
            string tenSP = txtName.Text;
            int sL = int.Parse(txtBoxSL.Text);

            string[] rowData = new string[6];
            rowData[0] = dataTable.Rows.Count.ToString(); 
            rowData[1] = maSP.Trim(); 
            rowData[2] = tenSP; 
            rowData[3] =  DVG.CurrentRow.Cells[2].Value.ToString().Trim();
            rowData[4] = sL.ToString();
            rowData[5] = (sL * int.Parse(DVG.CurrentRow.Cells[2].Value.ToString())).ToString(); 

            dataTable.Rows.Add(rowData);

            
            dataGridViewHD.Update();
        }


        private void dataGridViewHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

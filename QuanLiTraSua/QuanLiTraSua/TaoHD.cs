using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Drawing;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Document = iTextSharp.text.Document;

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
        MY_DB db = new MY_DB();
        HoaDon hd = new HoaDon();
        ClassKhachHang kh = new ClassKhachHang();
        NVien nv = new NVien();
        int RowIndex;
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
            dataGridViewHD.Columns["Tên SP"].MinimumWidth = 300;
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
            if (Singleton.Instance.curentKey != null && Singleton.Instance.Temp_Hd.ContainsKey(Singleton.Instance.curentKey))
            {
                dataGridViewHD.DataSource = Singleton.Instance.Temp_Hd[Singleton.Instance.curentKey];
                txtTongTien.Text = TongTien();
            }
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
            rowData[3] = DVG.CurrentRow.Cells[2].Value.ToString().Trim();
            rowData[4] = sL.ToString();
            rowData[5] = (sL * int.Parse(DVG.CurrentRow.Cells[2].Value.ToString())).ToString();

            if (sL <= 0)
            {
                DialogResult result = MessageBox.Show("Số lượng sản phẩm không được nhở hơn hoặc bằng 0", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (CheckDatainList(rowData[1]))
                {
                    dataGridViewHD.Rows[RowIndex].Cells[4].Value = int.Parse(dataGridViewHD.Rows[RowIndex].Cells[4].Value.ToString()) + sL;
                    dataGridViewHD.Rows[RowIndex].Cells[5].Value = int.Parse(dataGridViewHD.Rows[RowIndex].Cells[4].Value.ToString()) * int.Parse(dataGridViewHD.Rows[RowIndex].Cells[3].Value.ToString());
                }
                else
                {
                    dataTable.Rows.Add(rowData);
                    dataGridViewHD.Update();
                }
                txtTongTien.Text = TongTien();
            }
        }

        bool CheckDatainList(string masp)
        {
            bool isInList = false;
            for (int i = 0; i < dataGridViewHD.Rows.Count; i++)
            {
                if (dataGridViewHD.Rows[i].Cells[1].Value != null && dataGridViewHD.Rows[i].Cells[1].Value.ToString().Equals(masp))
                {
                    RowIndex = i;
                    isInList = true;
                    break;
                }
            }
            return isInList;
        }

        string TongTien()
        {
            int tong = 0;
            for (int i = 0; i < dataGridViewHD.Rows.Count; i++)
            {
                if (dataGridViewHD.Rows[i].Cells[5].Value != null)
                {
                    tong += int.Parse(dataGridViewHD.Rows[i].Cells[5].Value.ToString());
                }
            }
            return tong.ToString();
        }
        private void dataGridViewHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCloseTable_Click(object sender, EventArgs e)
        {
            if (Singleton.Instance.Temp_Hd.ContainsKey(Singleton.Instance.curentKey))
            {
                Singleton.Instance.Temp_Hd[Singleton.Instance.curentKey] = dataGridViewHD.DataSource as System.Data.DataTable;
            }
            else
            {
                Singleton.Instance.Temp_Hd.Add(Singleton.Instance.curentKey, dataGridViewHD.DataSource as System.Data.DataTable);
            }
            Singleton.Instance.curentKey = null;
            this.Close();
        }

        private void BtnXuatFile_Click(object sender, EventArgs e)
        {
            // Tạo chuỗi biểu diễn ngày tháng và thời gian hiện tại
            string currentDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveDialog.FileName = $"HoaDon_{Singleton.Instance.curentKey}.pdf";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(saveDialog.FileName);
                ExportToPDF(dataGridViewHD, folderPath,currentDate);
            }
        }

        private void ExportToPDF(DataGridView dataGridView, string folderPath, string currentDate)
        {
            try
            {
                

                // Tạo tên tệp PDF
                string fileName = $"HoaDon_{Singleton.Instance.curentKey}.pdf";
                string filePath = Path.Combine(folderPath, fileName);

                // Khởi tạo tệp PDF
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                using (Document document = new Document())
                using (PdfWriter writer = PdfWriter.GetInstance(document, fs))
                {
                    document.Open();

                    // Tạo đoạn văn bản cho ngày xuất
                    iTextSharp.text.Paragraph dateParagraph = new iTextSharp.text.Paragraph($"Date: {currentDate}");
                    dateParagraph.Alignment = Element.ALIGN_RIGHT;
                    dateParagraph.SpacingAfter = 20f; // Khoảng cách giữa bảng và ngày xuất
                    document.Add(dateParagraph);

                    iTextSharp.text.Paragraph title = new iTextSharp.text.Paragraph("BILL", new iTextSharp.text.Font());
                    title.Alignment = Element.ALIGN_CENTER;
                    title.SpacingAfter = 30f;
                    document.Add(title);

                    // Tạo bảng PDF và thêm dữ liệu từ DataGridView
                    PdfPTable pdfTable = new PdfPTable(dataGridView.Columns.Count);
                    pdfTable.DefaultCell.Padding = 3;
                    pdfTable.WidthPercentage = 100;
                    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                    // Thêm tiêu đề cột
                    foreach (DataGridViewColumn column in dataGridView.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, new iTextSharp.text.Font()));
                        pdfTable.AddCell(cell);
                    }

                    // Thêm dữ liệu từ DataGridView
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if(cell.Value != null)
                            {
                                PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value.ToString(), new iTextSharp.text.Font()));
                                pdfTable.AddCell(pdfCell);
                            }
                        }
                    }

                    // Thêm bảng vào tài liệu
                    document.Add(pdfTable);
                    document.Close();
                }

                MessageBox.Show("Xuất PDF thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //System.Data.DataTable dt = dataGridViewHD.DataSource as System.Data.DataTable;
            if (dataGridViewHD.DataSource != null)
            {
                HoaDon_Mod hd = new HoaDon_Mod();
                hd.IdHoaDon = GenerateRandomID(6);
                hd.NgayTao = DateTime.Now.Date;
                hd.SoLuongSP = dataGridViewHD.Rows.Count;
                hd.TongTien = int.Parse(txtTongTien.Text);
                hd.MaNV = Global.GlobalUserId;
                db.InsertHoaDon(hd);
                SendDataSanPham(hd.IdHoaDon);
            }
            dataGridViewHD.DataSource = null;
            txtTongTien.Text = "0";
        }
        void SendDataSanPham(string idHD)
        {
            if(dataGridViewHD.DataSource != null || dataGridViewHD.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridViewHD.Rows.Count - 1; i++)
                {
                    db.openConection();
                    SanPham_Mod sp = new SanPham_Mod();
                    sp.IdSanPham = dataGridViewHD.Rows[i].Cells[1].Value.ToString();
                    sp.TenSanPham = dataGridViewHD.Rows[i].Cells[2].Value.ToString();
                    sp.GiaSanPham = dataGridViewHD.Rows[i].Cells[3].Value.ToString();
                    sp.SoLuong = int.Parse(dataGridViewHD.Rows[i].Cells[4].Value.ToString());
                    sp.IdHoaDon = idHD;
                    string insertQuery = "INSERT INTO SanPham_mod (IDsanpham, Tensp, Giatien, IDhoadon, Soluong) VALUES (@IDsanpham, @Tensp, @Giatien, @IDhoadon, @Soluong)";
                    using (SqlCommand command = new SqlCommand(insertQuery, db.getConnection))
                    {
                        command.Parameters.AddWithValue("@IDsanpham", sp.IdSanPham);
                        command.Parameters.AddWithValue("@Tensp", sp.TenSanPham);
                        command.Parameters.AddWithValue("@Giatien", sp.GiaSanPham);
                        command.Parameters.AddWithValue("@IDhoadon", sp.IdHoaDon);
                        command.Parameters.AddWithValue("@Soluong", sp.SoLuong);

                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
        }
        string GenerateRandomID(int length)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            char[] randomChars = new char[length];

            for (int i = 0; i < length; i++)
            {
                randomChars[i] = chars[random.Next(chars.Length)];
            }

            return new string(randomChars);
        }

    }
}

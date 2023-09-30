
namespace QuanLiTraSua
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.labelMaMon = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.dgvCapNhatSanPham = new System.Windows.Forms.DataGridView();
            this.btnXoaDichVu = new System.Windows.Forms.Button();
            this.btnThemDichVu = new System.Windows.Forms.Button();
            this.btnLuuCapNhatDichVu = new System.Windows.Forms.Button();
            this.btnThoatCapNhatDichVu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaSP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMaMon
            // 
            this.labelMaMon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelMaMon.AutoSize = true;
            this.labelMaMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaMon.ForeColor = System.Drawing.Color.Blue;
            this.labelMaMon.Location = new System.Drawing.Point(678, 187);
            this.labelMaMon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaMon.Name = "labelMaMon";
            this.labelMaMon.Size = new System.Drawing.Size(114, 22);
            this.labelMaMon.TabIndex = 34;
            this.labelMaMon.Text = "Mã sản phẩm";
            this.labelMaMon.Click += new System.EventHandler(this.labelMaMon_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(679, 340);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 33;
            this.label3.Text = "Giá Sản Phẩm";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(678, 268);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // txtGia
            // 
            this.txtGia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtGia.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(837, 329);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(272, 30);
            this.txtGia.TabIndex = 30;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTenSP.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtTenSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(837, 257);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(272, 30);
            this.txtTenSP.TabIndex = 31;
            // 
            // dgvCapNhatSanPham
            // 
            this.dgvCapNhatSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCapNhatSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCapNhatSanPham.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvCapNhatSanPham.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCapNhatSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapNhatSanPham.Location = new System.Drawing.Point(13, 16);
            this.dgvCapNhatSanPham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCapNhatSanPham.Name = "dgvCapNhatSanPham";
            this.dgvCapNhatSanPham.ReadOnly = true;
            this.dgvCapNhatSanPham.RowHeadersWidth = 51;
            this.dgvCapNhatSanPham.Size = new System.Drawing.Size(632, 560);
            this.dgvCapNhatSanPham.TabIndex = 29;
            this.dgvCapNhatSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCapNhatSanPham_CellClick);
            // 
            // btnXoaDichVu
            // 
            this.btnXoaDichVu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXoaDichVu.BackColor = System.Drawing.Color.Red;
            this.btnXoaDichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaDichVu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDichVu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoaDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDichVu.Location = new System.Drawing.Point(1032, 419);
            this.btnXoaDichVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaDichVu.Name = "btnXoaDichVu";
            this.btnXoaDichVu.Size = new System.Drawing.Size(77, 41);
            this.btnXoaDichVu.TabIndex = 28;
            this.btnXoaDichVu.Text = "Xóa";
            this.btnXoaDichVu.UseVisualStyleBackColor = false;
            this.btnXoaDichVu.Click += new System.EventHandler(this.btnXoaDichVu_Click);
            // 
            // btnThemDichVu
            // 
            this.btnThemDichVu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThemDichVu.AutoSize = true;
            this.btnThemDichVu.BackColor = System.Drawing.Color.Lime;
            this.btnThemDichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemDichVu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDichVu.Location = new System.Drawing.Point(837, 419);
            this.btnThemDichVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemDichVu.Name = "btnThemDichVu";
            this.btnThemDichVu.Size = new System.Drawing.Size(77, 40);
            this.btnThemDichVu.TabIndex = 27;
            this.btnThemDichVu.Text = "Thêm";
            this.btnThemDichVu.UseVisualStyleBackColor = false;
            this.btnThemDichVu.Click += new System.EventHandler(this.btnThemDichVu_Click);
            // 
            // btnLuuCapNhatDichVu
            // 
            this.btnLuuCapNhatDichVu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLuuCapNhatDichVu.AutoSize = true;
            this.btnLuuCapNhatDichVu.BackColor = System.Drawing.Color.Gold;
            this.btnLuuCapNhatDichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuCapNhatDichVu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuCapNhatDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuCapNhatDichVu.Location = new System.Drawing.Point(933, 419);
            this.btnLuuCapNhatDichVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuuCapNhatDichVu.Name = "btnLuuCapNhatDichVu";
            this.btnLuuCapNhatDichVu.Size = new System.Drawing.Size(74, 41);
            this.btnLuuCapNhatDichVu.TabIndex = 26;
            this.btnLuuCapNhatDichVu.Text = "Sửa";
            this.btnLuuCapNhatDichVu.UseVisualStyleBackColor = false;
            this.btnLuuCapNhatDichVu.Click += new System.EventHandler(this.btnLuuCapNhatDichVu_Click);
            // 
            // btnThoatCapNhatDichVu
            // 
            this.btnThoatCapNhatDichVu.BackColor = System.Drawing.Color.Pink;
            this.btnThoatCapNhatDichVu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatCapNhatDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatCapNhatDichVu.Location = new System.Drawing.Point(-38, -55);
            this.btnThoatCapNhatDichVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoatCapNhatDichVu.Name = "btnThoatCapNhatDichVu";
            this.btnThoatCapNhatDichVu.Size = new System.Drawing.Size(118, 52);
            this.btnThoatCapNhatDichVu.TabIndex = 25;
            this.btnThoatCapNhatDichVu.Text = "Trở Về";
            this.btnThoatCapNhatDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoatCapNhatDichVu.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 24;
            // 
            // textBoxMaSP
            // 
            this.textBoxMaSP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxMaSP.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxMaSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaSP.Location = new System.Drawing.Point(837, 176);
            this.textBoxMaSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMaSP.Name = "textBoxMaSP";
            this.textBoxMaSP.Size = new System.Drawing.Size(272, 30);
            this.textBoxMaSP.TabIndex = 37;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 591);
            this.Controls.Add(this.textBoxMaSP);
            this.Controls.Add(this.labelMaMon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.dgvCapNhatSanPham);
            this.Controls.Add(this.btnXoaDichVu);
            this.Controls.Add(this.btnThemDichVu);
            this.Controls.Add(this.btnLuuCapNhatDichVu);
            this.Controls.Add(this.btnThoatCapNhatDichVu);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapNhatSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMaMon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.DataGridView dgvCapNhatSanPham;
        private System.Windows.Forms.Button btnXoaDichVu;
        private System.Windows.Forms.Button btnThemDichVu;
        private System.Windows.Forms.Button btnLuuCapNhatDichVu;
        private System.Windows.Forms.Button btnThoatCapNhatDichVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaSP;
    }
}
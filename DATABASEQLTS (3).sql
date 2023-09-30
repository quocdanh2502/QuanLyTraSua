--Tạo database
CREATE DATABASE QLTS
GO
USE [QLTS]
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 19/09/2021 12:31:36 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[maNV] [char](50) NOT NULL,
	[Pword] [char](20) NOT NULL,
	[IDLoaiQuyen] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maNV] ASC,
	[Pword] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 19/09/2021 12:31:36 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[IDhoadon] [char](20) NOT NULL,
	[NgayTao] [date] NOT NULL,
	[IDkh] [char](20) NOT NULL,
	[IDsanpham] [char](30) NOT NULL,
	[SLsanpham] [int] NOT NULL,
	[TongTien] [char] (30) NOT NULL,
	[maNV] [char](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDhoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 19/09/2021 12:31:36 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[IDkh] [char](20) NOT NULL,
	[tenkh] [nvarchar](50) NOT NULL,
	[Dchi] [nvarchar](50) NOT NULL,
	[SDT] [char](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDkh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 19/09/2021 12:31:36 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[IDsanpham] [char](30) NOT NULL,
	[Tensp] [nvarchar](50) NULL,
	[Giatien] [char](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDsanpham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongTinNV]    Script Date: 19/09/2021 12:31:36 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinNV](
	[maNV] [char](50) NOT NULL,
	[tenNV] [nvarchar](30) NOT NULL,
	[Gtinh] [char](10) NOT NULL,
	[Nsinh] [date] NOT NULL,
	[SDt] [char](30) NOT NULL,
	[Dchi] [nvarchar](50) NOT NULL,
	[LoaiNV] [nvarchar](20) NOT NULL,
	[Luong] [char](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[DangNhap]  WITH CHECK ADD FOREIGN KEY([maNV])
REFERENCES [dbo].[ThongTinNV] ([maNV])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([IDkh])
REFERENCES [dbo].[KhachHang] ([IDkh])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([IDsanpham])
REFERENCES [dbo].[SanPham] ([IDsanpham])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([maNV])
REFERENCES [dbo].[ThongTinNV] ([maNV])
ON DELETE CASCADE

Go

INSERT [dbo].[ThongTinNV] ([maNV], [tenNV], [Gtinh], [Nsinh], [SDT], [Dchi], [LoaiNV], [Luong]) VALUES ('admin', N'Nguyễn Thành Sơn', N'Nam', CAST(N'1979-10-19' AS Date), '0123456', N'TPHCM', N'Admin', '10000')
INSERT [dbo].[ThongTinNV] ([maNV], [tenNV], [Gtinh], [Nsinh], [SDT], [Dchi], [LoaiNV], [Luong]) VALUES ('NV1', N'Nguyễn Công Tiến', N'Nam', CAST(N'2001-10-19' AS Date), '012345', N'Vũng Tàu', N'Nhân viên', '9000')
INSERT [dbo].[ThongTinNV] ([maNV], [tenNV], [Gtinh], [Nsinh], [SDT], [Dchi], [LoaiNV], [Luong]) VALUES ('NV2', N'Hoàng Văn Tiến', N'Nam', CAST(N'2001-10-19' AS Date), '01234', N'Đăk Nông', N'Nhân viên', '9000')
INSERT [dbo].[ThongTinNV] ([maNV], [tenNV], [Gtinh], [Nsinh], [SDT], [Dchi], [LoaiNV], [Luong]) VALUES ('NV3', N'Tôn Thiên Thạch', N'Nam', CAST(N'2002-10-19' AS Date), '0123456', N'Bình Định', N'Nhân viên', '8000')
INSERT [dbo].[ThongTinNV] ([maNV], [tenNV], [Gtinh], [Nsinh], [SDT], [Dchi], [LoaiNV], [Luong]) VALUES ('NV4', N'Dương Nguyễn Huy Vũ', N'Nam', CAST(N'2000-10-19' AS Date), '012345', N'Hà Tĩnh', N'Nhân viên', '7000')
INSERT [dbo].[ThongTinNV] ([maNV], [tenNV], [Gtinh], [Nsinh], [SDT], [Dchi], [LoaiNV], [Luong]) VALUES ('NV5', N'Trân Anh', N'Nam', CAST(N'2000-12-19' AS Date), '012345', N'Nghệ An', N'Nhân viên', '7000')

Go
INSERT [dbo].DangNhap ([maNV],[Pword],[IDLoaiQuyen]) Values ('admin',N'1234',1)
INSERT [dbo].DangNhap ([maNV],[Pword],[IDLoaiQuyen]) Values ('NV1',N'1234',2)
INSERT [dbo].DangNhap ([maNV],[Pword],[IDLoaiQuyen]) Values ('NV2',N'1234',2)
INSERT [dbo].DangNhap ([maNV],[Pword],[IDLoaiQuyen]) Values ('NV3',N'1234',2)
INSERT [dbo].DangNhap ([maNV],[Pword],[IDLoaiQuyen]) Values ('NV4',N'1234',2)
INSERT [dbo].DangNhap ([maNV],[Pword],[IDLoaiQuyen]) Values ('NV5',N'1234',2)
GO
INSERT [dbo].[KhachHang] ([IDkh], [tenkh], [Dchi],[SDT]) VALUES (N'KH1     ', N'Nguyễn Thị A', N'Quận 1', N'02334455')
INSERT [dbo].[KhachHang] ([IDkh], [tenkh], [Dchi],[SDT]) VALUES (N'KH2     ', N'Nguyễn Văn B', N'Quận 3',N'06627222')
INSERT [dbo].[KhachHang] ([IDkh], [tenkh], [Dchi],[SDT]) VALUES (N'KH3     ', N'Nguyễn Thị C', N'Quận 6',N'04727272')
INSERT [dbo].[KhachHang] ([IDkh], [tenkh], [Dchi],[SDT]) VALUES (N'KH4     ', N'Nguyễn Văn D', N'Quận 2',N'0383838')
INSERT [dbo].[KhachHang] ([IDkh], [tenkh], [Dchi],[SDT]) VALUES (N'KH5     ', N'Nguyễn Thị E', N'Thủ Đức',N'03938383')

GO
INSERT [dbo].[SanPham] ([IDsanpham], [Tensp], [Giatien]) VALUES (N'SP1     ', N'Trà Sữa Bé     ', N'5000')
INSERT [dbo].[SanPham] ([IDsanpham], [Tensp], [Giatien]) VALUES (N'SP2     ', N'Trà Sữa Bé Vừa     ', N'6000')
INSERT [dbo].[SanPham] ([IDsanpham], [Tensp], [Giatien]) VALUES (N'SP3     ', N'Trà Sữa Vừa      ', N'7000')
INSERT [dbo].[SanPham] ([IDsanpham], [Tensp], [Giatien]) VALUES (N'SP4     ', N'Trà Sữa Trung Bình    ', N'8000')
INSERT [dbo].[SanPham] ([IDsanpham], [Tensp], [Giatien]) VALUES (N'SP5     ', N'Trà Sữa Lớn     ', N'9000')
INSERT [dbo].[SanPham] ([IDsanpham], [Tensp], [Giatien]) VALUES (N'SP6     ', N'Trà Sữa Khổng Lồ     ', N'10000')

GO
INSERT [dbo].[HoaDon] ([IDhoadon], [NgayTao], [IDkh], [IDsanpham],[SLsanpham],[TongTien],[maNV]) VALUES (N'HD1     ', CAST(N'2021-10-19' AS Date),N'KH1     ',N'SP1     ',2,N'10000     ',N'NV1     ')
INSERT [dbo].[HoaDon] ([IDhoadon], [NgayTao], [IDkh], [IDsanpham],[SLsanpham],[TongTien],[maNV]) VALUES (N'HD2     ', CAST(N'2021-10-19' AS Date),N'KH2     ',N'SP2     ',2,N'12000     ',N'NV2     ')
INSERT [dbo].[HoaDon] ([IDhoadon], [NgayTao], [IDkh], [IDsanpham],[SLsanpham],[TongTien],[maNV]) VALUES (N'HD3     ', CAST(N'2021-10-20' AS Date),N'KH3     ',N'SP3     ',2,N'14000     ',N'NV3     ')
INSERT [dbo].[HoaDon] ([IDhoadon], [NgayTao], [IDkh], [IDsanpham],[SLsanpham],[TongTien],[maNV]) VALUES (N'HD4     ', CAST(N'2021-10-21' AS Date),N'KH2     ',N'SP4     ',2,N'16000     ',N'NV4     ')
INSERT [dbo].[HoaDon] ([IDhoadon], [NgayTao], [IDkh], [IDsanpham],[SLsanpham],[TongTien],[maNV]) VALUES (N'HD5     ', CAST(N'2021-10-21' AS Date),N'KH4     ',N'SP5     ',2,N'18000     ',N'NV5     ')
INSERT [dbo].[HoaDon] ([IDhoadon], [NgayTao], [IDkh], [IDsanpham],[SLsanpham],[TongTien],[maNV]) VALUES (N'HD6     ', CAST(N'2021-10-22' AS Date),N'KH5     ',N'SP6     ',2,N'20000     ',N'NV1     ')
INSERT [dbo].[HoaDon] ([IDhoadon], [NgayTao], [IDkh], [IDsanpham],[SLsanpham],[TongTien],[maNV]) VALUES (N'HD7     ', CAST(N'2021-10-23' AS Date),N'KH3     ',N'SP4     ',2,N'16000     ',N'NV2     ')
INSERT [dbo].[HoaDon] ([IDhoadon], [NgayTao], [IDkh], [IDsanpham],[SLsanpham],[TongTien],[maNV]) VALUES (N'HD8     ', CAST(N'2021-10-23' AS Date),N'KH2     ',N'SP3     ',2,N'14000     ',N'NV3     ')
INSERT [dbo].[HoaDon] ([IDhoadon], [NgayTao], [IDkh], [IDsanpham],[SLsanpham],[TongTien],[maNV]) VALUES (N'HD9     ', CAST(N'2021-10-23' AS Date),N'KH1     ',N'SP2     ',2,N'12000     ',N'NV4     ')
Go
---trigger đảm bảo nhập giá sản phẩm hợp lệ
Create TRIGGER [dbo].[Check_Gia] --Tên Trigger
ON [dbo].[SanPham]
FOR UPDATE,INSERT
AS
 BEGIN
 DECLARE @gia AS INT
SELECT @gia=inserted.Giatien FROM inserted
IF (@gia<0)
	BEGIN
		PRINT N'Giá KHÔNG HỢP LỆ'
		ROLLBACK TRANSACTION
	 END
END
GO
---trigger đảm bảo không trùng tài khoản
Create TRIGGER [dbo].[CHECK_USERS] --Tên Trigger
ON [dbo].[DangNhap]
FOR UPDATE,INSERT
AS
 BEGIN
 DECLARE @manv AS NCHAR(50), @TEMP AS INT
SELECT @manv=inserted.maNV FROM inserted
SELECT @TEMP=COUNT(*) FROM dbo.DangNhap
WHERE maNV=@manv
IF (@TEMP>1)
	 BEGIN
		 PRINT N'TÀI KHOẢN Đã Tồn Tại'
		 ROLLBACK TRANSACTION
	 END
END
Go
--trigger gán quyền cho tài 
CREATE OR ALTER TRIGGER trgThemTaiKhoan ON dbo.DangNhap FOR INSERT AS
BEGIN
	BEGIN TRANSACTION ThemTaiKhoan;
	DECLARE @maNV CHAR(10), @Pword CHAR(10), @IDLoaiQuyen INT;
	SELECT @maNV = maNV,	@Pword = Pword,	@IDLoaiQuyen = IDLoaiQuyen	FROM Inserted;

	-- Them login
	EXECUTE('CREATE LOGIN [' + @maNV + '] WITH PASSWORD = ''' + @Pword +	'''' + ', DEFAULT_DATABASE=[QLTS]');

	-- Them user
	EXECUTE('CREATE USER [' + @maNV + '] FOR LOGIN [' + @maNV + ']');

	-- Gan role
	IF (@IDLoaiQuyen = 1) EXECUTE sp_addrolemember 'QuanLy', @maNV;
	ELSE IF(@IDLoaiQuyen = 2) EXECUTE sp_addrolemember 'NhanVien', @maNV;

	IF (@@ERROR <> 0)
	BEGIN
		RAISERROR('Lỗi, không thêm được!', 16, 1);
		ROLLBACK TRANSACTION ThemTaiKhoan;
	END
	ELSE COMMIT TRANSACTION ThemTaiKhoan;
END
GO



----------------VIEW---------------------------------------
---Tạo view hiển thị thông tin nhân viên
CREATE OR ALTER VIEW viewNhanVien AS
	SELECT [maNV], [tenNV], [Gtinh], [Nsinh], [Dchi], [SDt],[LoaiNV],[Luong] FROM dbo.ThongTinNV;
GO
----Tạo view hiển thị thông tin khách hàng
CREATE OR ALTER VIEW viewKhachHang AS
	SELECT [IDkh], [tenkh],[Dchi],[SDT] FROM dbo.KhachHang;
GO
----Tạo view hiển thị thông tin Sản phẩm
CREATE OR ALTER VIEW viewSanPham AS
	SELECT [IDsanpham], [Tensp], [Giatien] FROM dbo.SanPham;
GO
---Tạo view  hiển thị thông tin hóa đơn
CREATE OR ALTER VIEW viewHoaDon AS
	SELECT [IDhoadon], [NgayTao], [IDkh],[IDsanpham],[SLsanpham], [TongTien],[maNV] FROM dbo.HoaDon;

GO
----Tạo view hiển thị thông tin user
CREATE OR ALTER VIEW viewUser AS
	SELECT [maNV], [Pword], [IDLoaiQuyen] FROM dbo.DangNhap;
GO


-----Insert dữ liệu vào bảng hóa đơn
CREATE OR ALTER PROCEDURE spThemHoaDon
	(@IDhoadon CHAR(20), @NgayTao DATE, @IDkh CHAR(20),
	@IDsanpham CHAR(30), @SLsanpham INT, @TongTien CHAR(30), @maNV CHAR(10))
AS
BEGIN 
	IF(EXISTS (SELECT * FROM HoaDon
				WHERE (IDhoadon = @IDhoadon)))
				return -1;
	ELSE 
		BEGIN TRAN;
			BEGIN TRY
				INSERT INTO dbo.HoaDon VALUES(@IDhoadon , @NgayTao, @IDkh,@IDsanpham , @SLsanpham, @TongTien, @maNV);
				COMMIT TRAN;
			END TRY
			BEGIN CATCH
				ROLLBACK TRAN
			END CATCH
END
GO
---Xoa hoa don-----
CREATE OR ALTER PROCEDURE spXoaHoaDon_TheoMaHoaDon  (@IDhoadon CHAR(20) ) AS
	DELETE FROM dbo.HoaDon  WHERE IDhoadon = @IDhoadon;
Go
---Cap nhap hoa don----

CREATE OR ALTER PROCEDURE spCapNhatHoaDon (@IDhoadon CHAR(20), @NgayTao DATE, @IDkh CHAR(20),
	@IDsanpham CHAR(30), @SLsanpham INT, @TongTien CHAR(30), @maNV CHAR(10))
AS
BEGIN
	BEGIN TRAN;
		BEGIN TRY
			UPDATE dbo.HoaDon SET NgayTao= @NgayTao,@IDkh = @IDkh,
								IDsanpham = @IDsanpham,SLsanpham = @SLsanpham,TongTien = @TongTien,
								maNV= @maNV
			WHERE HoaDon.IDHoaDon= @IDhoadon;
			COMMIT TRAN;
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
		END CATCH
END
GO 
----------------Procedure KhachHang------------------
CREATE OR ALTER PROCEDURE spThemKhachHang
	(@IDkh CHAR(10),
	@tenkh CHAR(20),
	@Dchi Char (20),
	@SDT char(10))
AS
BEGIN 
	IF(EXISTS (SELECT * FROM KhachHang
				WHERE (IDkh =@IDkh)))
				return -1;
	ELSE 
		BEGIN TRAN;
			BEGIN TRY
				INSERT INTO dbo.KhachHang VALUES(@IDkh,@tenkh,@Dchi,@SDT);
				COMMIT TRAN;
			END TRY
			BEGIN CATCH
				ROLLBACK TRAN
			END CATCH
END
GO

---Xoa KH
CREATE OR ALTER PROCEDURE spXoaKH_TheoID  (@IDkh CHAR(10) ) AS
	DELETE FROM dbo.KhachHang  WHERE IDkh = @IDkh;
GO


CREATE OR ALTER PROCEDURE spCapNhatKhachHang ( @IDkh CHAR(10),
											@tenkh NVARCHAR(50),
											@Dchi nvarchar(50),
											@SDT char(10))
											
AS
BEGIN
	BEGIN TRAN;
		BEGIN TRY
				UPDATE dbo.KhachHang SET tenkh= @tenkh,Dchi = @Dchi,SDT = @SDT
				WHERE IDkh= @IDkh;
			COMMIT TRAN;
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
		END CATCH
END
GO 
----------------Procedure SanPham--------------------------
CREATE OR ALTER PROCEDURE spSanPham (@IDsanpham char(30), @Tensp NVARCHAR(50),@GiaTien char(50))
AS
BEGIN 
	IF(EXISTS (SELECT * FROM SanPham
				WHERE (IDsanpham = @IDsanpham)))
				return -1;
	ELSE 
		BEGIN TRAN;
			BEGIN TRY
				INSERT INTO dbo.SanPham VALUES (@IDsanpham , @Tensp,@GiaTien);
				COMMIT TRAN;
			END TRY
			BEGIN CATCH
				ROLLBACK TRAN
			END CATCH
END
GO
---Xoa KH-------
CREATE OR ALTER PROCEDURE spXoaSanPham_TheoID  (@IDsanpham CHAR(30) ) AS
	DELETE FROM dbo.SanPham  WHERE IDsanpham = @IDsanpham;
GO
--sua thong tin sanPham-----
CREATE OR ALTER PROCEDURE spCapNhatSanPham (@IDsanpham CHAR(30),@Tensp NVARCHAR(50),@Giatien CHAR(30))
AS
BEGIN
	BEGIN TRAN;
		BEGIN TRY
			UPDATE dbo.SanPham SET Tensp= @Tensp,Giatien = @Giatien
			WHERE IDsanpham= @IDsanpham;
			COMMIT TRAN;
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
		END CATCH
END
GO 

----------------Procedure BLNHanVien------------------
CREATE OR ALTER PROCEDURE spThemNhanVien
    (@maNV CHAR(10), @tenNV NVARCHAR(50), @Gtinh nvarchar(10),
    @Nsinh DATETIME,  @SDt char(10),@Dchi NVARCHAR(50),@LoaiNV nvarchar (20),@Luong char(10))
AS
BEGIN 
	IF(EXISTS (SELECT * FROM ThongTinNV
				WHERE (MaNV = @MaNV)))
				return -1;
	ELSE 
		BEGIN TRAN;
			BEGIN TRY
				 INSERT INTO dbo.ThongTinNV VALUES(@maNV, @tenNV , @Gtinh, @Nsinh, @Dchi, @SDt, @LoaiNV,@Luong);
				COMMIT TRAN;
			END TRY
			BEGIN CATCH
				ROLLBACK TRAN
			END CATCH
END
GO

CREATE OR ALTER PROCEDURE spXoaNhanVien_MaNV (@maNV CHAR(10) ) AS
	DELETE FROM dbo.ThongTinNV  WHERE maNV = @maNV;
Go


CREATE OR ALTER PROCEDURE spCapNhatNhanVien (	@maNV char(10),
											@tenNV nvarchar(50),
											@Gtinh nvarchar(10),
											@Nsinh date,
											@Dchi nvarchar(50),
											@SDt char(10),
											@LoaiNV nvarchar (20),
											@Luong char (10))
AS
BEGIN
	BEGIN TRAN;
		BEGIN TRY
					UPDATE dbo.ThongTinNV SET tenNV=@tenNV, Gtinh = @Gtinh, Nsinh = @Nsinh,
												Dchi = @Dchi, SDt = @SDt, LoaiNV = @LoaiNV, Luong = @Luong
					WHERE maNV= @maNV;
			COMMIT TRAN;
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
		END CATCH
END
GO 

----------------Procedure BLDoiMatKhau------------------
CREATE OR ALTER PROCEDURE spCapNhatMatKhau(@MatKhauMoi char(10),
                                            @maNV char(20),
                                            @MatKhauCu char(20))
AS
BEGIN
	BEGIN TRAN;
		BEGIN TRY
					 UPDATE dbo.DangNhap SET Pword = @MatKhauMoi
					WHERE maNV = @maNV AND Pword = @MatKhauCu;
			COMMIT TRAN;
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
		END CATCH
END
---Procedure Tai Khoan----
GO
CREATE OR ALTER PROCEDURE spSuaTaiKhoan_TheoTenTK
(@maNV CHAR(15), @Pword CHAR(10), @IDLoaiQuyen INT) AS
BEGIN
	BEGIN TRANSACTION SuaTaiKhoan;
	UPDATE dbo.DangNhap SET Pword= @Pword, IDLoaiQuyen = @IDLoaiQuyen
	WHERE maNV = @maNV;
	COMMIT TRANSACTION SuaTaiKhoan;
END
GO

CREATE OR ALTER PROCEDURE spThemTaiKhoan
(@maNV CHAR(15), @Pword CHAR(10), @IDLoaiQuyen INT) AS
	INSERT INTO dbo.DangNhap VALUES(@maNV, @Pword, @IDLoaiQuyen);
GO

CREATE OR ALTER PROCEDURE spXoaTaiKhoan_TheoTenTK (@maNV CHAR(10)) AS
	IF (@maNV <> 'admin') DELETE FROM dbo.DangNhap WHERE maNV = @maNV;
	ELSE RAISERROR('Không xóa được tài khoản Admin!', 16, 1);
GO
--Function
---function in ra tổng thu nhập trong 1 ngày
Create function [dbo].[F_ThuNhapByNgay](@ngay Datetime)
returns table
as
	return
(
select NgayTao,Sum(CAST (TongTien as int) )as thunhap
from HoaDon
where NgayTao=@ngay
group by NgayTao
)
go 
---function kiểm tra đăng nhập
Create function [dbo].[F_KTDangNhap](@ten char(15),@pass char(15))
returns table
as
	return
(
select *
from DangNhap
where maNV=@ten and Pword=@pass

)
go 
---function trả về bảng nhân viên tìm kiếm theo id nhân viên
Create function [dbo].[F_NVById](@IDnv char(15))
returns table
as
	return
(
SELECT * 
FROM ThongTinNV 
WHERE maNV = @IDnv

)
go 
---function trả về bảng sản phẩm tìm kiếm theo id sản phẩm
Create function [dbo].[F_SPById](@IDsp char(15))
returns table
as
	return
(
SELECT * 
FROM SanPham 
WHERE IDsanpham = @IDsp

)

go 
---function trả về bảng hóa đơn tìm kiếm thông qua theo id hóa đơn
Create function [dbo].[F_HoaDonById](@IDhd char(15))
returns table
as
	return
(
SELECT 
* FROM HoaDon 
WHERE IDhoadon = @IDhd

)
go 
---function trả về bảng khách hàng thông qua tìm kiếm theo id khách hàng

Create function [dbo].[F_KhachHangById](@IDkh char(15))
returns table
as
	return
(
SELECT * FROM KhachHang 
WHERE IDkh = @IDkh

)
go 

---Phân quyền
CREATE ROLE QuanLy;
GO
GRANT EXECUTE ON [dbo].[spCapNhatNhanVien] TO QuanLy;
GRANT EXECUTE ON [dbo].[spCapNhatHoaDon] TO QuanLy;
GRANT EXECUTE ON [dbo].[spCapNhatMatKhau] TO QuanLy;
GRANT EXECUTE ON [dbo].[spCapNhatSanPham] TO QuanLy;
GRANT EXECUTE ON [dbo].[spCapNhatKhachHang] TO QuanLy;
GRANT EXECUTE ON [dbo].[spThemTaiKhoan] TO QuanLy;
GRANT EXECUTE ON [dbo].[spSuaTaiKhoan_TheoTenTK] TO QuanLy;
GRANT EXECUTE ON [dbo].[spSanPham] TO QuanLy;
GRANT EXECUTE ON [dbo].[spThemHoaDon] TO QuanLy;
GRANT EXECUTE ON [dbo].[spThemKhachHang] TO QuanLy;
GRANT EXECUTE ON [dbo].[spThemNhanVien] TO QuanLy;
GRANT EXECUTE ON [dbo].[spThemTaiKhoan] TO QuanLy;
GRANT EXECUTE ON [dbo].[spXoaHoaDon_TheoMaHoaDon] TO QuanLy;
GRANT EXECUTE ON [dbo].[spXoaKH_TheoID] TO QuanLy;
GRANT EXECUTE ON [dbo].[spXoaNhanVien_MaNV] TO QuanLy;
GRANT EXECUTE ON [dbo].[spXoaSanPham_TheoID] TO QuanLy;
GRANT EXECUTE ON [dbo].[spXoaTaiKhoan_TheoTenTK] TO QuanLy;
CREATE ROLE NhanVien;
GO
GRANT EXECUTE ON [dbo].[spCapNhatHoaDon] TO NhanVien;
GRANT EXECUTE ON [dbo].[spThemHoaDon] TO NhanVien;
GRANT EXECUTE ON [dbo].[spThemKhachHang] TO NhanVien;
GRANT EXECUTE ON [dbo].[spXoaKH_TheoID] TO NhanVien;
GRANT EXECUTE ON [dbo].[spCapNhatKhachHang] TO NhanVien;
GO

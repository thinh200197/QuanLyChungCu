USE [DB_QLCC]
GO
/****** Object:  StoredProcedure [dbo].[PR_InserResident]    Script Date: 26-Jun-20 4:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PR_InserResident]
 @MaCuDan varchar(30), @TenCuDan nvarchar(50),@NgaySinh date,@SoDienThoai varchar(10),@Cmnd varchar(10)
AS
BEGIN	
	INSERT CUDAN (MACUDAN,TENCUDAN,NGAYSINH,SODIENTHOAI,CHUNGMINHNHANDAN)
	VALUES (@MaCuDan,@TenCuDan,@NgaySinh,@SoDienThoai,@Cmnd) 
END

GO
/****** Object:  StoredProcedure [dbo].[PR_InserResidentApartment]    Script Date: 26-Jun-20 4:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	

CREATE PROCEDURE [dbo].[PR_InserResidentApartment]
 @MaCuDan varchar(30), @MaCanHo varchar(30)
AS
BEGIN	
	INSERT [CUDAN-CANHO] (MACANHO,MACUDAN,NGAYBATDAUO,NGAYHETO)
	VALUES (@MaCanHo,@MaCuDan,GETDATE(),'2999-05-01') 
END

GO
/****** Object:  StoredProcedure [dbo].[PR_login]    Script Date: 26-Jun-20 4:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- proc Login
CREATE PROCEDURE [dbo].[PR_login] 
 @username varchar(30), @password varchar(30)
AS
BEGIN
	SELECT * FROM TAIKHOAN WHERE TENDANGNHAP = @username and MATKHAU = @password
END

GO
/****** Object:  Table [dbo].[BIENBANVIPHAM]    Script Date: 26-Jun-20 4:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BIENBANVIPHAM](
	[MABIENBAN] [varchar](30) NOT NULL,
	[TENBIENBAN] [nvarchar](50) NULL,
	[MACUDAN] [varchar](30) NULL,
 CONSTRAINT [PK_BIENBANVIPHAM] PRIMARY KEY CLUSTERED 
(
	[MABIENBAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CANHO]    Script Date: 26-Jun-20 4:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CANHO](
	[MACANHO] [varchar](30) NOT NULL,
	[MATANGLAU] [varchar](30) NOT NULL,
	[MALOAI_CH] [varchar](30) NULL,
	[TENCANHO] [nvarchar](30) NULL,
	[SONGUOIO] [int] NULL,
	[CHUHO] [varchar](30) NULL,
 CONSTRAINT [PK_CANHO_1] PRIMARY KEY CLUSTERED 
(
	[MACANHO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHIPHI_THANHTOAN]    Script Date: 26-Jun-20 4:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHIPHI_THANHTOAN](
	[MACHIPHI] [varchar](30) NOT NULL,
	[TENCHIPHI] [nvarchar](50) NULL,
	[DONVITINH] [nvarchar](50) NULL,
 CONSTRAINT [PK_CHIPHI_THANHTOAN] PRIMARY KEY CLUSTERED 
(
	[MACHIPHI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHITIET_HDTT]    Script Date: 26-Jun-20 4:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIET_HDTT](
	[MACHIPHI] [varchar](30) NULL,
	[MAHD_THANHTOAN] [varchar](30) NULL,
	[SOLUONG] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHITIET_VIPHAM]    Script Date: 26-Jun-20 4:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIET_VIPHAM](
	[MABIENBAN] [varchar](30) NULL,
	[MAVIPHAM] [varchar](30) NULL,
	[THOIGIAN_VIPHAM] [datetime] NULL,
	[LANVIPHAM] [int] NULL,
	[MUCDO_VIPHAM] [nvarchar](500) NULL,
	[HINHTHUCXULY] [nvarchar](500) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CUDAN]    Script Date: 26-Jun-20 4:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CUDAN](
	[MACUDAN] [varchar](30) NOT NULL,
	[TENCUDAN] [nvarchar](50) NULL,
	[NGAYSINH] [date] NULL,
	[SODIENTHOAI] [varchar](10) NULL,
	[CHUNGMINHNHANDAN] [varchar](10) NULL,
	[GIOITINH] [bit] NULL,
 CONSTRAINT [PK_CUDAN_1] PRIMARY KEY CLUSTERED 
(
	[MACUDAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CUDAN-CANHO]    Script Date: 26-Jun-20 4:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CUDAN-CANHO](
	[MACUDAN] [varchar](30) NOT NULL,
	[MACANHO] [varchar](30) NOT NULL,
	[NGAYBATDAUO] [date] NULL,
	[NGAYHETO] [date] NULL,
 CONSTRAINT [PK_CUDAN-CANHO] PRIMARY KEY CLUSTERED 
(
	[MACUDAN] ASC,
	[MACANHO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DANHSACH_VIPHAM]    Script Date: 26-Jun-20 4:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DANHSACH_VIPHAM](
	[MAVIPHAM] [varchar](30) NOT NULL,
	[TENVIPHAM] [nvarchar](50) NULL,
	[NOIDUNG_VIPHAM] [nvarchar](500) NULL,
 CONSTRAINT [PK_DANHSACH_VIPHAM] PRIMARY KEY CLUSTERED 
(
	[MAVIPHAM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DICHVU]    Script Date: 26-Jun-20 4:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DICHVU](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MALOAIDICHVU] [int] NULL,
	[TENDICHVU] [nvarchar](50) NULL,
	[DONVITINH] [nvarchar](50) NULL,
	[NGAYTAO] [date] NULL,
	[NGUOITAO] [int] NULL,
	[NGAYCAPNHAT] [date] NULL,
	[NGUOICAPNHAT] [int] NULL,
 CONSTRAINT [PK_DICHVU] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DONGIA_CPTT]    Script Date: 26-Jun-20 4:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DONGIA_CPTT](
	[MAGIA_CPTT] [varchar](30) NOT NULL,
	[TENGIA_CPTT] [nvarchar](50) NULL,
	[GIÁ] [int] NULL,
	[NGAYAPDUNG] [date] NULL,
	[MACHIPHI] [varchar](30) NULL,
 CONSTRAINT [PK_DONGIA_CPTT] PRIMARY KEY CLUSTERED 
(
	[MAGIA_CPTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HOADON_THANHTOAN]    Script Date: 26-Jun-20 4:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOADON_THANHTOAN](
	[MAHD_THANHTOAN] [varchar](30) NOT NULL,
	[TENHD_THANHTOAN] [nvarchar](50) NULL,
	[TONGTIEN] [int] NULL,
	[NGAYLAP] [date] NULL,
	[MANHANVIEN] [varchar](30) NULL,
 CONSTRAINT [PK_HOADON_THANHTOAN] PRIMARY KEY CLUSTERED 
(
	[MAHD_THANHTOAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAICANHO]    Script Date: 26-Jun-20 4:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAICANHO](
	[MALOAI_CH] [varchar](30) NOT NULL,
	[TENLOAI_CH] [nvarchar](50) NULL,
	[DIENTICH] [int] NULL,
	[SOPHONGNGU] [int] NULL,
	[SONGUOITOIDA] [int] NULL,
 CONSTRAINT [PK_LOAICANHO] PRIMARY KEY CLUSTERED 
(
	[MALOAI_CH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAIDICHVU]    Script Date: 26-Jun-20 4:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIDICHVU](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TENLOAIDICHVU] [nvarchar](50) NULL,
	[NGAYTAO] [date] NULL,
	[NGUOITAO] [int] NULL,
	[NGAYCAPNHAT] [date] NULL,
	[NGUOICAPNHAT] [int] NULL,
 CONSTRAINT [PK_LOAIDICHVU] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN_TAIKHOAN]    Script Date: 26-Jun-20 4:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN_TAIKHOAN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MANHANVIEN] [varchar](30) NULL,
	[TAIKHOAN] [varchar](30) NULL,
	[NGAYTAO] [date] NULL,
	[NGUOITAO] [varchar](30) NULL,
	[NGAYCAPNHAT] [date] NULL,
	[NGUOICAPNHAT] [varchar](30) NULL,
 CONSTRAINT [PK_NHANVIEN_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN_TOANHA]    Script Date: 26-Jun-20 4:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN_TOANHA](
	[MANHANVIEN] [varchar](30) NOT NULL,
	[TENNHANVIEN] [nvarchar](50) NULL,
	[NGAYSINH] [date] NULL,
	[SODIENTHOAI] [varchar](10) NULL,
	[EMAIL] [varchar](30) NULL,
 CONSTRAINT [PK_NHANVIEN_TOANHA] PRIMARY KEY CLUSTERED 
(
	[MANHANVIEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHOM_TAIKHOAN]    Script Date: 26-Jun-20 4:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHOM_TAIKHOAN](
	[MANHOM_TAIKHOAN] [varchar](30) NOT NULL,
	[TENNHOM_TAIKHOAN] [nvarchar](50) NULL,
 CONSTRAINT [PK_NHOM_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[MANHOM_TAIKHOAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 26-Jun-20 4:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[TENDANGNHAP] [varchar](30) NOT NULL,
	[MANHOM_TAIKHOAN] [varchar](30) NULL,
	[MATKHAU] [varchar](30) NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[TENDANGNHAP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TANGLAU]    Script Date: 26-Jun-20 4:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TANGLAU](
	[MATANGLAU] [varchar](30) NOT NULL,
	[MABLOCK] [varchar](30) NOT NULL,
	[TENTANGLAU] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TANGLAU_1] PRIMARY KEY CLUSTERED 
(
	[MATANGLAU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TOANHA]    Script Date: 26-Jun-20 4:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TOANHA](
	[MABLOCK] [varchar](30) NOT NULL,
	[TENBLOCK] [nvarchar](10) NULL,
 CONSTRAINT [PK__TOANHA__1FF2A67370CEB997] PRIMARY KEY CLUSTERED 
(
	[MABLOCK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[VIEW_NhanKhau]    Script Date: 26-Jun-20 4:43:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VIEW_NhanKhau]
AS
SELECT        dbo.TOANHA.TENBLOCK, dbo.TANGLAU.TENTANGLAU, dbo.LOAICANHO.TENLOAI_CH, dbo.LOAICANHO.DIENTICH, dbo.LOAICANHO.SOPHONGNGU, dbo.LOAICANHO.SONGUOITOIDA, dbo.[CUDAN-CANHO].NGAYBATDAUO, 
                         dbo.[CUDAN-CANHO].NGAYHETO, dbo.CANHO.TENCANHO, dbo.CUDAN.TENCUDAN, dbo.CUDAN.NGAYSINH, dbo.CUDAN.SODIENTHOAI, dbo.CANHO.CHUHO, dbo.CANHO.SONGUOIO, dbo.CUDAN.GIOITINH, 
                         dbo.CUDAN.CHUNGMINHNHANDAN
FROM            dbo.CANHO INNER JOIN
                         dbo.[CUDAN-CANHO] ON dbo.CANHO.MACANHO = dbo.[CUDAN-CANHO].MACANHO INNER JOIN
                         dbo.CUDAN ON dbo.[CUDAN-CANHO].MACUDAN = dbo.CUDAN.MACUDAN INNER JOIN
                         dbo.LOAICANHO ON dbo.CANHO.MALOAI_CH = dbo.LOAICANHO.MALOAI_CH INNER JOIN
                         dbo.TANGLAU ON dbo.CANHO.MATANGLAU = dbo.TANGLAU.MATANGLAU INNER JOIN
                         dbo.TOANHA ON dbo.TANGLAU.MABLOCK = dbo.TOANHA.MABLOCK

GO
INSERT [dbo].[NHOM_TAIKHOAN] ([MANHOM_TAIKHOAN], [TENNHOM_TAIKHOAN]) VALUES (N'ADMIN', N'ADMIN')
INSERT [dbo].[NHOM_TAIKHOAN] ([MANHOM_TAIKHOAN], [TENNHOM_TAIKHOAN]) VALUES (N'RESIDENT', N'CU DÂN')
INSERT [dbo].[NHOM_TAIKHOAN] ([MANHOM_TAIKHOAN], [TENNHOM_TAIKHOAN]) VALUES (N'STAFF', N'NHÂN VIÊN')
INSERT [dbo].[TAIKHOAN] ([TENDANGNHAP], [MANHOM_TAIKHOAN], [MATKHAU]) VALUES (N'ADMIN', N'ADMIN', N'123')
INSERT [dbo].[TAIKHOAN] ([TENDANGNHAP], [MANHOM_TAIKHOAN], [MATKHAU]) VALUES (N'TOI', N'RESIDENT', N'123')
INSERT [dbo].[TAIKHOAN] ([TENDANGNHAP], [MANHOM_TAIKHOAN], [MATKHAU]) VALUES (N'USER', N'STAFF', N'123')
ALTER TABLE [dbo].[BIENBANVIPHAM]  WITH CHECK ADD  CONSTRAINT [FK_BIENBANVIPHAM_CUDAN] FOREIGN KEY([MACUDAN])
REFERENCES [dbo].[CUDAN] ([MACUDAN])
GO
ALTER TABLE [dbo].[BIENBANVIPHAM] CHECK CONSTRAINT [FK_BIENBANVIPHAM_CUDAN]
GO
ALTER TABLE [dbo].[CANHO]  WITH CHECK ADD  CONSTRAINT [FK_CANHO_LOAICANHO] FOREIGN KEY([MALOAI_CH])
REFERENCES [dbo].[LOAICANHO] ([MALOAI_CH])
GO
ALTER TABLE [dbo].[CANHO] CHECK CONSTRAINT [FK_CANHO_LOAICANHO]
GO
ALTER TABLE [dbo].[CANHO]  WITH CHECK ADD  CONSTRAINT [FK_CANHO_TANGLAU] FOREIGN KEY([MATANGLAU])
REFERENCES [dbo].[TANGLAU] ([MATANGLAU])
GO
ALTER TABLE [dbo].[CANHO] CHECK CONSTRAINT [FK_CANHO_TANGLAU]
GO
ALTER TABLE [dbo].[CHITIET_HDTT]  WITH CHECK ADD  CONSTRAINT [FK_CHITIET_HDTT_CHIPHI_THANHTOAN] FOREIGN KEY([MACHIPHI])
REFERENCES [dbo].[CHIPHI_THANHTOAN] ([MACHIPHI])
GO
ALTER TABLE [dbo].[CHITIET_HDTT] CHECK CONSTRAINT [FK_CHITIET_HDTT_CHIPHI_THANHTOAN]
GO
ALTER TABLE [dbo].[CHITIET_HDTT]  WITH CHECK ADD  CONSTRAINT [FK_CHITIET_HDTT_HOADON_THANHTOAN] FOREIGN KEY([MAHD_THANHTOAN])
REFERENCES [dbo].[HOADON_THANHTOAN] ([MAHD_THANHTOAN])
GO
ALTER TABLE [dbo].[CHITIET_HDTT] CHECK CONSTRAINT [FK_CHITIET_HDTT_HOADON_THANHTOAN]
GO
ALTER TABLE [dbo].[CHITIET_VIPHAM]  WITH CHECK ADD  CONSTRAINT [FK_CHITIET_VIPHAM_BIENBANVIPHAM] FOREIGN KEY([MABIENBAN])
REFERENCES [dbo].[BIENBANVIPHAM] ([MABIENBAN])
GO
ALTER TABLE [dbo].[CHITIET_VIPHAM] CHECK CONSTRAINT [FK_CHITIET_VIPHAM_BIENBANVIPHAM]
GO
ALTER TABLE [dbo].[CHITIET_VIPHAM]  WITH CHECK ADD  CONSTRAINT [FK_CHITIET_VIPHAM_DANHSACH_VIPHAM] FOREIGN KEY([MAVIPHAM])
REFERENCES [dbo].[DANHSACH_VIPHAM] ([MAVIPHAM])
GO
ALTER TABLE [dbo].[CHITIET_VIPHAM] CHECK CONSTRAINT [FK_CHITIET_VIPHAM_DANHSACH_VIPHAM]
GO
ALTER TABLE [dbo].[CUDAN-CANHO]  WITH CHECK ADD  CONSTRAINT [FK_CUDAN-CANHO_CANHO] FOREIGN KEY([MACANHO])
REFERENCES [dbo].[CANHO] ([MACANHO])
GO
ALTER TABLE [dbo].[CUDAN-CANHO] CHECK CONSTRAINT [FK_CUDAN-CANHO_CANHO]
GO
ALTER TABLE [dbo].[CUDAN-CANHO]  WITH CHECK ADD  CONSTRAINT [FK_CUDAN-CANHO_CUDAN] FOREIGN KEY([MACUDAN])
REFERENCES [dbo].[CUDAN] ([MACUDAN])
GO
ALTER TABLE [dbo].[CUDAN-CANHO] CHECK CONSTRAINT [FK_CUDAN-CANHO_CUDAN]
GO
ALTER TABLE [dbo].[DONGIA_CPTT]  WITH CHECK ADD  CONSTRAINT [FK_DONGIA_CPTT_CHIPHI_THANHTOAN] FOREIGN KEY([MACHIPHI])
REFERENCES [dbo].[CHIPHI_THANHTOAN] ([MACHIPHI])
GO
ALTER TABLE [dbo].[DONGIA_CPTT] CHECK CONSTRAINT [FK_DONGIA_CPTT_CHIPHI_THANHTOAN]
GO
ALTER TABLE [dbo].[HOADON_THANHTOAN]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_THANHTOAN_NHANVIEN_TOANHA] FOREIGN KEY([MANHANVIEN])
REFERENCES [dbo].[NHANVIEN_TOANHA] ([MANHANVIEN])
GO
ALTER TABLE [dbo].[HOADON_THANHTOAN] CHECK CONSTRAINT [FK_HOADON_THANHTOAN_NHANVIEN_TOANHA]
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOAN_NHOM_TAIKHOAN] FOREIGN KEY([MANHOM_TAIKHOAN])
REFERENCES [dbo].[NHOM_TAIKHOAN] ([MANHOM_TAIKHOAN])
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [FK_TAIKHOAN_NHOM_TAIKHOAN]
GO
ALTER TABLE [dbo].[TANGLAU]  WITH CHECK ADD  CONSTRAINT [FK_TANGLAU_CHUNGCU] FOREIGN KEY([MABLOCK])
REFERENCES [dbo].[TOANHA] ([MABLOCK])
GO
ALTER TABLE [dbo].[TANGLAU] CHECK CONSTRAINT [FK_TANGLAU_CHUNGCU]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "CANHO"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "CUDAN-CANHO"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 421
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CUDAN"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 261
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "LOAICANHO"
            Begin Extent = 
               Top = 138
               Left = 299
               Bottom = 268
               Right = 474
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "TANGLAU"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 383
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TOANHA"
            Begin Extent = 
               Top = 270
               Left = 246
               Bottom = 366
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Ali' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEW_NhanKhau'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'as = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEW_NhanKhau'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEW_NhanKhau'
GO

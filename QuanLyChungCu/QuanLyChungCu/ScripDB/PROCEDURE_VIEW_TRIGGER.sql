
/****** Object:  StoredProcedure [dbo].[PR_login]    Script Date: 26-Jun-20 4:43:55 PM ******/
-- proc Login
CREATE PROCEDURE [dbo].[PR_login] 
 @username varchar(30), @password varchar(30)
AS
BEGIN
	SELECT * FROM TAIKHOAN WHERE TENDANGNHAP = @username and MATKHAU = @password
END

GO
-- Tao View Nhan Khau
CREATE VIEW VIEW_NhanKhau AS 

WITH DSCuDan (ID,TENBLOCK,TENTANGLAU,TENLOAI_CH, DIENTICH, SOPHONGNGU, SONGUOITOIDA, NGAYBATDAUO,NGAYHETO, TENCANHO, TENCUDAN,NGAYSINH, SODIENTHOAI, CHUHO, SONGUOIO,GIOITINH,CMND_CUDAN)  
	AS  
	(  
		SELECT       dbo.[CUDAN-CANHO].ID, dbo.TOANHA.TENBLOCK, dbo.TANGLAU.TENTANGLAU, dbo.LOAICANHO.TENLOAI_CH, dbo.LOAICANHO.DIENTICH, dbo.LOAICANHO.SOPHONGNGU, dbo.LOAICANHO.SONGUOITOIDA, dbo.[CUDAN-CANHO].NGAYBATDAUO, 
								 dbo.[CUDAN-CANHO].NGAYHETO, dbo.CANHO.TENCANHO, dbo.CUDAN.TENCUDAN, dbo.CUDAN.NGAYSINH, dbo.CUDAN.SODIENTHOAI, dbo.CANHO.CHUHO, dbo.CANHO.SONGUOIO, dbo.CUDAN.GIOITINH, 
								 dbo.CUDAN.CHUNGMINHNHANDAN AS CMND_CUDAN
		FROM            dbo.CANHO INNER JOIN
								 dbo.[CUDAN-CANHO] ON dbo.CANHO.MACANHO = dbo.[CUDAN-CANHO].MACANHO INNER JOIN
								 dbo.CUDAN ON dbo.[CUDAN-CANHO].MACUDAN = dbo.CUDAN.MACUDAN INNER JOIN
								 dbo.LOAICANHO ON dbo.CANHO.MALOAI_CH = dbo.LOAICANHO.MALOAI_CH INNER JOIN
								 dbo.TANGLAU ON dbo.CANHO.MATANGLAU = dbo.TANGLAU.MATANGLAU INNER JOIN
								 dbo.TOANHA ON dbo.TANGLAU.MABLOCK = dbo.TOANHA.MABLOCK
	   WHERE dbo.[CUDAN-CANHO].NGAYHETO is null				 
 
	)  
SELECT c.*,cd.TENCUDAN AS TENCHUHO , cd.CHUNGMINHNHANDAN  as CMND_CHUHO
FROM DSCuDan  c
LEFT JOIN CUDAN cd on c.CHUHO = cd.MACUDAN
GO

/****** Object:  StoredProcedure [dbo].[PR_InserResident]    Script Date: 26-Jun-20 4:43:55 PM ******/
CREATE PROCEDURE [dbo].[PR_INSERT_CUDAN]
 @TenCuDan nvarchar(50),@NgaySinh date,@SoDienThoai varchar(10),@Cmnd varchar(10) , @GioiTinh int
AS
BEGIN	
	INSERT [dbo].[CUDAN] ([TENCUDAN], [NGAYSINH], [SODIENTHOAI], [CHUNGMINHNHANDAN] , [GIOITINH]) VALUES (@TenCuDan, @NgaySinh, @SoDienThoai, @Cmnd ,@GioiTinh)	
END
GO

CREATE PROCEDURE [dbo].[PR_UPDATE_CUDAN]
 @MaCuDan int, @TenCuDan nvarchar(50), @NgaySinh date, @SoDienThoai varchar(10), @Cmnd varchar(10) , @GioiTinh int
AS
BEGIN	
	UPDATE [dbo].[CUDAN] 
	SET [TENCUDAN] = @TenCuDan, [NGAYSINH] = @NgaySinh, [SODIENTHOAI] = @SoDienThoai , [CHUNGMINHNHANDAN] = @Cmnd, [GIOITINH] = @GioiTinh
	WHERE [MACUDAN] = @MaCuDan	
END
GO

CREATE PROC INSERT_APARTMENT 
	@MaCanHo varchar(10), @MaTangLau varchar(30),@MaLoaiCH varchar(30),@TenCanHo nvarchar(30),@SoNguoiO int, @ChuHo int
AS
BEGIN
	INSERT CANHO (MACANHO , MATANGLAU , MALOAI_CH , TENCANHO , SONGUOIO , CHUHO) VALUE (@MaCanHo , @TenCanHo,@MaLoaiCH,@TenCanHo,@SoNguoiO,@ChuHo)
END
Go

CREATE PROC UPDATE_APARTMENT 
	@MaCanHo varchar(10), @MaTangLau varchar(30),@MaLoaiCH varchar(30),@TenCanHo nvarchar(30),@SoNguoiO int,@ChuHo int
AS
BEGIN
	UPDATE CANHO 
	SET MATANGLAU = @MaTangLau , MALOAI_CH = @MaLoaiCH , TENCANHO = @TenCanHo , SONGUOIO = @SoNguoiO , CHUHO = @ChuHo
	WHERE MACANHO = @MaCanHo
END
GO


create proc  PR_INSERT_CUDAN_CANHO 
	@MaCuDan int , @MaCanHo varchar(30) 
as
begin	
	INSERT [dbo].[CUDAN-CANHO] ([MACUDAN], [MACANHO], [NGAYBATDAUO], [NGAYHETO]) 
	VALUES (@MaCuDan, @MaCanHo, GetDate(), Null)	
end
go

create proc  PR_UPDATE_CUDAN_CANHO
	@Id int ,@MaCuDan int , @MaCanHo varchar(30) , @NgayVaoO date, @NgayHetO date
as
begin	
	UPDATE [dbo].[CUDAN-CANHO] 
	SET [NGAYBATDAUO] = @NgayVaoO, [NGAYHETO] =  @NgayHetO	
	WHERE ID = @Id
end
go
-- Lấy thông tin chủ hộ từ căn hộ
create proc PR_LayThongTinChuHo 
	@maCanHo varchar(30)
AS
BEGIN
	SELECT * FROM CUDAN cd
	INNER JOIN CANHO ch ON cd.MACUDAN = ch.CHUHO
END
GO



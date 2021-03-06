USE [master]
GO
/****** Object:  Database [LT.Net]    Script Date: 28/10/2017 13:01:36 ******/
CREATE DATABASE [LT.Net]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LT.Net', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\LT.Net.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'LT.Net_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\LT.Net_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [LT.Net] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LT.Net].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LT.Net] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LT.Net] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LT.Net] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LT.Net] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LT.Net] SET ARITHABORT OFF 
GO
ALTER DATABASE [LT.Net] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LT.Net] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LT.Net] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LT.Net] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LT.Net] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LT.Net] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LT.Net] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LT.Net] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LT.Net] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LT.Net] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LT.Net] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LT.Net] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LT.Net] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LT.Net] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LT.Net] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LT.Net] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LT.Net] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LT.Net] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LT.Net] SET  MULTI_USER 
GO
ALTER DATABASE [LT.Net] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LT.Net] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LT.Net] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LT.Net] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [LT.Net] SET DELAYED_DURABILITY = DISABLED 
GO
USE [LT.Net]
GO
/****** Object:  Table [dbo].[BookRoom]    Script Date: 28/10/2017 13:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookRoom](
	[MaBookRoom] [int] NOT NULL,
	[MaPhong] [int] NULL,
	[BookRoomStart] [datetime] NULL,
	[SoLuongKhach] [int] NULL,
	[BookRoomTill] [datetime] NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_BookRoom] PRIMARY KEY CLUSTERED 
(
	[MaBookRoom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CheckOut]    Script Date: 28/10/2017 13:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CheckOut](
	[MaKH] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[MaBookRoom] [int] NOT NULL,
 CONSTRAINT [PK_CheckOut_1] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC,
	[MaBookRoom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 28/10/2017 13:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaCV] [int] NOT NULL,
	[TenCV] [nvarchar](max) NULL,
	[HSLuong] [float] NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTDichVu]    Script Date: 28/10/2017 13:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTDichVu](
	[MaDV] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[NgaySD] [datetime] NOT NULL,
	[MaBookRoom] [int] NOT NULL,
 CONSTRAINT [PK_CTDichVu] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC,
	[MaBookRoom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTHoaDon]    Script Date: 28/10/2017 13:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHoaDon](
	[MaHD] [int] NOT NULL,
	[MaBookRoom] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[ThanhTien] [float] NOT NULL,
 CONSTRAINT [PK_CTHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaBookRoom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 28/10/2017 13:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDV] [int] NOT NULL,
	[TenDv] [nvarchar](max) NOT NULL,
	[TrangThai] [bit] NOT NULL,
	[Gia] [float] NOT NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 28/10/2017 13:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [int] NOT NULL,
	[TongTien] [float] NOT NULL,
	[NgayThanhToan] [datetime] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 28/10/2017 13:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] NOT NULL,
	[TenKH] [nvarchar](max) NOT NULL,
	[DiaChi] [nvarchar](max) NOT NULL,
	[SDT] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[TrangThai] [nvarchar](max) NOT NULL,
	[Anh] [nvarchar](max) NOT NULL,
	[CMT] [int] NULL,
	[NamSinh] [int] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhuVuc]    Script Date: 28/10/2017 13:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuVuc](
	[MaKV] [int] NOT NULL,
	[TenKV] [nvarchar](50) NULL,
	[MoTa] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhuVuc] PRIMARY KEY CLUSTERED 
(
	[MaKV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LichDonPhong]    Script Date: 28/10/2017 13:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichDonPhong](
	[MaBookRoom] [int] NOT NULL,
	[MaNV] [int] NOT NULL,
	[NgayLam] [datetime] NOT NULL,
	[TrangThai] [bit] NULL,
	[MaLich] [int] NOT NULL,
 CONSTRAINT [PK_LichDonPhong_1] PRIMARY KEY CLUSTERED 
(
	[MaLich] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 28/10/2017 13:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiPhong](
	[MaLoaiPhong] [int] NOT NULL,
	[TenLoaiPhong] [nvarchar](max) NOT NULL,
	[GiaPhong] [float] NOT NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_LoaiPhong] PRIMARY KEY CLUSTERED 
(
	[MaLoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Menu]    Script Date: 28/10/2017 13:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[SoLuong] [int] NOT NULL,
	[TrangThai] [bit] NOT NULL,
	[MaBookRoom] [int] NOT NULL,
	[MaMonAn] [int] NOT NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [PK_Menu_1] PRIMARY KEY CLUSTERED 
(
	[MaBookRoom] ASC,
	[MaMonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 28/10/2017 13:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] NOT NULL,
	[TenNV] [nvarchar](max) NULL,
	[NgaySinh] [datetime] NULL,
	[DiaChi] [nvarchar](max) NULL,
	[GioiTinh] [int] NULL,
	[AnhNV] [int] NULL,
	[TrangThai] [bit] NULL,
	[SDT] [int] NULL,
	[Email] [nvarchar](max) NULL,
	[NgayBDL] [datetime] NULL,
	[Password] [nvarchar](max) NULL,
	[Luong] [float] NULL,
	[MaCV] [int] NULL,
	[MaPhongBan] [int] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 28/10/2017 13:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[MaTaiKhoan] [nvarchar](50) NOT NULL,
	[TrangChu] [bit] NULL,
	[TiepNhanKhach] [bit] NULL,
	[DanhSachPhong] [bit] NULL,
	[LoaiPhong] [bit] NULL,
	[DichVu] [bit] NULL,
	[ThucDon] [bit] NULL,
	[PhongBan] [bit] NULL,
	[KhuVuc] [bit] NULL,
	[ThongTinKhach] [bit] NULL,
	[ThongTinNV] [bit] NULL,
	[DanhSachHD] [bit] NULL,
	[ChucVu] [bit] NULL,
	[LichDonPhong] [bit] NULL,
	[TKCuaTui] [bit] NULL,
	[MaNV] [int] NULL,
	[PhanQuyen] [bit] NULL,
 CONSTRAINT [PK_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[MaTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Phong]    Script Date: 28/10/2017 13:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [int] NOT NULL,
	[TenPhong] [nvarchar](max) NOT NULL,
	[MaLoaiPhong] [int] NOT NULL,
	[AnhPhong] [nvarchar](max) NOT NULL,
	[MoTa] [nvarchar](max) NOT NULL,
	[ViTri] [nvarchar](max) NOT NULL,
	[TrangThai] [bit] NOT NULL,
	[NguoiLon] [int] NOT NULL,
	[TreEm] [int] NOT NULL,
	[Gia] [float] NOT NULL,
	[MaBookRoom] [int] NULL,
	[MaKV] [int] NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 28/10/2017 13:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[MaPhongBan] [int] NOT NULL,
	[TenPhongBan] [nvarchar](50) NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_PhongBan] PRIMARY KEY CLUSTERED 
(
	[MaPhongBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TTMonAn]    Script Date: 28/10/2017 13:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TTMonAn](
	[MaMonAn] [int] NOT NULL,
	[TenMonAn] [nvarchar](max) NOT NULL,
	[MoTa] [nvarchar](max) NOT NULL,
	[Anh] [nvarchar](max) NOT NULL,
	[Gia] [float] NULL,
 CONSTRAINT [PK_TTMonAn] PRIMARY KEY CLUSTERED 
(
	[MaMonAn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VatDung]    Script Date: 28/10/2017 13:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VatDung](
	[MaVD] [int] NOT NULL,
	[MaPhong] [int] NOT NULL,
	[KichThuoc] [nvarchar](max) NOT NULL,
	[TTWiFi] [bit] NOT NULL,
	[SLGiuong] [nvarchar](max) NOT NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK_VatDung_1] PRIMARY KEY CLUSTERED 
(
	[MaVD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[ChucVu] ([MaCV], [TenCV], [HSLuong]) VALUES (1, N'Admin', 0)
INSERT [dbo].[ChucVu] ([MaCV], [TenCV], [HSLuong]) VALUES (2, N'Giám Đốc', 1.5)
INSERT [dbo].[ChucVu] ([MaCV], [TenCV], [HSLuong]) VALUES (3, N'Lễ Tân', 0.2)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [GiaPhong], [TrangThai]) VALUES (1, N'VIP', 50000, 1)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [GiaPhong], [TrangThai]) VALUES (2, N'Thường', 120000, 0)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [GiaPhong], [TrangThai]) VALUES (3, N'VIP đôi', 320000, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [DiaChi], [GioiTinh], [AnhNV], [TrangThai], [SDT], [Email], [NgayBDL], [Password], [Luong], [MaCV], [MaPhongBan]) VALUES (1, N'abc', NULL, NULL, 1, NULL, 1, NULL, N'Admin', NULL, N'1234', NULL, 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [DiaChi], [GioiTinh], [AnhNV], [TrangThai], [SDT], [Email], [NgayBDL], [Password], [Luong], [MaCV], [MaPhongBan]) VALUES (2, N'Nguyễn Hồng Cẩm', CAST(N'1997-04-09 00:00:00.000' AS DateTime), N'Hà Nội', 1, NULL, 1, 981792327, N'Admin1', CAST(N'2016-01-01 00:00:00.000' AS DateTime), N'1234', NULL, 2, 3)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [DiaChi], [GioiTinh], [AnhNV], [TrangThai], [SDT], [Email], [NgayBDL], [Password], [Luong], [MaCV], [MaPhongBan]) VALUES (3, N'Nguyễn Văn A', CAST(N'1990-01-01 00:00:00.000' AS DateTime), N'Hàn Quốc', 0, NULL, 1, 123456, N'Admin2', CAST(N'2016-01-01 00:00:00.000' AS DateTime), N'1234', NULL, 3, 2)
INSERT [dbo].[PhanQuyen] ([MaTaiKhoan], [TrangChu], [TiepNhanKhach], [DanhSachPhong], [LoaiPhong], [DichVu], [ThucDon], [PhongBan], [KhuVuc], [ThongTinKhach], [ThongTinNV], [DanhSachHD], [ChucVu], [LichDonPhong], [TKCuaTui], [MaNV], [PhanQuyen]) VALUES (N'1', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[PhanQuyen] ([MaTaiKhoan], [TrangChu], [TiepNhanKhach], [DanhSachPhong], [LoaiPhong], [DichVu], [ThucDon], [PhongBan], [KhuVuc], [ThongTinKhach], [ThongTinNV], [DanhSachHD], [ChucVu], [LichDonPhong], [TKCuaTui], [MaNV], [PhanQuyen]) VALUES (N'2', 0, 0, 1, 0, 1, 0, 0, 1, 1, 1, 1, 1, 0, 1, 2, 0)
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [TrangThai]) VALUES (1, N'Admin', 1)
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [TrangThai]) VALUES (2, N'Lễ Tân', 1)
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [TrangThai]) VALUES (3, N'Giám Đốc', 1)
ALTER TABLE [dbo].[CheckOut]  WITH CHECK ADD  CONSTRAINT [FK_CheckOut_BookRoom1] FOREIGN KEY([MaBookRoom])
REFERENCES [dbo].[BookRoom] ([MaBookRoom])
GO
ALTER TABLE [dbo].[CheckOut] CHECK CONSTRAINT [FK_CheckOut_BookRoom1]
GO
ALTER TABLE [dbo].[CheckOut]  WITH CHECK ADD  CONSTRAINT [FK_CheckOut_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[CheckOut] CHECK CONSTRAINT [FK_CheckOut_KhachHang]
GO
ALTER TABLE [dbo].[CTDichVu]  WITH CHECK ADD  CONSTRAINT [FK_CTDichVu_BookRoom] FOREIGN KEY([MaBookRoom])
REFERENCES [dbo].[BookRoom] ([MaBookRoom])
GO
ALTER TABLE [dbo].[CTDichVu] CHECK CONSTRAINT [FK_CTDichVu_BookRoom]
GO
ALTER TABLE [dbo].[CTDichVu]  WITH CHECK ADD  CONSTRAINT [FK_CTDichVu_DichVu1] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DichVu] ([MaDV])
GO
ALTER TABLE [dbo].[CTDichVu] CHECK CONSTRAINT [FK_CTDichVu_DichVu1]
GO
ALTER TABLE [dbo].[CTHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_CTHoaDon_BookRoom1] FOREIGN KEY([MaBookRoom])
REFERENCES [dbo].[BookRoom] ([MaBookRoom])
GO
ALTER TABLE [dbo].[CTHoaDon] CHECK CONSTRAINT [FK_CTHoaDon_BookRoom1]
GO
ALTER TABLE [dbo].[CTHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_CTHoaDon_HoaDon1] FOREIGN KEY([MaBookRoom])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[CTHoaDon] CHECK CONSTRAINT [FK_CTHoaDon_HoaDon1]
GO
ALTER TABLE [dbo].[LichDonPhong]  WITH CHECK ADD  CONSTRAINT [FK_LichDonPhong_BookRoom1] FOREIGN KEY([MaBookRoom])
REFERENCES [dbo].[BookRoom] ([MaBookRoom])
GO
ALTER TABLE [dbo].[LichDonPhong] CHECK CONSTRAINT [FK_LichDonPhong_BookRoom1]
GO
ALTER TABLE [dbo].[LichDonPhong]  WITH CHECK ADD  CONSTRAINT [FK_LichDonPhong_NhanVien1] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[LichDonPhong] CHECK CONSTRAINT [FK_LichDonPhong_NhanVien1]
GO
ALTER TABLE [dbo].[Menu]  WITH CHECK ADD  CONSTRAINT [FK_Menu_BookRoom1] FOREIGN KEY([MaBookRoom])
REFERENCES [dbo].[BookRoom] ([MaBookRoom])
GO
ALTER TABLE [dbo].[Menu] CHECK CONSTRAINT [FK_Menu_BookRoom1]
GO
ALTER TABLE [dbo].[Menu]  WITH CHECK ADD  CONSTRAINT [FK_Menu_TTMonAn] FOREIGN KEY([MaMonAn])
REFERENCES [dbo].[TTMonAn] ([MaMonAn])
GO
ALTER TABLE [dbo].[Menu] CHECK CONSTRAINT [FK_Menu_TTMonAn]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_PhongBan] FOREIGN KEY([MaPhongBan])
REFERENCES [dbo].[PhongBan] ([MaPhongBan])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_PhongBan]
GO
ALTER TABLE [dbo].[PhanQuyen]  WITH CHECK ADD  CONSTRAINT [FK_PhanQuyen_NhanVien1] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhanQuyen] CHECK CONSTRAINT [FK_PhanQuyen_NhanVien1]
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [FK_Phong_BookRoom1] FOREIGN KEY([MaBookRoom])
REFERENCES [dbo].[BookRoom] ([MaBookRoom])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [FK_Phong_BookRoom1]
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [FK_Phong_KhuVuc] FOREIGN KEY([MaKV])
REFERENCES [dbo].[KhuVuc] ([MaKV])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [FK_Phong_KhuVuc]
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [FK_Phong_LoaiPhong1] FOREIGN KEY([MaLoaiPhong])
REFERENCES [dbo].[LoaiPhong] ([MaLoaiPhong])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [FK_Phong_LoaiPhong1]
GO
ALTER TABLE [dbo].[VatDung]  WITH CHECK ADD  CONSTRAINT [FK_VatDung_Phong1] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[VatDung] CHECK CONSTRAINT [FK_VatDung_Phong1]
GO
/****** Object:  StoredProcedure [dbo].[sp_ChucVuGet_By_Top]    Script Date: 28/10/2017 13:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ChucVuGet_By_Top]
@top NVARCHAR(50),
@where NVARCHAR(50),
@order NVARCHAR(50)
AS
BEGIN
	DECLARE @sql NVARCHAR(50);
	SET @sql  = ' SELECT ';
	IF(LEN(@top) > 0)
	BEGIN
		SET @sql = @sql +' TOP '+ @top;
	END
    SET @sql = @sql + ' * FROM dbo.ChucVu '
	IF(LEN(@where) > 0)
	BEGIN
		SET @sql = @sql +' WHERE '+ @where;
	END
	IF(LEN(@order) > 0)
	BEGIN
		SET @sql = @sql +' order by ' +@order;
	END
	EXEC (@sql);
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Insearch_PQ]    Script Date: 28/10/2017 13:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Insearch_PQ]
@MaTaiKhoan NVARCHAR(50),
@TrangChu BIT,
@TiepNhanKhach BIT,
@DanhSachPhong BIT,
@LoaiPhong BIT,
@DichVu BIT,
@ThucDon BIT,
@PhongBan BIT,
@KhuVuc BIT,
@ThongTinKhach BIT,
@ThongTinNV BIT,
@DanhSachHD BIT,
@ChucVu BIT,
@LichDonPhong BIT,
@TKCuaTui BIT,
@MaNV int,
@PhanQuyen  BIT
AS
BEGIN
	UPDATE dbo.PhanQuyen SET TrangChu =@TrangChu , -- TrangChu - bit
	        TiepNhanKhach=   @TiepNhanKhach , -- TiepNhanKhach - bit
	         DanhSachPhong=  @DanhSachPhong , -- DanhSachPhong - bit
	        LoaiPhong=  @LoaiPhong , -- LoaiPhong - bit
	         DichVu=  @DichVu , -- DichVu - bit
	       ThucDon =   @ThucDon , -- ThucDon - bit
	        PhongBan =  @PhongBan , -- PhongBan - bit
	       KhuVuc =   @KhuVuc , -- KhuVuc - bit
	        ThongTinKhach =  @ThongTinKhach , -- ThongTinKhach - bit
	         ThongTinNV = @ThongTinNV , -- ThongTinNV - bit
	         DanhSachHD = @DanhSachHD , -- DanhSachHD - bit
	       ChucVu =   @ChucVu , -- ChucVu - bit
	       LichDonPhong =   @LichDonPhong , -- LichDonPhong - bit
	        TKCuaTui =  @TKCuaTui , -- TKCuaTui - bit
	     PhanQuyen= @PhanQuyen  -- PhanQuyen - bit
	WHERE dbo.PhanQuyen.MaTaiKhoan = @MaTaiKhoan AND dbo.PhanQuyen.MaNV = @MaNV
END

GO
/****** Object:  StoredProcedure [dbo].[sp_LoaiPhong_Get_By_Top]    Script Date: 28/10/2017 13:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_LoaiPhong_Get_By_Top]
@top NVARCHAR(50),
@where NVARCHAR(50),
@order NVARCHAR(50)
AS
BEGIN
	DECLARE @sql NVARCHAR(max);
	SET @sql  = ' SELECT ';
	DECLARE @str NVARCHAR(max);
	SET @str = 	' MaLoaiPhong ,TenLoaiPhong ,GiaPhong,
				  CASE  
					 WHEN TrangThai = 1 THEN N'''+N'Hoạt Động' + '''  
					 ELSE N'''+N'Không hoạt Động' + '''  
				 END as TrangThai 
				 FROM dbo.LoaiPhong ';
	IF(LEN(@top) > 0)
	BEGIN
		SET @sql = @sql +' TOP '+ @top;
	END
    SET @sql = @sql + 	@str;
	IF(LEN(@where) > 0)
	BEGIN
		SET @sql = @sql +' WHERE '+ @where;
	END
	IF(LEN(@order) > 0)
	BEGIN
		SET @sql = @sql +' order by ' +@order;
	END
	EXEC (@sql);
END

GO
/****** Object:  StoredProcedure [dbo].[sp_login]    Script Date: 28/10/2017 13:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_login]	
	@email NVARCHAR(50),
	@pass NVARCHAR(50)
AS
BEGIN
	SELECT * FROM dbo.NhanVien WHERE Email = @email AND Password = @pass
END

GO
/****** Object:  StoredProcedure [dbo].[sp_PQ_Get_By_Top]    Script Date: 28/10/2017 13:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_PQ_Get_By_Top]

AS
BEGIN
	SELECT  MaTaiKhoan,TenNv,NhanVien.MaNV,TenCV, TrangChu,TiepNhanKhach, DanhSachPhong, LoaiPhong, DichVu, ThucDon, PhongBan, KhuVuc,
	ThongTinKhach,ThongTinNV,DanhSachHD,ChucVu,LichDonPhong,TKCuaTui,PhanQuyen  FROM dbo.PhanQuyen,dbo.NhanVien,dbo.ChucVu WHERE NhanVien.MaNV = PhanQuyen.MaNV	AND ChucVu.MaCV = NhanVien.MaCV
END
GO
/****** Object:  StoredProcedure [dbo].[sp_PQ_Get_By_Top1]    Script Date: 28/10/2017 13:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[sp_PQ_Get_By_Top1]


@email NVARCHAR(50),
@pass NVARCHAR(50)

AS
BEGIN
	SELECT * FROM dbo.PhanQuyen, dbo.NhanVien WHERE NhanVien.MaNV = PhanQuyen.MaNV AND Email = @email AND Password=@pass
	END

GO
/****** Object:  StoredProcedure [dbo].[sp_Search_PQ]    Script Date: 28/10/2017 13:01:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Search_PQ]
@tk NVARCHAR(50),
@tennv NVARCHAR(50),
@manv NVARCHAR(50),
@tencv NVARCHAR(50)
AS
BEGIN
	DECLARE @sql NVARCHAR(max);
	SET @sql =  'SELECT  MaTaiKhoan,TenNv,NhanVien.MaNV,TenCV, TrangChu,TiepNhanKhach, DanhSachPhong, LoaiPhong, DichVu, ThucDon, PhongBan, KhuVuc,
	ThongTinKhach,ThongTinNV,DanhSachHD,ChucVu,LichDonPhong,TKCuaTui,PhanQuyen  
	FROM dbo.PhanQuyen,dbo.NhanVien,dbo.ChucVu WHERE NhanVien.MaNV = PhanQuyen.MaNV	AND ChucVu.MaCV = NhanVien.MaCV ';
	IF(LEN(@tk)>0)
	BEGIN
		SET @sql = @sql + ' AND MaTaiKhoan LIKE ''%'+ @tk +'%''';
	END	
	IF(LEN(@tennv)>0)
	BEGIN
		SET @sql = @sql + '  AND TenNV LIKE  ''%'+ @tennv +'%''';
	END	
	IF(LEN(@manv)>0)
	BEGIN
		SET @sql = @sql + '  AND NhanVien.MaNV LIKE ''%'+ @manv +'%''' ;
	END	
	IF(LEN(@tencv)>0)
	BEGIN
		SET @sql = @sql + '  AND TenCV LIKE  ''%'+ @tencv +'%''';
	END		
	EXEC(@sql)
END
GO
USE [master]
GO
ALTER DATABASE [LT.Net] SET  READ_WRITE 
GO

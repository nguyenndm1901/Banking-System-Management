USE [master]
GO
/****** Object:  Database [QLNH]    Script Date: 12/11/2020 3:04:43 PM ******/
CREATE DATABASE [QLNH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLNH', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLNH.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLNH_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLNH_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLNH] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLNH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLNH] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLNH] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLNH] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLNH] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLNH] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLNH] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLNH] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLNH] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLNH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLNH] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLNH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLNH] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLNH] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLNH] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLNH] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLNH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLNH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLNH] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLNH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLNH] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLNH] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLNH] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLNH] SET RECOVERY FULL 
GO
ALTER DATABASE [QLNH] SET  MULTI_USER 
GO
ALTER DATABASE [QLNH] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLNH] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLNH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLNH] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLNH] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLNH] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLNH', N'ON'
GO
ALTER DATABASE [QLNH] SET QUERY_STORE = OFF
GO
USE [QLNH]
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 12/11/2020 3:04:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[id] [varchar](9) NOT NULL,
	[hoten] [nvarchar](50) NOT NULL,
	[username] [varchar](20) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[password] [varchar](20) NOT NULL,
	[usertype] [nvarchar](11) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaHanVayVon]    Script Date: 12/11/2020 3:04:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaHanVayVon](
	[id] [varchar](11) NOT NULL,
	[tenKH] [nvarchar](50) NOT NULL,
	[maHoSo] [varchar](11) NOT NULL,
	[lyDo] [nvarchar](200) NOT NULL,
	[kyHanCu] [smallint] NOT NULL,
	[kyHanMoi] [smallint] NOT NULL,
	[ngayDangKy] [date] NOT NULL,
	[tinhTrang] [nvarchar](10) NULL,
	[nhanVienDuyet] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoSoVayVon]    Script Date: 12/11/2020 3:04:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoSoVayVon](
	[id] [varchar](11) NOT NULL,
	[tenKH] [nvarchar](50) NOT NULL,
	[soTien] [bigint] NOT NULL,
	[ngayDangKy] [date] NOT NULL,
	[kyHan] [smallint] NOT NULL,
	[nhanVienDuyet] [nvarchar](50) NOT NULL,
	[tinhTrang] [nvarchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DangNhap] ([id], [hoten], [username], [email], [password], [usertype]) VALUES (N'KH-555-39', N'Khách Hàng 2', N'client2', N'client2', N'1231234', N'Khách Hàng')
INSERT [dbo].[DangNhap] ([id], [hoten], [username], [email], [password], [usertype]) VALUES (N'KH-624-54', N'Khách hàng 1', N'client1', N'client1@client.com', N'client', N'Khách Hàng')
INSERT [dbo].[DangNhap] ([id], [hoten], [username], [email], [password], [usertype]) VALUES (N'NH-000-01', N'Master', N'master', N'master@admin.com', N'masterkey', N'master')
INSERT [dbo].[DangNhap] ([id], [hoten], [username], [email], [password], [usertype]) VALUES (N'NH-234-62', N'Nhân viên 1', N'admin1', N'admin1@admin.com', N'1234', N'Ngân Hàng')
GO
INSERT [dbo].[GiaHanVayVon] ([id], [tenKH], [maHoSo], [lyDo], [kyHanCu], [kyHanMoi], [ngayDangKy], [tinhTrang], [nhanVienDuyet]) VALUES (N'GH-356-69', N'Khách hàng 1', N'HSVV-218-30', N'Kẹt tiền', 12, 24, CAST(N'2020-11-06' AS Date), N'Đang chờ', N'Chưa xác định')
INSERT [dbo].[GiaHanVayVon] ([id], [tenKH], [maHoSo], [lyDo], [kyHanCu], [kyHanMoi], [ngayDangKy], [tinhTrang], [nhanVienDuyet]) VALUES (N'GH-636-98', N'Khách hàng 1', N'HSVV-238-18', N'Kẹt tiền', 72, 720, CAST(N'2020-12-11' AS Date), N'Đang chờ', N'Chưa xác định')
INSERT [dbo].[GiaHanVayVon] ([id], [tenKH], [maHoSo], [lyDo], [kyHanCu], [kyHanMoi], [ngayDangKy], [tinhTrang], [nhanVienDuyet]) VALUES (N'GH-703-91', N'Khách hàng 1', N'HSVV-218-30', N'Kẹt tiền', 12, 13, CAST(N'2020-11-06' AS Date), N'Đang chờ', N'Chưa xác định')
GO
INSERT [dbo].[HoSoVayVon] ([id], [tenKH], [soTien], [ngayDangKy], [kyHan], [nhanVienDuyet], [tinhTrang]) VALUES (N'HSVV-182-5', N'Khách hàng 1', 20000000, CAST(N'2020-11-06' AS Date), 36, N'Nhân viên 1', N'Rejected')
INSERT [dbo].[HoSoVayVon] ([id], [tenKH], [soTien], [ngayDangKy], [kyHan], [nhanVienDuyet], [tinhTrang]) VALUES (N'HSVV-218-30', N'Khách hàng 1', 10000000, CAST(N'2020-11-06' AS Date), 12, N'Nhân viên 1', N'Rejected')
INSERT [dbo].[HoSoVayVon] ([id], [tenKH], [soTien], [ngayDangKy], [kyHan], [nhanVienDuyet], [tinhTrang]) VALUES (N'HSVV-238-18', N'Khách hàng 1', 100000000, CAST(N'2020-11-06' AS Date), 72, N'Nhân viên 1', N'Rejected')
INSERT [dbo].[HoSoVayVon] ([id], [tenKH], [soTien], [ngayDangKy], [kyHan], [nhanVienDuyet], [tinhTrang]) VALUES (N'HSVV-989-23', N'Khách hàng 1', 123150000, CAST(N'2020-12-11' AS Date), 12, N'Nhân viên 1', N'Accepted')
GO
USE [master]
GO
ALTER DATABASE [QLNH] SET  READ_WRITE 
GO

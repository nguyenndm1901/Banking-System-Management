USE [master]
GO
/****** Object:  Database [QLNH]    Script Date: 11/6/2020 2:33:53 AM ******/
CREATE DATABASE [QLNH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLNH', FILENAME = N'H:\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLNH.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLNH_log', FILENAME = N'H:\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLNH_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
/****** Object:  Table [dbo].[DangNhap]    Script Date: 11/6/2020 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[username] [varchar](20) NULL,
	[password] [varchar](20) NULL,
	[email] [varchar](20) NULL,
	[usertype] [nvarchar](11) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoSoVayVon]    Script Date: 11/6/2020 2:33:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoSoVayVon](
	[tenKH] [nvarchar](50) NOT NULL,
	[soTien] [bigint] NOT NULL,
	[ngayDangKy] [date] NOT NULL,
	[kyHan] [smallint] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[DangNhap] ([username], [password], [email], [usertype]) VALUES (N'admin', N'1231234', N'admin@admin.com', N'Ngân Hàng')
INSERT [dbo].[DangNhap] ([username], [password], [email], [usertype]) VALUES (N'admin1', N'admin123', N'admin1@admin.com', N'Ngân Hàng')
INSERT [dbo].[DangNhap] ([username], [password], [email], [usertype]) VALUES (N'admin2', N'admin123', N'admin2@admin.com', N'Ngân Hàng')
INSERT [dbo].[DangNhap] ([username], [password], [email], [usertype]) VALUES (N'client', N'1231234', N'client@client.com', N'Khách Hàng')
INSERT [dbo].[DangNhap] ([username], [password], [email], [usertype]) VALUES (N'client2', N'1231234', N'client2@client.com', N'Khách Hàng')
INSERT [dbo].[DangNhap] ([username], [password], [email], [usertype]) VALUES (N'master', N'masterkeyword', N'master@admin.com', N'Admin')
GO
INSERT [dbo].[HoSoVayVon] ([tenKH], [soTien], [ngayDangKy], [kyHan]) VALUES (N'Nguy?n Van A', 100000000, CAST(N'2020-11-06' AS Date), 120)
INSERT [dbo].[HoSoVayVon] ([tenKH], [soTien], [ngayDangKy], [kyHan]) VALUES (N'Nguyễn Văn B', 20, CAST(N'2020-11-06' AS Date), 120)
GO
USE [master]
GO
ALTER DATABASE [QLNH] SET  READ_WRITE 
GO

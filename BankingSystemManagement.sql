CREATE DATABASE [QLNH]
GO

USE [QLNH]
GO 

CREATE TABLE DangNhap(
	[id] [varchar](9) PRIMARY KEY NOT NULL,
	[hoten] [nvarchar](50) NOT NULL,
	[username] [varchar](20) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[password] [varchar](20) NOT NULL,
	[usertype] [nvarchar](11) NOT NULL,
)

CREATE TABLE GiaHanVayVon(
	[id] [varchar](11) PRIMARY KEY NOT NULL,
	[tenKH] [nvarchar](50) NOT NULL,
	[maHoSo] [varchar](11) NOT NULL,
	[lyDo] [nvarchar](200) NOT NULL,
	[kyHanCu] [smallint] NOT NULL,
	[kyHanMoi] [smallint] NOT NULL,
	[ngayDangKy] [date] NOT NULL,
	[tinhTrang] [nvarchar](10) NOT NULL,
	[nhanVienDuyet] [nvarchar](50) NOT NULL,
)

CREATE TABLE HopDong(
	[id] [varchar](10) PRIMARY KEY NOT NULL,
	[maHoSo] [varchar](20) NOT NULL,
	[benA] [nvarchar](50) NOT NULL,
	[benB] [nvarchar](50) NOT NULL,
	[soTien] [nvarchar](15) NOT NULL,
	[kyHan] [smallint] NOT NULL,
	[taiSan] [nvarchar](500) NOT NULL,
	[ngayKy] date NOT NULL,
)

CREATE TABLE HoSoVayVon(
	[id] [varchar](11) PRIMARY KEY NOT NULL,
	[tenKH] [nvarchar](50) NOT NULL,
	[soTien] [nvarchar](15) NOT NULL,
	[ngayDangKy] [date] NOT NULL,
	[kyHan] [smallint] NOT NULL,
	[nhanVienDuyet] [nvarchar](50) NOT NULL,
	[tinhTrang] [nvarchar](15) NOT NULL,
)

GO
INSERT [dbo].[DangNhap] ([id], [hoten], [username], [email], [password], [usertype]) VALUES (N'KH-555-39', N'Khách Hàng 2', N'client2', N'client2', N'1231234', N'Khách Hàng')
INSERT [dbo].[DangNhap] ([id], [hoten], [username], [email], [password], [usertype]) VALUES (N'KH-624-54', N'Khách hàng 1', N'client1', N'client1@client.com', N'client', N'Khách Hàng')
INSERT [dbo].[DangNhap] ([id], [hoten], [username], [email], [password], [usertype]) VALUES (N'NH-000-01', N'Master', N'master', N'master@admin.com', N'masterkey', N'master')
INSERT [dbo].[DangNhap] ([id], [hoten], [username], [email], [password], [usertype]) VALUES (N'NH-234-62', N'Nhân viên 1', N'admin1', N'admin1@admin.com', N'1234', N'Ngân Hàng')
GO
INSERT [dbo].[GiaHanVayVon] ([id], [tenKH], [maHoSo], [lyDo], [kyHanCu], [kyHanMoi], [ngayDangKy], [tinhTrang], [nhanVienDuyet]) VALUES (N'GH-298-91', N'Khách hàng 1', N'HSVV-218-30', N'14', 13, 14, CAST(N'2020-12-14' AS Date), N'Đang chờ', N'Chưa xác định')
INSERT [dbo].[GiaHanVayVon] ([id], [tenKH], [maHoSo], [lyDo], [kyHanCu], [kyHanMoi], [ngayDangKy], [tinhTrang], [nhanVienDuyet]) VALUES (N'GH-356-69', N'Khách hàng 1', N'HSVV-218-30', N'Kẹt tiền', 24, 0, CAST(N'2020-11-06' AS Date), N'Accepted', N'Nhân viên 1')
INSERT [dbo].[GiaHanVayVon] ([id], [tenKH], [maHoSo], [lyDo], [kyHanCu], [kyHanMoi], [ngayDangKy], [tinhTrang], [nhanVienDuyet]) VALUES (N'GH-361-72', N'Khách hàng 1', N'HSVV-218-30', N'123123', 13, 14, CAST(N'2020-12-14' AS Date), N'Đang chờ', N'Chưa xác định')
INSERT [dbo].[GiaHanVayVon] ([id], [tenKH], [maHoSo], [lyDo], [kyHanCu], [kyHanMoi], [ngayDangKy], [tinhTrang], [nhanVienDuyet]) VALUES (N'GH-466-96', N'Khách hàng 1', N'HSVV-238-18', N'78', 72, 78, CAST(N'2020-12-14' AS Date), N'Đang chờ', N'Chưa xác định')
INSERT [dbo].[GiaHanVayVon] ([id], [tenKH], [maHoSo], [lyDo], [kyHanCu], [kyHanMoi], [ngayDangKy], [tinhTrang], [nhanVienDuyet]) VALUES (N'GH-475-73', N'Khách hàng 1', N'HSVV-218-30', N'13', 13, 14, CAST(N'2020-12-14' AS Date), N'Đang chờ', N'Chưa xác định')
INSERT [dbo].[GiaHanVayVon] ([id], [tenKH], [maHoSo], [lyDo], [kyHanCu], [kyHanMoi], [ngayDangKy], [tinhTrang], [nhanVienDuyet]) VALUES (N'GH-574-21', N'Khách hàng 1', N'HSVV-218-30', N'13', 13, 14, CAST(N'2020-12-14' AS Date), N'Đang chờ', N'Chưa xác định')
INSERT [dbo].[GiaHanVayVon] ([id], [tenKH], [maHoSo], [lyDo], [kyHanCu], [kyHanMoi], [ngayDangKy], [tinhTrang], [nhanVienDuyet]) VALUES (N'GH-636-98', N'Khách hàng 1', N'HSVV-238-18', N'Kẹt tiền', 72, 0, CAST(N'2020-12-11' AS Date), N'Rejected', N'Nhân viên 1')
INSERT [dbo].[GiaHanVayVon] ([id], [tenKH], [maHoSo], [lyDo], [kyHanCu], [kyHanMoi], [ngayDangKy], [tinhTrang], [nhanVienDuyet]) VALUES (N'GH-703-91', N'Khách hàng 1', N'HSVV-218-30', N'Kẹt tiền', 13, 0, CAST(N'2020-11-06' AS Date), N'Accepted', N'Nhân viên 1')
INSERT [dbo].[GiaHanVayVon] ([id], [tenKH], [maHoSo], [lyDo], [kyHanCu], [kyHanMoi], [ngayDangKy], [tinhTrang], [nhanVienDuyet]) VALUES (N'GH-740-4', N'Khách Hàng 2', N'HSVV-342-98', N'3453', 36, 0, CAST(N'2020-12-14' AS Date), N'Rejected', N'Nhân viên 1')
INSERT [dbo].[GiaHanVayVon] ([id], [tenKH], [maHoSo], [lyDo], [kyHanCu], [kyHanMoi], [ngayDangKy], [tinhTrang], [nhanVienDuyet]) VALUES (N'GH-810-11', N'Khách hàng 1', N'HSVV-567-45', N'13', 12, 14, CAST(N'2020-12-14' AS Date), N'Đang chờ', N'Chưa xác định')
INSERT [dbo].[GiaHanVayVon] ([id], [tenKH], [maHoSo], [lyDo], [kyHanCu], [kyHanMoi], [ngayDangKy], [tinhTrang], [nhanVienDuyet]) VALUES (N'GH-817-90', N'Khách hàng 1', N'HSVV-238-18', N'sadgasg', 72, 73, CAST(N'2020-12-14' AS Date), N'Đang chờ', N'Chưa xác định')
INSERT [dbo].[GiaHanVayVon] ([id], [tenKH], [maHoSo], [lyDo], [kyHanCu], [kyHanMoi], [ngayDangKy], [tinhTrang], [nhanVienDuyet]) VALUES (N'GH-842-34', N'Khách hàng 1', N'HSVV-218-30', N'13213123', 13, 14, CAST(N'2020-12-14' AS Date), N'Đang chờ', N'Chưa xác định')
INSERT [dbo].[GiaHanVayVon] ([id], [tenKH], [maHoSo], [lyDo], [kyHanCu], [kyHanMoi], [ngayDangKy], [tinhTrang], [nhanVienDuyet]) VALUES (N'GH-926-52', N'Khách Hàng 2', N'HSVV-342-98', N'234', 36, 72, CAST(N'2020-12-14' AS Date), N'Đang chờ', N'Chưa xác định')
INSERT [dbo].[GiaHanVayVon] ([id], [tenKH], [maHoSo], [lyDo], [kyHanCu], [kyHanMoi], [ngayDangKy], [tinhTrang], [nhanVienDuyet]) VALUES (N'GH-981-20', N'Khách hàng 1', N'HSVV-218-30', N'13', 13, 14, CAST(N'2020-12-14' AS Date), N'Đang chờ', N'Chưa xác định')
GO
INSERT [dbo].[HoSoVayVon] ([id], [tenKH], [soTien], [ngayDangKy], [kyHan], [nhanVienDuyet], [tinhTrang]) VALUES (N'HSVV-182-5', N'Khách hàng 1', N'20000000', CAST(N'2020-11-06' AS Date), 36, N'Nhân viên 1', N'Rejected')
INSERT [dbo].[HoSoVayVon] ([id], [tenKH], [soTien], [ngayDangKy], [kyHan], [nhanVienDuyet], [tinhTrang]) VALUES (N'HSVV-218-30', N'Khách hàng 1', N'10000000', CAST(N'2020-11-06' AS Date), 13, N'Nhân viên 1', N'Rejected')
INSERT [dbo].[HoSoVayVon] ([id], [tenKH], [soTien], [ngayDangKy], [kyHan], [nhanVienDuyet], [tinhTrang]) VALUES (N'HSVV-238-18', N'Khách hàng 1', N'100000000', CAST(N'2020-11-06' AS Date), 72, N'Nhân viên 1', N'Rejected')
INSERT [dbo].[HoSoVayVon] ([id], [tenKH], [soTien], [ngayDangKy], [kyHan], [nhanVienDuyet], [tinhTrang]) VALUES (N'HSVV-342-98', N'Khách Hàng 2', N'20000000', CAST(N'2020-12-09' AS Date), 36, N'Master', N'Accepted')
INSERT [dbo].[HoSoVayVon] ([id], [tenKH], [soTien], [ngayDangKy], [kyHan], [nhanVienDuyet], [tinhTrang]) VALUES (N'HSVV-567-45', N'Khách hàng 1', N'20000000', CAST(N'2020-12-14' AS Date), 12, N'Chưa xác định', N'Đang chờ')
INSERT [dbo].[HoSoVayVon] ([id], [tenKH], [soTien], [ngayDangKy], [kyHan], [nhanVienDuyet], [tinhTrang]) VALUES (N'HSVV-748-22', N'Khách Hàng 2', N'10000000', CAST(N'2020-12-14' AS Date), 12, N'Nhân viên 1', N'Accepted')
GO

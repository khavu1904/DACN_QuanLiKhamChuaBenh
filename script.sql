USE [QL_KHAMCHUABENHTRUCTUYEN]
GO
/****** Object:  Table [dbo].[BacSi]    Script Date: 24/11/2023 8:48:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BacSi](
	[idBacSi] [int] IDENTITY(1,1) NOT NULL,
	[MaBS] [nvarchar](10) NULL,
	[TenBS] [nvarchar](255) NULL,
	[TrangThai] [int] NULL,
	[KinhNghiem] [nvarchar](255) NULL,
	[KyNangChuyenMon] [nvarchar](255) NULL,
	[SDT] [nvarchar](20) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[Email] [nvarchar](255) NULL,
	[GioiThieu] [nvarchar](max) NULL,
	[NgaySinh] [datetime] NULL,
	[QuocTich] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[idBacSi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BangCap]    Script Date: 24/11/2023 8:48:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangCap](
	[idBangCap] [int] IDENTITY(1,1) NOT NULL,
	[TenBangCap] [nvarchar](255) NULL,
	[HinhAnh] [nvarchar](255) NULL,
	[idBacSi] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idBangCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BenhNhan]    Script Date: 24/11/2023 8:48:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BenhNhan](
	[idBenhNhan] [int] IDENTITY(1,1) NOT NULL,
	[MaBN] [nvarchar](10) NULL,
	[TenBN] [nvarchar](255) NULL,
	[SDT] [nvarchar](20) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[MaBHYT] [nvarchar](255) NULL,
	[QuocTich] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[idBenhNhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChungChi]    Script Date: 24/11/2023 8:48:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChungChi](
	[idChungChi] [int] IDENTITY(1,1) NOT NULL,
	[TenChungChi] [nvarchar](255) NULL,
	[HinhAnh] [nvarchar](255) NULL,
	[idBacSi] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idChungChi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KetQuaDuyet]    Script Date: 24/11/2023 8:48:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KetQuaDuyet](
	[idKetQuaDuyet] [int] IDENTITY(1,1) NOT NULL,
	[ThongBao] [nvarchar](255) NULL,
	[NgayDuyet] [datetime] NULL,
	[idBacSi] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idKetQuaDuyet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichKham]    Script Date: 24/11/2023 8:48:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichKham](
	[idLichKham] [int] IDENTITY(1,1) NOT NULL,
	[TrangThai] [int] NULL,
	[MaLK] [nvarchar](255) NULL,
	[KetQua] [nvarchar](max) NULL,
	[idBacSi] [int] NULL,
	[idBenhNhan] [int] NULL,
	[idPhongKham] [int] NULL,
	[ThoiGianBatDau] [datetime] NULL,
	[ThoiGianKetThuc] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idLichKham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongKham]    Script Date: 24/11/2023 8:48:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongKham](
	[idPhongKham] [int] IDENTITY(1,1) NOT NULL,
	[MaPhongKham] [nvarchar](10) NULL,
	[TenPhongKham] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[idPhongKham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 24/11/2023 8:48:52 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[idTaiKhoan] [int] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [nvarchar](255) NULL,
	[MatKhau] [nvarchar](255) NULL,
	[Quyen] [int] NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BacSi] ON 

INSERT [dbo].[BacSi] ([idBacSi], [MaBS], [TenBS], [TrangThai], [KinhNghiem], [KyNangChuyenMon], [SDT], [DiaChi], [Email], [GioiThieu], [NgaySinh], [QuocTich]) VALUES (1, N'BS01', N'Nguyễn Văn Ngọc', 1, N'5 năm', N'Tai-Mũi-Họng', N'0963254178', N'Cà Mau', N'ngoc@gmail.com', N'Không', CAST(N'1982-05-12T00:00:00.000' AS DateTime), N'Việt Nam')
INSERT [dbo].[BacSi] ([idBacSi], [MaBS], [TenBS], [TrangThai], [KinhNghiem], [KyNangChuyenMon], [SDT], [DiaChi], [Email], [GioiThieu], [NgaySinh], [QuocTich]) VALUES (2, N'BS02', N'La Văn Tấn', 1, N'10 năm', N'Nội soi', N'0369874529', N'Bình Phước', N'tan@gmail.com', N'Không', CAST(N'1979-10-10T00:00:00.000' AS DateTime), N'Việt Nam')
INSERT [dbo].[BacSi] ([idBacSi], [MaBS], [TenBS], [TrangThai], [KinhNghiem], [KyNangChuyenMon], [SDT], [DiaChi], [Email], [GioiThieu], [NgaySinh], [QuocTich]) VALUES (3, N'BS03', N'Nguyễn Tấn Phát', 2, N'6 năm', N'Thận', N'0365214789', N'Tây Ninh', N'phat@gmail.com', N'Không', CAST(N'1969-03-12T00:00:00.000' AS DateTime), N'Việt Nam')
INSERT [dbo].[BacSi] ([idBacSi], [MaBS], [TenBS], [TrangThai], [KinhNghiem], [KyNangChuyenMon], [SDT], [DiaChi], [Email], [GioiThieu], [NgaySinh], [QuocTich]) VALUES (4, N'BS04', N'Trần Nhật Thái', 3, N'2 năm', N'Nam khoa', N'0325478961', N'Khánh Hòa', N'thai@gmail.com', N'Không', CAST(N'1995-02-15T00:00:00.000' AS DateTime), N'Việt Nam')
SET IDENTITY_INSERT [dbo].[BacSi] OFF
GO
SET IDENTITY_INSERT [dbo].[BenhNhan] ON 

INSERT [dbo].[BenhNhan] ([idBenhNhan], [MaBN], [TenBN], [SDT], [DiaChi], [MaBHYT], [QuocTich]) VALUES (1, N'BN01', N'Nguyễn Công Phượng', N'0352147896', N'Nghệ An', N'7458963214', N'Việt Nam')
INSERT [dbo].[BenhNhan] ([idBenhNhan], [MaBN], [TenBN], [SDT], [DiaChi], [MaBHYT], [QuocTich]) VALUES (2, N'BN02', N'Nguyễn Tiến Linh', N'0578963214', N'Bình Dương', N'9654782314', N'Việt Nam')
INSERT [dbo].[BenhNhan] ([idBenhNhan], [MaBN], [TenBN], [SDT], [DiaChi], [MaBHYT], [QuocTich]) VALUES (3, N'BN03', N'Nguyễn Quang Hải', N'0632145879', N'Hà Nội', N'9625147853', N'Việt Nam')
INSERT [dbo].[BenhNhan] ([idBenhNhan], [MaBN], [TenBN], [SDT], [DiaChi], [MaBHYT], [QuocTich]) VALUES (4, N'BN04', N'Nguyễn Văn Toàn', N'0652147896', N'Hải Dương', N'9651247896', N'Việt Nam')
INSERT [dbo].[BenhNhan] ([idBenhNhan], [MaBN], [TenBN], [SDT], [DiaChi], [MaBHYT], [QuocTich]) VALUES (5, N'BN05', N'Lê Vi', N'0632145879', N'Cẩm Giang', N'9651247853', N'Việt Nam')
SET IDENTITY_INSERT [dbo].[BenhNhan] OFF
GO
SET IDENTITY_INSERT [dbo].[LichKham] ON 

INSERT [dbo].[LichKham] ([idLichKham], [TrangThai], [MaLK], [KetQua], [idBacSi], [idBenhNhan], [idPhongKham], [ThoiGianBatDau], [ThoiGianKetThuc]) VALUES (1, 1, N'LK01', N'Đau ruột thừa', 1, 1, 1, CAST(N'2022-10-10T08:00:00.000' AS DateTime), CAST(N'2022-10-12T10:00:00.000' AS DateTime))
INSERT [dbo].[LichKham] ([idLichKham], [TrangThai], [MaLK], [KetQua], [idBacSi], [idBenhNhan], [idPhongKham], [ThoiGianBatDau], [ThoiGianKetThuc]) VALUES (2, 1, N'LK02', N'Đứt dây chằn trước trái', 2, 2, 3, CAST(N'2023-05-15T13:30:00.000' AS DateTime), CAST(N'2023-05-15T15:30:00.000' AS DateTime))
INSERT [dbo].[LichKham] ([idLichKham], [TrangThai], [MaLK], [KetQua], [idBacSi], [idBenhNhan], [idPhongKham], [ThoiGianBatDau], [ThoiGianKetThuc]) VALUES (3, 2, N'LK03', NULL, 1, NULL, 2, CAST(N'2023-11-23T07:00:00.000' AS DateTime), CAST(N'2023-11-23T09:00:00.000' AS DateTime))
INSERT [dbo].[LichKham] ([idLichKham], [TrangThai], [MaLK], [KetQua], [idBacSi], [idBenhNhan], [idPhongKham], [ThoiGianBatDau], [ThoiGianKetThuc]) VALUES (4, 2, N'LK04', NULL, 2, NULL, 1, CAST(N'2023-10-21T10:00:00.000' AS DateTime), CAST(N'2023-10-21T12:00:00.000' AS DateTime))
INSERT [dbo].[LichKham] ([idLichKham], [TrangThai], [MaLK], [KetQua], [idBacSi], [idBenhNhan], [idPhongKham], [ThoiGianBatDau], [ThoiGianKetThuc]) VALUES (5, 3, N'LK04', NULL, 3, 4, 3, CAST(N'2023-11-25T15:00:00.000' AS DateTime), CAST(N'2023-11-25T17:00:00.000' AS DateTime))
INSERT [dbo].[LichKham] ([idLichKham], [TrangThai], [MaLK], [KetQua], [idBacSi], [idBenhNhan], [idPhongKham], [ThoiGianBatDau], [ThoiGianKetThuc]) VALUES (7, 1, N'LK05', N'Ho', 4, 4, 2, CAST(N'2023-11-15T07:30:00.000' AS DateTime), CAST(N'2023-11-15T09:30:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[LichKham] OFF
GO
SET IDENTITY_INSERT [dbo].[PhongKham] ON 

INSERT [dbo].[PhongKham] ([idPhongKham], [MaPhongKham], [TenPhongKham]) VALUES (1, N'A301', N'Nội soi')
INSERT [dbo].[PhongKham] ([idPhongKham], [MaPhongKham], [TenPhongKham]) VALUES (2, N'B102', N'Siêu âm')
INSERT [dbo].[PhongKham] ([idPhongKham], [MaPhongKham], [TenPhongKham]) VALUES (3, N'C115', N'Chụp X-Quang')
SET IDENTITY_INSERT [dbo].[PhongKham] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__BacSi__2724759794DF4C5F]    Script Date: 24/11/2023 8:48:52 CH ******/
ALTER TABLE [dbo].[BacSi] ADD UNIQUE NONCLUSTERED 
(
	[MaBS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__BenhNhan__272475AC98B7F138]    Script Date: 24/11/2023 8:48:52 CH ******/
ALTER TABLE [dbo].[BenhNhan] ADD UNIQUE NONCLUSTERED 
(
	[MaBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__PhongKha__D31EFFBBF2A88CE4]    Script Date: 24/11/2023 8:48:52 CH ******/
ALTER TABLE [dbo].[PhongKham] ADD UNIQUE NONCLUSTERED 
(
	[MaPhongKham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__TaiKhoan__55F68FC000CAE533]    Script Date: 24/11/2023 8:48:52 CH ******/
ALTER TABLE [dbo].[TaiKhoan] ADD UNIQUE NONCLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BangCap]  WITH CHECK ADD FOREIGN KEY([idBacSi])
REFERENCES [dbo].[BacSi] ([idBacSi])
GO
ALTER TABLE [dbo].[ChungChi]  WITH CHECK ADD FOREIGN KEY([idBacSi])
REFERENCES [dbo].[BacSi] ([idBacSi])
GO
ALTER TABLE [dbo].[KetQuaDuyet]  WITH CHECK ADD FOREIGN KEY([idBacSi])
REFERENCES [dbo].[BacSi] ([idBacSi])
GO
ALTER TABLE [dbo].[LichKham]  WITH CHECK ADD FOREIGN KEY([idBacSi])
REFERENCES [dbo].[BacSi] ([idBacSi])
GO
ALTER TABLE [dbo].[LichKham]  WITH CHECK ADD FOREIGN KEY([idBenhNhan])
REFERENCES [dbo].[BenhNhan] ([idBenhNhan])
GO
ALTER TABLE [dbo].[LichKham]  WITH CHECK ADD FOREIGN KEY([idPhongKham])
REFERENCES [dbo].[PhongKham] ([idPhongKham])
GO

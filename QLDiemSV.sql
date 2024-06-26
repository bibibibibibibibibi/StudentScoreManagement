USE [master]
GO
/****** Object:  Database [QLDiemSV]    Script Date: 6/4/2024 5:56:22 PM ******/
CREATE DATABASE [QLDiemSV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLDiemSV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QLDiemSV.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLDiemSV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QLDiemSV_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLDiemSV] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLDiemSV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLDiemSV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLDiemSV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLDiemSV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLDiemSV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLDiemSV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLDiemSV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLDiemSV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLDiemSV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLDiemSV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLDiemSV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLDiemSV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLDiemSV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLDiemSV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLDiemSV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLDiemSV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLDiemSV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLDiemSV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLDiemSV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLDiemSV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLDiemSV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLDiemSV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLDiemSV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLDiemSV] SET RECOVERY FULL 
GO
ALTER DATABASE [QLDiemSV] SET  MULTI_USER 
GO
ALTER DATABASE [QLDiemSV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLDiemSV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLDiemSV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLDiemSV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLDiemSV] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLDiemSV] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLDiemSV] SET QUERY_STORE = ON
GO
ALTER DATABASE [QLDiemSV] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QLDiemSV]
GO
/****** Object:  User [HocSinhUser]    Script Date: 6/4/2024 5:56:22 PM ******/
CREATE USER [HocSinhUser] FOR LOGIN [HocSinhLogin] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [GiangVienUser]    Script Date: 6/4/2024 5:56:22 PM ******/
CREATE USER [GiangVienUser] FOR LOGIN [GiangVienLogin] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [AdminUser]    Script Date: 6/4/2024 5:56:22 PM ******/
CREATE USER [AdminUser] FOR LOGIN [AdminLogin] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [HocSinhRole]    Script Date: 6/4/2024 5:56:22 PM ******/
CREATE ROLE [HocSinhRole]
GO
/****** Object:  DatabaseRole [GiangVienRole]    Script Date: 6/4/2024 5:56:22 PM ******/
CREATE ROLE [GiangVienRole]
GO
/****** Object:  DatabaseRole [AdminRole]    Script Date: 6/4/2024 5:56:22 PM ******/
CREATE ROLE [AdminRole]
GO
ALTER ROLE [HocSinhRole] ADD MEMBER [HocSinhUser]
GO
ALTER ROLE [GiangVienRole] ADD MEMBER [GiangVienUser]
GO
ALTER ROLE [AdminRole] ADD MEMBER [AdminUser]
GO
/****** Object:  Table [dbo].[Diem]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diem](
	[MaSV] [char](15) NOT NULL,
	[MaMH] [char](5) NOT NULL,
	[HocKy] [int] NOT NULL,
	[DiemQuaTrinh] [float] NULL,
	[DiemCuoiKy] [float] NULL,
	[DiemTrungBinh] [float] NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_Diem] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC,
	[MaMH] ASC,
	[HocKy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMH] [char](5) NOT NULL,
	[TenMH] [nvarchar](30) NOT NULL,
	[SoTinChi] [int] NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [char](15) NOT NULL,
	[TenSV] [nvarchar](20) NOT NULL,
	[GioiTinh] [bit] NOT NULL,
	[NgaySinh] [datetime] NOT NULL,
	[QueQuan] [nvarchar](50) NOT NULL,
	[MaLop] [char](5) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Scores]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Scores]
AS
SELECT    sv.MaSV, sv.TenSV, sv.GioiTinh, sv.MaLop, mh.TenMH, d.HocKy, d.DiemQuaTrinh, d.DiemCuoiKy, d.DiemTrungBinh, d.TinhTrang
FROM         dbo.SinhVien AS sv INNER JOIN
                      dbo.Diem AS d ON sv.MaSV = d.MaSV INNER JOIN
                      dbo.MonHoc AS mh ON d.MaMH = mh.MaMH
GO
/****** Object:  UserDefinedFunction [dbo].[FindStudent]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[FindStudent](@MaSV char(15))
RETURNS TABLE
AS
RETURN 
(
    SELECT * 
    FROM SinhVien
    WHERE MaSV = @MaSV
)
GO
/****** Object:  Table [dbo].[HeDT]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HeDT](
	[MaHeDT] [char](5) NOT NULL,
	[TenHeDT] [nvarchar](40) NOT NULL,
 CONSTRAINT [PK_HeDT] PRIMARY KEY CLUSTERED 
(
	[MaHeDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [char](5) NOT NULL,
	[TenKhoa] [nvarchar](30) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[DienThoai] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhoaHoc]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoaHoc](
	[MaKhoaHoc] [char](5) NOT NULL,
	[TenKhoaHoc] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_KhoaHoc] PRIMARY KEY CLUSTERED 
(
	[MaKhoaHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [char](5) NOT NULL,
	[TenLop] [nvarchar](30) NOT NULL,
	[MaKhoa] [char](5) NULL,
	[MaHeDT] [char](5) NULL,
	[MaKhoaHoc] [char](5) NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Courses_Info]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Courses_Info] AS
SELECT l.MaLop, l.TenLop, l.MaKhoa, k.TenKhoa, l.MaHeDT, h.TenHeDT, l.MaKhoaHoc, kh.TenKhoaHoc, k.DiaChi, k.DienThoai
FROM SinhVien sv, Lop l, Khoa k, HeDT h, KhoaHoc kh
WHERE l.MaLop = sv.MaLop
and l.MaKhoa = k.MaKhoa
and l.MaHeDT = h.MaHeDT
and l.MaKhoaHoc = kh.MaKhoaHoc;
GO
/****** Object:  UserDefinedFunction [dbo].[FindStudentWithHighestScore]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[FindStudentWithHighestScore]()
RETURNS TABLE
AS
RETURN (
    SELECT TOP 1 Diem.MaSV, Diem.MaMH, Diem.HocKy, Diem.DiemQuaTrinh, Diem.DiemCuoiKy, Diem.DiemTrungBinh, Diem.TinhTrang
    FROM Diem
    ORDER BY DiemTrungBinh DESC
)
GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien](
	[MaGV] [int] NOT NULL,
	[TenGV] [varchar](255) NULL,
	[DiaChi] [varchar](255) NULL,
	[SDT] [varchar](20) NULL,
	[MaKhoa] [char](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LopHocPhan]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopHocPhan](
	[MaLHP] [char](5) NOT NULL,
	[MaMH] [char](5) NULL,
	[MaKhoaHoc] [char](5) NULL,
	[NamHoc] [int] NULL,
	[MaGV] [int] NULL,
	[SiSoSV] [int] NULL,
 CONSTRAINT [PK_LopHocPhan] PRIMARY KEY CLUSTERED 
(
	[MaLHP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Role] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_MonHoc] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MonHoc] ([MaMH])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_MonHoc]
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_SinhVien] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_SinhVien]
GO
ALTER TABLE [dbo].[GiangVien]  WITH CHECK ADD  CONSTRAINT [FK_GiangVien_Khoa] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[GiangVien] CHECK CONSTRAINT [FK_GiangVien_Khoa]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_HeDT] FOREIGN KEY([MaHeDT])
REFERENCES [dbo].[HeDT] ([MaHeDT])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_HeDT]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_Khoa] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_Khoa]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_KhoaHoc] FOREIGN KEY([MaKhoaHoc])
REFERENCES [dbo].[KhoaHoc] ([MaKhoaHoc])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_KhoaHoc]
GO
ALTER TABLE [dbo].[LopHocPhan]  WITH CHECK ADD FOREIGN KEY([MaKhoaHoc])
REFERENCES [dbo].[KhoaHoc] ([MaKhoaHoc])
GO
ALTER TABLE [dbo].[LopHocPhan]  WITH CHECK ADD FOREIGN KEY([MaGV])
REFERENCES [dbo].[GiangVien] ([MaGV])
GO
ALTER TABLE [dbo].[LopHocPhan]  WITH CHECK ADD FOREIGN KEY([MaMH])
REFERENCES [dbo].[MonHoc] ([MaMH])
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_Lop] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_Lop]
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [CK_Diem] CHECK  (([HocKy]>(0)))
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [CK_Diem]
GO
ALTER TABLE [dbo].[MonHoc]  WITH CHECK ADD  CONSTRAINT [CK_MonHoc] CHECK  (([SoTinChi]>(0) AND [SoTinChi]<(7)))
GO
ALTER TABLE [dbo].[MonHoc] CHECK CONSTRAINT [CK_MonHoc]
GO
/****** Object:  StoredProcedure [dbo].[hienthisv_diem]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[hienthisv_diem]
  as
  SELECT SinhVien.MaSV,TenSV,QueQuan,MaMH,DiemQuaTrinh, DiemCuoiKy
  from SinhVien join diem
  on Sinhvien.masv=diem.masv
GO
/****** Object:  StoredProcedure [dbo].[nhapmoiSV]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[nhapmoiSV]
    @Masv char(15),
    @Tensv nvarchar(20),
    @gioitinh bit,
    @ngaysinh datetime,
    @quequan nvarchar(50),
    @malop char(5)
    as
    begin
      insert into sinhvien
      values(@Masv,@Tensv,@gioitinh,@ngaysinh,@quequan,@malop)
    end
GO
/****** Object:  StoredProcedure [dbo].[sp_delDIEM]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_delDIEM]
          @MASV char(15)
          as
            delete from Diem
            where MASV=@MASV
 
GO
/****** Object:  StoredProcedure [dbo].[sp_delGiangVien]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_delGiangVien]
          (
          @MaGV int
          )
          AS
          BEGIN
          DELETE FROM GiangVien
          WHERE MaGV = @MaGV;
          END
GO
/****** Object:  StoredProcedure [dbo].[sp_delHEDT]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_delHEDT]
          @MaHeDT char(5)
          as
            delete from HEDT
            where MaHeDT=@MaHeDT
GO
/****** Object:  StoredProcedure [dbo].[sp_delKHOA]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_delKHOA]
          @MAKHOA char(5)
          as
            delete from KHOA
            where MAKHOA=@MAKHOA
GO
/****** Object:  StoredProcedure [dbo].[sp_delKHOAHOC]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_delKHOAHOC]
          @MaKhoaHoc char(5)
          as
            delete from KHOAHOC
            where MaKhoaHoc=@MaKhoaHoc
GO
/****** Object:  StoredProcedure [dbo].[sp_delLOP]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_delLOP]
          @MALOP char(5)
          as
            delete from LOP
            where MALOP=@MALOP
GO
/****** Object:  StoredProcedure [dbo].[sp_delLopHocPhan]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_delLopHocPhan]
          (
          @MaLHP char(5)
          )
          AS
          BEGIN
          DELETE FROM LopHocPhan
          WHERE MaLHP = @MaLHP;
          END
GO
/****** Object:  StoredProcedure [dbo].[sp_delMONHOC]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_delMONHOC]
          @MAMH char(5)
          as
            delete from MonHoc
            where MAMH=@MAMH
GO
/****** Object:  StoredProcedure [dbo].[sp_delSINHVIEN]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_delSINHVIEN]
          @MASV char(15)
          as
            delete from SINHVIEN
            where MASV=@MASV
GO
/****** Object:  StoredProcedure [dbo].[sp_HEDT]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_HEDT]
          (
           @MaHeDT char(5),
           @TenHeDT nvarchar(40)
          )
          AS
          BEGIN
          insert into HEDT
          (
             MaHeDT,
             TenHeDT
             )
     
         values (@MaHeDT,@TenHeDT)
         END
GO
/****** Object:  StoredProcedure [dbo].[sp_insDIEM]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_insDIEM]
          (
          @MaSV char(15),
          @MaMH CHAR(5),
          @HocKy INT,
          @DiemQuaTrinh FLOAT,
          @DiemCuoiKy FLOAT
          )
          AS
          BEGIN
          insert into Diem
          (
             MASV,
             MAMH,
             HOCKY,
           DIEMQUATRINH,
             DIEMCUOIKY
             )
     
         values (@MaSV,@MaMH,@HocKy,@DiemQuaTrinh,@DiemCuoiKy)
         END
GO
/****** Object:  StoredProcedure [dbo].[sp_insGiangVien]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_insGiangVien]
          (
          @MaGV int,
          @TenGV varchar(255),
          @MaKhoa int,
          @DiaChi varchar(255),
          @SDT varchar(20)
          )
          AS
          BEGIN
          INSERT INTO GiangVien (MaGV, TenGV, MaKhoa, DiaChi, SDT)
          VALUES (@MaGV, @TenGV, @MaKhoa, @DiaChi, @SDT);
          END
GO
/****** Object:  StoredProcedure [dbo].[sp_insKHOA]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_insKHOA]
          (
            @MaKhoa char(5),
            @TenKhoa nvarchar(30),
            @DiaChi nvarchar(100),
            @DienThoai varchar(20)
          )
          AS
          BEGIN
          insert into KHOA
          (
             MaKhoa,
             TenKhoa,
             DiaChi,
           DienThoai
            )
     
         values (@MaKhoa,@TenKhoa,@DiaChi,@DienThoai)
         END
GO
/****** Object:  StoredProcedure [dbo].[sp_insKHOAHOC]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_insKHOAHOC]
          (
           @MaKhoaHoc char(5),
           @TenKhoaHoc nvarchar(20)
          )
          AS
          BEGIN
          insert into KHOAHOC
          (
             MaKhoaHoc,
             TenKhoaHoc
             )
     
         values (@MaKhoaHoc,@TenKhoaHoc)
         END
GO
/****** Object:  StoredProcedure [dbo].[sp_insLOP]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_insLOP]
          (
          @MALOP char(5),
          @TENLOP nvarchar(30),
          @MAKHOA CHAR(5),
          @MaHeDT CHAR(5),
          @MaKhoaHoc CHAR(5)
          )
          AS
          BEGIN
          insert into LOP
          (
             MALOP,
             TENLOP,
             MAKHOA,
           MaHeDT,
             MaKhoaHoc
             )
     
         values (@MALOP,@TENLOP,@MAKHOA,@MaHeDT,@MaKhoaHoc)
         END
GO
/****** Object:  StoredProcedure [dbo].[sp_insLopHocPhan]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_insLopHocPhan]
          (
          @MaLHP char(5),
          @MaMH char(5),
          @MaKhoaHoc char(5),
          @NamHoc int,
          @MaGV int,
          @SiSoSV int
          )
          AS
          BEGIN
          INSERT INTO LopHocPhan (MaLHP, MaMH, MaKhoaHoc, NamHoc, MaGV, SiSoSV)
          VALUES (@MaLHP, @MaMH, @MaKhoaHoc, @NamHoc, @MaGV, @SiSoSV);
          END
GO
/****** Object:  StoredProcedure [dbo].[sp_insMONHOC]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_insMONHOC]
          (
          @MaMH char(5),
          @TenMH nvarchar(30),
          @SoTinChi INT
          )
          AS
          BEGIN
			insert into MonHoc (MaMH, TenMH, SoTinChi)     
			values (@MAMH,@TENMH,@SOTINCHI)
          END
GO
/****** Object:  StoredProcedure [dbo].[sp_insSINHVIEN]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_insSINHVIEN]
          (
          @MASV char(15),
          @TENSV nvarchar(20),
          @GIOITINH bit,
          @NGAYSINH DATETIME,
          @QueQuan nvarchar(50),
          @MALOP char(5)
          )
          AS
          BEGIN
          insert into SINHVIEN
          (
             MASV,
             TENSV,
             GIOITINH,
           NGAYSINH,
             QueQuan,
             MALOP
          )
           values (@MASV,@TENSV,@GIOITINH,@NGAYSINH,@QUEQUAN,@MALOP)
         END
GO
/****** Object:  StoredProcedure [dbo].[sp_showDIEM]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_showDIEM]
          as
            select * from DIEM
GO
/****** Object:  StoredProcedure [dbo].[sp_showHEDT]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_showHEDT]
          as
            select * from HEDT
GO
/****** Object:  StoredProcedure [dbo].[sp_showKHOA]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_showKHOA]
          as
            select * from KHOA
GO
/****** Object:  StoredProcedure [dbo].[sp_showKHOAHOC]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_showKHOAHOC]
          as
            select * from KHOAHOC
GO
/****** Object:  StoredProcedure [dbo].[sp_showLOP]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_showLOP]
          as
            select * from LOP
GO
/****** Object:  StoredProcedure [dbo].[sp_showMONHOC]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_showMONHOC]
          as
            select * from MonHoc
GO
/****** Object:  StoredProcedure [dbo].[sp_showSINHVIEN]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_showSINHVIEN]
          as
            select * from SinhVien
GO
/****** Object:  StoredProcedure [dbo].[sp_updateDIEM]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_updateDIEM]
          (
           @MaSV char(15),
           @MaMH char(5),
           @HocKy INT,
           @DiemQuaTrinh FLOAT,
           @DiemCuoiKy FLOAT
          )
          as

          update Diem
            set  
               MaSV=@MaSV,
               MaMH=@MaMH,
			   HocKy=@HocKy,
               DiemQuaTrinh=@DiemQuaTrinh,
               DiemCuoiKy=@DiemCuoiKy
             where MaSV=@MaSV
GO
/****** Object:  StoredProcedure [dbo].[sp_updateGiangVien]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_updateGiangVien]
          (
          @MaGV int,
          @TenGV varchar(255),
          @MaKhoa int,
          @DiaChi varchar(255),
          @SDT varchar(20)
          )
          AS
          BEGIN
          UPDATE GiangVien
          SET TenGV = @TenGV, MaKhoa = @MaKhoa, DiaChi = @DiaChi, SDT = @SDT
          WHERE MaGV = @MaGV;
          END
GO
/****** Object:  StoredProcedure [dbo].[sp_updateHEDT]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateHEDT]
          (
            @MaHeDT char(5),
            @TenHeDT nvarchar(40)
          )
          as

          update HEDT
            set  
               MaHeDT=@MaHeDT,
               TenHeDT=@TenHeDT
            where MaHeDT=@MaHeDT
GO
/****** Object:  StoredProcedure [dbo].[sp_updateKHOA]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateKHOA]
          (
            @MaKhoa char(5),
            @TenKhoa nvarchar(30),
            @DiaChi nvarchar(100),
            @DienThoai varchar(20)
          )
          as

          update KHOA
            set  
               MaKhoa=@MaKhoa,
               TenKhoa=@TenKhoa,
           DiaChi=@DiaChi,
               DienThoai=@DienThoai
             where MaKhoa=@MaKhoa
GO
/****** Object:  StoredProcedure [dbo].[sp_updateKHOAHOC]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateKHOAHOC]
          (
            @MaKhoaHoc char(5),
            @TenKhoaHoc nvarchar(20)
          )
          as

          update KHOAHOC
            set  
               MaKhoaHoc=@MaKhoaHoc,
               TenKhoaHoc=@TenKhoaHoc
            where MaKhoaHoc=@MaKhoaHoc
GO
/****** Object:  StoredProcedure [dbo].[sp_updateLOP]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_updateLOP]
          (
           @MALOP char(5),
           @TENLOP nvarchar(30),
           @MAKHOA CHAR(5),
           @MaHeDT CHAR(5),
           @MaKhoaHoc CHAR(5)
          )
          as

          update LOP
            set  
               MALOP=@MALOP,
               TENLOP=@TENLOP,
           MAKHOA=@MAKHOA,
               MaHeDT=@MaHeDT,
               MaKhoaHoc=@MaKhoaHoc
             where MALOP=@MALOP
GO
/****** Object:  StoredProcedure [dbo].[sp_updateLopHocPhan]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_updateLopHocPhan]
          (
          @MaLHP char(5),
          @MaMH char(5),
          @MaKhoaHoc char(5),
          @NamHoc int,
          @MaGV int,
          @SiSoSV int
          )
          AS
          BEGIN
          UPDATE LopHocPhan
          SET MaMH = @MaMH, MaKhoaHoc = @MaKhoaHoc, NamHoc = @NamHoc, MaGV = @MaGV, SiSoSV = @SiSoSV
          WHERE MaLHP = @MaLHP;
          END
GO
/****** Object:  StoredProcedure [dbo].[sp_updateMONHOC]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_updateMONHOC]
          (
           @MaMH char(5),
           @TenMH nvarchar(30),
           @SoTinChi INT
          )
          as

          update MonHoc
            set  
               MAMH=@MAMH,
               TENMH=@TENMH,
           SOTINCHI=@SOTINCHI
             where MAMH=@MAMH
GO
/****** Object:  StoredProcedure [dbo].[sp_updateSINHVIEN]    Script Date: 6/4/2024 5:56:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_updateSINHVIEN]
          (
           @MASV char(15),
           @TENSV nvarchar(20),
           @GIOITINH bit,
           @NGAYSINH DATETIME,
           @QUEQUAN nvarchar(50),
           @MALOP char(5)
          )
          as

          update SINHVIEN
            set  
               MASV=@MASV,
               TENSV=@TENSV,
			   GIOITINH=@GIOITINH,
               NGAYSINH=@NGAYSINH,
               QUEQUAN=@QUEQUAN,
               MALOP=@MALOP
             where MASV=@MASV
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
         Top = -360
         Left = 0
      End
      Begin Tables = 
         Begin Table = "sv"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "d"
            Begin Extent = 
               Top = 175
               Left = 48
               Bottom = 338
               Right = 246
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "mh"
            Begin Extent = 
               Top = 343
               Left = 48
               Bottom = 484
               Right = 242
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
         Alias = 900
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Scores'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Scores'
GO
USE [master]
GO
ALTER DATABASE [QLDiemSV] SET  READ_WRITE 
GO

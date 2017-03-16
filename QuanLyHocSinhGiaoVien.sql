﻿

CREATE DATABASE [QuanLyHocSinhGiaoVien]
GO

USE [QuanLyHocSinhGiaoVien]

CREATE TABLE DangNhap(
	[tendangnhap] [nvarchar](20) NULL,
	[matkhau] [nvarchar](20) NULL
)

CREATE TABLE MonHoc
(
	[mamonhoc] [varchar](10) PRIMARY KEY NOT NULL,
	[tenmonhoc] [nvarchar](50) NULL,
	[heso] [int] NULL
) 

CREATE TABLE GiaoVien(
	[magiaovien] [varchar](10) PRIMARY KEY NOT NULL,
	[hovaten] [nvarchar](40) NULL,
	[ngaysinh] [datetime] NULL,
	[gioitinh] [nvarchar](10) NULL,
	[tongiao] [nvarchar](10) NULL,
	[quequan] [nvarchar](50) NULL,
	[diachithuongtru] [nvarchar](50) NULL,
	[sodienthoai] [nvarchar](12) NULL,
	[hocvi] [nvarchar](10) NULL,
	[chucvu] [nvarchar](15) NULL,
	[chuyenmon] [nvarchar](50) NULL,
	[tinhtrang] [nvarchar](10) NULL,
	[luong] [nvarchar](15) NULL
)

CREATE TABLE Lop(
	[malop] [varchar](10) PRIMARY KEY NOT NULL,
	[soluong] [int] NULL,
	[namhoc] [nvarchar](15) NULL,
	[giaovienma] [varchar](10) REFERENCES giaovien(magiaovien),
)

CREATE TABLE HocSinh(
	[mahocsinh] [varchar](10) PRIMARY KEY NOT NULL,
	[hocvaten] [nvarchar](40) NULL,
	[ngaysinh] [datetime] NULL,
	[gioitinh] [nvarchar](10) NULL,
	[tongiao] [nvarchar](10) NULL,
	[quequan] [nvarchar](50) NULL,
	[diachithuongtru] [nvarchar](50) NULL,
	[hotenbo] [nvarchar](30) NULL,
	[nghenghiepbo] [nvarchar](20) NULL,
	[hotenme] [nvarchar](30) NULL,
	[nghenghiepme] [nvarchar](20) NULL,
	[sodienthoai] [nvarchar](12) NULL,
	[lopma] [varchar](10) references lop(malop)
)

CREATE TABLE BangDiem(
	[hocsinhma] [varchar](10) NOT NULL REFERENCES hocsinh(mahocsinh),
	[monhocma] [varchar](10) NOT NULL REFERENCES monhoc(mamonhoc),
	[tenmonhoc] [nvarchar](10) NULL,
	[diemmieng1] [float] NULL,
	[diemmieng2] [float] NULL,
	[diem15p] [float] NULL,
	[diem1tiet] [float] NULL,
	[diemhetmon] [float] NULL,
	[diemtrungbinh] [float] NULL,
	PRIMARY KEY (hocsinhma, monhocma)	
)

CREATE TABLE KetQuaHocTap(
	[hocsinhma] [varchar](10) REFERENCES hocsinh(mahocsinh),
	[lopma] [varchar](10) REFERENCES lop(malop),
	[diemtrungbinhki1] [float] NULL,
	[hoclucki1] [nvarchar](10) NULL,
	[diemtrungbinhki2] [float] NULL,
	[hoclucki2] [nvarchar](10) NULL,
	[diemtrungbinhcanam] [float] NULL,
	[hocluccanam] [nvarchar](10) NULL,
	PRIMARY KEY (hocsinhma)
)
	

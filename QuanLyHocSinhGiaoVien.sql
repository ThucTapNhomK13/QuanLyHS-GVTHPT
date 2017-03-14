

CREATE DATABASE [QuanLiHocSinhGiaoVien]

USE [QuanLiHocSinhGiaoVien]

CREATE TABLE BangDiem(
	[hocsinhma] [nvarchar](10)  primary key NOT NULL,
	[masomonhoc] [nvarchar](20) NULL,
	[tenmonhoc] [nvarchar](10) NULL,
	[diemmieng1] [float] NULL,
	[diemmieng2] [float] NULL,
	[diem15p] [float] NULL,
	[diem1tiet] [float] NULL,
	[diemhetmon] [float] NULL,
	[diemtrungbinh] [float] NULL,

CREATE TABLE DangNhap(
	[tendangnhap] [nvarchar](20) NULL,
	[matkhau] [nvarchar](20) NULL
) 

CREATE TABLE GiaoVien(
	[magiaovien] [nvarchar](10) PRIMARY KEY NOT NULL,
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
	[luong] [nvarchar](15) NULL,

(

CREATE TABLE HocSinh(
	[mahocsinh] [nvarchar](10) PRIMARY KEY NOT NULL,
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
	[lophoc] [nvarchar](10) NULL,
	[malop] [nvarchar](10) NULL,

(
CREATE TABLE KetQuaHocTap(
	[hocsinhma] [nvarchar](10) PRIMARY KEY NOT NULL,
	[diemtrungbinhki1] [float] NULL,
	[hoclucki1] [nvarchar](10) NULL,
	[diemtrungbinhki2] [float] NULL,
	[hoclucki2] [nvarchar](10) NULL,
	[diemtrungbinhcanam] [float] NULL,
	[hocluccanam] [nvarchar](10) NULL,

(
	
CREATE TABLE Lop(
	[malop] [nvarchar](10) PRIMARY KEY NOT NULL,
	[soluong] [int] NULL,
	[giaovienchunhiemma] [nvarchar](10) NULL,
	[namhoc] [nvarchar](15) NULL,

(

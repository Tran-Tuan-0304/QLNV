-- Xóa database cũ nếu đang tồn tại
USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = 'QLNhanVien')
BEGIN
    ALTER DATABASE QLNhanVien SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QLNhanVien;
END
GO

-- Tạo lại database
CREATE DATABASE QLNhanVien;
GO

USE QLNhanVien;
GO
CREATE TABLE Luong (
    ChucVuID INT PRIMARY KEY,
    TenChucVu NVARCHAR(100),
    MucLuong DECIMAL(18,2)
);
INSERT INTO Luong (ChucVuID, TenChucVu, MucLuong) VALUES
(1, N'Trưởng phòng', 2000000),
(2, N'Phó phòng', 1800000),
(3, N'Chuyên viên', 1500000),
(4, N'Nhân viên', 1200000),
(5, N'Thực tập sinh', 1000000);

CREATE TABLE NhanVien (
    MaNV NVARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100),
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    DiaChi NVARCHAR(200),
    SoDienThoai NVARCHAR(15),
    Email NVARCHAR(100),
    ChucVuID INT,
    FOREIGN KEY (ChucVuID) REFERENCES Luong(ChucVuID)
);
INSERT INTO NhanVien (MaNV, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, Email, ChucVuID) VALUES
('NV001', N'Trần Quốc Tuấn', '2006-07-06', N'Nam', N'Hà Nội', '0912345678', 'vana@gmail.com', 1),
('NV002', N'Dương Tiến Quang', '2006-08-25', N'Nam', N'TP HCM', '0938123456', 'leb@gmail.com', 2),
('NV003', N'Phan Đức Anh', '2006-09-10', N'Nam', N'Đà Nẵng', '0945236789', 'tranc@gmail.com', 3),
('NV004', N'Lương Ngọc Duy', '1995-01-30', N'Nam', N'Hải Phòng', '0975123456', 'phamd@gmail.com', 5),
('NV005', N'Đỗ Thị E', '1993-03-25', N'Nữ', N'Cần Thơ', '0986345678', 'doe@gmail.com', 4);


-- Tạo bảng TaiKhoan
CREATE TABLE TaiKhoan (
    TenDN NVARCHAR(50) PRIMARY KEY,
    MatKhau NVARCHAR(100),
    HoTen NVARCHAR(100)
);

INSERT INTO TaiKhoan (TenDN, MatKhau, HoTen) VALUES
('trant', '123456', N'Trần Quốc Tuấn'),
('duongq', '123456', N'Dương Tiến Quang'),
('phana', '123456', N'Phan Đức Anh'),
('luongd', '123456', N'Lương Ngọc Duy'),
('doe', '123456', N'Đỗ Thị E');

-- Tạo database nếu chưa có
IF DB_ID(N'BaiTapBuoi5DB') IS NULL
    CREATE DATABASE BaiTapBuoi5DB;
GO

USE BaiTapBuoi5DB;
GO

-- Tạo bảng sản phẩm nếu chưa có
IF OBJECT_ID(N'dbo.Products', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Products
    (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Name NVARCHAR(200) NOT NULL,
        Price DECIMAL(18,2) NOT NULL
    );
END
GO

-- Thêm dữ liệu mẫu nếu bảng đang trống
IF NOT EXISTS (SELECT 1 FROM dbo.Products)
BEGIN
    INSERT INTO dbo.Products (Name, Price)
    VALUES
        (N'Bàn phím', 350000),
        (N'Chuột', 180000),
        (N'Màn hình', 2500000);
END
GO

-- Kiểm tra kết quả
SELECT Id, Name, Price
FROM dbo.Products;
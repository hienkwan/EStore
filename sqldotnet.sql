CREATE DATABASE EStore

USE EStore

CREATE	TABLE Product
(
	ProductId int IDENTITY(1,1) PRIMARY KEY	,
	ProductName nvarchar(255) NOT NULL,
	ListedPrice bigint NOT  NULL,
	SalePrice bigint NOT NULL,
	ImgUrl text ,
	Category nvarchar(255),
	Product_Status bit 
)

go

CREATE TABLE ProductDetail
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Content TEXT ,
	ProductId INT FOREIGN KEY REFERENCES Product(ProductId)
)



use shop;

CREATE TABLE dbo.byers
	(
	ID int NOT NULL IDENTITY (1, 1) PRIMARY KEY,
	NAME nvarchar(50) NOT NULL,
	LASTNAME nvarchar(50) NOT NULL
	)

CREATE TABLE dbo.sellers
	(
	ID int NOT NULL IDENTITY (1, 1) PRIMARY KEY,
	NAME nvarchar(50) NOT NULL,
	LASTNAME nvarchar(50) NOT NULL
	)

	CREATE TABLE dbo.sales
	(
	ID int NOT NULL IDENTITY (1,1) PRIMARY KEY,
	ID_BYER int NOT NULL FOREIGN KEY REFERENCES byers (ID),
	ID_SELLER int NOT NULL FOREIGN KEY REFERENCES sellers(ID),
	SUMM decimal(18, 2),
	DATE_SELES DATE
	)
	

	INSERT INTO byers
(NAME, LASTNAME)
VALUES 
('B_NAME1','B_LASTNAME1'),
('B_NAME2','B_LASTNAME2'),
('B_NAME3','B_LASTNAME3'),
('B_NAME4','B_LASTNAME4'),
('B_NAME5','B_LASTNAME5');


	INSERT INTO sellers
(NAME, LASTNAME)
VALUES 
('S_NAME1','S_LASTNAME1'),
('S_NAME2','S_LASTNAME2'),
('S_NAME3','S_LASTNAME3'),
('S_NAME4','S_LASTNAME4'),
('S_NAME5','S_LASTNAME5');


	INSERT INTO sales
(ID_BYER, ID_SELLER,SUMM,DATE_SELES)
VALUES 
(2,3,104,'02/05/2020'),
(1,4,105,'01/05/2020'),
(3,2,107,'06/05/2020'),
(1,5,108,'04/05/2020'),
(1,3,108,'06/05/2020'),
(2,4,103,'07/05/2020'),
(1,1,101,'01/05/2020');
CREATE DATABASE Register

use Register

-- Drop the existing table if it exists
IF OBJECT_ID('account', 'U') IS NOT NULL
    DROP TABLE account;

-- Create the new table
CREATE TABLE account (
    user_ID NVARCHAR(20) PRIMARY KEY,
    FirstName NVARCHAR(20) NOT NULL,
    LastName NVARCHAR(20) NOT NULL,
    MiddleInitial NVARCHAR(20) NOT NULL,
    Suffix NVARCHAR(20) NOT NULL,
    Email NVARCHAR(255) NOT NULL,
    username NVARCHAR(20) NOT NULL,
    Contact NVARCHAR(255) NOT NULL,
    password NVARCHAR(255) NOT NULL,
);

CREATE TABLE admin_table(
user_ID INT IDENTITY(1,1),
username VARCHAR(20) NOT NULL,
password VARCHAR(20)NOT NULL,
user_role INT NOT NULL,
PRIMARY KEY(user_ID)

);

INSERT INTO admin_table values('admin1','admin1',1)

-- Create a trigger to automatically generate the user_ID in the format C-001
CREATE TRIGGER trg_generate_user_ID
ON account
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @lastUserID INT;
    DECLARE @newUserID NVARCHAR(20);

    -- Get the last user_ID
    SELECT @lastUserID = MAX(CAST(SUBSTRING(CONVERT(NVARCHAR(20), user_ID), 3, LEN(user_ID)) AS INT)) FROM account WHERE user_ID LIKE N'C-%';

    -- Increment and format the new user_ID
    SET @newUserID = N'C-' + RIGHT('00' + CAST(ISNULL(@lastUserID, 0) + 1 AS NVARCHAR(3)), 3);

    -- Insert the new record with the generated user_ID
    INSERT INTO account (user_ID, FirstName, LastName, MiddleInitial, Suffix, Email, username, Contact, password)
    SELECT @newUserID, FirstName, LastName, MiddleInitial, Suffix, Email, username, Contact, password
    FROM inserted;
END;




-- Drop the products table if it exists
IF OBJECT_ID('products', 'U') IS NOT NULL
    DROP TABLE products;

CREATE TABLE products (
    product_ID NVARCHAR(50) PRIMARY KEY,
    product_name NVARCHAR(100) NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
    image VARBINARY(MAX) NULL
);

CREATE TABLE cart (
    product_ID NVARCHAR(50) ,
    product_name NVARCHAR(100) PRIMARY KEY,
    price DECIMAL(10, 2) NOT NULL,
	qty int NOT NULL,
	total DECIMAL(10, 2) NOT NULL
  FOREIGN KEY (product_ID) REFERENCES products(product_ID),

);

DROP TABLE cart;

CREATE TABLE Receipt (
	username NVARCHAR(20),
    product_ID NVARCHAR(50) PRIMARY KEY ,
    product_name NVARCHAR(100),
    price DECIMAL(10, 2) NOT NULL,
	qty int NOT NULL,
	total DECIMAL(10, 2) NOT NULL
  FOREIGN KEY (product_ID) REFERENCES products(product_ID),
);
DROP TABLE Receipt;

-- Create a trigger to automatically generate the product_ID in the format P-001
CREATE TRIGGER trg_generate_product_ID
ON products
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @lastProductID INT;
    DECLARE @newProductID NVARCHAR(20);

    -- Get the last product_ID
    SELECT @lastProductID = MAX(CAST(SUBSTRING(CONVERT(NVARCHAR(20), product_ID), 3, LEN(product_ID)) AS INT)) FROM products WHERE product_ID LIKE N'P-%';

    -- Increment and format the new product_ID
    SET @newProductID = N'P-' + RIGHT('00' + CAST(ISNULL(@lastProductID, 0) + 1 AS NVARCHAR(3)), 3);

    -- Insert the new record with the generated product_ID
    INSERT INTO products (product_ID, product_name, price, image)
    SELECT @newProductID, product_name, price, image
    FROM inserted;
END;
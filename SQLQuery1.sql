CREATE DATABASE HR

USE HR

CREATE TABLE user_table(
user_ID INT IDENTITY(1,1),
username VARCHAR(20) NOT NULL,
password VARCHAR(20)NOT NULL,
user_role INT NOT NULL,
PRIMARY KEY(user_ID)
);

CREATE TABLE management_table(
user_ID INT IDENTITY(1,1),
username VARCHAR(20) NOT NULL,
password VARCHAR(20)NOT NULL,
user_role INT NOT NULL,
PRIMARY KEY(user_ID)
);

CREATE TABLE reserve_table(
    Room_ID INT IDENTITY NOT NULL,
    Room_Class VARCHAR(20) NOT NULL,
    Available_Date DATETIME NOT NULL,
    Price INT NOT NULL,
    PRIMARY KEY(Room_ID)
);

CREATE TABLE customer_table(
    Customer_ID INT IDENTITY NOT NULL,
	Price INT NOT NULL,
	Room_Class VARCHAR(20) NOT NULL,
    Customer_Name VARCHAR(255) NOT NULL,
	Customer_Email NVARCHAR(255) NOT NULL,
	Customer_Contact NVARCHAR(255) NOT NULL,
    CheckIn DATETIME NOT NULL,
	CheckOut DATETIME NOT NULL,
   
    PRIMARY KEY(Customer_ID)
);

INSERT INTO user_table values('admin','admin',1)
INSERT INTO management_table values('manager1','manager1',1)

SELECT * FROM customer_table
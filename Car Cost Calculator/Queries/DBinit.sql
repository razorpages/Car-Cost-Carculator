CREATE DATABASE IF NOT EXISTS carcostdatabase;

USE carcostdatabase;

DROP TABLE IF EXISTS users, Vehicle, costs, tank;

CREATE TABLE IF NOT EXISTS users(
mail VARCHAR(40) NOT NULL,
full_name VARCHAR(40),
password VARCHAR(40) NOT NULL,
PRIMARY KEY(mail)
);

CREATE TABLE IF NOT EXISTS Vehicle(
Number_Plate VARCHAR(16) NOT NULL,
Vehicle_Kind VARCHAR(20),
Account_ID VARCHAR(40),
Current_KM INTEGER,
BuyDate DATETIME,
BuyCost DOUBLE,
PRIMARY KEY (Number_Plate),
FOREIGN KEY(Account_ID) REFERENCES users(mail)
);

CREATE TABLE IF NOT EXISTS costs(
Cost_ID INTEGER NOT NULL AUTO_INCREMENT,
Cost_Name VARCHAR(40),
Cost_Amount DOUBLE,
Cost_Date DATETIME,
Vehicle_Cost VARCHAR(16),
PRIMARY KEY(cost_ID),
FOREIGN KEY(Vehicle_Cost) REFERENCES Vehicle(Number_Plate)
);

CREATE TABLE IF NOT EXISTS tank(
Tank_ID INTEGER NOT NULL,
Before_Tank_KM INTEGER,
After_Tank_KM INTEGER,
Tank_Cost DOUBLE,
Tank_Date DATETIME,
Vehicle_KM VARCHAR(16),
PRIMARY KEY(Tank_ID),
FOREIGN KEY (Vehicle_KM) REFERENCES Vehicle(Number_Plate)
);


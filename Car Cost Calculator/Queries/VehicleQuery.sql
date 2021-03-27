CREATE TABLE Vehicle(
Number_Plate VARCHAR(16) NOT NULL,
Vehicle_Kind VARCHAR(20),
Account_ID VARCHAR(40),
Current_KM INTEGER,
BuyDate DATETIME,
BuyCost FLOAT,
PRIMARY KEY (Number_Plate),
FOREIGN KEY(Account_ID) REFERENCES users(mail)
);

DROP TABLE Vehicle;

SELECT * FROM Vehicle;

/*Dapper*/
INSERT INTO Vehicle(Number_Plate, Vehicle_Kind, Current_KM, BuyDate, BuyCost)
VALUES(@Number_Plate, @Vehicle_Kind, @Current_KM, @BuyDate, @BuyCost);

SELECT * FROM Vehicle WHERE Account_ID = @Account_ID;

UPDATE Vehicle 
SET Buy_Cost = @Buy_Cost 
WHERE Account_ID = @Account_ID;

DELETE FROM Vehicle WHERE Number_Plate = @Number_Plate;
 

/*Dummy Data*/
INSERT INTO Vehicle
([Number_Plate]
,[Vehicle_Kind]
,[Account_ID]
,[Current_KM]
,[BuyDate]
,[BuyCost])
VALUES
('AC-130-HP'
,'Mercedes'
,'MercedesMan@hotmail.com'
,1300
,'2020-03-15 15:00:01'
,10890);

INSERT INTO Vehicle
([Number_Plate]
,[Vehicle_Kind]
,[Account_ID]
,[Current_KM]
,[BuyDate]
,[BuyCost])
VALUES
('AMR-21-11'
,'Aston Martin DB11'
,'AstonMartinDriver@Mercedes.com'
,19027
,'2020-03-27 10:10:01'
,4799);



INSERT INTO Vehicle(Number_Plate, Vehicle_Kind, Account_ID, Current_KM, BuyDate, BuyCost)
VALUES("FOR-I-80", "Aston Martin Car", "TestDummy@MyDomain.info", 1, '2010-03-15 09:45:09', 2400);

INSERT INTO Vehicle(Number_Plate, Vehicle_Kind, Account_ID, Current_KM, BuyDate, BuyCost)
VALUES("BB-90-PP", "Honda Car", "kevin.voet@grandmaster.nhlstenden.com", 1300, '2020-03-15 15:00:01', 4799);
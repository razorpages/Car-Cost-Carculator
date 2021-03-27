/*IDENTITY = AUTO_INCREMENT*/
CREATE TABLE costs(
Cost_ID INTEGER NOT NULL IDENTITY,
Cost_Name VARCHAR(40),
Cost_Amount FLOAT,
Cost_Date DATETIME,
Vehicle_Cost VARCHAR(16),
PRIMARY KEY(cost_ID),
FOREIGN KEY(Vehicle_Cost) REFERENCES Vehicle(Number_Plate)
);

DROP TABLE costs;

INSERT INTO costs
([Cost_Name]
,[Cost_Amount]
,[Cost_Date]
,[Vehicle_Cost]
)
VALUES
('Gearbox Failure'
,100.00
,'2016-11-11 04:35:01'
,'AC-130-HP');

INSERT INTO costs
([Cost_Name]
,[Cost_Amount]
,[Cost_Date]
,[Vehicle_Cost]
)
VALUES
('Front Wing Damage'
,1200.00
,'2021-03-03 09:35:01'
,'AC-130-HP');

INSERT INTO costs
([Cost_Name]
,[Cost_Amount]
,[Cost_Date]
,[Vehicle_Cost]
)
VALUES
('Engine Blowout'
,560.00
,'2011-11-11 12:35:09'
,'AMR-21-11');

/*Dapper*/
INSERT INTO costs(Cost_ID, Cost_Name, Cost_Amount, Cost_Date, Vehicle_Cost)
VALUES(@Cost_ID, @Cost_Name, @Cost_Amount, @Cost_Date, @Vehicle_Cost);

SELECT * FROM costs 
WHERE Vehicle_Cost = @Vehicle_Cost;

UPDATE costs 
SET Cost_Name = @Cost_Name
WHERE Vehicle_Cost = @Vehicle_Cost;

DELETE FROM costs
WHERE Cost_ID = @Cost_ID;

INSERT INTO costs( Cost_Name, Cost_Amount, Cost_Date, Vehicle_Cost)
VALUES( "New Tyres", 399.99, '2021-03-22 12:45:42', "AC-130-HP");

INSERT INTO costs(Cost_Name, Cost_Amount, Cost_Date, Vehicle_Cost)
VALUES("Gearbox Failure", 99.99, '2021-03-22 12:45:42', "FOR-I-80");

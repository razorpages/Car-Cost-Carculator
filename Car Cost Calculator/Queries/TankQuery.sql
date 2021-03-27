CREATE TABLE tank(
Tank_ID INTEGER NOT NULL,
Before_Tank_KM INTEGER,
After_Tank_KM INTEGER,
Tank_Cost FLOAT,
Tank_Date DATETIME,
Vehicle_KM VARCHAR(16),
PRIMARY KEY(Tank_ID),
FOREIGN KEY (Vehicle_KM) REFERENCES Vehicle(Number_Plate)
);

DROP TABLE tank;

SELECT * FROM tank
WHERE Vehicle_KM = @Vehicle_KM;

/*Dapper*/
INSERT INTO tank (Tank_ID, Before_Tank_KM, After_Tank_KM, Tank_Cost, Tank_Date, Vehicle_KM)
VALUES(@Tank_ID, @Before_Tank_KM, @After_Tank_KM, @Tank_Cost, @Tank_Date, @Vehicle_KM);

SELECT * FROM tank
WHERE Vehicle_KM = @Vehicle_KM;

UPDATE  tank
SET Before_Tank_KM = @Before_Tank_KM, After_Tank_KM = @After_Tank_KM
WHERE @Vehicle_Cost = @Vehicle_Cost;

/*NO DELETE!usersusers*/

INSERT INTO tank
([Tank_ID]
,[Before_Tank_KM]
,[After_Tank_KM]
,[Tank_Cost]
,[Tank_Date]
,[Vehicle_KM])
VALUES
(1
,47868
,48009
,57.90
,'2002-12-04 05:30:01'
,'AC-130-HP');

INSERT INTO tank
([Tank_ID]
,[Before_Tank_KM]
,[After_Tank_KM]
,[Tank_Cost]
,[Tank_Date]
,[Vehicle_KM])
VALUES
(2
,52668
,60000
,89.00
,'2019-04-04 07:30:09'
,'AMR-21-11');
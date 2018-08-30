--CANNOT DROP DATABASE PROPERLY
use master
go

IF EXISTS(select * from sys.databases where name='udbTableTap')
DROP DATABASE udbTableTap
go

CREATE DATABASE udbTableTap
go

USE udbTableTap
go

--table creation
CREATE TABLE tblBuilding (
	buildingID		INT IDENTITY(001,1) PRIMARY KEY,
	buildingLabel	NVARCHAR(10) NOT NULL,
	buildingName	NVARCHAR(50) NOT NULL,
	roomQty			SMALLINT NOT NULL,
	buildingMap		IMAGE --temporarily Null since we haven't figured out how we're gonna make it interactive
	)

CREATE TABLE tblRoom (
	roomID			INT IDENTITY(0001,1) PRIMARY KEY,
	roomName		NVARCHAR(50) NOT NULL,
	roomLabel		NVARCHAR(10) NOT NULL,
	buildingID		INT NOT NULL,
	openingTime		TIME(0) NOT NULL,
	closingTime		TIME(0) NOT NULL,
	roomMap			IMAGE, --Same as building map
	tableQty		SMALLINT NOT NULL,
	tablesAvailable SMALLINT NOT NULL DEFAULT 0,

	CONSTRAINT fk_RoomBuilding FOREIGN KEY (buildingID) REFERENCES tblBuilding(buildingID)
	)

CREATE TABLE tblTable (
	tableID			INT IDENTITY(00001,1) PRIMARY KEY,
	tableQR			NVARCHAR(50) NOT NULL,
	roomID			INT NOT NULL,
	personCapacity	SMALLINT NOT NULL,
	category		NVARCHAR(10) NOT NULL,
	available		BIT NOT NULL DEFAULT 0,
	reservable		BIT NOT NULL DEFAULT 0,

	CONSTRAINT fk_TableRoom FOREIGN KEY (roomID) REFERENCES tblRoom(roomID)
	)
	
	
CREATE TABLE tblUser (
	userID			INT IDENTITY(100001,1) PRIMARY KEY,
	emailAddress	NVARCHAR(100) NOT NULL,
	passcode		NVARCHAR(30) NOT NULL,
	firstName		NVARCHAR(40),
	lastName		NVARCHAR(40),
	adminPermission	BIT NOT NULL DEFAULT 0
	)

CREATE TABLE tblReservation (
	reservationID	INT IDENTITY(00001,1) PRIMARY KEY,
	userID			INT NOT NULL,
	tableID			INT NOT NULL,
	reservationStartTime	DATETIME NOT NULL,
	reservationFinishTime	DATETIME NOT NULL,
	groupName				NVARCHAR(50) NOT NULL,

	CONSTRAINT fk_ReserverID FOREIGN KEY (userID) REFERENCES tblUser(userID),
	CONSTRAINT fk_ReservedTable FOREIGN KEY (tableID) REFERENCES tblTable(tableID)
	)

CREATE TABLE tblSession (
	sessionID		INT IDENTITY(000000001, 1) PRIMARY KEY,
	tableID			INT NOT NULL,
	sessionStartTime	DATETIME DEFAULT GETDATE(),
	sessionFinishTime	DATETIME NOT NULL,
	sessionName			NVARCHAR(50), --optional session name. session name will pop up on map and may help users find where their group/friends are sitting

	CONSTRAINT fk_OccupiedTable FOREIGN KEY (tableID) REFERENCES tblTable(tableID)
	)
go


--sets default value of tablesAvailable as tableQty when a room is created
CREATE TRIGGER tblRoom_AfterInsert_TRG
  ON tblRoom
AFTER INSERT
AS
  UPDATE tblRoom
  SET tblRoom.tablesAvailable = tblRoom.tableQty
  FROM Inserted AS i
  WHERE tblRoom.roomID = i.roomID ;
go

--Test values
INSERT INTO tblBuilding(buildingName, buildingLabel, roomQty)
VALUES ('Auchmuty Library', 'L', 2), ('Huxley Library', 'H', 1), ('ICT Building', 'ICT', 1)
go

INSERT INTO tblRoom(roomName, roomLabel, buildingID, openingTime, closingTime, tableQty)
VALUES ('Auchmuty Information Common', 'L-266', 001, '00:00:00', '23:59:59', 100), 
('Huxley Information Common Area', 'HA-157', 002, '08:00:00', '22:00:00', 140)
go

INSERT INTO tblTable(tableQR, roomID, personCapacity, category, reservable)
VALUES ('18nvjwk89', 0001, 6, 'Large', 1), ('mvne439j0d', 0001, 2, 'Small', 0),
('8jf74hn3j4', 0001, 6, 'Lounge', 1), ('mklpo098ik', 0002, 1, 'Computer', 0)
go

INSERT INTO tblUser(emailAddress, passcode, firstName, lastName, adminPermission)
VALUES ('kepler@uon.edu.au', 'password1', 'Kepler', 'Manu', 0),
('admin@official.com', 'password2', NULL, NULL, 1),
('michael@uon.edu.au', 'password3', 'Michael', NULL, 0)
go

INSERT INTO tblReservation(userID, tableID, reservationStartTime, reservationFinishTime, groupName)
VALUES (100001, 1, '2018-09-15 12:00:00', '2018-09-15 13:00:00', 'Keplers group, INFT3970'),
(100003, 3, '2018-09-15 12:00:00', '2018-09-15 13:00:00', 'Michaels group, INFT3960')
go

INSERT INTO tblSession(tableID, sessionStartTime, sessionFinishTime, sessionName)
VALUES (2, '2018-09-16 12:00:00', '2018-09-16 15:20:02', 'Beau'), 
(4, '2018-09-15 11:00:00', '2018-09-15 16:05:40', NULL)
go

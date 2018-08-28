DROP TABLE udbTableTap.dbo.tblSession;
DROP TABLE udbTableTap.dbo.tblReservation;
DROP TABLE udbTableTap.dbo.tblUser;
DROP TABLE udbTableTap.dbo.tblTable;
DROP TABLE udbTableTap.dbo.tblRoom;
DROP TABLE udbTableTap.dbo.tblBuilding;

CREATE TABLE udbTableTap.dbo.tblBuilding (
	buildingID		nchar(10) NOT NULL PRIMARY KEY,
	buildingName	nvarchar(50) NOT NULL,
	roomQty			smallint NOT NULL,
	buildingMap		image NOT NULL)

CREATE TABLE udbTableTap.dbo.tblRoom (
	roomID			nchar(10) NOT NULL PRIMARY KEY,
	roomName		nvarchar(50) NOT NULL,
	buildingID		nchar(10) NOT NULL,
	openingTime		time(7) NOT NULL,
	closingTime		time(7) NOT NULL,
	roomMap			image NOT NULL,
	tableQty		smallint NOT NULL,
	tablesAvailable smallint NOT NULL,
	FOREIGN KEY (buildingID) REFERENCES udbTableTap.dbo.tblBuilding(buildingID))

CREATE TABLE udbTableTap.dbo.tblTable (
	tableQR			varchar(50) NOT NULL PRIMARY KEY,
	roomID			nchar(10) NOT NULL,
	personCapacity	smallint NOT NULL,
	category		char(10) NOT NULL,
	available		bit NOT NULL,
	FOREIGN KEY (roomID) REFERENCES udbTableTap.dbo.tblRoom(roomID))
	
	
CREATE TABLE udbTableTap.dbo.tblUser (
	emailAddress	nvarchar(100) NOT NULL PRIMARY KEY,
	userPassword	nvarchar(30) NOT NULL,
	firstName		nvarchar(40),
	lastName		nvarchar(40),
	adminPermission	bit NOT NULL)

CREATE TABLE udbTableTap.dbo.tblReservation (
	reservationID	varchar(10)	NOT NULL PRIMARY KEY,
	emailAddress	nvarchar(100) NOT NULL,
	tableQR			varchar(50) NOT NULL,
	reservationStartTime	datetime NOT NULL,
	reservationFinishTime	datetime NOT NULL,
	groupName				nchar(10) NOT NULL,
	FOREIGN KEY (emailAddress) REFERENCES udbTableTap.dbo.tblUser(emailAddress),
	FOREIGN KEY (tableQR) REFERENCES udbTableTap.dbo.tblTable(tableQR))

CREATE TABLE udbTableTap.dbo.tblSession (
	sessionID		int NOT NULL PRIMARY KEY,
	tableQR			varchar(50),
	sessionStartTime	datetime,
	sessionFinishTime	datetime,
	name			nvarchar(25),
	FOREIGN KEY (tableQR) REFERENCES udbTableTap.dbo.tblTable(tableQR))


	

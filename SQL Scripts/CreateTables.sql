CREATE TABLE Player (
	id int IDENTITY(1,1) PRIMARY KEY,
    firstName varchar(255) NOT NULL,
    lastName varchar(255) NOT NULL,
	pdgaNum char(6)
);

CREATE TABLE LMSUser (
	id int IDENTITY(1,1) PRIMARY KEY,
	userName varchar(50) NOT NULL,
	password varchar(25) NOT NULL,
	privileges char(7) NOT NULL,
	playerID int
	CONSTRAINT lms_user_player_fk FOREIGN KEY (playerID) REFERENCES Player(id)
);

CREATE TABLE League (
	id int IDENTITY(1,1) PRIMARY KEY,
	name varchar(255) NOT NULL,
	startDate date,
	endDate date,
	courseName varchar(255)
);

CREATE TABLE Round (
	leagueID int NOT NULL,
	playerID int NOT NULL,
	dateOfRound date,
	score int
	CONSTRAINT round_pk PRIMARY KEY (leagueID, playerID, dateOfRound),
	CONSTRAINT round_league_fk FOREIGN KEY (leagueID)
		REFERENCES League(id),
	CONSTRAINT round_player_fk FOREIGN KEY (playerID)
		REFERENCES Player(id)
);

/*I did forget to include update and delete cascading when creating the tables but they have been included now*/
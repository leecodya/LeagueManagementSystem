/* ADMIN - MANAGE LEAGUES QUERIES */
/** Add League **/
insert into League
values
('HCDGC Fall 2021', '2021-08-19', '2021-10-07', 'Rozar Park');

/** Edit League **/
select * from League;

update League
set courseName = 'Rozar'
where League.id = 2;

/** Add Players to League **/
select id, name from League;
select id, firstName, lastName from Player;

insert into LeaguePlayers
values
(2, 3);

/* ADMIN - MANAGE USERS QUERIES */
/** Add User that is Not a Player (and therefore no playerId will be entered) **/
insert into LMSUser
values
('slee', 'test1234', 'regular', null);

/** Add User that IS a Player **/
	/*** search for player id (in this case, player ID is 2 and is added to insert statement below ***/
	select id
	from Player
	where firstName = 'LeighAnn'
	and lastName = 'Shell';

insert into LMSUser
values
('lshell', 'test1234', 'regular', 2);
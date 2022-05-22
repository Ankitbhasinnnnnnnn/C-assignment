USE Cricket
GO
create table Player 
(Player_id int not null identity(1,1) primary key,
Player_name varchar(30), 
player_age varchar(30) ,
Country_id int FOREIGN KEY REFERENCES Country(Country_id)
)

insert into Player values
('Steve Smith' , 30 , 1),
('Nathon Lyon' , 34, 1),
('Mitchell Starc' , 32, 1),
('Shaun March' , 38, 1),
('Mattew Wade' , 34, 1),
('Aaron Finch' , 35, 1),
('Glen Maxwell' , 33, 1),
('Chriss Lyn', 32, 1),
('Nathan Coulter-Nile', 32, 1),
('James Pattinson' , 33, 1),
('George Bailey', 31, 1)

insert into Player values
('Asif Ali' , 30 , ),
('Nathon Lyon' , 34, 1),
('Mitchell Starc' , 32, 1),
('Shaun March' , 38, 1),
('Mattew Wade' , 34, 1),
('Aaron Finch' , 35, 1),
('Glen Maxwell' , 33, 1),
('Chriss Lyn', 32, 1),
('Nathan Coulter-Nile', 32, 1),
('James Pattinson' , 33, 1),
('George Bailey', 31, 1)

--England


insert into Player values
('Joe Root' , 31, 2),
('Ben Stokes' , 30 , 2),
('Jofra Archer' , 30 , 2),
('Jos Buttler' , 29 , 2),
('Eoin Buttler' , 28 , 2),
('Johnny Bairstow ', 28 , 2),
('Moein Ali' , 30 ,2),
('Chris Woakes' , 29 , 2),
('Jason Roy' , 33,2),
('Mark Wood' , 31 , 2),
('Liam Plunkett' ,30 , 2)

insert into Player values
('Rohit Sharma', 32, 3),
('Virat Kohli' , 34, 3),
('Kl Rahul' , 29 , 3),
('Rishab Pant' , 28, 3),
('Hardik Pandya' , 29 , 3),
('Ravindra Jadeja', 34 , 3),
('Mahindra Dhoni' ,35 , 3),
('Jaspreet Bumrah' ,32 , 3),
('Mayank Aggarwal ', 31 , 3),
('Kuldeep Yadav', 28 , 3),
('Mohammad Swami ' , 31 , 3)



select * from Player;


insert into Player values
('Liton Das', 31, 5),
('Mehidy Hasan', 32 , 5),
('khaled Ahmed', 31 , 5),
('Yasir Ali', 32 , 5),
('Nayam Hasan' , 33 , 5),
('Mushfiqur Rahim' ,31 , 5),
('taijul islam', 31, 5),
('Shakib Al Hasan' , 32, 5),
('Rejaur Rahman', 31 , 5),
('Nurul Hasan', 36 , 5),
('Tamim Iqbal' , 31, 5)





select * from Player;


create table Stadium (
stadium_name varchar(30)  primary key, 
stadium_matches int,
stadium_count bigint ,
stadium_id int FOREIGN KEY REFERENCES Country(Country_id) , 
)
select * from Player;
insert into Stadium values 
('Melbourn Ground' , 2, 150000 , 1),
('Sydney Cricket Ground',2,20000,1),
('Lords', 3, 30000, 2),
('The Oval' , 3 , 75000, 2),
('Eden Garden' , 2, 50000,3),
('Rajiv Gandhi Stadium',2, 70000, 3),
('Gaddafi Ground' ,2, 40000, 4),
('MULTAN CRICKET STADIUM' , 2, 50000, 4),
('Shaheed Chandu Stadium', 3, 20000, 5),
('Bangabandhu National Stadium' , 4 , 10000, 5)

create table Matches 
( Match_id int identity(1,1) primary key,
Stadium_name varchar(30) ,
Team_A int FOREIGN KEY REFERENCES Country(Country_id),
Team_B int FOREIGN KEY REFERENCES Country(Country_id),
Result varchar(30) ,
Date_Time datetime ,
was_match_played varchar(30))


insert into Matches values 
( 'lords' , 1,2,null ,'2021-04-12 18:00:00',null),
('Eden Garden', 3 , 4 ,null , '2021-06-16', null),
('The Oval' , 2, 3, null , '2022-08-17 12:00' , null),
('Multan cricket', 4,5, null , '2022-06-17 18:00' , null)



select * from Matches;


Create Database Hostel;
use Hostel;
set sql_safe_updates = 0;
create table Rooms(
RoomNo bigint not null primary key,
RoomStatus varchar(250) not null,
Booked varchar(150) default 'No' 
);
describe table Rooms;
select * from Rooms;
create table Fees(
	MobileNo bigint not null,
    FeeMonth varchar(60) not null,
    Amount bigint not null
);
select * from Fees;
Create Table NewStudentDetails(
	Id int primary key  auto_increment,
	Name varchar(250) not null,
	MobileNo bigint not null,
	FathersName varchar(250) not null,
	MothersName varchar(250) not null,
	ParrentsMobileNo bigint not null,
	Email varchar(250),
	Gender varchar(250) not null,
	CollegeName varchar(250) not null,
	CollegeRoll int not null,
	IDProof varchar(250) not null,
	StudyField varchar(250) not null,
	RoomNo bigint not null,
	Living varchar(250) default 'Yes',
	Address varchar(500) not null,
	FOREIGN KEY (RoomNo) REFERENCES Rooms(RoomNo)
);
select *from NewStudentDetails;
create table UserDetails(
	Id int primary key  auto_increment,
	Name varchar(250) not null,
    UserID varchar(25) not null UNIQUE,
    Password varchar(30) not null UNIQUE
);
select * from UserDetails;
#drop table UserDetails;
/*drop table NewStudentDetails;*/
/*ALTER TABLE NewStudentDetails DROP COLUMN BookingDate;*/
/*Name,MobileNo,FathersName,MothersName,ParrentsMobileNo,Email,Gender,CollegeName,CollegeRoll,IDProof,StudyField,BookingDate,RoomNo,Living,Address */
/*FOREIGN KEY (RoomNo) REFERENCES Rooms(RoomNo),*/
insert into UserDetails(Name,UserID,Password)
values
(
	'jinu',
    'jinu',
    '0292'
);

create table InOutStatus(
	RoomNo bigint not null,
	Name varchar(30),
	StatusOut varchar(3),
	Purpose varchar(300),
	OutTime varchar(20),
	OutDate varchar(30),
	StatusIN varchar(3),
	InTime varchar(20),
	InDate varchar(30),
	FOREIGN KEY (RoomNo) REFERENCES Rooms(RoomNo)
);
select * from InOutStatus;
insert into InOutStatus(RoomNo,Name,StatusOut,Purpose,OutTime,OutDate,StatusIN,InTime,InDate)
values(
	100,
    'Deepak',
    'Yes',
    'Market',
    '5:30 pm',
    '08/08/2022',
    '',
    '',
    ''
);

insert into InOutStatus(RoomNo,Name,StatusOut,Purpose,OutTime,OutDate,StatusIN,InTime,InDate)
values(
	100,
    'Deepak',
    'No',
    '',
    '',
    '',
    'Yes',
    '6:00pm',
    '08/08/2022'
);
select * from InOutStatus;
#Get Room Data Query
select count(*) from Rooms where RoomStatus = 'Yes'; /* Avilable Roms */
select count(*) from Rooms where RoomStatus = 'No'; /* Under Maintainance Roms */
select count(*) from Rooms where Booked = 'Yes'; /* Booked Roms */
select count(*) from Rooms; /* Totl Roms In Hostel */

#Get student Details Queery
select count(*) from NewStudentDetails where Gender = 'Boy' and Living='Yes';/*Living Boys in Hostel Roms */
select count(*) from NewStudentDetails where Gender = 'Boy' and Living='No';/*Leaved Boys From Hostel Roms */
select count(*) from NewStudentDetails where Gender = 'Girl' and Living='Yes';/*Living Girls in Hostel Roms */
select count(*) from NewStudentDetails where Gender = 'Girl' and Living='No';/*Living Girls From Hostel Roms */

#Software user
select count(*) from UserDetails; /*Current Software User*/
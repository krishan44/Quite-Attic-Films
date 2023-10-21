create table Client(
	cSerial int,
	CID varchar(20)not null,
	cFname varchar(30),
	cLname varchar(40) not null,
	cCompany varchar(60),
	Email varchar (40),
	ConNo int not null,
	primary key(CID)
);
create table Prodution (
	prSerial int,
	PID varchar(40) not null,
	pName varchar(20)not null,
	Duration int not null,
	pType varchar(30)not null,
	Customer_ID varchar(20)not null,
	primary Key(PID),
	foreign Key(Customer_ID) references Client(CID)
);
create table Location(
	Lserial int,
	LID varchar(30),
	loName Varchar(20)NOT NULL,
	conNo int not null,
	type varchar(30),
	Prodution_ID varchar(40),
	primary key(LID),
	foreign key (Prodution_ID) references Prodution(PID)
);
create table Property (
	propSer int,
	PrID varchar (30)not null,
	PrName varchar(20)not null,
	PrType varchar (20)not null,
	Description varchar (150)not null,
	Prodution_ID varchar(40)not null,
	foreign key (Prodution_ID) references Prodution(PID)
);
create table staff(
	stSerial int,
	SID varchar(20)not null,
	Fname varchar(30),
	Lname Varchar(30),
	NIC char(12) not null,
	Email varchar(40),
	ConNo int not null,
	Type varchar (20),
	Prodution_ID varchar(40)not null,
	primary key(SID),
	foreign key (Prodution_ID) references Prodution(PID)
);
create table pay(
	pSerial int,
	SID varchar(20),
	Hr_Rate decimal(5,2) not null,
	Hr_Worked int not null,
	Total int not null,
	foreign key (SID) references staff(SID)
);
create table users(
	User_name varchar(20) not null,
	User_PW varchar(20)not null,
	User_type varchar (20)not null,
	Real_Name varchar(50)not null
);
create table Cost(
	RefID varchar(20)not null,
	Estimation decimal(15,2) not null,
	Paid decimal(15,2) not null,
	Customer_ID varchar(20)not null,
	Prodution_ID varchar(40)not null,
	primary key (RefID),
	foreign key (Prodution_ID) references Prodution(PID),
	foreign key (Prodution_ID) references Prodution(PID)
);








drop table Property;
drop table Location;
drop table Prodution;
drop table Client;

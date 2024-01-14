create database DemoLogin
go

use DemoLogin
go

create table Account (
	Id bigint not null primary key identity,
	Email varchar(50) not null unique,
	Password varchar(200) not null,
	Address ntext,
	Avatar varchar(200),
	IsActived bit not null default 1,
	IsDeleted bit not null default 0
)
go

insert into Account values
('quandh@gmail.com', '123123', null, null, 1, 0);

select * from Account
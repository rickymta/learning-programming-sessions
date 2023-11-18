-- Relational
create table Departments (
	Id int primary key identity,
	Name nvarchar(50),
	Code varchar(50) not null unique,
	Status bit not null default 1 -- (boolean | bit sẽ nhận 2 giá trị: 1, 0 tương ứng với true và false)
)
go

drop table Employees;
create table Employees (
	Id int primary key identity,
	Name nvarchar(50),
	Role nvarchar(50),
	DepartmentId int foreign key references Departments(Id)
)
go

insert into Departments values
(N'Đào tạo', 'DT', 1),
(N'Hành Chính', 'HC', 0),
(N'Phát triển sản phẩm', 'PTSP', 1);

insert into Employees values
(N'Dương Trung Đạt', 'Manager', 3),
(N'Phạm Thị Huyền', 'BrSE', 3),
(N'Nghiêm Phương Anh', 'QA', 1),
(N'Nguyễn Tiến Đông', N'Lễ tân', 2),
(N'Nguyễn Văn Khánh', 'IT', 2),
(N'Nguyễn Văn Đạt', 'IT', 2),
(N'Nguyễn Đức Cường', 'Dev', 3);

select * from Departments
select * from Employees

select * from Departments inner join Employees on Departments.Id = Employees.DepartmentId

select
	e.Id MaNV,
	e.Name HoVaTen,
	e.Role ChucVu,
	d.Name TenPhongBan,
	d.Status TrangThaiPhongBan
from
	Departments d
inner join
	Employees e
on
	d.Id = e.DepartmentId


insert into Departments values
('', null, 1); --'' string.IsNullOrWhiteSpace() | string.IsNullOrEmpty()
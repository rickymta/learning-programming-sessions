-- tạo database Demo
create database Demo
go

-- sử dụng database Demo
use Demo
go

-- tạo bảng Employees
create table Employees (
	Id int primary key identity,
	Name nvarchar(50),
	Role nvarchar(50)
)
go

-- thêm dữ liệu vào bảng Employees
insert into Employees values
(N'Nguyễn Văn A', N'PM'),
(N'Nguyễn Văn B', N'JQC'),
(N'Nguyễn Văn C', N'BrSE'),
(N'Nguyễn Văn D', N'Dev'),
(N'Nguyễn Văn E', N'QC');

-- lấy toàn bộ dữ liệu từ bảng Employees
select * from Employees

-- cập nhật dữ liệu
update Employees set Name = N'Dương Trung Đạt' where Id = 1 --(unicode)

update
	Employees
set
	Name = N'Phạm Thị Huyền',
	Role = N'SubPM'
where
	Id = 3

-- xoá dữ liệu
delete from Employees where Id = 2

-- SQL script (CRUD)
--insert (C-Create)
--select (R-Read)
--update (U-Update)
--delete (D-Delete)
-- <table_name>

-- câu lệnh select:
select top 3 Name Ten, Role ChucVu from Employees
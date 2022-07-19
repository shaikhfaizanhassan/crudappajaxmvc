create database crudajax
go
use crudajax
go
create table employeetb
(
	Eid int identity primary key,
	Ename nvarchar(50),
	EEmail nvarchar(50),
	EPassword nvarchar(50),
	EGender nvarchar(50),
)
select * from employeetb
go
--Start Store Procedure
--Select	
create proc Select_Employee
as
	begin
	select * from employeetb;
	end
	
--Insert Update
go

create proc insert_Proc(
	@id integer,
	@name nvarchar(50),
	@email nvarchar(50),
	@password nvarchar(50),
	@gender nvarchar(50))

	as 
		begin
			insert into employeetb (Ename,EEmail,EPassword,EGender)
			values (@name,@email,@password,@gender);
		end

		go
		
create proc update_Proc(
	@id integer,
	@name nvarchar(50),
	@email nvarchar(50),
	@password nvarchar(50),
	@gender nvarchar(50))

	as 
		begin
			update employeetb
			set Ename = @name,
			EEmail = @email,
			EPassword = @password,
			EGender = @gender

			where Eid = @id;

			end
	
	go
	create proc DeleteEmployeeStor(@id integer)
	as
	begin
	delete employeetb 
	where Eid = @id;
	end


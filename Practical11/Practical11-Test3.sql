select * from employee;
select * from Designation;
create table employee(Id int primary key identity(1,1),FirstName varchar(50) not null,MiddleName varchar(50),LastName varchar(50) not null,DOB date not null,MobileNumber varchar(10) not null,Address varchar(100),Salary Decimal not null,DesignationId int foreign key references Designation(Id));
insert into designation values('FrontEnd Engineer');
insert into designation values('BackEnd Engineer');
insert into designation values('Software Engineer');
insert into designation values('Devops Engineer');
insert into designation values('HR Executive');

insert into employee values('Gaurav',null,'Rathor','2001-01-21','6359218480','Chandlodiya',50000,2);
insert into employee values('Parth','bhai','prajapati','2000-12-02','1234567890','Ahmedabad',20000,null);
insert into employee values('Shivang',null,'Rathod','1998-12-22','3456789210','Chandlodiya',30000,2);
insert into employee values('Tejas','singh','prajapati','2003-10-11','2345678901','Rajkot',30000,2);
insert into employee values('Anand','bhai','panchal','2002-01-11','1245780963','Chandlodiya',50000,3);
insert into employee values('Dhruv',null,'patel','2001-01-21','12121212','Gandhinagar',40000,4);
insert into employee values('Aman',null,'Singh','2002-12-20','1313131212','Bhavnagar',20000,4);
insert into employee values('Ankit','bhai','Rathor','2003-11-15','3456789098','Ranip',20000,null);
insert into employee values('Shyam',null,'Bhai','2002-11-19','1234987650','Vastral',30000,1);
insert into employee values('Dinesh',null,'Rathod','01-01-2001','3421786509','Bhuj',40000,1);

select d.Designation,count(e.FirstName) as TotalEmployee from employee e inner join designation d on e.designationid=d.id group by d.designation;
select e.FirstName,e.MiddleName,e.LastName,d.Designation from employee e left join designation d on e.designationid=d.id;
create view EmpInfo as select e.id,e.FirstName,e.MiddleName,e.LastName,d.Designation,e.DOB,e.MobileNumber,e.Address,e.salary from employee e left join designation d on e.designationid=d.id;
select * from empInfo;

create PROCEDURE DesignationInsert (@Designation varchar(50))
AS
  BEGIN 
  INSERT INTO Designation(Designation)
            VALUES     ( @Designation)
        END

create PROCEDURE EmployeeInsert (@firstname varchar(50),@middlename varchar(50),@lastname varchar(50),@dob date,@mobilenumber varchar(10),@address varchar(100),@salary decimal,@designationid int)
AS
  BEGIN 
  INSERT INTO Employee(FirstName,MiddleName,LastName,DOB,MobileNumber,Address,Salary,DesignationId)
            VALUES     (@firstname,@middlename,@lastname,@dob,@mobilenumber,@address,@salary,@designationid)
        END

select d.Designation as TotalEmployee from employee e inner join designation d on e.designationid=d.id group by d.designation  having count(e.FirstName)>1;

create procedure SelectEmployee
as
begin
select e.id,e.FirstName,e.MiddleName,e.LastName,d.Designation,e.DOB,e.MobileNumber,e.Address,e.salary from employee e left join designation d on e.designationid=d.id order by dob;
end

execute SelectEmployee;

create procedure EmployeebyDesignationID(@designationid int)
as
begin
select e.* from employee e where e.DesignationId=@designationid order by FirstName;
end

execute EmployeebyDesignationID 4;


create index DesignationId on employee(DesignationId);

select * from Employee where salary=(select max(salary) from Employee);





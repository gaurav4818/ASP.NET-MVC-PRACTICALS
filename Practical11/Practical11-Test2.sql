select * from employee;
create table employee(Id int primary key identity(1,1),FirstName varchar(50) not null,MiddleName varchar(50),LastName varchar(50) not null,DOB date not null,MobileNumber varchar(10) not null,Address varchar(100),Salary Decimal not null);
insert into employee values('Gaurav',null,'Rathor','2001-01-21','6359218480','Chandlodiya',50000);
insert into employee values('Parth','bhai','prajapati','2000-12-02','1234567890','Ahmedabad',20000);
insert into employee values('Shivang',null,'Rathod','1998-12-22','3456789210','Chandlodiya',30000);
insert into employee values('Tejas','singh','prajapati','2003-10-11','2345678901','Rajkot',30000);
insert into employee values('Anand','bhai','panchal','2002-01-11','1245780963','Chandlodiya',50000);
insert into employee values('Dhruv',null,'patel','2001-01-21','12121212','Gandhinagar',40000);
insert into employee values('Aman',null,'Singh','2002-12-20','1313131212','Bhavnagar',20000);
insert into employee values('Ankit','bhai','Rathor','2003-11-15','3456789098','Ranip',20000);
insert into employee values('Shyam',null,'Bhai','2002-11-19','1234987650','Vastral',30000);
insert into employee values('Dinesh',null,'Rathod','01-01-2001','3421786509','Bhuj',40000);

select sum(salary) as TotalSalary from Employee;
select * from Employee where DOB<'01-01-2000';
select count(*) as MiddleNameNull from Employee where MiddleName is null;




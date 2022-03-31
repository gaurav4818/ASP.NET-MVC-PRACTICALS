select * from employee;
insert into employee values('Gaurav',null,'Rathor','2001-01-21','6359218480','Chandlodiya');
insert into employee values('Parth','bhai','prajapati','2000-12-02','1234567890','Ahmedabad');
insert into employee values('Shivang',null,'Rathod','1998-12-22','3456789210','Chandlodiya');
insert into employee values('Tejas','singh','prajapati','2003-10-11','2345678901','Rajkot');
insert into employee values('Anand','bhai','panchal','2002-01-11','1245780963','Chandlodiya');
insert into employee values('Dhruv',null,'patel','2001-01-21','12121212','Gandhinagar');
insert into employee values('Aman',null,'Singh','2002-12-20','1313131212','Bhavnagar');
insert into employee values('Ankit','bhai','Rathor','2003-11-15','3456789098','Ranip');
insert into employee values('Shyam',null,'Bhai','2002-11-19','1234987650','Vastral');
insert into employee values('Dinesh',null,'Rathod','2001-01-09','3421786509','Bhuj');

update employee set FirstName='SQLPerson' where id=1;
update employee set MiddleName='I';

delete from employee where id<2;
delete from employee;

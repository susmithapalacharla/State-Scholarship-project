use StudentScholarshipdb;

create table scholarshipdetails(student_Id int  primary key not null,
Marks int not null, Grade varchar(100) not null,DemoCourse varchar(100) not null,College varchar(100) not null);

select * from scholarshipdetails;

delete from scholarshipdetails where student_Id=1001;


CREATE DATABASE  StudentManagement;
go
USE StudentManagement;
go
CREATE TABLE Student (
    id INT NOT NULL,
    name VARCHAR(255) NOT NULL,
    birth Nvarchar NOT NULL,
    address VARCHAR(255) NOT NULL,
    PRIMARY KEY (id)
);
set dateformat dmy

insert into Student values ('21521865','Tran Nguyen Quoc Bao','29/03/2003','Quang Ngai')
insert into Student values ('21521864','Nguyen Van A','29/08/2003','Ho Chi Minh')
insert into Student values ('21521863','Nguyen Van B','25/05/2003','Quang Nam')
insert into Student values ('21521862','Nguyen Van C','19/10/2003','Can Tho')
insert into Student values ('21521861','Nguyen Van D','24/07/2003','Da Lat')

select *from Student
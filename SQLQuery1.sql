create database Payroll_service

create table employee_payroll
(
id int not null,
name varchar(20) not null,
salary money not null,
start_date date not null
)

insert into employee_payroll values
(101,'Ram',10000.00,'2005-04-03'),
(102,'Shyam',20000.00,'2010-12-22'),
(103,'Dharani',30000.00,'2019-12-19')

select * from employee_payroll;

select salary from employee_payroll where name='Ram'
select * from employee_payroll 
where start_date between CAST('2010-01-01' as date) AND CAST('2020-01-01' as date)

alter table employee_payroll add gender char(1)
update employee_payroll 
set gender='M' 
where name='Ram' or name ='Shyam'

update employee_payroll
set gender='F' 
where name='Dharani'

select sum(salary) from employee_payroll where gender='M' group by gender;

select avg(salary) from employee_payroll where gender='M' group by gender;

select min(salary) from employee_payroll where gender='M' group by gender;

select max(salary) from employee_payroll where gender='M' group by gender;

select count(salary) from employee_payroll where gender='F' group by gender;

Alter table employee_payroll add phone_number varchar(15) 
Alter table employee_payroll add addres varchar(200) not null default 'TBD'
Alter table employee_payroll add department varchar(200) default null

select * from employee_payroll 
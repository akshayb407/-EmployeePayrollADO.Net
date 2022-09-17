Create Database Address_Book

Create Table Address_Book_Table
(
FirstName varchar(50),
LastName varchar(50),
_address varchar,
City varchar,
_State varchar,
Zip int,
PhoneNumber varchar(12),--With Country Code,
email varchar
)

Select * 
from Address_Book_Table

Insert into Address_Book_Table 
(FirstName,LastName,_address,City,_State,Zip,PhoneNumber,email) 
values('Akshay','Bhagwat','Katraj','Pune','Maharashtra',411056,'8087148746','ab@gmail.com')


Insert into Address_Book_Table
(FirstName,LastName,_address,City,_State,Zip,PhoneNumber,email) 
values('Rahul','Dravid',' Nagar','Bangalore','KN',500909,'919090909090','RD@gmail.com')


Insert into Address_Book_Table 
(FirstName,LastName,_address,City,_State,Zip,PhoneNumber,email) 
values('Manu','Thiparapu','torento','torento','Ontario',205532,'918978977310','manuthiparapu@gmail.com')



Update Address_Book_Table -- UC-4 Editing Data using FirstName
Set City='Warangal'
where FirstName='Manoj'


Delete -- UC-5-Delete Record Using FirstName
from Address_Book_Table
Where FirstName='Manu'

select * -- UC-6 Retrieve Record Using City
from Address_Book_Table
Where City='Katraj'


select * --Retrieve Using State
from Address_Book_Table
Where _State='Maharashtra'

select count(*)--UC-7-Count
from Address_Book_Table
where City='Bangalore'


select count(*)--UC-7-Count
from Address_Book_Table
where _State='TS'

select * -- UC-8 Sort FirstName using State 
From Address_Book_Table
Where _State='TS' 
ORDER BY FirstName
Go

select * -- UC-8 Sort FirstName using State 
From Address_Book_Table
Where City='Pune' 
ORDER BY FirstName

Alter Table Address_Book_Table--UC-9 Add Coulumn 
Add RelationType varchar(20) default 'Null'


Update Address_Book_Table
Set RelationType ='Family'
Where FirstName ='Pratik'

Update Address_Book_Table
Set RelationType ='Friend'
Where FirstName ='Sachin'

Insert into Address_Book_Table 
(FirstName,LastName,_address,City,_State,Zip,PhoneNumber,email,RelationType) 
values('Virendar','Sehwag','KishanGanj','Delhi','Delhi',543543,'919877899870','vs@gmail.com','Family')


select count(*)--UC-10-Count-Relation Type
from Address_Book_Table
where RelationType='Family'

Update Address_Book_Table -- UC -11 Family and Friend
Set RelationType='Family''Friend'
Where FirstName='Virendar'

create Table AddressBook2
(FirstName varchar(50) ,
RelationType varchar(20),
Foreign key(FirstName) References Address_Book_Table(FirstName)
)


Insert into AddressBook2(FirstName,RelationType) values('Virendar','Family,Friend')

Insert into AddressBook2(FirstName,RelationType) values('Rahul','Family')

Insert into AddressBook2(FirstName,RelationType) values('Akshay',NULL)

Insert into AddressBook2(FirstName,RelationType) values('Akshay','Family')

select *
From Address_Book_Table

select *
From AddressBook2
INSERT INTO CarClasses
  [ClassName]
)
VALUES
('a'),
('b'),
('c'),
('d'),
('e'),
('f'),
('m'),
('s'),
('j'),
('p')

GO


INSERT INTO CarModels
(
  [Model]
)
VALUES
('nexon'),
('A3'),
('A1'),
('A2'),
('A4'),
('100'),
('200'),
('A7'),
('A8'),
('A9'),
('A10')

GO

INSERT INTO Manufacturers
( -- columns to insert data into
  [WhoManufacturer]
)
VALUES
('Audi'),
('BMW'),
('Citroen'),
('Jeep'),
('Opel'),
('Subaru'),
('Suzuki'),
('Rover'),
('Lexus'),
('Mazda'),
('Ford'),
('Fiat')

GO

INSERT INTO Cars
( -- columns to insert data into
 [CarClassId], [ModelCarModelId],[WhoManufacturerCarId],[YearOfIssue],[RegistrationNumber])
VALUES
(1,1,1,'2008','K124'),
(2,2,2,'2000','B124'),
(3,3,3,'2006','E124'),
(4,4,4,'2004','J124'),
(4,3,2,'2012','B124'),
(3,1,2,'2003','Z124'),
(1,3,1,'2016','F124'),
(8,7,1,'2001','G124'),
(7,8,1,'1999','KJ124'),
(3,3,5,'2005','KK24'),
(3,6,7,'2003','L124'),
(3,7,9,'2009','O124'),
(6,4,1,'2008','P124'),
(9,3,1,'2002','Y124')

GO

INSERT INTO Users
( -- columns to insert data into
 [FirstName], [LastName], [DateOfBirth] ,[DlNumber]
)
VALUES
('Kolya','Myalik',CONVERT([date],'1996-01-09',5),'Agfks8412nfdas'),
('Vitya','MyaBoolik',CONVERT([date],'1995-05-11',5),'asd12ras2nfl'),
('Andrey','Booler',CONVERT([date],'1983-03-15',5),'Afnu15442adasI'),
('Oled','Destir',CONVERT([date],'1979-11-01',5),'Esd64kam5das'),
('Alex','Ulyanov',CONVERT([date],'1998-06-21',5),'Dm14mz49fm'),
('Efim','Tihov',CONVERT([date],'1995-03-12',5),'hf1956jam14da'),
('Confim','Orlov',CONVERT([date],'1990-08-12',5),'dak1750d4mfna'),
('Anya','Sautin',CONVERT([date],'1986-03-31',5),'asdh175k023j'),
('Olya','Demyanchik',CONVERT([date],'1979-03-30',5),'dbfu16539akk12'),
('Muhamed','Obrexor',CONVERT([date],'1983-05-25',5),'dj1j57869ajaf'),
('Eli','Svetliy',CONVERT([date],'1986-02-08',5),'91056jwmm532'),
('Ome','Homie',CONVERT([date],'1995-03-07',5),'kd95j18dj38wj')

-- add more rows here
GO
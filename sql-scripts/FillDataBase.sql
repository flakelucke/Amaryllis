INSERT INTO CarClasses
(
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
(1,1,1,'2008','AB124B-7 '),
(2,2,2,'2000','BF124X-3'),
(3,3,3,'2006','ME124K-2'),
(4,4,4,'2004','GJ124A-3'),
(4,3,2,'2012','FB124F-4'),
(3,1,2,'2003','XZ124F-5'),
(1,3,1,'2016','FF124Q-3'),
(8,7,1,'2001','AG124J-3'),
(7,8,1,'1999','FK124F-1'),
(3,3,5,'2005','RKK24N-7'),
(3,6,7,'2003','EL124C-1'),
(3,7,9,'2009','EO124N-5'),
(6,4,1,'2008','FP124X-6'),
(9,3,1,'2002','GY124V-6')

GO

INSERT INTO Users
( 
 [FirstName], [LastName], [DateOfBirth] ,[DlNumber]
)
VALUES
('Kolya','Myalik','1996-01-09','Agfks8412nfdas'),
('Vitya','MyaBoolik','1995-05-11','asd12ras2nfl'),
('Andrey','Booler','1983-03-15','Afnu15442adasI'),
('Oled','Destir','1979-11-01','Esd64kam5das'),
('Alex','Ulyanov','1998-06-21','Dm14mz49fm'),
('Efim','Tihov','1995-03-12','hf1956jam14da'),
('Confim','Orlov','1990-08-12','dak1750d4mfna'),
('Anya','Sautin','1986-03-31','asdh175k023j'),
('Olya','Demyanchik','1979-03-30','dbfu16539akk12'),
('Muhamed','Obrexor','1983-05-25','dj1j57869ajaf'),
('Eli','Svetliy','1986-02-08','91056jwmm532'),
('Ome','Homie','1995-03-07','kd95j18dj38wj')

GO


INSERT INTO Orders
( -- columns to insert data into
 [Comment], [EndOfRental], [CarId],[StartOfRental],[UserId]
)
VALUES
('Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum',CONVERT([datetime],'13-06-12 10:34:09 PM',5),3,CONVERT([datetime],'18-11-12 15:34:09 PM',5),1),
('Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum',CONVERT([datetime],'15-06-13 17:36:09 PM',5),4,CONVERT([datetime],'18-06-14 03:34:09 PM',5),3),
('Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum',CONVERT([datetime],'17-07-12 16:34:13 PM',5),1,CONVERT([datetime],'18-06-13 10:34:09 PM',5),5),
('Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum',CONVERT([datetime],'11-06-15 13:33:15 PM',5),6,CONVERT([datetime],'18-07-15 11:34:09 PM',5),8),
('Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum',CONVERT([datetime],'19-06-12 12:38:09 PM',5),9,CONVERT([datetime],'18-11-12 09:34:09 PM',5),6),
('Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum',CONVERT([datetime],'13-06-12 21:34:07 PM',5),3,CONVERT([datetime],'19-06-12 16:34:09 PM',5),5),
('Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum',CONVERT([datetime],'16-06-12 15:31:11 PM',5),2,CONVERT([datetime],'18-09-12 13:34:09 PM',5),4),
('Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum',CONVERT([datetime],'18-06-12 11:32:09 PM',5),5,CONVERT([datetime],'18-07-12 11:35:09 PM',5),2)

-- add more rows here
GO
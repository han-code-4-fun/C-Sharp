/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

DELETE FROM [dbo].[Hall]
DBCC CHECKIDENT (Hall, RESEED, 1)
go


INSERT INTO [dbo].[Hall] ([HallName], [MaxRow], [MaxColume]) VALUES (N'Sky',5,4)
INSERT INTO [dbo].[Hall] ([HallName], [MaxRow], [MaxColume]) VALUES (N'Ocean',5,4)
INSERT INTO [dbo].[Hall] ([HallName], [MaxRow], [MaxColume]) VALUES (N'Earth',5,4)
go

DELETE FROM [dbo].[Movies]
DBCC CHECKIDENT (Movies, RESEED, 1)
go

INSERT INTO [dbo].[Movies] ([Name], [Description], [Duration_Minutes],[InitialPrice]) VALUES (N'Mission Impossible 6',
N'Another Tom Cruise action movie',120,40)
INSERT INTO [dbo].[Movies] ([Name], [Description], [Duration_Minutes],[InitialPrice]) VALUES (N'Thor',
N'Marvel studio proudly present',140,43)
INSERT INTO [dbo].[Movies] ([Name], [Description], [Duration_Minutes],[InitialPrice]) VALUES (N'Kill Bill',
N'Famour action movie',114,39)
go

DELETE FROM [dbo].[Customers]
DBCC CHECKIDENT (Customers, RESEED, 1)
go

INSERT INTO [dbo].[Customers]([FirstName], [LastName], [Phone],[Email]) VALUES (N'N/A',N'N/A',N'N/A',N'N/A')
INSERT INTO [dbo].[Customers]([FirstName], [LastName], [Phone],[Email]) VALUES (N'John',N'River',N'778-888-1234',N'johnr@gmail.com')
INSERT INTO [dbo].[Customers]([FirstName], [LastName], [Phone],[Email]) VALUES (N'Ruby',N'Kava',N'604-695-9983',N'rubyk@gmail.com')
INSERT INTO [dbo].[Customers]([FirstName], [LastName], [Phone],[Email]) VALUES (N'Teddy',N'Bear',N'604-342-4763',N'ttd@gmail.com')

go

DELETE FROM [dbo].[Snacks]
DBCC CHECKIDENT (Snacks, RESEED, 1)
go

INSERT INTO [dbo].[Snacks]([Name], [Price]) VALUES (N'Pepsi 500ml',2.0)
INSERT INTO [dbo].[Snacks]([Name], [Price]) VALUES (N'Pepsi 300ml can', 1.8)
INSERT INTO [dbo].[Snacks]([Name], [Price]) VALUES (N'Coke 500ml', 2.2)
INSERT INTO [dbo].[Snacks]([Name], [Price]) VALUES (N'Popcorn small', 2.5)
INSERT INTO [dbo].[Snacks]([Name], [Price]) VALUES (N'Popcorn medium', 3.5)
INSERT INTO [dbo].[Snacks]([Name], [Price]) VALUES (N'Popcorn super', 4.5)

go

DELETE FROM [dbo].[Schedules]
DBCC CHECKIDENT (Schedules, RESEED, 1)
go

INSERT INTO [dbo].[Schedules]([HallId],[MovieId],[StartTime]) VALUES (1,1,'09:00:00.0000000')
INSERT INTO [dbo].[Schedules]([HallId],[MovieId],[StartTime]) VALUES (1,1,'11:30:00.0000000')
INSERT INTO [dbo].[Schedules]([HallId],[MovieId],[StartTime]) VALUES (1,1,'14:00:00.0000000')
INSERT INTO [dbo].[Schedules]([HallId],[MovieId],[StartTime]) VALUES (1,1,'16:30:00.0000000')
INSERT INTO [dbo].[Schedules]([HallId],[MovieId],[StartTime]) VALUES (1,1,'19:00:00.0000000')
INSERT INTO [dbo].[Schedules]([HallId],[MovieId],[StartTime]) VALUES (1,1,'21:30:00.0000000')


INSERT INTO [dbo].[Schedules]([HallId],[MovieId],[StartTime]) VALUES (2,2,'09:00:00.0000000')
INSERT INTO [dbo].[Schedules]([HallId],[MovieId],[StartTime]) VALUES (2,2,'12:00:00.0000000')
INSERT INTO [dbo].[Schedules]([HallId],[MovieId],[StartTime]) VALUES (2,2,'15:00:00.0000000')
INSERT INTO [dbo].[Schedules]([HallId],[MovieId],[StartTime]) VALUES (2,2,'18:00:00.0000000')
INSERT INTO [dbo].[Schedules]([HallId],[MovieId],[StartTime]) VALUES (2,2,'21:00:00.0000000')

INSERT INTO [dbo].[Schedules]([HallId],[MovieId],[StartTime]) VALUES (3,3,'09:00:00.0000000')
INSERT INTO [dbo].[Schedules]([HallId],[MovieId],[StartTime]) VALUES (3,3,'11:30:00.0000000')
INSERT INTO [dbo].[Schedules]([HallId],[MovieId],[StartTime]) VALUES (3,3,'14:00:00.0000000')
INSERT INTO [dbo].[Schedules]([HallId],[MovieId],[StartTime]) VALUES (3,3,'16:30:00.0000000')
INSERT INTO [dbo].[Schedules]([HallId],[MovieId],[StartTime]) VALUES (3,3,'19:00:00.0000000')
INSERT INTO [dbo].[Schedules]([HallId],[MovieId],[StartTime]) VALUES (3,3,'21:30:00.0000000')


go

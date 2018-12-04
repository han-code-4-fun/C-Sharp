CREATE TABLE [dbo].[Hall]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [HallName] CHAR(30) NOT NULL, 
    [MaxRow] INT NOT NULL, 
    [MaxColume] INT NOT NULL 
)

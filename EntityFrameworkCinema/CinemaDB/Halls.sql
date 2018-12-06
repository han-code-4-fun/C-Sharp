CREATE TABLE [dbo].[Halls]
(
	[HallId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [HallName] VARCHAR(50) NOT NULL, 
    [NMaxRow] INT NOT NULL, 
    [NMaxColum] INT NOT NULL
)

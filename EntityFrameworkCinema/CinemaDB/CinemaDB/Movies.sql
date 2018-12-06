CREATE TABLE [dbo].[Movies]
(
    [MovieId]      INT           NOT NULL PRIMARY KEY IDENTITY,
    [Name]         VARCHAR (MAX) NOT NULL,
    [Description]  VARCHAR (MAX) NOT NULL,
	[Director]  VARCHAR (MAX) NOT NULL,
    [Duration_Minutes]     INT  NOT NULL,
    [InitialPrice] MONEY         NOT NULL,
)

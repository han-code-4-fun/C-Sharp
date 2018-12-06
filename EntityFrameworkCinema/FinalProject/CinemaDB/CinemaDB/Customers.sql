CREATE TABLE [dbo].[Customers]
(
	[CustomerId] INT NOT NULL PRIMARY KEY IDENTITY,
	[FirstName]  VARCHAR (MAX) NOT NULL,
    [LastName]   VARCHAR (MAX) NOT NULL,
	[Email]      VARCHAR (MAX) NOT NULL,
	[Phone]      VARCHAR (MAX) NOT NULL,
)

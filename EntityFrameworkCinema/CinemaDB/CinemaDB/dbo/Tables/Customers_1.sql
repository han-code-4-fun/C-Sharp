CREATE TABLE [dbo].[Customers] (
    [CustomerId] INT           NOT NULL,
    [FirstName]  VARCHAR (MAX) NULL,
    [Phone]      VARCHAR (MAX) NOT NULL,
    [Email]      VARCHAR (MAX) NOT NULL,
    [LastName]   VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);


CREATE TABLE [dbo].[Snacks] (
    [SnackId] INT           NOT NULL,
    [Name]    VARCHAR (MAX) NOT NULL,
    [Price]   MONEY         NOT NULL,
    PRIMARY KEY CLUSTERED ([SnackId] ASC)
);


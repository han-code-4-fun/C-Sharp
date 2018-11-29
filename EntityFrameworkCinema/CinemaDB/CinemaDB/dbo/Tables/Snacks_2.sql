CREATE TABLE [dbo].[Snacks] (
    [SnackId] INT           NOT NULL IDENTITY,
    [Name]    CHAR(30) NOT NULL,
    [Price]   MONEY         NOT NULL,
    PRIMARY KEY CLUSTERED ([SnackId] ASC)
);
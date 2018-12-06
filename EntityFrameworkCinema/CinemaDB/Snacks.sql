CREATE TABLE [dbo].[Snacks]
(
    [SnackId] INT           NOT NULL PRIMARY KEY IDENTITY,
    [Name]    VARCHAR(MAX) NOT NULL,
    [Price]   MONEY         NOT NULL,
)

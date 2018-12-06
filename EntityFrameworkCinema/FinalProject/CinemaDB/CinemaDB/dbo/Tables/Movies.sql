CREATE TABLE [dbo].[Movies] (
    [MovieId]      INT           NOT NULL,
    [Name]         VARCHAR (MAX) NULL,
    [Description]  VARCHAR (MAX) NULL,
    [Duration]     DECIMAL (18)  NULL,
    [InitialPrice] MONEY         NULL,
    PRIMARY KEY CLUSTERED ([MovieId] ASC)
);


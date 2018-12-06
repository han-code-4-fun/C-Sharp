CREATE TABLE [dbo].[Schedules] (
    [ScheduleId]    INT            NOT NULL,
    [MovieId]       INT            NOT NULL,
    [StartTime]     NVARCHAR (MAX) NOT NULL,
    [NumberOfSeats] INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([ScheduleId] ASC),
    CONSTRAINT [FK_dbo.Schedules_dbo.Movies_MovieId] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([MovieId]) ON DELETE CASCADE
);


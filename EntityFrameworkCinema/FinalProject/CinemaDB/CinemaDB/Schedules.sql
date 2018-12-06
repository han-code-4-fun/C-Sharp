CREATE TABLE [dbo].[Schedules]
(
    [ScheduleId]    INT NOT NULL PRIMARY KEY IDENTITY,
    [HallId] INT NOT NULL, 
	[MovieId]       INT            NOT NULL,
    [StartTime]     TIME NOT NULL,
	CONSTRAINT [FK_dbo.Schedules_dbo.Movies_MovieId] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([MovieId]) ON DELETE CASCADE,
	CONSTRAINT [FK_dbo.Schedules_dbo.Halls_HallId] FOREIGN KEY ([HallId]) REFERENCES [dbo].[Halls] ([HallId]) ON DELETE CASCADE
)

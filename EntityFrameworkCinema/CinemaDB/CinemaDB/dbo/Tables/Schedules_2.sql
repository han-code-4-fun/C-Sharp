CREATE TABLE [dbo].[Schedules] (
    [ScheduleId]    INT            NOT NULL IDENTITY,
    [HallId] INT NOT NULL, 
	[MovieId]       INT            NOT NULL,
    [StartTime]     TIME NOT NULL,
    


    
    PRIMARY KEY CLUSTERED ([ScheduleId] ASC),
    CONSTRAINT [FK_dbo.Schedules_dbo.Movies_MovieId] FOREIGN KEY ([MovieId]) REFERENCES [dbo].[Movies] ([MovieId]) ON DELETE CASCADE,
	CONSTRAINT [FK_dbo.Schedules_dbo.Hall_HallId] FOREIGN KEY ([HallId]) REFERENCES [dbo].[Hall] ([Id]) ON DELETE CASCADE
);
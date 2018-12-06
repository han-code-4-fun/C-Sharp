CREATE TABLE [dbo].[Orders]
(
	[OrderId] INT NOT NULL PRIMARY KEY IDENTITY,
	[CustomerId]       INT            NULL,
    [ScheduleId]       INT            NULL,
    [OrderTotal]       MONEY          NULL,
    [OrderDateTime]        DATETIME2     NULL,
    [TicketIdentifier] NVARCHAR (MAX) NULL,
	    CONSTRAINT [FK_dbo.Orders_dbo.Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([CustomerId]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.Orders_dbo.Schedules_ScheduleId] FOREIGN KEY ([ScheduleId]) REFERENCES [dbo].[Schedules] ([ScheduleId]) ON DELETE CASCADE
)

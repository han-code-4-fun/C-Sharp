CREATE TABLE [dbo].[Orders] (
    [OrderId]          INT            NOT NULL IDENTITY,
    [CustomerId]       INT            NULL,
    [ScheduleId]       INT            NULL,
    [OrderTotal]       MONEY          NULL,
    [OrderDateTime]        DATETIME2     NULL,
    [TicketIdentifier] NVARCHAR (MAX) NULL,
    [NumberOfTickets]  INT            NULL,
    [SeatsBooked] VARCHAR(MAX) NULL, 
    PRIMARY KEY CLUSTERED ([OrderId] ASC),
    CONSTRAINT [FK_dbo.Orders_dbo.Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([CustomerId]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.Orders_dbo.Schedules_ScheduleId] FOREIGN KEY ([ScheduleId]) REFERENCES [dbo].[Schedules] ([ScheduleId]) ON DELETE CASCADE
);
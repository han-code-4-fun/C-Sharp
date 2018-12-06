CREATE TABLE [dbo].[Orders] (
    [OrderId]          INT            NOT NULL,
    [CustomerId]       INT            NOT NULL,
    [ScheduleId]       INT            NOT NULL,
    [OrderTotal]       MONEY          NOT NULL,
    [OrderDate]        ROWVERSION     NOT NULL,
    [TicketIdentifier] NVARCHAR (MAX) NOT NULL,
    [NumberOfTickets]  INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([OrderId] ASC),
    CONSTRAINT [FK_dbo.Orders_dbo.Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([CustomerId]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.Orders_dbo.Schedules_ScheduleId] FOREIGN KEY ([ScheduleId]) REFERENCES [dbo].[Schedules] ([ScheduleId]) ON DELETE CASCADE
);


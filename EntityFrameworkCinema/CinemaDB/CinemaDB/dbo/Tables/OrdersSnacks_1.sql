CREATE TABLE [dbo].[OrdersSnacks] (
    [Id]         INT   NOT NULL,
    [OrderId]    INT   NOT NULL,
    [SnackId]    INT   NOT NULL,
    [Quantity]   INT   NOT NULL,
    [TotalPrice] MONEY NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.OrdersSnacks_dbo.Order_OrderId] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Orders] ([OrderId]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.OrdersSnacks_dbo.Snacke_SnakeId] FOREIGN KEY ([SnackId]) REFERENCES [dbo].[Snacks] ([SnackId]) ON DELETE CASCADE
);


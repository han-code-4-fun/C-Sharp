CREATE TABLE [dbo].[SeatsOrders]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Row] INT NULL, 
    [Column] INT NULL, 
    [OrderId] INT NULL,
CONSTRAINT [FK_dbo.SeatsOrders_dbo.Orders_OrderId] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Orders] ([OrderId]) ON DELETE CASCADE
)

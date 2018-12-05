CREATE TABLE [dbo].[BookedSeats]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [OrderID] INT NOT NULL, 
    [SeatRow] INT NOT NULL, 
    [SeatColumn] INT NOT NULL
	CONSTRAINT [FK_dbo.Orders_dbo.BookedSeats_OrderID] FOREIGN KEY ([OrderID]) REFERENCES [dbo].[Orders] ([OrderID]) ON DELETE CASCADE
)

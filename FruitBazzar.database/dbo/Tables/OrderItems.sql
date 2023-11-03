CREATE TABLE [dbo].[OrderItems] (
    [Id]        INT        IDENTITY (1, 1) NOT NULL,
    [OrderId]   INT        NULL,
    [ProductId] INT        NULL,
    [Quantity]  NCHAR (10) NULL,
    [Subtotal]  NCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_OrderItems_ToOrderDetails] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Orders] ([Id]),
    CONSTRAINT [FK_OrderItems_ToProducts] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([Id])
);


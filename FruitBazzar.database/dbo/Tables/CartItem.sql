CREATE TABLE [dbo].[CartItem] (
    [Id]        INT NOT NULL IDENTITY,
    [ProductId] INT          NULL,
    [Quantity]  INT          NULL,
    [Price]     DECIMAL (18) NULL,
    [Date]      DATE         NULL,
    [CustomersId] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CartItem_ToProducts] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([Id]), 
    CONSTRAINT [FK_CartItem_ToCustomers] FOREIGN KEY ([CustomersId]) REFERENCES [Customers]([Id])
);


GO

CREATE INDEX [IX_CartItem_ProductId] ON [dbo].[CartItem] ([ProductId])

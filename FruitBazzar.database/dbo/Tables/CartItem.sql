CREATE TABLE [dbo].[CartItem] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [ProductId] INT          NULL,
    [Quantity]  INT          NULL,
    [Price]     DECIMAL (18) NULL,
    [Date]      DATE         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CartItem_ToProducts] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([Id])
);


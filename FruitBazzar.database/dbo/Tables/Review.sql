CREATE TABLE [dbo].[Review] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [CustomerId] INT            NULL,
    [ProductId]  INT            NULL,
    [Rating]     NVARCHAR (MAX) NULL,
    [Comment]    NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Review_ToCustomers] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([Id]),
    CONSTRAINT [FK_Review_ToProducts] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([Id])
);


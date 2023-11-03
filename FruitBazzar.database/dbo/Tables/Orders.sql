CREATE TABLE [dbo].[Orders] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [CustomerId]  INT            NULL,
    [TotalAmount] DECIMAL (18)   NULL,
    [Status]      NVARCHAR (MAX) NULL,
    [Date]        DATE           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Orders_ToCustomers] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([Id])
);


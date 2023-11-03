CREATE TABLE [dbo].[Payment] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [OrderId]       INT            NULL,
    [Amount]        DECIMAL (18)   NULL,
    [Date]          DATETIME       NULL,
    [PaymentMethod] NVARCHAR (MAX) NULL,
    [Provider]      NVARCHAR (MAX) NULL,
    [Status]        NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Payment_ToOrders] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Orders] ([Id])
);


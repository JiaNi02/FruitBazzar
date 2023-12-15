﻿CREATE TABLE [dbo].[Purchases]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CustomerId] INT NULL, 
    [ProductId] INT NULL, 
    [Quantity] INT NULL, 
    CONSTRAINT [FK_Purchases_ToProducts] FOREIGN KEY ([ProductId]) REFERENCES [Products]([Id]), 
    CONSTRAINT [FK_Purchases_ToCustomers] FOREIGN KEY ([CustomerId]) REFERENCES [Customers]([Id])
)

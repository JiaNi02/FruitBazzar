CREATE TABLE [dbo].[Deliveries]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PurchasesId] INT NULL, 
    [Status] NVARCHAR(MAX) NULL, 
    CONSTRAINT [FK_Deliveries_ToPurchses] FOREIGN KEY ([PurchasesId]) REFERENCES [Purchases]([Id])
)

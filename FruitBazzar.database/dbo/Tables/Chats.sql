CREATE TABLE [dbo].[Chats]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CustomerId] INT NULL, 
    [Time] DATE NULL, 
    [Message] NVARCHAR(MAX) NULL, 
    CONSTRAINT [FK_Chats_ToCustomers] FOREIGN KEY ([CustomerId]) REFERENCES [Customers]([Id])
)

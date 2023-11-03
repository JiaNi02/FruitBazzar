CREATE TABLE [dbo].[Products] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NULL,
    [Description] TEXT           NULL,
    [Price]       DECIMAL (18)   NULL,
    [Image]       NVARCHAR (MAX) NULL,
    [CategortId]  INT            NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Products_ToCategory] FOREIGN KEY ([CategortId]) REFERENCES [dbo].[Category] ([Id])
);


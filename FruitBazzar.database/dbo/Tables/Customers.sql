CREATE TABLE [dbo].[Customers] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NULL,
    [Email]       NVARCHAR (MAX) NULL,
    [PhoneNumber] INT            NULL,
    [Address]     NVARCHAR (MAX) NULL,
    [Password]    NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[List_items]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    CONSTRAINT [FK_List_items] FOREIGN KEY ([Id]) REFERENCES [dbo].[Lists]([Id])
)

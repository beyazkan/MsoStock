CREATE TABLE [dbo].[LocationDebits]
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[LocationId] INT NOT NULL,
    [ProductId] INT NOT NULL, 
    [SerialNumber] VARCHAR(255) NOT NULL, 
    [Barcode] VARCHAR(255) NOT NULL, 
    [RecognizedCode] VARCHAR(255) NOT NULL, 
    [EntryCount] INT NULL, 
    [Count] INT NULL, 
    [Owner] INT NULL, 
    [To] INT NOT NULL, 
    [Description] TEXT NULL, 
    [CreatedDate] DATETIME NOT NULL DEFAULT (getdate()), 
    [UpdatedDate] DATETIME NULL 
)

CREATE TABLE [dbo].[Users]
(
    [Id] INT NOT NULL PRIMARY KEY, 
    [UserID] VARCHAR(50) NOT NULL, 
    [Username] VARCHAR(50) NOT NULL, 
    [Password] VARCHAR(50) NOT NULL, 
    [Last_Logon] DATETIME NULL, 
    [Authorization] VARCHAR(50) NOT NULL DEFAULT 1, 
    [CreatedDate] DATETIME NOT NULL DEFAULT (getdate()), 
    [UpdatedDate] DATETIME NULL
)

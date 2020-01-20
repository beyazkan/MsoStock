CREATE TABLE [dbo].[Users] (
    [Id]            INT          IDENTITY (1, 1) NOT NULL,
    [UserID]        INT          NOT NULL,
    [Username]      VARCHAR (50) NOT NULL,
    [Password]      VARCHAR (50) NOT NULL,
    [Last_Logon]    DATETIME     NULL,
    [Authorization] VARCHAR (50) DEFAULT ((1)) NOT NULL,
    [CreatedDate]   DATETIME     DEFAULT (getdate()) NOT NULL,
    [UpdatedDate]   DATETIME     NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Stores] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [Name]     VARCHAR (50) NOT NULL,
    [PersonId] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


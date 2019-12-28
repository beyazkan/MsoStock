CREATE TABLE [dbo].[Locations] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (50) NOT NULL,
    [CreatedDate] DATETIME     NULL,
    [UpdatedDate] DATETIME     NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[ProductTypes] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (50) NULL,
    [CreatedDate] DATETIME     NULL,
    [UpdatedDate] DATETIME     NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


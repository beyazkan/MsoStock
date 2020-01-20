CREATE TABLE [dbo].[People] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (50)  NOT NULL,
    [LastName]    VARCHAR (50)  NOT NULL,
    [PersonID]    VARCHAR (50)  NULL,
    [Email]       VARCHAR (255) NULL,
    [Telephone]   VARCHAR (50)  NULL,
    [CreatedDate] DATETIME       NOT NULL,
    [UpdatedDate] DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


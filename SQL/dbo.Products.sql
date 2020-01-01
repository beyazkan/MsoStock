CREATE TABLE [dbo].[Products] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (50) NOT NULL,
    [Brand]       VARCHAR (50) NULL,
    [Model]       VARCHAR (50) NULL,
    [Type]        INT          NOT NULL,
    [WorkType]    INT          NOT NULL,
    [Warranty]    INT          NULL,
    [Price]       DECIMAL (18) NULL,
	[Barcode]     VARCHAR (50) NULL,
    [CreatedDate] DATETIME     NULL,
    [UpdatedDate] DATETIME     NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


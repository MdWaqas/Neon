CREATE TABLE [dbo].[Categories] (
    [Id]               INT             IDENTITY (1, 1) NOT NULL,
    [ParentCategoryId] INT             NULL,
    [Name]             NVARCHAR (4000) NULL,
    [CategoryLevel]    NVARCHAR (10)   NULL,
    [CreatedBy]        NVARCHAR (320)  NULL,
    [CreatedDate]      DATETIME2 (4)   CONSTRAINT [DF_Categories_CreatedDate] DEFAULT (getutcdate()) NOT NULL,
    [ModifiedBy]       NVARCHAR (320)  NULL,
    [ModifiedDate]     DATETIME2 (4)   CONSTRAINT [DF_Categories_ModifiedDate] DEFAULT (getutcdate()) NOT NULL,
    [Status]           INT             NOT NULL,
    [RowVersion]       ROWVERSION      NOT NULL,
    CONSTRAINT [PK_dbo.Categories] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Categories_dbo.Categories_ParentCategoryId] FOREIGN KEY ([ParentCategoryId]) REFERENCES [dbo].[Categories] ([Id])
);






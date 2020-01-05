CREATE TABLE [dbo].[Categories] (
    [Id]               INT            IDENTITY (1, 1) NOT NULL,
    [ParentCategoryId] INT            NULL,
    [Name]             NVARCHAR (MAX) NULL,
    [CategoryLevel]    NVARCHAR (10)  NULL,
    [CreatedBy]        NVARCHAR (MAX) NULL,
    [CreatedDate]      DATETIME       NOT NULL,
    [ModifiedBy]       NVARCHAR (MAX) NULL,
    [ModifiedDate]     DATETIME       NULL,
    [Status]           INT            NOT NULL,
    [RowVersion]       ROWVERSION     NOT NULL,
    CONSTRAINT [PK_dbo.Categories] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Categories_dbo.Categories_ParentCategoryId] FOREIGN KEY ([ParentCategoryId]) REFERENCES [dbo].[Categories] ([Id])
);


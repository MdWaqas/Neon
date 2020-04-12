CREATE TABLE [dbo].[ProductForms] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (4000) NOT NULL,
    [Description]  NVARCHAR (4000) NULL,
    [CreatedBy]    NVARCHAR (320)  NULL,
    [CreatedDate]  DATETIME2 (4)   CONSTRAINT [DF_ProductForms_CreatedDate] DEFAULT (getutcdate()) NOT NULL,
    [ModifiedBy]   NVARCHAR (320)  NULL,
    [ModifiedDate] DATETIME2 (4)   CONSTRAINT [DF_ProductForms_ModifiedDate] DEFAULT (getutcdate()) NOT NULL,
    [Status]       INT             NOT NULL,
    [RowVersion]   ROWVERSION      NOT NULL,
    CONSTRAINT [PK_dbo.ProductForms] PRIMARY KEY CLUSTERED ([Id] ASC)
);




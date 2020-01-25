CREATE TABLE [dbo].[StorageConditions] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (4000) NOT NULL,
    [CreatedBy]    NVARCHAR (320)  NULL,
    [CreatedDate]  DATETIME2 (4)   CONSTRAINT [DF_StorageConditions_CreatedDate] DEFAULT (getutcdate()) NOT NULL,
    [ModifiedBy]   NVARCHAR (320)  NULL,
    [ModifiedDate] DATETIME2 (4)   CONSTRAINT [DF_StorageConditions_ModifiedDate] DEFAULT (getutcdate()) NOT NULL,
    [Status]       INT             NOT NULL,
    [RowVersion]   ROWVERSION      NOT NULL,
    CONSTRAINT [PK_dbo.StorageConditions] PRIMARY KEY CLUSTERED ([Id] ASC)
);




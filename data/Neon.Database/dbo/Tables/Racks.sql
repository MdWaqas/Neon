CREATE TABLE [dbo].[Racks] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [Number]       NVARCHAR (20)   NOT NULL,
    [Description]  NVARCHAR (4000) NULL,
    [CreatedBy]    NVARCHAR (4000) NULL,
    [CreatedDate]  DATETIME2 (4)   CONSTRAINT [DF_Racks_CreatedDate] DEFAULT (getutcdate()) NOT NULL,
    [ModifiedBy]   NVARCHAR (320)  NULL,
    [ModifiedDate] DATETIME2 (4)   CONSTRAINT [DF_Racks_ModifiedDate] DEFAULT (getutcdate()) NOT NULL,
    [Status]       INT             NOT NULL,
    [RowVersion]   ROWVERSION      NOT NULL,
    CONSTRAINT [PK_dbo.Racks] PRIMARY KEY CLUSTERED ([Id] ASC)
);




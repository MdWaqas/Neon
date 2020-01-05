CREATE TABLE [dbo].[Racks] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Number]       NVARCHAR (20)  NOT NULL,
    [Description]  NVARCHAR (MAX) NULL,
    [CreatedBy]    NVARCHAR (MAX) NULL,
    [CreatedDate]  DATETIME       NOT NULL,
    [ModifiedBy]   NVARCHAR (MAX) NULL,
    [ModifiedDate] DATETIME       NULL,
    [Status]       INT            NOT NULL,
    [RowVersion]   ROWVERSION     NOT NULL,
    CONSTRAINT [PK_dbo.Racks] PRIMARY KEY CLUSTERED ([Id] ASC)
);


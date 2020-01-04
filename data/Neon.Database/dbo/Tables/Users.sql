CREATE TABLE [dbo].[Users] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (50) NOT NULL,
    [CreatedDate]  DATETIME      NOT NULL,
    [CreatedBy]    NVARCHAR (50) NULL,
    [ModifiedDate] DATETIME      NULL,
    [ModifiedBy]   NVARCHAR (50) NULL,
    [Status]       SMALLINT      NOT NULL,
    [RowVersion]   ROWVERSION    NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC)
);


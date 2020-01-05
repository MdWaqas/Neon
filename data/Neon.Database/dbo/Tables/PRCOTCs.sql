CREATE TABLE [dbo].[PRCOTCs] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (MAX) NOT NULL,
    [CreatedBy]    NVARCHAR (MAX) NULL,
    [CreatedDate]  DATETIME       NOT NULL,
    [ModifiedBy]   NVARCHAR (MAX) NULL,
    [ModifiedDate] DATETIME       NULL,
    [Status]       INT            NOT NULL,
    [RowVersion]   ROWVERSION     NOT NULL,
    CONSTRAINT [PK_dbo.PRCOTCs] PRIMARY KEY CLUSTERED ([Id] ASC)
);


﻿CREATE TABLE [dbo].[Contradictions] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (MAX) NOT NULL,
    [CreatedBy]    NVARCHAR (MAX) NULL,
    [CreatedDate]  DATETIME       NOT NULL,
    [ModifiedBy]   NVARCHAR (MAX) NULL,
    [ModifiedDate] DATETIME       NULL,
    [Status]       INT            NOT NULL,
    [RowVersion]   ROWVERSION     NOT NULL,
    CONSTRAINT [PK_dbo.Contradictions] PRIMARY KEY CLUSTERED ([Id] ASC)
);


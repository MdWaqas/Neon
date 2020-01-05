CREATE TABLE [dbo].[Customers] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (50)   NOT NULL,
    [Phone]        NVARCHAR (12)   NOT NULL,
    [NIC]          NVARCHAR (15)   NULL,
    [Email]        NVARCHAR (MAX)  NULL,
    [Address]      NVARCHAR (MAX)  NULL,
    [LoanLimit]    DECIMAL (18, 2) NOT NULL,
    [Balance]      DECIMAL (18, 2) NOT NULL,
    [CreatedBy]    NVARCHAR (MAX)  NULL,
    [CreatedDate]  DATETIME        NOT NULL,
    [ModifiedBy]   NVARCHAR (MAX)  NULL,
    [ModifiedDate] DATETIME        NULL,
    [Status]       INT             NOT NULL,
    [RowVersion]   ROWVERSION      NOT NULL,
    CONSTRAINT [PK_dbo.Customers] PRIMARY KEY CLUSTERED ([Id] ASC)
);


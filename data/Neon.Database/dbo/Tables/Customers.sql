CREATE TABLE [dbo].[Customers] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (50)   NOT NULL,
    [Phone]        NVARCHAR (12)   NOT NULL,
    [NIC]          NVARCHAR (15)   NULL,
    [Email]        NVARCHAR (320)  NULL,
    [Address]      NVARCHAR (500)  NULL,
    [LoanLimit]    DECIMAL (18, 4) NOT NULL,
    [Balance]      DECIMAL (18, 4) NOT NULL,
    [CreatedBy]    NVARCHAR (320)  NULL,
    [CreatedDate]  DATETIME2 (4)   CONSTRAINT [DF_Customers_CreatedDate] DEFAULT (getutcdate()) NOT NULL,
    [ModifiedBy]   NVARCHAR (320)  NULL,
    [ModifiedDate] DATETIME2 (4)   CONSTRAINT [DF_Customers_ModifiedDate] DEFAULT (getutcdate()) NOT NULL,
    [Status]       INT             NOT NULL,
    [RowVersion]   ROWVERSION      NOT NULL,
    CONSTRAINT [PK_dbo.Customers] PRIMARY KEY CLUSTERED ([Id] ASC)
);




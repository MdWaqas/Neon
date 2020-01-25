CREATE TABLE [dbo].[CustomerPayments] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [CustomerId]   INT             NOT NULL,
    [Amount]       DECIMAL (18, 4) NOT NULL,
    [Remarks]      NVARCHAR (1000) NULL,
    [CreatedBy]    NVARCHAR (320)  NOT NULL,
    [CreatedDate]  DATETIME2 (4)   CONSTRAINT [DF_CustomerPayments_CreatedDate] DEFAULT (getutcdate()) NOT NULL,
    [ModifiedBy]   NVARCHAR (320)  NULL,
    [ModifiedDate] DATETIME2 (4)   CONSTRAINT [DF_CustomerPayments_ModifiedDate] DEFAULT (getutcdate()) NOT NULL,
    [Status]       INT             NOT NULL,
    [RowVersion]   ROWVERSION      NOT NULL,
    CONSTRAINT [PK_dbo.CustomerPayments] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.CustomerPayments_dbo.Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([Id]) ON DELETE CASCADE
);




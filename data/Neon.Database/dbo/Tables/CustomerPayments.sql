CREATE TABLE [dbo].[CustomerPayments] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [CustomerId]   INT             NOT NULL,
    [Amount]       DECIMAL (18, 2) NOT NULL,
    [Remarks]      NVARCHAR (MAX)  NULL,
    [CreatedBy]    NVARCHAR (MAX)  NULL,
    [CreatedDate]  DATETIME        NOT NULL,
    [ModifiedBy]   NVARCHAR (MAX)  NULL,
    [ModifiedDate] DATETIME        NULL,
    [Status]       INT             NOT NULL,
    [RowVersion]   ROWVERSION      NOT NULL,
    CONSTRAINT [PK_dbo.CustomerPayments] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.CustomerPayments_dbo.Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([Id]) ON DELETE CASCADE
);


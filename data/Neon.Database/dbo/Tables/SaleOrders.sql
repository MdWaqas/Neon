CREATE TABLE [dbo].[SaleOrders] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [CustomerId]   INT             NOT NULL,
    [Balance]      DECIMAL (18, 2) NOT NULL,
    [OrderDate]    DATETIME        NOT NULL,
    [SaleType]     INT             NOT NULL,
    [CreatedBy]    NVARCHAR (MAX)  NULL,
    [CreatedDate]  DATETIME        NOT NULL,
    [ModifiedBy]   NVARCHAR (MAX)  NULL,
    [ModifiedDate] DATETIME        NULL,
    [Status]       INT             NOT NULL,
    [RowVersion]   ROWVERSION      NOT NULL,
    [Dicount]      DECIMAL (18, 2) DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_dbo.SaleOrders] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.SaleOrders_dbo.Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([Id]) ON DELETE CASCADE
);


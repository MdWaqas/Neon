CREATE TABLE [dbo].[SaleOrders] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [CustomerId]   INT             NOT NULL,
    [Balance]      DECIMAL (18, 4) NOT NULL,
    [OrderDate]    DATETIME2 (4)   NOT NULL,
    [SaleType]     INT             NOT NULL,
    [CreatedBy]    NVARCHAR (320)  NULL,
    [CreatedDate]  DATETIME2 (4)   CONSTRAINT [DF_SaleOrders_CreatedDate] DEFAULT (getutcdate()) NOT NULL,
    [ModifiedBy]   NVARCHAR (320)  NULL,
    [ModifiedDate] DATETIME        CONSTRAINT [DF_SaleOrders_ModifiedDate] DEFAULT (getutcdate()) NOT NULL,
    [Status]       INT             NOT NULL,
    [RowVersion]   ROWVERSION      NOT NULL,
    [Dicount]      DECIMAL (18, 4) CONSTRAINT [DF__tmp_ms_xx__Dicou__0C85DE4D] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_dbo.SaleOrders] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.SaleOrders_dbo.Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([Id]) ON DELETE CASCADE
);




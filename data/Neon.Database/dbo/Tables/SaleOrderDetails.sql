CREATE TABLE [dbo].[SaleOrderDetails] (
    [Id]            INT             IDENTITY (1, 1) NOT NULL,
    [SaleOrderId]   INT             NOT NULL,
    [ItemId]        INT             NOT NULL,
    [PurchasePrice] FLOAT (53)      NOT NULL,
    [RetailPrice]   FLOAT (53)      NOT NULL,
    [Quantity]      FLOAT (53)      NOT NULL,
    [Balance]       DECIMAL (18, 2) NOT NULL,
    [RowVersion]    VARBINARY (MAX) NULL,
    CONSTRAINT [PK_dbo.SaleOrderDetails] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.SaleOrderDetails_dbo.Items_ItemId] FOREIGN KEY ([ItemId]) REFERENCES [dbo].[Items] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.SaleOrderDetails_dbo.SaleOrders_SaleOrderId] FOREIGN KEY ([SaleOrderId]) REFERENCES [dbo].[SaleOrders] ([Id]) ON DELETE CASCADE
);


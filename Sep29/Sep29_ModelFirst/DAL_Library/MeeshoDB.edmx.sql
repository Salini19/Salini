
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/29/2022 11:28:56
-- Generated from EDMX file: E:\Repos\Sep29\DAL_Library\MeeshoDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MeeshoShoppingApp];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [Custid] int IDENTITY(1,1) NOT NULL,
    [CustName] nvarchar(max)  NOT NULL,
    [Birthdate] datetime  NOT NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [ProdID] int IDENTITY(1,1) NOT NULL,
    [ProdName] nvarchar(max)  NOT NULL,
    [Fabric] nvarchar(max)  NOT NULL,
    [Price] int  NOT NULL,
    [CustomerCustid] int  NOT NULL
);
GO

-- Creating table 'OrderDetails'
CREATE TABLE [dbo].[OrderDetails] (
    [OrderId] int IDENTITY(1,1) NOT NULL,
    [OrderDate] datetime  NOT NULL
);
GO

-- Creating table 'CustomerOrderDetails'
CREATE TABLE [dbo].[CustomerOrderDetails] (
    [Customers_Custid] int  NOT NULL,
    [OrderDetails_OrderId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Custid] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([Custid] ASC);
GO

-- Creating primary key on [ProdID] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([ProdID] ASC);
GO

-- Creating primary key on [OrderId] in table 'OrderDetails'
ALTER TABLE [dbo].[OrderDetails]
ADD CONSTRAINT [PK_OrderDetails]
    PRIMARY KEY CLUSTERED ([OrderId] ASC);
GO

-- Creating primary key on [Customers_Custid], [OrderDetails_OrderId] in table 'CustomerOrderDetails'
ALTER TABLE [dbo].[CustomerOrderDetails]
ADD CONSTRAINT [PK_CustomerOrderDetails]
    PRIMARY KEY CLUSTERED ([Customers_Custid], [OrderDetails_OrderId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CustomerCustid] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_CustomerProduct]
    FOREIGN KEY ([CustomerCustid])
    REFERENCES [dbo].[Customers]
        ([Custid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerProduct'
CREATE INDEX [IX_FK_CustomerProduct]
ON [dbo].[Products]
    ([CustomerCustid]);
GO

-- Creating foreign key on [Customers_Custid] in table 'CustomerOrderDetails'
ALTER TABLE [dbo].[CustomerOrderDetails]
ADD CONSTRAINT [FK_CustomerOrderDetails_Customer]
    FOREIGN KEY ([Customers_Custid])
    REFERENCES [dbo].[Customers]
        ([Custid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [OrderDetails_OrderId] in table 'CustomerOrderDetails'
ALTER TABLE [dbo].[CustomerOrderDetails]
ADD CONSTRAINT [FK_CustomerOrderDetails_OrderDetails]
    FOREIGN KEY ([OrderDetails_OrderId])
    REFERENCES [dbo].[OrderDetails]
        ([OrderId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerOrderDetails_OrderDetails'
CREATE INDEX [IX_FK_CustomerOrderDetails_OrderDetails]
ON [dbo].[CustomerOrderDetails]
    ([OrderDetails_OrderId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
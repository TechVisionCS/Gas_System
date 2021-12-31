IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        [FullName] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [ProductTypes] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [CategoryName] nvarchar(max) NOT NULL,
        [TypeName] nvarchar(max) NOT NULL,
        [Description] nvarchar(max) NULL,
        [Status] int NOT NULL,
        CONSTRAINT [PK_ProductTypes] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [wms_bank_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [BankName] nvarchar(max) NOT NULL,
        [AccountName] nvarchar(max) NOT NULL,
        [AccountNo] nvarchar(max) NOT NULL,
        [Branch] nvarchar(max) NULL,
        [Signature] nvarchar(max) NULL,
        CONSTRAINT [PK_wms_bank_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [wms_cash_ledger_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [EntityId] bigint NOT NULL,
        [Date] datetime2 NOT NULL,
        [Description] nvarchar(max) NULL,
        [VoucherNo] nvarchar(max) NULL,
        [MyProperty] int NOT NULL,
        [Debit] decimal(38, 2) NOT NULL,
        [Credit] decimal(38, 2) NOT NULL,
        [Balance] decimal(38, 2) NOT NULL,
        [TransCode] nvarchar(max) NULL,
        [TransType] int NOT NULL,
        [isClosed] bit NOT NULL,
        CONSTRAINT [PK_wms_cash_ledger_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [wms_category_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [Name] nvarchar(max) NOT NULL,
        [Description] nvarchar(max) NULL,
        [Status] int NOT NULL,
        CONSTRAINT [PK_wms_category_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [wms_country_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [Name] nvarchar(max) NULL,
        [Code] nvarchar(max) NULL,
        CONSTRAINT [PK_wms_country_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [wms_product_batch_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [BatchId] nvarchar(450) NULL,
        [Code] nvarchar(450) NULL,
        [ProductId] bigint NOT NULL,
        [SupplierId] bigint NOT NULL,
        [PurchasePrice] decimal(38, 2) NOT NULL,
        [SalePrice] decimal(38, 2) NOT NULL,
        [PurchaseDate] datetime2 NULL,
        CONSTRAINT [PK_wms_product_batch_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [wms_product_supplier_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [ProductId] bigint NOT NULL,
        [SupplierId] bigint NOT NULL,
        CONSTRAINT [PK_wms_product_supplier_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [wms_stock_details_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [ProductId] bigint NOT NULL,
        [SupplierId] bigint NOT NULL,
        [InQty] real NOT NULL,
        [OutQty] real NOT NULL,
        [PurchasePrice] decimal(38, 2) NOT NULL,
        [SalePrice] decimal(38, 2) NOT NULL,
        [TransCode] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        CONSTRAINT [PK_wms_stock_details_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [wms_stock_purchase_log_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [ProductId] bigint NOT NULL,
        [SupplierId] bigint NOT NULL,
        [BatchId] nvarchar(max) NULL,
        [InQty] real NOT NULL,
        [OutQty] real NOT NULL,
        [StockQty] real NOT NULL,
        [PurchaseDate] datetime2 NULL,
        CONSTRAINT [PK_wms_stock_purchase_log_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [wms_stock_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [ProductId] bigint NOT NULL,
        [InQty] real NOT NULL,
        [OutQty] real NOT NULL,
        [StockQty] real NOT NULL,
        [TotalStockSalePrice] decimal(38, 2) NOT NULL,
        [TotalStockPurchasePrice] decimal(38, 2) NOT NULL,
        CONSTRAINT [PK_wms_stock_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [wms_tax_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [Name] nvarchar(max) NOT NULL,
        [Amount] decimal(38, 2) NOT NULL,
        [Status] int NOT NULL,
        CONSTRAINT [PK_wms_tax_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [wms_transaction_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [TransCode] nvarchar(max) NULL,
        [TransDate] datetime2 NOT NULL,
        [Description] nvarchar(max) NULL,
        [TransType] int NOT NULL,
        [Amount] decimal(38, 2) NOT NULL,
        [Operation] int NOT NULL,
        [isClosed] bit NOT NULL,
        CONSTRAINT [PK_wms_transaction_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [wms_unit_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [Name] nvarchar(max) NOT NULL,
        [Description] nvarchar(max) NULL,
        [Status] int NOT NULL,
        CONSTRAINT [PK_wms_unit_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(450) NOT NULL,
        [ProviderKey] nvarchar(450) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(450) NOT NULL,
        [Name] nvarchar(450) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [wms_bank_transaction_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [Date] datetime2 NOT NULL,
        [BankId] bigint NOT NULL,
        [TransType] int NOT NULL,
        [TransID] nvarchar(max) NOT NULL,
        [Amount] decimal(38, 2) NOT NULL,
        [Description] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_wms_bank_transaction_tbl] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_wms_bank_transaction_tbl_wms_bank_tbl_BankId] FOREIGN KEY ([BankId]) REFERENCES [wms_bank_tbl] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [wms_province_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [Name] nvarchar(max) NULL,
        [CountryId] bigint NOT NULL,
        [CountryName] nvarchar(max) NULL,
        [CountryCode] nvarchar(max) NULL,
        CONSTRAINT [PK_wms_province_tbl] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_wms_province_tbl_wms_country_tbl_CountryId] FOREIGN KEY ([CountryId]) REFERENCES [wms_country_tbl] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [wms_product_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [Name] nvarchar(max) NOT NULL,
        [Category] bigint NOT NULL,
        [Type] bigint NOT NULL,
        [Model] bigint NOT NULL,
        [Unit] bigint NOT NULL,
        [Image] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [CategoryId] bigint NULL,
        [ProductTypeId] bigint NULL,
        [UnitId] bigint NULL,
        CONSTRAINT [PK_wms_product_tbl] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_wms_product_tbl_wms_category_tbl_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [wms_category_tbl] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_wms_product_tbl_ProductTypes_ProductTypeId] FOREIGN KEY ([ProductTypeId]) REFERENCES [ProductTypes] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_wms_product_tbl_wms_unit_tbl_UnitId] FOREIGN KEY ([UnitId]) REFERENCES [wms_unit_tbl] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [wms_bank_ledger_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [EntityId] bigint NOT NULL,
        [Date] datetime2 NOT NULL,
        [Description] nvarchar(max) NULL,
        [VoucherNo] nvarchar(max) NULL,
        [MyProperty] int NOT NULL,
        [Debit] decimal(38, 2) NOT NULL,
        [Credit] decimal(38, 2) NOT NULL,
        [Balance] decimal(38, 2) NOT NULL,
        [TransCode] nvarchar(max) NULL,
        [TransType] int NOT NULL,
        [isClosed] bit NOT NULL,
        CONSTRAINT [PK_wms_bank_ledger_tbl] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_wms_bank_ledger_tbl_wms_bank_transaction_tbl_EntityId] FOREIGN KEY ([EntityId]) REFERENCES [wms_bank_transaction_tbl] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [wms_customer_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [Name] nvarchar(max) NOT NULL,
        [Phone] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [countrysid] bigint NOT NULL,
        [Provincesid] bigint NOT NULL,
        [Address] nvarchar(max) NULL,
        [Details] nvarchar(max) NULL,
        [PreviousBalance] decimal(38, 2) NOT NULL,
        CONSTRAINT [PK_wms_customer_tbl] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_wms_customer_tbl_wms_province_tbl_Provincesid] FOREIGN KEY ([Provincesid]) REFERENCES [wms_province_tbl] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_wms_customer_tbl_wms_country_tbl_countrysid] FOREIGN KEY ([countrysid]) REFERENCES [wms_country_tbl] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [wms_partner_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [Name] nvarchar(max) NOT NULL,
        [Phone] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [PreviousBalance] decimal(38, 2) NOT NULL,
        [Province_id] bigint NOT NULL,
        [Country_id] bigint NOT NULL,
        [Address] nvarchar(max) NULL,
        [RegDate] nvarchar(max) NULL,
        [Provinceid] bigint NULL,
        CONSTRAINT [PK_wms_partner_tbl] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_wms_partner_tbl_wms_country_tbl_Country_id] FOREIGN KEY ([Country_id]) REFERENCES [wms_country_tbl] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_wms_partner_tbl_wms_province_tbl_Provinceid] FOREIGN KEY ([Provinceid]) REFERENCES [wms_province_tbl] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [wms_supplier_ledger_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [Name] nvarchar(20) NOT NULL,
        [Phone] nvarchar(15) NULL,
        [Email] nvarchar(max) NULL,
        [Countryid] bigint NOT NULL,
        [Provinceid] bigint NOT NULL,
        [Address] nvarchar(max) NULL,
        [Details] nvarchar(max) NULL,
        [PreviousBalance] decimal(38, 2) NOT NULL,
        CONSTRAINT [PK_wms_supplier_ledger_tbl] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_wms_supplier_ledger_tbl_wms_country_tbl_Countryid] FOREIGN KEY ([Countryid]) REFERENCES [wms_country_tbl] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_wms_supplier_ledger_tbl_wms_province_tbl_Provinceid] FOREIGN KEY ([Provinceid]) REFERENCES [wms_province_tbl] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [ProductTaxes] (
        [ProductId] bigint NOT NULL,
        [TaxId] bigint NOT NULL,
        CONSTRAINT [PK_ProductTaxes] PRIMARY KEY ([ProductId], [TaxId]),
        CONSTRAINT [FK_ProductTaxes_wms_product_tbl_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [wms_product_tbl] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_ProductTaxes_wms_tax_tbl_TaxId] FOREIGN KEY ([TaxId]) REFERENCES [wms_tax_tbl] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [wms_customer_ledger_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [EntityId] bigint NOT NULL,
        [Date] datetime2 NOT NULL,
        [Description] nvarchar(max) NULL,
        [VoucherNo] nvarchar(max) NULL,
        [Debit] decimal(38, 2) NOT NULL,
        [Credit] decimal(38, 2) NOT NULL,
        [Balance] decimal(38, 2) NOT NULL,
        [TransCode] nvarchar(max) NULL,
        [isClosed] bit NOT NULL,
        CONSTRAINT [PK_wms_customer_ledger_tbl] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_wms_customer_ledger_tbl_wms_customer_tbl_EntityId] FOREIGN KEY ([EntityId]) REFERENCES [wms_customer_tbl] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [wms_partner_ledger_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [EntityId] bigint NOT NULL,
        [Date] datetime2 NOT NULL,
        [Description] nvarchar(max) NULL,
        [VoucherNo] nvarchar(max) NULL,
        [MyProperty] int NOT NULL,
        [Debit] decimal(38, 2) NOT NULL,
        [Credit] decimal(38, 2) NOT NULL,
        [Balance] decimal(38, 2) NOT NULL,
        [TransCode] nvarchar(max) NULL,
        [isClosed] bit NOT NULL,
        [partnerId] bigint NULL,
        CONSTRAINT [PK_wms_partner_ledger_tbl] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_wms_partner_ledger_tbl_wms_partner_tbl_partnerId] FOREIGN KEY ([partnerId]) REFERENCES [wms_partner_tbl] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE TABLE [SupplierLedgers] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [EntityId] bigint NOT NULL,
        [Date] datetime2 NOT NULL,
        [Description] nvarchar(max) NULL,
        [VoucherNo] nvarchar(max) NULL,
        [MyProperty] int NOT NULL,
        [Debit] decimal(38, 2) NOT NULL,
        [Credit] decimal(38, 2) NOT NULL,
        [Balance] decimal(38, 2) NOT NULL,
        [TransCode] nvarchar(max) NULL,
        [isClosed] bit NOT NULL,
        CONSTRAINT [PK_SupplierLedgers] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_SupplierLedgers_wms_supplier_ledger_tbl_EntityId] FOREIGN KEY ([EntityId]) REFERENCES [wms_supplier_ledger_tbl] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE INDEX [IX_ProductTaxes_TaxId] ON [ProductTaxes] ([TaxId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE INDEX [IX_SupplierLedgers_EntityId] ON [SupplierLedgers] ([EntityId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE INDEX [IX_wms_bank_ledger_tbl_EntityId] ON [wms_bank_ledger_tbl] ([EntityId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE INDEX [IX_wms_bank_transaction_tbl_BankId] ON [wms_bank_transaction_tbl] ([BankId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE INDEX [IX_wms_customer_ledger_tbl_EntityId] ON [wms_customer_ledger_tbl] ([EntityId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE INDEX [IX_wms_customer_tbl_Provincesid] ON [wms_customer_tbl] ([Provincesid]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE INDEX [IX_wms_customer_tbl_countrysid] ON [wms_customer_tbl] ([countrysid]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE INDEX [IX_wms_partner_ledger_tbl_partnerId] ON [wms_partner_ledger_tbl] ([partnerId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE INDEX [IX_wms_partner_tbl_Country_id] ON [wms_partner_tbl] ([Country_id]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE INDEX [IX_wms_partner_tbl_Provinceid] ON [wms_partner_tbl] ([Provinceid]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE UNIQUE INDEX [IX_wms_product_batch_tbl_BatchId] ON [wms_product_batch_tbl] ([BatchId]) WHERE [BatchId] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE UNIQUE INDEX [IX_wms_product_batch_tbl_Code] ON [wms_product_batch_tbl] ([Code]) WHERE [Code] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE INDEX [IX_wms_product_tbl_CategoryId] ON [wms_product_tbl] ([CategoryId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE INDEX [IX_wms_product_tbl_ProductTypeId] ON [wms_product_tbl] ([ProductTypeId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE INDEX [IX_wms_product_tbl_UnitId] ON [wms_product_tbl] ([UnitId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE INDEX [IX_wms_province_tbl_CountryId] ON [wms_province_tbl] ([CountryId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE INDEX [IX_wms_supplier_ledger_tbl_Countryid] ON [wms_supplier_ledger_tbl] ([Countryid]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    CREATE INDEX [IX_wms_supplier_ledger_tbl_Provinceid] ON [wms_supplier_ledger_tbl] ([Provinceid]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214180025_initialMigration')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210214180025_initialMigration', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210218164148_ModelsUpdated')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_product_tbl]') AND [c].[name] = N'Category');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [wms_product_tbl] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [wms_product_tbl] DROP COLUMN [Category];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210218164148_ModelsUpdated')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_product_tbl]') AND [c].[name] = N'Type');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [wms_product_tbl] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [wms_product_tbl] DROP COLUMN [Type];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210218164148_ModelsUpdated')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_product_tbl]') AND [c].[name] = N'Unit');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [wms_product_tbl] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [wms_product_tbl] DROP COLUMN [Unit];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210218164148_ModelsUpdated')
BEGIN
    DROP INDEX [IX_wms_product_tbl_UnitId] ON [wms_product_tbl];
    DECLARE @var3 sysname;
    SELECT @var3 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_product_tbl]') AND [c].[name] = N'UnitId');
    IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [wms_product_tbl] DROP CONSTRAINT [' + @var3 + '];');
    ALTER TABLE [wms_product_tbl] ALTER COLUMN [UnitId] bigint NOT NULL;
    CREATE INDEX [IX_wms_product_tbl_UnitId] ON [wms_product_tbl] ([UnitId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210218164148_ModelsUpdated')
BEGIN
    DECLARE @var4 sysname;
    SELECT @var4 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_product_tbl]') AND [c].[name] = N'Model');
    IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [wms_product_tbl] DROP CONSTRAINT [' + @var4 + '];');
    ALTER TABLE [wms_product_tbl] ALTER COLUMN [Model] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210218164148_ModelsUpdated')
BEGIN
    DROP INDEX [IX_wms_product_tbl_CategoryId] ON [wms_product_tbl];
    DECLARE @var5 sysname;
    SELECT @var5 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_product_tbl]') AND [c].[name] = N'CategoryId');
    IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [wms_product_tbl] DROP CONSTRAINT [' + @var5 + '];');
    ALTER TABLE [wms_product_tbl] ALTER COLUMN [CategoryId] bigint NOT NULL;
    CREATE INDEX [IX_wms_product_tbl_CategoryId] ON [wms_product_tbl] ([CategoryId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210218164148_ModelsUpdated')
BEGIN
    ALTER TABLE [wms_product_tbl] ADD [TypeId] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210218164148_ModelsUpdated')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210218164148_ModelsUpdated', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210220190404_SupplierIdAddedToProductModel')
BEGIN
    ALTER TABLE [wms_product_tbl] ADD [SupplierId] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210220190404_SupplierIdAddedToProductModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210220190404_SupplierIdAddedToProductModel', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225195648_stockbatchesupdated')
BEGIN
    DROP INDEX [IX_wms_product_batch_tbl_Code] ON [wms_product_batch_tbl];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225195648_stockbatchesupdated')
BEGIN
    DECLARE @var6 sysname;
    SELECT @var6 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_product_batch_tbl]') AND [c].[name] = N'Code');
    IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [wms_product_batch_tbl] DROP CONSTRAINT [' + @var6 + '];');
    ALTER TABLE [wms_product_batch_tbl] DROP COLUMN [Code];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225195648_stockbatchesupdated')
BEGIN
    DECLARE @var7 sysname;
    SELECT @var7 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_product_batch_tbl]') AND [c].[name] = N'SupplierId');
    IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [wms_product_batch_tbl] DROP CONSTRAINT [' + @var7 + '];');
    ALTER TABLE [wms_product_batch_tbl] DROP COLUMN [SupplierId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225195648_stockbatchesupdated')
BEGIN
    ALTER TABLE [wms_product_batch_tbl] ADD [BarCode] nvarchar(450) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225195648_stockbatchesupdated')
BEGIN
    ALTER TABLE [wms_product_batch_tbl] ADD [StockQty] decimal(38, 2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225195648_stockbatchesupdated')
BEGIN
    CREATE UNIQUE INDEX [IX_wms_product_batch_tbl_BarCode] ON [wms_product_batch_tbl] ([BarCode]) WHERE [BarCode] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210225195648_stockbatchesupdated')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210225195648_stockbatchesupdated', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210305194929_ManufacturerModelAdded')
BEGIN
    DECLARE @var8 sysname;
    SELECT @var8 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_cash_ledger_tbl]') AND [c].[name] = N'MyProperty');
    IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [wms_cash_ledger_tbl] DROP CONSTRAINT [' + @var8 + '];');
    ALTER TABLE [wms_cash_ledger_tbl] DROP COLUMN [MyProperty];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210305194929_ManufacturerModelAdded')
BEGIN
    DECLARE @var9 sysname;
    SELECT @var9 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SupplierLedgers]') AND [c].[name] = N'MyProperty');
    IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [SupplierLedgers] DROP CONSTRAINT [' + @var9 + '];');
    ALTER TABLE [SupplierLedgers] DROP COLUMN [MyProperty];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210305194929_ManufacturerModelAdded')
BEGIN
    DECLARE @var10 sysname;
    SELECT @var10 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_supplier_ledger_tbl]') AND [c].[name] = N'Phone');
    IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [wms_supplier_ledger_tbl] DROP CONSTRAINT [' + @var10 + '];');
    ALTER TABLE [wms_supplier_ledger_tbl] ALTER COLUMN [Phone] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210305194929_ManufacturerModelAdded')
BEGIN
    DECLARE @var11 sysname;
    SELECT @var11 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_supplier_ledger_tbl]') AND [c].[name] = N'Name');
    IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [wms_supplier_ledger_tbl] DROP CONSTRAINT [' + @var11 + '];');
    ALTER TABLE [wms_supplier_ledger_tbl] ALTER COLUMN [Name] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210305194929_ManufacturerModelAdded')
BEGIN
    ALTER TABLE [wms_product_tbl] ADD [ManufacturerId] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210305194929_ManufacturerModelAdded')
BEGIN
    ALTER TABLE [wms_cash_ledger_tbl] ADD [EntityType] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210305194929_ManufacturerModelAdded')
BEGIN
    CREATE TABLE [wms_manufacturer_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [Name] nvarchar(max) NOT NULL,
        [CountryName] nvarchar(max) NOT NULL,
        [Description] nvarchar(max) NULL,
        [Status] int NOT NULL,
        CONSTRAINT [PK_wms_manufacturer_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210305194929_ManufacturerModelAdded')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210305194929_ManufacturerModelAdded', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306191217_SupplierModelRenamed')
BEGIN
    ALTER TABLE [wms_supplier_ledger_tbl] DROP CONSTRAINT [FK_wms_supplier_ledger_tbl_wms_country_tbl_Countryid];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306191217_SupplierModelRenamed')
BEGIN
    ALTER TABLE [wms_supplier_ledger_tbl] DROP CONSTRAINT [FK_wms_supplier_ledger_tbl_wms_province_tbl_Provinceid];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306191217_SupplierModelRenamed')
BEGIN
    DROP TABLE [SupplierLedgers];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306191217_SupplierModelRenamed')
BEGIN
    DROP INDEX [IX_wms_supplier_ledger_tbl_Countryid] ON [wms_supplier_ledger_tbl];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306191217_SupplierModelRenamed')
BEGIN
    DROP INDEX [IX_wms_supplier_ledger_tbl_Provinceid] ON [wms_supplier_ledger_tbl];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306191217_SupplierModelRenamed')
BEGIN
    DECLARE @var12 sysname;
    SELECT @var12 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_supplier_ledger_tbl]') AND [c].[name] = N'Address');
    IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [wms_supplier_ledger_tbl] DROP CONSTRAINT [' + @var12 + '];');
    ALTER TABLE [wms_supplier_ledger_tbl] DROP COLUMN [Address];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306191217_SupplierModelRenamed')
BEGIN
    DECLARE @var13 sysname;
    SELECT @var13 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_supplier_ledger_tbl]') AND [c].[name] = N'Countryid');
    IF @var13 IS NOT NULL EXEC(N'ALTER TABLE [wms_supplier_ledger_tbl] DROP CONSTRAINT [' + @var13 + '];');
    ALTER TABLE [wms_supplier_ledger_tbl] DROP COLUMN [Countryid];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306191217_SupplierModelRenamed')
BEGIN
    DECLARE @var14 sysname;
    SELECT @var14 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_supplier_ledger_tbl]') AND [c].[name] = N'Details');
    IF @var14 IS NOT NULL EXEC(N'ALTER TABLE [wms_supplier_ledger_tbl] DROP CONSTRAINT [' + @var14 + '];');
    ALTER TABLE [wms_supplier_ledger_tbl] DROP COLUMN [Details];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306191217_SupplierModelRenamed')
BEGIN
    DECLARE @var15 sysname;
    SELECT @var15 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_supplier_ledger_tbl]') AND [c].[name] = N'Email');
    IF @var15 IS NOT NULL EXEC(N'ALTER TABLE [wms_supplier_ledger_tbl] DROP CONSTRAINT [' + @var15 + '];');
    ALTER TABLE [wms_supplier_ledger_tbl] DROP COLUMN [Email];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306191217_SupplierModelRenamed')
BEGIN
    DECLARE @var16 sysname;
    SELECT @var16 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_supplier_ledger_tbl]') AND [c].[name] = N'Name');
    IF @var16 IS NOT NULL EXEC(N'ALTER TABLE [wms_supplier_ledger_tbl] DROP CONSTRAINT [' + @var16 + '];');
    ALTER TABLE [wms_supplier_ledger_tbl] DROP COLUMN [Name];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306191217_SupplierModelRenamed')
BEGIN
    DECLARE @var17 sysname;
    SELECT @var17 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_supplier_ledger_tbl]') AND [c].[name] = N'Phone');
    IF @var17 IS NOT NULL EXEC(N'ALTER TABLE [wms_supplier_ledger_tbl] DROP CONSTRAINT [' + @var17 + '];');
    ALTER TABLE [wms_supplier_ledger_tbl] DROP COLUMN [Phone];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306191217_SupplierModelRenamed')
BEGIN
    DECLARE @var18 sysname;
    SELECT @var18 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_supplier_ledger_tbl]') AND [c].[name] = N'Provinceid');
    IF @var18 IS NOT NULL EXEC(N'ALTER TABLE [wms_supplier_ledger_tbl] DROP CONSTRAINT [' + @var18 + '];');
    ALTER TABLE [wms_supplier_ledger_tbl] DROP COLUMN [Provinceid];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306191217_SupplierModelRenamed')
BEGIN
    EXEC sp_rename N'[wms_supplier_ledger_tbl].[PreviousBalance]', N'Debit', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306191217_SupplierModelRenamed')
BEGIN
    ALTER TABLE [wms_supplier_ledger_tbl] ADD [Balance] decimal(38, 2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306191217_SupplierModelRenamed')
BEGIN
    ALTER TABLE [wms_supplier_ledger_tbl] ADD [Credit] decimal(38, 2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306191217_SupplierModelRenamed')
BEGIN
    ALTER TABLE [wms_supplier_ledger_tbl] ADD [Date] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306191217_SupplierModelRenamed')
BEGIN
    ALTER TABLE [wms_supplier_ledger_tbl] ADD [Description] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306191217_SupplierModelRenamed')
BEGIN
    ALTER TABLE [wms_supplier_ledger_tbl] ADD [EntityId] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306191217_SupplierModelRenamed')
BEGIN
    ALTER TABLE [wms_supplier_ledger_tbl] ADD [TransCode] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306191217_SupplierModelRenamed')
BEGIN
    ALTER TABLE [wms_supplier_ledger_tbl] ADD [VoucherNo] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306191217_SupplierModelRenamed')
BEGIN
    ALTER TABLE [wms_supplier_ledger_tbl] ADD [isClosed] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306191217_SupplierModelRenamed')
BEGIN
    CREATE TABLE [wms_supplier_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [Name] nvarchar(max) NOT NULL,
        [Phone] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [Countryid] bigint NOT NULL,
        [Provinceid] bigint NOT NULL,
        [Address] nvarchar(max) NULL,
        [Details] nvarchar(max) NULL,
        [PreviousBalance] decimal(38, 2) NOT NULL,
        CONSTRAINT [PK_wms_supplier_tbl] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_wms_supplier_tbl_wms_country_tbl_Countryid] FOREIGN KEY ([Countryid]) REFERENCES [wms_country_tbl] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_wms_supplier_tbl_wms_province_tbl_Provinceid] FOREIGN KEY ([Provinceid]) REFERENCES [wms_province_tbl] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306191217_SupplierModelRenamed')
BEGIN
    CREATE INDEX [IX_wms_supplier_tbl_Countryid] ON [wms_supplier_tbl] ([Countryid]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306191217_SupplierModelRenamed')
BEGIN
    CREATE INDEX [IX_wms_supplier_tbl_Provinceid] ON [wms_supplier_tbl] ([Provinceid]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210306191217_SupplierModelRenamed')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210306191217_SupplierModelRenamed', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210307093638_CustomerFiledAlterd')
BEGIN
    ALTER TABLE [wms_customer_tbl] DROP CONSTRAINT [FK_wms_customer_tbl_wms_province_tbl_Provincesid];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210307093638_CustomerFiledAlterd')
BEGIN
    ALTER TABLE [wms_customer_tbl] DROP CONSTRAINT [FK_wms_customer_tbl_wms_country_tbl_countrysid];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210307093638_CustomerFiledAlterd')
BEGIN
    DROP INDEX [IX_wms_customer_tbl_Provincesid] ON [wms_customer_tbl];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210307093638_CustomerFiledAlterd')
BEGIN
    DROP INDEX [IX_wms_customer_tbl_countrysid] ON [wms_customer_tbl];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210307093638_CustomerFiledAlterd')
BEGIN
    DECLARE @var19 sysname;
    SELECT @var19 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_customer_tbl]') AND [c].[name] = N'Provincesid');
    IF @var19 IS NOT NULL EXEC(N'ALTER TABLE [wms_customer_tbl] DROP CONSTRAINT [' + @var19 + '];');
    ALTER TABLE [wms_customer_tbl] DROP COLUMN [Provincesid];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210307093638_CustomerFiledAlterd')
BEGIN
    DECLARE @var20 sysname;
    SELECT @var20 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_customer_tbl]') AND [c].[name] = N'countrysid');
    IF @var20 IS NOT NULL EXEC(N'ALTER TABLE [wms_customer_tbl] DROP CONSTRAINT [' + @var20 + '];');
    ALTER TABLE [wms_customer_tbl] DROP COLUMN [countrysid];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210307093638_CustomerFiledAlterd')
BEGIN
    ALTER TABLE [wms_customer_tbl] ADD [Countryid] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210307093638_CustomerFiledAlterd')
BEGIN
    ALTER TABLE [wms_customer_tbl] ADD [Provinceid] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210307093638_CustomerFiledAlterd')
BEGIN
    CREATE INDEX [IX_wms_customer_tbl_Countryid] ON [wms_customer_tbl] ([Countryid]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210307093638_CustomerFiledAlterd')
BEGIN
    CREATE INDEX [IX_wms_customer_tbl_Provinceid] ON [wms_customer_tbl] ([Provinceid]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210307093638_CustomerFiledAlterd')
BEGIN
    ALTER TABLE [wms_customer_tbl] ADD CONSTRAINT [FK_wms_customer_tbl_wms_country_tbl_Countryid] FOREIGN KEY ([Countryid]) REFERENCES [wms_country_tbl] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210307093638_CustomerFiledAlterd')
BEGIN
    ALTER TABLE [wms_customer_tbl] ADD CONSTRAINT [FK_wms_customer_tbl_wms_province_tbl_Provinceid] FOREIGN KEY ([Provinceid]) REFERENCES [wms_province_tbl] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210307093638_CustomerFiledAlterd')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210307093638_CustomerFiledAlterd', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210307174631_PartnerFiledAlterd')
BEGIN
    ALTER TABLE [wms_partner_tbl] DROP CONSTRAINT [FK_wms_partner_tbl_wms_country_tbl_Country_id];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210307174631_PartnerFiledAlterd')
BEGIN
    ALTER TABLE [wms_partner_tbl] DROP CONSTRAINT [FK_wms_partner_tbl_wms_province_tbl_Provinceid];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210307174631_PartnerFiledAlterd')
BEGIN
    DROP INDEX [IX_wms_partner_tbl_Country_id] ON [wms_partner_tbl];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210307174631_PartnerFiledAlterd')
BEGIN
    DROP INDEX [IX_wms_partner_tbl_Provinceid] ON [wms_partner_tbl];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210307174631_PartnerFiledAlterd')
BEGIN
    DECLARE @var21 sysname;
    SELECT @var21 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_partner_tbl]') AND [c].[name] = N'Country_id');
    IF @var21 IS NOT NULL EXEC(N'ALTER TABLE [wms_partner_tbl] DROP CONSTRAINT [' + @var21 + '];');
    ALTER TABLE [wms_partner_tbl] DROP COLUMN [Country_id];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210307174631_PartnerFiledAlterd')
BEGIN
    DECLARE @var22 sysname;
    SELECT @var22 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_partner_tbl]') AND [c].[name] = N'Description');
    IF @var22 IS NOT NULL EXEC(N'ALTER TABLE [wms_partner_tbl] DROP CONSTRAINT [' + @var22 + '];');
    ALTER TABLE [wms_partner_tbl] DROP COLUMN [Description];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210307174631_PartnerFiledAlterd')
BEGIN
    DECLARE @var23 sysname;
    SELECT @var23 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_partner_tbl]') AND [c].[name] = N'Province_id');
    IF @var23 IS NOT NULL EXEC(N'ALTER TABLE [wms_partner_tbl] DROP CONSTRAINT [' + @var23 + '];');
    ALTER TABLE [wms_partner_tbl] DROP COLUMN [Province_id];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210307174631_PartnerFiledAlterd')
BEGIN
    DECLARE @var24 sysname;
    SELECT @var24 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_partner_tbl]') AND [c].[name] = N'RegDate');
    IF @var24 IS NOT NULL EXEC(N'ALTER TABLE [wms_partner_tbl] DROP CONSTRAINT [' + @var24 + '];');
    ALTER TABLE [wms_partner_tbl] DROP COLUMN [RegDate];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210307174631_PartnerFiledAlterd')
BEGIN
    DECLARE @var25 sysname;
    SELECT @var25 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_partner_tbl]') AND [c].[name] = N'Provinceid');
    IF @var25 IS NOT NULL EXEC(N'ALTER TABLE [wms_partner_tbl] DROP CONSTRAINT [' + @var25 + '];');
    ALTER TABLE [wms_partner_tbl] ALTER COLUMN [Provinceid] bigint NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210307174631_PartnerFiledAlterd')
BEGIN
    ALTER TABLE [wms_partner_tbl] ADD [Countryid] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210307174631_PartnerFiledAlterd')
BEGIN
    ALTER TABLE [wms_partner_tbl] ADD [Details] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210307174631_PartnerFiledAlterd')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210307174631_PartnerFiledAlterd', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210309110608_CustomerForeignKeysRemoved')
BEGIN
    ALTER TABLE [wms_customer_tbl] DROP CONSTRAINT [FK_wms_customer_tbl_wms_country_tbl_Countryid];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210309110608_CustomerForeignKeysRemoved')
BEGIN
    ALTER TABLE [wms_customer_tbl] DROP CONSTRAINT [FK_wms_customer_tbl_wms_province_tbl_Provinceid];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210309110608_CustomerForeignKeysRemoved')
BEGIN
    DROP INDEX [IX_wms_customer_tbl_Countryid] ON [wms_customer_tbl];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210309110608_CustomerForeignKeysRemoved')
BEGIN
    DROP INDEX [IX_wms_customer_tbl_Provinceid] ON [wms_customer_tbl];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210309110608_CustomerForeignKeysRemoved')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210309110608_CustomerForeignKeysRemoved', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312063003_DescriptionAddedToBankModel')
BEGIN
    ALTER TABLE [wms_bank_tbl] ADD [Description] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312063003_DescriptionAddedToBankModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210312063003_DescriptionAddedToBankModel', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312122832_BankModelsChangeds')
BEGIN
    DECLARE @var26 sysname;
    SELECT @var26 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_bank_transaction_tbl]') AND [c].[name] = N'TransID');
    IF @var26 IS NOT NULL EXEC(N'ALTER TABLE [wms_bank_transaction_tbl] DROP CONSTRAINT [' + @var26 + '];');
    ALTER TABLE [wms_bank_transaction_tbl] DROP COLUMN [TransID];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312122832_BankModelsChangeds')
BEGIN
    ALTER TABLE [wms_bank_transaction_tbl] ADD [BankTransactionId] nvarchar(max) NOT NULL DEFAULT N'';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312122832_BankModelsChangeds')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210312122832_BankModelsChangeds', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312123537_ForeignKeysRemovedFromBankModels')
BEGIN
    ALTER TABLE [wms_bank_ledger_tbl] DROP CONSTRAINT [FK_wms_bank_ledger_tbl_wms_bank_transaction_tbl_EntityId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312123537_ForeignKeysRemovedFromBankModels')
BEGIN
    ALTER TABLE [wms_bank_transaction_tbl] DROP CONSTRAINT [FK_wms_bank_transaction_tbl_wms_bank_tbl_BankId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312123537_ForeignKeysRemovedFromBankModels')
BEGIN
    DROP INDEX [IX_wms_bank_transaction_tbl_BankId] ON [wms_bank_transaction_tbl];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312123537_ForeignKeysRemovedFromBankModels')
BEGIN
    DROP INDEX [IX_wms_bank_ledger_tbl_EntityId] ON [wms_bank_ledger_tbl];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312123537_ForeignKeysRemovedFromBankModels')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210312123537_ForeignKeysRemovedFromBankModels', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312200755_BankLedgerUpdated')
BEGIN
    DECLARE @var27 sysname;
    SELECT @var27 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_bank_ledger_tbl]') AND [c].[name] = N'MyProperty');
    IF @var27 IS NOT NULL EXEC(N'ALTER TABLE [wms_bank_ledger_tbl] DROP CONSTRAINT [' + @var27 + '];');
    ALTER TABLE [wms_bank_ledger_tbl] DROP COLUMN [MyProperty];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312200755_BankLedgerUpdated')
BEGIN
    ALTER TABLE [wms_bank_ledger_tbl] ADD [BankTransactionId] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312200755_BankLedgerUpdated')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210312200755_BankLedgerUpdated', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210321103604_PurchaseMigrationAdded')
BEGIN
    ALTER TABLE [wms_product_batch_tbl] ADD [PurchaseId] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210321103604_PurchaseMigrationAdded')
BEGIN
    ALTER TABLE [wms_product_batch_tbl] ADD [QRCode] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210321103604_PurchaseMigrationAdded')
BEGIN
    CREATE TABLE [wms_partners_purchase_shares_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        CONSTRAINT [PK_wms_partners_purchase_shares_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210321103604_PurchaseMigrationAdded')
BEGIN
    CREATE TABLE [wms_purchase_details_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [PurchaseId] bigint NOT NULL,
        [ProductId] bigint NOT NULL,
        [Qty] decimal(38, 2) NOT NULL,
        [PurchasePrice] decimal(38, 2) NOT NULL,
        [SellPrice] decimal(38, 2) NOT NULL,
        CONSTRAINT [PK_wms_purchase_details_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210321103604_PurchaseMigrationAdded')
BEGIN
    CREATE TABLE [wms_purchase_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [PurchaseDate] datetime2 NOT NULL,
        [InvoiceNo] nvarchar(max) NOT NULL,
        [SupplierId] bigint NOT NULL,
        [PaymentType] int NOT NULL,
        [RentAmount] decimal(38, 2) NOT NULL,
        [TaxAmount] decimal(38, 2) NOT NULL,
        [DiscountAmount] decimal(38, 2) NOT NULL,
        [TotalAmount] decimal(38, 2) NOT NULL,
        [PaidAmount] decimal(38, 2) NOT NULL,
        [DueAmount] decimal(38, 2) NOT NULL,
        [Description] nvarchar(max) NULL,
        [PurchaseType] int NOT NULL,
        CONSTRAINT [PK_wms_purchase_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210321103604_PurchaseMigrationAdded')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210321103604_PurchaseMigrationAdded', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210321115133_BankIdAddedToPurchaseModel')
BEGIN
    ALTER TABLE [wms_purchase_tbl] ADD [BankId] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210321115133_BankIdAddedToPurchaseModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210321115133_BankIdAddedToPurchaseModel', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210322121819_SubTotalAddedToPurchase')
BEGIN
    ALTER TABLE [wms_purchase_tbl] ADD [SubTotal] decimal(38, 2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210322121819_SubTotalAddedToPurchase')
BEGIN
    ALTER TABLE [wms_purchase_details_tbl] ADD [TotalPurchasePrice] decimal(38, 2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210322121819_SubTotalAddedToPurchase')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210322121819_SubTotalAddedToPurchase', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210326070344_ExpireDateAddedToProductBatches')
BEGIN
    DECLARE @var28 sysname;
    SELECT @var28 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_product_batch_tbl]') AND [c].[name] = N'QRCode');
    IF @var28 IS NOT NULL EXEC(N'ALTER TABLE [wms_product_batch_tbl] DROP CONSTRAINT [' + @var28 + '];');
    ALTER TABLE [wms_product_batch_tbl] DROP COLUMN [QRCode];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210326070344_ExpireDateAddedToProductBatches')
BEGIN
    EXEC sp_rename N'[wms_product_batch_tbl].[SalePrice]', N'SellPrice', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210326070344_ExpireDateAddedToProductBatches')
BEGIN
    ALTER TABLE [wms_purchase_details_tbl] ADD [ExpireDate] datetime2 NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210326070344_ExpireDateAddedToProductBatches')
BEGIN
    ALTER TABLE [wms_product_batch_tbl] ADD [ExpireDate] datetime2 NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210326070344_ExpireDateAddedToProductBatches')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210326070344_ExpireDateAddedToProductBatches', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210409181438_BarCodeAttributeRemovedFromProductBatch')
BEGIN
    DROP INDEX [IX_wms_product_batch_tbl_BarCode] ON [wms_product_batch_tbl];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210409181438_BarCodeAttributeRemovedFromProductBatch')
BEGIN
    DECLARE @var29 sysname;
    SELECT @var29 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_product_batch_tbl]') AND [c].[name] = N'BarCode');
    IF @var29 IS NOT NULL EXEC(N'ALTER TABLE [wms_product_batch_tbl] DROP CONSTRAINT [' + @var29 + '];');
    ALTER TABLE [wms_product_batch_tbl] DROP COLUMN [BarCode];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210409181438_BarCodeAttributeRemovedFromProductBatch')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210409181438_BarCodeAttributeRemovedFromProductBatch', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210413191749_BankModelsUpdated')
BEGIN
    DECLARE @var30 sysname;
    SELECT @var30 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_stock_purchase_log_tbl]') AND [c].[name] = N'StockQty');
    IF @var30 IS NOT NULL EXEC(N'ALTER TABLE [wms_stock_purchase_log_tbl] DROP CONSTRAINT [' + @var30 + '];');
    ALTER TABLE [wms_stock_purchase_log_tbl] ALTER COLUMN [StockQty] decimal(18,2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210413191749_BankModelsUpdated')
BEGIN
    DECLARE @var31 sysname;
    SELECT @var31 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_stock_purchase_log_tbl]') AND [c].[name] = N'OutQty');
    IF @var31 IS NOT NULL EXEC(N'ALTER TABLE [wms_stock_purchase_log_tbl] DROP CONSTRAINT [' + @var31 + '];');
    ALTER TABLE [wms_stock_purchase_log_tbl] ALTER COLUMN [OutQty] decimal(18,2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210413191749_BankModelsUpdated')
BEGIN
    DECLARE @var32 sysname;
    SELECT @var32 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_stock_purchase_log_tbl]') AND [c].[name] = N'InQty');
    IF @var32 IS NOT NULL EXEC(N'ALTER TABLE [wms_stock_purchase_log_tbl] DROP CONSTRAINT [' + @var32 + '];');
    ALTER TABLE [wms_stock_purchase_log_tbl] ALTER COLUMN [InQty] decimal(18,2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210413191749_BankModelsUpdated')
BEGIN
    ALTER TABLE [wms_bank_ledger_tbl] ADD [EntityType] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210413191749_BankModelsUpdated')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210413191749_BankModelsUpdated', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210416073812_UniqueConstraintRemovedFromProductBatches')
BEGIN
    DROP INDEX [IX_wms_product_batch_tbl_BatchId] ON [wms_product_batch_tbl];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210416073812_UniqueConstraintRemovedFromProductBatches')
BEGIN
    DECLARE @var33 sysname;
    SELECT @var33 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_product_batch_tbl]') AND [c].[name] = N'BatchId');
    IF @var33 IS NOT NULL EXEC(N'ALTER TABLE [wms_product_batch_tbl] DROP CONSTRAINT [' + @var33 + '];');
    ALTER TABLE [wms_product_batch_tbl] ALTER COLUMN [BatchId] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210416073812_UniqueConstraintRemovedFromProductBatches')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210416073812_UniqueConstraintRemovedFromProductBatches', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210421114620_PartnerInvestmentModelAdded')
BEGIN
    DECLARE @var34 sysname;
    SELECT @var34 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_partner_ledger_tbl]') AND [c].[name] = N'MyProperty');
    IF @var34 IS NOT NULL EXEC(N'ALTER TABLE [wms_partner_ledger_tbl] DROP CONSTRAINT [' + @var34 + '];');
    ALTER TABLE [wms_partner_ledger_tbl] DROP COLUMN [MyProperty];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210421114620_PartnerInvestmentModelAdded')
BEGIN
    CREATE TABLE [wms_partner_investment_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [PartnerId] bigint NOT NULL,
        [PartnerName] nvarchar(max) NULL,
        [InvestmentDate] datetime2 NOT NULL,
        [BankId] bigint NOT NULL,
        [BankName] nvarchar(max) NULL,
        [Amount] decimal(18,2) NOT NULL,
        [Desciption] nvarchar(max) NOT NULL,
        [TransCode] nvarchar(max) NULL,
        [InvestmetType] int NOT NULL,
        CONSTRAINT [PK_wms_partner_investment_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210421114620_PartnerInvestmentModelAdded')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210421114620_PartnerInvestmentModelAdded', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210423190642_PartnerPaymentModelCreated')
BEGIN
    CREATE TABLE [wms_partner_payment_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [PartnerId] bigint NOT NULL,
        [PartnerName] nvarchar(max) NULL,
        [Date] datetime2 NOT NULL,
        [BankId] bigint NOT NULL,
        [BankName] nvarchar(max) NULL,
        [Amount] decimal(18,2) NOT NULL,
        [Desciption] nvarchar(max) NOT NULL,
        [TransCode] nvarchar(max) NULL,
        [PaymentType] int NOT NULL,
        CONSTRAINT [PK_wms_partner_payment_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210423190642_PartnerPaymentModelCreated')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210423190642_PartnerPaymentModelCreated', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210426191835_SupplierAndCustomerReceivePaymentAndAdvancedModelsCreated')
BEGIN
    CREATE TABLE [wms_customer_advanced_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [CustomerId] bigint NOT NULL,
        [CustomerName] nvarchar(max) NULL,
        [Date] datetime2 NOT NULL,
        [BankId] bigint NOT NULL,
        [BankName] nvarchar(max) NULL,
        [Amount] decimal(18,2) NOT NULL,
        [Desciption] nvarchar(max) NULL,
        [TransCode] nvarchar(max) NULL,
        [PaymentType] int NOT NULL,
        CONSTRAINT [PK_wms_customer_advanced_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210426191835_SupplierAndCustomerReceivePaymentAndAdvancedModelsCreated')
BEGIN
    CREATE TABLE [wms_customer_receive_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [CustomerId] bigint NOT NULL,
        [CustomerName] nvarchar(max) NULL,
        [Date] datetime2 NOT NULL,
        [BankId] bigint NOT NULL,
        [BankName] nvarchar(max) NULL,
        [Amount] decimal(18,2) NOT NULL,
        [Desciption] nvarchar(max) NULL,
        [TransCode] nvarchar(max) NULL,
        [PaymentType] int NOT NULL,
        CONSTRAINT [PK_wms_customer_receive_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210426191835_SupplierAndCustomerReceivePaymentAndAdvancedModelsCreated')
BEGIN
    CREATE TABLE [wms_supplier_advanced_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [SupplierId] bigint NOT NULL,
        [SupplierName] nvarchar(max) NULL,
        [Date] datetime2 NOT NULL,
        [BankId] bigint NOT NULL,
        [BankName] nvarchar(max) NULL,
        [Amount] decimal(18,2) NOT NULL,
        [Desciption] nvarchar(max) NULL,
        [TransCode] nvarchar(max) NULL,
        [PaymentType] int NOT NULL,
        CONSTRAINT [PK_wms_supplier_advanced_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210426191835_SupplierAndCustomerReceivePaymentAndAdvancedModelsCreated')
BEGIN
    CREATE TABLE [wms_supplier_payment_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [SupplierId] bigint NOT NULL,
        [SupplierName] nvarchar(max) NULL,
        [Date] datetime2 NOT NULL,
        [BankId] bigint NOT NULL,
        [BankName] nvarchar(max) NULL,
        [Amount] decimal(18,2) NOT NULL,
        [Desciption] nvarchar(max) NULL,
        [TransCode] nvarchar(max) NULL,
        [PaymentType] int NOT NULL,
        CONSTRAINT [PK_wms_supplier_payment_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210426191835_SupplierAndCustomerReceivePaymentAndAdvancedModelsCreated')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210426191835_SupplierAndCustomerReceivePaymentAndAdvancedModelsCreated', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210428185819_SaleModelsCreated')
BEGIN
    CREATE TABLE [wms_sale_details_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [SaleId] bigint NOT NULL,
        [ProductId] bigint NOT NULL,
        [Qty] decimal(38, 2) NOT NULL,
        [UnitPrice] decimal(38, 2) NOT NULL,
        [Discount] decimal(38, 2) NOT NULL,
        [TotalSalePrice] decimal(38, 2) NOT NULL,
        CONSTRAINT [PK_wms_sale_details_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210428185819_SaleModelsCreated')
BEGIN
    CREATE TABLE [wms_sale_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [SaleDate] datetime2 NOT NULL,
        [CustomerId] bigint NOT NULL,
        [PaymentType] int NOT NULL,
        [BankId] bigint NOT NULL,
        [SubTotal] decimal(38, 2) NOT NULL,
        [RentAmount] decimal(38, 2) NOT NULL,
        [TaxAmount] decimal(38, 2) NOT NULL,
        [DiscountAmount] decimal(38, 2) NOT NULL,
        [TotalAmount] decimal(38, 2) NOT NULL,
        [PaidAmount] decimal(38, 2) NOT NULL,
        [DueAmount] decimal(38, 2) NOT NULL,
        [Description] nvarchar(max) NULL,
        CONSTRAINT [PK_wms_sale_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210428185819_SaleModelsCreated')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210428185819_SaleModelsCreated', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210428190504_BatchIdAddedToSaleModel')
BEGIN
    DECLARE @var35 sysname;
    SELECT @var35 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_supplier_payment_tbl]') AND [c].[name] = N'Amount');
    IF @var35 IS NOT NULL EXEC(N'ALTER TABLE [wms_supplier_payment_tbl] DROP CONSTRAINT [' + @var35 + '];');
    ALTER TABLE [wms_supplier_payment_tbl] ALTER COLUMN [Amount] decimal(38, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210428190504_BatchIdAddedToSaleModel')
BEGIN
    DECLARE @var36 sysname;
    SELECT @var36 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_supplier_advanced_tbl]') AND [c].[name] = N'Amount');
    IF @var36 IS NOT NULL EXEC(N'ALTER TABLE [wms_supplier_advanced_tbl] DROP CONSTRAINT [' + @var36 + '];');
    ALTER TABLE [wms_supplier_advanced_tbl] ALTER COLUMN [Amount] decimal(38, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210428190504_BatchIdAddedToSaleModel')
BEGIN
    ALTER TABLE [wms_sale_details_tbl] ADD [BatchId] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210428190504_BatchIdAddedToSaleModel')
BEGIN
    DECLARE @var37 sysname;
    SELECT @var37 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_customer_receive_tbl]') AND [c].[name] = N'Amount');
    IF @var37 IS NOT NULL EXEC(N'ALTER TABLE [wms_customer_receive_tbl] DROP CONSTRAINT [' + @var37 + '];');
    ALTER TABLE [wms_customer_receive_tbl] ALTER COLUMN [Amount] decimal(38, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210428190504_BatchIdAddedToSaleModel')
BEGIN
    DECLARE @var38 sysname;
    SELECT @var38 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_customer_advanced_tbl]') AND [c].[name] = N'Amount');
    IF @var38 IS NOT NULL EXEC(N'ALTER TABLE [wms_customer_advanced_tbl] DROP CONSTRAINT [' + @var38 + '];');
    ALTER TABLE [wms_customer_advanced_tbl] ALTER COLUMN [Amount] decimal(38, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210428190504_BatchIdAddedToSaleModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210428190504_BatchIdAddedToSaleModel', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210428190935_DecimalTypeAdded')
BEGIN
    DECLARE @var39 sysname;
    SELECT @var39 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_stock_purchase_log_tbl]') AND [c].[name] = N'StockQty');
    IF @var39 IS NOT NULL EXEC(N'ALTER TABLE [wms_stock_purchase_log_tbl] DROP CONSTRAINT [' + @var39 + '];');
    ALTER TABLE [wms_stock_purchase_log_tbl] ALTER COLUMN [StockQty] decimal(38, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210428190935_DecimalTypeAdded')
BEGIN
    DECLARE @var40 sysname;
    SELECT @var40 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_stock_purchase_log_tbl]') AND [c].[name] = N'OutQty');
    IF @var40 IS NOT NULL EXEC(N'ALTER TABLE [wms_stock_purchase_log_tbl] DROP CONSTRAINT [' + @var40 + '];');
    ALTER TABLE [wms_stock_purchase_log_tbl] ALTER COLUMN [OutQty] decimal(38, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210428190935_DecimalTypeAdded')
BEGIN
    DECLARE @var41 sysname;
    SELECT @var41 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_stock_purchase_log_tbl]') AND [c].[name] = N'InQty');
    IF @var41 IS NOT NULL EXEC(N'ALTER TABLE [wms_stock_purchase_log_tbl] DROP CONSTRAINT [' + @var41 + '];');
    ALTER TABLE [wms_stock_purchase_log_tbl] ALTER COLUMN [InQty] decimal(38, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210428190935_DecimalTypeAdded')
BEGIN
    DECLARE @var42 sysname;
    SELECT @var42 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_partner_payment_tbl]') AND [c].[name] = N'Amount');
    IF @var42 IS NOT NULL EXEC(N'ALTER TABLE [wms_partner_payment_tbl] DROP CONSTRAINT [' + @var42 + '];');
    ALTER TABLE [wms_partner_payment_tbl] ALTER COLUMN [Amount] decimal(38, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210428190935_DecimalTypeAdded')
BEGIN
    DECLARE @var43 sysname;
    SELECT @var43 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_partner_investment_tbl]') AND [c].[name] = N'Amount');
    IF @var43 IS NOT NULL EXEC(N'ALTER TABLE [wms_partner_investment_tbl] DROP CONSTRAINT [' + @var43 + '];');
    ALTER TABLE [wms_partner_investment_tbl] ALTER COLUMN [Amount] decimal(38, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210428190935_DecimalTypeAdded')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210428190935_DecimalTypeAdded', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210605082527_ExpensesModelCreated')
BEGIN
    CREATE TABLE [wms_expense_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [Date] nvarchar(max) NULL,
        [ExpenseCategory] bigint NOT NULL,
        [PaymentType] int NOT NULL,
        [Amount] decimal(38, 2) NOT NULL,
        [Desciption] nvarchar(max) NULL,
        [TransCode] nvarchar(max) NULL,
        CONSTRAINT [PK_wms_expense_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210605082527_ExpensesModelCreated')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210605082527_ExpensesModelCreated', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210605084541_ExpenseModelEdited')
BEGIN
    DECLARE @var44 sysname;
    SELECT @var44 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_expense_tbl]') AND [c].[name] = N'Date');
    IF @var44 IS NOT NULL EXEC(N'ALTER TABLE [wms_expense_tbl] DROP CONSTRAINT [' + @var44 + '];');
    ALTER TABLE [wms_expense_tbl] ALTER COLUMN [Date] datetime2 NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210605084541_ExpenseModelEdited')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210605084541_ExpenseModelEdited', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210605120129_ExpanseCategory')
BEGIN
    DECLARE @var45 sysname;
    SELECT @var45 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_expense_tbl]') AND [c].[name] = N'Desciption');
    IF @var45 IS NOT NULL EXEC(N'ALTER TABLE [wms_expense_tbl] DROP CONSTRAINT [' + @var45 + '];');
    ALTER TABLE [wms_expense_tbl] DROP COLUMN [Desciption];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210605120129_ExpanseCategory')
BEGIN
    ALTER TABLE [wms_expense_tbl] ADD [Description] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210605120129_ExpanseCategory')
BEGIN
    CREATE TABLE [wms_expense_category_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [Name] nvarchar(450) NOT NULL,
        [Description] nvarchar(max) NULL,
        [Status] int NOT NULL,
        CONSTRAINT [PK_wms_expense_category_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210605120129_ExpanseCategory')
BEGIN
    CREATE UNIQUE INDEX [IX_wms_expense_category_tbl_Name] ON [wms_expense_category_tbl] ([Name]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210605120129_ExpanseCategory')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210605120129_ExpanseCategory', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210623181225_ForeignKeyRemovedFromCustomerLedger')
BEGIN
    ALTER TABLE [wms_customer_ledger_tbl] DROP CONSTRAINT [FK_wms_customer_ledger_tbl_wms_customer_tbl_EntityId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210623181225_ForeignKeyRemovedFromCustomerLedger')
BEGIN
    DROP INDEX [IX_wms_customer_ledger_tbl_EntityId] ON [wms_customer_ledger_tbl];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210623181225_ForeignKeyRemovedFromCustomerLedger')
BEGIN
    ALTER TABLE [wms_customer_ledger_tbl] ADD [CustomerId] bigint NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210623181225_ForeignKeyRemovedFromCustomerLedger')
BEGIN
    CREATE INDEX [IX_wms_customer_ledger_tbl_CustomerId] ON [wms_customer_ledger_tbl] ([CustomerId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210623181225_ForeignKeyRemovedFromCustomerLedger')
BEGIN
    ALTER TABLE [wms_customer_ledger_tbl] ADD CONSTRAINT [FK_wms_customer_ledger_tbl_wms_customer_tbl_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [wms_customer_tbl] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210623181225_ForeignKeyRemovedFromCustomerLedger')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210623181225_ForeignKeyRemovedFromCustomerLedger', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210625071636_ShopModelAdded')
BEGIN
    CREATE TABLE [wms_shop_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [Name_en] nvarchar(max) NOT NULL,
        [Name_ps] nvarchar(max) NULL,
        [Name_dr] nvarchar(max) NULL,
        [LogoUrl] nvarchar(max) NOT NULL,
        [Phone1] nvarchar(max) NULL,
        [Phone2] nvarchar(max) NULL,
        [Email1] nvarchar(max) NULL,
        [Email2] nvarchar(max) NULL,
        [Address_en] nvarchar(max) NULL,
        [Address_ps] nvarchar(max) NULL,
        [Address_dr] nvarchar(max) NULL,
        [Responsible1] nvarchar(max) NULL,
        [Responsible2] nvarchar(max) NULL,
        [Slog_en] nvarchar(max) NULL,
        [Slog_ps] nvarchar(max) NULL,
        [Slog_dr] nvarchar(max) NULL,
        CONSTRAINT [PK_wms_shop_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210625071636_ShopModelAdded')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210625071636_ShopModelAdded', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210625114042_FileAddedToShopModel')
BEGIN
    DECLARE @var46 sysname;
    SELECT @var46 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_shop_tbl]') AND [c].[name] = N'LogoUrl');
    IF @var46 IS NOT NULL EXEC(N'ALTER TABLE [wms_shop_tbl] DROP CONSTRAINT [' + @var46 + '];');
    ALTER TABLE [wms_shop_tbl] ALTER COLUMN [LogoUrl] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210625114042_FileAddedToShopModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210625114042_FileAddedToShopModel', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210702062250_ExpenseModelsCreated')
BEGIN
    ALTER TABLE [wms_expense_tbl] ADD [BankId] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210702062250_ExpenseModelsCreated')
BEGIN
    ALTER TABLE [wms_expense_tbl] ADD [BankName] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210702062250_ExpenseModelsCreated')
BEGIN
    ALTER TABLE [wms_expense_tbl] ADD [BillNumber] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210702062250_ExpenseModelsCreated')
BEGIN
    CREATE TABLE [wms_asset_handover_Details_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [AssetHandoverId] bigint NOT NULL,
        [AssetId] bigint NOT NULL,
        [Status] int NOT NULL,
        [Qty] int NOT NULL,
        [Details] nvarchar(max) NULL,
        CONSTRAINT [PK_wms_asset_handover_Details_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210702062250_ExpenseModelsCreated')
BEGIN
    CREATE TABLE [wms_asset_handover_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [EmployeeId] bigint NOT NULL,
        [HandoverDate] datetime2 NULL,
        [HandoverRequestId] nvarchar(max) NULL,
        [HandoverRemarks] nvarchar(max) NULL,
        CONSTRAINT [PK_wms_asset_handover_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210702062250_ExpenseModelsCreated')
BEGIN
    CREATE TABLE [wms_asset_return] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        CONSTRAINT [PK_wms_asset_return] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210702062250_ExpenseModelsCreated')
BEGIN
    CREATE TABLE [wms_asset_stock_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [AssetId] bigint NOT NULL,
        [PurchaseDate] datetime2 NOT NULL,
        [ExpiryDate] datetime2 NULL,
        [InQty] int NOT NULL,
        [OutQty] int NOT NULL,
        [StockQty] int NOT NULL,
        [Description] nvarchar(max) NULL,
        [Status] int NOT NULL,
        CONSTRAINT [PK_wms_asset_stock_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210702062250_ExpenseModelsCreated')
BEGIN
    CREATE TABLE [wms_asset_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [AssetCategoryId] bigint NOT NULL,
        [Name] nvarchar(450) NOT NULL,
        [Description] nvarchar(max) NULL,
        [Model] nvarchar(max) NULL,
        [InQty] int NOT NULL,
        [OutQty] int NOT NULL,
        [StockQty] int NOT NULL,
        [Status] int NOT NULL,
        CONSTRAINT [PK_wms_asset_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210702062250_ExpenseModelsCreated')
BEGIN
    CREATE TABLE [wms_assets_category_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [Name] nvarchar(450) NOT NULL,
        [Description] nvarchar(max) NULL,
        [Status] int NOT NULL,
        CONSTRAINT [PK_wms_assets_category_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210702062250_ExpenseModelsCreated')
BEGIN
    CREATE TABLE [wms_designation_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [Name] nvarchar(max) NOT NULL,
        [Description] nvarchar(max) NULL,
        [Status] int NOT NULL,
        CONSTRAINT [PK_wms_designation_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210702062250_ExpenseModelsCreated')
BEGIN
    CREATE TABLE [wms_employee_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [Name] nvarchar(max) NOT NULL,
        [Lastname] nvarchar(max) NOT NULL,
        [Fathername] nvarchar(max) NOT NULL,
        [NationalIdnumber] nvarchar(450) NULL,
        [Phone] nvarchar(max) NOT NULL,
        [Email] nvarchar(max) NULL,
        [Countryid] bigint NOT NULL,
        [Provinceid] bigint NOT NULL,
        [Address] nvarchar(max) NULL,
        [Gender] int NOT NULL,
        [MaritalStatus] int NOT NULL,
        [EducationalDegree] int NOT NULL,
        [BaseSalary] decimal (38,2) NOT NULL,
        [Birthdate] nvarchar(max) NULL,
        [Hiredate] nvarchar(max) NULL,
        [Leavedate] nvarchar(max) NULL,
        [Image] nvarchar(max) NULL,
        [Details] nvarchar(max) NULL,
        [DesignationId] bigint NOT NULL,
        CONSTRAINT [PK_wms_employee_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210702062250_ExpenseModelsCreated')
BEGIN
    CREATE UNIQUE INDEX [IX_wms_asset_tbl_Name] ON [wms_asset_tbl] ([Name]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210702062250_ExpenseModelsCreated')
BEGIN
    CREATE UNIQUE INDEX [IX_wms_assets_category_tbl_Name] ON [wms_assets_category_tbl] ([Name]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210702062250_ExpenseModelsCreated')
BEGIN
    CREATE UNIQUE INDEX [IX_wms_employee_tbl_NationalIdnumber] ON [wms_employee_tbl] ([NationalIdnumber]) WHERE [NationalIdnumber] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210702062250_ExpenseModelsCreated')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210702062250_ExpenseModelsCreated', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210715192722_InvoiceNoAddedToSaleModel')
BEGIN
    ALTER TABLE [wms_sale_tbl] ADD [InvoiceNo] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210715192722_InvoiceNoAddedToSaleModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210715192722_InvoiceNoAddedToSaleModel', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210808172347_ServiceQuoteModelsCreated')
BEGIN
    ALTER TABLE [ProductTaxes] DROP CONSTRAINT [FK_ProductTaxes_wms_product_tbl_ProductId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210808172347_ServiceQuoteModelsCreated')
BEGIN
    ALTER TABLE [ProductTaxes] DROP CONSTRAINT [FK_ProductTaxes_wms_tax_tbl_TaxId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210808172347_ServiceQuoteModelsCreated')
BEGIN
    ALTER TABLE [wms_product_tbl] DROP CONSTRAINT [FK_wms_product_tbl_ProductTypes_ProductTypeId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210808172347_ServiceQuoteModelsCreated')
BEGIN
    ALTER TABLE [ProductTypes] DROP CONSTRAINT [PK_ProductTypes];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210808172347_ServiceQuoteModelsCreated')
BEGIN
    ALTER TABLE [ProductTaxes] DROP CONSTRAINT [PK_ProductTaxes];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210808172347_ServiceQuoteModelsCreated')
BEGIN
    EXEC sp_rename N'[ProductTypes]', N'wms_product_type_tbl';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210808172347_ServiceQuoteModelsCreated')
BEGIN
    EXEC sp_rename N'[ProductTaxes]', N'wms_product_tax_tbl';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210808172347_ServiceQuoteModelsCreated')
BEGIN
    EXEC sp_rename N'[wms_product_tax_tbl].[IX_ProductTaxes_TaxId]', N'IX_wms_product_tax_tbl_TaxId', N'INDEX';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210808172347_ServiceQuoteModelsCreated')
BEGIN
    ALTER TABLE [wms_product_type_tbl] ADD CONSTRAINT [PK_wms_product_type_tbl] PRIMARY KEY ([Id]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210808172347_ServiceQuoteModelsCreated')
BEGIN
    ALTER TABLE [wms_product_tax_tbl] ADD CONSTRAINT [PK_wms_product_tax_tbl] PRIMARY KEY ([ProductId], [TaxId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210808172347_ServiceQuoteModelsCreated')
BEGIN
    CREATE TABLE [wms_quote_details_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [QuoteId] bigint NOT NULL,
        [ProductId] bigint NOT NULL,
        [BatchId] nvarchar(max) NULL,
        [Qty] decimal(38, 2) NOT NULL,
        [UnitPrice] decimal(38, 2) NOT NULL,
        [Discount] decimal(38, 2) NOT NULL,
        [TotalQuotePrice] decimal(38, 2) NOT NULL,
        CONSTRAINT [PK_wms_quote_details_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210808172347_ServiceQuoteModelsCreated')
BEGIN
    CREATE TABLE [wms_quote_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [QuoteDate] datetime2 NOT NULL,
        [CustomerId] bigint NOT NULL,
        [PaymentType] int NOT NULL,
        [BankId] bigint NOT NULL,
        [SubTotal] decimal(38, 2) NOT NULL,
        [RentAmount] decimal(38, 2) NOT NULL,
        [TaxAmount] decimal(38, 2) NOT NULL,
        [DiscountAmount] decimal(38, 2) NOT NULL,
        [TotalAmount] decimal(38, 2) NOT NULL,
        [PaidAmount] decimal(38, 2) NOT NULL,
        [DueAmount] decimal(38, 2) NOT NULL,
        [Description] nvarchar(max) NULL,
        [InvoiceNo] nvarchar(max) NULL,
        [QuoteStatus] int NOT NULL,
        CONSTRAINT [PK_wms_quote_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210808172347_ServiceQuoteModelsCreated')
BEGIN
    CREATE TABLE [wms_service_category_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [Name] nvarchar(450) NOT NULL,
        [Fee] decimal(38, 2) NOT NULL,
        [Description] nvarchar(max) NULL,
        [Status] int NOT NULL,
        CONSTRAINT [PK_wms_service_category_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210808172347_ServiceQuoteModelsCreated')
BEGIN
    CREATE TABLE [wms_service_details_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [ServiceId] bigint NOT NULL,
        [ServiceCatergoryId] bigint NOT NULL,
        [Qty] decimal(38, 2) NOT NULL,
        [Fee_Charges] decimal(38, 2) NOT NULL,
        [Discount] decimal(38, 2) NOT NULL,
        [TotalServicePrice] decimal(38, 2) NOT NULL,
        [Descriptions] nvarchar(max) NULL,
        CONSTRAINT [PK_wms_service_details_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210808172347_ServiceQuoteModelsCreated')
BEGIN
    CREATE TABLE [wms_service_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [ServiceDate] datetime2 NOT NULL,
        [CustomerId] bigint NOT NULL,
        [EmployeeId] bigint NOT NULL,
        [PaymentType] int NOT NULL,
        [BankId] bigint NOT NULL,
        [TaxAmount] decimal(38, 2) NOT NULL,
        [DiscountAmount] decimal(38, 2) NOT NULL,
        [SubTotal] decimal(38, 2) NOT NULL,
        [TotalAmount] decimal(38, 2) NOT NULL,
        [PaidAmount] decimal(38, 2) NOT NULL,
        [DueAmount] decimal(38, 2) NOT NULL,
        [Description] nvarchar(max) NULL,
        [InvoiceNo] nvarchar(max) NULL,
        CONSTRAINT [PK_wms_service_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210808172347_ServiceQuoteModelsCreated')
BEGIN
    CREATE UNIQUE INDEX [IX_wms_service_category_tbl_Name] ON [wms_service_category_tbl] ([Name]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210808172347_ServiceQuoteModelsCreated')
BEGIN
    ALTER TABLE [wms_product_tax_tbl] ADD CONSTRAINT [FK_wms_product_tax_tbl_wms_product_tbl_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [wms_product_tbl] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210808172347_ServiceQuoteModelsCreated')
BEGIN
    ALTER TABLE [wms_product_tax_tbl] ADD CONSTRAINT [FK_wms_product_tax_tbl_wms_tax_tbl_TaxId] FOREIGN KEY ([TaxId]) REFERENCES [wms_tax_tbl] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210808172347_ServiceQuoteModelsCreated')
BEGIN
    ALTER TABLE [wms_product_tbl] ADD CONSTRAINT [FK_wms_product_tbl_wms_product_type_tbl_ProductTypeId] FOREIGN KEY ([ProductTypeId]) REFERENCES [wms_product_type_tbl] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210808172347_ServiceQuoteModelsCreated')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210808172347_ServiceQuoteModelsCreated', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210813170652_LoanModuleCreated')
BEGIN
    CREATE TABLE [wms_office_loan_ledger_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [EntityId] bigint NOT NULL,
        [Date] datetime2 NOT NULL,
        [Description] nvarchar(max) NULL,
        [VoucherNo] nvarchar(max) NULL,
        [Debit] decimal(38, 2) NOT NULL,
        [Credit] decimal(38, 2) NOT NULL,
        [Balance] decimal(38, 2) NOT NULL,
        [TransCode] nvarchar(max) NULL,
        [isClosed] bit NOT NULL,
        CONSTRAINT [PK_wms_office_loan_ledger_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210813170652_LoanModuleCreated')
BEGIN
    CREATE TABLE [wms_office_loan_payment_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [PersonId] bigint NOT NULL,
        [PersonName] nvarchar(max) NULL,
        [Date] datetime2 NOT NULL,
        [BankId] bigint NOT NULL,
        [BankName] nvarchar(max) NULL,
        [Amount] decimal(38, 2) NOT NULL,
        [Desciption] nvarchar(max) NULL,
        [TransCode] nvarchar(max) NULL,
        [PaymentType] int NOT NULL,
        CONSTRAINT [PK_wms_office_loan_payment_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210813170652_LoanModuleCreated')
BEGIN
    CREATE TABLE [wms_office_loan_receive_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [PersonId] bigint NOT NULL,
        [PersonName] nvarchar(max) NULL,
        [Date] datetime2 NOT NULL,
        [BankId] bigint NOT NULL,
        [BankName] nvarchar(max) NULL,
        [Amount] decimal(38, 2) NOT NULL,
        [Desciption] nvarchar(max) NULL,
        [TransCode] nvarchar(max) NULL,
        [PaymentType] int NOT NULL,
        CONSTRAINT [PK_wms_office_loan_receive_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210813170652_LoanModuleCreated')
BEGIN
    CREATE TABLE [wms_office_person_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [Name] nvarchar(max) NOT NULL,
        [FatherName] nvarchar(max) NULL,
        [Phone] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [Details] nvarchar(max) NULL,
        [PreviousBalance] decimal(38, 2) NOT NULL,
        CONSTRAINT [PK_wms_office_person_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210813170652_LoanModuleCreated')
BEGIN
    CREATE TABLE [wms_person_loan_ledger_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [EntityId] bigint NOT NULL,
        [Date] datetime2 NOT NULL,
        [Description] nvarchar(max) NULL,
        [VoucherNo] nvarchar(max) NULL,
        [Debit] decimal(38, 2) NOT NULL,
        [Credit] decimal(38, 2) NOT NULL,
        [Balance] decimal(38, 2) NOT NULL,
        [TransCode] nvarchar(max) NULL,
        [isClosed] bit NOT NULL,
        CONSTRAINT [PK_wms_person_loan_ledger_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210813170652_LoanModuleCreated')
BEGIN
    CREATE TABLE [wms_person_loan_payment_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [PersonId] bigint NOT NULL,
        [PersonName] nvarchar(max) NULL,
        [Date] datetime2 NOT NULL,
        [BankId] bigint NOT NULL,
        [BankName] nvarchar(max) NULL,
        [Amount] decimal(38, 2) NOT NULL,
        [Desciption] nvarchar(max) NULL,
        [TransCode] nvarchar(max) NULL,
        [PaymentType] int NOT NULL,
        CONSTRAINT [PK_wms_person_loan_payment_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210813170652_LoanModuleCreated')
BEGIN
    CREATE TABLE [wms_person_loan_receive_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [PersonId] bigint NOT NULL,
        [PersonName] nvarchar(max) NULL,
        [Date] datetime2 NOT NULL,
        [BankId] bigint NOT NULL,
        [BankName] nvarchar(max) NULL,
        [Amount] decimal(38, 2) NOT NULL,
        [Desciption] nvarchar(max) NULL,
        [TransCode] nvarchar(max) NULL,
        [PaymentType] int NOT NULL,
        CONSTRAINT [PK_wms_person_loan_receive_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210813170652_LoanModuleCreated')
BEGIN
    CREATE TABLE [wms_person_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [Name] nvarchar(max) NOT NULL,
        [FatherName] nvarchar(max) NULL,
        [Phone] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [Details] nvarchar(max) NULL,
        [PreviousBalance] decimal(38, 2) NOT NULL,
        CONSTRAINT [PK_wms_person_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210813170652_LoanModuleCreated')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210813170652_LoanModuleCreated', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210824185202_ReturnsModelsAdded')
BEGIN
    CREATE TABLE [wms_return_details_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [SaleId] bigint NOT NULL,
        [PurchaseId] bigint NOT NULL,
        [ProductId] bigint NOT NULL,
        [BatchId] nvarchar(max) NULL,
        [Qty] decimal(38, 2) NOT NULL,
        [UnitPrice] decimal(38, 2) NOT NULL,
        [TotalPrice] decimal(38, 2) NOT NULL,
        CONSTRAINT [PK_wms_return_details_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210824185202_ReturnsModelsAdded')
BEGIN
    CREATE TABLE [wms_return_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [ReturnType] int NOT NULL,
        [ReturnDate] datetime2 NOT NULL,
        [CustomerId] bigint NOT NULL,
        [SupplierId] bigint NOT NULL,
        [PaymentType] int NOT NULL,
        [BankId] bigint NOT NULL,
        [TotalAmount] decimal(38, 2) NOT NULL,
        [PaidAmount] decimal(38, 2) NOT NULL,
        [DueAmount] decimal(38, 2) NOT NULL,
        [Description] nvarchar(max) NULL,
        CONSTRAINT [PK_wms_return_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210824185202_ReturnsModelsAdded')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210824185202_ReturnsModelsAdded', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210825104647_PurchaseIdWithInvoiceNoAddedToReturnModel')
BEGIN
    ALTER TABLE [wms_return_tbl] ADD [InvoiceNo] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210825104647_PurchaseIdWithInvoiceNoAddedToReturnModel')
BEGIN
    ALTER TABLE [wms_return_tbl] ADD [PurchaseId] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210825104647_PurchaseIdWithInvoiceNoAddedToReturnModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210825104647_PurchaseIdWithInvoiceNoAddedToReturnModel', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210825105417_ReturnIdAddedToReturnDetailsModel')
BEGIN
    DECLARE @var47 sysname;
    SELECT @var47 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_return_details_tbl]') AND [c].[name] = N'PurchaseId');
    IF @var47 IS NOT NULL EXEC(N'ALTER TABLE [wms_return_details_tbl] DROP CONSTRAINT [' + @var47 + '];');
    ALTER TABLE [wms_return_details_tbl] DROP COLUMN [PurchaseId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210825105417_ReturnIdAddedToReturnDetailsModel')
BEGIN
    DECLARE @var48 sysname;
    SELECT @var48 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_return_details_tbl]') AND [c].[name] = N'SaleId');
    IF @var48 IS NOT NULL EXEC(N'ALTER TABLE [wms_return_details_tbl] DROP CONSTRAINT [' + @var48 + '];');
    ALTER TABLE [wms_return_details_tbl] DROP COLUMN [SaleId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210825105417_ReturnIdAddedToReturnDetailsModel')
BEGIN
    ALTER TABLE [wms_return_details_tbl] ADD [ReturnId] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210825105417_ReturnIdAddedToReturnDetailsModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210825105417_ReturnIdAddedToReturnDetailsModel', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210825183831_DiscountAddedToReturnDetailsModel')
BEGIN
    ALTER TABLE [wms_return_details_tbl] ADD [Discount] decimal(38, 2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210825183831_DiscountAddedToReturnDetailsModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210825183831_DiscountAddedToReturnDetailsModel', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210828110852_ReturnModelUpdated')
BEGIN
    ALTER TABLE [wms_return_tbl] ADD [DiscountAmount] decimal(38, 2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210828110852_ReturnModelUpdated')
BEGIN
    ALTER TABLE [wms_return_tbl] ADD [RentAmount] decimal(38, 2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210828110852_ReturnModelUpdated')
BEGIN
    ALTER TABLE [wms_return_tbl] ADD [SubTotal] decimal(38, 2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210828110852_ReturnModelUpdated')
BEGIN
    ALTER TABLE [wms_return_tbl] ADD [TaxAmount] decimal(38, 2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210828110852_ReturnModelUpdated')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210828110852_ReturnModelUpdated', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210909082842_EmployeeAddedintoExpenses')
BEGIN
    EXEC sp_rename N'[wms_return_details_tbl].[TotalPrice]', N'TotalReturnPrice', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210909082842_EmployeeAddedintoExpenses')
BEGIN
    ALTER TABLE [wms_stock_details_tbl] ADD [CustomerId] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210909082842_EmployeeAddedintoExpenses')
BEGIN
    ALTER TABLE [wms_return_details_tbl] ADD [DetailsId] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210909082842_EmployeeAddedintoExpenses')
BEGIN
    ALTER TABLE [wms_expense_tbl] ADD [EmployeeId] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210909082842_EmployeeAddedintoExpenses')
BEGIN
    DECLARE @var49 sysname;
    SELECT @var49 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_employee_tbl]') AND [c].[name] = N'Lastname');
    IF @var49 IS NOT NULL EXEC(N'ALTER TABLE [wms_employee_tbl] DROP CONSTRAINT [' + @var49 + '];');
    ALTER TABLE [wms_employee_tbl] ALTER COLUMN [Lastname] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210909082842_EmployeeAddedintoExpenses')
BEGIN
    DECLARE @var50 sysname;
    SELECT @var50 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_country_tbl]') AND [c].[name] = N'Name');
    IF @var50 IS NOT NULL EXEC(N'ALTER TABLE [wms_country_tbl] DROP CONSTRAINT [' + @var50 + '];');
    ALTER TABLE [wms_country_tbl] ALTER COLUMN [Name] nvarchar(450) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210909082842_EmployeeAddedintoExpenses')
BEGIN
    CREATE UNIQUE INDEX [IX_wms_country_tbl_Name] ON [wms_country_tbl] ([Name]) WHERE [Name] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210909082842_EmployeeAddedintoExpenses')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210909082842_EmployeeAddedintoExpenses', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210912073537_ReturnModelUpdatedWithTransactionCode')
BEGIN
    ALTER TABLE [wms_return_tbl] ADD [TransCode] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210912073537_ReturnModelUpdatedWithTransactionCode')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210912073537_ReturnModelUpdatedWithTransactionCode', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211006105357_SaleIdAddedToReturnModel')
BEGIN
    ALTER TABLE [wms_return_tbl] ADD [SaleId] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211006105357_SaleIdAddedToReturnModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211006105357_SaleIdAddedToReturnModel', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211011180943_WastageModelCreated')
BEGIN
    CREATE TABLE [wms_wastage_details_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [WastageId] bigint NOT NULL,
        [ProductId] bigint NOT NULL,
        [BatchId] nvarchar(max) NULL,
        [Qty] decimal(38, 2) NOT NULL,
        [UnitPrice] decimal(38, 2) NOT NULL,
        [TotalPrice] decimal(38, 2) NOT NULL,
        CONSTRAINT [PK_wms_wastage_details_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211011180943_WastageModelCreated')
BEGIN
    CREATE TABLE [wms_wastage_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [WastageDate] datetime2 NOT NULL,
        [SubTotal] decimal(38, 2) NOT NULL,
        [IncomeFromWastage] decimal(38, 2) NOT NULL,
        [ExCharges] decimal(38, 2) NOT NULL,
        [TotalAmount] decimal(38, 2) NOT NULL,
        [Description] nvarchar(max) NULL,
        CONSTRAINT [PK_wms_wastage_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211011180943_WastageModelCreated')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211011180943_WastageModelCreated', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211016104650_TransCodeAddedToWastageModel')
BEGIN
    ALTER TABLE [wms_wastage_tbl] ADD [TransCode] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211016104650_TransCodeAddedToWastageModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211016104650_TransCodeAddedToWastageModel', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211016134203_FlagForUpdateAddedToWastageModel')
BEGIN
    ALTER TABLE [wms_wastage_tbl] ADD [Flg] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211016134203_FlagForUpdateAddedToWastageModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211016134203_FlagForUpdateAddedToWastageModel', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211030182929_TransactionCodeAddedToSalePurchaseModels')
BEGIN
    ALTER TABLE [wms_sale_tbl] ADD [TransCode] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211030182929_TransactionCodeAddedToSalePurchaseModels')
BEGIN
    ALTER TABLE [wms_purchase_tbl] ADD [TransCode] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211030182929_TransactionCodeAddedToSalePurchaseModels')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211030182929_TransactionCodeAddedToSalePurchaseModels', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129075724_EmployeeSalaryies')
BEGIN
    CREATE TABLE [pms_employee_ledger_tbl] (
        [Id] bigint NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [EntityId] bigint NOT NULL,
        [Date] datetime2 NOT NULL,
        [Description] nvarchar(max) NULL,
        [VoucherNo] nvarchar(max) NULL,
        [Debit] decimal(38, 2) NOT NULL,
        [Credit] decimal(38, 2) NOT NULL,
        [Balance] decimal(38, 2) NOT NULL,
        [TransCode] nvarchar(max) NULL,
        [isClosed] bit NOT NULL,
        CONSTRAINT [PK_pms_employee_ledger_tbl] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129075724_EmployeeSalaryies')
BEGIN
    CREATE TABLE [pms_employee_salaries_tbl] (
        [EmployeeId] bigint NOT NULL,
        [SalaryYear] int NOT NULL,
        [SalaryMonth] int NOT NULL,
        [Id] bigint NOT NULL,
        [UserId] nvarchar(max) NULL,
        [UserName] nvarchar(max) NULL,
        [CreatedAt] datetime2 NULL,
        [UpdatedAt] datetime2 NULL,
        [DeletedAt] datetime2 NULL,
        [TotalWorkDays] int NOT NULL,
        [OverTime] decimal(38, 2) NOT NULL,
        [Bounce] decimal(38, 2) NOT NULL,
        [Tax] decimal(38, 2) NOT NULL,
        [NetSalary] decimal(38, 2) NOT NULL,
        [Paid] decimal(38, 2) NOT NULL,
        [Balanced] decimal(38, 2) NOT NULL,
        [DueDate] datetime2 NOT NULL,
        [isPaid] bit NOT NULL,
        [TransCode] nvarchar(max) NULL,
        CONSTRAINT [PK_pms_employee_salaries_tbl] PRIMARY KEY ([EmployeeId], [SalaryYear], [SalaryMonth]),
        CONSTRAINT [FK_pms_employee_salaries_tbl_wms_employee_tbl_EmployeeId] FOREIGN KEY ([EmployeeId]) REFERENCES [wms_employee_tbl] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129075724_EmployeeSalaryies')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedAt', N'DeletedAt', N'Description', N'Name', N'Status', N'UpdatedAt', N'UserId', N'UserName') AND [object_id] = OBJECT_ID(N'[wms_assets_category_tbl]'))
        SET IDENTITY_INSERT [wms_assets_category_tbl] ON;
    INSERT INTO [wms_assets_category_tbl] ([Id], [CreatedAt], [DeletedAt], [Description], [Name], [Status], [UpdatedAt], [UserId], [UserName])
    VALUES (CAST(5 AS bigint), '2021-11-29T12:27:22.1372053+04:30', NULL, N'', N'Land', 1, '2021-11-29T12:27:22.1372056+04:30', NULL, N'System Defined'),
    (CAST(4 AS bigint), '2021-11-29T12:27:22.1372046+04:30', NULL, N'', N'Buildings', 1, '2021-11-29T12:27:22.1372049+04:30', NULL, N'System Defined'),
    (CAST(3 AS bigint), '2021-11-29T12:27:22.1372037+04:30', NULL, N'', N'Machinery', 1, '2021-11-29T12:27:22.1372040+04:30', NULL, N'System Defined'),
    (CAST(2 AS bigint), '2021-11-29T12:27:22.1371988+04:30', NULL, N'', N'Office furniture', 1, '2021-11-29T12:27:22.1371999+04:30', NULL, N'System Defined'),
    (CAST(1 AS bigint), '2021-11-29T12:27:22.1369981+04:30', NULL, N'', N'Vehicles', 1, '2021-11-29T12:27:22.1369994+04:30', NULL, N'System Defined');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedAt', N'DeletedAt', N'Description', N'Name', N'Status', N'UpdatedAt', N'UserId', N'UserName') AND [object_id] = OBJECT_ID(N'[wms_assets_category_tbl]'))
        SET IDENTITY_INSERT [wms_assets_category_tbl] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129075724_EmployeeSalaryies')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccountName', N'AccountNo', N'BankName', N'Branch', N'CreatedAt', N'DeletedAt', N'Description', N'Signature', N'UpdatedAt', N'UserId', N'UserName') AND [object_id] = OBJECT_ID(N'[wms_bank_tbl]'))
        SET IDENTITY_INSERT [wms_bank_tbl] ON;
    INSERT INTO [wms_bank_tbl] ([Id], [AccountName], [AccountNo], [BankName], [Branch], [CreatedAt], [DeletedAt], [Description], [Signature], [UpdatedAt], [UserId], [UserName])
    VALUES (CAST(1 AS bigint), N'System Defiand', N'Editable', N'Islamic Bank of Afghanistan', N'Editable', '2021-11-29T12:27:22.1358050+04:30', NULL, N'Editebal', N'Editable', '2021-11-29T12:27:22.1358062+04:30', NULL, N'System Defined'),
    (CAST(9 AS bigint), N'System Defiand', N'Editable', N'Ghazanfar bank', N'Editable', '2021-11-29T12:27:22.1362135+04:30', NULL, N'Editebal', N'Editable', '2021-11-29T12:27:22.1362139+04:30', NULL, N'System Defined'),
    (CAST(10 AS bigint), N'System Defiand', N'Editable', N'Afghan United Bank', N'Editable', '2021-11-29T12:27:22.1362143+04:30', NULL, N'Editebal', N'Editable', '2021-11-29T12:27:22.1362146+04:30', NULL, N'System Defined'),
    (CAST(7 AS bigint), N'System Defiand', N'Editable', N'New Kabul Bank', N'Editable', '2021-11-29T12:27:22.1362120+04:30', NULL, N'Editebal', N'Editable', '2021-11-29T12:27:22.1362123+04:30', NULL, N'System Defined'),
    (CAST(6 AS bigint), N'System Defiand', N'Editable', N'Kabul Bank', N'Editable', '2021-11-29T12:27:22.1362109+04:30', NULL, N'Editebal', N'Editable', '2021-11-29T12:27:22.1362114+04:30', NULL, N'System Defined'),
    (CAST(5 AS bigint), N'System Defiand', N'Editable', N'First MicroFinance Bank-Afghanistan', N'Editable', '2021-11-29T12:27:22.1362016+04:30', NULL, N'Editebal', N'Editable', '2021-11-29T12:27:22.1362021+04:30', NULL, N'System Defined'),
    (CAST(4 AS bigint), N'System Defiand', N'Editable', N'Bank-e-Millie Afghan', N'Editable', '2021-11-29T12:27:22.1362008+04:30', NULL, N'Editebal', N'Editable', '2021-11-29T12:27:22.1362011+04:30', NULL, N'System Defined'),
    (CAST(3 AS bigint), N'System Defiand', N'Editable', N'Azizi Bank', N'Editable', '2021-11-29T12:27:22.1361999+04:30', NULL, N'Editebal', N'Editable', '2021-11-29T12:27:22.1362003+04:30', NULL, N'System Defined'),
    (CAST(2 AS bigint), N'System Defiand', N'Editable', N'Afghanistan International Bank', N'Editable', '2021-11-29T12:27:22.1361850+04:30', NULL, N'Editebal', N'Editable', '2021-11-29T12:27:22.1361863+04:30', NULL, N'System Defined'),
    (CAST(8 AS bigint), N'System Defiand', N'Editable', N'Pashtany Bank', N'Editable', '2021-11-29T12:27:22.1362128+04:30', NULL, N'Editebal', N'Editable', '2021-11-29T12:27:22.1362131+04:30', NULL, N'System Defined');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccountName', N'AccountNo', N'BankName', N'Branch', N'CreatedAt', N'DeletedAt', N'Description', N'Signature', N'UpdatedAt', N'UserId', N'UserName') AND [object_id] = OBJECT_ID(N'[wms_bank_tbl]'))
        SET IDENTITY_INSERT [wms_bank_tbl] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129075724_EmployeeSalaryies')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedAt', N'DeletedAt', N'Description', N'Name', N'Status', N'UpdatedAt', N'UserId', N'UserName') AND [object_id] = OBJECT_ID(N'[wms_category_tbl]'))
        SET IDENTITY_INSERT [wms_category_tbl] ON;
    INSERT INTO [wms_category_tbl] ([Id], [CreatedAt], [DeletedAt], [Description], [Name], [Status], [UpdatedAt], [UserId], [UserName])
    VALUES (CAST(7 AS bigint), '2021-11-29T12:27:22.1308653+04:30', NULL, N'remedy to counteract the effects of poison needed the antidote for the snake''s venom. 2 : something that relieves, prevents, or counteracts an antidote to boredom', N'Antidotes', 1, '2021-11-29T12:27:22.1308656+04:30', NULL, N'System Defined'),
    (CAST(12 AS bigint), '2021-11-29T12:27:22.1308682+04:30', NULL, N' ', N'Enzymya', 1, '2021-11-29T12:27:22.1308684+04:30', NULL, N'System Defined'),
    (CAST(9 AS bigint), '2021-11-29T12:27:22.1308668+04:30', NULL, N' ', N'Antifungals', 1, '2021-11-29T12:27:22.1308670+04:30', NULL, N'System Defined'),
    (CAST(8 AS bigint), '2021-11-29T12:27:22.1308659+04:30', NULL, N'drug that is effective against vomiting and nausea', N'Antiemetics', 1, '2021-11-29T12:27:22.1308662+04:30', NULL, N'System Defined'),
    (CAST(6 AS bigint), '2021-11-29T12:27:22.1308647+04:30', NULL, N' used to prevent or treat depression.', N'Antidepressants', 1, '2021-11-29T12:27:22.1308649+04:30', NULL, N'System Defined'),
    (CAST(10 AS bigint), '2021-11-29T12:27:22.1308675+04:30', NULL, N' category of drugs used to prevent anxiety and treat anxiety related to several anxiety disorders)', N'Anxiolytic', 1, '2021-11-29T12:27:22.1308677+04:30', NULL, N'System Defined'),
    (CAST(4 AS bigint), '2021-11-29T12:27:22.1308635+04:30', NULL, N'Anticonvulsants suppress the excessive rapid firing of neurons during seizures. Anticonvulsants also prevent the spread of the seizure within the brain.', N'Anticonvulsants', 1, '2021-11-29T12:27:22.1308637+04:30', NULL, N'System Defined'),
    (CAST(3 AS bigint), '2021-11-29T12:27:22.1308627+04:30', NULL, N'medications that destroy or slow down the growth of bacteria', N'Antibacterials', 1, '2021-11-29T12:27:22.1308630+04:30', NULL, N'System Defined'),
    (CAST(2 AS bigint), '2021-11-29T12:27:22.1308564+04:30', NULL, N'any agent that produces a local or general loss of sensation, including pain. Anesthetics achieve this effect by acting on the brain or peripheral nervous system to suppress responses to sensory stimulation', N'Anesthetics', 1, '2021-11-29T12:27:22.1308588+04:30', NULL, N'System Defined'),
    (CAST(1 AS bigint), '2021-11-29T12:27:22.1305357+04:30', NULL, N'including opioids and non-opioids designed to relieve pain without causing the loss of consciousness.', N'Analgesics', 1, '2021-11-29T12:27:22.1306609+04:30', NULL, N'System Defined'),
    (CAST(5 AS bigint), '2021-11-29T12:27:22.1308641+04:30', NULL, N'A cholinesterase inhibitor used to manage mild to moderate dementia associated with Alzheimer''s Disease.', N'Antidementia ', 1, '2021-11-29T12:27:22.1308642+04:30', NULL, N'System Defined');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedAt', N'DeletedAt', N'Description', N'Name', N'Status', N'UpdatedAt', N'UserId', N'UserName') AND [object_id] = OBJECT_ID(N'[wms_category_tbl]'))
        SET IDENTITY_INSERT [wms_category_tbl] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129075724_EmployeeSalaryies')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Code', N'CreatedAt', N'DeletedAt', N'Name', N'UpdatedAt', N'UserId', N'UserName') AND [object_id] = OBJECT_ID(N'[wms_country_tbl]'))
        SET IDENTITY_INSERT [wms_country_tbl] ON;
    INSERT INTO [wms_country_tbl] ([Id], [Code], [CreatedAt], [DeletedAt], [Name], [UpdatedAt], [UserId], [UserName])
    VALUES (CAST(1 AS bigint), N'AFN', '2021-11-29T12:27:22.1344751+04:30', NULL, N'Afghanistan', '2021-11-29T12:27:22.1344763+04:30', NULL, N'System_Populated'),
    (CAST(2 AS bigint), N'PK', '2021-11-29T12:27:22.1344843+04:30', NULL, N'Pakistan', '2021-11-29T12:27:22.1344847+04:30', NULL, N'System_Populated'),
    (CAST(3 AS bigint), N'IND', '2021-11-29T12:27:22.1344853+04:30', NULL, N'India', '2021-11-29T12:27:22.1344855+04:30', NULL, N'System_Populated'),
    (CAST(4 AS bigint), N'TUR', '2021-11-29T12:27:22.1344858+04:30', NULL, N'Turkey', '2021-11-29T12:27:22.1344861+04:30', NULL, N'System_Populated'),
    (CAST(5 AS bigint), N'IR', '2021-11-29T12:27:22.1344865+04:30', NULL, N'Iran', '2021-11-29T12:27:22.1344867+04:30', NULL, N'System_Populated');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Code', N'CreatedAt', N'DeletedAt', N'Name', N'UpdatedAt', N'UserId', N'UserName') AND [object_id] = OBJECT_ID(N'[wms_country_tbl]'))
        SET IDENTITY_INSERT [wms_country_tbl] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129075724_EmployeeSalaryies')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedAt', N'DeletedAt', N'Description', N'Name', N'Status', N'UpdatedAt', N'UserId', N'UserName') AND [object_id] = OBJECT_ID(N'[wms_designation_tbl]'))
        SET IDENTITY_INSERT [wms_designation_tbl] ON;
    INSERT INTO [wms_designation_tbl] ([Id], [CreatedAt], [DeletedAt], [Description], [Name], [Status], [UpdatedAt], [UserId], [UserName])
    VALUES (CAST(7 AS bigint), '2021-11-29T12:27:22.1364213+04:30', NULL, NULL, N'Pharmacist', 1, '2021-11-29T12:27:22.1364215+04:30', NULL, N'System Defined'),
    (CAST(6 AS bigint), '2021-11-29T12:27:22.1364208+04:30', NULL, NULL, N'SalesMan', 1, '2021-11-29T12:27:22.1364210+04:30', NULL, N'System Defined'),
    (CAST(5 AS bigint), '2021-11-29T12:27:22.1364203+04:30', NULL, NULL, N'Pharmacy IT Specialist', 1, '2021-11-29T12:27:22.1364206+04:30', NULL, N'System Defined'),
    (CAST(4 AS bigint), '2021-11-29T12:27:22.1364198+04:30', NULL, NULL, N'Medicines Safety Manager', 1, '2021-11-29T12:27:22.1364201+04:30', NULL, N'System Defined'),
    (CAST(2 AS bigint), '2021-11-29T12:27:22.1364186+04:30', NULL, NULL, N'Checking Technician', 1, '2021-11-29T12:27:22.1364189+04:30', NULL, N'System Defined'),
    (CAST(1 AS bigint), '2021-11-29T12:27:22.1364130+04:30', NULL, NULL, N'Admin', 1, '2021-11-29T12:27:22.1364141+04:30', NULL, N'System Defined'),
    (CAST(3 AS bigint), '2021-11-29T12:27:22.1364192+04:30', NULL, NULL, N'Dispensary Manager', 1, '2021-11-29T12:27:22.1364194+04:30', NULL, N'System Defined');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedAt', N'DeletedAt', N'Description', N'Name', N'Status', N'UpdatedAt', N'UserId', N'UserName') AND [object_id] = OBJECT_ID(N'[wms_designation_tbl]'))
        SET IDENTITY_INSERT [wms_designation_tbl] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129075724_EmployeeSalaryies')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedAt', N'DeletedAt', N'Description', N'Name', N'Status', N'UpdatedAt', N'UserId', N'UserName') AND [object_id] = OBJECT_ID(N'[wms_expense_category_tbl]'))
        SET IDENTITY_INSERT [wms_expense_category_tbl] ON;
    INSERT INTO [wms_expense_category_tbl] ([Id], [CreatedAt], [DeletedAt], [Description], [Name], [Status], [UpdatedAt], [UserId], [UserName])
    VALUES (CAST(10 AS bigint), '2021-11-29T12:27:22.1368032+04:30', NULL, N'', N'Business meals', 1, '2021-11-29T12:27:22.1368034+04:30', NULL, N'System Defined'),
    (CAST(1 AS bigint), '2021-11-29T12:27:22.1368077+04:30', NULL, N'', N'Printing', 1, '2021-11-29T12:27:22.1368079+04:30', NULL, N'System Defined'),
    (CAST(2 AS bigint), '2021-11-29T12:27:22.1368072+04:30', NULL, N'', N'repairs', 1, '2021-11-29T12:27:22.1368074+04:30', NULL, N'System Defined'),
    (CAST(3 AS bigint), '2021-11-29T12:27:22.1368067+04:30', NULL, N'', N'Maintenance', 1, '2021-11-29T12:27:22.1368069+04:30', NULL, N'System Defined'),
    (CAST(4 AS bigint), '2021-11-29T12:27:22.1368062+04:30', NULL, N'', N'Bank fees', 1, '2021-11-29T12:27:22.1368064+04:30', NULL, N'System Defined'),
    (CAST(5 AS bigint), '2021-11-29T12:27:22.1368057+04:30', NULL, N'', N'Meals', 1, '2021-11-29T12:27:22.1368059+04:30', NULL, N'System Defined'),
    (CAST(6 AS bigint), '2021-11-29T12:27:22.1368052+04:30', NULL, N'', N'Health Insurance', 1, '2021-11-29T12:27:22.1368054+04:30', NULL, N'System Defined'),
    (CAST(7 AS bigint), '2021-11-29T12:27:22.1368047+04:30', NULL, N'', N'Insurance', 1, '2021-11-29T12:27:22.1368050+04:30', NULL, N'System Defined'),
    (CAST(8 AS bigint), '2021-11-29T12:27:22.1368042+04:30', NULL, N'', N'Vehicle expenses', 1, '2021-11-29T12:27:22.1368044+04:30', NULL, N'System Defined'),
    (CAST(9 AS bigint), '2021-11-29T12:27:22.1368037+04:30', NULL, N'', N'travel expenses', 1, '2021-11-29T12:27:22.1368039+04:30', NULL, N'System Defined'),
    (CAST(11 AS bigint), '2021-11-29T12:27:22.1368027+04:30', NULL, N'', N'Entertainment', 1, '2021-11-29T12:27:22.1368029+04:30', NULL, N'System Defined'),
    (CAST(20 AS bigint), '2021-11-29T12:27:22.1367981+04:30', NULL, N'', N'Water', 1, '2021-11-29T12:27:22.1367983+04:30', NULL, N'System Defined'),
    (CAST(13 AS bigint), '2021-11-29T12:27:22.1368017+04:30', NULL, N'', N'Website', 1, '2021-11-29T12:27:22.1368019+04:30', NULL, N'System Defined'),
    (CAST(12 AS bigint), '2021-11-29T12:27:22.1368022+04:30', NULL, N'', N'Software', 1, '2021-11-29T12:27:22.1368024+04:30', NULL, N'System Defined'),
    (CAST(22 AS bigint), '2021-11-29T12:27:22.1367938+04:30', NULL, N'', N'Electricity', 1, '2021-11-29T12:27:22.1367948+04:30', NULL, N'System Defined'),
    (CAST(21 AS bigint), '2021-11-29T12:27:22.1367975+04:30', NULL, N'', N'Gas', 1, '2021-11-29T12:27:22.1367978+04:30', NULL, N'System Defined'),
    (CAST(19 AS bigint), '2021-11-29T12:27:22.1367986+04:30', NULL, N'', N'Air conditioning', 1, '2021-11-29T12:27:22.1367988+04:30', NULL, N'System Defined'),
    (CAST(23 AS bigint), '2021-11-29T12:27:22.1366190+04:30', NULL, N'', N'Rent ', 1, '2021-11-29T12:27:22.1366204+04:30', NULL, N'System Defined'),
    (CAST(17 AS bigint), '2021-11-29T12:27:22.1367996+04:30', NULL, N'', N'Cellphones', 1, '2021-11-29T12:27:22.1367999+04:30', NULL, N'System Defined'),
    (CAST(16 AS bigint), '2021-11-29T12:27:22.1368002+04:30', NULL, N'Track your spending on pens, folders, disinfectant wipes, trash bags, and other cleaning supplies', N'Office supplies', 1, '2021-11-29T12:27:22.1368004+04:30', NULL, N'System Defined'),
    (CAST(15 AS bigint), '2021-11-29T12:27:22.1368008+04:30', NULL, N'', N'Advertising', 1, '2021-11-29T12:27:22.1368010+04:30', NULL, N'System Defined'),
    (CAST(14 AS bigint), '2021-11-29T12:27:22.1368013+04:30', NULL, N'', N'marketing', 1, '2021-11-29T12:27:22.1368015+04:30', NULL, N'System Defined'),
    (CAST(18 AS bigint), '2021-11-29T12:27:22.1367991+04:30', NULL, N'', N'Trash', 1, '2021-11-29T12:27:22.1367993+04:30', NULL, N'System Defined');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedAt', N'DeletedAt', N'Description', N'Name', N'Status', N'UpdatedAt', N'UserId', N'UserName') AND [object_id] = OBJECT_ID(N'[wms_expense_category_tbl]'))
        SET IDENTITY_INSERT [wms_expense_category_tbl] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129075724_EmployeeSalaryies')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CountryName', N'CreatedAt', N'DeletedAt', N'Description', N'Name', N'Status', N'UpdatedAt', N'UserId', N'UserName') AND [object_id] = OBJECT_ID(N'[wms_manufacturer_tbl]'))
        SET IDENTITY_INSERT [wms_manufacturer_tbl] ON;
    INSERT INTO [wms_manufacturer_tbl] ([Id], [CountryName], [CreatedAt], [DeletedAt], [Description], [Name], [Status], [UpdatedAt], [UserId], [UserName])
    VALUES (CAST(26 AS bigint), N'Pakistan', '2021-11-29T12:27:22.1355483+04:30', NULL, N'Pakistan', N'Hilton Pharma ', 1, '2021-11-29T12:27:22.1355486+04:30', NULL, N'System_Populated'),
    (CAST(34 AS bigint), N'Pakistan', '2021-11-29T12:27:22.1355542+04:30', NULL, N'Pakistan', N'Sanofi', 1, '2021-11-29T12:27:22.1355545+04:30', NULL, N'System_Populated'),
    (CAST(27 AS bigint), N'Pakistan', '2021-11-29T12:27:22.1355490+04:30', NULL, N'Pakistan', N' Ferozsons Laboratorie', 1, '2021-11-29T12:27:22.1355493+04:30', NULL, N'System_Populated'),
    (CAST(28 AS bigint), N'Pakistan', '2021-11-29T12:27:22.1355497+04:30', NULL, N'Pakistan', N'Pfizer Pakistan', 1, '2021-11-29T12:27:22.1355500+04:30', NULL, N'System_Populated'),
    (CAST(29 AS bigint), N'Pakistan', '2021-11-29T12:27:22.1355505+04:30', NULL, N'Pakistan', N'Bayer - pK', 1, '2021-11-29T12:27:22.1355507+04:30', NULL, N'System_Populated'),
    (CAST(30 AS bigint), N'Pakistan', '2021-11-29T12:27:22.1355512+04:30', NULL, N'Pakistan', N'Macter pharma', 1, '2021-11-29T12:27:22.1355514+04:30', NULL, N'System_Populated'),
    (CAST(31 AS bigint), N'Pakistan', '2021-11-29T12:27:22.1355519+04:30', NULL, N'Pakistan', N'PharmEvo', 1, '2021-11-29T12:27:22.1355521+04:30', NULL, N'System_Populated'),
    (CAST(32 AS bigint), N'Pakistan', '2021-11-29T12:27:22.1355525+04:30', NULL, N'Pakistan', N'Martin Dow', 1, '2021-11-29T12:27:22.1355528+04:30', NULL, N'System_Populated'),
    (CAST(33 AS bigint), N'Pakistan', '2021-11-29T12:27:22.1355533+04:30', NULL, N'Pakistan', N'Novartis', 1, '2021-11-29T12:27:22.1355536+04:30', NULL, N'System_Populated'),
    (CAST(35 AS bigint), N'Pakistan', '2021-11-29T12:27:22.1355549+04:30', NULL, N'Pakistan', N'Bosch pharma', 1, '2021-11-29T12:27:22.1355552+04:30', NULL, N'System_Populated'),
    (CAST(40 AS bigint), N'India', '2021-11-29T12:27:22.1355592+04:30', NULL, N'India', N'Torrent Pharmaceuticals', 1, '2021-11-29T12:27:22.1355595+04:30', NULL, N'System_Populated'),
    (CAST(36 AS bigint), N'India', '2021-11-29T12:27:22.1355562+04:30', NULL, N'India', N'Dr. Reddy’s Laboratories Ltd', 1, '2021-11-29T12:27:22.1355566+04:30', NULL, N'System_Populated'),
    (CAST(37 AS bigint), N'India', '2021-11-29T12:27:22.1355570+04:30', NULL, N'India', N'Divi’s Laboratories', 1, '2021-11-29T12:27:22.1355573+04:30', NULL, N'System_Populated'),
    (CAST(38 AS bigint), N'India', '2021-11-29T12:27:22.1355577+04:30', NULL, N'India', N'Cipla', 1, '2021-11-29T12:27:22.1355580+04:30', NULL, N'System_Populated'),
    (CAST(39 AS bigint), N'India', '2021-11-29T12:27:22.1355585+04:30', NULL, N'India', N'Aurobindo Pharma', 1, '2021-11-29T12:27:22.1355588+04:30', NULL, N'System_Populated'),
    (CAST(41 AS bigint), N'India', '2021-11-29T12:27:22.1355599+04:30', NULL, N'India', N'Lupin Ltd', 1, '2021-11-29T12:27:22.1355602+04:30', NULL, N'System_Populated'),
    (CAST(42 AS bigint), N'India', '2021-11-29T12:27:22.1355606+04:30', NULL, N'India', N'Zydus Cadila Healthcare', 1, '2021-11-29T12:27:22.1355609+04:30', NULL, N'System_Populated'),
    (CAST(43 AS bigint), N'India', '2021-11-29T12:27:22.1355613+04:30', NULL, N'India', N'Abbott India', 1, '2021-11-29T12:27:22.1355616+04:30', NULL, N'System_Populated'),
    (CAST(44 AS bigint), N'India', '2021-11-29T12:27:22.1355620+04:30', NULL, N'India', N'Alkem Laboratories', 1, '2021-11-29T12:27:22.1355623+04:30', NULL, N'System_Populated'),
    (CAST(46 AS bigint), N'India', '2021-11-29T12:27:22.1355635+04:30', NULL, N'India', N'Lupin', 1, '2021-11-29T12:27:22.1355638+04:30', NULL, N'System_Populated'),
    (CAST(25 AS bigint), N'Pakistan', '2021-11-29T12:27:22.1355475+04:30', NULL, N'Pakistan', N' Sami Pharmaceutical', 1, '2021-11-29T12:27:22.1355478+04:30', NULL, N'System_Populated'),
    (CAST(47 AS bigint), N'India', '2021-11-29T12:27:22.1355555+04:30', NULL, N'India', N'Sun Pharmaceutical Industries Ltd', 1, '2021-11-29T12:27:22.1355558+04:30', NULL, N'System_Populated'),
    (CAST(24 AS bigint), N'Pakistan', '2021-11-29T12:27:22.1355468+04:30', NULL, N'Pakistan', N' Abbott Laboratories ', 1, '2021-11-29T12:27:22.1355471+04:30', NULL, N'System_Populated'),
    (CAST(45 AS bigint), N'India', '2021-11-29T12:27:22.1355628+04:30', NULL, N'India', N'Glenmark Pharmaceuticals Ltd', 1, '2021-11-29T12:27:22.1355631+04:30', NULL, N'System_Populated'),
    (CAST(22 AS bigint), N'Pakistan', '2021-11-29T12:27:22.1355454+04:30', NULL, N'Pakistan', N'GlaxoSmithKline', 1, '2021-11-29T12:27:22.1355456+04:30', NULL, N'System_Populated'),
    (CAST(23 AS bigint), N'Pakistan', '2021-11-29T12:27:22.1355461+04:30', NULL, N'Pakistan', N'Getz Pharma (Private) Limited', 1, '2021-11-29T12:27:22.1355464+04:30', NULL, N'System_Populated'),
    (CAST(1 AS bigint), N'Iran', '2021-11-29T12:27:22.1355164+04:30', NULL, N'Iran', N'DAROU PAKHSH FACTORIES - IR', 1, '2021-11-29T12:27:22.1355179+04:30', NULL, N'System_Populated'),
    (CAST(2 AS bigint), N'Iran', '2021-11-29T12:27:22.1355304+04:30', NULL, N'Iran', N'SOBHAN PHARMACEUTICAL - IR', 1, '2021-11-29T12:27:22.1355307+04:30', NULL, N'System_Populated'),
    (CAST(3 AS bigint), N'Iran', '2021-11-29T12:27:22.1355312+04:30', NULL, N'Iran', N'SINA DAROU LABORATORIES - IR', 1, '2021-11-29T12:27:22.1355315+04:30', NULL, N'System_Populated'),
    (CAST(4 AS bigint), N'Iran', '2021-11-29T12:27:22.1355319+04:30', NULL, N'Iran', N'CINNAGEN - IR', 1, '2021-11-29T12:27:22.1355323+04:30', NULL, N'System_Populated'),
    (CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1355327+04:30', NULL, N'Iran', N'BEHESTAN PLASMA COMPANY-IR ', 1, '2021-11-29T12:27:22.1355330+04:30', NULL, N'System_Populated'),
    (CAST(7 AS bigint), N'Iran', '2021-11-29T12:27:22.1355344+04:30', NULL, N'Iran', N'PISHTAZ TEB ZAMAN - IR', 1, '2021-11-29T12:27:22.1355347+04:30', NULL, N'System_Populated'),
    (CAST(8 AS bigint), N'Iran', '2021-11-29T12:27:22.1355351+04:30', NULL, N'Iran', N'PARTO SALAMAT ROUZ - IR', 1, '2021-11-29T12:27:22.1355354+04:30', NULL, N'System_Populated'),
    (CAST(9 AS bigint), N'Iran', '2021-11-29T12:27:22.1355359+04:30', NULL, N'Iran', N'DR. ABIDI PHARMACEUTICALS -IR', 1, '2021-11-29T12:27:22.1355362+04:30', NULL, N'System_Populated'),
    (CAST(10 AS bigint), N'Iran', '2021-11-29T12:27:22.1355366+04:30', NULL, N'Iran', N'FARABI PHARMACEUTICALS CO -IR', 1, '2021-11-29T12:27:22.1355369+04:30', NULL, N'System_Populated'),
    (CAST(6 AS bigint), N'Iran', '2021-11-29T12:27:22.1355337+04:30', NULL, N'Iran', N'CASPIAN TAMIN PHARMACEUTICAL CO -IR', 1, '2021-11-29T12:27:22.1355340+04:30', NULL, N'System_Populated'),
    (CAST(12 AS bigint), N'Iran', '2021-11-29T12:27:22.1355380+04:30', NULL, N'Iran', N'ARASTO PHARMACEUTICAL CHEMICAL INC -IR', 1, '2021-11-29T12:27:22.1355383+04:30', NULL, N'System_Populated'),
    (CAST(21 AS bigint), N'Turkey', '2021-11-29T12:27:22.1355446+04:30', NULL, N'Turkey', N'Dora Pharma LLC', 1, '2021-11-29T12:27:22.1355449+04:30', NULL, N'System_Populated'),
    (CAST(11 AS bigint), N'Iran', '2021-11-29T12:27:22.1355373+04:30', NULL, N'Iran', N'ALMAGEN DAROU -IR', 1, '2021-11-29T12:27:22.1355376+04:30', NULL, N'System_Populated'),
    (CAST(19 AS bigint), N'Turkey', '2021-11-29T12:27:22.1355432+04:30', NULL, N'Turkey', N'Halfa Medical -TUR', 1, '2021-11-29T12:27:22.1355435+04:30', NULL, N'System_Populated'),
    (CAST(18 AS bigint), N'Turkey', '2021-11-29T12:27:22.1355425+04:30', NULL, N'Turkey', N'MS Pharma İlaç - TUR', 1, '2021-11-29T12:27:22.1355428+04:30', NULL, N'System_Populated'),
    (CAST(17 AS bigint), N'Turkey', '2021-11-29T12:27:22.1355417+04:30', NULL, N'Turkey', N'Directorate General of Drug Pharmactiv - TUR', 1, '2021-11-29T12:27:22.1355420+04:30', NULL, N'System_Populated'),
    (CAST(20 AS bigint), N'Turkey', '2021-11-29T12:27:22.1355439+04:30', NULL, N'Turkey', N'Hamle Pharma Trade -TUR', 1, '2021-11-29T12:27:22.1355442+04:30', NULL, N'System_Populated'),
    (CAST(15 AS bigint), N'Turkey', '2021-11-29T12:27:22.1355402+04:30', NULL, N'Elbi Pharmaceutical Warehouse provides the delivery of medicines and medical supplies around the world with a wide range of products.', N'Elbi Pharmaceutical Wholesale Warehouse - TUR', 1, '2021-11-29T12:27:22.1355405+04:30', NULL, N'System_Populated'),
    (CAST(14 AS bigint), N'Turkey', '2021-11-29T12:27:22.1355395+04:30', NULL, N'established in 1947. The company is engaged in manufacturing and selling of pharmaceutical products. Its products include dermatology, gastrointestinal and metabolism, hematology, immune, cardiovascular, muscle and skeleton, radiology, central nervous, respiratory, and urogenital medicines.', N'Santa Farma Ilac - TUR', 1, '2021-11-29T12:27:22.1355398+04:30', NULL, N'System_Populated'),
    (CAST(13 AS bigint), N'Iran', '2021-11-29T12:27:22.1355387+04:30', NULL, N'Iran', N'MELLI AGRO CHEMICAL -IR', 1, '2021-11-29T12:27:22.1355390+04:30', NULL, N'System_Populated'),
    (CAST(16 AS bigint), N'Turkey', '2021-11-29T12:27:22.1355409+04:30', NULL, N'Imuneks Farma is a pharmaceutical company that dates back to Mustafa Nevzat Pharmaceuticals’ establishment in 1923', N'İmuneks Farma - TUR', 1, '2021-11-29T12:27:22.1355412+04:30', NULL, N'System_Populated');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CountryName', N'CreatedAt', N'DeletedAt', N'Description', N'Name', N'Status', N'UpdatedAt', N'UserId', N'UserName') AND [object_id] = OBJECT_ID(N'[wms_manufacturer_tbl]'))
        SET IDENTITY_INSERT [wms_manufacturer_tbl] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129075724_EmployeeSalaryies')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CategoryName', N'CreatedAt', N'DeletedAt', N'Description', N'Status', N'TypeName', N'UpdatedAt', N'UserId', N'UserName') AND [object_id] = OBJECT_ID(N'[wms_product_type_tbl]'))
        SET IDENTITY_INSERT [wms_product_type_tbl] ON;
    INSERT INTO [wms_product_type_tbl] ([Id], [CategoryName], [CreatedAt], [DeletedAt], [Description], [Status], [TypeName], [UpdatedAt], [UserId], [UserName])
    VALUES (CAST(144 AS bigint), N'Antiemetics', '2021-11-29T12:27:22.1336969+04:30', NULL, N'', 1, N'I.V Infusion', '2021-11-29T12:27:22.1336971+04:30', NULL, N'System Defined'),
    (CAST(135 AS bigint), N'Antiemetics', '2021-11-29T12:27:22.1336924+04:30', NULL, N'', 1, N'Elixir', '2021-11-29T12:27:22.1336928+04:30', NULL, N'System Defined'),
    (CAST(136 AS bigint), N'Antiemetics', '2021-11-29T12:27:22.1336930+04:30', NULL, N'', 1, N'Suppository', '2021-11-29T12:27:22.1336932+04:30', NULL, N'System Defined'),
    (CAST(137 AS bigint), N'Antiemetics', '2021-11-29T12:27:22.1336935+04:30', NULL, N'', 1, N'Ampoules', '2021-11-29T12:27:22.1336937+04:30', NULL, N'System Defined'),
    (CAST(138 AS bigint), N'Antiemetics', '2021-11-29T12:27:22.1336940+04:30', NULL, N'', 1, N'Suspension', '2021-11-29T12:27:22.1336942+04:30', NULL, N'System Defined'),
    (CAST(139 AS bigint), N'Antiemetics', '2021-11-29T12:27:22.1336945+04:30', NULL, N'', 1, N'Oily', '2021-11-29T12:27:22.1336947+04:30', NULL, N'System Defined'),
    (CAST(140 AS bigint), N'Antiemetics', '2021-11-29T12:27:22.1336950+04:30', NULL, N'', 1, N'Cream', '2021-11-29T12:27:22.1336952+04:30', NULL, N'System Defined'),
    (CAST(141 AS bigint), N'Antiemetics', '2021-11-29T12:27:22.1336955+04:30', NULL, N'', 1, N'Gel/Lotion', '2021-11-29T12:27:22.1336957+04:30', NULL, N'System Defined'),
    (CAST(142 AS bigint), N'Antiemetics', '2021-11-29T12:27:22.1336960+04:30', NULL, N'', 1, N'Dispersible', '2021-11-29T12:27:22.1336962+04:30', NULL, N'System Defined'),
    (CAST(143 AS bigint), N'Antiemetics', '2021-11-29T12:27:22.1336965+04:30', NULL, N'', 1, N'Chewable', '2021-11-29T12:27:22.1336967+04:30', NULL, N'System Defined'),
    (CAST(145 AS bigint), N'Antiemetics', '2021-11-29T12:27:22.1336975+04:30', NULL, N'', 1, N'Ointment', '2021-11-29T12:27:22.1336977+04:30', NULL, N'System Defined'),
    (CAST(155 AS bigint), N'Antifungals', '2021-11-29T12:27:22.1337026+04:30', NULL, N'', 1, N'Ointment', '2021-11-29T12:27:22.1337028+04:30', NULL, N'System Defined'),
    (CAST(147 AS bigint), N'Antiemetics', '2021-11-29T12:27:22.1336985+04:30', NULL, N'', 1, N'Implant Capsule', '2021-11-29T12:27:22.1336987+04:30', NULL, N'System Defined'),
    (CAST(148 AS bigint), N'Antifungals', '2021-11-29T12:27:22.1336990+04:30', NULL, N'', 1, N'Liquid', '2021-11-29T12:27:22.1336992+04:30', NULL, N'System Defined'),
    (CAST(149 AS bigint), N'Antifungals', '2021-11-29T12:27:22.1336996+04:30', NULL, N'', 1, N'Tablet', '2021-11-29T12:27:22.1336998+04:30', NULL, N'System Defined'),
    (CAST(150 AS bigint), N'Antifungals', '2021-11-29T12:27:22.1337000+04:30', NULL, N'', 1, N'Capsules', '2021-11-29T12:27:22.1337002+04:30', NULL, N'System Defined'),
    (CAST(151 AS bigint), N'Antifungals', '2021-11-29T12:27:22.1337005+04:30', NULL, N'', 1, N'Drops', '2021-11-29T12:27:22.1337007+04:30', NULL, N'System Defined'),
    (CAST(152 AS bigint), N'Antifungals', '2021-11-29T12:27:22.1337010+04:30', NULL, N'', 1, N'Inhalers', '2021-11-29T12:27:22.1337013+04:30', NULL, N'System Defined'),
    (CAST(153 AS bigint), N'Antifungals', '2021-11-29T12:27:22.1337015+04:30', NULL, N'', 1, N'Injections', '2021-11-29T12:27:22.1337018+04:30', NULL, N'System Defined'),
    (CAST(154 AS bigint), N'Antifungals', '2021-11-29T12:27:22.1337021+04:30', NULL, N'', 1, N'Powder', '2021-11-29T12:27:22.1337023+04:30', NULL, N'System Defined'),
    (CAST(134 AS bigint), N'Antiemetics', '2021-11-29T12:27:22.1336920+04:30', NULL, N'', 1, N'Ointment', '2021-11-29T12:27:22.1336922+04:30', NULL, N'System Defined'),
    (CAST(156 AS bigint), N'Antifungals', '2021-11-29T12:27:22.1337031+04:30', NULL, N'', 1, N'Elixir', '2021-11-29T12:27:22.1337033+04:30', NULL, N'System Defined'),
    (CAST(146 AS bigint), N'Antiemetics', '2021-11-29T12:27:22.1336980+04:30', NULL, N'', 1, N'Liposomal', '2021-11-29T12:27:22.1336982+04:30', NULL, N'System Defined'),
    (CAST(133 AS bigint), N'Antiemetics', '2021-11-29T12:27:22.1336914+04:30', NULL, N'', 1, N'Powder', '2021-11-29T12:27:22.1336916+04:30', NULL, N'System Defined'),
    (CAST(122 AS bigint), N'Antidotes', '2021-11-29T12:27:22.1336858+04:30', NULL, N'', 1, N'Chewable', '2021-11-29T12:27:22.1336860+04:30', NULL, N'System Defined'),
    (CAST(131 AS bigint), N'Antiemetics', '2021-11-29T12:27:22.1336904+04:30', NULL, N'', 1, N'Inhalers', '2021-11-29T12:27:22.1336906+04:30', NULL, N'System Defined'),
    (CAST(108 AS bigint), N'Antidotes', '2021-11-29T12:27:22.1336741+04:30', NULL, N'', 1, N'Capsules', '2021-11-29T12:27:22.1336743+04:30', NULL, N'System Defined'),
    (CAST(109 AS bigint), N'Antidotes', '2021-11-29T12:27:22.1336747+04:30', NULL, N'', 1, N'Drops', '2021-11-29T12:27:22.1336749+04:30', NULL, N'System Defined'),
    (CAST(110 AS bigint), N'Antidotes', '2021-11-29T12:27:22.1336752+04:30', NULL, N'', 1, N'Inhalers', '2021-11-29T12:27:22.1336754+04:30', NULL, N'System Defined'),
    (CAST(111 AS bigint), N'Antidotes', '2021-11-29T12:27:22.1336757+04:30', NULL, N'', 1, N'Injections', '2021-11-29T12:27:22.1336759+04:30', NULL, N'System Defined'),
    (CAST(112 AS bigint), N'Antidotes', '2021-11-29T12:27:22.1336762+04:30', NULL, N'', 1, N'Powder', '2021-11-29T12:27:22.1336764+04:30', NULL, N'System Defined'),
    (CAST(113 AS bigint), N'Antidotes', '2021-11-29T12:27:22.1336812+04:30', NULL, N'', 1, N'Ointment', '2021-11-29T12:27:22.1336814+04:30', NULL, N'System Defined'),
    (CAST(114 AS bigint), N'Antidotes', '2021-11-29T12:27:22.1336817+04:30', NULL, N'', 1, N'Elixir', '2021-11-29T12:27:22.1336819+04:30', NULL, N'System Defined'),
    (CAST(115 AS bigint), N'Antidotes', '2021-11-29T12:27:22.1336822+04:30', NULL, N'', 1, N'Suppository', '2021-11-29T12:27:22.1336824+04:30', NULL, N'System Defined'),
    (CAST(116 AS bigint), N'Antidotes', '2021-11-29T12:27:22.1336828+04:30', NULL, N'', 1, N'Ampoules', '2021-11-29T12:27:22.1336830+04:30', NULL, N'System Defined'),
    (CAST(117 AS bigint), N'Antidotes', '2021-11-29T12:27:22.1336833+04:30', NULL, N'', 1, N'Suspension', '2021-11-29T12:27:22.1336835+04:30', NULL, N'System Defined'),
    (CAST(118 AS bigint), N'Antidotes', '2021-11-29T12:27:22.1336838+04:30', NULL, N'', 1, N'Oily', '2021-11-29T12:27:22.1336840+04:30', NULL, N'System Defined'),
    (CAST(119 AS bigint), N'Antidotes', '2021-11-29T12:27:22.1336843+04:30', NULL, N'', 1, N'Cream', '2021-11-29T12:27:22.1336845+04:30', NULL, N'System Defined'),
    (CAST(120 AS bigint), N'Antidotes', '2021-11-29T12:27:22.1336848+04:30', NULL, N'', 1, N'Gel/Lotion', '2021-11-29T12:27:22.1336850+04:30', NULL, N'System Defined'),
    (CAST(121 AS bigint), N'Antidotes', '2021-11-29T12:27:22.1336853+04:30', NULL, N'', 1, N'Dispersible', '2021-11-29T12:27:22.1336855+04:30', NULL, N'System Defined'),
    (CAST(157 AS bigint), N'Antifungals', '2021-11-29T12:27:22.1337036+04:30', NULL, N'', 1, N'Suppository', '2021-11-29T12:27:22.1337038+04:30', NULL, N'System Defined'),
    (CAST(123 AS bigint), N'Antidotes', '2021-11-29T12:27:22.1336863+04:30', NULL, N'', 1, N'I.V Infusion', '2021-11-29T12:27:22.1336865+04:30', NULL, N'System Defined'),
    (CAST(124 AS bigint), N'Antidotes', '2021-11-29T12:27:22.1336868+04:30', NULL, N'', 1, N'Ointment', '2021-11-29T12:27:22.1336870+04:30', NULL, N'System Defined'),
    (CAST(125 AS bigint), N'Antidotes', '2021-11-29T12:27:22.1336873+04:30', NULL, N'', 1, N'Liposomal', '2021-11-29T12:27:22.1336875+04:30', NULL, N'System Defined'),
    (CAST(126 AS bigint), N'Antidotes', '2021-11-29T12:27:22.1336879+04:30', NULL, N'', 1, N'Implant Capsule', '2021-11-29T12:27:22.1336881+04:30', NULL, N'System Defined'),
    (CAST(127 AS bigint), N'Antiemetics', '2021-11-29T12:27:22.1336884+04:30', NULL, N'', 1, N'Liquid', '2021-11-29T12:27:22.1336886+04:30', NULL, N'System Defined'),
    (CAST(128 AS bigint), N'Antiemetics', '2021-11-29T12:27:22.1336889+04:30', NULL, N'', 1, N'Tablet', '2021-11-29T12:27:22.1336891+04:30', NULL, N'System Defined'),
    (CAST(129 AS bigint), N'Antiemetics', '2021-11-29T12:27:22.1336894+04:30', NULL, N'', 1, N'Capsules', '2021-11-29T12:27:22.1336896+04:30', NULL, N'System Defined'),
    (CAST(130 AS bigint), N'Antiemetics', '2021-11-29T12:27:22.1336899+04:30', NULL, N'', 1, N'Drops', '2021-11-29T12:27:22.1336901+04:30', NULL, N'System Defined'),
    (CAST(132 AS bigint), N'Antiemetics', '2021-11-29T12:27:22.1336909+04:30', NULL, N'', 1, N'Injections', '2021-11-29T12:27:22.1336911+04:30', NULL, N'System Defined'),
    (CAST(158 AS bigint), N'Antifungals', '2021-11-29T12:27:22.1337041+04:30', NULL, N'', 1, N'Ampoules', '2021-11-29T12:27:22.1337043+04:30', NULL, N'System Defined'),
    (CAST(170 AS bigint), N'Anxiolytic', '2021-11-29T12:27:22.1337104+04:30', NULL, N'', 1, N'Tablet', '2021-11-29T12:27:22.1337106+04:30', NULL, N'System Defined'),
    (CAST(160 AS bigint), N'Antifungals', '2021-11-29T12:27:22.1337051+04:30', NULL, N'', 1, N'Oily', '2021-11-29T12:27:22.1337053+04:30', NULL, N'System Defined'),
    (CAST(189 AS bigint), N'Anxiolytic', '2021-11-29T12:27:22.1337245+04:30', NULL, N'', 1, N'Implant Capsule', '2021-11-29T12:27:22.1337247+04:30', NULL, N'System Defined'),
    (CAST(190 AS bigint), N'Enzymya', '2021-11-29T12:27:22.1337250+04:30', NULL, N'', 1, N'Liquid', '2021-11-29T12:27:22.1337252+04:30', NULL, N'System Defined'),
    (CAST(191 AS bigint), N'Enzymya', '2021-11-29T12:27:22.1337255+04:30', NULL, N'', 1, N'Tablet', '2021-11-29T12:27:22.1337257+04:30', NULL, N'System Defined'),
    (CAST(192 AS bigint), N'Enzymya', '2021-11-29T12:27:22.1337260+04:30', NULL, N'', 1, N'Capsules', '2021-11-29T12:27:22.1337262+04:30', NULL, N'System Defined'),
    (CAST(193 AS bigint), N'Enzymya', '2021-11-29T12:27:22.1337265+04:30', NULL, N'', 1, N'Drops', '2021-11-29T12:27:22.1337267+04:30', NULL, N'System Defined'),
    (CAST(194 AS bigint), N'Enzymya', '2021-11-29T12:27:22.1337271+04:30', NULL, N'', 1, N'Inhalers', '2021-11-29T12:27:22.1337273+04:30', NULL, N'System Defined'),
    (CAST(195 AS bigint), N'Enzymya', '2021-11-29T12:27:22.1337276+04:30', NULL, N'', 1, N'Injections', '2021-11-29T12:27:22.1337278+04:30', NULL, N'System Defined'),
    (CAST(196 AS bigint), N'Enzymya', '2021-11-29T12:27:22.1337281+04:30', NULL, N'', 1, N'Powder', '2021-11-29T12:27:22.1337283+04:30', NULL, N'System Defined'),
    (CAST(197 AS bigint), N'Enzymya', '2021-11-29T12:27:22.1337286+04:30', NULL, N'', 1, N'Ointment', '2021-11-29T12:27:22.1337288+04:30', NULL, N'System Defined'),
    (CAST(198 AS bigint), N'Enzymya', '2021-11-29T12:27:22.1337291+04:30', NULL, N'', 1, N'Elixir', '2021-11-29T12:27:22.1337293+04:30', NULL, N'System Defined'),
    (CAST(199 AS bigint), N'Enzymya', '2021-11-29T12:27:22.1337296+04:30', NULL, N'', 1, N'Suppository', '2021-11-29T12:27:22.1337298+04:30', NULL, N'System Defined'),
    (CAST(200 AS bigint), N'Enzymya', '2021-11-29T12:27:22.1337301+04:30', NULL, N'', 1, N'Ampoules', '2021-11-29T12:27:22.1337303+04:30', NULL, N'System Defined'),
    (CAST(201 AS bigint), N'Enzymya', '2021-11-29T12:27:22.1337306+04:30', NULL, N'', 1, N'Suspension', '2021-11-29T12:27:22.1337309+04:30', NULL, N'System Defined'),
    (CAST(202 AS bigint), N'Enzymya', '2021-11-29T12:27:22.1337312+04:30', NULL, N'', 1, N'Oily', '2021-11-29T12:27:22.1337314+04:30', NULL, N'System Defined'),
    (CAST(203 AS bigint), N'Enzymya', '2021-11-29T12:27:22.1337317+04:30', NULL, N'', 1, N'Cream', '2021-11-29T12:27:22.1337319+04:30', NULL, N'System Defined'),
    (CAST(204 AS bigint), N'Enzymya', '2021-11-29T12:27:22.1337322+04:30', NULL, N'', 1, N'Gel/Lotion', '2021-11-29T12:27:22.1337324+04:30', NULL, N'System Defined'),
    (CAST(205 AS bigint), N'Enzymya', '2021-11-29T12:27:22.1337327+04:30', NULL, N'', 1, N'Dispersible', '2021-11-29T12:27:22.1337329+04:30', NULL, N'System Defined'),
    (CAST(206 AS bigint), N'Enzymya', '2021-11-29T12:27:22.1337332+04:30', NULL, N'', 1, N'Chewable', '2021-11-29T12:27:22.1337334+04:30', NULL, N'System Defined'),
    (CAST(207 AS bigint), N'Enzymya', '2021-11-29T12:27:22.1337337+04:30', NULL, N'', 1, N'I.V Infusion', '2021-11-29T12:27:22.1337339+04:30', NULL, N'System Defined'),
    (CAST(208 AS bigint), N'Enzymya', '2021-11-29T12:27:22.1337343+04:30', NULL, N'', 1, N'Ointment', '2021-11-29T12:27:22.1337345+04:30', NULL, N'System Defined'),
    (CAST(209 AS bigint), N'Enzymya', '2021-11-29T12:27:22.1337348+04:30', NULL, N'', 1, N'Liposomal', '2021-11-29T12:27:22.1337350+04:30', NULL, N'System Defined'),
    (CAST(210 AS bigint), N'Enzymya', '2021-11-29T12:27:22.1337354+04:30', NULL, N'', 1, N'Implant Capsule', '2021-11-29T12:27:22.1337356+04:30', NULL, N'System Defined'),
    (CAST(107 AS bigint), N'Antidotes', '2021-11-29T12:27:22.1336736+04:30', NULL, N'', 1, N'Tablet', '2021-11-29T12:27:22.1336738+04:30', NULL, N'System Defined'),
    (CAST(188 AS bigint), N'Anxiolytic', '2021-11-29T12:27:22.1337240+04:30', NULL, N'', 1, N'Liposomal', '2021-11-29T12:27:22.1337242+04:30', NULL, N'System Defined'),
    (CAST(159 AS bigint), N'Antifungals', '2021-11-29T12:27:22.1337046+04:30', NULL, N'', 1, N'Suspension', '2021-11-29T12:27:22.1337048+04:30', NULL, N'System Defined'),
    (CAST(187 AS bigint), N'Anxiolytic', '2021-11-29T12:27:22.1337235+04:30', NULL, N'', 1, N'Ointment', '2021-11-29T12:27:22.1337237+04:30', NULL, N'System Defined'),
    (CAST(185 AS bigint), N'Anxiolytic', '2021-11-29T12:27:22.1337225+04:30', NULL, N'', 1, N'Chewable', '2021-11-29T12:27:22.1337227+04:30', NULL, N'System Defined'),
    (CAST(161 AS bigint), N'Antifungals', '2021-11-29T12:27:22.1337056+04:30', NULL, N'', 1, N'Cream', '2021-11-29T12:27:22.1337058+04:30', NULL, N'System Defined'),
    (CAST(162 AS bigint), N'Antifungals', '2021-11-29T12:27:22.1337062+04:30', NULL, N'', 1, N'Gel/Lotion', '2021-11-29T12:27:22.1337064+04:30', NULL, N'System Defined'),
    (CAST(163 AS bigint), N'Antifungals', '2021-11-29T12:27:22.1337066+04:30', NULL, N'', 1, N'Dispersible', '2021-11-29T12:27:22.1337069+04:30', NULL, N'System Defined'),
    (CAST(164 AS bigint), N'Antifungals', '2021-11-29T12:27:22.1337072+04:30', NULL, N'', 1, N'Chewable', '2021-11-29T12:27:22.1337074+04:30', NULL, N'System Defined'),
    (CAST(165 AS bigint), N'Antifungals', '2021-11-29T12:27:22.1337078+04:30', NULL, N'', 1, N'I.V Infusion', '2021-11-29T12:27:22.1337079+04:30', NULL, N'System Defined'),
    (CAST(166 AS bigint), N'Antifungals', '2021-11-29T12:27:22.1337082+04:30', NULL, N'', 1, N'Ointment', '2021-11-29T12:27:22.1337084+04:30', NULL, N'System Defined'),
    (CAST(167 AS bigint), N'Antifungals', '2021-11-29T12:27:22.1337087+04:30', NULL, N'', 1, N'Liposomal', '2021-11-29T12:27:22.1337089+04:30', NULL, N'System Defined'),
    (CAST(168 AS bigint), N'Antifungals', '2021-11-29T12:27:22.1337094+04:30', NULL, N'', 1, N'Implant Capsule', '2021-11-29T12:27:22.1337096+04:30', NULL, N'System Defined'),
    (CAST(169 AS bigint), N'Anxiolytic', '2021-11-29T12:27:22.1337099+04:30', NULL, N'', 1, N'Liquid', '2021-11-29T12:27:22.1337101+04:30', NULL, N'System Defined'),
    (CAST(171 AS bigint), N'Anxiolytic', '2021-11-29T12:27:22.1337109+04:30', NULL, N'', 1, N'Capsules', '2021-11-29T12:27:22.1337111+04:30', NULL, N'System Defined'),
    (CAST(172 AS bigint), N'Anxiolytic', '2021-11-29T12:27:22.1337114+04:30', NULL, N'', 1, N'Drops', '2021-11-29T12:27:22.1337116+04:30', NULL, N'System Defined'),
    (CAST(173 AS bigint), N'Anxiolytic', '2021-11-29T12:27:22.1337119+04:30', NULL, N'', 1, N'Inhalers', '2021-11-29T12:27:22.1337121+04:30', NULL, N'System Defined'),
    (CAST(174 AS bigint), N'Anxiolytic', '2021-11-29T12:27:22.1337124+04:30', NULL, N'', 1, N'Injections', '2021-11-29T12:27:22.1337127+04:30', NULL, N'System Defined'),
    (CAST(175 AS bigint), N'Anxiolytic', '2021-11-29T12:27:22.1337130+04:30', NULL, N'', 1, N'Powder', '2021-11-29T12:27:22.1337132+04:30', NULL, N'System Defined'),
    (CAST(176 AS bigint), N'Anxiolytic', '2021-11-29T12:27:22.1337135+04:30', NULL, N'', 1, N'Ointment', '2021-11-29T12:27:22.1337137+04:30', NULL, N'System Defined'),
    (CAST(177 AS bigint), N'Anxiolytic', '2021-11-29T12:27:22.1337182+04:30', NULL, N'', 1, N'Elixir', '2021-11-29T12:27:22.1337184+04:30', NULL, N'System Defined'),
    (CAST(178 AS bigint), N'Anxiolytic', '2021-11-29T12:27:22.1337187+04:30', NULL, N'', 1, N'Suppository', '2021-11-29T12:27:22.1337189+04:30', NULL, N'System Defined'),
    (CAST(179 AS bigint), N'Anxiolytic', '2021-11-29T12:27:22.1337193+04:30', NULL, N'', 1, N'Ampoules', '2021-11-29T12:27:22.1337195+04:30', NULL, N'System Defined'),
    (CAST(180 AS bigint), N'Anxiolytic', '2021-11-29T12:27:22.1337198+04:30', NULL, N'', 1, N'Suspension', '2021-11-29T12:27:22.1337200+04:30', NULL, N'System Defined'),
    (CAST(181 AS bigint), N'Anxiolytic', '2021-11-29T12:27:22.1337203+04:30', NULL, N'', 1, N'Oily', '2021-11-29T12:27:22.1337206+04:30', NULL, N'System Defined'),
    (CAST(182 AS bigint), N'Anxiolytic', '2021-11-29T12:27:22.1337209+04:30', NULL, N'', 1, N'Cream', '2021-11-29T12:27:22.1337211+04:30', NULL, N'System Defined'),
    (CAST(183 AS bigint), N'Anxiolytic', '2021-11-29T12:27:22.1337214+04:30', NULL, N'', 1, N'Gel/Lotion', '2021-11-29T12:27:22.1337216+04:30', NULL, N'System Defined'),
    (CAST(184 AS bigint), N'Anxiolytic', '2021-11-29T12:27:22.1337220+04:30', NULL, N'', 1, N'Dispersible', '2021-11-29T12:27:22.1337223+04:30', NULL, N'System Defined'),
    (CAST(186 AS bigint), N'Anxiolytic', '2021-11-29T12:27:22.1337230+04:30', NULL, N'', 1, N'I.V Infusion', '2021-11-29T12:27:22.1337232+04:30', NULL, N'System Defined'),
    (CAST(106 AS bigint), N'Antidotes', '2021-11-29T12:27:22.1336731+04:30', NULL, N'', 1, N'Liquid', '2021-11-29T12:27:22.1336733+04:30', NULL, N'System Defined');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CategoryName', N'CreatedAt', N'DeletedAt', N'Description', N'Status', N'TypeName', N'UpdatedAt', N'UserId', N'UserName') AND [object_id] = OBJECT_ID(N'[wms_product_type_tbl]'))
        SET IDENTITY_INSERT [wms_product_type_tbl] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129075724_EmployeeSalaryies')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CategoryName', N'CreatedAt', N'DeletedAt', N'Description', N'Status', N'TypeName', N'UpdatedAt', N'UserId', N'UserName') AND [object_id] = OBJECT_ID(N'[wms_product_type_tbl]'))
        SET IDENTITY_INSERT [wms_product_type_tbl] ON;
    INSERT INTO [wms_product_type_tbl] ([Id], [CategoryName], [CreatedAt], [DeletedAt], [Description], [Status], [TypeName], [UpdatedAt], [UserId], [UserName])
    VALUES (CAST(57 AS bigint), N'Antibacterials', '2021-11-29T12:27:22.1336480+04:30', NULL, N'', 1, N'Gel/Lotion', '2021-11-29T12:27:22.1336485+04:30', NULL, N'System Defined'),
    (CAST(104 AS bigint), N'Antidementia', '2021-11-29T12:27:22.1336720+04:30', NULL, N'', 1, N'Liposomal', '2021-11-29T12:27:22.1336722+04:30', NULL, N'System Defined'),
    (CAST(28 AS bigint), N'Anesthetics', '2021-11-29T12:27:22.1336257+04:30', NULL, N'', 1, N'Powder', '2021-11-29T12:27:22.1336259+04:30', NULL, N'System Defined'),
    (CAST(29 AS bigint), N'Anesthetics', '2021-11-29T12:27:22.1336262+04:30', NULL, N'', 1, N'Ointment', '2021-11-29T12:27:22.1336265+04:30', NULL, N'System Defined'),
    (CAST(30 AS bigint), N'Anesthetics', '2021-11-29T12:27:22.1336268+04:30', NULL, N'', 1, N'Elixir', '2021-11-29T12:27:22.1336270+04:30', NULL, N'System Defined'),
    (CAST(31 AS bigint), N'Anesthetics', '2021-11-29T12:27:22.1336273+04:30', NULL, N'', 1, N'Suppository', '2021-11-29T12:27:22.1336275+04:30', NULL, N'System Defined'),
    (CAST(32 AS bigint), N'Anesthetics', '2021-11-29T12:27:22.1336279+04:30', NULL, N'', 1, N'Ampoules', '2021-11-29T12:27:22.1336282+04:30', NULL, N'System Defined'),
    (CAST(33 AS bigint), N'Anesthetics', '2021-11-29T12:27:22.1336287+04:30', NULL, N'', 1, N'Suspension', '2021-11-29T12:27:22.1336289+04:30', NULL, N'System Defined'),
    (CAST(34 AS bigint), N'Anesthetics', '2021-11-29T12:27:22.1336293+04:30', NULL, N'', 1, N'Oily', '2021-11-29T12:27:22.1336295+04:30', NULL, N'System Defined'),
    (CAST(35 AS bigint), N'Anesthetics', '2021-11-29T12:27:22.1336298+04:30', NULL, N'', 1, N'Cream', '2021-11-29T12:27:22.1336300+04:30', NULL, N'System Defined'),
    (CAST(36 AS bigint), N'Anesthetics', '2021-11-29T12:27:22.1336303+04:30', NULL, N'', 1, N'Gel/Lotion', '2021-11-29T12:27:22.1336305+04:30', NULL, N'System Defined'),
    (CAST(37 AS bigint), N'Anesthetics', '2021-11-29T12:27:22.1336308+04:30', NULL, N'', 1, N'Dispersible', '2021-11-29T12:27:22.1336310+04:30', NULL, N'System Defined'),
    (CAST(27 AS bigint), N'Anesthetics', '2021-11-29T12:27:22.1336251+04:30', NULL, N'', 1, N'Injections', '2021-11-29T12:27:22.1336254+04:30', NULL, N'System Defined'),
    (CAST(38 AS bigint), N'Anesthetics', '2021-11-29T12:27:22.1336314+04:30', NULL, N'', 1, N'Chewable', '2021-11-29T12:27:22.1336316+04:30', NULL, N'System Defined'),
    (CAST(40 AS bigint), N'Anesthetics', '2021-11-29T12:27:22.1336323+04:30', NULL, N'', 1, N'Ointment', '2021-11-29T12:27:22.1336325+04:30', NULL, N'System Defined'),
    (CAST(41 AS bigint), N'Anesthetics', '2021-11-29T12:27:22.1336328+04:30', NULL, N'', 1, N'Liposomal', '2021-11-29T12:27:22.1336331+04:30', NULL, N'System Defined'),
    (CAST(42 AS bigint), N'Anesthetics', '2021-11-29T12:27:22.1336335+04:30', NULL, N'', 1, N'Implant Capsule', '2021-11-29T12:27:22.1336337+04:30', NULL, N'System Defined'),
    (CAST(43 AS bigint), N'Antibacterials', '2021-11-29T12:27:22.1336341+04:30', NULL, N'', 1, N'Liquid', '2021-11-29T12:27:22.1336343+04:30', NULL, N'System Defined'),
    (CAST(44 AS bigint), N'Antibacterials', '2021-11-29T12:27:22.1336346+04:30', NULL, N'', 1, N'Tablet', '2021-11-29T12:27:22.1336348+04:30', NULL, N'System Defined'),
    (CAST(45 AS bigint), N'Antibacterials', '2021-11-29T12:27:22.1336351+04:30', NULL, N'', 1, N'Capsules', '2021-11-29T12:27:22.1336353+04:30', NULL, N'System Defined'),
    (CAST(46 AS bigint), N'Antibacterials', '2021-11-29T12:27:22.1336356+04:30', NULL, N'', 1, N'Drops', '2021-11-29T12:27:22.1336358+04:30', NULL, N'System Defined'),
    (CAST(105 AS bigint), N'Antidementia', '2021-11-29T12:27:22.1336725+04:30', NULL, N'', 1, N'Implant Capsule', '2021-11-29T12:27:22.1336727+04:30', NULL, N'System Defined'),
    (CAST(48 AS bigint), N'Antibacterials', '2021-11-29T12:27:22.1336367+04:30', NULL, N'', 1, N'Injections', '2021-11-29T12:27:22.1336369+04:30', NULL, N'System Defined'),
    (CAST(49 AS bigint), N'Antibacterials', '2021-11-29T12:27:22.1336440+04:30', NULL, N'', 1, N'Powder', '2021-11-29T12:27:22.1336442+04:30', NULL, N'System Defined'),
    (CAST(39 AS bigint), N'Anesthetics', '2021-11-29T12:27:22.1336319+04:30', NULL, N'', 1, N'I.V Infusion', '2021-11-29T12:27:22.1336320+04:30', NULL, N'System Defined'),
    (CAST(26 AS bigint), N'Anesthetics', '2021-11-29T12:27:22.1336246+04:30', NULL, N'', 1, N'Inhalers', '2021-11-29T12:27:22.1336248+04:30', NULL, N'System Defined'),
    (CAST(25 AS bigint), N'Anesthetics', '2021-11-29T12:27:22.1336241+04:30', NULL, N'', 1, N'Drops', '2021-11-29T12:27:22.1336243+04:30', NULL, N'System Defined'),
    (CAST(24 AS bigint), N'Anesthetics', '2021-11-29T12:27:22.1336236+04:30', NULL, N'', 1, N'Capsules', '2021-11-29T12:27:22.1336238+04:30', NULL, N'System Defined'),
    (CAST(1 AS bigint), N'Analgesics', '2021-11-29T12:27:22.1335956+04:30', NULL, N'', 1, N'Liquid', '2021-11-29T12:27:22.1336001+04:30', NULL, N'System Defined'),
    (CAST(2 AS bigint), N'Analgesics', '2021-11-29T12:27:22.1336107+04:30', NULL, N'', 1, N'Tablet', '2021-11-29T12:27:22.1336110+04:30', NULL, N'System Defined'),
    (CAST(3 AS bigint), N'Analgesics', '2021-11-29T12:27:22.1336115+04:30', NULL, N'', 1, N'Capsules', '2021-11-29T12:27:22.1336117+04:30', NULL, N'System Defined'),
    (CAST(4 AS bigint), N'Analgesics', '2021-11-29T12:27:22.1336122+04:30', NULL, N'', 1, N'Drops', '2021-11-29T12:27:22.1336124+04:30', NULL, N'System Defined'),
    (CAST(5 AS bigint), N'Analgesics', '2021-11-29T12:27:22.1336127+04:30', NULL, N'', 1, N'Inhalers', '2021-11-29T12:27:22.1336129+04:30', NULL, N'System Defined'),
    (CAST(6 AS bigint), N'Analgesics', '2021-11-29T12:27:22.1336133+04:30', NULL, N'', 1, N'Injections', '2021-11-29T12:27:22.1336135+04:30', NULL, N'System Defined'),
    (CAST(7 AS bigint), N'Analgesics', '2021-11-29T12:27:22.1336139+04:30', NULL, N'', 1, N'Powder', '2021-11-29T12:27:22.1336141+04:30', NULL, N'System Defined'),
    (CAST(8 AS bigint), N'Analgesics', '2021-11-29T12:27:22.1336144+04:30', NULL, N'', 1, N'Ointment', '2021-11-29T12:27:22.1336146+04:30', NULL, N'System Defined'),
    (CAST(9 AS bigint), N'Analgesics', '2021-11-29T12:27:22.1336149+04:30', NULL, N'', 1, N'Elixir', '2021-11-29T12:27:22.1336151+04:30', NULL, N'System Defined'),
    (CAST(10 AS bigint), N'Analgesics', '2021-11-29T12:27:22.1336156+04:30', NULL, N'', 1, N'Suppository', '2021-11-29T12:27:22.1336158+04:30', NULL, N'System Defined'),
    (CAST(11 AS bigint), N'Analgesics', '2021-11-29T12:27:22.1336163+04:30', NULL, N'', 1, N'Ampoules', '2021-11-29T12:27:22.1336165+04:30', NULL, N'System Defined'),
    (CAST(12 AS bigint), N'Analgesics', '2021-11-29T12:27:22.1336169+04:30', NULL, N'', 1, N'Suspension', '2021-11-29T12:27:22.1336171+04:30', NULL, N'System Defined'),
    (CAST(13 AS bigint), N'Analgesics', '2021-11-29T12:27:22.1336174+04:30', NULL, N'', 1, N'Oily', '2021-11-29T12:27:22.1336178+04:30', NULL, N'System Defined'),
    (CAST(14 AS bigint), N'Analgesics', '2021-11-29T12:27:22.1336181+04:30', NULL, N'', 1, N'Cream', '2021-11-29T12:27:22.1336183+04:30', NULL, N'System Defined'),
    (CAST(15 AS bigint), N'Analgesics', '2021-11-29T12:27:22.1336187+04:30', NULL, N'', 1, N'Gel/Lotion', '2021-11-29T12:27:22.1336189+04:30', NULL, N'System Defined'),
    (CAST(16 AS bigint), N'Analgesics', '2021-11-29T12:27:22.1336191+04:30', NULL, N'', 1, N'Dispersible', '2021-11-29T12:27:22.1336193+04:30', NULL, N'System Defined'),
    (CAST(17 AS bigint), N'Analgesics', '2021-11-29T12:27:22.1336196+04:30', NULL, N'', 1, N'Chewable', '2021-11-29T12:27:22.1336198+04:30', NULL, N'System Defined'),
    (CAST(18 AS bigint), N'Analgesics', '2021-11-29T12:27:22.1336201+04:30', NULL, N'', 1, N'I.V Infusion', '2021-11-29T12:27:22.1336204+04:30', NULL, N'System Defined'),
    (CAST(19 AS bigint), N'Analgesics', '2021-11-29T12:27:22.1336207+04:30', NULL, N'', 1, N'Ointment', '2021-11-29T12:27:22.1336209+04:30', NULL, N'System Defined'),
    (CAST(20 AS bigint), N'Analgesics', '2021-11-29T12:27:22.1336213+04:30', NULL, N'', 1, N'Liposomal', '2021-11-29T12:27:22.1336216+04:30', NULL, N'System Defined'),
    (CAST(21 AS bigint), N'Analgesics', '2021-11-29T12:27:22.1336220+04:30', NULL, N'', 1, N'Implant Capsule', '2021-11-29T12:27:22.1336222+04:30', NULL, N'System Defined'),
    (CAST(22 AS bigint), N'Anesthetics', '2021-11-29T12:27:22.1336226+04:30', NULL, N'', 1, N'Liquid', '2021-11-29T12:27:22.1336228+04:30', NULL, N'System Defined'),
    (CAST(23 AS bigint), N'Anesthetics', '2021-11-29T12:27:22.1336231+04:30', NULL, N'', 1, N'Tablet', '2021-11-29T12:27:22.1336233+04:30', NULL, N'System Defined'),
    (CAST(50 AS bigint), N'Antibacterials', '2021-11-29T12:27:22.1336445+04:30', NULL, N'', 1, N'Ointment', '2021-11-29T12:27:22.1336447+04:30', NULL, N'System Defined'),
    (CAST(51 AS bigint), N'Antibacterials', '2021-11-29T12:27:22.1336450+04:30', NULL, N'', 1, N'Elixir', '2021-11-29T12:27:22.1336452+04:30', NULL, N'System Defined'),
    (CAST(47 AS bigint), N'Antibacterials', '2021-11-29T12:27:22.1336361+04:30', NULL, N'', 1, N'Inhalers', '2021-11-29T12:27:22.1336363+04:30', NULL, N'System Defined'),
    (CAST(53 AS bigint), N'Antibacterials', '2021-11-29T12:27:22.1336460+04:30', NULL, N'', 1, N'Ampoules', '2021-11-29T12:27:22.1336462+04:30', NULL, N'System Defined'),
    (CAST(81 AS bigint), N'Anticonvulsants', '2021-11-29T12:27:22.1336603+04:30', NULL, N'', 1, N'I.V Infusion', '2021-11-29T12:27:22.1336605+04:30', NULL, N'System Defined'),
    (CAST(82 AS bigint), N'Anticonvulsants', '2021-11-29T12:27:22.1336608+04:30', NULL, N'', 1, N'Ointment', '2021-11-29T12:27:22.1336611+04:30', NULL, N'System Defined'),
    (CAST(52 AS bigint), N'Antibacterials', '2021-11-29T12:27:22.1336455+04:30', NULL, N'', 1, N'Suppository', '2021-11-29T12:27:22.1336457+04:30', NULL, N'System Defined'),
    (CAST(84 AS bigint), N'Anticonvulsants', '2021-11-29T12:27:22.1336620+04:30', NULL, N'', 1, N'Implant Capsule', '2021-11-29T12:27:22.1336622+04:30', NULL, N'System Defined'),
    (CAST(85 AS bigint), N'Antidementia', '2021-11-29T12:27:22.1336625+04:30', NULL, N'', 1, N'Liquid', '2021-11-29T12:27:22.1336627+04:30', NULL, N'System Defined'),
    (CAST(86 AS bigint), N'Antidementia', '2021-11-29T12:27:22.1336630+04:30', NULL, N'', 1, N'Tablet', '2021-11-29T12:27:22.1336632+04:30', NULL, N'System Defined'),
    (CAST(87 AS bigint), N'Antidementia', '2021-11-29T12:27:22.1336635+04:30', NULL, N'', 1, N'Capsules', '2021-11-29T12:27:22.1336637+04:30', NULL, N'System Defined'),
    (CAST(88 AS bigint), N'Antidementia', '2021-11-29T12:27:22.1336640+04:30', NULL, N'', 1, N'Drops', '2021-11-29T12:27:22.1336642+04:30', NULL, N'System Defined'),
    (CAST(89 AS bigint), N'Antidementia', '2021-11-29T12:27:22.1336645+04:30', NULL, N'', 1, N'Inhalers', '2021-11-29T12:27:22.1336647+04:30', NULL, N'System Defined'),
    (CAST(90 AS bigint), N'Antidementia', '2021-11-29T12:27:22.1336650+04:30', NULL, N'', 1, N'Injections', '2021-11-29T12:27:22.1336652+04:30', NULL, N'System Defined'),
    (CAST(91 AS bigint), N'Antidementia', '2021-11-29T12:27:22.1336655+04:30', NULL, N'', 1, N'Powder', '2021-11-29T12:27:22.1336657+04:30', NULL, N'System Defined'),
    (CAST(92 AS bigint), N'Antidementia', '2021-11-29T12:27:22.1336660+04:30', NULL, N'', 1, N'Ointment', '2021-11-29T12:27:22.1336662+04:30', NULL, N'System Defined'),
    (CAST(93 AS bigint), N'Antidementia', '2021-11-29T12:27:22.1336664+04:30', NULL, N'', 1, N'Elixir', '2021-11-29T12:27:22.1336666+04:30', NULL, N'System Defined'),
    (CAST(94 AS bigint), N'Antidementia', '2021-11-29T12:27:22.1336669+04:30', NULL, N'', 1, N'Suppository', '2021-11-29T12:27:22.1336671+04:30', NULL, N'System Defined'),
    (CAST(95 AS bigint), N'Antidementia', '2021-11-29T12:27:22.1336674+04:30', NULL, N'', 1, N'Ampoules', '2021-11-29T12:27:22.1336676+04:30', NULL, N'System Defined'),
    (CAST(96 AS bigint), N'Antidementia', '2021-11-29T12:27:22.1336679+04:30', NULL, N'', 1, N'Suspension', '2021-11-29T12:27:22.1336682+04:30', NULL, N'System Defined'),
    (CAST(97 AS bigint), N'Antidementia', '2021-11-29T12:27:22.1336685+04:30', NULL, N'', 1, N'Oily', '2021-11-29T12:27:22.1336687+04:30', NULL, N'System Defined'),
    (CAST(98 AS bigint), N'Antidementia', '2021-11-29T12:27:22.1336690+04:30', NULL, N'', 1, N'Cream', '2021-11-29T12:27:22.1336693+04:30', NULL, N'System Defined'),
    (CAST(99 AS bigint), N'Antidementia', '2021-11-29T12:27:22.1336695+04:30', NULL, N'', 1, N'Gel/Lotion', '2021-11-29T12:27:22.1336698+04:30', NULL, N'System Defined'),
    (CAST(100 AS bigint), N'Antidementia', '2021-11-29T12:27:22.1336700+04:30', NULL, N'', 1, N'Dispersible', '2021-11-29T12:27:22.1336702+04:30', NULL, N'System Defined'),
    (CAST(101 AS bigint), N'Antidementia', '2021-11-29T12:27:22.1336705+04:30', NULL, N'', 1, N'Chewable', '2021-11-29T12:27:22.1336707+04:30', NULL, N'System Defined'),
    (CAST(102 AS bigint), N'Antidementia', '2021-11-29T12:27:22.1336710+04:30', NULL, N'', 1, N'I.V Infusion', '2021-11-29T12:27:22.1336712+04:30', NULL, N'System Defined'),
    (CAST(103 AS bigint), N'Antidementia', '2021-11-29T12:27:22.1336715+04:30', NULL, N'', 1, N'Ointment', '2021-11-29T12:27:22.1336717+04:30', NULL, N'System Defined'),
    (CAST(80 AS bigint), N'Anticonvulsants', '2021-11-29T12:27:22.1336597+04:30', NULL, N'', 1, N'Chewable', '2021-11-29T12:27:22.1336600+04:30', NULL, N'System Defined'),
    (CAST(79 AS bigint), N'Anticonvulsants', '2021-11-29T12:27:22.1336592+04:30', NULL, N'', 1, N'Dispersible', '2021-11-29T12:27:22.1336595+04:30', NULL, N'System Defined'),
    (CAST(83 AS bigint), N'Anticonvulsants', '2021-11-29T12:27:22.1336615+04:30', NULL, N'', 1, N'Liposomal', '2021-11-29T12:27:22.1336617+04:30', NULL, N'System Defined'),
    (CAST(77 AS bigint), N'Anticonvulsants', '2021-11-29T12:27:22.1336583+04:30', NULL, N'', 1, N'Cream', '2021-11-29T12:27:22.1336585+04:30', NULL, N'System Defined'),
    (CAST(54 AS bigint), N'Antibacterials', '2021-11-29T12:27:22.1336465+04:30', NULL, N'', 1, N'Suspension', '2021-11-29T12:27:22.1336467+04:30', NULL, N'System Defined'),
    (CAST(55 AS bigint), N'Antibacterials', '2021-11-29T12:27:22.1336470+04:30', NULL, N'', 1, N'Oily', '2021-11-29T12:27:22.1336472+04:30', NULL, N'System Defined'),
    (CAST(56 AS bigint), N'Antibacterials', '2021-11-29T12:27:22.1336475+04:30', NULL, N'', 1, N'Cream', '2021-11-29T12:27:22.1336477+04:30', NULL, N'System Defined'),
    (CAST(58 AS bigint), N'Antibacterials', '2021-11-29T12:27:22.1336487+04:30', NULL, N'', 1, N'Dispersible', '2021-11-29T12:27:22.1336489+04:30', NULL, N'System Defined'),
    (CAST(59 AS bigint), N'Antibacterials', '2021-11-29T12:27:22.1336492+04:30', NULL, N'', 1, N'Chewable', '2021-11-29T12:27:22.1336494+04:30', NULL, N'System Defined'),
    (CAST(78 AS bigint), N'Anticonvulsants', '2021-11-29T12:27:22.1336588+04:30', NULL, N'', 1, N'Gel/Lotion', '2021-11-29T12:27:22.1336590+04:30', NULL, N'System Defined'),
    (CAST(61 AS bigint), N'Antibacterials', '2021-11-29T12:27:22.1336502+04:30', NULL, N'', 1, N'Ointment', '2021-11-29T12:27:22.1336504+04:30', NULL, N'System Defined'),
    (CAST(62 AS bigint), N'Antibacterials', '2021-11-29T12:27:22.1336507+04:30', NULL, N'', 1, N'Liposomal', '2021-11-29T12:27:22.1336509+04:30', NULL, N'System Defined'),
    (CAST(63 AS bigint), N'Antibacterials', '2021-11-29T12:27:22.1336512+04:30', NULL, N'', 1, N'Implant Capsule', '2021-11-29T12:27:22.1336514+04:30', NULL, N'System Defined'),
    (CAST(64 AS bigint), N'Anticonvulsants', '2021-11-29T12:27:22.1336517+04:30', NULL, N'', 1, N'Liquid', '2021-11-29T12:27:22.1336519+04:30', NULL, N'System Defined'),
    (CAST(65 AS bigint), N'Anticonvulsants', '2021-11-29T12:27:22.1336522+04:30', NULL, N'', 1, N'Tablet', '2021-11-29T12:27:22.1336523+04:30', NULL, N'System Defined'),
    (CAST(60 AS bigint), N'Antibacterials', '2021-11-29T12:27:22.1336497+04:30', NULL, N'', 1, N'I.V Infusion', '2021-11-29T12:27:22.1336499+04:30', NULL, N'System Defined'),
    (CAST(67 AS bigint), N'Anticonvulsants', '2021-11-29T12:27:22.1336532+04:30', NULL, N'', 1, N'Drops', '2021-11-29T12:27:22.1336534+04:30', NULL, N'System Defined'),
    (CAST(66 AS bigint), N'Anticonvulsants', '2021-11-29T12:27:22.1336527+04:30', NULL, N'', 1, N'Capsules', '2021-11-29T12:27:22.1336529+04:30', NULL, N'System Defined'),
    (CAST(75 AS bigint), N'Anticonvulsants', '2021-11-29T12:27:22.1336572+04:30', NULL, N'', 1, N'Suspension', '2021-11-29T12:27:22.1336574+04:30', NULL, N'System Defined'),
    (CAST(74 AS bigint), N'Anticonvulsants', '2021-11-29T12:27:22.1336567+04:30', NULL, N'', 1, N'Ampoules', '2021-11-29T12:27:22.1336569+04:30', NULL, N'System Defined'),
    (CAST(73 AS bigint), N'Anticonvulsants', '2021-11-29T12:27:22.1336562+04:30', NULL, N'', 1, N'Suppository', '2021-11-29T12:27:22.1336564+04:30', NULL, N'System Defined'),
    (CAST(76 AS bigint), N'Anticonvulsants', '2021-11-29T12:27:22.1336577+04:30', NULL, N'', 1, N'Oily', '2021-11-29T12:27:22.1336579+04:30', NULL, N'System Defined'),
    (CAST(71 AS bigint), N'Anticonvulsants', '2021-11-29T12:27:22.1336552+04:30', NULL, N'', 1, N'Ointment', '2021-11-29T12:27:22.1336554+04:30', NULL, N'System Defined'),
    (CAST(70 AS bigint), N'Anticonvulsants', '2021-11-29T12:27:22.1336547+04:30', NULL, N'', 1, N'Powder', '2021-11-29T12:27:22.1336549+04:30', NULL, N'System Defined'),
    (CAST(69 AS bigint), N'Anticonvulsants', '2021-11-29T12:27:22.1336542+04:30', NULL, N'', 1, N'Injections', '2021-11-29T12:27:22.1336544+04:30', NULL, N'System Defined'),
    (CAST(68 AS bigint), N'Anticonvulsants', '2021-11-29T12:27:22.1336537+04:30', NULL, N'', 1, N'Inhalers', '2021-11-29T12:27:22.1336539+04:30', NULL, N'System Defined'),
    (CAST(72 AS bigint), N'Anticonvulsants', '2021-11-29T12:27:22.1336557+04:30', NULL, N'', 1, N'Elixir', '2021-11-29T12:27:22.1336559+04:30', NULL, N'System Defined');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CategoryName', N'CreatedAt', N'DeletedAt', N'Description', N'Status', N'TypeName', N'UpdatedAt', N'UserId', N'UserName') AND [object_id] = OBJECT_ID(N'[wms_product_type_tbl]'))
        SET IDENTITY_INSERT [wms_product_type_tbl] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129075724_EmployeeSalaryies')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedAt', N'DeletedAt', N'Description', N'Name', N'Status', N'UpdatedAt', N'UserId', N'UserName') AND [object_id] = OBJECT_ID(N'[wms_unit_tbl]'))
        SET IDENTITY_INSERT [wms_unit_tbl] ON;
    INSERT INTO [wms_unit_tbl] ([Id], [CreatedAt], [DeletedAt], [Description], [Name], [Status], [UpdatedAt], [UserId], [UserName])
    VALUES (CAST(10 AS bigint), '2021-11-29T12:27:22.1341802+04:30', NULL, N'', N'Boxes', 1, '2021-11-29T12:27:22.1341804+04:30', NULL, N'System Defined'),
    (CAST(1 AS bigint), '2021-11-29T12:27:22.1341661+04:30', NULL, N'', N'Blister Packs', 1, '2021-11-29T12:27:22.1341677+04:30', NULL, N'System Defined'),
    (CAST(2 AS bigint), '2021-11-29T12:27:22.1341758+04:30', NULL, N'', N'Tubes', 1, '2021-11-29T12:27:22.1341760+04:30', NULL, N'System Defined'),
    (CAST(3 AS bigint), '2021-11-29T12:27:22.1341764+04:30', NULL, N'', N'Bottles', 1, '2021-11-29T12:27:22.1341767+04:30', NULL, N'System Defined'),
    (CAST(4 AS bigint), '2021-11-29T12:27:22.1341770+04:30', NULL, N'', N'Jars ', 1, '2021-11-29T12:27:22.1341772+04:30', NULL, N'System Defined'),
    (CAST(5 AS bigint), '2021-11-29T12:27:22.1341774+04:30', NULL, N'', N'Plastic bags', 1, '2021-11-29T12:27:22.1341776+04:30', NULL, N'System Defined'),
    (CAST(6 AS bigint), '2021-11-29T12:27:22.1341779+04:30', NULL, N'', N'Syringes', 1, '2021-11-29T12:27:22.1341781+04:30', NULL, N'System Defined'),
    (CAST(7 AS bigint), '2021-11-29T12:27:22.1341784+04:30', NULL, N'', N'Vials', 1, '2021-11-29T12:27:22.1341786+04:30', NULL, N'System Defined'),
    (CAST(8 AS bigint), '2021-11-29T12:27:22.1341790+04:30', NULL, N'', N'Sachets', 1, '2021-11-29T12:27:22.1341792+04:30', NULL, N'System Defined'),
    (CAST(9 AS bigint), '2021-11-29T12:27:22.1341797+04:30', NULL, N'', N'Cartons', 1, '2021-11-29T12:27:22.1341799+04:30', NULL, N'System Defined'),
    (CAST(11 AS bigint), '2021-11-29T12:27:22.1341806+04:30', NULL, N'', N'Enteral syringe', 1, '2021-11-29T12:27:22.1341808+04:30', NULL, N'System Defined');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedAt', N'DeletedAt', N'Description', N'Name', N'Status', N'UpdatedAt', N'UserId', N'UserName') AND [object_id] = OBJECT_ID(N'[wms_unit_tbl]'))
        SET IDENTITY_INSERT [wms_unit_tbl] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129075724_EmployeeSalaryies')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CountryCode', N'CountryId', N'CountryName', N'CreatedAt', N'DeletedAt', N'Name', N'UpdatedAt', N'UserId', N'UserName') AND [object_id] = OBJECT_ID(N'[wms_province_tbl]'))
        SET IDENTITY_INSERT [wms_province_tbl] ON;
    INSERT INTO [wms_province_tbl] ([Id], [CountryCode], [CountryId], [CountryName], [CreatedAt], [DeletedAt], [Name], [UpdatedAt], [UserId], [UserName])
    VALUES (CAST(1 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1349597+04:30', NULL, N'Badakhshan', '2021-11-29T12:27:22.1349620+04:30', NULL, N'System_Populated'),
    (CAST(94 AS bigint), N'TUR', CAST(4 AS bigint), N'Turkey', '2021-11-29T12:27:22.1350507+04:30', NULL, N'Diyarbakır', '2021-11-29T12:27:22.1350509+04:30', NULL, N'System_Populated'),
    (CAST(93 AS bigint), N'TUR', CAST(4 AS bigint), N'Turkey', '2021-11-29T12:27:22.1350502+04:30', NULL, N'Denizli', '2021-11-29T12:27:22.1350504+04:30', NULL, N'System_Populated'),
    (CAST(92 AS bigint), N'TUR', CAST(4 AS bigint), N'Turkey', '2021-11-29T12:27:22.1350497+04:30', NULL, N'Çorum', '2021-11-29T12:27:22.1350499+04:30', NULL, N'System_Populated'),
    (CAST(91 AS bigint), N'TUR', CAST(4 AS bigint), N'Turkey', '2021-11-29T12:27:22.1350492+04:30', NULL, N'Çankırı', '2021-11-29T12:27:22.1350494+04:30', NULL, N'System_Populated'),
    (CAST(90 AS bigint), N'TUR', CAST(4 AS bigint), N'Turkey', '2021-11-29T12:27:22.1350487+04:30', NULL, N'Çanakkale', '2021-11-29T12:27:22.1350489+04:30', NULL, N'System_Populated'),
    (CAST(88 AS bigint), N'TUR', CAST(4 AS bigint), N'Turkey', '2021-11-29T12:27:22.1350482+04:30', NULL, N'Bursa', '2021-11-29T12:27:22.1350484+04:30', NULL, N'System_Populated'),
    (CAST(87 AS bigint), N'TUR', CAST(4 AS bigint), N'Turkey', '2021-11-29T12:27:22.1350477+04:30', NULL, N'Burdur', '2021-11-29T12:27:22.1350479+04:30', NULL, N'System_Populated'),
    (CAST(86 AS bigint), N'TUR', CAST(4 AS bigint), N'Turkey', '2021-11-29T12:27:22.1350471+04:30', NULL, N'Bolu', '2021-11-29T12:27:22.1350474+04:30', NULL, N'System_Populated'),
    (CAST(85 AS bigint), N'TUR', CAST(4 AS bigint), N'Turkey', '2021-11-29T12:27:22.1350417+04:30', NULL, N'Bitlis', '2021-11-29T12:27:22.1350419+04:30', NULL, N'System_Populated'),
    (CAST(84 AS bigint), N'TUR', CAST(4 AS bigint), N'Turkey', '2021-11-29T12:27:22.1350406+04:30', NULL, N'Bingöl', '2021-11-29T12:27:22.1350408+04:30', NULL, N'System_Populated'),
    (CAST(83 AS bigint), N'TUR', CAST(4 AS bigint), N'Turkey', '2021-11-29T12:27:22.1350402+04:30', NULL, N'Bilecik', '2021-11-29T12:27:22.1350404+04:30', NULL, N'System_Populated'),
    (CAST(82 AS bigint), N'TUR', CAST(4 AS bigint), N'Turkey', '2021-11-29T12:27:22.1350396+04:30', NULL, N'Bayburt', '2021-11-29T12:27:22.1350399+04:30', NULL, N'System_Populated'),
    (CAST(81 AS bigint), N'TUR', CAST(4 AS bigint), N'Turkey', '2021-11-29T12:27:22.1350391+04:30', NULL, N'Batman', '2021-11-29T12:27:22.1350393+04:30', NULL, N'System_Populated'),
    (CAST(95 AS bigint), N'TUR', CAST(4 AS bigint), N'Turkey', '2021-11-29T12:27:22.1350513+04:30', NULL, N'Düzce', '2021-11-29T12:27:22.1350515+04:30', NULL, N'System_Populated'),
    (CAST(80 AS bigint), N'TUR', CAST(4 AS bigint), N'Turkey', '2021-11-29T12:27:22.1350386+04:30', NULL, N'Bartın', '2021-11-29T12:27:22.1350388+04:30', NULL, N'System_Populated'),
    (CAST(78 AS bigint), N'TUR', CAST(4 AS bigint), N'Turkey', '2021-11-29T12:27:22.1350377+04:30', NULL, N'Aydın', '2021-11-29T12:27:22.1350379+04:30', NULL, N'System_Populated'),
    (CAST(77 AS bigint), N'TUR', CAST(4 AS bigint), N'Turkey', '2021-11-29T12:27:22.1350372+04:30', NULL, N'Artvin', '2021-11-29T12:27:22.1350374+04:30', NULL, N'System_Populated'),
    (CAST(76 AS bigint), N'TUR', CAST(4 AS bigint), N'Turkey', '2021-11-29T12:27:22.1350367+04:30', NULL, N'Ardahan', '2021-11-29T12:27:22.1350369+04:30', NULL, N'System_Populated'),
    (CAST(75 AS bigint), N'TUR', CAST(4 AS bigint), N'Turkey', '2021-11-29T12:27:22.1350362+04:30', NULL, N'Antalya', '2021-11-29T12:27:22.1350364+04:30', NULL, N'System_Populated'),
    (CAST(74 AS bigint), N'TUR', CAST(4 AS bigint), N'Turkey', '2021-11-29T12:27:22.1350356+04:30', NULL, N'Ankara', '2021-11-29T12:27:22.1350358+04:30', NULL, N'System_Populated'),
    (CAST(73 AS bigint), N'TUR', CAST(4 AS bigint), N'Turkey', '2021-11-29T12:27:22.1350351+04:30', NULL, N'Amasya', '2021-11-29T12:27:22.1350353+04:30', NULL, N'System_Populated'),
    (CAST(72 AS bigint), N'TUR', CAST(4 AS bigint), N'Turkey', '2021-11-29T12:27:22.1350345+04:30', NULL, N'Aksaray', '2021-11-29T12:27:22.1350347+04:30', NULL, N'System_Populated'),
    (CAST(71 AS bigint), N'TUR', CAST(4 AS bigint), N'Turkey', '2021-11-29T12:27:22.1350340+04:30', NULL, N'Ağri', '2021-11-29T12:27:22.1350342+04:30', NULL, N'System_Populated'),
    (CAST(70 AS bigint), N'TUR', CAST(4 AS bigint), N'Turkey', '2021-11-29T12:27:22.1350335+04:30', NULL, N'Afyonkarahisar', '2021-11-29T12:27:22.1350337+04:30', NULL, N'System_Populated'),
    (CAST(69 AS bigint), N'TUR', CAST(4 AS bigint), N'Turkey', '2021-11-29T12:27:22.1350330+04:30', NULL, N'Adıyaman', '2021-11-29T12:27:22.1350332+04:30', NULL, N'System_Populated'),
    (CAST(68 AS bigint), N'TUR', CAST(4 AS bigint), N'Turkey', '2021-11-29T12:27:22.1350325+04:30', NULL, N'Adana', '2021-11-29T12:27:22.1350327+04:30', NULL, N'System_Populated'),
    (CAST(67 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350320+04:30', NULL, N'Uttarakhand', '2021-11-29T12:27:22.1350322+04:30', NULL, N'System_Populated'),
    (CAST(66 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350315+04:30', NULL, N'Uttar Pradesh', '2021-11-29T12:27:22.1350317+04:30', NULL, N'System_Populated'),
    (CAST(79 AS bigint), N'TUR', CAST(4 AS bigint), N'Turkey', '2021-11-29T12:27:22.1350382+04:30', NULL, N'Balıkesir', '2021-11-29T12:27:22.1350384+04:30', NULL, N'System_Populated'),
    (CAST(65 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350310+04:30', NULL, N'Tripura', '2021-11-29T12:27:22.1350312+04:30', NULL, N'System_Populated'),
    (CAST(96 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350518+04:30', NULL, N'Alborz', '2021-11-29T12:27:22.1350520+04:30', NULL, N'System_Populated'),
    (CAST(98 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350528+04:30', NULL, N'Razavi Khorasan', '2021-11-29T12:27:22.1350530+04:30', NULL, N'System_Populated'),
    (CAST(125 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350696+04:30', NULL, N'Markazi', '2021-11-29T12:27:22.1350698+04:30', NULL, N'System_Populated'),
    (CAST(124 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350691+04:30', NULL, N'Qazvin', '2021-11-29T12:27:22.1350693+04:30', NULL, N'System_Populated'),
    (CAST(123 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350685+04:30', NULL, N'Gilan', '2021-11-29T12:27:22.1350689+04:30', NULL, N'System_Populated'),
    (CAST(122 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350681+04:30', NULL, N'Ardabil', '2021-11-29T12:27:22.1350682+04:30', NULL, N'System_Populated'),
    (CAST(121 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350676+04:30', NULL, N'Zanjan', '2021-11-29T12:27:22.1350678+04:30', NULL, N'System_Populated'),
    (CAST(120 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350671+04:30', NULL, N'East Azarbaijan', '2021-11-29T12:27:22.1350672+04:30', NULL, N'System_Populated'),
    (CAST(119 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350666+04:30', NULL, N'West Azarbaijan', '2021-11-29T12:27:22.1350668+04:30', NULL, N'System_Populated'),
    (CAST(118 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350661+04:30', NULL, N'Kurdistan', '2021-11-29T12:27:22.1350663+04:30', NULL, N'System_Populated'),
    (CAST(117 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350656+04:30', NULL, N'Hamadan', '2021-11-29T12:27:22.1350658+04:30', NULL, N'System_Populated'),
    (CAST(128 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350651+04:30', NULL, N'Kermanshah', '2021-11-29T12:27:22.1350653+04:30', NULL, N'System_Populated'),
    (CAST(116 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350646+04:30', NULL, N'Ilam', '2021-11-29T12:27:22.1350648+04:30', NULL, N'System_Populated'),
    (CAST(115 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350641+04:30', NULL, N'Lorestan', '2021-11-29T12:27:22.1350643+04:30', NULL, N'System_Populated'),
    (CAST(114 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350635+04:30', NULL, N'Khuzestan', '2021-11-29T12:27:22.1350637+04:30', NULL, N'System_Populated'),
    (CAST(97 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350523+04:30', NULL, N'South Khorasan', '2021-11-29T12:27:22.1350525+04:30', NULL, N'System_Populated'),
    (CAST(113 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350630+04:30', NULL, N'Chahar Mahaal', '2021-11-29T12:27:22.1350632+04:30', NULL, N'System_Populated'),
    (CAST(111 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350621+04:30', NULL, N'Kohkiluyeh', '2021-11-29T12:27:22.1350623+04:30', NULL, N'System_Populated'),
    (CAST(110 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350616+04:30', NULL, N'Buyer Ahmad', '2021-11-29T12:27:22.1350618+04:30', NULL, N'System_Populated'),
    (CAST(109 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350611+04:30', NULL, N'Bushehr', '2021-11-29T12:27:22.1350613+04:30', NULL, N'System_Populated'),
    (CAST(108 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350606+04:30', NULL, N'Fars', '2021-11-29T12:27:22.1350608+04:30', NULL, N'System_Populated'),
    (CAST(107 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350577+04:30', NULL, N'Hormozgan', '2021-11-29T12:27:22.1350603+04:30', NULL, N'System_Populated'),
    (CAST(106 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350572+04:30', NULL, N'Sistan-Baluchistan', '2021-11-29T12:27:22.1350574+04:30', NULL, N'System_Populated'),
    (CAST(105 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350565+04:30', NULL, N'Kerman', '2021-11-29T12:27:22.1350569+04:30', NULL, N'System_Populated'),
    (CAST(104 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350558+04:30', NULL, N'Yazd', '2021-11-29T12:27:22.1350560+04:30', NULL, N'System_Populated'),
    (CAST(103 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350553+04:30', NULL, N'Esfahan', '2021-11-29T12:27:22.1350555+04:30', NULL, N'System_Populated'),
    (CAST(102 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350548+04:30', NULL, N'Semnan', '2021-11-29T12:27:22.1350550+04:30', NULL, N'System_Populated'),
    (CAST(101 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350543+04:30', NULL, N'Mazandaran', '2021-11-29T12:27:22.1350545+04:30', NULL, N'System_Populated'),
    (CAST(100 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350538+04:30', NULL, N'Golestan', '2021-11-29T12:27:22.1350540+04:30', NULL, N'System_Populated'),
    (CAST(99 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350533+04:30', NULL, N'North Khorasan', '2021-11-29T12:27:22.1350535+04:30', NULL, N'System_Populated'),
    (CAST(112 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350625+04:30', NULL, N'Bakhtiari', '2021-11-29T12:27:22.1350627+04:30', NULL, N'System_Populated'),
    (CAST(126 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350701+04:30', NULL, N'Qom', '2021-11-29T12:27:22.1350703+04:30', NULL, N'System_Populated'),
    (CAST(64 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350304+04:30', NULL, N'Telangana', '2021-11-29T12:27:22.1350306+04:30', NULL, N'System_Populated'),
    (CAST(62 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350294+04:30', NULL, N'Tamil Nadu', '2021-11-29T12:27:22.1350297+04:30', NULL, N'System_Populated'),
    (CAST(29 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1350120+04:30', NULL, N'Parwan', '2021-11-29T12:27:22.1350122+04:30', NULL, N'System_Populated'),
    (CAST(28 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1350115+04:30', NULL, N'Panjshir', '2021-11-29T12:27:22.1350117+04:30', NULL, N'System_Populated'),
    (CAST(27 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1350110+04:30', NULL, N'Paktika', '2021-11-29T12:27:22.1350112+04:30', NULL, N'System_Populated'),
    (CAST(26 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1350101+04:30', NULL, N'Paktia', '2021-11-29T12:27:22.1350105+04:30', NULL, N'System_Populated'),
    (CAST(25 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1349852+04:30', NULL, N'Urozgan', '2021-11-29T12:27:22.1349855+04:30', NULL, N'System_Populated'),
    (CAST(24 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1349844+04:30', NULL, N'Nuristan', '2021-11-29T12:27:22.1349848+04:30', NULL, N'System_Populated'),
    (CAST(23 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1349837+04:30', NULL, N'Nimruz', '2021-11-29T12:27:22.1349840+04:30', NULL, N'System_Populated'),
    (CAST(22 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1349830+04:30', NULL, N'Nangarhar', '2021-11-29T12:27:22.1349832+04:30', NULL, N'System_Populated'),
    (CAST(21 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1349824+04:30', NULL, N'Logar', '2021-11-29T12:27:22.1349826+04:30', NULL, N'System_Populated'),
    (CAST(20 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1349816+04:30', NULL, N'Laghman', '2021-11-29T12:27:22.1349820+04:30', NULL, N'System_Populated'),
    (CAST(19 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1349810+04:30', NULL, N'Kunduz', '2021-11-29T12:27:22.1349812+04:30', NULL, N'System_Populated'),
    (CAST(18 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1349804+04:30', NULL, N'Kunar', '2021-11-29T12:27:22.1349807+04:30', NULL, N'System_Populated'),
    (CAST(17 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1349799+04:30', NULL, N'Khost', '2021-11-29T12:27:22.1349801+04:30', NULL, N'System_Populated'),
    (CAST(30 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1350125+04:30', NULL, N'Samangan', '2021-11-29T12:27:22.1350127+04:30', NULL, N'System_Populated'),
    (CAST(16 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1349794+04:30', NULL, N'Kapisa', '2021-11-29T12:27:22.1349796+04:30', NULL, N'System_Populated'),
    (CAST(14 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1349784+04:30', NULL, N'Kabul', '2021-11-29T12:27:22.1349786+04:30', NULL, N'System_Populated'),
    (CAST(13 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1349779+04:30', NULL, N'Jowzjan', '2021-11-29T12:27:22.1349781+04:30', NULL, N'System_Populated'),
    (CAST(12 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1349774+04:30', NULL, N'Herat', '2021-11-29T12:27:22.1349776+04:30', NULL, N'System_Populated'),
    (CAST(11 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1349769+04:30', NULL, N'Helmand', '2021-11-29T12:27:22.1349771+04:30', NULL, N'System_Populated'),
    (CAST(10 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1349764+04:30', NULL, N'Ghor', '2021-11-29T12:27:22.1349766+04:30', NULL, N'System_Populated'),
    (CAST(9 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1349757+04:30', NULL, N'Ghazni', '2021-11-29T12:27:22.1349759+04:30', NULL, N'System_Populated'),
    (CAST(8 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1349751+04:30', NULL, N'Faryab', '2021-11-29T12:27:22.1349753+04:30', NULL, N'System_Populated'),
    (CAST(7 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1349746+04:30', NULL, N'Farah', '2021-11-29T12:27:22.1349748+04:30', NULL, N'System_Populated'),
    (CAST(6 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1349739+04:30', NULL, N'Daykundi', '2021-11-29T12:27:22.1349741+04:30', NULL, N'System_Populated'),
    (CAST(5 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1349732+04:30', NULL, N'Bamyan', '2021-11-29T12:27:22.1349734+04:30', NULL, N'System_Populated'),
    (CAST(4 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1349727+04:30', NULL, N'Balkh', '2021-11-29T12:27:22.1349729+04:30', NULL, N'System_Populated'),
    (CAST(3 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1349720+04:30', NULL, N'Baghlan', '2021-11-29T12:27:22.1349722+04:30', NULL, N'System_Populated'),
    (CAST(2 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1349712+04:30', NULL, N'Badghis', '2021-11-29T12:27:22.1349715+04:30', NULL, N'System_Populated'),
    (CAST(15 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1349789+04:30', NULL, N'Kandahar', '2021-11-29T12:27:22.1349791+04:30', NULL, N'System_Populated'),
    (CAST(63 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350299+04:30', NULL, N'Telangana', '2021-11-29T12:27:22.1350301+04:30', NULL, N'System_Populated'),
    (CAST(31 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1350130+04:30', NULL, N'Sar-e Pol', '2021-11-29T12:27:22.1350132+04:30', NULL, N'System_Populated'),
    (CAST(33 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1350140+04:30', NULL, N'Wardak', '2021-11-29T12:27:22.1350142+04:30', NULL, N'System_Populated'),
    (CAST(61 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350289+04:30', NULL, N'Sikkim', '2021-11-29T12:27:22.1350291+04:30', NULL, N'System_Populated'),
    (CAST(60 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350284+04:30', NULL, N'Rajasthan', '2021-11-29T12:27:22.1350286+04:30', NULL, N'System_Populated'),
    (CAST(59 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350280+04:30', NULL, N'Punjab', '2021-11-29T12:27:22.1350282+04:30', NULL, N'System_Populated'),
    (CAST(58 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350275+04:30', NULL, N'Odisha', '2021-11-29T12:27:22.1350277+04:30', NULL, N'System_Populated'),
    (CAST(57 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350270+04:30', NULL, N'Nagaland', '2021-11-29T12:27:22.1350272+04:30', NULL, N'System_Populated'),
    (CAST(56 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350264+04:30', NULL, N'Mizoram', '2021-11-29T12:27:22.1350266+04:30', NULL, N'System_Populated'),
    (CAST(55 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350254+04:30', NULL, N'Meghalaya', '2021-11-29T12:27:22.1350262+04:30', NULL, N'System_Populated'),
    (CAST(54 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350249+04:30', NULL, N'Manipur', '2021-11-29T12:27:22.1350252+04:30', NULL, N'System_Populated'),
    (CAST(53 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350244+04:30', NULL, N'Maharashtra', '2021-11-29T12:27:22.1350246+04:30', NULL, N'System_Populated'),
    (CAST(52 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350239+04:30', NULL, N'Madhya Pradesh', '2021-11-29T12:27:22.1350241+04:30', NULL, N'System_Populated'),
    (CAST(51 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350233+04:30', NULL, N'Kerala', '2021-11-29T12:27:22.1350235+04:30', NULL, N'System_Populated'),
    (CAST(50 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350228+04:30', NULL, N'Karnataka', '2021-11-29T12:27:22.1350230+04:30', NULL, N'System_Populated'),
    (CAST(49 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350223+04:30', NULL, N'Jharkhand', '2021-11-29T12:27:22.1350225+04:30', NULL, N'System_Populated'),
    (CAST(32 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1350135+04:30', NULL, N'Takhar', '2021-11-29T12:27:22.1350137+04:30', NULL, N'System_Populated'),
    (CAST(48 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350218+04:30', NULL, N'Himachal Pradesh', '2021-11-29T12:27:22.1350220+04:30', NULL, N'System_Populated'),
    (CAST(46 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350209+04:30', NULL, N'Gujarat', '2021-11-29T12:27:22.1350211+04:30', NULL, N'System_Populated'),
    (CAST(45 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350204+04:30', NULL, N'Goa', '2021-11-29T12:27:22.1350206+04:30', NULL, N'System_Populated'),
    (CAST(44 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350198+04:30', NULL, N'Chhattisgarh', '2021-11-29T12:27:22.1350201+04:30', NULL, N'System_Populated'),
    (CAST(43 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350192+04:30', NULL, N'Bihar', '2021-11-29T12:27:22.1350195+04:30', NULL, N'System_Populated'),
    (CAST(42 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350187+04:30', NULL, N'Assam', '2021-11-29T12:27:22.1350189+04:30', NULL, N'System_Populated'),
    (CAST(41 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350182+04:30', NULL, N'Arunachal Pradesh', '2021-11-29T12:27:22.1350184+04:30', NULL, N'System_Populated'),
    (CAST(40 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350177+04:30', NULL, N'Andhra Pradesh', '2021-11-29T12:27:22.1350179+04:30', NULL, N'System_Populated'),
    (CAST(39 AS bigint), N'PK', CAST(2 AS bigint), N'Pakistan', '2021-11-29T12:27:22.1350172+04:30', NULL, N'Peshawar', '2021-11-29T12:27:22.1350174+04:30', NULL, N'System_Populated'),
    (CAST(38 AS bigint), N'PK', CAST(2 AS bigint), N'Pakistan', '2021-11-29T12:27:22.1350167+04:30', NULL, N'Sohawa', '2021-11-29T12:27:22.1350169+04:30', NULL, N'System_Populated'),
    (CAST(37 AS bigint), N'PK', CAST(2 AS bigint), N'Pakistan', '2021-11-29T12:27:22.1350162+04:30', NULL, N'Jehlum', '2021-11-29T12:27:22.1350164+04:30', NULL, N'System_Populated'),
    (CAST(36 AS bigint), N'PK', CAST(2 AS bigint), N'Pakistan', '2021-11-29T12:27:22.1350156+04:30', NULL, N'RawalPindi', '2021-11-29T12:27:22.1350158+04:30', NULL, N'System_Populated'),
    (CAST(35 AS bigint), N'PK', CAST(2 AS bigint), N'Pakistan', '2021-11-29T12:27:22.1350150+04:30', NULL, N'Punjab', '2021-11-29T12:27:22.1350152+04:30', NULL, N'System_Populated'),
    (CAST(34 AS bigint), N'AFN', CAST(1 AS bigint), N'Afghanistan', '2021-11-29T12:27:22.1350145+04:30', NULL, N'Zabul', '2021-11-29T12:27:22.1350147+04:30', NULL, N'System_Populated'),
    (CAST(47 AS bigint), N'IND', CAST(3 AS bigint), N'India', '2021-11-29T12:27:22.1350213+04:30', NULL, N'Haryana', '2021-11-29T12:27:22.1350215+04:30', NULL, N'System_Populated'),
    (CAST(127 AS bigint), N'IR', CAST(5 AS bigint), N'Iran', '2021-11-29T12:27:22.1350706+04:30', NULL, N'Tehran', '2021-11-29T12:27:22.1350708+04:30', NULL, N'System_Populated');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CountryCode', N'CountryId', N'CountryName', N'CreatedAt', N'DeletedAt', N'Name', N'UpdatedAt', N'UserId', N'UserName') AND [object_id] = OBJECT_ID(N'[wms_province_tbl]'))
        SET IDENTITY_INSERT [wms_province_tbl] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129075724_EmployeeSalaryies')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211129075724_EmployeeSalaryies', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    DECLARE @var51 sysname;
    SELECT @var51 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_employee_tbl]') AND [c].[name] = N'Leavedate');
    IF @var51 IS NOT NULL EXEC(N'ALTER TABLE [wms_employee_tbl] DROP CONSTRAINT [' + @var51 + '];');
    ALTER TABLE [wms_employee_tbl] ALTER COLUMN [Leavedate] datetime2 NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_assets_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8802660+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8802669+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_assets_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8804160+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8804168+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_assets_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8804197+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8804200+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_assets_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8804203+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8804205+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_assets_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8804208+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8804210+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8791609+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8791619+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8795064+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8795074+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8795248+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8795252+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8795256+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8795258+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8795262+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8795265+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8795268+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8795270+04:30'
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8795274+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8795276+04:30'
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8795279+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8795281+04:30'
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8795284+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8795286+04:30'
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8795290+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8795292+04:30'
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8744234+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8745407+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8747175+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8747201+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8747240+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8747243+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8747246+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8747248+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8747251+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8747253+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8747256+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8747258+04:30'
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8747262+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8747264+04:30'
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8747267+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8747269+04:30'
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8747273+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8747276+04:30'
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8747280+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8747282+04:30'
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8747285+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8747287+04:30'
    WHERE [Id] = CAST(12 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_country_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8780067+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8780078+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_country_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8780155+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8780158+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_country_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8780165+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8780167+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_country_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8780170+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8780173+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_country_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8780176+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8780178+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_designation_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8797160+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8797172+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_designation_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8797220+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8797223+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_designation_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8797226+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8797228+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_designation_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8797231+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8797233+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_designation_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8797236+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8797238+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_designation_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8797242+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8797243+04:30'
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_designation_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8797246+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8797248+04:30'
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8800762+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8800764+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8800757+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8800759+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8800752+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8800754+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8800747+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8800749+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8800742+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8800744+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8800737+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8800739+04:30'
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8800731+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8800734+04:30'
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8800726+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8800728+04:30'
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8800721+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8800723+04:30'
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8800716+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8800718+04:30'
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8800711+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8800713+04:30'
    WHERE [Id] = CAST(11 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8800706+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8800708+04:30'
    WHERE [Id] = CAST(12 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8800701+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8800703+04:30'
    WHERE [Id] = CAST(13 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8800695+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8800698+04:30'
    WHERE [Id] = CAST(14 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8800622+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8800624+04:30'
    WHERE [Id] = CAST(15 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8800617+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8800619+04:30'
    WHERE [Id] = CAST(16 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8800608+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8800614+04:30'
    WHERE [Id] = CAST(17 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8800603+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8800605+04:30'
    WHERE [Id] = CAST(18 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8800598+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8800600+04:30'
    WHERE [Id] = CAST(19 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8800593+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8800595+04:30'
    WHERE [Id] = CAST(20 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8800588+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8800590+04:30'
    WHERE [Id] = CAST(21 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8800551+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8800560+04:30'
    WHERE [Id] = CAST(22 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8799094+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8799105+04:30'
    WHERE [Id] = CAST(23 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789109+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789120+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789201+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789203+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789207+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789209+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789213+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789215+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789218+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789220+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789224+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789226+04:30'
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789229+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789231+04:30'
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789234+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789236+04:30'
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789239+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789241+04:30'
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789244+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789246+04:30'
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789249+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789251+04:30'
    WHERE [Id] = CAST(11 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789254+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789256+04:30'
    WHERE [Id] = CAST(12 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789260+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789262+04:30'
    WHERE [Id] = CAST(13 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789265+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789268+04:30'
    WHERE [Id] = CAST(14 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789272+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789274+04:30'
    WHERE [Id] = CAST(15 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789277+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789279+04:30'
    WHERE [Id] = CAST(16 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789282+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789284+04:30'
    WHERE [Id] = CAST(17 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789287+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789289+04:30'
    WHERE [Id] = CAST(18 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789292+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789294+04:30'
    WHERE [Id] = CAST(19 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789297+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789299+04:30'
    WHERE [Id] = CAST(20 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789302+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789304+04:30'
    WHERE [Id] = CAST(21 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789307+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789309+04:30'
    WHERE [Id] = CAST(22 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789313+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789315+04:30'
    WHERE [Id] = CAST(23 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789318+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789320+04:30'
    WHERE [Id] = CAST(24 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789324+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789326+04:30'
    WHERE [Id] = CAST(25 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789329+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789331+04:30'
    WHERE [Id] = CAST(26 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789334+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789336+04:30'
    WHERE [Id] = CAST(27 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789338+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789340+04:30'
    WHERE [Id] = CAST(28 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789407+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789409+04:30'
    WHERE [Id] = CAST(29 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789412+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789414+04:30'
    WHERE [Id] = CAST(30 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789417+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789419+04:30'
    WHERE [Id] = CAST(31 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789422+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789424+04:30'
    WHERE [Id] = CAST(32 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789427+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789429+04:30'
    WHERE [Id] = CAST(33 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789433+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789435+04:30'
    WHERE [Id] = CAST(34 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789438+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789440+04:30'
    WHERE [Id] = CAST(35 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789448+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789450+04:30'
    WHERE [Id] = CAST(36 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789453+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789455+04:30'
    WHERE [Id] = CAST(37 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789458+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789460+04:30'
    WHERE [Id] = CAST(38 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789463+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789465+04:30'
    WHERE [Id] = CAST(39 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789468+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789470+04:30'
    WHERE [Id] = CAST(40 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789473+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789475+04:30'
    WHERE [Id] = CAST(41 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789478+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789480+04:30'
    WHERE [Id] = CAST(42 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789484+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789486+04:30'
    WHERE [Id] = CAST(43 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789489+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789491+04:30'
    WHERE [Id] = CAST(44 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789494+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789496+04:30'
    WHERE [Id] = CAST(45 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789499+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789501+04:30'
    WHERE [Id] = CAST(46 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8789443+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8789445+04:30'
    WHERE [Id] = CAST(47 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772155+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772192+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772307+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772309+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772314+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772316+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772319+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772322+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772325+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772328+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772332+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772335+04:30'
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772337+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772340+04:30'
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772342+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772344+04:30'
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772349+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772351+04:30'
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772354+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772356+04:30'
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772359+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772361+04:30'
    WHERE [Id] = CAST(11 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772364+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772366+04:30'
    WHERE [Id] = CAST(12 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772369+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772371+04:30'
    WHERE [Id] = CAST(13 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772450+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772452+04:30'
    WHERE [Id] = CAST(14 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772455+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772457+04:30'
    WHERE [Id] = CAST(15 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772460+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772462+04:30'
    WHERE [Id] = CAST(16 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772465+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772467+04:30'
    WHERE [Id] = CAST(17 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772470+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772474+04:30'
    WHERE [Id] = CAST(18 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772477+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772479+04:30'
    WHERE [Id] = CAST(19 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772482+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772484+04:30'
    WHERE [Id] = CAST(20 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772487+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772490+04:30'
    WHERE [Id] = CAST(21 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772493+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772495+04:30'
    WHERE [Id] = CAST(22 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772498+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772500+04:30'
    WHERE [Id] = CAST(23 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772503+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772505+04:30'
    WHERE [Id] = CAST(24 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772508+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772510+04:30'
    WHERE [Id] = CAST(25 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772514+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772516+04:30'
    WHERE [Id] = CAST(26 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772519+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772521+04:30'
    WHERE [Id] = CAST(27 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772525+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772527+04:30'
    WHERE [Id] = CAST(28 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772530+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772532+04:30'
    WHERE [Id] = CAST(29 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772535+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772537+04:30'
    WHERE [Id] = CAST(30 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772540+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772542+04:30'
    WHERE [Id] = CAST(31 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772545+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772547+04:30'
    WHERE [Id] = CAST(32 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772550+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772552+04:30'
    WHERE [Id] = CAST(33 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772555+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772557+04:30'
    WHERE [Id] = CAST(34 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772560+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772562+04:30'
    WHERE [Id] = CAST(35 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772565+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772567+04:30'
    WHERE [Id] = CAST(36 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772570+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772572+04:30'
    WHERE [Id] = CAST(37 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772575+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772578+04:30'
    WHERE [Id] = CAST(38 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772581+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772583+04:30'
    WHERE [Id] = CAST(39 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772586+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772588+04:30'
    WHERE [Id] = CAST(40 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772591+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772593+04:30'
    WHERE [Id] = CAST(41 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772596+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772598+04:30'
    WHERE [Id] = CAST(42 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772600+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772602+04:30'
    WHERE [Id] = CAST(43 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772605+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772607+04:30'
    WHERE [Id] = CAST(44 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772610+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772612+04:30'
    WHERE [Id] = CAST(45 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772615+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772618+04:30'
    WHERE [Id] = CAST(46 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772621+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772623+04:30'
    WHERE [Id] = CAST(47 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772627+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772629+04:30'
    WHERE [Id] = CAST(48 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772632+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772634+04:30'
    WHERE [Id] = CAST(49 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772637+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772639+04:30'
    WHERE [Id] = CAST(50 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772642+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772644+04:30'
    WHERE [Id] = CAST(51 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772647+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772649+04:30'
    WHERE [Id] = CAST(52 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772652+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772654+04:30'
    WHERE [Id] = CAST(53 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772657+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772659+04:30'
    WHERE [Id] = CAST(54 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772662+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772664+04:30'
    WHERE [Id] = CAST(55 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772667+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772669+04:30'
    WHERE [Id] = CAST(56 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772672+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772675+04:30'
    WHERE [Id] = CAST(57 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772678+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772680+04:30'
    WHERE [Id] = CAST(58 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772683+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772685+04:30'
    WHERE [Id] = CAST(59 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772688+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772690+04:30'
    WHERE [Id] = CAST(60 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772693+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772695+04:30'
    WHERE [Id] = CAST(61 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772698+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772700+04:30'
    WHERE [Id] = CAST(62 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772703+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772704+04:30'
    WHERE [Id] = CAST(63 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772707+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772709+04:30'
    WHERE [Id] = CAST(64 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772712+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772714+04:30'
    WHERE [Id] = CAST(65 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772717+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772719+04:30'
    WHERE [Id] = CAST(66 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772723+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772725+04:30'
    WHERE [Id] = CAST(67 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772728+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772730+04:30'
    WHERE [Id] = CAST(68 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772733+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772735+04:30'
    WHERE [Id] = CAST(69 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772738+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772740+04:30'
    WHERE [Id] = CAST(70 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772743+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772745+04:30'
    WHERE [Id] = CAST(71 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772749+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772751+04:30'
    WHERE [Id] = CAST(72 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772754+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772756+04:30'
    WHERE [Id] = CAST(73 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772759+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772761+04:30'
    WHERE [Id] = CAST(74 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772764+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772766+04:30'
    WHERE [Id] = CAST(75 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772771+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772773+04:30'
    WHERE [Id] = CAST(76 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772777+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772779+04:30'
    WHERE [Id] = CAST(77 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772875+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772878+04:30'
    WHERE [Id] = CAST(78 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772881+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772883+04:30'
    WHERE [Id] = CAST(79 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772886+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772888+04:30'
    WHERE [Id] = CAST(80 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772891+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772893+04:30'
    WHERE [Id] = CAST(81 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772896+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772898+04:30'
    WHERE [Id] = CAST(82 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772900+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772902+04:30'
    WHERE [Id] = CAST(83 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772905+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772907+04:30'
    WHERE [Id] = CAST(84 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772910+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772912+04:30'
    WHERE [Id] = CAST(85 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772915+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772917+04:30'
    WHERE [Id] = CAST(86 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772921+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772923+04:30'
    WHERE [Id] = CAST(87 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772926+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772929+04:30'
    WHERE [Id] = CAST(88 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772932+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772933+04:30'
    WHERE [Id] = CAST(89 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772937+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772938+04:30'
    WHERE [Id] = CAST(90 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772942+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772944+04:30'
    WHERE [Id] = CAST(91 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772946+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772948+04:30'
    WHERE [Id] = CAST(92 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772951+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772953+04:30'
    WHERE [Id] = CAST(93 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772956+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772958+04:30'
    WHERE [Id] = CAST(94 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772961+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772963+04:30'
    WHERE [Id] = CAST(95 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772966+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772969+04:30'
    WHERE [Id] = CAST(96 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772972+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772974+04:30'
    WHERE [Id] = CAST(97 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772977+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772979+04:30'
    WHERE [Id] = CAST(98 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772982+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772984+04:30'
    WHERE [Id] = CAST(99 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772987+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772989+04:30'
    WHERE [Id] = CAST(100 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772992+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8772994+04:30'
    WHERE [Id] = CAST(101 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8772998+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773000+04:30'
    WHERE [Id] = CAST(102 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773002+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773004+04:30'
    WHERE [Id] = CAST(103 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773007+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773009+04:30'
    WHERE [Id] = CAST(104 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773012+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773015+04:30'
    WHERE [Id] = CAST(105 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773021+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773024+04:30'
    WHERE [Id] = CAST(106 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773027+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773029+04:30'
    WHERE [Id] = CAST(107 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773032+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773034+04:30'
    WHERE [Id] = CAST(108 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773037+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773039+04:30'
    WHERE [Id] = CAST(109 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773042+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773044+04:30'
    WHERE [Id] = CAST(110 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773047+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773049+04:30'
    WHERE [Id] = CAST(111 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773052+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773054+04:30'
    WHERE [Id] = CAST(112 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773057+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773059+04:30'
    WHERE [Id] = CAST(113 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773062+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773064+04:30'
    WHERE [Id] = CAST(114 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773067+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773069+04:30'
    WHERE [Id] = CAST(115 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773073+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773075+04:30'
    WHERE [Id] = CAST(116 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773078+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773080+04:30'
    WHERE [Id] = CAST(117 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773083+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773085+04:30'
    WHERE [Id] = CAST(118 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773088+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773090+04:30'
    WHERE [Id] = CAST(119 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773093+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773095+04:30'
    WHERE [Id] = CAST(120 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773098+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773100+04:30'
    WHERE [Id] = CAST(121 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773103+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773105+04:30'
    WHERE [Id] = CAST(122 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773108+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773110+04:30'
    WHERE [Id] = CAST(123 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773113+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773115+04:30'
    WHERE [Id] = CAST(124 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773118+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773120+04:30'
    WHERE [Id] = CAST(125 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773124+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773126+04:30'
    WHERE [Id] = CAST(126 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773129+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773131+04:30'
    WHERE [Id] = CAST(127 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773134+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773136+04:30'
    WHERE [Id] = CAST(128 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773139+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773141+04:30'
    WHERE [Id] = CAST(129 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773144+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773146+04:30'
    WHERE [Id] = CAST(130 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773149+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773151+04:30'
    WHERE [Id] = CAST(131 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773154+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773156+04:30'
    WHERE [Id] = CAST(132 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773159+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773161+04:30'
    WHERE [Id] = CAST(133 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773164+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773166+04:30'
    WHERE [Id] = CAST(134 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773169+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773172+04:30'
    WHERE [Id] = CAST(135 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773175+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773177+04:30'
    WHERE [Id] = CAST(136 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773180+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773182+04:30'
    WHERE [Id] = CAST(137 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773185+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773187+04:30'
    WHERE [Id] = CAST(138 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773190+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773192+04:30'
    WHERE [Id] = CAST(139 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773195+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773197+04:30'
    WHERE [Id] = CAST(140 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773199+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773201+04:30'
    WHERE [Id] = CAST(141 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773321+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773324+04:30'
    WHERE [Id] = CAST(142 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773327+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773329+04:30'
    WHERE [Id] = CAST(143 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773332+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773334+04:30'
    WHERE [Id] = CAST(144 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773338+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773340+04:30'
    WHERE [Id] = CAST(145 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773343+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773345+04:30'
    WHERE [Id] = CAST(146 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773348+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773350+04:30'
    WHERE [Id] = CAST(147 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773353+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773355+04:30'
    WHERE [Id] = CAST(148 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773358+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773360+04:30'
    WHERE [Id] = CAST(149 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773363+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773365+04:30'
    WHERE [Id] = CAST(150 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773368+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773370+04:30'
    WHERE [Id] = CAST(151 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773373+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773375+04:30'
    WHERE [Id] = CAST(152 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773378+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773380+04:30'
    WHERE [Id] = CAST(153 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773383+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773385+04:30'
    WHERE [Id] = CAST(154 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773389+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773391+04:30'
    WHERE [Id] = CAST(155 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773394+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773396+04:30'
    WHERE [Id] = CAST(156 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773399+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773401+04:30'
    WHERE [Id] = CAST(157 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773404+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773406+04:30'
    WHERE [Id] = CAST(158 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773409+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773411+04:30'
    WHERE [Id] = CAST(159 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773414+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773416+04:30'
    WHERE [Id] = CAST(160 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773419+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773421+04:30'
    WHERE [Id] = CAST(161 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773424+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773426+04:30'
    WHERE [Id] = CAST(162 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773429+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773431+04:30'
    WHERE [Id] = CAST(163 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773434+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773436+04:30'
    WHERE [Id] = CAST(164 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773440+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773442+04:30'
    WHERE [Id] = CAST(165 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773444+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773446+04:30'
    WHERE [Id] = CAST(166 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773451+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773453+04:30'
    WHERE [Id] = CAST(167 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773456+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773459+04:30'
    WHERE [Id] = CAST(168 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773462+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773463+04:30'
    WHERE [Id] = CAST(169 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773466+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773468+04:30'
    WHERE [Id] = CAST(170 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773471+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773473+04:30'
    WHERE [Id] = CAST(171 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773476+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773478+04:30'
    WHERE [Id] = CAST(172 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773481+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773483+04:30'
    WHERE [Id] = CAST(173 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773486+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773489+04:30'
    WHERE [Id] = CAST(174 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773492+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773494+04:30'
    WHERE [Id] = CAST(175 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773497+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773499+04:30'
    WHERE [Id] = CAST(176 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773502+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773504+04:30'
    WHERE [Id] = CAST(177 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773507+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773510+04:30'
    WHERE [Id] = CAST(178 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773513+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773515+04:30'
    WHERE [Id] = CAST(179 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773518+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773520+04:30'
    WHERE [Id] = CAST(180 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773523+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773525+04:30'
    WHERE [Id] = CAST(181 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773528+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773530+04:30'
    WHERE [Id] = CAST(182 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773533+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773535+04:30'
    WHERE [Id] = CAST(183 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773539+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773541+04:30'
    WHERE [Id] = CAST(184 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773544+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773546+04:30'
    WHERE [Id] = CAST(185 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773549+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773551+04:30'
    WHERE [Id] = CAST(186 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773554+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773556+04:30'
    WHERE [Id] = CAST(187 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773560+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773562+04:30'
    WHERE [Id] = CAST(188 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773565+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773567+04:30'
    WHERE [Id] = CAST(189 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773570+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773572+04:30'
    WHERE [Id] = CAST(190 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773575+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773577+04:30'
    WHERE [Id] = CAST(191 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773580+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773582+04:30'
    WHERE [Id] = CAST(192 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773585+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773587+04:30'
    WHERE [Id] = CAST(193 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773591+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773593+04:30'
    WHERE [Id] = CAST(194 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773596+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773598+04:30'
    WHERE [Id] = CAST(195 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773601+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773603+04:30'
    WHERE [Id] = CAST(196 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773606+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773608+04:30'
    WHERE [Id] = CAST(197 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773611+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773613+04:30'
    WHERE [Id] = CAST(198 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773616+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773618+04:30'
    WHERE [Id] = CAST(199 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773620+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773622+04:30'
    WHERE [Id] = CAST(200 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773625+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773627+04:30'
    WHERE [Id] = CAST(201 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773630+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773632+04:30'
    WHERE [Id] = CAST(202 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773635+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773637+04:30'
    WHERE [Id] = CAST(203 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773641+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773643+04:30'
    WHERE [Id] = CAST(204 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773691+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773694+04:30'
    WHERE [Id] = CAST(205 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773697+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773699+04:30'
    WHERE [Id] = CAST(206 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773702+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773704+04:30'
    WHERE [Id] = CAST(207 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773707+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773709+04:30'
    WHERE [Id] = CAST(208 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773712+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773714+04:30'
    WHERE [Id] = CAST(209 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8773717+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8773719+04:30'
    WHERE [Id] = CAST(210 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784196+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784208+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784295+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784298+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784301+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784303+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784307+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784308+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784311+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784313+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784317+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784319+04:30'
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784324+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784326+04:30'
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784329+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784331+04:30'
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784334+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784336+04:30'
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784339+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784341+04:30'
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784344+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784346+04:30'
    WHERE [Id] = CAST(11 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784349+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784351+04:30'
    WHERE [Id] = CAST(12 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784354+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784356+04:30'
    WHERE [Id] = CAST(13 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784359+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784361+04:30'
    WHERE [Id] = CAST(14 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784366+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784368+04:30'
    WHERE [Id] = CAST(15 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784371+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784373+04:30'
    WHERE [Id] = CAST(16 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784377+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784379+04:30'
    WHERE [Id] = CAST(17 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784382+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784384+04:30'
    WHERE [Id] = CAST(18 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784386+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784388+04:30'
    WHERE [Id] = CAST(19 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784392+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784394+04:30'
    WHERE [Id] = CAST(20 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784397+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784399+04:30'
    WHERE [Id] = CAST(21 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784402+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784404+04:30'
    WHERE [Id] = CAST(22 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784407+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784409+04:30'
    WHERE [Id] = CAST(23 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784412+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784414+04:30'
    WHERE [Id] = CAST(24 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784417+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784419+04:30'
    WHERE [Id] = CAST(25 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784422+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784425+04:30'
    WHERE [Id] = CAST(26 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784428+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784430+04:30'
    WHERE [Id] = CAST(27 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784433+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784435+04:30'
    WHERE [Id] = CAST(28 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784438+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784440+04:30'
    WHERE [Id] = CAST(29 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784443+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784445+04:30'
    WHERE [Id] = CAST(30 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784448+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784450+04:30'
    WHERE [Id] = CAST(31 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784452+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784454+04:30'
    WHERE [Id] = CAST(32 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784457+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784459+04:30'
    WHERE [Id] = CAST(33 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784463+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784465+04:30'
    WHERE [Id] = CAST(34 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784468+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784470+04:30'
    WHERE [Id] = CAST(35 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784474+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784476+04:30'
    WHERE [Id] = CAST(36 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784478+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784480+04:30'
    WHERE [Id] = CAST(37 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784483+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784485+04:30'
    WHERE [Id] = CAST(38 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784488+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784490+04:30'
    WHERE [Id] = CAST(39 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784493+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784495+04:30'
    WHERE [Id] = CAST(40 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784498+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784500+04:30'
    WHERE [Id] = CAST(41 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784503+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784505+04:30'
    WHERE [Id] = CAST(42 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784508+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784510+04:30'
    WHERE [Id] = CAST(43 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784513+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784515+04:30'
    WHERE [Id] = CAST(44 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784518+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784520+04:30'
    WHERE [Id] = CAST(45 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784524+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784526+04:30'
    WHERE [Id] = CAST(46 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784529+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784531+04:30'
    WHERE [Id] = CAST(47 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784534+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784536+04:30'
    WHERE [Id] = CAST(48 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784539+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784541+04:30'
    WHERE [Id] = CAST(49 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784544+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784546+04:30'
    WHERE [Id] = CAST(50 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784548+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784551+04:30'
    WHERE [Id] = CAST(51 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784553+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784555+04:30'
    WHERE [Id] = CAST(52 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784621+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784623+04:30'
    WHERE [Id] = CAST(53 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784626+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784628+04:30'
    WHERE [Id] = CAST(54 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784631+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784635+04:30'
    WHERE [Id] = CAST(55 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784638+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784640+04:30'
    WHERE [Id] = CAST(56 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784643+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784645+04:30'
    WHERE [Id] = CAST(57 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784648+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784650+04:30'
    WHERE [Id] = CAST(58 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784653+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784655+04:30'
    WHERE [Id] = CAST(59 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784658+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784660+04:30'
    WHERE [Id] = CAST(60 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784663+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784665+04:30'
    WHERE [Id] = CAST(61 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784668+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784670+04:30'
    WHERE [Id] = CAST(62 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784673+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784675+04:30'
    WHERE [Id] = CAST(63 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784678+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784680+04:30'
    WHERE [Id] = CAST(64 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784684+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784686+04:30'
    WHERE [Id] = CAST(65 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784689+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784691+04:30'
    WHERE [Id] = CAST(66 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784694+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784696+04:30'
    WHERE [Id] = CAST(67 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784699+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784701+04:30'
    WHERE [Id] = CAST(68 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784704+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784706+04:30'
    WHERE [Id] = CAST(69 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784709+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784711+04:30'
    WHERE [Id] = CAST(70 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784714+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784716+04:30'
    WHERE [Id] = CAST(71 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784718+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784720+04:30'
    WHERE [Id] = CAST(72 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784723+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784725+04:30'
    WHERE [Id] = CAST(73 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784728+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784730+04:30'
    WHERE [Id] = CAST(74 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784734+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784736+04:30'
    WHERE [Id] = CAST(75 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784739+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784741+04:30'
    WHERE [Id] = CAST(76 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784744+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784746+04:30'
    WHERE [Id] = CAST(77 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784749+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784751+04:30'
    WHERE [Id] = CAST(78 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784756+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784758+04:30'
    WHERE [Id] = CAST(79 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784761+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784763+04:30'
    WHERE [Id] = CAST(80 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784766+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784768+04:30'
    WHERE [Id] = CAST(81 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784771+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784773+04:30'
    WHERE [Id] = CAST(82 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784776+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784778+04:30'
    WHERE [Id] = CAST(83 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784781+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784783+04:30'
    WHERE [Id] = CAST(84 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784787+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784789+04:30'
    WHERE [Id] = CAST(85 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784792+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784794+04:30'
    WHERE [Id] = CAST(86 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784797+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784799+04:30'
    WHERE [Id] = CAST(87 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784802+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784804+04:30'
    WHERE [Id] = CAST(88 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784806+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784808+04:30'
    WHERE [Id] = CAST(90 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784811+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784813+04:30'
    WHERE [Id] = CAST(91 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784816+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784818+04:30'
    WHERE [Id] = CAST(92 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784821+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784823+04:30'
    WHERE [Id] = CAST(93 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784826+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784828+04:30'
    WHERE [Id] = CAST(94 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784832+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784834+04:30'
    WHERE [Id] = CAST(95 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784837+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784839+04:30'
    WHERE [Id] = CAST(96 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784842+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784844+04:30'
    WHERE [Id] = CAST(97 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784847+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784849+04:30'
    WHERE [Id] = CAST(98 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784852+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784854+04:30'
    WHERE [Id] = CAST(99 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784857+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784859+04:30'
    WHERE [Id] = CAST(100 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784862+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784864+04:30'
    WHERE [Id] = CAST(101 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784867+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784869+04:30'
    WHERE [Id] = CAST(102 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784872+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784874+04:30'
    WHERE [Id] = CAST(103 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784877+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784879+04:30'
    WHERE [Id] = CAST(104 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784883+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784885+04:30'
    WHERE [Id] = CAST(105 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784888+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784890+04:30'
    WHERE [Id] = CAST(106 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784893+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784895+04:30'
    WHERE [Id] = CAST(107 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784897+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784899+04:30'
    WHERE [Id] = CAST(108 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784902+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784904+04:30'
    WHERE [Id] = CAST(109 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784907+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784909+04:30'
    WHERE [Id] = CAST(110 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784912+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784914+04:30'
    WHERE [Id] = CAST(111 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784917+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784919+04:30'
    WHERE [Id] = CAST(112 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784922+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784924+04:30'
    WHERE [Id] = CAST(113 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784971+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784973+04:30'
    WHERE [Id] = CAST(114 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784977+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784979+04:30'
    WHERE [Id] = CAST(115 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784982+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784984+04:30'
    WHERE [Id] = CAST(116 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784992+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784994+04:30'
    WHERE [Id] = CAST(117 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784997+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784999+04:30'
    WHERE [Id] = CAST(118 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8785002+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8785004+04:30'
    WHERE [Id] = CAST(119 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8785007+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8785009+04:30'
    WHERE [Id] = CAST(120 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8785012+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8785014+04:30'
    WHERE [Id] = CAST(121 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8785017+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8785019+04:30'
    WHERE [Id] = CAST(122 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8785022+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8785025+04:30'
    WHERE [Id] = CAST(123 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8785027+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8785029+04:30'
    WHERE [Id] = CAST(124 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8785032+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8785034+04:30'
    WHERE [Id] = CAST(125 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8785037+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8785039+04:30'
    WHERE [Id] = CAST(126 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8785042+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8785044+04:30'
    WHERE [Id] = CAST(127 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8784987+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8784989+04:30'
    WHERE [Id] = CAST(128 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8777295+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8777307+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8777465+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8777467+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8777471+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8777473+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8777476+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8777478+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8777481+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8777483+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8777486+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8777488+04:30'
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8777491+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8777493+04:30'
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8777496+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8777498+04:30'
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8777501+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8777503+04:30'
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8777505+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8777507+04:30'
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-11-29T12:43:45.8777510+04:30', [UpdatedAt] = '2021-11-29T12:43:45.8777512+04:30'
    WHERE [Id] = CAST(11 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211129081348_EmployeeSalaries')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211129081348_EmployeeSalaries', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    ALTER TABLE [wms_unit_tbl] ADD [KgAmount] real NOT NULL DEFAULT CAST(0 AS real);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_assets_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8957054+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8957071+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_assets_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8959162+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8959177+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_assets_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8959222+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8959225+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_assets_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8959230+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8959233+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_assets_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8959237+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8959241+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8940491+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8940536+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8945667+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8945691+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8945840+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8945844+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8945848+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8945852+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8945857+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8945861+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8945865+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8945868+04:30'
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8945873+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8945875+04:30'
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8946059+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8946064+04:30'
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8946071+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8946073+04:30'
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8946078+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8946081+04:30'
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8875109+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8876672+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8878906+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8878939+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8878999+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8879003+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8879006+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8879009+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8879015+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8879017+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8879022+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8879025+04:30'
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8879029+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8879032+04:30'
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8879036+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8879039+04:30'
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8879044+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8879047+04:30'
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8879051+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8879054+04:30'
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8879058+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8879061+04:30'
    WHERE [Id] = CAST(12 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_country_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8921946+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8921959+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_country_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8922033+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8922035+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_country_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8922038+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8922041+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_country_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8922044+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8922046+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_country_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8922048+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8922050+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_designation_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8949222+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8949241+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_designation_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8949309+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8949314+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_designation_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8949318+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8949320+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_designation_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8949326+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8949328+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_designation_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8949331+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8949334+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_designation_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8949337+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8949340+04:30'
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_designation_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8949343+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8949346+04:30'
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8954355+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8954357+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8954348+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8954351+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8954342+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8954344+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8954335+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8954338+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8954328+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8954332+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8954322+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8954325+04:30'
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8954314+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8954318+04:30'
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8954307+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8954309+04:30'
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8954299+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8954302+04:30'
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8954292+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8954295+04:30'
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8954286+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8954288+04:30'
    WHERE [Id] = CAST(11 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8954279+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8954282+04:30'
    WHERE [Id] = CAST(12 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8954273+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8954275+04:30'
    WHERE [Id] = CAST(13 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8954267+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8954269+04:30'
    WHERE [Id] = CAST(14 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8954261+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8954263+04:30'
    WHERE [Id] = CAST(15 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8954254+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8954257+04:30'
    WHERE [Id] = CAST(16 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8954246+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8954250+04:30'
    WHERE [Id] = CAST(17 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8954239+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8954242+04:30'
    WHERE [Id] = CAST(18 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8954233+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8954235+04:30'
    WHERE [Id] = CAST(19 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8954227+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8954229+04:30'
    WHERE [Id] = CAST(20 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8954220+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8954223+04:30'
    WHERE [Id] = CAST(21 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8954155+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8954171+04:30'
    WHERE [Id] = CAST(22 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8952127+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8952144+04:30'
    WHERE [Id] = CAST(23 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8933779+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8933796+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8933922+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8933926+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8933932+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8933936+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8933941+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8933945+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8933949+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8933953+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8933958+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8933961+04:30'
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8933966+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8933969+04:30'
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8933973+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8933976+04:30'
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8933981+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8933984+04:30'
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8933989+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8933992+04:30'
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8933998+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934001+04:30'
    WHERE [Id] = CAST(11 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934006+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934009+04:30'
    WHERE [Id] = CAST(12 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934013+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934017+04:30'
    WHERE [Id] = CAST(13 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934021+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934025+04:30'
    WHERE [Id] = CAST(14 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934031+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934034+04:30'
    WHERE [Id] = CAST(15 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934039+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934042+04:30'
    WHERE [Id] = CAST(16 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934047+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934050+04:30'
    WHERE [Id] = CAST(17 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934055+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934058+04:30'
    WHERE [Id] = CAST(18 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934063+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934066+04:30'
    WHERE [Id] = CAST(19 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934071+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934074+04:30'
    WHERE [Id] = CAST(20 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934079+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934082+04:30'
    WHERE [Id] = CAST(21 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934086+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934090+04:30'
    WHERE [Id] = CAST(22 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934094+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934098+04:30'
    WHERE [Id] = CAST(23 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934103+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934106+04:30'
    WHERE [Id] = CAST(24 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934112+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934115+04:30'
    WHERE [Id] = CAST(25 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934119+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934123+04:30'
    WHERE [Id] = CAST(26 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934127+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934130+04:30'
    WHERE [Id] = CAST(27 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934135+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934138+04:30'
    WHERE [Id] = CAST(28 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934143+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934146+04:30'
    WHERE [Id] = CAST(29 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934151+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934154+04:30'
    WHERE [Id] = CAST(30 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934158+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934162+04:30'
    WHERE [Id] = CAST(31 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934166+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934169+04:30'
    WHERE [Id] = CAST(32 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934174+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934177+04:30'
    WHERE [Id] = CAST(33 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934182+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934186+04:30'
    WHERE [Id] = CAST(34 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934190+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934194+04:30'
    WHERE [Id] = CAST(35 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934207+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934210+04:30'
    WHERE [Id] = CAST(36 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934215+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934218+04:30'
    WHERE [Id] = CAST(37 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934222+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934226+04:30'
    WHERE [Id] = CAST(38 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934230+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934233+04:30'
    WHERE [Id] = CAST(39 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934238+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934241+04:30'
    WHERE [Id] = CAST(40 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934246+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934249+04:30'
    WHERE [Id] = CAST(41 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934254+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934257+04:30'
    WHERE [Id] = CAST(42 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934261+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934264+04:30'
    WHERE [Id] = CAST(43 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934269+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934272+04:30'
    WHERE [Id] = CAST(44 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934277+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934280+04:30'
    WHERE [Id] = CAST(45 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934285+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934288+04:30'
    WHERE [Id] = CAST(46 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8934198+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8934202+04:30'
    WHERE [Id] = CAST(47 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911368+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911409+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911568+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911571+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911577+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911580+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911583+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911587+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911591+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911594+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911598+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911602+04:30'
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911606+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911608+04:30'
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911614+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911618+04:30'
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911623+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911627+04:30'
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911631+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911635+04:30'
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911639+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911642+04:30'
    WHERE [Id] = CAST(11 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911646+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911650+04:30'
    WHERE [Id] = CAST(12 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911654+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911657+04:30'
    WHERE [Id] = CAST(13 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911661+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911665+04:30'
    WHERE [Id] = CAST(14 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911669+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911673+04:30'
    WHERE [Id] = CAST(15 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911678+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911681+04:30'
    WHERE [Id] = CAST(16 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911685+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911688+04:30'
    WHERE [Id] = CAST(17 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911693+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911697+04:30'
    WHERE [Id] = CAST(18 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911701+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911704+04:30'
    WHERE [Id] = CAST(19 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911708+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911712+04:30'
    WHERE [Id] = CAST(20 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911716+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911719+04:30'
    WHERE [Id] = CAST(21 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911724+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911728+04:30'
    WHERE [Id] = CAST(22 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911732+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911736+04:30'
    WHERE [Id] = CAST(23 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911740+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911743+04:30'
    WHERE [Id] = CAST(24 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911748+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911751+04:30'
    WHERE [Id] = CAST(25 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911755+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911758+04:30'
    WHERE [Id] = CAST(26 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911762+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911765+04:30'
    WHERE [Id] = CAST(27 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911769+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911772+04:30'
    WHERE [Id] = CAST(28 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911777+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911780+04:30'
    WHERE [Id] = CAST(29 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911783+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911786+04:30'
    WHERE [Id] = CAST(30 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911790+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911793+04:30'
    WHERE [Id] = CAST(31 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911797+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911800+04:30'
    WHERE [Id] = CAST(32 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911805+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911807+04:30'
    WHERE [Id] = CAST(33 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911811+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911814+04:30'
    WHERE [Id] = CAST(34 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911818+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911821+04:30'
    WHERE [Id] = CAST(35 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911825+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911827+04:30'
    WHERE [Id] = CAST(36 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911834+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911837+04:30'
    WHERE [Id] = CAST(37 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911841+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911844+04:30'
    WHERE [Id] = CAST(38 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911848+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911851+04:30'
    WHERE [Id] = CAST(39 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911855+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911858+04:30'
    WHERE [Id] = CAST(40 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911862+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911865+04:30'
    WHERE [Id] = CAST(41 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911868+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911871+04:30'
    WHERE [Id] = CAST(42 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911876+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911879+04:30'
    WHERE [Id] = CAST(43 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911883+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911886+04:30'
    WHERE [Id] = CAST(44 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911890+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911893+04:30'
    WHERE [Id] = CAST(45 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911897+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911900+04:30'
    WHERE [Id] = CAST(46 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911904+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911908+04:30'
    WHERE [Id] = CAST(47 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911913+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911916+04:30'
    WHERE [Id] = CAST(48 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911920+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911923+04:30'
    WHERE [Id] = CAST(49 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8911928+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8911931+04:30'
    WHERE [Id] = CAST(50 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912072+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912076+04:30'
    WHERE [Id] = CAST(51 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912081+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912084+04:30'
    WHERE [Id] = CAST(52 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912088+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912091+04:30'
    WHERE [Id] = CAST(53 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912095+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912098+04:30'
    WHERE [Id] = CAST(54 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912102+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912106+04:30'
    WHERE [Id] = CAST(55 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912110+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912114+04:30'
    WHERE [Id] = CAST(56 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912118+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912122+04:30'
    WHERE [Id] = CAST(57 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912126+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912129+04:30'
    WHERE [Id] = CAST(58 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912133+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912136+04:30'
    WHERE [Id] = CAST(59 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912140+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912144+04:30'
    WHERE [Id] = CAST(60 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912147+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912151+04:30'
    WHERE [Id] = CAST(61 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912154+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912158+04:30'
    WHERE [Id] = CAST(62 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912162+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912165+04:30'
    WHERE [Id] = CAST(63 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912169+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912172+04:30'
    WHERE [Id] = CAST(64 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912176+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912179+04:30'
    WHERE [Id] = CAST(65 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912183+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912186+04:30'
    WHERE [Id] = CAST(66 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912191+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912194+04:30'
    WHERE [Id] = CAST(67 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912198+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912201+04:30'
    WHERE [Id] = CAST(68 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912205+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912209+04:30'
    WHERE [Id] = CAST(69 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912213+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912216+04:30'
    WHERE [Id] = CAST(70 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912220+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912223+04:30'
    WHERE [Id] = CAST(71 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912227+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912229+04:30'
    WHERE [Id] = CAST(72 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912233+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912236+04:30'
    WHERE [Id] = CAST(73 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912240+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912243+04:30'
    WHERE [Id] = CAST(74 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912246+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912249+04:30'
    WHERE [Id] = CAST(75 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912252+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912255+04:30'
    WHERE [Id] = CAST(76 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912260+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912262+04:30'
    WHERE [Id] = CAST(77 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912267+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912270+04:30'
    WHERE [Id] = CAST(78 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912276+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912279+04:30'
    WHERE [Id] = CAST(79 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912283+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912312+04:30'
    WHERE [Id] = CAST(80 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912317+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912320+04:30'
    WHERE [Id] = CAST(81 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912324+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912327+04:30'
    WHERE [Id] = CAST(82 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912331+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912334+04:30'
    WHERE [Id] = CAST(83 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912338+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912342+04:30'
    WHERE [Id] = CAST(84 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912346+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912349+04:30'
    WHERE [Id] = CAST(85 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912354+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912357+04:30'
    WHERE [Id] = CAST(86 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912361+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912363+04:30'
    WHERE [Id] = CAST(87 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912367+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912371+04:30'
    WHERE [Id] = CAST(88 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912375+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912377+04:30'
    WHERE [Id] = CAST(89 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912382+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912385+04:30'
    WHERE [Id] = CAST(90 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912389+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912392+04:30'
    WHERE [Id] = CAST(91 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912396+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912398+04:30'
    WHERE [Id] = CAST(92 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912402+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912405+04:30'
    WHERE [Id] = CAST(93 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912409+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912412+04:30'
    WHERE [Id] = CAST(94 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912417+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912420+04:30'
    WHERE [Id] = CAST(95 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912424+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912428+04:30'
    WHERE [Id] = CAST(96 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912431+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912434+04:30'
    WHERE [Id] = CAST(97 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912439+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912441+04:30'
    WHERE [Id] = CAST(98 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912446+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912449+04:30'
    WHERE [Id] = CAST(99 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912453+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912457+04:30'
    WHERE [Id] = CAST(100 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912461+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912464+04:30'
    WHERE [Id] = CAST(101 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912468+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912472+04:30'
    WHERE [Id] = CAST(102 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912475+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912478+04:30'
    WHERE [Id] = CAST(103 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912483+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912486+04:30'
    WHERE [Id] = CAST(104 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912490+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912493+04:30'
    WHERE [Id] = CAST(105 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912498+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912502+04:30'
    WHERE [Id] = CAST(106 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912506+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912509+04:30'
    WHERE [Id] = CAST(107 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912513+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912516+04:30'
    WHERE [Id] = CAST(108 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912521+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912523+04:30'
    WHERE [Id] = CAST(109 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912528+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912531+04:30'
    WHERE [Id] = CAST(110 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912535+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912538+04:30'
    WHERE [Id] = CAST(111 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912542+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912546+04:30'
    WHERE [Id] = CAST(112 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912550+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912553+04:30'
    WHERE [Id] = CAST(113 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912556+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912563+04:30'
    WHERE [Id] = CAST(114 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912619+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912621+04:30'
    WHERE [Id] = CAST(115 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912625+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912627+04:30'
    WHERE [Id] = CAST(116 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912630+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912632+04:30'
    WHERE [Id] = CAST(117 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912635+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912637+04:30'
    WHERE [Id] = CAST(118 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912640+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912643+04:30'
    WHERE [Id] = CAST(119 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912646+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912648+04:30'
    WHERE [Id] = CAST(120 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912651+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912653+04:30'
    WHERE [Id] = CAST(121 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912656+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912658+04:30'
    WHERE [Id] = CAST(122 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912661+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912663+04:30'
    WHERE [Id] = CAST(123 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912666+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912668+04:30'
    WHERE [Id] = CAST(124 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912671+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912673+04:30'
    WHERE [Id] = CAST(125 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912678+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912681+04:30'
    WHERE [Id] = CAST(126 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912685+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912687+04:30'
    WHERE [Id] = CAST(127 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912690+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912692+04:30'
    WHERE [Id] = CAST(128 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912695+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912697+04:30'
    WHERE [Id] = CAST(129 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912700+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912702+04:30'
    WHERE [Id] = CAST(130 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912705+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912707+04:30'
    WHERE [Id] = CAST(131 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912710+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912712+04:30'
    WHERE [Id] = CAST(132 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912715+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912717+04:30'
    WHERE [Id] = CAST(133 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912720+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912722+04:30'
    WHERE [Id] = CAST(134 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912725+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912727+04:30'
    WHERE [Id] = CAST(135 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912730+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912732+04:30'
    WHERE [Id] = CAST(136 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912735+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912737+04:30'
    WHERE [Id] = CAST(137 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912740+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912742+04:30'
    WHERE [Id] = CAST(138 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912745+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912747+04:30'
    WHERE [Id] = CAST(139 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912750+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912752+04:30'
    WHERE [Id] = CAST(140 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912755+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912757+04:30'
    WHERE [Id] = CAST(141 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912760+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912762+04:30'
    WHERE [Id] = CAST(142 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912765+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912767+04:30'
    WHERE [Id] = CAST(143 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912770+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912772+04:30'
    WHERE [Id] = CAST(144 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912779+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912781+04:30'
    WHERE [Id] = CAST(145 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912784+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912786+04:30'
    WHERE [Id] = CAST(146 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912790+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912792+04:30'
    WHERE [Id] = CAST(147 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912794+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912796+04:30'
    WHERE [Id] = CAST(148 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912799+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912801+04:30'
    WHERE [Id] = CAST(149 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912804+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912806+04:30'
    WHERE [Id] = CAST(150 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912809+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912811+04:30'
    WHERE [Id] = CAST(151 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912815+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912817+04:30'
    WHERE [Id] = CAST(152 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912819+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912821+04:30'
    WHERE [Id] = CAST(153 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912824+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912826+04:30'
    WHERE [Id] = CAST(154 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912830+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912832+04:30'
    WHERE [Id] = CAST(155 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912835+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912837+04:30'
    WHERE [Id] = CAST(156 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912840+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912842+04:30'
    WHERE [Id] = CAST(157 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912845+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912847+04:30'
    WHERE [Id] = CAST(158 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912851+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912853+04:30'
    WHERE [Id] = CAST(159 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912858+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912860+04:30'
    WHERE [Id] = CAST(160 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912864+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912867+04:30'
    WHERE [Id] = CAST(161 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912871+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912874+04:30'
    WHERE [Id] = CAST(162 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912878+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912880+04:30'
    WHERE [Id] = CAST(163 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912884+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912887+04:30'
    WHERE [Id] = CAST(164 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912891+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912893+04:30'
    WHERE [Id] = CAST(165 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912897+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912900+04:30'
    WHERE [Id] = CAST(166 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912903+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912905+04:30'
    WHERE [Id] = CAST(167 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912909+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912912+04:30'
    WHERE [Id] = CAST(168 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912915+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912918+04:30'
    WHERE [Id] = CAST(169 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912922+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912924+04:30'
    WHERE [Id] = CAST(170 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912928+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912931+04:30'
    WHERE [Id] = CAST(171 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912935+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912937+04:30'
    WHERE [Id] = CAST(172 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912941+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912944+04:30'
    WHERE [Id] = CAST(173 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912949+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912953+04:30'
    WHERE [Id] = CAST(174 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912957+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912960+04:30'
    WHERE [Id] = CAST(175 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912965+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912968+04:30'
    WHERE [Id] = CAST(176 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912972+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912975+04:30'
    WHERE [Id] = CAST(177 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8912979+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8912982+04:30'
    WHERE [Id] = CAST(178 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913072+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913077+04:30'
    WHERE [Id] = CAST(179 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913082+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913086+04:30'
    WHERE [Id] = CAST(180 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913090+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913093+04:30'
    WHERE [Id] = CAST(181 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913098+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913101+04:30'
    WHERE [Id] = CAST(182 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913105+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913109+04:30'
    WHERE [Id] = CAST(183 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913114+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913118+04:30'
    WHERE [Id] = CAST(184 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913122+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913125+04:30'
    WHERE [Id] = CAST(185 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913131+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913134+04:30'
    WHERE [Id] = CAST(186 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913138+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913142+04:30'
    WHERE [Id] = CAST(187 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913146+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913149+04:30'
    WHERE [Id] = CAST(188 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913154+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913157+04:30'
    WHERE [Id] = CAST(189 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913161+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913164+04:30'
    WHERE [Id] = CAST(190 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913168+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913172+04:30'
    WHERE [Id] = CAST(191 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913176+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913179+04:30'
    WHERE [Id] = CAST(192 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913184+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913187+04:30'
    WHERE [Id] = CAST(193 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913192+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913195+04:30'
    WHERE [Id] = CAST(194 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913200+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913203+04:30'
    WHERE [Id] = CAST(195 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913208+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913211+04:30'
    WHERE [Id] = CAST(196 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913215+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913219+04:30'
    WHERE [Id] = CAST(197 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913223+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913226+04:30'
    WHERE [Id] = CAST(198 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913231+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913234+04:30'
    WHERE [Id] = CAST(199 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913239+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913242+04:30'
    WHERE [Id] = CAST(200 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913246+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913249+04:30'
    WHERE [Id] = CAST(201 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913253+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913256+04:30'
    WHERE [Id] = CAST(202 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913261+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913264+04:30'
    WHERE [Id] = CAST(203 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913269+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913272+04:30'
    WHERE [Id] = CAST(204 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913276+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913280+04:30'
    WHERE [Id] = CAST(205 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913284+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913287+04:30'
    WHERE [Id] = CAST(206 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913292+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913295+04:30'
    WHERE [Id] = CAST(207 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913299+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913303+04:30'
    WHERE [Id] = CAST(208 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913307+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913310+04:30'
    WHERE [Id] = CAST(209 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8913315+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8913318+04:30'
    WHERE [Id] = CAST(210 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8926863+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8926876+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8926962+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8926965+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8926969+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8926971+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8926974+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8926976+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8926980+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8926981+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8926984+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8926991+04:30'
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8926995+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8926997+04:30'
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927000+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927003+04:30'
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927006+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927008+04:30'
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927012+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927014+04:30'
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927017+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927019+04:30'
    WHERE [Id] = CAST(11 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927022+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927023+04:30'
    WHERE [Id] = CAST(12 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927027+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927029+04:30'
    WHERE [Id] = CAST(13 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927033+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927035+04:30'
    WHERE [Id] = CAST(14 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927038+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927040+04:30'
    WHERE [Id] = CAST(15 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927043+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927046+04:30'
    WHERE [Id] = CAST(16 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927049+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927051+04:30'
    WHERE [Id] = CAST(17 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927054+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927056+04:30'
    WHERE [Id] = CAST(18 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927059+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927061+04:30'
    WHERE [Id] = CAST(19 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927064+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927066+04:30'
    WHERE [Id] = CAST(20 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927074+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927076+04:30'
    WHERE [Id] = CAST(21 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927080+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927083+04:30'
    WHERE [Id] = CAST(22 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927087+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927090+04:30'
    WHERE [Id] = CAST(23 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927094+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927096+04:30'
    WHERE [Id] = CAST(24 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927100+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927103+04:30'
    WHERE [Id] = CAST(25 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927107+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927111+04:30'
    WHERE [Id] = CAST(26 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927115+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927118+04:30'
    WHERE [Id] = CAST(27 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927217+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927221+04:30'
    WHERE [Id] = CAST(28 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927226+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927229+04:30'
    WHERE [Id] = CAST(29 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927233+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927236+04:30'
    WHERE [Id] = CAST(30 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927240+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927242+04:30'
    WHERE [Id] = CAST(31 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927247+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927249+04:30'
    WHERE [Id] = CAST(32 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927254+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927257+04:30'
    WHERE [Id] = CAST(33 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927261+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927264+04:30'
    WHERE [Id] = CAST(34 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927268+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927271+04:30'
    WHERE [Id] = CAST(35 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927276+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927279+04:30'
    WHERE [Id] = CAST(36 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927283+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927286+04:30'
    WHERE [Id] = CAST(37 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927290+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927293+04:30'
    WHERE [Id] = CAST(38 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927297+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927301+04:30'
    WHERE [Id] = CAST(39 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927304+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927307+04:30'
    WHERE [Id] = CAST(40 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927311+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927314+04:30'
    WHERE [Id] = CAST(41 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927318+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927321+04:30'
    WHERE [Id] = CAST(42 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927326+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927329+04:30'
    WHERE [Id] = CAST(43 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927333+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927336+04:30'
    WHERE [Id] = CAST(44 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927340+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927343+04:30'
    WHERE [Id] = CAST(45 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927348+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927351+04:30'
    WHERE [Id] = CAST(46 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927356+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927359+04:30'
    WHERE [Id] = CAST(47 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927364+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927367+04:30'
    WHERE [Id] = CAST(48 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927371+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927374+04:30'
    WHERE [Id] = CAST(49 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927378+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927380+04:30'
    WHERE [Id] = CAST(50 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927385+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927388+04:30'
    WHERE [Id] = CAST(51 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927392+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927395+04:30'
    WHERE [Id] = CAST(52 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927399+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927402+04:30'
    WHERE [Id] = CAST(53 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927406+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927408+04:30'
    WHERE [Id] = CAST(54 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927412+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927416+04:30'
    WHERE [Id] = CAST(55 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927420+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927423+04:30'
    WHERE [Id] = CAST(56 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927427+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927430+04:30'
    WHERE [Id] = CAST(57 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927435+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927438+04:30'
    WHERE [Id] = CAST(58 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927442+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927446+04:30'
    WHERE [Id] = CAST(59 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927450+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927454+04:30'
    WHERE [Id] = CAST(60 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927458+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927461+04:30'
    WHERE [Id] = CAST(61 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927466+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927469+04:30'
    WHERE [Id] = CAST(62 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927474+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927477+04:30'
    WHERE [Id] = CAST(63 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927481+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927485+04:30'
    WHERE [Id] = CAST(64 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927490+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927494+04:30'
    WHERE [Id] = CAST(65 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927498+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927501+04:30'
    WHERE [Id] = CAST(66 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927506+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927509+04:30'
    WHERE [Id] = CAST(67 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927513+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927517+04:30'
    WHERE [Id] = CAST(68 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927521+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927524+04:30'
    WHERE [Id] = CAST(69 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927529+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927532+04:30'
    WHERE [Id] = CAST(70 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927537+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927540+04:30'
    WHERE [Id] = CAST(71 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927545+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927548+04:30'
    WHERE [Id] = CAST(72 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927552+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927556+04:30'
    WHERE [Id] = CAST(73 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927560+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927563+04:30'
    WHERE [Id] = CAST(74 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927569+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927573+04:30'
    WHERE [Id] = CAST(75 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927577+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927580+04:30'
    WHERE [Id] = CAST(76 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927585+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927588+04:30'
    WHERE [Id] = CAST(77 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927593+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927596+04:30'
    WHERE [Id] = CAST(78 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927600+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927604+04:30'
    WHERE [Id] = CAST(79 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927608+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927611+04:30'
    WHERE [Id] = CAST(80 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927616+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927619+04:30'
    WHERE [Id] = CAST(81 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927623+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927626+04:30'
    WHERE [Id] = CAST(82 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927631+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927634+04:30'
    WHERE [Id] = CAST(83 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927639+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927642+04:30'
    WHERE [Id] = CAST(84 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927646+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927649+04:30'
    WHERE [Id] = CAST(85 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927654+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927657+04:30'
    WHERE [Id] = CAST(86 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927662+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927665+04:30'
    WHERE [Id] = CAST(87 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927740+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927744+04:30'
    WHERE [Id] = CAST(88 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927749+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927753+04:30'
    WHERE [Id] = CAST(90 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927757+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927760+04:30'
    WHERE [Id] = CAST(91 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927765+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927768+04:30'
    WHERE [Id] = CAST(92 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927773+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927776+04:30'
    WHERE [Id] = CAST(93 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927781+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927784+04:30'
    WHERE [Id] = CAST(94 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927790+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927793+04:30'
    WHERE [Id] = CAST(95 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927798+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927801+04:30'
    WHERE [Id] = CAST(96 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927806+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927809+04:30'
    WHERE [Id] = CAST(97 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927813+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927817+04:30'
    WHERE [Id] = CAST(98 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927821+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927825+04:30'
    WHERE [Id] = CAST(99 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927829+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927832+04:30'
    WHERE [Id] = CAST(100 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927837+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927840+04:30'
    WHERE [Id] = CAST(101 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927845+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927848+04:30'
    WHERE [Id] = CAST(102 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927853+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927856+04:30'
    WHERE [Id] = CAST(103 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927861+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927864+04:30'
    WHERE [Id] = CAST(104 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927870+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927873+04:30'
    WHERE [Id] = CAST(105 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927877+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927880+04:30'
    WHERE [Id] = CAST(106 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927885+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927888+04:30'
    WHERE [Id] = CAST(107 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927893+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927896+04:30'
    WHERE [Id] = CAST(108 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927900+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927904+04:30'
    WHERE [Id] = CAST(109 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927908+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927911+04:30'
    WHERE [Id] = CAST(110 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927916+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927919+04:30'
    WHERE [Id] = CAST(111 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927923+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927927+04:30'
    WHERE [Id] = CAST(112 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927931+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927934+04:30'
    WHERE [Id] = CAST(113 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927939+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927942+04:30'
    WHERE [Id] = CAST(114 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927947+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927950+04:30'
    WHERE [Id] = CAST(115 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927954+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927958+04:30'
    WHERE [Id] = CAST(116 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927970+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927973+04:30'
    WHERE [Id] = CAST(117 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927978+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927981+04:30'
    WHERE [Id] = CAST(118 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927986+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927989+04:30'
    WHERE [Id] = CAST(119 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927994+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927997+04:30'
    WHERE [Id] = CAST(120 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8928002+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8928005+04:30'
    WHERE [Id] = CAST(121 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8928009+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8928013+04:30'
    WHERE [Id] = CAST(122 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8928017+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8928021+04:30'
    WHERE [Id] = CAST(123 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8928026+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8928029+04:30'
    WHERE [Id] = CAST(124 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8928034+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8928037+04:30'
    WHERE [Id] = CAST(125 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8928041+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8928044+04:30'
    WHERE [Id] = CAST(126 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8928049+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8928052+04:30'
    WHERE [Id] = CAST(127 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8927962+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8927966+04:30'
    WHERE [Id] = CAST(128 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8918294+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8918309+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8918410+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8918415+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8918420+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8918423+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8918428+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8918431+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8918435+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8918439+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8918443+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8918446+04:30'
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8918450+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8918453+04:30'
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8918457+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8918460+04:30'
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8918466+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8918469+04:30'
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8918473+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8918505+04:30'
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-12-05T23:07:31.8918510+04:30', [UpdatedAt] = '2021-12-05T23:07:31.8918513+04:30'
    WHERE [Id] = CAST(11 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205183734_KgAddedToUnitModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211205183734_KgAddedToUnitModel', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    ALTER TABLE [wms_product_tbl] DROP CONSTRAINT [FK_wms_product_tbl_wms_unit_tbl_UnitId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    DROP INDEX [IX_wms_product_tbl_UnitId] ON [wms_product_tbl];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_assets_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0116129+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0116139+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_assets_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0117658+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0117669+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_assets_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0117694+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0117697+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_assets_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0117700+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0117702+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_assets_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0117706+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0117708+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0104603+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0104628+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0108202+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0108213+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0108333+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0108335+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0108339+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0108342+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0108345+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0108348+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0108351+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0108353+04:30'
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0108358+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0108360+04:30'
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0108364+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0108366+04:30'
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0108369+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0108371+04:30'
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_bank_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0108374+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0108376+04:30'
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0053635+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0054800+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0056538+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0056564+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0056604+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0056607+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0056610+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0056612+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0056615+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0056617+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0056620+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0056622+04:30'
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0056625+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0056627+04:30'
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0056631+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0056633+04:30'
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0056637+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0056639+04:30'
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0056642+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0056644+04:30'
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0056647+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0056649+04:30'
    WHERE [Id] = CAST(12 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_country_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0089705+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0089716+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_country_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0089796+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0089799+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_country_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0089805+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0089807+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_country_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0089811+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0089813+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_country_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0089816+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0089818+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_designation_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0110628+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0110638+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_designation_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0110684+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0110686+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_designation_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0110689+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0110692+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_designation_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0110697+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0110700+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_designation_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0110702+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0110704+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_designation_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0110707+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0110709+04:30'
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_designation_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0110711+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0110713+04:30'
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0114244+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0114246+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0114239+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0114241+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0114235+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0114237+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0114230+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0114232+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0114225+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0114227+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0114220+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0114222+04:30'
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0114214+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0114217+04:30'
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0114209+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0114211+04:30'
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0114204+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0114206+04:30'
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0114199+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0114201+04:30'
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0114194+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0114196+04:30'
    WHERE [Id] = CAST(11 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0114189+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0114191+04:30'
    WHERE [Id] = CAST(12 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0114184+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0114186+04:30'
    WHERE [Id] = CAST(13 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0114179+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0114181+04:30'
    WHERE [Id] = CAST(14 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0114174+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0114176+04:30'
    WHERE [Id] = CAST(15 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0114169+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0114171+04:30'
    WHERE [Id] = CAST(16 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0114163+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0114166+04:30'
    WHERE [Id] = CAST(17 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0114158+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0114160+04:30'
    WHERE [Id] = CAST(18 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0114153+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0114155+04:30'
    WHERE [Id] = CAST(19 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0114147+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0114149+04:30'
    WHERE [Id] = CAST(20 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0114141+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0114144+04:30'
    WHERE [Id] = CAST(21 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0114104+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0114113+04:30'
    WHERE [Id] = CAST(22 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_expense_category_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0112616+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0112625+04:30'
    WHERE [Id] = CAST(23 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098664+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098674+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098756+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098758+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098763+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098765+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098768+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098770+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098773+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098775+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098780+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098782+04:30'
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098854+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098856+04:30'
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098859+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098861+04:30'
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098864+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098866+04:30'
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098869+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098871+04:30'
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098874+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098876+04:30'
    WHERE [Id] = CAST(11 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098880+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098882+04:30'
    WHERE [Id] = CAST(12 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098885+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098887+04:30'
    WHERE [Id] = CAST(13 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098890+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098892+04:30'
    WHERE [Id] = CAST(14 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098896+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098898+04:30'
    WHERE [Id] = CAST(15 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098901+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098903+04:30'
    WHERE [Id] = CAST(16 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098906+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098908+04:30'
    WHERE [Id] = CAST(17 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098911+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098914+04:30'
    WHERE [Id] = CAST(18 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098917+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098919+04:30'
    WHERE [Id] = CAST(19 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098922+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098923+04:30'
    WHERE [Id] = CAST(20 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098926+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098928+04:30'
    WHERE [Id] = CAST(21 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098931+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098933+04:30'
    WHERE [Id] = CAST(22 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098936+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098938+04:30'
    WHERE [Id] = CAST(23 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098941+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098943+04:30'
    WHERE [Id] = CAST(24 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098948+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098950+04:30'
    WHERE [Id] = CAST(25 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098953+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098955+04:30'
    WHERE [Id] = CAST(26 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098958+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098960+04:30'
    WHERE [Id] = CAST(27 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098963+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098965+04:30'
    WHERE [Id] = CAST(28 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098968+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098970+04:30'
    WHERE [Id] = CAST(29 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098973+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098975+04:30'
    WHERE [Id] = CAST(30 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098978+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098981+04:30'
    WHERE [Id] = CAST(31 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098984+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098986+04:30'
    WHERE [Id] = CAST(32 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098989+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098991+04:30'
    WHERE [Id] = CAST(33 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098994+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0098996+04:30'
    WHERE [Id] = CAST(34 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0098999+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0099001+04:30'
    WHERE [Id] = CAST(35 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0099009+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0099011+04:30'
    WHERE [Id] = CAST(36 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0099014+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0099016+04:30'
    WHERE [Id] = CAST(37 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0099018+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0099020+04:30'
    WHERE [Id] = CAST(38 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0099023+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0099025+04:30'
    WHERE [Id] = CAST(39 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0099028+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0099030+04:30'
    WHERE [Id] = CAST(40 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0099033+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0099036+04:30'
    WHERE [Id] = CAST(41 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0099039+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0099041+04:30'
    WHERE [Id] = CAST(42 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0099044+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0099046+04:30'
    WHERE [Id] = CAST(43 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0099049+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0099051+04:30'
    WHERE [Id] = CAST(44 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0099054+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0099056+04:30'
    WHERE [Id] = CAST(45 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0099060+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0099062+04:30'
    WHERE [Id] = CAST(46 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_manufacturer_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0099004+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0099006+04:30'
    WHERE [Id] = CAST(47 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081683+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081712+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081816+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081821+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081825+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081827+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081830+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081832+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081835+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081837+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081840+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081842+04:30'
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081845+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081847+04:30'
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081850+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081852+04:30'
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081856+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081858+04:30'
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081861+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081863+04:30'
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081866+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081868+04:30'
    WHERE [Id] = CAST(11 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081871+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081873+04:30'
    WHERE [Id] = CAST(12 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081876+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081878+04:30'
    WHERE [Id] = CAST(13 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081881+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081883+04:30'
    WHERE [Id] = CAST(14 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081886+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081888+04:30'
    WHERE [Id] = CAST(15 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081891+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081893+04:30'
    WHERE [Id] = CAST(16 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081896+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081898+04:30'
    WHERE [Id] = CAST(17 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081901+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081904+04:30'
    WHERE [Id] = CAST(18 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081907+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081910+04:30'
    WHERE [Id] = CAST(19 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081913+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081915+04:30'
    WHERE [Id] = CAST(20 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081918+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081920+04:30'
    WHERE [Id] = CAST(21 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081923+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081925+04:30'
    WHERE [Id] = CAST(22 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081928+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081930+04:30'
    WHERE [Id] = CAST(23 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081933+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081935+04:30'
    WHERE [Id] = CAST(24 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081938+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081940+04:30'
    WHERE [Id] = CAST(25 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081943+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081946+04:30'
    WHERE [Id] = CAST(26 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081948+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081950+04:30'
    WHERE [Id] = CAST(27 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081954+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081956+04:30'
    WHERE [Id] = CAST(28 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081959+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081961+04:30'
    WHERE [Id] = CAST(29 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081964+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081966+04:30'
    WHERE [Id] = CAST(30 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081969+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081971+04:30'
    WHERE [Id] = CAST(31 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081974+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081976+04:30'
    WHERE [Id] = CAST(32 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081979+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081981+04:30'
    WHERE [Id] = CAST(33 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081985+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081987+04:30'
    WHERE [Id] = CAST(34 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081989+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081991+04:30'
    WHERE [Id] = CAST(35 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0081995+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0081997+04:30'
    WHERE [Id] = CAST(36 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082000+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082002+04:30'
    WHERE [Id] = CAST(37 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082006+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082008+04:30'
    WHERE [Id] = CAST(38 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082011+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082013+04:30'
    WHERE [Id] = CAST(39 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082016+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082018+04:30'
    WHERE [Id] = CAST(40 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082021+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082023+04:30'
    WHERE [Id] = CAST(41 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082026+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082028+04:30'
    WHERE [Id] = CAST(42 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082031+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082033+04:30'
    WHERE [Id] = CAST(43 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082036+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082038+04:30'
    WHERE [Id] = CAST(44 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082041+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082043+04:30'
    WHERE [Id] = CAST(45 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082046+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082048+04:30'
    WHERE [Id] = CAST(46 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082051+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082053+04:30'
    WHERE [Id] = CAST(47 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082057+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082059+04:30'
    WHERE [Id] = CAST(48 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082062+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082064+04:30'
    WHERE [Id] = CAST(49 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082067+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082069+04:30'
    WHERE [Id] = CAST(50 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082072+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082074+04:30'
    WHERE [Id] = CAST(51 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082079+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082081+04:30'
    WHERE [Id] = CAST(52 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082085+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082087+04:30'
    WHERE [Id] = CAST(53 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082090+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082092+04:30'
    WHERE [Id] = CAST(54 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082094+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082096+04:30'
    WHERE [Id] = CAST(55 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082099+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082101+04:30'
    WHERE [Id] = CAST(56 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082180+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082183+04:30'
    WHERE [Id] = CAST(57 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082186+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082188+04:30'
    WHERE [Id] = CAST(58 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082191+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082193+04:30'
    WHERE [Id] = CAST(59 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082196+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082198+04:30'
    WHERE [Id] = CAST(60 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082202+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082204+04:30'
    WHERE [Id] = CAST(61 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082208+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082210+04:30'
    WHERE [Id] = CAST(62 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082213+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082215+04:30'
    WHERE [Id] = CAST(63 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082219+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082221+04:30'
    WHERE [Id] = CAST(64 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082224+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082226+04:30'
    WHERE [Id] = CAST(65 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082229+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082231+04:30'
    WHERE [Id] = CAST(66 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082235+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082238+04:30'
    WHERE [Id] = CAST(67 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082241+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082243+04:30'
    WHERE [Id] = CAST(68 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082246+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082248+04:30'
    WHERE [Id] = CAST(69 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082251+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082253+04:30'
    WHERE [Id] = CAST(70 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082256+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082258+04:30'
    WHERE [Id] = CAST(71 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082261+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082263+04:30'
    WHERE [Id] = CAST(72 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082266+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082268+04:30'
    WHERE [Id] = CAST(73 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082271+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082273+04:30'
    WHERE [Id] = CAST(74 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082276+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082278+04:30'
    WHERE [Id] = CAST(75 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082281+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082283+04:30'
    WHERE [Id] = CAST(76 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082287+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082289+04:30'
    WHERE [Id] = CAST(77 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082292+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082294+04:30'
    WHERE [Id] = CAST(78 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082297+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082299+04:30'
    WHERE [Id] = CAST(79 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082302+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082304+04:30'
    WHERE [Id] = CAST(80 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082307+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082309+04:30'
    WHERE [Id] = CAST(81 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082312+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082314+04:30'
    WHERE [Id] = CAST(82 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082317+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082319+04:30'
    WHERE [Id] = CAST(83 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082322+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082324+04:30'
    WHERE [Id] = CAST(84 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082327+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082329+04:30'
    WHERE [Id] = CAST(85 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082332+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082334+04:30'
    WHERE [Id] = CAST(86 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082338+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082340+04:30'
    WHERE [Id] = CAST(87 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082343+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082345+04:30'
    WHERE [Id] = CAST(88 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082348+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082350+04:30'
    WHERE [Id] = CAST(89 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082353+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082356+04:30'
    WHERE [Id] = CAST(90 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082359+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082361+04:30'
    WHERE [Id] = CAST(91 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082363+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082365+04:30'
    WHERE [Id] = CAST(92 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082368+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082370+04:30'
    WHERE [Id] = CAST(93 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082373+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082375+04:30'
    WHERE [Id] = CAST(94 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082378+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082380+04:30'
    WHERE [Id] = CAST(95 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082383+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082386+04:30'
    WHERE [Id] = CAST(96 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082390+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082392+04:30'
    WHERE [Id] = CAST(97 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082395+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082396+04:30'
    WHERE [Id] = CAST(98 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082399+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082401+04:30'
    WHERE [Id] = CAST(99 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082404+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082406+04:30'
    WHERE [Id] = CAST(100 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082409+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082411+04:30'
    WHERE [Id] = CAST(101 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082414+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082417+04:30'
    WHERE [Id] = CAST(102 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082420+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082422+04:30'
    WHERE [Id] = CAST(103 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082425+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082427+04:30'
    WHERE [Id] = CAST(104 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082430+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082432+04:30'
    WHERE [Id] = CAST(105 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082436+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082438+04:30'
    WHERE [Id] = CAST(106 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082441+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082443+04:30'
    WHERE [Id] = CAST(107 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082446+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082448+04:30'
    WHERE [Id] = CAST(108 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082451+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082453+04:30'
    WHERE [Id] = CAST(109 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082456+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082458+04:30'
    WHERE [Id] = CAST(110 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082461+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082463+04:30'
    WHERE [Id] = CAST(111 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082466+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082468+04:30'
    WHERE [Id] = CAST(112 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082471+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082473+04:30'
    WHERE [Id] = CAST(113 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082477+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082479+04:30'
    WHERE [Id] = CAST(114 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082482+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082484+04:30'
    WHERE [Id] = CAST(115 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082488+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082490+04:30'
    WHERE [Id] = CAST(116 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082493+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082495+04:30'
    WHERE [Id] = CAST(117 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082498+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082500+04:30'
    WHERE [Id] = CAST(118 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082503+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082505+04:30'
    WHERE [Id] = CAST(119 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082507+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082509+04:30'
    WHERE [Id] = CAST(120 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082609+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082612+04:30'
    WHERE [Id] = CAST(121 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082615+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082617+04:30'
    WHERE [Id] = CAST(122 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082620+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082622+04:30'
    WHERE [Id] = CAST(123 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082625+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082627+04:30'
    WHERE [Id] = CAST(124 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082630+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082632+04:30'
    WHERE [Id] = CAST(125 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082636+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082638+04:30'
    WHERE [Id] = CAST(126 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082641+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082643+04:30'
    WHERE [Id] = CAST(127 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082646+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082648+04:30'
    WHERE [Id] = CAST(128 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082651+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082653+04:30'
    WHERE [Id] = CAST(129 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082656+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082658+04:30'
    WHERE [Id] = CAST(130 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082661+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082663+04:30'
    WHERE [Id] = CAST(131 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082666+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082668+04:30'
    WHERE [Id] = CAST(132 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082671+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082673+04:30'
    WHERE [Id] = CAST(133 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082676+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082678+04:30'
    WHERE [Id] = CAST(134 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082681+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082684+04:30'
    WHERE [Id] = CAST(135 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082687+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082689+04:30'
    WHERE [Id] = CAST(136 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082692+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082694+04:30'
    WHERE [Id] = CAST(137 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082697+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082699+04:30'
    WHERE [Id] = CAST(138 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082702+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082704+04:30'
    WHERE [Id] = CAST(139 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082707+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082709+04:30'
    WHERE [Id] = CAST(140 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082712+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082714+04:30'
    WHERE [Id] = CAST(141 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082717+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082719+04:30'
    WHERE [Id] = CAST(142 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082722+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082724+04:30'
    WHERE [Id] = CAST(143 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082727+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082729+04:30'
    WHERE [Id] = CAST(144 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082733+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082735+04:30'
    WHERE [Id] = CAST(145 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082738+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082740+04:30'
    WHERE [Id] = CAST(146 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082743+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082745+04:30'
    WHERE [Id] = CAST(147 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082748+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082750+04:30'
    WHERE [Id] = CAST(148 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082753+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082755+04:30'
    WHERE [Id] = CAST(149 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082758+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082760+04:30'
    WHERE [Id] = CAST(150 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082764+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082766+04:30'
    WHERE [Id] = CAST(151 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082769+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082771+04:30'
    WHERE [Id] = CAST(152 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082774+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082776+04:30'
    WHERE [Id] = CAST(153 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082779+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082781+04:30'
    WHERE [Id] = CAST(154 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082785+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082880+04:30'
    WHERE [Id] = CAST(155 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082884+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082886+04:30'
    WHERE [Id] = CAST(156 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082889+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082891+04:30'
    WHERE [Id] = CAST(157 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082894+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082896+04:30'
    WHERE [Id] = CAST(158 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082899+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082901+04:30'
    WHERE [Id] = CAST(159 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082904+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082906+04:30'
    WHERE [Id] = CAST(160 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082909+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082911+04:30'
    WHERE [Id] = CAST(161 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082913+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082915+04:30'
    WHERE [Id] = CAST(162 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082918+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082920+04:30'
    WHERE [Id] = CAST(163 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082923+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082925+04:30'
    WHERE [Id] = CAST(164 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082929+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082931+04:30'
    WHERE [Id] = CAST(165 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082934+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082937+04:30'
    WHERE [Id] = CAST(166 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082940+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082942+04:30'
    WHERE [Id] = CAST(167 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082945+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082948+04:30'
    WHERE [Id] = CAST(168 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082951+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082953+04:30'
    WHERE [Id] = CAST(169 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082958+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082963+04:30'
    WHERE [Id] = CAST(170 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082966+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082968+04:30'
    WHERE [Id] = CAST(171 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082975+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082977+04:30'
    WHERE [Id] = CAST(172 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082980+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082982+04:30'
    WHERE [Id] = CAST(173 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082985+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082987+04:30'
    WHERE [Id] = CAST(174 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082990+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082992+04:30'
    WHERE [Id] = CAST(175 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0082995+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0082997+04:30'
    WHERE [Id] = CAST(176 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083000+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083002+04:30'
    WHERE [Id] = CAST(177 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083005+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083007+04:30'
    WHERE [Id] = CAST(178 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083010+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083012+04:30'
    WHERE [Id] = CAST(179 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083015+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083017+04:30'
    WHERE [Id] = CAST(180 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083020+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083022+04:30'
    WHERE [Id] = CAST(181 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083025+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083027+04:30'
    WHERE [Id] = CAST(182 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083030+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083032+04:30'
    WHERE [Id] = CAST(183 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083094+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083096+04:30'
    WHERE [Id] = CAST(184 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083099+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083101+04:30'
    WHERE [Id] = CAST(185 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083105+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083106+04:30'
    WHERE [Id] = CAST(186 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083114+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083116+04:30'
    WHERE [Id] = CAST(187 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083120+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083122+04:30'
    WHERE [Id] = CAST(188 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083125+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083127+04:30'
    WHERE [Id] = CAST(189 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083130+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083132+04:30'
    WHERE [Id] = CAST(190 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083135+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083137+04:30'
    WHERE [Id] = CAST(191 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083140+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083142+04:30'
    WHERE [Id] = CAST(192 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083145+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083147+04:30'
    WHERE [Id] = CAST(193 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083151+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083153+04:30'
    WHERE [Id] = CAST(194 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083156+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083158+04:30'
    WHERE [Id] = CAST(195 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083161+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083163+04:30'
    WHERE [Id] = CAST(196 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083165+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083167+04:30'
    WHERE [Id] = CAST(197 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083170+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083172+04:30'
    WHERE [Id] = CAST(198 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083175+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083177+04:30'
    WHERE [Id] = CAST(199 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083180+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083182+04:30'
    WHERE [Id] = CAST(200 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083185+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083187+04:30'
    WHERE [Id] = CAST(201 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083190+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083192+04:30'
    WHERE [Id] = CAST(202 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083195+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083197+04:30'
    WHERE [Id] = CAST(203 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083200+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083203+04:30'
    WHERE [Id] = CAST(204 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083206+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083208+04:30'
    WHERE [Id] = CAST(205 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083210+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083212+04:30'
    WHERE [Id] = CAST(206 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083215+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083217+04:30'
    WHERE [Id] = CAST(207 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083220+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083222+04:30'
    WHERE [Id] = CAST(208 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083225+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083227+04:30'
    WHERE [Id] = CAST(209 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_product_type_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0083231+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0083233+04:30'
    WHERE [Id] = CAST(210 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093748+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093758+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093838+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093842+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093845+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093848+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093851+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093853+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093856+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093858+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093861+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093863+04:30'
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093867+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093869+04:30'
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093873+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093875+04:30'
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093878+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093880+04:30'
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093883+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093885+04:30'
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093888+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093890+04:30'
    WHERE [Id] = CAST(11 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093893+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093895+04:30'
    WHERE [Id] = CAST(12 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093898+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093901+04:30'
    WHERE [Id] = CAST(13 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093904+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093906+04:30'
    WHERE [Id] = CAST(14 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093909+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093911+04:30'
    WHERE [Id] = CAST(15 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093915+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093917+04:30'
    WHERE [Id] = CAST(16 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093921+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093924+04:30'
    WHERE [Id] = CAST(17 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093928+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093930+04:30'
    WHERE [Id] = CAST(18 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093934+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093936+04:30'
    WHERE [Id] = CAST(19 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093939+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093941+04:30'
    WHERE [Id] = CAST(20 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093943+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093946+04:30'
    WHERE [Id] = CAST(21 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093948+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093951+04:30'
    WHERE [Id] = CAST(22 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093954+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093956+04:30'
    WHERE [Id] = CAST(23 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093959+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093961+04:30'
    WHERE [Id] = CAST(24 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093964+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093966+04:30'
    WHERE [Id] = CAST(25 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093969+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093973+04:30'
    WHERE [Id] = CAST(26 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093976+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093978+04:30'
    WHERE [Id] = CAST(27 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093981+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093983+04:30'
    WHERE [Id] = CAST(28 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093986+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093988+04:30'
    WHERE [Id] = CAST(29 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093991+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093993+04:30'
    WHERE [Id] = CAST(30 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0093995+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0093997+04:30'
    WHERE [Id] = CAST(31 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094003+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094004+04:30'
    WHERE [Id] = CAST(32 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094007+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094009+04:30'
    WHERE [Id] = CAST(33 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094084+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094086+04:30'
    WHERE [Id] = CAST(34 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094090+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094092+04:30'
    WHERE [Id] = CAST(35 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094096+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094099+04:30'
    WHERE [Id] = CAST(36 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094102+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094104+04:30'
    WHERE [Id] = CAST(37 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094107+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094109+04:30'
    WHERE [Id] = CAST(38 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094112+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094114+04:30'
    WHERE [Id] = CAST(39 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094116+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094118+04:30'
    WHERE [Id] = CAST(40 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094121+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094123+04:30'
    WHERE [Id] = CAST(41 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094126+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094128+04:30'
    WHERE [Id] = CAST(42 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094131+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094133+04:30'
    WHERE [Id] = CAST(43 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094136+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094138+04:30'
    WHERE [Id] = CAST(44 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094141+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094143+04:30'
    WHERE [Id] = CAST(45 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094147+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094149+04:30'
    WHERE [Id] = CAST(46 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094152+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094154+04:30'
    WHERE [Id] = CAST(47 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094157+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094159+04:30'
    WHERE [Id] = CAST(48 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094162+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094164+04:30'
    WHERE [Id] = CAST(49 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094167+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094169+04:30'
    WHERE [Id] = CAST(50 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094172+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094174+04:30'
    WHERE [Id] = CAST(51 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094177+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094179+04:30'
    WHERE [Id] = CAST(52 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094182+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094184+04:30'
    WHERE [Id] = CAST(53 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094187+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094189+04:30'
    WHERE [Id] = CAST(54 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094192+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094196+04:30'
    WHERE [Id] = CAST(55 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094199+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094201+04:30'
    WHERE [Id] = CAST(56 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094204+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094206+04:30'
    WHERE [Id] = CAST(57 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094209+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094211+04:30'
    WHERE [Id] = CAST(58 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094214+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094216+04:30'
    WHERE [Id] = CAST(59 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094219+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094221+04:30'
    WHERE [Id] = CAST(60 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094225+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094227+04:30'
    WHERE [Id] = CAST(61 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094230+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094232+04:30'
    WHERE [Id] = CAST(62 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094235+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094237+04:30'
    WHERE [Id] = CAST(63 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094241+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094243+04:30'
    WHERE [Id] = CAST(64 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094246+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094248+04:30'
    WHERE [Id] = CAST(65 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094251+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094254+04:30'
    WHERE [Id] = CAST(66 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094257+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094259+04:30'
    WHERE [Id] = CAST(67 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094261+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094264+04:30'
    WHERE [Id] = CAST(68 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094267+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094269+04:30'
    WHERE [Id] = CAST(69 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094272+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094275+04:30'
    WHERE [Id] = CAST(70 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094277+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094279+04:30'
    WHERE [Id] = CAST(71 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094282+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094284+04:30'
    WHERE [Id] = CAST(72 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094287+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094289+04:30'
    WHERE [Id] = CAST(73 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094292+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094294+04:30'
    WHERE [Id] = CAST(74 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094298+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094300+04:30'
    WHERE [Id] = CAST(75 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094303+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094305+04:30'
    WHERE [Id] = CAST(76 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094308+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094310+04:30'
    WHERE [Id] = CAST(77 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094313+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094315+04:30'
    WHERE [Id] = CAST(78 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094318+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094320+04:30'
    WHERE [Id] = CAST(79 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094323+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094325+04:30'
    WHERE [Id] = CAST(80 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094328+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094330+04:30'
    WHERE [Id] = CAST(81 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094333+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094335+04:30'
    WHERE [Id] = CAST(82 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094337+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094339+04:30'
    WHERE [Id] = CAST(83 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094342+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094344+04:30'
    WHERE [Id] = CAST(84 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094348+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094350+04:30'
    WHERE [Id] = CAST(85 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094353+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094355+04:30'
    WHERE [Id] = CAST(86 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094358+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094360+04:30'
    WHERE [Id] = CAST(87 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094363+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094365+04:30'
    WHERE [Id] = CAST(88 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094368+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094370+04:30'
    WHERE [Id] = CAST(90 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094373+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094375+04:30'
    WHERE [Id] = CAST(91 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094378+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094381+04:30'
    WHERE [Id] = CAST(92 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094384+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094386+04:30'
    WHERE [Id] = CAST(93 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094388+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094390+04:30'
    WHERE [Id] = CAST(94 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094458+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094461+04:30'
    WHERE [Id] = CAST(95 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094464+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094466+04:30'
    WHERE [Id] = CAST(96 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094469+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094471+04:30'
    WHERE [Id] = CAST(97 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094474+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094476+04:30'
    WHERE [Id] = CAST(98 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094479+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094481+04:30'
    WHERE [Id] = CAST(99 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094483+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094485+04:30'
    WHERE [Id] = CAST(100 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094488+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094490+04:30'
    WHERE [Id] = CAST(101 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094493+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094495+04:30'
    WHERE [Id] = CAST(102 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094498+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094500+04:30'
    WHERE [Id] = CAST(103 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094503+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094505+04:30'
    WHERE [Id] = CAST(104 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094509+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094511+04:30'
    WHERE [Id] = CAST(105 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094514+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094516+04:30'
    WHERE [Id] = CAST(106 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094519+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094521+04:30'
    WHERE [Id] = CAST(107 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094523+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094525+04:30'
    WHERE [Id] = CAST(108 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094528+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094530+04:30'
    WHERE [Id] = CAST(109 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094534+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094536+04:30'
    WHERE [Id] = CAST(110 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094538+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094540+04:30'
    WHERE [Id] = CAST(111 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094543+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094545+04:30'
    WHERE [Id] = CAST(112 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094548+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094550+04:30'
    WHERE [Id] = CAST(113 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094553+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094555+04:30'
    WHERE [Id] = CAST(114 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094559+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094562+04:30'
    WHERE [Id] = CAST(115 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094565+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094567+04:30'
    WHERE [Id] = CAST(116 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094575+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094577+04:30'
    WHERE [Id] = CAST(117 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094580+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094582+04:30'
    WHERE [Id] = CAST(118 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094585+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094587+04:30'
    WHERE [Id] = CAST(119 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094590+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094596+04:30'
    WHERE [Id] = CAST(120 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094599+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094601+04:30'
    WHERE [Id] = CAST(121 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094604+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094606+04:30'
    WHERE [Id] = CAST(122 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094609+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094612+04:30'
    WHERE [Id] = CAST(123 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094615+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094617+04:30'
    WHERE [Id] = CAST(124 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094619+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094622+04:30'
    WHERE [Id] = CAST(125 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094625+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094627+04:30'
    WHERE [Id] = CAST(126 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094629+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094631+04:30'
    WHERE [Id] = CAST(127 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_province_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0094570+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0094572+04:30'
    WHERE [Id] = CAST(128 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0086944+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0086958+04:30'
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0087030+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0087033+04:30'
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0087103+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0087106+04:30'
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0087109+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0087111+04:30'
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0087114+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0087116+04:30'
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0087119+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0087121+04:30'
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0087124+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0087127+04:30'
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0087130+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0087132+04:30'
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0087135+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0087142+04:30'
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0087145+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0087147+04:30'
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    UPDATE [wms_unit_tbl] SET [CreatedAt] = '2021-12-05T23:13:58.0087149+04:30', [UpdatedAt] = '2021-12-05T23:13:58.0087152+04:30'
    WHERE [Id] = CAST(11 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211205184400_ProductsRemovedFromUnit')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211205184400_ProductsRemovedFromUnit', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_assets_category_tbl]
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_assets_category_tbl]
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_assets_category_tbl]
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_assets_category_tbl]
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_assets_category_tbl]
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_bank_tbl]
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_bank_tbl]
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_bank_tbl]
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_bank_tbl]
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_bank_tbl]
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_bank_tbl]
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_bank_tbl]
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_bank_tbl]
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_bank_tbl]
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_bank_tbl]
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_category_tbl]
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_category_tbl]
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_category_tbl]
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_category_tbl]
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_category_tbl]
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_category_tbl]
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_category_tbl]
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_category_tbl]
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_category_tbl]
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_category_tbl]
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_category_tbl]
    WHERE [Id] = CAST(12 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_designation_tbl]
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_designation_tbl]
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_designation_tbl]
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_designation_tbl]
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_designation_tbl]
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_designation_tbl]
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_designation_tbl]
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_expense_category_tbl]
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_expense_category_tbl]
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_expense_category_tbl]
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_expense_category_tbl]
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_expense_category_tbl]
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_expense_category_tbl]
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_expense_category_tbl]
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_expense_category_tbl]
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_expense_category_tbl]
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_expense_category_tbl]
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_expense_category_tbl]
    WHERE [Id] = CAST(11 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_expense_category_tbl]
    WHERE [Id] = CAST(12 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_expense_category_tbl]
    WHERE [Id] = CAST(13 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_expense_category_tbl]
    WHERE [Id] = CAST(14 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_expense_category_tbl]
    WHERE [Id] = CAST(15 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_expense_category_tbl]
    WHERE [Id] = CAST(16 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_expense_category_tbl]
    WHERE [Id] = CAST(17 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_expense_category_tbl]
    WHERE [Id] = CAST(18 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_expense_category_tbl]
    WHERE [Id] = CAST(19 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_expense_category_tbl]
    WHERE [Id] = CAST(20 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_expense_category_tbl]
    WHERE [Id] = CAST(21 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_expense_category_tbl]
    WHERE [Id] = CAST(22 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_expense_category_tbl]
    WHERE [Id] = CAST(23 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(11 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(12 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(13 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(14 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(15 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(16 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(17 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(18 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(19 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(20 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(21 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(22 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(23 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(24 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(25 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(26 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(27 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(28 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(29 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(30 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(31 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(32 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(33 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(34 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(35 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(36 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(37 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(38 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(39 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(40 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(41 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(42 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(43 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(44 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(45 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(46 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_manufacturer_tbl]
    WHERE [Id] = CAST(47 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(11 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(12 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(13 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(14 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(15 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(16 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(17 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(18 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(19 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(20 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(21 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(22 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(23 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(24 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(25 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(26 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(27 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(28 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(29 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(30 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(31 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(32 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(33 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(34 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(35 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(36 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(37 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(38 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(39 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(40 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(41 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(42 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(43 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(44 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(45 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(46 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(47 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(48 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(49 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(50 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(51 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(52 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(53 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(54 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(55 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(56 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(57 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(58 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(59 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(60 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(61 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(62 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(63 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(64 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(65 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(66 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(67 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(68 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(69 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(70 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(71 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(72 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(73 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(74 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(75 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(76 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(77 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(78 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(79 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(80 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(81 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(82 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(83 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(84 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(85 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(86 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(87 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(88 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(89 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(90 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(91 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(92 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(93 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(94 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(95 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(96 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(97 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(98 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(99 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(100 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(101 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(102 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(103 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(104 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(105 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(106 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(107 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(108 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(109 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(110 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(111 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(112 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(113 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(114 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(115 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(116 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(117 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(118 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(119 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(120 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(121 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(122 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(123 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(124 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(125 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(126 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(127 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(128 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(129 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(130 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(131 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(132 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(133 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(134 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(135 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(136 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(137 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(138 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(139 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(140 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(141 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(142 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(143 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(144 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(145 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(146 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(147 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(148 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(149 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(150 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(151 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(152 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(153 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(154 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(155 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(156 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(157 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(158 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(159 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(160 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(161 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(162 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(163 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(164 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(165 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(166 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(167 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(168 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(169 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(170 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(171 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(172 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(173 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(174 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(175 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(176 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(177 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(178 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(179 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(180 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(181 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(182 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(183 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(184 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(185 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(186 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(187 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(188 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(189 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(190 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(191 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(192 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(193 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(194 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(195 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(196 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(197 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(198 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(199 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(200 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(201 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(202 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(203 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(204 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(205 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(206 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(207 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(208 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(209 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_product_type_tbl]
    WHERE [Id] = CAST(210 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(11 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(12 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(13 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(14 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(15 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(16 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(17 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(18 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(19 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(20 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(21 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(22 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(23 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(24 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(25 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(26 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(27 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(28 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(29 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(30 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(31 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(32 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(33 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(34 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(35 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(36 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(37 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(38 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(39 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(40 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(41 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(42 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(43 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(44 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(45 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(46 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(47 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(48 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(49 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(50 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(51 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(52 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(53 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(54 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(55 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(56 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(57 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(58 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(59 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(60 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(61 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(62 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(63 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(64 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(65 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(66 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(67 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(68 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(69 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(70 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(71 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(72 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(73 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(74 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(75 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(76 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(77 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(78 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(79 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(80 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(81 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(82 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(83 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(84 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(85 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(86 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(87 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(88 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(90 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(91 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(92 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(93 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(94 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(95 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(96 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(97 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(98 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(99 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(100 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(101 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(102 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(103 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(104 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(105 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(106 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(107 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(108 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(109 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(110 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(111 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(112 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(113 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(114 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(115 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(116 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(117 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(118 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(119 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(120 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(121 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(122 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(123 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(124 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(125 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(126 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(127 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_province_tbl]
    WHERE [Id] = CAST(128 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_unit_tbl]
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_unit_tbl]
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_unit_tbl]
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_unit_tbl]
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_unit_tbl]
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_unit_tbl]
    WHERE [Id] = CAST(6 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_unit_tbl]
    WHERE [Id] = CAST(7 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_unit_tbl]
    WHERE [Id] = CAST(8 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_unit_tbl]
    WHERE [Id] = CAST(9 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_unit_tbl]
    WHERE [Id] = CAST(10 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_unit_tbl]
    WHERE [Id] = CAST(11 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_country_tbl]
    WHERE [Id] = CAST(1 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_country_tbl]
    WHERE [Id] = CAST(2 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_country_tbl]
    WHERE [Id] = CAST(3 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_country_tbl]
    WHERE [Id] = CAST(4 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DELETE FROM [wms_country_tbl]
    WHERE [Id] = CAST(5 AS bigint);
    SELECT @@ROWCOUNT;

END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DECLARE @var52 sysname;
    SELECT @var52 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_product_tbl]') AND [c].[name] = N'Image');
    IF @var52 IS NOT NULL EXEC(N'ALTER TABLE [wms_product_tbl] DROP CONSTRAINT [' + @var52 + '];');
    ALTER TABLE [wms_product_tbl] DROP COLUMN [Image];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DECLARE @var53 sysname;
    SELECT @var53 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_product_tbl]') AND [c].[name] = N'Model');
    IF @var53 IS NOT NULL EXEC(N'ALTER TABLE [wms_product_tbl] DROP CONSTRAINT [' + @var53 + '];');
    ALTER TABLE [wms_product_tbl] DROP COLUMN [Model];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DECLARE @var54 sysname;
    SELECT @var54 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_product_tbl]') AND [c].[name] = N'SupplierId');
    IF @var54 IS NOT NULL EXEC(N'ALTER TABLE [wms_product_tbl] DROP CONSTRAINT [' + @var54 + '];');
    ALTER TABLE [wms_product_tbl] DROP COLUMN [SupplierId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    DECLARE @var55 sysname;
    SELECT @var55 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_product_tbl]') AND [c].[name] = N'TypeId');
    IF @var55 IS NOT NULL EXEC(N'ALTER TABLE [wms_product_tbl] DROP CONSTRAINT [' + @var55 + '];');
    ALTER TABLE [wms_product_tbl] DROP COLUMN [TypeId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    ALTER TABLE [wms_product_tbl] ADD [UnitSellPrice] decimal(38, 2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206080841_ProductModelUpdated')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211206080841_ProductModelUpdated', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206094129_ManufacturerModelUpdated')
BEGIN
    DECLARE @var56 sysname;
    SELECT @var56 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_manufacturer_tbl]') AND [c].[name] = N'CountryName');
    IF @var56 IS NOT NULL EXEC(N'ALTER TABLE [wms_manufacturer_tbl] DROP CONSTRAINT [' + @var56 + '];');
    ALTER TABLE [wms_manufacturer_tbl] DROP COLUMN [CountryName];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206094129_ManufacturerModelUpdated')
BEGIN
    DECLARE @var57 sysname;
    SELECT @var57 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_manufacturer_tbl]') AND [c].[name] = N'Description');
    IF @var57 IS NOT NULL EXEC(N'ALTER TABLE [wms_manufacturer_tbl] DROP CONSTRAINT [' + @var57 + '];');
    ALTER TABLE [wms_manufacturer_tbl] ALTER COLUMN [Description] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206094129_ManufacturerModelUpdated')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211206094129_ManufacturerModelUpdated', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206100035_ProductModelUpdated2')
BEGIN
    DECLARE @var58 sysname;
    SELECT @var58 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_product_tbl]') AND [c].[name] = N'UnitSellPrice');
    IF @var58 IS NOT NULL EXEC(N'ALTER TABLE [wms_product_tbl] DROP CONSTRAINT [' + @var58 + '];');
    ALTER TABLE [wms_product_tbl] DROP COLUMN [UnitSellPrice];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211206100035_ProductModelUpdated2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211206100035_ProductModelUpdated2', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211208074746_UnitSellPriceAddedToUnitModel')
BEGIN
    DECLARE @var59 sysname;
    SELECT @var59 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_product_tbl]') AND [c].[name] = N'UnitId');
    IF @var59 IS NOT NULL EXEC(N'ALTER TABLE [wms_product_tbl] DROP CONSTRAINT [' + @var59 + '];');
    ALTER TABLE [wms_product_tbl] DROP COLUMN [UnitId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211208074746_UnitSellPriceAddedToUnitModel')
BEGIN
    ALTER TABLE [wms_unit_tbl] ADD [UnitSellPrice] decimal(18,2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211208074746_UnitSellPriceAddedToUnitModel')
BEGIN
    DECLARE @var60 sysname;
    SELECT @var60 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_product_tbl]') AND [c].[name] = N'Description');
    IF @var60 IS NOT NULL EXEC(N'ALTER TABLE [wms_product_tbl] DROP CONSTRAINT [' + @var60 + '];');
    ALTER TABLE [wms_product_tbl] ALTER COLUMN [Description] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211208074746_UnitSellPriceAddedToUnitModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211208074746_UnitSellPriceAddedToUnitModel', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211208165233_ProductUnitModelCreated')
BEGIN
    DECLARE @var61 sysname;
    SELECT @var61 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_unit_tbl]') AND [c].[name] = N'UnitSellPrice');
    IF @var61 IS NOT NULL EXEC(N'ALTER TABLE [wms_unit_tbl] DROP CONSTRAINT [' + @var61 + '];');
    ALTER TABLE [wms_unit_tbl] DROP COLUMN [UnitSellPrice];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211208165233_ProductUnitModelCreated')
BEGIN
    DECLARE @var62 sysname;
    SELECT @var62 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_product_batch_tbl]') AND [c].[name] = N'ExpireDate');
    IF @var62 IS NOT NULL EXEC(N'ALTER TABLE [wms_product_batch_tbl] DROP CONSTRAINT [' + @var62 + '];');
    ALTER TABLE [wms_product_batch_tbl] DROP COLUMN [ExpireDate];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211208165233_ProductUnitModelCreated')
BEGIN
    DECLARE @var63 sysname;
    SELECT @var63 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_product_batch_tbl]') AND [c].[name] = N'SellPrice');
    IF @var63 IS NOT NULL EXEC(N'ALTER TABLE [wms_product_batch_tbl] DROP CONSTRAINT [' + @var63 + '];');
    ALTER TABLE [wms_product_batch_tbl] DROP COLUMN [SellPrice];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211208165233_ProductUnitModelCreated')
BEGIN
    CREATE TABLE [ProductUnit] (
        [ProductId] bigint NOT NULL,
        [UnitId] bigint NOT NULL,
        [UnitSellPrice] decimal(38, 2) NOT NULL,
        CONSTRAINT [PK_ProductUnit] PRIMARY KEY ([ProductId], [UnitId]),
        CONSTRAINT [FK_ProductUnit_wms_product_tbl_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [wms_product_tbl] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_ProductUnit_wms_unit_tbl_UnitId] FOREIGN KEY ([UnitId]) REFERENCES [wms_unit_tbl] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211208165233_ProductUnitModelCreated')
BEGIN
    CREATE INDEX [IX_ProductUnit_UnitId] ON [ProductUnit] ([UnitId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211208165233_ProductUnitModelCreated')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211208165233_ProductUnitModelCreated', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211208165523_ProductUnitMappedToDatabase')
BEGIN
    ALTER TABLE [ProductUnit] DROP CONSTRAINT [FK_ProductUnit_wms_product_tbl_ProductId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211208165523_ProductUnitMappedToDatabase')
BEGIN
    ALTER TABLE [ProductUnit] DROP CONSTRAINT [FK_ProductUnit_wms_unit_tbl_UnitId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211208165523_ProductUnitMappedToDatabase')
BEGIN
    ALTER TABLE [ProductUnit] DROP CONSTRAINT [PK_ProductUnit];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211208165523_ProductUnitMappedToDatabase')
BEGIN
    EXEC sp_rename N'[ProductUnit]', N'ProductUnits';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211208165523_ProductUnitMappedToDatabase')
BEGIN
    EXEC sp_rename N'[ProductUnits].[IX_ProductUnit_UnitId]', N'IX_ProductUnits_UnitId', N'INDEX';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211208165523_ProductUnitMappedToDatabase')
BEGIN
    ALTER TABLE [ProductUnits] ADD CONSTRAINT [PK_ProductUnits] PRIMARY KEY ([ProductId], [UnitId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211208165523_ProductUnitMappedToDatabase')
BEGIN
    ALTER TABLE [ProductUnits] ADD CONSTRAINT [FK_ProductUnits_wms_product_tbl_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [wms_product_tbl] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211208165523_ProductUnitMappedToDatabase')
BEGIN
    ALTER TABLE [ProductUnits] ADD CONSTRAINT [FK_ProductUnits_wms_unit_tbl_UnitId] FOREIGN KEY ([UnitId]) REFERENCES [wms_unit_tbl] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211208165523_ProductUnitMappedToDatabase')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211208165523_ProductUnitMappedToDatabase', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211209122103_IdAddedToProductUnitModel')
BEGIN
    ALTER TABLE [ProductUnits] ADD [Id] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211209122103_IdAddedToProductUnitModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211209122103_IdAddedToProductUnitModel', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211211105029_PurchaseModelUpdatewithGas')
BEGIN
    DECLARE @var64 sysname;
    SELECT @var64 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_purchase_details_tbl]') AND [c].[name] = N'ExpireDate');
    IF @var64 IS NOT NULL EXEC(N'ALTER TABLE [wms_purchase_details_tbl] DROP CONSTRAINT [' + @var64 + '];');
    ALTER TABLE [wms_purchase_details_tbl] DROP COLUMN [ExpireDate];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211211105029_PurchaseModelUpdatewithGas')
BEGIN
    DECLARE @var65 sysname;
    SELECT @var65 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_purchase_details_tbl]') AND [c].[name] = N'SellPrice');
    IF @var65 IS NOT NULL EXEC(N'ALTER TABLE [wms_purchase_details_tbl] DROP CONSTRAINT [' + @var65 + '];');
    ALTER TABLE [wms_purchase_details_tbl] DROP COLUMN [SellPrice];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211211105029_PurchaseModelUpdatewithGas')
BEGIN
    ALTER TABLE [wms_purchase_details_tbl] ADD [UnitId] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211211105029_PurchaseModelUpdatewithGas')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211211105029_PurchaseModelUpdatewithGas', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211212180052_InvoiceNoRemovedFromSaleModel')
BEGIN
    DECLARE @var66 sysname;
    SELECT @var66 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_sale_tbl]') AND [c].[name] = N'InvoiceNo');
    IF @var66 IS NOT NULL EXEC(N'ALTER TABLE [wms_sale_tbl] DROP CONSTRAINT [' + @var66 + '];');
    ALTER TABLE [wms_sale_tbl] DROP COLUMN [InvoiceNo];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211212180052_InvoiceNoRemovedFromSaleModel')
BEGIN
    DECLARE @var67 sysname;
    SELECT @var67 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_sale_details_tbl]') AND [c].[name] = N'BatchId');
    IF @var67 IS NOT NULL EXEC(N'ALTER TABLE [wms_sale_details_tbl] DROP CONSTRAINT [' + @var67 + '];');
    ALTER TABLE [wms_sale_details_tbl] DROP COLUMN [BatchId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211212180052_InvoiceNoRemovedFromSaleModel')
BEGIN
    ALTER TABLE [wms_sale_details_tbl] ADD [UnitId] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211212180052_InvoiceNoRemovedFromSaleModel')
BEGIN
    CREATE INDEX [IX_wms_sale_details_tbl_ProductId] ON [wms_sale_details_tbl] ([ProductId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211212180052_InvoiceNoRemovedFromSaleModel')
BEGIN
    CREATE INDEX [IX_wms_sale_details_tbl_UnitId] ON [wms_sale_details_tbl] ([UnitId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211212180052_InvoiceNoRemovedFromSaleModel')
BEGIN
    ALTER TABLE [wms_sale_details_tbl] ADD CONSTRAINT [FK_wms_sale_details_tbl_wms_product_tbl_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [wms_product_tbl] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211212180052_InvoiceNoRemovedFromSaleModel')
BEGIN
    ALTER TABLE [wms_sale_details_tbl] ADD CONSTRAINT [FK_wms_sale_details_tbl_wms_unit_tbl_UnitId] FOREIGN KEY ([UnitId]) REFERENCES [wms_unit_tbl] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211212180052_InvoiceNoRemovedFromSaleModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211212180052_InvoiceNoRemovedFromSaleModel', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211216105913_ReturnModelsUpdated')
BEGIN
    DECLARE @var68 sysname;
    SELECT @var68 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_wastage_details_tbl]') AND [c].[name] = N'BatchId');
    IF @var68 IS NOT NULL EXEC(N'ALTER TABLE [wms_wastage_details_tbl] DROP CONSTRAINT [' + @var68 + '];');
    ALTER TABLE [wms_wastage_details_tbl] DROP COLUMN [BatchId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211216105913_ReturnModelsUpdated')
BEGIN
    DECLARE @var69 sysname;
    SELECT @var69 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[wms_return_details_tbl]') AND [c].[name] = N'BatchId');
    IF @var69 IS NOT NULL EXEC(N'ALTER TABLE [wms_return_details_tbl] DROP CONSTRAINT [' + @var69 + '];');
    ALTER TABLE [wms_return_details_tbl] DROP COLUMN [BatchId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211216105913_ReturnModelsUpdated')
BEGIN
    ALTER TABLE [wms_wastage_details_tbl] ADD [UnitId] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211216105913_ReturnModelsUpdated')
BEGIN
    ALTER TABLE [wms_return_details_tbl] ADD [UnitId] bigint NOT NULL DEFAULT CAST(0 AS bigint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211216105913_ReturnModelsUpdated')
BEGIN
    CREATE INDEX [IX_wms_wastage_details_tbl_ProductId] ON [wms_wastage_details_tbl] ([ProductId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211216105913_ReturnModelsUpdated')
BEGIN
    CREATE INDEX [IX_wms_wastage_details_tbl_UnitId] ON [wms_wastage_details_tbl] ([UnitId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211216105913_ReturnModelsUpdated')
BEGIN
    CREATE INDEX [IX_wms_return_details_tbl_ProductId] ON [wms_return_details_tbl] ([ProductId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211216105913_ReturnModelsUpdated')
BEGIN
    CREATE INDEX [IX_wms_return_details_tbl_UnitId] ON [wms_return_details_tbl] ([UnitId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211216105913_ReturnModelsUpdated')
BEGIN
    ALTER TABLE [wms_return_details_tbl] ADD CONSTRAINT [FK_wms_return_details_tbl_wms_product_tbl_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [wms_product_tbl] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211216105913_ReturnModelsUpdated')
BEGIN
    ALTER TABLE [wms_return_details_tbl] ADD CONSTRAINT [FK_wms_return_details_tbl_wms_unit_tbl_UnitId] FOREIGN KEY ([UnitId]) REFERENCES [wms_unit_tbl] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211216105913_ReturnModelsUpdated')
BEGIN
    ALTER TABLE [wms_wastage_details_tbl] ADD CONSTRAINT [FK_wms_wastage_details_tbl_wms_product_tbl_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [wms_product_tbl] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211216105913_ReturnModelsUpdated')
BEGIN
    ALTER TABLE [wms_wastage_details_tbl] ADD CONSTRAINT [FK_wms_wastage_details_tbl_wms_unit_tbl_UnitId] FOREIGN KEY ([UnitId]) REFERENCES [wms_unit_tbl] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211216105913_ReturnModelsUpdated')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211216105913_ReturnModelsUpdated', N'3.1.9');
END;

GO


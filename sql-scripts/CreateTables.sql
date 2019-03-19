CREATE TABLE [CarClasses] (
    [CarClassId] bigint NOT NULL IDENTITY,
    [ClassName] nvarchar(max) NULL,
    CONSTRAINT [PK_CarClasses] PRIMARY KEY ([CarClassId])
);

GO

CREATE TABLE [CarModels] (
    [CarModelId] bigint NOT NULL IDENTITY,
    [Model] nvarchar(max) NULL,
    CONSTRAINT [PK_CarModels] PRIMARY KEY ([CarModelId])
);

GO

CREATE TABLE [Manufacturers] (
    [WhoManufacturerCarId] bigint NOT NULL IDENTITY,
    [WhoManufacturer] nvarchar(max) NULL,
    CONSTRAINT [PK_Manufacturers] PRIMARY KEY ([WhoManufacturerCarId])
);

GO

CREATE TABLE [Users] (
    [UserId] bigint NOT NULL IDENTITY,
    [FirstName] nvarchar(max) NULL,
    [LastName] nvarchar(max) NULL,
    [DateOfBirth] datetime2 NOT NULL,
    [DlNumber] nvarchar(max) NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY ([UserId])
);

GO

CREATE TABLE [Cars] (
    [CarId] bigint NOT NULL IDENTITY,
    [CarClassId] bigint NULL,
    [ModelCarModelId] bigint NULL,
    [WhoManufacturerCarId] bigint NULL,
    [YearOfIssue] int NOT NULL,
    [RegistrationNumber] nvarchar(max) NULL,
    CONSTRAINT [PK_Cars] PRIMARY KEY ([CarId]),
    CONSTRAINT [FK_Cars_CarClasses_CarClassId] FOREIGN KEY ([CarClassId]) REFERENCES [CarClasses] ([CarClassId]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Cars_CarModels_ModelCarModelId] FOREIGN KEY ([ModelCarModelId]) REFERENCES [CarModels] ([CarModelId]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Cars_Manufacturers_WhoManufacturerCarId] FOREIGN KEY ([WhoManufacturerCarId]) REFERENCES [Manufacturers] ([WhoManufacturerCarId]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Orders] (
    [OrderId] bigint NOT NULL IDENTITY,
    [StartOfRental] datetime2 NOT NULL,
    [EndOfRental] datetime2 NOT NULL,
    [Comment] nvarchar(max) NULL,
    [CarId] bigint NULL,
    [UserId] bigint NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY ([OrderId]),
    CONSTRAINT [FK_Orders_Cars_CarId] FOREIGN KEY ([CarId]) REFERENCES [Cars] ([CarId]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Orders_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([UserId]) ON DELETE NO ACTION
);

GO
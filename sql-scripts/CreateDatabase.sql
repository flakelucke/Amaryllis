USE master
GO

IF NOT EXISTS (
    SELECT name
        FROM sys.databases
        WHERE name = N'flakedatabase'
)
CREATE DATABASE flakedatabase
GO
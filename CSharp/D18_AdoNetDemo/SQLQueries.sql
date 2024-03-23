CREATE TABLE [dbo].[Products]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NOT NULL, 
    [UnitPrice] MONEY NOT NULL, 
    [StockAmount] INT NOT NULL
)

INSERT INTO [dbo].[Products] ([Name], [UnitPrice], [StockAmount])
VALUES
    ('Laptop', 3000, 10),
    ('Mouse', 20, 20),
    ('Keyboard', 40, 21);
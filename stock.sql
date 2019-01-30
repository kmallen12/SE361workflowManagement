CREATE TABLE [dbo].[Table]
(
	[itemID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [materialType] NCHAR(25) NOT NULL, 
    [quantity] INT NOT NULL, 
    [unitCost] MONEY NULL, 
    [totalCost] MONEY NULL, 
    [dateAcquired] DATE NULL, 
    [dateUsed] DATE NULL
)

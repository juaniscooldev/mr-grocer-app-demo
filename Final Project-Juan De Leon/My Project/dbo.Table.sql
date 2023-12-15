CREATE TABLE [dbo].[LoginTable]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY,
    [username] NVARCHAR(50) NULL,
    [password] NVARCHAR(50) NULL, 
    [wallet] NCHAR(10) NULL DEFAULT 0,
	
)
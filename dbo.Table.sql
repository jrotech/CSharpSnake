CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [username] NCHAR(40) NULL, 
    [password] NCHAR(40) NULL, 
    [highscore] INT NULL DEFAULT 0, 
    [date] DATETIME NULL
)

CREATE TABLE [dbo].[Room]
(
	[Number] NVARCHAR(10) NOT NULL,
    [Building] NVARCHAR(10) NOT NULL, 
    [Capasity] INT NOT NULL, 
    CONSTRAINT [PK_Room] PRIMARY KEY ([Number])
)

CREATE TABLE [dbo].[ContactEmail]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [ContactId] int not NULL,
	[EmailId] int not null
)

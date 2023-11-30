CREATE TABLE [dbo].[Personne]
(
	[Id] INT NOT NULL IDENTITY, 
    [Nom] NVARCHAR(50) NOT NULL, 
    [Prenom] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Personne] PRIMARY KEY ([Id]) 
)

CREATE TABLE [dbo].[Tache]
(
	[Id] INT NOT NULL IDENTITY, 
    [Titre] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(100) NOT NULL, 
    [Cloturee] BIT NOT NULL 
        CONSTRAINT DF_Tache_Cloturee DEFAULT (0), 
    [PersonneId] INT NULL,
    CONSTRAINT [PK_Tache] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Tache_Personne] FOREIGN KEY (PersonneId) 
        REFERENCES Personne(Id)
)

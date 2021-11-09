CREATE TABLE [dbo].[Animaux] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Nom]         NVARCHAR (50) DEFAULT ('inconnu') NOT NULL,
    [Espece]      NVARCHAR (50) DEFAULT ('inconnu') NOT NULL,
    [Sous-espece] NVARCHAR (50) DEFAULT ('inconnu') NOT NULL,
    [Age]         INT           DEFAULT ((0)) NOT NULL,
    [Sexe]        NVARCHAR (50) DEFAULT ('inconnu') NOT NULL,
    [Statut]      NVARCHAR (50) DEFAULT ('inconnu') NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Animaux_Especes] FOREIGN KEY ([Espece]) REFERENCES [dbo].[Especes] ([EspeceAnimal])
);


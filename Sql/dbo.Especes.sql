CREATE TABLE [dbo].[Especes] (
    [EspeceAnimal]        NVARCHAR (50) NOT NULL,
    [Nombre de spécimène] INT           NULL,
    [Classe]              NVARCHAR (50) NOT NULL,
    [Famille]             NVARCHAR (50) NOT NULL,
    [Sous-famille]        NVARCHAR (50) NOT NULL,
    [régime]              NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Especes] PRIMARY KEY CLUSTERED ([EspeceAnimal] ASC)
);


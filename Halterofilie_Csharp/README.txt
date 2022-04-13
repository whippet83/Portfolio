Dans le Login, nom d'utilisateur = bob et mot de passe = bob

Ne pas oublier de changé la SqlConnection pour votre connexion SQL. Sinon le form MainPage ne fonctionra pas !

Pour les 2 tables de SQL SERVER.

Table Athlete
CREATE TABLE [dbo].[Athlete] (
    [Id_Athlete] INT        NOT NULL,
    [nom]        NCHAR (30) NOT NULL,
    [prenom]     NCHAR (30) NOT NULL,
    [pays]       NCHAR (30) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Athlete] ASC)
);

Table AthletePoids
CREATE TABLE [dbo].[AthletePoids] (
    [Id]         INT        NOT NULL,
    [Tentative1] FLOAT (53) NOT NULL,
    [Tentative2] FLOAT (53) NOT NULL,
    [Tentative3] FLOAT (53) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_IdAthlete] FOREIGN KEY ([Id]) REFERENCES [dbo].[Athlete] ([Id_Athlete])
);
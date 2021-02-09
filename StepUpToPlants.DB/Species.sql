CREATE TABLE [dbo].[Species]
(
	[IdSpecies] INT NOT NULL IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [UsualName] NVARCHAR(50) NOT NULL, 
    [Color] VARCHAR(10) NOT NULL,
    PRIMARY KEY CLUSTERED ([IdSpecies] ASC),
    CONSTRAINT UK_Species_Name UNIQUE ([Name]),
);
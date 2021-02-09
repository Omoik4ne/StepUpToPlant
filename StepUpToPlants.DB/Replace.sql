CREATE TABLE [dbo].[Replace]
(
	[IdReplace] INT NOT NULL IDENTITY,
	[IdPrePlant] INT NOT NULL,
	[IdFollPlant] INT NOT NULL,
	PRIMARY KEY CLUSTERED ([IdReplace] ASC)
);
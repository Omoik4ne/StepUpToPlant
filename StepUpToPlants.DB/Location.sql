CREATE TABLE [dbo].[Location]
(
	[IdLocation] INT NOT NULL IDENTITY,
	[Size] VARCHAR(32) NOT NULL,
	[IdPlant] INT NULL,
	[IdExposure] INT NOT NULL,
	PRIMARY KEY CLUSTERED ([IdLocation] ASC),
	CONSTRAINT [FK_Location_ToPlant] FOREIGN KEY ([IdPlant])
	REFERENCES [dbo].[Plant] ([IdPlant]),
	CONSTRAINT [FK_Location_ToExposure] FOREIGN KEY ([IdExposure]) REFERENCES [dbo].[Exposure] ([IdExposure])
);
CREATE TABLE [dbo].[Exposure]
(
	[IdExposure] INT NOT NULL IDENTITY,
	[IdCardinal] INT NOT NULL,
	[IdUser] INT NOT NULL,
	[IdPlant] INT NOT NULL,
	PRIMARY KEY CLUSTERED ([IdExposure] ASC),
	CONSTRAINT [FK_Exposure_ToCardinal] FOREIGN KEY ([IdCardinal]) REFERENCES [dbo].[Cardinal] ([IdCardinal]),
	CONSTRAINT [FK_Exposure_ToUser] FOREIGN KEY ([IdUser]) REFERENCES [dbo].[User] ([IdUser]),
	CONSTRAINT [FK_Exposure_ToPlant] FOREIGN KEY ([IdPlant]) REFERENCES [dbo].[Plant] ([IdPlant])
);

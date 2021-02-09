CREATE TABLE [dbo].[Plot]
(
	[IdPlot] INT NOT NULL IDENTITY,
	[BegPlant] DATE NOT NULL,
	[EndPlant] DATE NOT NULL,
	[NumPlant] INT NOT NULL,
	[Layout] NVARCHAR(250) NOT NULL,
	[Substrate] VARCHAR(MAX) NULL,
	[Equipement] VARCHAR(MAX) NULL,
	[Status] BIT NOT NULL,
	[IdLocation] INT NOT NULL,
	PRIMARY KEY CLUSTERED ([IdPlot] ASC),
	CONSTRAINT [FK_Plot_ToLocation] FOREIGN KEY ([IdLocation]) REFERENCES [dbo].[Location] ([IdLocation])
);

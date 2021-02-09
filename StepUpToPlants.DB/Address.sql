CREATE TABLE [dbo].[Address]
(
	[IdAddress] INT NOT NULL IDENTITY,
	[Number] VARCHAR(8) NOT NULL,
	[Street] VARCHAR(128) NOT NULL,
	[City] VARCHAR(32) NOT NULL,
	[Country] VARCHAR(32) NOT NULL,
	[Zip] INT NULL,
	[Departement] VARCHAR(32) NULL, 
    PRIMARY KEY ([IdAddress] ASC),
	CONSTRAINT UK_Address UNIQUE ([Number],[Street],[City],[Country],[Zip])
);

use SuperheroesDb
GO

CREATE TABLE Superhero (
	[Id][int] IDENTITY (1,1) PRIMARY KEY (id),
	[Name][nchar](50),
	[Alias][nchar](50),
	[Origin][text]
)

CREATE TABLE Assistant (
	[Id][int] IDENTITY (1,1) PRIMARY KEY (id),
	[Name][nchar](50)
)

CREATE TABLE Power (
	[Id][int]  IDENTITY (1,1) PRIMARY KEY (id),
	[Name][nchar](50),
	[Description][text]
)
GO


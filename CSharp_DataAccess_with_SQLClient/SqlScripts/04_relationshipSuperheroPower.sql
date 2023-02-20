use SuperheroesDb

CREATE TABLE Superhero_Power
(
	[FK_Superhero_Id][int],
	[FK_Power_Id][int]
)
GO

ALTER TABLE Superhero_Power
ADD CONSTRAINT FK_Superhero_Power_SuperheroId
FOREIGN KEY (FK_Superhero_Id)
REFERENCES Superhero(Id);
GO

ALTER TABLE Superhero_Power
ADD CONSTRAINT FK_Superhero_Power_PowerId
FOREIGN KEY (FK_Power_Id)
REFERENCES Power(Id);
GO